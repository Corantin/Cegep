using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Exemple
    {
        static bool termine = false;
        static readonly object cadenas = new object();
        static void Main()
        {
            Console.WriteLine("Exemple5");
            Thread t = new Thread(JeVaisAttendre);
            Thread t2 = new Thread(JeVaisAttendre1);
            Thread t3 = new Thread(JeVaisAttendre2);
            t.Start();
            t.Join();
            t2.Start();
            t2.Join();
            t3.Start();
            
            
            t3.Join();

            Console.WriteLine("Fin du Main");
            Console.ReadKey();
        }

        static void JeVaisAttendre()
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.Write("z");

                Thread.Yield();
            }
        }
        static void JeVaisAttendre1()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.Write("x");

                Thread.Yield();
            }
        }
        static void JeVaisAttendre2()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.Write("y");

                Thread.Yield();
            }
        }

        static void ConditionSi()
        {
            lock (cadenas)
            {                
                if (!termine)
                {
                    Console.WriteLine("Terminé");
                    termine = false;
                    
                }
            }
        }
    }
}
