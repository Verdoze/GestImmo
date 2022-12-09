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

namespace GestImmo.Views.Forms
{
    /// <summary>
    /// Logique d'interaction pour GererBienForm.xaml
    /// </summary>
    public partial class GererBienForm : Page
    {
        private IObserver obs;
        public GererBienForm(IObserver obs)
        {
            InitializeComponent();
            this.obs = obs;
        }
        private void TypeBien_ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (TypeBien_ComboBox.SelectedIndex == 0)
            {
                GererAppartementForm gererAppartementForm = new GererAppartementForm();
                gererAppartementForm.Observers.Add(this.obs);
                this.Frame_Ajouter_Bien.Navigate(gererAppartementForm);
            }
            else if (TypeBien_ComboBox.SelectedIndex == 1)
            {  
                GererMaisonForm gererMaisonForm = new GererMaisonForm();
                gererMaisonForm.Observers.Add(this.obs);
                this.Frame_Ajouter_Bien.Navigate(gererMaisonForm);
            }
            if (TypeBien_ComboBox.SelectedIndex == 2)
            {
                GererBoxForm gererBoxForm = new GererBoxForm();
                gererBoxForm.Observers.Add(this.obs);
                this.Frame_Ajouter_Bien.Navigate(gererBoxForm);
            }
        }
    }
}
