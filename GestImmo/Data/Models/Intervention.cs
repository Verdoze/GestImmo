using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestImmo.Models
{
    public class Intervention
    {
        public int InterventionId { get; set; }
        private string dateIntervention;
        private int montantTTC;
        private string information;
        private List<Prestataire>? prestataires { get; set; }
        private Bien? bien { get; set; }

        public Intervention()
        {

        }
        public Intervention(string dateIntervention, int montantTTC, string information, List<Prestataire> listePresta, Bien bien)
        {
            this.dateIntervention = dateIntervention;
            this.montantTTC = montantTTC;
            this.information = information;
            this.prestataires = prestataires;
            this.bien = bien;   
        }

        public string DateIntervention { get => dateIntervention; set => dateIntervention = value; }
        public int MontantTTC { get => montantTTC; set => montantTTC = value; }
        public string Information { get => information; set => information = value; }
    }
}
