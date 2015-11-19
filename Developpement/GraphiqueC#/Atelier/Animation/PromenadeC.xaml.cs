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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Animation
{
    /// <summary>
    /// Logique d'interaction pour PromenadeC.xaml
    /// </summary>
    public partial class PromenadeC : Window
    {
        Storyboard[] scn_action = new Storyboard[2];
        
        public PromenadeC()
        {
            InitializeComponent();
        }

        private void btnImage_Click(object sender, RoutedEventArgs e)
        {
            DoubleAnimation deplaceBas = new DoubleAnimation();
            deplaceBas.From = 0;
            deplaceBas.To = 300;
            deplaceBas.Duration = TimeSpan.FromSeconds(2);

            DoubleAnimation deplaceDroite = new DoubleAnimation();
            deplaceDroite.From = 0;
            deplaceDroite.To = 600;
            deplaceDroite.Duration = TimeSpan.FromSeconds(2);

            scn_action[0] = new Storyboard();
            Storyboard.SetTarget(deplaceBas,btnImage);
            Storyboard.SetTargetProperty(deplaceBas, new PropertyPath("(Canvas.Top)"));
            scn_action[0].Children.Add(deplaceBas);

            scn_action[1] = new Storyboard();
            Storyboard.SetTarget(deplaceDroite, btnImage);
            Storyboard.SetTargetProperty(deplaceDroite, new PropertyPath("(Canvas.Left)"));
            scn_action[1].Children.Add(deplaceDroite);

            scn_action[0].Completed += PromenadeC_Completed;

            scn_action[0].Begin();
            

        }

        private void PromenadeC_Completed(object sender, EventArgs e)
        {
            scn_action[1].Begin();
        }
    }
}
