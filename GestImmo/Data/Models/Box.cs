using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestImmo.Models
{
    public class Box : Bien
    {
        public int BoxId {get; set; }

        public Box()
        {

        }
        public Box(string nomBien, int valeur, int surface, string adresse, Pret pret, List<Contrat> listeContrat, List<Intervention> listeIntervention) 
                :base(nomBien, valeur, surface, adresse, pret, listeContrat,listeIntervention)
        {

        }
    }
}
