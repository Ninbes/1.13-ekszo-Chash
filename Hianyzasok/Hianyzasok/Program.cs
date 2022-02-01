using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Hianyzasok
{
    internal class Program
    {       //Név;Osztály;Első nap;Utolsó nap;Mulasztott órák
        struct Adat
        {
            public string name;
            public string clas;
            public int first;
            public int last;
            public int skip;
        }
        static void Main(string[] args)
        {
            
            string[] s = File.ReadAllLines("szeptember.csv");
            Adat[] t = new Adat[s.Length-1];
            for (int i = 1; i < s.Length; i++)
            {
                string[] tmp = s[i].Split(';');
                t[i - 1].name = tmp[0]; 
                t[i - 1].clas = tmp[1]; 
                t[i - 1].first = int.Parse(tmp[2]); 
                t[i - 1].last= int.Parse(tmp[3]); 
                t[i - 1].skip = int.Parse(tmp[4]); 
            }
            Console.WriteLine("2.feladat");
            float allskip = 0;
            for (int i = 0; i < t.Length; i++)
            {
                allskip += (t[i].last-t[i].first+1)*t[i].skip;
            }
            Console.WriteLine("\tÖsszes mulasztott órák száma: " + allskip);
            Console.WriteLine("3. feladat");
            
            
            
            int input1 = 0;
            do
            {
                Console.WriteLine("\tKérem adjon meg egy napot: ");
                input1 =Convert.ToInt32(Console.ReadLine());
            } while (input1 <=1 || input1 >= 31);
            string input2 = "";

            int vótmá = 0;
            

            while (vótmá != 1) {
                Console.WriteLine("\tTanuló neve: ");
                input2 = Console.ReadLine();
                for (int i = 0; i < t.Length; i++)
                {
                    if(t[i].name == input2)
                    {
                        vótmá = 1;
                        if ((t[i].last-t[i].first+1)*t[i].skip > 0)
                        {
                            Console.WriteLine("4. feladat");
                            Console.WriteLine("\tA tanuló hiányzott szpetemberben");
                        }
                        else 
                        {
                            Console.WriteLine("4. feladat");
                            Console.WriteLine("\tA tanulo nem hianyzott"); 
                        } 
                    }
                }
            }
            //5. feladat
            int hianyzokszama = 0;
            Console.WriteLine("\n5. feladat: Hianyzok 2017. 09.{0} -n \n",input1);
            for (int i = 0; i < t.Length; i++)
            {
                if (t[i].first <= input1 && t[i].last >= input1)
                {
                    hianyzokszama++;
                    Console.WriteLine("\t {0} ({1})", t[i].name,t[i].clas);
                }               
            }
            if (hianyzokszama == 0)
            {
                Console.WriteLine("\tNem volt hianyzo");
            }
            
           


            Console.ReadKey();

        }
    }
}
