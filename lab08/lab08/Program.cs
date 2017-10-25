/*
 *Tee ohjelma, joka kirjoittaa käyttäjän antamat merkkijonot tiedostoon 
 * (lopetusehdon voit päättää itse) ja sulje tiedosto. Avaa tämän jälkeen tiedosto 
 * lukemista varten ja tulosta näyttölaitteelle tiedoston sisältö riveittäin. 
 * Huomioi mahdolliset poikkeukset, joita tiedoston käsittely voi aiheuttaa. 
 * H4143
 * Virve Vähäsarja
 * */
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab08
{
    class Program
    {
        static void Main(string[] args)
        {
            //Käytä aina try-catchia
            try
            {
                string nimi;
                string filupath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                string filu = filupath + @"\testi.txt";

                //kirjoitetaan kättäjän antamat rivit tieodstoon
                //luodaan StreamWriter-tyypinen olio johon kirjotetaan
                StreamWriter sw = new StreamWriter(filu);
                do
                {
                    Console.Write("Anna nimi(Enter lopettaa)");
                    nimi = Console.ReadLine();
                    if (nimi.Length > 0)
                        sw.WriteLine(nimi);
                }
                while (nimi.Length != 0);
                sw.Close();
                //avataan tiedosto uudestaan ja luetaan sen sisältö ja näytetään käyttäjälle
                if (File.Exists(filu))
                { 
                string teksti = File.ReadAllText(filu);
                Console.WriteLine(teksti);
                }
            }
            catch (FileNotFoundException ex)
            { Console.WriteLine("tiedostoa ei löydy");
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}
