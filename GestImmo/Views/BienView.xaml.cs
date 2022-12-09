using GestImmo.Views.Forms;
using GestImmo.Views.SubViews;
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
    /// Logique d'interaction pour BienView.xaml
    /// </summary>
    public partial class BienView : Page
    {
        public BienView()
        {
            InitializeComponent();
            ListBienView BienView = new ListBienView();
            this.Consulter_Bien.Navigate(BienView);
            this.Ajouter_Bien.Navigate(new GererBienForm());

        }

        private void Frame_Navigated_1(object sender, NavigationEventArgs e)
        {
        }

        private void Frame_Navigated(object sender, NavigationEventArgs e)
        {
        }
    }
}
