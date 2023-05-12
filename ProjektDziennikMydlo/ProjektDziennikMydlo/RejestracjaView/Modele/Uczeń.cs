namespace ProjektDziennikMydlo.RejestracjaView.Modele
{
    public class Uczeń
    {
        public string Imię { get; set; } = String.Empty;
        public string Nazwisko { get; set; } = String.Empty;
        public string Pesel { get; set; } = String.Empty;
        public string DataUrodzenia { get; set; } = String.Empty;
        public int Klasa { get; set; }
        public string Email { get; set; } = String.Empty;
    }
}
