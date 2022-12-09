using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestImmo.Models
{
    public class Contrat
    {   
        public int ContratId { get; set; }
        private int coutLoyer;
        private string dateDebut;
        private string dateFin;
        private List<Locataire> listeLocataire = new List<Locataire>();

        public Contrat()
        {

        }
        public Contrat(int coutLoyer, string dateDebut, string dateFin, List<Locataire> listeLocataire)
        {
            this.coutLoyer = coutLoyer;
            this.dateDebut = dateDebut;
            this.dateFin = dateFin;
            this.listeLocataire = new List<Locataire>();
        }

        public int CoutLoyer { get => coutLoyer; set => coutLoyer = value; }
        public string DateDebut { get => dateDebut; set => dateDebut = value; }
        public string DateFin { get => dateFin; set => dateFin = value; }
        internal List<Locataire> ListeLocataire { get => listeLocataire; set => listeLocataire = value; }

        public void afficher()
        {
            Console.WriteLine("====Bail======");
            Console.WriteLine("Loyer:" + coutLoyer);
            foreach (Locataire item in listeLocataire)
            {
                item.afficher();
            }
        }
    }
}
