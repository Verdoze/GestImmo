using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestImmo.Models
{
    public class Pret
    {
        public int PretId { get; set; }   
        private int montant;
        private int apport;
        private string duree;
        private int tauxInteret;

        public Pret(int montant, int apport, string duree, int tauxInteret)
        {
            this.montant = montant;
            this.apport = apport;
            this.duree = duree;
            this.tauxInteret = tauxInteret;
        }

        public int Montant { get => montant; set => montant = value; }
        public int Apport { get => apport; set => apport = value; }
        public string Duree { get => duree; set => duree = value; }
        public int TauxInteret { get => tauxInteret; set => tauxInteret = value; }
    }
}
