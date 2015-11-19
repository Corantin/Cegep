using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluateurMainTexas
{
    class uneMain
    {
        public Carte[] mainOrigine;
        public Carte[] mainTriee;
        public Evaluateur Eval;

        public uneMain(Carte[] lamain)
        {
            mainTriee = new Carte[7];
            for (int i = 0; i < 7; i++)
            {
                mainOrigine[i] = lamain[i];
            }
            Trier();
            Eval = new Evaluateur();
        }

        public uneMain()
        {
            mainOrigine = new Carte[7];
            for (int i = 0; i < 7; i++)
            {
                mainOrigine[i] = new Carte();
            }
            Eval = new Evaluateur();
        }

        public uneMain(double duree)
        {
            mainOrigine = new Carte[7];
            for (int i = 0; i < 7; i++)
            {
                mainOrigine[i] = new Carte();
            }
            Eval = new Evaluateur();
        }

        uneMain(Carte c0, Carte c1, Carte c2, Carte c3, Carte c4)
        {
            mainOrigine[0] = c0;
            mainOrigine[1] = c1;
            mainOrigine[2] = c2;
            mainOrigine[3] = c3;
            mainOrigine[4] = c4;
        }




        public int DonneValeur()
        {
            int[] v = new int[5];
            int[] s = new int[5];
            int res = -1;
            for (int i = 0; i < 5; i++)
            {
                v[i] = mainTriee[i].Valeur;
                s[i] = mainTriee[i].Sorte;
            }
            res = Eval.Eval_Seq_Flush(v, s); if (res > 0) { return res; }
            res = Eval.Eval_Carre(v, s); if (res > 0) { return res; }
            res = Eval.Eval_Full(v, s); if (res > 0) { return res; }
            res = Eval.Eval_Flush(v, s); if (res > 0) { return res; }
            res = Eval.Eval_Seq(v, s); if (res > 0) { return res; }
            res = Eval.Eval_Brelan(v, s); if (res > 0) { return res; }
            res = Eval.Eval_Deux_Paires(v, s); if (res > 0) { return res; }
            res = Eval.Eval_Paire(v, s); if (res > 0) { return res; }
            res = Eval.Eval_Rien(v, s); if (res > 0) { return res; }
            return res;
        }

        public void Trier()
        {
            mainTriee = new Carte[5];
            int LaPlusGrosse = -2;
            int IndicePlusGrosse = -1;
            int[] ValeurUtilisée = new int[52];

            for (int i = 0; i < 5; i++) { ValeurUtilisée[i] = -1; }

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    int val = mainOrigine[j].Valeur;
                    if (mainOrigine[j].Valeur > LaPlusGrosse)
                    {
                        if (ValeurUtilisée[j] == -1)
                        {
                            LaPlusGrosse = mainOrigine[j].Valeur;
                            IndicePlusGrosse = j;
                        }
                    }
                }
                ValeurUtilisée[IndicePlusGrosse] = 0;
                mainTriee[i] = mainOrigine[IndicePlusGrosse];
                LaPlusGrosse = -2;
            }
        }
    }
}
