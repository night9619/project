using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ProjektWcf
{
    // UWAGA: możesz użyć polecenia „Zmień nazwę” w menu „Refaktoryzuj”, aby zmienić nazwę interfejsu „IObliczService” w kodzie i pliku konfiguracji.
    [ServiceContract]
    public interface IObliczService
    {
        [OperationContract]
        double srednieSpalanie(double paliwo, double km);

        [OperationContract]
        double koszt1km(double paliwo, double km, double cena);

        [OperationContract]
        double koszt100km(double paliwo, double km, double cena);

        [OperationContract]
        double kosztXkm(double paliwo, double km, double cena);
    }
}
