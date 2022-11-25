
using GestImmo.Data.DAL;
using GestImmo.Models;
using GestImmo.Views;
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


namespace GestImmo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            // ligne à ajouter pour la compatibilité des dates
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);

            InitializeComponent();
            this.Content = new NavigationView();

            ImmoContext ImmoContext = new ImmoContext();
            ImmoContext ctx = ImmoContext.getInstance();

            Pret pret1 = new Pret(100000, 15000, "11/10/2032", 1);
            ctx.Pret.Add(pret1);
            ctx.SaveChanges();
        }
    }
}
