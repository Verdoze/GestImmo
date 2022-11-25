using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestImmo.Models
{
    public class Appartement : Logement
    {
        public int AppartementId { get; set; }
        private int etage;
        private string ascenseur;
        private string chauffage;

        public Appartement()
        {
        }

        public Appartement(string nomBien, int valeur, int surface, string adresse, Pret prets, List<Contrat> listeContrat, List<Intervention> listeIntervention, int nbPiece, int nbChambre, int cave, int parking, int etage, string ascenseur, string chauffage)
            : base(nomBien, valeur, surface, adresse, prets, listeContrat, listeIntervention, nbPiece, nbChambre, cave, parking)
        {
            this.etage = etage;
            this.ascenseur = ascenseur;
            this.chauffage = chauffage;
        }
        public int Etage { get => etage; set => etage = value; }
        public string Ascenseur { get => ascenseur; set => ascenseur = value; }
        public string Chauffage { get => chauffage; set => chauffage = value; }
    }   
}

