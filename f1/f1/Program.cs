using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orai01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Szevasz!");
            int a;
            a = 12;
            a = 13;
            int b = 30;
            string s, w = "sos", d;
            int c = a + b;
            Console.WriteLine(a);
            a++;
            Console.WriteLine(a);
            Console.WriteLine("Add meg az első számot!");
            int s1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Add meg a 2. számot!");
            int s2 = Convert.ToInt32(Console.ReadLine());
            if (s1 > s2)
                Console.WriteLine("Az első szám nagyobb!");
            else if (s1 < s2)
                Console.WriteLine("A második nagyobb!");
            else
                Console.WriteLine("A két szám egyenlő!");

            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(i + 1);
            }

            for (int i = 1; i <= 12; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            Console.ReadKey();
        }
    }
}

Önálló feladat: Prímvizsgálat bevett értékkel

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orai01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prímvizsgálat!");
            Console.WriteLine("Add meg a számot!");
            int s1 = Convert.ToInt32(Console.ReadLine());
            int o = 0;
            for (int i = 1; i <= s1; i++)
            {
                if (s1 % i == 0)
                {
                    o++;
                }
            }
            if (o == 2)
            {
                Console.WriteLine("A szám prím!");
            }
            else
            {
                Console.WriteLine("A szám nem prím, osztóinak száma: {0}", o);
            }
            Console.ReadKey();
        }
    }
}
