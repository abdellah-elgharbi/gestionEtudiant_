using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Data.Linq;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        private DataContext sqlBd;
        private int selectedStudentId = -1;
        private string connectionString = @"Server=ABDELLAH\SQL2002;Database=ensaj;Integrated Security=True;TrustServerCertificate=True";

        public Form1()
        {
            InitializeComponent();

            // Initialisation
            sqlBd = new DataContext(connectionString);
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.ReadOnly = true;

            ChargerEtudiants();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Event optionnel si tu veux charger les étudiants ici
        }

        private void ChargerEtudiants()
        {
            try
            {
                var etudiants = sqlBd.GetTable<Etudiant>();
                var data = from e in etudiants
                           select new
                           {
                               e.Id,
                               e.Nom,
                               e.Prenom,
                               e.Date_Naissance,
                               e.Email,
                               e.Telephone,
                               e.Filiere,
                               e.Annee,
                               e.Adresse
                           };

                dataGridView1.DataSource = data.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement des étudiants : " + ex.Message);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                var newEtudiant = new Etudiant
                {
                    Nom = nom.Text,
                    Prenom = prenom.Text,
                    Date_Naissance = dateTimePicker1.Value,
                    Email = email.Text,
                    Telephone = tele.Text,
                    Filiere = filiere.Text,
                    Annee = int.Parse(annee.Text),
                    Adresse = adress.Text
                };

                sqlBd.GetTable<Etudiant>().InsertOnSubmit(newEtudiant);
                sqlBd.SubmitChanges();

                MessageBox.Show("Étudiant ajouté avec succès !");
                ChargerEtudiants();
                ResetForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'ajout : " + ex.Message);
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var row = dataGridView1.SelectedRows[0];
                selectedStudentId = Convert.ToInt32(row.Cells["Id"].Value);

                nom.Text = row.Cells["Nom"].Value.ToString();
                prenom.Text = row.Cells["Prenom"].Value.ToString();
                dateTimePicker1.Value = Convert.ToDateTime(row.Cells["Date_Naissance"].Value);
                email.Text = row.Cells["Email"].Value.ToString();
                tele.Text = row.Cells["Telephone"].Value.ToString();
                filiere.Text = row.Cells["Filiere"].Value.ToString();
                annee.Text = row.Cells["Annee"].Value.ToString();
                adress.Text = row.Cells["Adresse"].Value.ToString();

                btnEdit.Enabled = true;
                btnDelete.Enabled = true;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                var etudiant = sqlBd.GetTable<Etudiant>().FirstOrDefault(et => et.Id == selectedStudentId);
                if (etudiant != null)
                {
                    etudiant.Nom = nom.Text;
                    etudiant.Prenom = prenom.Text;
                    etudiant.Date_Naissance = dateTimePicker1.Value;
                    etudiant.Email = email.Text;
                    etudiant.Telephone = tele.Text;
                    etudiant.Filiere = filiere.Text;
                    etudiant.Annee = int.Parse(annee.Text);
                    etudiant.Adresse = adress.Text;

                    sqlBd.SubmitChanges();

                    MessageBox.Show("Étudiant modifié avec succès !");
                    ChargerEtudiants();
                    ResetForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la modification : " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var etudiant = sqlBd.GetTable<Etudiant>().FirstOrDefault(et => et.Id == selectedStudentId);
                if (etudiant != null)
                {
                    var confirm = MessageBox.Show("Voulez-vous vraiment supprimer cet étudiant ?", "Confirmation", MessageBoxButtons.YesNo);
                    if (confirm == DialogResult.Yes)
                    {
                        sqlBd.GetTable<Etudiant>().DeleteOnSubmit(etudiant);
                        sqlBd.SubmitChanges();

                        MessageBox.Show("Étudiant supprimé !");
                        ChargerEtudiants();
                        ResetForm();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la suppression : " + ex.Message);
            }
        }

        private void ResetForm()
        {
            nom.Clear();
            prenom.Clear();
            email.Clear();
            tele.Clear();
            filiere.Clear();
            annee.Clear();
            adress.Clear();
            dateTimePicker1.Value = DateTime.Today;

            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            selectedStudentId = -1;
        }
    }
}
