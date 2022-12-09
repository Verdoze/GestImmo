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
        private bool ascenseur;
        private bool chauffage;

        public Appartement()
        {

        }
        public Appartement(string nomBien, int valeur, int surface, string adresse, Pret prets, List<Contrat> listeContrat,int nbPiece, int nbChambre, int cave, int parking, int etage, bool ascenseur, bool chauffage)
            : base(nomBien, valeur, surface, adresse, prets, listeContrat, nbPiece, nbChambre, cave, parking)
        {
            this.etage = etage;
            this.ascenseur = ascenseur;
            this.chauffage = chauffage;
        }

        public int Etage { get => etage; set => etage = value; }
        public bool Ascenseur { get => ascenseur; set => ascenseur = value; }
        public bool Chauffage { get => chauffage; set => chauffage = value; }
    }
}
