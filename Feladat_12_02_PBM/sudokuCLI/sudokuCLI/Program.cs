using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace sudokuCLI
{
    class Feladvany
    {
        public string Kezdo { get; private set; }
        public int Meret { get; private set; }

        public Feladvany(string sor)
        {
            Kezdo = sor;
            Meret = Convert.ToInt32(Math.Sqrt(sor.Length));
        }

        public void Kirajzol()
        {
            for (int i = 0; i < Kezdo.Length; i++)
            {
                if (Kezdo[i] == '0')
                {
                    Console.Write(".");
                }
                else
                {
                    Console.Write(Kezdo[i]);
                }
                if (i % Meret == Meret - 1)
                {
                    Console.WriteLine();
                }
            }
        }
    }

    class Program
    {
        static List<Feladvany> lista = new List<Feladvany>();
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("feladvanyok.txt", Encoding.UTF8);
            string sor = "";
            while (!sr.EndOfStream)
            {
                sor = sr.ReadLine();
                Feladvany f = new Feladvany(sor);
                lista.Add(f);
            }
            sr.Close();
            Console.WriteLine("3.Feladat");
            Console.WriteLine("Feladvanyok szama: " + lista.Count);

            Console.WriteLine("4.Feladat");
            //              Kérjen be a felhasználótól egy 4...9 intervallumba eső(4≤x≤9) egész számot!A beolvasást
            //              addig ismételje, amíg a megfelelő értékhatárból érkező számot nem kapjuk!Határozza meg,
            //              és írja a képernyőre, hogy ebből a méretből hány feladvány található a forrásállományban!
            int meret = 0;
            do
            {

                Console.WriteLine("Kerem a sudoku meretet: ");
                meret = Convert.ToInt32(Console.ReadLine());

            } while (meret <4 || meret > 9);
            int meretDB = 0;
            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i].Meret == meret)
                {
                    meretDB++;
                }
            }
            Console.WriteLine("{0}x{0} meretu feladvanybol {1} darab van tarolva", meret, meretDB);
            Console.WriteLine("5. feladat");
            //              Válasszon ki véletlenszerűen egy feladványt, amely az előző feladatban bekért méretű!
            //              A kiválasztott feladványt jelenítse meg a képernyőn a minta szerint! Ha nem sikerült
            //              véletlenszerű feladványt kiválasztani, akkor dolgozzon a legelső beolvasott feladvánnyal!
            Random r = new Random();
            int kivalasztottIndex = 0;
            do
            {
                kivalasztottIndex = r.Next(0, lista.Count);
            } while (lista[kivalasztottIndex].Meret != meret);
            Console.WriteLine("A kisorsolt feladvany kezdo allapota: " + lista[kivalasztottIndex].Kezdo);
            Console.WriteLine("6.feladat");
            //Határozza meg és írja a képernyőre a kiválasztott feladvány kitöltöttségét %-os formában
            //a minta szerint!A kitöltöttségen a kitöltött mezők arányát értjük az összes mező számához
            //viszonyítva! A százalékos értéket egész számra kerekítve jelenítse meg!
            int nemNullaDB = 0;
            int hossz = lista[kivalasztottIndex].Kezdo.Length;
            for (int i = 0; i < hossz; i++)
            {
                if (lista[kivalasztottIndex].Kezdo[i] != '0')
                {
                    nemNullaDB++;
                }
            }
            double kitoltottseg = (double)nemNullaDB / hossz * 100;
            Console.WriteLine("A kivalasztott feladvany kitoltottsege: " + kitoltottseg + "%");
            Console.WriteLine("7.feladat");
            //A Feladvany osztály megfelelő metódusát felhasználva jelenítse meg a kiválasztott
            //feladványt a konzolon!
            Console.WriteLine("A kivalasztott feladvany kirajzolva:");
            lista[kivalasztottIndex].Kirajzol();
            Console.WriteLine("8.feladat");
            //Válogassa ki és írja ki fájlba az adott méretű feladványokat!Ha például a felhasználó a 4-es
            //méretet adta meg, akkor a kimeneten egy sudoku4.txt állományba kerüljenek a 4x4-es
            //méretű feladványok!Az állományban soronként egy feladvány kerüljön
            string fajlneve = "sudoku" + meret + ".txt";
            StreamWriter sw = new StreamWriter(fajlneve);
            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i].Meret == meret)
                {
                    sw.WriteLine(lista[i].Kezdo);
                }
            }
            sw.Close();
            Console.WriteLine("{0} allomany {1} darab feladvannyal lett letrehozva", fajlneve, meretDB);
            Console.ReadKey();
        }
    }
}
