using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cas222
{
    class Program
    {
        static void Main(string[] args)
        {
            /* variable declaration */
            int i, j, k;
            char c, ch;

            /* variable initialization */
            i = 24;

            /* variable declaration & initialization */
            float f = 2.87F, salary = 2000000F;
            double d = 3.14159;
            string txt = "Ovo je neki string";

            const float PI = 3.14F;

            double r = 5;

            double circleArea = PI * r * r;


            //Console.WriteLine(PI);

            j = 453;

            bool isEven = (j % 2 == 0);
            Console.WriteLine(isEven);


            k = 0;
            k++; // isto sto i k = k + 1
            Console.WriteLine(k);
            k--; // isto sto i k = k - 1
            Console.WriteLine(k);
            k = 100;
            Console.Write(k++);
            Console.WriteLine(" => " + k);

            k = 100;
            Console.Write(k--);
            Console.WriteLine(" => " + k);
            Console.WriteLine("----------------------------");
            k = 100;
            Console.Write(++k);
            Console.WriteLine(" => " + k);
            k = 100;
            Console.Write(--k);
            Console.WriteLine(" => " + k);

            /*
                   
            k++ => vrati vrednost k, a zatim uvecaj vrednost za 1
            ++k => uvecaj vrednost k za 1, a zatim vrati vrednost k

            */

            k = 99;

            if ((k < 100) && (k > 0))
            {
                Console.WriteLine("Uslov je ispunjen (AND)");
             }

            if (!(k > 100) || (k == 99))
            {
                Console.WriteLine("Uslov je ispunjen (OR)");
            }

            if (!(k > 100))
            {
                Console.WriteLine("Uslov je ispunjen (NOT)");
            }

            i = 20;
            j = 21;
            k = 15;

            if (i == j)
            {
                Console.WriteLine("i jednako j");
            }
            else
                Console.WriteLine("i nije jednako j");

            if (i < j)
            {
                Console.WriteLine("i manje od j");
            }
            else
                Console.WriteLine("i nije manje od j");

            if (i > j)
            {
                Console.WriteLine("i vece od j");
            } else
            {
                Console.WriteLine("i nije vece od j");
            }
            if (i >= k)
            {
                Console.WriteLine("i nije vece ili jednako od k");
            }
            else
            {
                Console.WriteLine("i je vece ili jednako od k");
            }

            if (i <= k)
            {
                Console.WriteLine("i je manje ili jednako od k");
            }
            else
            {
                Console.WriteLine("i nije manje ili jednako od k");
            }

            Console.ReadKey();

        }
    }
}
