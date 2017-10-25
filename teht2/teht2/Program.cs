/*
 * tee toteutus, jossa CD:n sisällä olevien biisien määrää ei ole rajattu.
 * Käsittele CD:n osalta ainakin seuraavat tiedot: nimi, artisti ja biisit.
Ohjelmoi suunnittelemasi CD-luokka. Toteuta pääohjelmassa CD-olio.
Tiedot voit keksiä itse, niitä ei tarvitse kysyä käyttäjältä. Tulosta ruudulle CD:n tietoja.

Virve Vähäsarja
H4143
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht2
{
    class Program
    {
        static void Testaa()
        {
            //luodaan lista olio tyyyppiä Biisi
            List<Biisi> biisit = new List<Biisi>();
            biisit.Add(new Biisi("ekabiisi", 5));
            biisit.Add(new Biisi("tokabiisi", 5));
            biisit.Add(new Biisi("kolmasbiisi", 5));
            biisit.Add(new Biisi("neljäsbiisi", 5));

            Cd levy= new Cd("Testi", "Artistitesti", biisit);
            Console.WriteLine(levy.ToString());
        }


        static void Main(string[] args)
        {
            Testaa();
        }
    }
}