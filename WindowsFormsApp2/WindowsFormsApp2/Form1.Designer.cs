using System.Windows.Forms;

namespace WindowsFormsApp2
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Drawing.Font font = new System.Drawing.Font("Segoe UI", 10F);

            this.nom = new System.Windows.Forms.TextBox()
            {
                Location = new System.Drawing.Point(160, 60),
                Size = new System.Drawing.Size(200, 25),
                Font = font,
            };

            this.prenom = new System.Windows.Forms.TextBox()
            {
                Location = new System.Drawing.Point(160, 100),
                Size = new System.Drawing.Size(200, 25),
                Font = font,
            };

            this.email = new System.Windows.Forms.TextBox()
            {
                Location = new System.Drawing.Point(160, 140),
                Size = new System.Drawing.Size(200, 25),
                Font = font,
            };

            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker()
            {
                Location = new System.Drawing.Point(160, 180),
                Size = new System.Drawing.Size(200, 25),
                Font = font,
            };

            this.tele = new System.Windows.Forms.TextBox()
            {
                Location = new System.Drawing.Point(480, 60),
                Size = new System.Drawing.Size(200, 25),
                Font = font,
            };

            this.filiere = new System.Windows.Forms.TextBox()
            {
                Location = new System.Drawing.Point(480, 100),
                Size = new System.Drawing.Size(200, 25),
                Font = font,
            };

            this.annee = new System.Windows.Forms.TextBox()
            {
                Location = new System.Drawing.Point(480, 140),
                Size = new System.Drawing.Size(200, 25),
                Font = font,
            };

            this.adress = new System.Windows.Forms.TextBox()
            {
                Location = new System.Drawing.Point(480, 180),
                Size = new System.Drawing.Size(200, 60),
                Font = font,
                Multiline = true
            };

            this.button1 = new System.Windows.Forms.Button()
            {
                Text = "Ajouter",
                BackColor = System.Drawing.Color.MediumSeaGreen,
                ForeColor = System.Drawing.Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = font,
                Location = new System.Drawing.Point(220, 260),
                Size = new System.Drawing.Size(100, 35)
            };
            this.button1.Click += new System.EventHandler(this.button1_Click_1);

            this.btnEdit = new System.Windows.Forms.Button()
            {
                Text = "Modifier",
                BackColor = System.Drawing.Color.SteelBlue,
                ForeColor = System.Drawing.Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = font,
                Location = new System.Drawing.Point(330, 260),
                Size = new System.Drawing.Size(100, 35)
            };
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);

            this.btnDelete = new System.Windows.Forms.Button()
            {
                Text = "Supprimer",
                BackColor = System.Drawing.Color.IndianRed,
                ForeColor = System.Drawing.Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = font,
                Location = new System.Drawing.Point(440, 260),
                Size = new System.Drawing.Size(100, 35)
            };
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

            this.dataGridView1 = new System.Windows.Forms.DataGridView()
            {
                Location = new System.Drawing.Point(40, 320),
                Size = new System.Drawing.Size(700, 130),
                BackgroundColor = System.Drawing.Color.WhiteSmoke,
                Font = font,
                SelectionMode = DataGridViewSelectionMode.FullRowSelect,
                ReadOnly = true
            };
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);

            // Titre principal
            this.label9 = new System.Windows.Forms.Label()
            {
                Text = "Gestion des Étudiants - ENSAJ",
                Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold),
                Location = new System.Drawing.Point(200, 15),
                AutoSize = true
            };

            // Labels
            AddLabel("Nom :", 90, 60);
            AddLabel("Prénom :", 90, 100);
            AddLabel("Email :", 90, 140);
            AddLabel("Date de naissance :", 20, 180);

            AddLabel("Téléphone :", 390, 60);
            AddLabel("Filière :", 390, 100);
            AddLabel("Année :", 390, 140);
            AddLabel("Adresse :", 390, 180);

            // Ajouter les contrôles
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                nom, prenom, email, dateTimePicker1,
                tele, filiere, annee, adress,
                button1, btnEdit, btnDelete,
                dataGridView1, label9
            });

            this.ClientSize = new System.Drawing.Size(800, 480);
            this.Name = "Form1";
            this.Text = "Gestion Étudiants";
            this.Load += new System.EventHandler(this.Form1_Load);
        }

        private void AddLabel(string text, int x, int y)
        {
            this.Controls.Add(new System.Windows.Forms.Label()
            {
                Text = text,
                Font = new System.Drawing.Font("Segoe UI", 10F),
                Location = new System.Drawing.Point(x, y),
                AutoSize = true
            });
        }

        #endregion

        private System.Windows.Forms.TextBox nom;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox prenom;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox tele;
        private System.Windows.Forms.TextBox filiere;
        private System.Windows.Forms.TextBox annee;
        private System.Windows.Forms.TextBox adress;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label9;
    }
}
