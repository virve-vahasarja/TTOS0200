/*
 * Toteuta ohjelma, joka tallentaa kaikki korttipelin kortit
 * (hertta, ruutu, risti ja pata. Numerot 1-52.)
 * valitsemaasi tietorakenteeseen ja tulostaa tietorakenteen sisällön.
 * 
 * Virve Vähäsarja
 * H4143
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht3
{
    class Program
    {
        static void Testaa()
        {
            List<Kortti> Korttipakka = new List<Kortti>();



            for (int i = 1; i < 14; i++)
            {
                Korttipakka.Add(new Kortti("Hertta", i));
                Korttipakka.Add(new Kortti("Pata", i));
                Korttipakka.Add(new Kortti("Ruutu", i));
                Korttipakka.Add(new Kortti("Risti", i));
            }

           
            Console.WriteLine(KortitToString (Korttipakka));
        }
            public static string KortitToString (List<Kortti> Kortteja)
            {
                string KaikkiKortit = "";
                for (int i =0; i<Kortteja.Count; i++)
                {
                    KaikkiKortit+= i+1 +" "+ Kortteja[i].ToString() + "\n";

                }
                return KaikkiKortit;            
        }
        static void Main(string[] args)
        {
            Testaa();
        }
    }
}
