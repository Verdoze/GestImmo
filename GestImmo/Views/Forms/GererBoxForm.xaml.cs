using GestImmo.Data.DAL;
using GestImmo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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
    /// Logique d'interaction pour GererBoxForm.xaml
    /// </summary>
    public partial class GererBoxForm : Page, IObservable
    {
        public List<IObserver> Observers { get; set; }
        public GererBoxForm()
        {
            InitializeComponent();
            this.Observers = new List<IObserver>();
            
        }        

        private void Bouton_Ajouter_Bien_Click(object sender, RoutedEventArgs e)
        {
            
            if (NomBien_TextBox.Text != "" && ValeurBien_TextBox.Text != "" && AdresseBien_TextBox.Text != "" && SurfaceBien_TextBox.Text != "")
            {
                string nom = NomBien_TextBox.Text;
                int valeur = int.Parse(ValeurBien_TextBox.Text);
                string adresse = AdresseBien_TextBox.Text;
                int surface = int.Parse(SurfaceBien_TextBox.Text);


                Box unBox = new Box(nom, valeur, surface, adresse, null, null, null);
                ImmoContext ctx = ImmoContext.getInstance();
                ctx.Bien.Add(unBox);
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
           
            foreach(IObserver obs in Observers)
            {
                obs.update();
            }
        }
    }
}
