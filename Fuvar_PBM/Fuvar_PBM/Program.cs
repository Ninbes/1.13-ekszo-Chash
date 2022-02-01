using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Fuvar_PBM
{
    class Program
    {
        struct Adat{
            public int taxiid;
            public string launch;
            public int eta;
            public float distance;
            public float fee;
            public float tip;
            public string paymethod;
        }
        static void Main(string[] args)
        {
            Adat a = new Adat();
            string[] t = File.ReadAllLines("fuvar.csv");
            Adat[] ad = new Adat[t.Length];
            for (int i = 1; i < ad.Length; i++)
            {
                string[] tmp = t[i].Split(';');
                ad[i].taxiid = int.Parse(tmp[0]);
                ad[i].launch = tmp[1];
                ad[i].eta = int.Parse(tmp[2]);
                ad[i].distance = float.Parse(tmp[3]);
                ad[i].fee = float.Parse(tmp[4]);
                ad[i].tip = float.Parse(tmp[5]);
                ad[i].paymethod = tmp[6];
            }
            //3.feladat Összesen hány utazás került feljegyzésre?
            int sorok = 0;
            for (int i = 0; i < t.Length; i++)
            {
                sorok++;
            }
            Console.WriteLine("Összesen {0} utazás került feljegyzésre!", sorok);
            //4 6185-ös id-jű taxi fee+tip és hány útja volt?
            int fuvarszam = 0;
            float fizetes = 0;
            for (int i = 1; i < ad.Length; i++)
            {
                if (ad[i].taxiid == 6185)
                {
                    fuvarszam++;
                    fizetes = fizetes + ad[i].fee + ad[i].tip;
                }
            }
            Console.WriteLine("A 6185-ös azonosítójú taxisnak {0} útja volt és {1} dollárt keresett összesen.", fuvarszam, fizetes);
            //5. feladat fizetési mód count bankkártya/készpénz/vitatott/ingyenes/ismeretlen
            int bankkartya = 0;
            int készpénz = 0;
            int vitatott= 0;
            int ingyenes = 0;
            int ismeretlen = 0;
            for (int i = 1; i < ad.Length; i++)
            {
                if (ad[i].paymethod == "bankkártya")
                {
                    bankkartya++;
                }
                else if (ad[i].paymethod == "készpénz")
                {
                    készpénz++;
                }
                else if (ad[i].paymethod == "vitatott")
                {
                    vitatott++;
                }
                else if (ad[i].paymethod == "ingyenes")
                {
                    ingyenes++;
                }
                else
                {
                    ismeretlen++;
                }
            }
            Console.WriteLine("Összesen {0} bankkártyás, {1} készppénzes, {2} vitatott tranzakció és {3} ingyenes, {4} ismeretlen módon utazott", bankkartya, készpénz, vitatott, ingyenes, ismeretlen);
            //6. feladat, összesen hány kilométert tettek meg a taxisok?
            float taxiut = 0;
            for (int i = 1; i < ad.Length; i++)
            {
                taxiut = ad[i].distance * (float)1.6 + taxiut;
            }
            Console.WriteLine("Összesen {0} kilométert tettek meg a taxisok.", taxiut);
            //7. feladat a leghosszabb út adatai. hossz, id, distance, viteldíj
            float hosszueta = float.MinValue;
            int azonos = 0;
            float tav = 0;
            float viteld = 0;
            for (int i = 1; i < ad.Length; i++)
            {
                if (ad[i].eta > hosszueta)
                {
                    hosszueta = ad[i].eta;
                    azonos = ad[i].taxiid;
                    tav = ad[i].distance;
                    viteld = (float)ad[i].fee + (float)ad[i].tip;
                }
            }
            Console.WriteLine("A leghosszabb fuvar: \nFuvar hossza:{0} másodperc\nTaxi azonosító: {1}\nMegtett távolság: {2}\nViteldíj: {3} ",hosszueta, azonos, tav, viteld);



            Console.ReadKey();
        }
    }
}
