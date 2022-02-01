using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _20211109_orai
{
    class Program
    {   //fájlkezelés
        //struct:
        struct adat
        {
            public string mn;
            public string an;
            public string cg;
            public int fi;
            public int sr;
        }

        static void Main(string[] args)
        {
            //string text = System.IO.File.ReadAllText(@"C:\Users\2020590\Desktop\forras.txt");
            // struct példányosítása:
            adat a = new adat();
            /*
            StreamReader sr = new StreamReader("forras.txt");
            string s = "";
            List<string> t = new List<string>();
            while ((s=sr.ReadLine())!=null)
            {
                t.Add(s);
            }
            for (int i = 0; i <t.Count; i++)
            {
                Console.WriteLine(t[i]);
            }*/
            string[] t = File.ReadAllLines("forras.txt");
                
            /*for (int i = 0; i < t.Length; i++)
            {
                Console.WriteLine(t[i]);
            }*/
            adat[] ad = new adat[t.Length];
            for (int i = 0; i < ad.Length; i++)
            {
                string[] tmp = t[i].Split(';');
                ad[i].mn = tmp[0];
                ad[i].an = tmp[1];
                ad[i].cg = tmp[2];
                ad[i].fi = int.Parse(tmp[3]);
                ad[i].sr = int.Parse(tmp[4]);

            }
            StreamWriter sw = new StreamWriter("valasz.txt");
            // 1. feladat: hány hős szerepel?:
            Console.WriteLine("A fájlban {0} hős adatai szerepelnek.", ad.Length);
            sw.WriteLine("A fájlban {0} hős adatai szerepelnek.", ad.Length);
            // 2.feladat: hány hős magyar nevében van 'ő' betű?:
            int darab = 0;
            for (int i = 0; i < ad.Length; i++)
            {
                if (ad[i].mn.Contains('ő') || ad[i].mn.Contains('Ő'))
                {
                    darab++;
                }
            }
            Console.WriteLine("A fájlban {0} hős nevében szerepel az 'ő'.", darab);
            sw.WriteLine("A fájlban {0} hős nevében szerepel az 'ő'.", darab);

            //3. feladat: listázd ki a hősöket akik angol neve K-val kezdődik.:
            Console.WriteLine("K-val kezdődő nevű hősök:");
            sw.WriteLine("K-val kezdődő nevű hősök:");
            for (int i = 0; i < ad.Length; i++)
            {
                if ((ad[i].an.ToLower())[0]=='k')
                {
                    Console.WriteLine("\t{0}",ad[i].an);
                    sw.WriteLine("\t{0}", ad[i].an);
                }
            }

            //4. feladat: hány hős van a marveltől és hány a dc-től?:
            int ma = 0;
            int dc = 0;
            int mo = 0;
            int d0 = 0; 
            for (int i = 0; i < ad.Length; i++)
            {
                if (ad[i].cg == "Marvel")
                {
                    ma++;
                    mo += ad[i].sr;
                }
                else
                    dc++;
                    d0 += ad[i].sr;
            }
            Console.WriteLine("Marvel: {0}; DC: {1}",ma,dc);
            sw.WriteLine("Marvel: {0}; DC: {1}", ma, dc);

            //5.feladat: max keresése:

            int mfilm = int.MinValue;
            int msor = int.MinValue;
            string hf = "";
            string hs = "";
            for (int i = 0; i < ad.Length; i++)
            {
                if (ad[i].fi > mfilm)
                {
                    mfilm = ad[i].fi;
                    hf = ad[i].mn;
                }
                if (ad[i].sr > msor)
                {
                    msor = ad[i].sr;
                    hs = ad[i].mn;
                }
            }
            Console.WriteLine("A hősök közül {0} szerepelt a legtöbb filmben, és {1} a legtöbb sorozatban.", hf,hs);
            sw.WriteLine("A hősök közül {0} szerepelt a legtöbb filmben, és {1} a legtöbb sorozatban.", hf, hs);

            //6. feladat. a marvel vagy a dc csinált e több sorozatot?

            if (mo > d0)
            {
                Console.WriteLine("Marvel csinált többet");
                sw.WriteLine("Marvel csinált többet");
            }
            else if (d0 > mo)
            {
                Console.WriteLine("DC csinált többet");
                sw.WriteLine("DC csinált többet");
            }
            else
            {
                Console.WriteLine("A két cég egyenlő");
                sw.WriteLine("A két cég egyenlő");
            }

            // fájl kiírása txt-be.
            // lezárása:
            sw.Close();


            Console.ReadKey();
            

        }
    }
}
