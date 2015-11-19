using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluateurMainTexas
{
    public class Carte
    {
        private int valeur;
        public int Valeur
        {
            get { return valeur; }
            set { valeur = value; }
        }
        private int sorte;
        public int Sorte
        {
            get { return sorte; }
            set { sorte = value; }
        }

        public string NomPhysique;

        public Carte()
        {
            Valeur = -1;
            Sorte = -1;
        }

        public Carte(int v, int s)
        {
            Valeur = v;
            Sorte = s;
            string NomTex = GetNomTextuel();
        }

        public Carte(string v, string s)
        {
            Valeur = Convert.ToInt32(v);
            Sorte = Convert.ToInt32(s);
            string NomTex = GetNomTextuel();
        }
        


        public string GetNomTextuel()
        {
            string s = "", v = "";
            switch (Sorte)
            {
                case -1: s = "vide"; break;
                case 0: s = "Pique"; break;
                case 1: s = "Trefle"; break;
                case 2: s = "Carreau"; break;
                case 3: s = "Coeur"; break;
                default:
                    Console.WriteLine("couleur de carte inexistante: Sorte");
                    break;
            }
            switch (Valeur)
            {
                case -1: v = "vide"; break;
                case 0: v = "Deux"; break;
                case 1: v = "Trois"; break;
                case 2: v = "Quatre"; break;
                case 3: v = "Cinq"; break;
                case 4: v = "Six"; break;
                case 5: v = "Sept"; break;
                case 6: v = "Huit"; break;
                case 7: v = "Neuf"; break;
                case 8: v = "Dix"; break;
                case 9: v = "Valet"; break;
                case 10: v = "Reine"; break;
                case 11: v = "Roi"; break;
                case 12: v = "As"; break;
                default:
                    Console.WriteLine("valeur de carte inexistante:" + Valeur);
                    break;
            }
            return s + "_" + v + ".gif";
        }

        public string afficheTexte()
        {
            string CarteTexte = "";
            switch (Valeur)
            {
                case -1: break;
                case 0: CarteTexte = "2"; break;
                case 1: CarteTexte = "3"; break;
                case 2: CarteTexte = "4"; break;
                case 3: CarteTexte = "5"; break;
                case 4: CarteTexte = "6"; break;
                case 5: CarteTexte = "7"; break;
                case 6: CarteTexte = "8"; break;
                case 7: CarteTexte = "9"; break;
                case 8: CarteTexte = "10"; break;
                case 9: CarteTexte = "J"; break;
                case 10: CarteTexte = "Q"; break;
                case 11: CarteTexte = "K"; break;
                case 12: CarteTexte = "A"; break;
                default: CarteTexte = "valeur de carte inexistante:" + Valeur; break;
            }
            switch (Sorte)
            {
                case -1: break;
                case 0: CarteTexte += " de pique"; break;
                case 1: CarteTexte += " de trèfle"; break;
                case 2: CarteTexte += " de carreau"; break;
                case 3: CarteTexte += " de coeur"; break;
                default: CarteTexte += " couleur de carte inexistante:" + Sorte; break;
            }
            return CarteTexte;
        }
    }
}
