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

namespace Binding
{
    /// <summary>
    /// La date ne marche pas !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
    /// </summary>
    public partial class MainWindow : Window
    {
        private Rencontre _rencontre;

        public MainWindow()
        {
            
            InitializeComponent();
            _rencontre = new Rencontre()
            {
                Sujet = "Discussion du budget",
                Date = DateTime.Now
            };
            RencontreDate.SelectedDate = _rencontre.Date;
            RencontreSujet.Text = _rencontre.Sujet;
            _rencontre.PropertyChanged += Event_PropertyChanged;
        }

        private void Event_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "Sujet")
            {
                RencontreSujet.Text = _rencontre.Sujet;
            }
            else
            {
                RencontreDate.SelectedDate = _rencontre.Date;
            }
        }


        private void AfficherModele_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(_rencontre.Sujet+" "+_rencontre.Date);
        }


        private void ModifierModele_Click(object sender, RoutedEventArgs e)
        {
            _rencontre.Sujet = "Brainstorm";
            _rencontre.Date = new DateTime(1996, 05, 23);


        }

        private void RencontreSujet_TextChanged(object sender, TextChangedEventArgs e)
        {
            _rencontre.Sujet = RencontreSujet.Text;
        }

        private void RencontreDate_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            _rencontre.Date = RencontreDate.SelectedDate.Value;
        }
    }
}
