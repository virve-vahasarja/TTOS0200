/*Tee luokka, jolla on seuraavat staattiset metodit:
bool OnkoLuku(string syote) ja bool OnkoPvm(string syote) 
Metodi OnkoLuku tutkii annetun merkkijonon ja palauttaa true jos syöte on muunnettavissa 
luvuksi (kokonaisluku tai desimaaliluku erottimena pilkku, pistettä ei hyväksytä).
Metodi OnkoPvm tutkii annetun merkkijonon ja palauttaa true jos syöte on suomalaisessa 
päivämäärämuodossa siis joko muotoa "pp.kk.vv" tai "pp.kk.vvvv", eli metodi esimerkiksi 
tunnistaa seuraavat merkkijonot päivämääriksi "1.2.13", "1.10.2017", "12.12.2017", "24.12.17"
Seuraavia syötteitä ei kelpuuteta: "12,12,2016" --> väärä erotin, 
tai "12.13.2017" --> väärä kuukausi tai "30.2.2017" --> helmikuussa ei ole kolmeakymmentä päivää! 
Tee testausta varten luokka TestiPeti, ja sinne sopiva metodi jolla testaat erilaisia vaihtoehtoja.

Virve Vähäsarja
H4143
Ohjelma ei toimi
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra4
{
    static class Teht1
    {
        public bool OnkoLuku(string syote);
        public bool OnkoPvm(string syote);

        OnkoLuku if {
            syote == 
    }
}
