/*
 * Ohjelmassa tulee pystyä käsittelemään työntekijöiden tietoja (Employee).
 * Työntekijöiden osalta seuraavia tietoa pitää pystyä käsittelemään:
 * työntekijän nimi (Name), työntekijän ammatti (Profession) ja palkka (Salary).
 * Samassa ohjelmassa pitää pystyä käsittelemään myös johtajien tietoja (Boss),
 * heillä on edellisten lisäksi myös auto (Car) ja palkkabonus (Bonus).

Tutki tehtävän tavoitetta/kerrontaa ja toteuta tarvittavat UML-luokkakaaviot. 
Toteuta tämän jälkeen vaaditut luokat, luo ja käytä olioita pääohjelmasta. 
Tulosta vaadittujen luokkien olioiden tietoja output-ikkunaan. 
Tietoja ei tarvitse kysyä sovelluksen käyttäjältä, vaan voit alustaa ne suoraan 
pääohjelmassa.

H4143/Virve Vähäsarja

Ohjelma ei toimi
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4

{
    class Employee
    {
        public string Nimi;
        public string Profession;
        public int Salary;

    //konstruktori
    public Employee (string nimi, string profession, int salary)
        {
            this.Nimi = nimi;
            this.Profession = profession;
            this.Salary = salary;

        }

        public string Tiedot()
        {
            return Nimi + " " + Profession + " " + Salary;
        }
    }
}
