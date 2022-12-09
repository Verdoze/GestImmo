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
    /// Logique d'interaction pour GererAppartementForm.xaml
    /// </summary>
    public partial class GererAppartementForm : Page
    {
        public GererAppartementForm()
        {
            InitializeComponent();
        }

        /*private void Bouton_Ajouter_Bien_Click(object sender, RoutedEventArgs e)
        {
            if(NomBien_TextBox.Text != "" && ValeurBien_TextBox.Text != "" && AdresseBien_TextBox.Text != "" && SurfaceBien_TextBox.Text != "" && Etage_Textbox.Text != "" && Ascenseur_TextBox.Text != "" && Chauffage_TextBox.Text != "")
            {
                Appartement unAppart = new Appartement(NomBien_TextBox.Text, int.Parse(ValeurBien_TextBox.Text), int.Parse(SurfaceBien_TextBox.Text), int.Parse(Etage_Textbox.Text), Ascenseur_TextBox.Text, Chauffage_TextBox.Text);
            }
            else
            {
                MessageBox.Show("Un ou plusieurs champs sont vides.");
            }
        }*/
    }   
}
