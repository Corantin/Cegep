using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            new Thread(Go).Start();
            Go();
            /* Thread t = new Thread(WriteY);
             t.Start();
             for (int i = 0; i < 1000; i++)
             {
                 Console.Write("x");
             }
             */
            Console.ReadKey();

        }

        static void Go()
        {
            for (int Cycle = 0; Cycle < 100; Cycle++)
            {
                Console.WriteLine(Cycle);
            }
        }

        static void WriteY()
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.Write("y");
            }
        }

    }
}
