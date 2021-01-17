using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ProjektWcf
{
    // UWAGA: możesz użyć polecenia „Zmień nazwę” w menu „Refaktoryzuj”, aby zmienić nazwę klasy „ObliczService” w kodzie i pliku konfiguracji.
    public class ObliczService : IObliczService
    {

        public double srednieSpalanie(double paliwo, double km )
        {
            double wynik;

            wynik = (paliwo / km) * 100;
            return wynik;
        }

        public double koszt1km(double paliwo, double km, double cena)
        {
            double wynik;

            wynik = (paliwo / km) * cena;
            return wynik;
        }

        public double koszt100km(double paliwo, double km, double cena)
        {
            double wynik;

            wynik = koszt1km(paliwo, km, cena) * 100;
            return wynik;
        }

        public double kosztXkm(double paliwo, double km, double cena)
        {
            double wynik;

            wynik = koszt1km(paliwo, km, cena) * km;
            return wynik;
        }
    }
}
