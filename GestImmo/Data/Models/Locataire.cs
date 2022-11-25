using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestImmo.Models
{
    public class Locataire
    {

        private string nom;
        private string prenom;
        private int age;
        private string profession;
        private Contrat Contrat;

        public Locataire(string nom, string prenom, int age, string profession)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.age = age;
            this.profession = profession;
        }

        public int LocataireId { get; set; }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public int Age { get => age; set => age = value; }
        public string Profession { get => profession; set => profession = value; }

        public Locataire ajouterLocataire()
        {
            Console.WriteLine("Saisir le nom du locataire:\r");
            string nom = Console.ReadLine();
            Console.WriteLine("Saisir le prenom du locataire:\r");
            int prenom = int.Parse(Console.ReadLine());
            Console.WriteLine("Saisir l'age du locataire:\r");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Saisir la profession du locataire:\r");
            string profession = Console.ReadLine();

            Locataire nvLocataire = new Locataire(nom, profession, age, profession);
            return nvLocataire;
        }

        public void afficher()
        {
            Console.WriteLine("Locataire:" + nom + " " + prenom);
        }
    }
}
