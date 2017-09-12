/*Tehtävä 1
 Tee ohjelma, joka tulostaa käyttäjän antamaa lukua (1, 2 tai 3) vastaavan luvun sanana (yksi, kaksi tai kolme). 
 Jos käyttäjä syöttää jonkin muun luvun, tulee näytölle tulostaa teksti: "joku muu luku".
 
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
    class Lab01
    {
        public static void Tehtava01 ()
        {

            int luku;
            Console.Write("Anna luku > ");
            luku = int.Parse(Console.ReadLine());
            
            //Console.WriteLine("under process");

            if (luku == 1) Console.WriteLine("Annoit luvun yksi");
            else if (luku == 2) Console.WriteLine("Annoit luvun kaksi");
            else if (luku == 3) Console.WriteLine("Annoit luvun kolme");
            else Console.WriteLine("Joku muu luku");
        }
    }

}
*/