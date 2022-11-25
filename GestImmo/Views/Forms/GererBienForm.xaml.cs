﻿using System;
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
        public GererBienForm()
        {
            InitializeComponent();
        }
        private void TypeBien_ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (TypeBien_ComboBox.SelectedIndex == 0)
            {
                this.Frame_Ajouter_Bien.Navigate(new GererAppartementForm());
            }
            else if (TypeBien_ComboBox.SelectedIndex == 1)
            {
                this.Frame_Ajouter_Bien.Navigate(new GererMaisonForm());
            }
            if (TypeBien_ComboBox.SelectedIndex == 2)
            {
                this.Frame_Ajouter_Bien.Navigate(new GererBoxForm());
            }
        }
    }
}
