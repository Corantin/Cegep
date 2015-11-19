using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace Binding4
{
    class Club
    {
        public List<Membre> lstMembre { get; set; }
        public Club()
        {
            lstMembre = new List<Membre>();
            lstMembre.Add(new Membre()
            {
                _numero = 1,
                _nom = "Albert",
                _image = new BitmapImage(new Uri("pack://application:,,,/Image/a.jpg")),
                _participation = 100,
                _inviter = true
            });
            lstMembre.Add(new Membre()
            {
                _numero = 2,
                _nom = "Bob",
                _image = new BitmapImage(new Uri("pack://application:,,,/Image/b.jpg")),
                _participation = 200,
                _inviter = true
            });
            lstMembre.Add(new Membre()
            {
                _numero = 3,
                _nom = "Charlotte",
                _image = new BitmapImage(new Uri("pack://application:,,,/Image/c.jpg")),
                _participation = 300,
                _inviter = true
            });
            lstMembre.Add(new Membre()
            {
                _numero = 4,
                _nom = "Enrique",
                _image = new BitmapImage(new Uri("pack://application:,,,/Image/d.jpg")),
                _participation = 400,
                _inviter = false
            });
            lstMembre.Add(new Membre()
            {
                _numero = 5,
                _nom = "Charlie",
                _image = new BitmapImage(new Uri("pack://application:,,,/Image/e.jpg")),
                _participation = 500,
                _inviter = true
            });
        }
    }
}
