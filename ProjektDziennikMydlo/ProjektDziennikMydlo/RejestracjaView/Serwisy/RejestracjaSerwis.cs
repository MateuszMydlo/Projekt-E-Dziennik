using MySql.Data.MySqlClient;
using ProjektDziennikMydlo.RejestracjaView.Modele;
using System.Text;

namespace ProjektDziennikMydlo.RejestracjaView.Serwisy
{
    public class RejestracjaSerwis
    {
        public void ZapiszNowychUczniów(List<Uczeń> listaUczniówDoDodania)
        {
            if (!listaUczniówDoDodania.Any())
            {
                return;
            }

            var valuesToAdd = new List<string>();
            listaUczniówDoDodania.ForEach(u =>
            {
                var hasło = CreatePassword(10);
                valuesToAdd.Add($"VALUES('{u.Imię}', '{u.Nazwisko}', '{u.Pesel}', '{u.DataUrodzenia}', '{u.Klasa}', '{hasło}', '{u.Email}')");
            });

            string connectionString = Form1.MyGlobals.connSTR;//pobiera string globalny wymagany do polaczenia sie z DB
            string query = $"INSERT INTO `students` (`name`, `surname`, `pesel`, `bth_date`, `class`, `password`, `email`) {String.Join(',', valuesToAdd.ToArray())}";
            MySqlConnection conn = new MySqlConnection(connectionString);
            MySqlCommand exec = new MySqlCommand(query, conn);
            exec.CommandTimeout = 60;
            MySqlDataReader result;
            try
            {
                conn.Open();
                result = exec.ExecuteReader();
                conn.Close();
            }
            catch (Exception ex){}
        }

        private string CreatePassword(int length)
        {
            const string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            StringBuilder res = new StringBuilder();
            Random rnd = new Random();
            while (0 < length--)
            {
                res.Append(valid[rnd.Next(valid.Length)]);
            }
            return res.ToString();
        }
    }
}
