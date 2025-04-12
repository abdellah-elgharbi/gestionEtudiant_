using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    [Table(Name = "etudiants")]
    public class Etudiant
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int Id { get; set; }

        [Column]
        public string Nom { get; set; }

        [Column]
        public string Prenom { get; set; }

        [Column]
        public DateTime Date_Naissance { get; set; }

        [Column]
        public string Email { get; set; }

        [Column]
        public string Telephone { get; set; }

        [Column]
        public string Filiere { get; set; }

        [Column]
        public int Annee { get; set; }

        [Column]
        public string Adresse { get; set; }
    }

}
