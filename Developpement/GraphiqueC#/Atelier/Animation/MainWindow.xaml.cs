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

namespace Animation
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private void StretchImage_Click(object sender, RoutedEventArgs e)
        {
            General.Outil.OuvrirEcran(this,"StretchImage",true,false);
        }

        private void AvecTimer_Click(object sender, RoutedEventArgs e)
        {
            General.Outil.OuvrirEcran(this, "Timer", true, false);
        }

        private void PromenadeC_Click(object sender, RoutedEventArgs e)
        {
            General.Outil.OuvrirEcran(this, "PromenadeC", true, false);
        }

        private void PromenadeXAML_Click(object sender, RoutedEventArgs e)
        {
            General.Outil.OuvrirEcran(this, "PromenadeXaml", true, false);
        }
    }
}
