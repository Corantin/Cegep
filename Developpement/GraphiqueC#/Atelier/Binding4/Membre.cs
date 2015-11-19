using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace Binding4
{
    class Membre
    {
        public int _numero { get; set; }
        public string _nom { get; set; }
        public int _participation { get; set; }
        public BitmapImage _image { get; set; }
        public bool _inviter { get; set; }
    }
}
