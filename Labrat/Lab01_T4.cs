/*
Tehtävä 4
Tee ohjelma, jossa kysytään käyttäjältä tämän ikä. Jos ikä on alle 18 vuotta,
tulosta "alaikäinen", jos se on 18-65 vuotta, tulosta "aikuinen", muussa tapauksessa tulosta "seniori".

Virve Vähäsarja
H4143

Ohjelma toimii

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labrat
{
    class Lab01_T4
    {
        public static void Tehtava04()
        {
            int ika;

            Console.WriteLine("Anna ikä");
            ika=int.Parse(Console.ReadLine());

            if (ika < 18) Console.WriteLine("Alaikäinen");
            else if (ika >= 18 && ika <= 65) Console.WriteLine("aikuinen");
            else Console.WriteLine("seniori");
        }
    }
}
*/