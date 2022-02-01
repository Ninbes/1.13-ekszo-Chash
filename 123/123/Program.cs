using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _123
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Add meg az első számot!");
            int s1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Add meg a másik számot!");
            int s2 = Convert.ToInt32(Console.ReadLine());
            if (s2 > s1)
            {
                s1 = s1 + s2;
                s2 = s1 - s2;
                s1 = s1 - s2;
            }
            Console.WriteLine("Páros számok");
            for(int i = s2; i <= s1; i++)
            {
                if (i%2 ==0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine("Páratlan számok");
            for (int i = s2; i <= s1; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
            
            for (int vizsgaltSzam = s2; vizsgaltSzam <= s1; vizsgaltSzam++)
            {
                int osztokSzama = 0;

                for (int oszto = 1; oszto <= vizsgaltSzam; oszto++)
                {
                    if(vizsgaltSzam%oszto==0)
                    {
                        osztokSzama++;
                    }
                }
                if(osztokSzama == 2)
                {
                    Console.WriteLine(vizsgaltSzam + " egy prím!");
                }
            }
            Console.ReadKey();
        }
    }
}
