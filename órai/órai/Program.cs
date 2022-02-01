using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sztring
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Console.WriteLine("Írj be egy szót!");
            string s = Console.ReadLine();
            int h = s.Length/2;
            int k = h-1;
            string z = s.Substring(k, h);
            Console.WriteLine(z);*/

            /*
            Console.WriteLine("Írd be hogy madár!");
            string s = Console.ReadLine();
            s=s.ToLower();
            if (s == "madár")
            {
                Console.WriteLine("Helyes");
            }
            else {
                Console.WriteLine("EHHH");
            }
            s = s.ToUpper();
            Console.WriteLine(s);
            */
            
            //Bontás
            Console.WriteLine("Írd be a nevet!");
            string s = Console.ReadLine();
            //Ősember mód
            string vn = "";
            string kn = "";
            int i = 0;
            char c = 'a';
            while (c!=' ') {
                c = s[i];
                if (c != ' ') {
                    vn += c;
                }
                i++;
            }
            Console.WriteLine("Vezetéknév: |{0}|",vn);
            while (i<s.Length)
            {
                c = s[i];
                if (c != ' ')
                {
                   kn += c;
                }
                i++;
            }
            Console.WriteLine("Keresztnév: |{0}|",kn);

            //Vaskori ősember
            vn = "";
            kn = "";
            int z = s.IndexOf(' ');
            vn = s.Substring(0,z);
            kn = s.Substring(z+1);
            Console.WriteLine("Vezetéknév: |{0}|", vn);
            Console.WriteLine("Keresztnév: |{0}|", kn);

            //Posztmodern ősember
            string[] t = s.Split(' ');
            for (int j = 0; j < t.Length; j++)
            {
                Console.WriteLine(t[j]);
            }
            Console.WriteLine("Az első szó harmadik betűje: {0}",t[0][2]);
            /
            Console.WriteLine("Írj be 6 sort!");
            string[] t = new string[6];
            for (int i = 0; i < t.Length; i++)
            {
                Console.WriteLine("{0}. sor:", i + 1);
                t[i] = Console.ReadLine();
            }
            for (int i = 0; i < t.Length; i++)
            {
                if (t[i].Contains("a") && t[i].Length > 10)
                {
                    Console.WriteLine("\nA sor bontva: \n");
                    for (int j = 0; j < t[i].Length; j++)
                    {
                        Console.Write("{0}, ", t[i][j]);
                    }
                }
            }
            */



            Console.ReadKey();
        }
    }
}