using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestImmo.Models
{
    public class Bien
    {
        public int BienId { get; set; }
        private string nomBien;
        private int valeur;
        private int surface;
        private string adresse;
        private Pret? pret;
        private List<Contrat>? listeContrat { get; set;}
        private List<Intervention>? listeIntervention {get; set;}

        public Bien()
        {

        }
        public Bien(string nomBien, int valeur, int surface, string adresse, Pret pret, List<Contrat> listeContrat)
        {

            this.nomBien = nomBien;
            this.valeur = valeur;
            this.surface = surface;
            this.adresse = adresse;
            this.listeContrat = listeContrat;
            this.listeIntervention = listeIntervention;
        }
        public Bien(string nomBien, int valeur, int surface, string adresse)
        {

            this.nomBien = nomBien;
            this.valeur = valeur;
            this.surface = surface;
            this.adresse = adresse;
            listeContrat = new List<Contrat>();

        }

        public Bien(string nomBien, int valeur, int surface, string adresse, Pret pret, List<Contrat> listeContrat, List<Intervention> listeIntervention) 
            : this(nomBien, valeur, surface, adresse, pret, listeContrat)
        {
            this.listeIntervention = listeIntervention;
        }

        public string NomBien { get => nomBien; set => nomBien = value; }
        public int Valeur { get => valeur; set => valeur = value; }
        public int Surface { get => surface; set => surface = value; }
        public string Adresse { get => adresse; set => adresse = value; }
        public List<Contrat> ListeContrat { get => listeContrat; set => listeContrat = value; }
        public List<Intervention> ListeIntervention { get => listeIntervention; set => listeIntervention = value; }

        /*public void afficherInfos()
        {
            Console.WriteLine("======= " + nomBien + " =======\r");
            Console.WriteLine("Adresse: " + adresse + "\r");
            Console.WriteLine("Surface: " + surface.ToString() + " m2\r");
            Console.WriteLine("Valeur: " + valeur.ToString() + "euros\r");
            if (listeContrat != null)
            {

            }

        }

        public static Bien ajouterBien()
        {

            Console.WriteLine("Saisir le nom du bien:\r");
            string nom = Console.ReadLine();
            Console.WriteLine("Saisir la valeur du bien:\r");
            int valeur = int.Parse(Console.ReadLine());
            Console.WriteLine("Saisir la surface du bien:\r");
            int surface = int.Parse(Console.ReadLine());
            Console.WriteLine("Saisir l'adresse du bien:\r");
            string adresse = Console.ReadLine();

            Bien bien = new Bien(nom, valeur, surface, adresse, null, null, null);
            return bien;

        }

        public void ajouterPret()
        {

        }*/
    }
}
