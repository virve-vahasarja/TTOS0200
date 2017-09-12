/*Tehtävä 3
Tee ohjelma, joka kysyy käyttäjältä kolme lukua ja tulostaa niiden summan ja keskiarvon.

Virve Vähäsarja
H4143

Ohjelma ei toimi

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labrat
{
    class Lab01_T3
    {
        public static void Tehtava03()
        {
            int luku1, luku2, luku3;
            int summa = luku1 + luku2 + luku3;
            int keskiarvo = summa / 3;

            Console.Write("Anna kolme lukua");
            luku1 = int.Parse(Console.ReadLine());
            luku2 = int.Parse(Console.ReadLine());
            luku3 = int.Parse(Console.ReadLine());

            Console.WriteLine("summa on "+ summa);
            Console.WriteLine("keskiarvo on " + keskiarvo);
        }  
    }
}
*/