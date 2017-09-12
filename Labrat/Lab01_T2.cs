/*Tehtävä 2
Tee ohjelma, jossa annetaan oppilaalle koulunumero taulukon mukaan 
(pistemäärä kysytään ja ohjelma tulostaa numeron)

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
    class Lab01_T2
    {
        public static void Tehtava02()
        {

            int numero;
            Console.Write("Anna pistemäärä > ");
            numero = int.Parse(Console.ReadLine());

            switch (numero)
            {

                case 0:
                case 1:
                    Console.WriteLine("Sait arvosanan 0");
                    break;

                case 2:
                case 3:
                    Console.WriteLine("Sait arvosanan 1");
                    break;

                case 4:
                case 5:
                    Console.WriteLine("Sait arvosanan 2");
                    break;

                case 6:
                case 7:
                    Console.WriteLine("Sait arvosanan 3");
                    break;

                case 8:
                case 9:
                    Console.WriteLine("Sait arvosanan 4");
                    break;

                case 10:
                case 11:
                case 12:
                    Console.WriteLine("Sait arvosanan 5");
                    break;


            }
        }
    }
}

*/
