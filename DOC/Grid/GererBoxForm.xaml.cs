using GestImmoGUI.Data.DAL;
using GestImmoGUI.Data.Models;
using GestImmoGUI.Views.Utils;
using System;
using System.Collections.Generic;
using System.Configuration;
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

namespace GestImmoGUI.Views.Forms
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

        private void btnAjouter_Click(object sender, RoutedEventArgs e)
        {
            string nom = this.txtNom.Text;
            int valeur = int.Parse(this.txtValeur.Text);
            string adresse = this.txtAdresse.Text;
            int surface = int.Parse(this.txtSurface.Text);

            Box box = new Box(nom, valeur, adresse, surface);
            GestImmoContext ctx = GestImmoContext.getInstance();
            ctx.Biens.Add(box);
            ctx.SaveChanges();

            this.notifyObservers();
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
