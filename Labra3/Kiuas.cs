/*Tehtävä 1
 Tehtävänäsi on ohjelmoida kiukaan toiminta. Kiuas pitää pystyä laittamaan päälle ja pois,
 sekä sen lämpötilaa että sen antamaa kosteutta pitää pystyä säätämään (arvoja ei ole rajattu).
 Toteuta Kiuas-luokan ohjelmointi sekä pääohjelma, jolla luot olion Kiuas-luokasta.
 Säädä kiuas-oliota erilaisilla arvoilla, jätä Console.WriteLine()-tulostuslauseet ohjelmaasi,
 jotta kiuas-olion käyttäminen jää näkyville.
 
 Virve Vähäsarja
 H4143

 Ohjelma ei toimi
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra3
{
    class Kiuas
    {
        public static void KiukaanToiminta()
        {
            //ominaisuudet
        public double Lampotila { get; set; }
        public double Kosteus;
        public bool Tila;

        //ominaisuudet
        get { return lampotila;}
        set {
            Lampotila = SaadaLampo();
        }

    //konstruktorit
    public Kiuas(double lampotila, double kosteus, bool tila); {
        Lampotila=lampotila;
        Kosteus=kosteus;
        Tila = tila;
        
}

            //metodit
            public void SaadaLampo() {
            Console.WriteLine("Anna lämpötila");
            Lampotila = double.Parse(Console.ReadLine());
}

            Console.WriteLine("Anna kosteus");
           Kosteus = double.Parse(Console.ReadLine());

            Console.WriteLine("Annoit arvot" + Lampotila + Kosteus);

            
        }
        

    }
}
