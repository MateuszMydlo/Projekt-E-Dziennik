using ProjektDziennikMydlo.RejestracjaView.Modele;

namespace ProjektDziennikMydlo.RejestracjaView.Eventy
{
    public class DodanieUczniaEvent : EventArgs 
    {
        public Uczeń Uczeń { get; set; }

        public DodanieUczniaEvent(Uczeń uczeń)
        {
            Uczeń = uczeń;
        }
    }
}
