using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NegyszogMetodus
{
    class Program
    {
        static void Kiir(string szoveg, int ertek)
        {
            Console.Write(szoveg);
            Console.WriteLine(" {0}", ertek);
        }

        static int Terulet(int valt1, int valt2)
        {
            return valt1 * valt2;
        }

        static int Kerulet(int valt1, int valt2)
        {
            return 2 * (valt1 + valt2);
        }

        static void Main()
        {
            int ter;
            int ker;
            int a_oldal;
            int b_oldal;

            // Adat bekérés
            Console.Write("Kerem az a oldalt: ");
            a_oldal = Convert.ToInt32(Console.ReadLine());

            Console.Write("Kerem az b oldalt: ");
            b_oldal = Convert.ToInt32(Console.ReadLine());

            // értékek számolása
            ter = Terulet(a_oldal, b_oldal);
            ker = Kerulet(a_oldal, b_oldal);

            // Terület és kerület kiiratása
            Kiir("A terulet:", ter);
            Kiir("A kerulet:", ker);

            Console.ReadKey();
        }
    }
}
