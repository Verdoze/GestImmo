using GestImmo.Data.DAL;
using GestImmo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GestImmo.Views.Forms
{
    /// <summary>
    /// Logique d'interaction pour GererMaisonForm.xaml
    /// </summary>
    public partial class GererMaisonForm : Page, IObservable
    {
        public List<IObserver> Observers { get; set; }
        public GererMaisonForm()
        {
            InitializeComponent();
            this.Observers = new List<IObserver>();
        }

        

        private void Bouton_Ajouter_Bien_Click(object sender, RoutedEventArgs e)
        {
            if (NomBien_TextBox.Text != "" && ValeurBien_TextBox.Text != "" && AdresseBien_TextBox.Text != "" && SurfaceBien_TextBox.Text != "" && ChambresBien_TextBox.Text != "" && PiecesBien_TextBox.Text != "" && Parking_TextBox.Text != "" && Cave_TextBox.Text != "")
            {
                string nom = NomBien_TextBox.Text;
                int valeur = int.Parse(ValeurBien_TextBox.Text);
                string adresse = AdresseBien_TextBox.Text;
                int surface = int.Parse(SurfaceBien_TextBox.Text);
                int nbChambres = int.Parse(ChambresBien_TextBox.Text);
                int nbPieces = int.Parse(PiecesBien_TextBox.Text);
                int cave = int.Parse(Cave_TextBox.Text);
                int parking = int.Parse(Parking_TextBox.Text);

                /*bool chauffage = false;
                if (Chauffage_TextBox.Text == 1)
                {
                    chauffage = true;
                }
                bool ascenseur = false;
                if (Ascenseur_TextBox.Text == 1)
                {
                    ascenseur = true;
                }*/

                Maison uneMaison = new Maison(nom, valeur, surface, adresse, null, null, null, nbPieces, nbChambres, cave, parking);
                ImmoContext ctx = ImmoContext.getInstance();
                ctx.Bien.Add(uneMaison);
                ctx.SaveChanges();

                this.notifyObservers();

                MessageBox.Show("Ajouté avec succès!");
            }
            else
            {
                MessageBox.Show("Un ou plusieurs des champs n'a pas été correctement rempli.");
            }
        }
        void notifyObservers()
        {
            foreach (IObserver obs in Observers)
            {
                obs.update();
            }
        }
    }
}
