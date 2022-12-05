using GestImmo.Views.SubViews;
using Serilog;
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

namespace GestImmo.Views
{
    /// <summary>
    /// Logique d'interaction pour NavigationView.xaml
    /// </summary>
    public partial class NavigationView : Page
    {
        public NavigationView()
        {
            InitializeComponent();
            this.MainFrame.Navigate(new HomeView());
            Log.Logger.Verbose("Changement de page vers Menu");

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {   
            this.MainFrame.Navigate(new BienView());
            Log.Logger.Verbose("Changement de page vers Bien");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.MainFrame.Navigate(new PretView());
            Log.Logger.Verbose("Changement de page vers Pret");
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.MainFrame.Navigate(new PrestataireView());
            Log.Logger.Verbose("Changement de page vers Prestataire");
        }
    }
}
