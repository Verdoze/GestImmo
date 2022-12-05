
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
using Serilog;
using System.Diagnostics.Eventing.Reader;

namespace GestImmo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Content = new NavigationView();

            ImmoContext ImmoContext = new ImmoContext();
            ImmoContext ctx = ImmoContext.getInstance();

            Log.Logger = new LoggerConfiguration().MinimumLevel.Verbose()
                                                    .WriteTo.File("../../../../logs.txt")
                                                    .WriteTo.Console(restrictedToMinimumLevel: Serilog.Events.LogEventLevel.Debug)
                                                    .CreateLogger();
            Log.Logger.Information("Bienvenue dans la LOG ZONE");
        }

    }
}
