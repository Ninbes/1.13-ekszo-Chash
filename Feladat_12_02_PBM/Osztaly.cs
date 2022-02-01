using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Valami
{
    class Program
    {
        struct adat
        {
            public int ti;
            public string ind;
            public int ido;
            public double tav;
            public double vit;
            public double bor;
            public string fiz;
        }

        static void Main(string[] args)
        {
            string[] s = File.ReadAllLines("fuvar.csv");
            adat[] t = new adat[s.Length-1];
            for (int i = 1; i < s.Length; i++)
            {
                string[] tmp = s[i].Split(';');
                t[i - 1].ti = int.Parse(tmp[0]);
                t[i - 1].ind = tmp[1];
                t[i - 1].ido = int.Parse(tmp[2]);
                t[i - 1].tav = double.Parse(tmp[3]);
                t[i - 1].vit = double.Parse(tmp[4]);
                t[i - 1].bor = double.Parse(tmp[5]);
                t[i - 1].fiz = tmp[6];
            }
            Console.WriteLine("3. feladat: {0} fuvar", t.Length);
            double osz = 0;
            int fsz = 0;
            for (int i = 0; i < t.Length; i++)
            {
                if (t[i].ti == 6185)
                {
                    osz = t[i].vit + t[i].bor + osz;
                    fsz++;
                }
            }
            Console.WriteLine("4. feladat: {0} fuvat alatt: {1}$", fsz, osz);
            //5. feladat
            List<string> fzs = new List<string>();
            for (int i = 0; i < t.Length; i++)
            {
                if (!(fzs.Contains(t[i].fiz)))
                {
                    fzs.Add(t[i].fiz);
                }
            }
            int[] sz = new int[fzs.Count];
            for (int i = 0; i < fzs.Count; i++)
            {
                for (int j = 0; j < t.Length; j++)
                {
                    if (fzs[i] == t[j].fiz)
                    {
                        sz[i]++;
                    }
                }
            }
            Console.WriteLine("5. feladat:");
            for (int i = 0; i < fzs.Count; i++)
            {
                Console.WriteLine("\t{0}: {1} fuvar", fzs[i], sz[i]);
            }
            //6. feladat
            double tav = 0;
            for (int i = 0; i < t.Length; i++)
            {
                tav += t[i].tav;
            }
            tav = tav * 1.6;
            Console.WriteLine("6. feladat: {0:0.00} km", tav);
            //7. feladat
            int max = int.MinValue;
            int ta = 0;
            double tavv = 0;
            double dj = 0;
            for (int i = 0; i < t.Length; i++)
            {
                if (max < t[i].ido)
                {
                    max = t[i].ido;
                    ta = t[i].ti;
                    tavv = t[i].tav;
                    dj = t[i].vit + t[i].bor;
                }
            }
            Console.WriteLine("7. feladat: A leghosszabb fuvar:");
            Console.WriteLine("\tFuvar hossza: {0} másodperc", max);
            Console.WriteLine("\tTaxi azonosító: {0}", ta);
            Console.WriteLine("\tMegtett távolság: {0} km", tavv);
            Console.WriteLine("\tViteldij: {0} $", dj);
            //8. feladat
            List<string> hiba = new List<string>();
            hiba.Add(s[0]);
            for (int i = 0; i < t.Length; i++)
            {
                if (t[i].vit > 0 && t[i].ido > 0 && t[i].tav == 0)
                {
                    hiba.Add(t[i].ti + ";" + t[i].ind + ";" + t[i].ido + ";" + t[i].tav + ";" + t[i].vit + ";" + t[i].bor + ";" + t[i].fiz);
                }
            }
            File.AppendAllLines("hibak.txt", hiba);

            Console.ReadKey();
        }
    }
}
