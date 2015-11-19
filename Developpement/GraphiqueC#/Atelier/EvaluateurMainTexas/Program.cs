using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluateurMainTexas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ouverture de l'évaluateur");
            Evaluateur eval = new Evaluateur();

            Carte[] laMain = new Carte[7];
            laMain[0] = new Carte(0, 0);
            laMain[1] = new Carte(1, 0);
            laMain[2] = new Carte(2, 0);
            laMain[3] = new Carte(3, 0);
            laMain[4] = new Carte(4, 0);
            laMain[5] = new Carte(5, 0);
            laMain[6] = new Carte(6, 0);

            int v = eval.CalculeValeurPostRiver(laMain);

            Console.WriteLine("Valeur = " + v);

            Console.WriteLine(eval.ConvertEvalEnFrancais(v));

            Console.ReadKey();
        }
    }
}
