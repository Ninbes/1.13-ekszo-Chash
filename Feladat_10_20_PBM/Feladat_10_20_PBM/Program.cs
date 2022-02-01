using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feladat_10_20_PBM
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Add meg a tömb lehetséges minimum értékét!");
            int a = Convert.ToInt32 (Console.ReadLine());
            Console.WriteLine("Add meg a tömb lehetséges maximum értékét!");
            int b = Convert.ToInt32 (Console.ReadLine());
            Console.WriteLine("Add meg a tömb hosszát!");
            int c = Convert.ToInt32(Console.ReadLine());
            if (a > b)
            {
                a = a + b;
                b = a - b;
                a = a - b;

            }
            int[] t = new int[c];
            Random r = new Random();
            for (int i = 0; i < t.Length; i++)
            {
                t[i] = r.Next(a, b);
            }
            //max keresése
            int max = int.MinValue;
            for (int i = 0; i < t.Length; i++)
            {
                if (max<t[i])
                {
                    max = t[i];
                }
            }
            Console.WriteLine("A legnagyobb szám: {0}",max);
            //min keresés

            int min = int.MaxValue;
            for (int i = 0; i < t.Length; i++)
            {
                if (min > t[i])
                {
                    min = t[i];
                }
            }
            Console.WriteLine("A legkisebb szám: {0}", min);
            //elemek összege
            int osszeg = 0;
            for (int i = 0; i < t.Length; i++)
            {
                osszeg = osszeg + t[i];
            }
            Console.WriteLine("A tömb elemeinek összege : {0}", osszeg);
            //átlagolás
            int átl = osszeg / t.Length;
            Console.WriteLine("Az elemek átlaga: {0}",átl);
            //páros számok
            Console.WriteLine("páros számok:");
            int parosDb = 0;
            for (int i = 0; i < t.Length; i++)
            {
                if (t[i]%2==0)
                {
                    Console.Write(t[i] + " ");
                    parosDb++;
                }
            }
            //páratlan számok
            Console.WriteLine("\nPáratlan számok:");
            int paratlanDb = 0;
            for (int i = 0; i < t.Length; i++)
            {
                if (t[i] % 2 != 0)
                {
                    Console.Write(t[i] + " ");
                    paratlanDb++;
                }
            }
            Console.WriteLine("\nPáros számból volt: {0}",parosDb);
            Console.WriteLine( "Páratlan számból volt: {0}",paratlanDb);
            Console.ReadKey();
        }
    }
}
