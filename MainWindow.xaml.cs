using GestImmoGUI.Data.DAL;
using GestImmoGUI.Data.Models;
using GestImmoGUI.Views;
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

namespace GestImmoGUI
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
        }
    }
}
