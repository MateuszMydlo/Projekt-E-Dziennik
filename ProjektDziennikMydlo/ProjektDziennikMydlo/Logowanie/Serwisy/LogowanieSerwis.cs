using ProjektDziennikMydlo.Logowanie.Modele;

namespace ProjektDziennikMydlo.Logowanie.Serwisy
{
    public class LogowanieSerwis
    {
        public LogowanieInfo Zaloguj(string nazwaUrzytkownika, string hasło, bool czyUczeń)
        {



            return new LogowanieInfo() { 
                czyZalogowano=true
            };
        }
    }
}
