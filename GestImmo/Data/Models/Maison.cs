using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestImmo.Models
{
    public class Maison : Logement
    {
        public int MaisonID { get; set; }

        public Maison()
        {

        }
        public Maison(string nomBien, int valeur, int surface, string adresse, Pret pret, List<Contrat> listeContrat, List<Intervention> listeIntervention, int nbPiece, int nbChambre, int cave, int parking)
            : base(nomBien, valeur, surface, adresse, pret, listeContrat, listeIntervention, nbPiece, nbChambre, cave, parking)
        {

        }
    }
}
