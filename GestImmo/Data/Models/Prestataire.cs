using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestImmo.Models
{
    public class Prestataire
    {
        public int PrestataireId { get; set; }
        private string nom;
        private string prenom;
        private string raisonSociale;
        private string telephone;
        private string adresse;
        private List<Intervention> Interventions { get; set; }

        public Prestataire()
        {

        }
        public Prestataire(string nom, string prenom, string raisonSociale, string telephone, string adresse)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.raisonSociale = raisonSociale;
            this.telephone = telephone;
            this.adresse = adresse;
        }

        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public string RaisonSociale { get => raisonSociale; set => raisonSociale = value; }
        public string Telephone { get => telephone; set => telephone = value; }
        public string Adresse { get => adresse; set => adresse = value; }
    }
}
