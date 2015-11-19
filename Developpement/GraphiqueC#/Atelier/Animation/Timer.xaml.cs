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
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Animation
{
    /// <summary>
    /// Logique d'interaction pour Timer.xaml
    /// </summary>
    public partial class Timer : Window
    {
        DispatcherTimer gereAgrandit = new DispatcherTimer();
        DispatcherTimer gereRetreci = new DispatcherTimer();

        DispatcherTimer gereMoveRight = new DispatcherTimer();
        DispatcherTimer gereMoveLeft = new DispatcherTimer();
        DispatcherTimer gereMoveTop = new DispatcherTimer();
        DispatcherTimer gereMoveBottom = new DispatcherTimer();

        int deplacementH = 0;
        int deplacementV = 0;
        int largeur = 40;

        public Timer()
        {
            InitializeComponent();
            gereAgrandit.Tick += gereAgrandit_Tick;
            gereAgrandit.Interval = TimeSpan.FromMilliseconds(100);

            gereRetreci.Tick += gereRetreci_Tick;
            gereRetreci.Interval = TimeSpan.FromMilliseconds(100);


            gereMoveRight.Tick += gereMoveRight_Tick;
            gereMoveRight.Interval = TimeSpan.FromMilliseconds(50);

            gereMoveLeft.Tick += gereMoveLeft_Tick;
            gereMoveLeft.Interval = TimeSpan.FromMilliseconds(50);

            gereMoveTop.Tick += gereMoveTop_Tick;
            gereMoveTop.Interval = TimeSpan.FromMilliseconds(50);

            gereMoveBottom.Tick += gereMoveBottom_Tick;
            gereMoveBottom.Interval = TimeSpan.FromMilliseconds(50);


        }

        private void gereMoveBottom_Tick(object sender, EventArgs e)
        {
            if (deplacementV <= 500)
            {
                deplacementV += 10;
                Canvas.SetTop(imgChat, deplacementV);
            }
        }

        private void gereMoveTop_Tick(object sender, EventArgs e)
        {
            if (deplacementV > 0)
            {
                deplacementV -= 10;
                Canvas.SetTop(imgChat, deplacementV);
            }
        }

        private void gereMoveLeft_Tick(object sender, EventArgs e)
        {
            if (deplacementH > 0)
            {
                deplacementH -= 10;
                Canvas.SetLeft(imgChat, deplacementH);
            }
        }

        private void gereMoveRight_Tick(object sender, EventArgs e)
        {
            if (deplacementH < 700)
            {
                deplacementH += 10;
                Canvas.SetLeft(imgChat,deplacementH);
            }

        }

        private void gereRetreci_Tick(object sender, EventArgs e)
        {
            if (largeur >= 0)
            {
                largeur -= 10;
                imgChat.Width = largeur;
            }
        }

        private void gereAgrandit_Tick(object sender, EventArgs e)
        {
            if (largeur <= 700)
            {
                largeur += 10;
                imgChat.Width = largeur;
            }
        }

        private void btnAgrandir_Click(object sender, RoutedEventArgs e)
        {
            gereRetreci.Stop();
            gereAgrandit.Start();
        }

        private void btnRetreci_Click(object sender, RoutedEventArgs e)
        {
            gereAgrandit.Stop();
            gereRetreci.Start();
        }

        private void btnMoveRight_Click(object sender, RoutedEventArgs e)
        {
            gereMoveLeft.Stop();
            gereMoveTop.Stop();
            gereMoveBottom.Stop();
            gereMoveRight.Start();
        }

        private void btnMoveLeft_Click(object sender, RoutedEventArgs e)
        {
            gereMoveRight.Stop();
            gereMoveTop.Stop();
            gereMoveBottom.Stop();
            gereMoveLeft.Start();
        }

        private void btnMoveTop_Click(object sender, RoutedEventArgs e)
        {
            gereMoveRight.Stop();
            gereMoveLeft.Stop();
            gereMoveBottom.Stop();
            gereMoveTop.Start();
        }

        private void btnMoveBottom_Click(object sender, RoutedEventArgs e)
        {
            gereMoveRight.Stop();
            gereMoveTop.Stop();
            gereMoveTop.Stop();
            gereMoveBottom.Start();
        }
    }
}
