﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feladat_11_03_PBM
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Írj be 10 sort!");
            string[] Sorok = new string[10];
            for (int i = 0; i < Sorok.Length; i++)
            {
                Console.WriteLine("{0}. sor:", i + 1);
                Sorok[i] = Console.ReadLine();

            }
            Console.WriteLine("A betűvel kezdődő elemek:");
            for (int i = 0; i < Sorok.Length; i++)
            {
                
                if (Sorok[i].Substring(0, 1).ToLower() == "a")
                {
                    Console.WriteLine(Sorok[i]);
                }         
            }
            Console.WriteLine("5 betűnél hosszabb elemek: ");
            for (int i = 0; i < Sorok.Length; i++)
            {
                
                if (Sorok[i].Length >5)
                {
                    Console.WriteLine(Sorok[i]);
                }
            }
            Console.WriteLine("Páros számú karakterből állnak: ");
            for (int i = 0; i < Sorok.Length; i++)
            {

                if (Sorok[i].Length %2 == 0)
                {
                    Console.WriteLine(Sorok[i]);
                }
            }
            string Hossz = ""; 
            for (int i = 0; i < Sorok.Length; i++)
            {
                if (Hossz.Length < Sorok[i].Length)
                {
                    Hossz = Sorok[i];
                }
            }
            Console.WriteLine("Leghosszabb sor : {0}", Hossz);
            Console.ReadKey();
        }
    }
}
