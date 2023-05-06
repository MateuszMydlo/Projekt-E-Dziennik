using MySql.Data.MySqlClient;
using ProjektDziennikMydlo.Logowanie.Modele;

namespace ProjektDziennikMydlo.Logowanie.Serwisy
{
    public class LogowanieSerwis
    {
        public LogowanieInfo Zaloguj(string nazwaUrzytkownika, string hasłoZInputa, bool czyUczeń)
        {
            string connectionString = Form1.MyGlobals.connSTR;//pobiera string globalny wymagany do polaczenia sie z DB

            string? nazwaTabeli;
            string rola = "";

            if (czyUczeń)
            {
                nazwaTabeli = "students";
            } else
            {
                nazwaTabeli = "teachers";
                rola = ", permissions";
            }

            string query = $"SELECT password {rola} FROM {nazwaTabeli} WHERE email='{nazwaUrzytkownika}'";
            MySqlConnection conn = new MySqlConnection(connectionString);
            MySqlCommand exec = new MySqlCommand(query, conn);
            exec.CommandTimeout = 60;
            MySqlDataReader result;
            try
            {
                conn.Open();
                result = exec.ExecuteReader();
                if (result.HasRows)
                {
                    while (result.Read())
                    {
                        var hasłoZBazyDanych= result.GetString(0);

                        var rolaEnum = Rola.Uczeń;
                        if (!czyUczeń)
                        {
                            var rolaZBazyDanych = result.GetString(1);

                            //Tutaj sprawdzam czy jest wicedyrektorem bo wice jest o numerze 2
                            if(rolaZBazyDanych ==  "2")
                            {
                                rolaEnum = Rola.SuperUser;
                            } else
                            {
                                rolaEnum = Rola.Nauczyciel;
                            }
                        }

                        if (hasłoZBazyDanych == hasłoZInputa)
                        {
                            return new LogowanieInfo()
                            {
                                czyZalogowano = true,
                                Rola = rolaEnum
                            };
                        } else
                        {
                            return new LogowanieInfo()
                            {
                                czyZalogowano = false
                            };
                        }

                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                return new LogowanieInfo()
                {
                    czyZalogowano = false
                };
            }

            return new LogowanieInfo()
            {
                czyZalogowano = false
            };
        }
    }
}
