using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szkt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Számkitaláló játék!");
            Random r = new Random();
            Console.WriteLine("Add meg a nehézséget (e/m/h):");
            string n = Console.ReadLine();
            int a = 0;
            if (n == "e")
            {
                a = 10;
            }
            else if (n == "m")
            {
                a = 20;
            }
            else if (n == "h")
            {
                a = 30;
            }
            int pp = 100;
            int cp = 100;
            int t = 0;
            do
            {
                Console.WriteLine("Egyenleged: {0}", pp);
                Console.WriteLine("Gép egyenlege: {0}", cp);
                do
                {
                    Console.WriteLine("Add meg a téted!");
                    t = Convert.ToInt32(Console.ReadLine());
                    if (t > pp)
                    {
                        Console.WriteLine("Túl sokat adtál meg!");
                    }
                } while (t > pp);
                int tc = r.Next(1, cp + 1);
                Console.WriteLine("A téted: {0}", t);
                Console.WriteLine("A gép tétje: {0}", tc);
                pp = pp - t;
                cp = cp - tc;
                Console.WriteLine("Gondoltam egy számra!");
                Console.WriteLine("Tipp:");
                int s = Convert.ToInt32(Console.ReadLine());
                int gsz = r.Next(1, a + 1);

                if (s == gsz)
                {
                    Console.WriteLine("Győztél!");
                    pp = pp + tc;
                }
                else
                {
                    Console.WriteLine("Vesztettél! A szám {0} volt!", gsz);
                    cp = cp + t;
                }

                int psz = 0;
                do
                {
                    Console.WriteLine("Gondolj egy számra (1-{0})!", a);
                    psz = Convert.ToInt32(Console.ReadLine());
                    if (psz > a || psz < 1)
                    {
                        Console.WriteLine("1 és {0} között!", a);
                    }
                } while (psz > a || psz < 1);
                gsz = r.Next(1, a);
                Console.WriteLine("A gép tippje: {0}", gsz);
                if (psz == gsz)
                {
                    Console.WriteLine("Győzött a gép!");
                    cp = cp + t;
                }
                else
                {
                    Console.WriteLine("Vesztett a gép! A szám {0} volt!", psz);
                    pp = pp + tc;
                }
                Console.ReadKey();
                Console.Clear();
            } while (pp > 0 && cp > 0);
            if (pp < 1)
            {
                Console.WriteLine("A játékos pénze elfogyott, bai");
            }
            else if (cp < 1)
            {
                Console.WriteLine("A GÉP pénze elfogyott, bai");
            }
            Console.ReadKey();
        }
    }
}