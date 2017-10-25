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
    public class Cd
    {
        public string Nimi { get; set; }
        public string Artisti { get; set; }
        public List<Biisi> Biisit { get; set; }



        //tässä ei alusteta mitään. laitetaan muuttujiin
        public Cd(string nimi, string artisti, List<Biisi> biisilista)
        {
            Nimi = nimi;
            Artisti = artisti;
            Biisit = biisilista;
        }


        public string KerroBiisit()
        {
            string kaikkibiisit = "";
        foreach (var o in Biisit)
            {
                kaikkibiisit += o.ToString() + "\n";
            }
            return kaikkibiisit;
        }

     public override string ToString()
        {
            return Nimi +", "+ Artisti +"\n" + KerroBiisit();
        }
    }
}
