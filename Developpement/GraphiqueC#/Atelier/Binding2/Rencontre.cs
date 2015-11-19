using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Binding
{
    class Rencontre : INotifyPropertyChanged
    {
        private string _sujet;
        private DateTime _date;

        public string Sujet { 
            get { return _sujet; }
            set { _sujet = value;
            OnPropertyChanged("Sujet");}
        }

        public DateTime Date
        {
            get { return _date; }
            set { _date = Date; 
            OnPropertyChanged("Date");}
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
	        {
		        PropertyChanged(this,new PropertyChangedEventArgs(propertyName));
	        }
        }
    }
}
