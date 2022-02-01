using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace jackie_stewart
{
    class Program
    {
        struct Adat{
            public int year;
            public int races;
            public int wins;
            public int pods;
            public int poles;
            public int fast; 
        }
        static void Main(string[] args)
        {
            string[] s = File.ReadAllLines("jackie.txt");
            Adat[] t = new Adat[s.Length-1];
            for (int i = 1; i < s.Length; i++)
            {
                string[] tmp = s[i].Split('\t');
                t[i - 1].year = int.Parse(tmp[0]);
                t[i - 1].races = int.Parse(tmp[1]);
                t[i - 1].wins = int.Parse(tmp[2]);
                t[i - 1].pods = int.Parse(tmp[3]);
                t[i - 1].poles = int.Parse(tmp[4]);
                t[i - 1].fast = int.Parse(tmp[5]);
            }
            int sorok = 0;
            for (int i = 0; i < t.Length; i++)
            {
                sorok++;
            }
            Console.WriteLine( "3.feladat: " + sorok);
            int sokrace = int.MinValue;
            int hat = 0;
            for (int i = 0; i < t.Length; i++)
            {
                if (sokrace < t[i].races)
                {
                    sokrace = t[i].races;
                    hat = t[i].year;
                }
            }
            Console.WriteLine("4.feladat: " + hat);
            int hatvanas = 0;
            int hetvenes = 0;

            for (int i = 0; i < t.Length; i++)
            {
                if (t[i].year % 100 < 70)
                {
                    hatvanas += t[i].wins;
                }
                else
                    hetvenes += t[i].wins;
            }
            // Amennyiben más évtizedek is kellenek akkor egy 10 lépcsős if else-t csinálnék
            // vagy az évszám % 100 / 10 valamilyen lista vagy tomb elemeiben tűrolnám az összes évtized összes nyert versenyét
            Console.WriteLine("5.feladat:");
            Console.WriteLine("\t 70-es évek: {0} megnyert verseny", hetvenes);
            Console.WriteLine("\t 60-es évek: {0} megnyert verseny", hatvanas);
            
            
            
            Console.ReadKey();
        }

    }
}
