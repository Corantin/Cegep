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
using MySql.Data.MySqlClient;

namespace BDServices
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            BDService MaBd = new BDService();

            //MaBd.Insert("INSERT INTO Membres VALUES(444,'Albert','Einstein','Le culte de la personalité reste à mes yeux toujours injustifié')");
            //MaBd.Insert("INSERT INTO Membres VALUES(222,'Charles','Dickens','Les plus jolies choses du monde ne sont que des ombres.')");
            //MaBd.Insert("INSERT INTO Membres VALUES(111,'Josianne','Fortin','Quand le petit chie dans le cadran, les aiguilles tournent dans la marde')");

            List<string>[] retour = MaBd.Select("SELECT * FROM Membres;");
            MessageBox.Show(retour[0][3]);

            
        }
    }
}
