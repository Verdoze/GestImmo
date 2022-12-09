using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestImmo.Models
{
    public class Logement : Bien
    {
        public int LogementId { get; set; }
        private int nbPiece;
        private int nbChambre;
        private int cave;
        private int parking;

        public Logement()
        {

        }
        public Logement(string nomBien, int valeur, int surface, string adresse, Pret pret, List<Contrat> listeContrat, List<Intervention> listeIntervention, int nbPiece, int nbChambre, int cave, int parking)
            : base(nomBien, valeur, surface, adresse, pret, listeContrat, listeIntervention)
        {          
            this.nbPiece = nbPiece;
            this.nbChambre = nbChambre;
            this.cave = cave;
            this.parking = parking;
        }

        public int NbPiece { get => nbPiece; set => nbPiece = value; }
        public int NbChambre { get => nbChambre; set => nbChambre = value; }
        public int Cave { get => cave; set => cave = value; }
        public int Parking { get => parking; set => parking = value; }
    }
}
