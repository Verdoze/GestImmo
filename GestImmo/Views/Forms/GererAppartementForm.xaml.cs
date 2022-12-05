using GestImmo.Data.DAL;
using GestImmo.Models;
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
using static System.Net.Mime.MediaTypeNames;

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

        private void Bouton_Ajouter_Bien_Click(object sender, RoutedEventArgs e)
        {
            

            if (NomBien_TextBox.Text != "" && ValeurBien_TextBox.Text!= "" && AdresseBien_TextBox.Text !="" && SurfaceBien_TextBox.Text != "" && Etage_Textbox.Text !="" && ChambresBien_TextBox.Text!= "" && PiecesBien_TextBox.Text != "" && Ascenseur_TextBox.Text != "" && Chauffage_TextBox.Text != "" && Parking_TextBox.Text != "" && Cave_TextBox.Text!= "")
            {
                Log.Logger.Verbose("Entrée dans la fonction de création d'appartement");
                string nom = NomBien_TextBox.Text;
                int valeur = int.Parse(ValeurBien_TextBox.Text);
                string adresse = AdresseBien_TextBox.Text;
                int surface = int.Parse(SurfaceBien_TextBox.Text);
                int etage = int.Parse(Etage_Textbox.Text);
                int nbChambres = int.Parse(ChambresBien_TextBox.Text);
                int nbPieces = int.Parse(PiecesBien_TextBox.Text);
                string ascenseur = Ascenseur_TextBox.Text;
                string chauffage = Chauffage_TextBox.Text;
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

                Appartement unAppartement = new Appartement(nom, valeur, surface, adresse, null, null,null, nbPieces, nbChambres, cave, parking, etage, ascenseur, chauffage);
                ImmoContext ctx = ImmoContext.getInstance();
                ctx.Bien.Add(unAppartement);
                ctx.SaveChanges();
                MessageBox.Show("Ajouté avec succès");
                Log.Logger.Information("Ajout de l'appartement : " + nom + "-" + adresse);
            }
            else
            {
                MessageBox.Show("Un ou plusieurs des champs n'a pas été correctement rempli.");
            }
        }
    }   
}
