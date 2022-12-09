using GestImmo.Data.DAL;
using GestImmo.Models;
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

namespace GestImmo.Views.SubViews
{
    /// <summary>
    /// Logique d'interaction pour ListBienView.xaml
    /// </summary>
    public partial class ListBienView : Page, IObserver
    {   
        ImmoContext ctx = ImmoContext.getInstance();
        

        public ListBienView()
        {
            InitializeComponent();
            this.updateList();
        }

        private void updateList()
        {
            
            ImmoContext ctx = ImmoContext.getInstance();

            this.ListBienView_Section.Items.Clear();

            foreach (Bien bien in ctx.Bien)
            {
                this.ListBienView_Section.Items.Add(bien.NomBien);
            }
        }

        public void update()
        {
            this.updateList();
        }
    }
}
