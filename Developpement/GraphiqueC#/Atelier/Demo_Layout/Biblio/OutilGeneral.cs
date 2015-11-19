using System;
using System.Windows;
using System.Reflection;

namespace General
{
    public class Outil
	{
		public static void OuvrirEcran(Window parent,string nom,bool modal,bool fermeParent)
        {
            Type type = parent.GetType();
            Assembly assembly = type.Assembly;
            Window win = (Window)assembly.CreateInstance(type.Namespace + "." + nom);

            if (fermeParent)
                parent.Close();

            if (modal)
                win.ShowDialog();
            else
                win.Show();

        }
	}
    
}