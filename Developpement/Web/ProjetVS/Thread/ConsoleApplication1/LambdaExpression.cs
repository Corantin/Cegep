using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class LambdaExpression
    {
        static void Main()
        {
            Func<int,int,bool> lambda1 =  (x,y) => x == y;
            Console.WriteLine(lambda1(7,3));

            Func<int,string,int> lambda2 = (int x, string s) => s.Length + x;
            Console.WriteLine(lambda2(5,"Yannick"));

            Action ecrireLigne = () => Console.WriteLine("Ecrire");
            ecrireLigne.Invoke();

            string[] jeux = {"Diablo II", "Guildwars 2","World of Warcraft,","Everquest","Fallout"};
            var sousEnsemble = jeux.Where(jeu => jeu.Contains(" ")).OrderBy(jeu => jeu).Select(jeu => jeu);

            jeux.ToList().ForEach(jeu => Console.WriteLine(jeu));

            int[] chiffres = {1,4,5,6,2,7,2,6,9,4,7,5};

            foreach (var item in sousEnsemble)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
