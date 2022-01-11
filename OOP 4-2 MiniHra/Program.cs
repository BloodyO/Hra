using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_4_2_MiniHra
{
    class Program
    {
        static void Main(string[] args)
        {
            Hra hra = new Hra();
            string prikaz = "";

            while (prikaz.ToLower() != "konec")
            {
                Console.WriteLine(hra.aktualniLokace);
                Console.Write("Zadej příkaz: ");
                prikaz = Console.ReadLine();
                hra.Prikaz(prikaz);
              //  Console.WriteLine();
            }
        }
    }
}
