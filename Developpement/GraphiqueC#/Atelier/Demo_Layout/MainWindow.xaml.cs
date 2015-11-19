using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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
using General;

namespace Demo_Layout
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

        private void OuvrirCanvas(object sender, RoutedEventArgs e)
        {
            Outil.OuvrirEcran(this, "Canvas", true, true);
        }

        private void OuvrirGrid(object sender, RoutedEventArgs e)
        {
            Outil.OuvrirEcran(this, "Grid", true, false);
        }

        private void OuvrirStack(object sender, RoutedEventArgs e)
        {
            Outil.OuvrirEcran(this,"Stack",false,true);
        }

        private void OuvrirWrap(object sender, RoutedEventArgs e)
        {
            Outil.OuvrirEcran(this, "Wrap", false, false);
        }



    }
}
