using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Text.RegularExpressions;
using System.Media;

namespace Kasety
{
    class DB
    {
        SQLiteConnection con;

        public DB()
        {
            if (!System.IO.File.Exists("KasetyDB.sqlite"))
            {
                SQLiteConnection.CreateFile("KasetyDB.sqlite");

                con = new SQLiteConnection("Data Source=KasetyDB.sqlite;Version=3;");
                con.Open();

                string query = "CREATE TABLE IF NOT EXISTS OSOBY (IdOsoby INTEGER PRIMARY KEY AUTOINCREMENT, Imie varchar(128), Nazwisko varchar(128), DataUrodzenia DateTime, Adres varchar(128), Ulica varchar(128), KodPocztowy varchar(16), Email varchar(128), nrTel varchar(128), Rola varchar(16))";
                SQLiteCommand command = new SQLiteCommand(query, con);
                command.ExecuteNonQuery();

                query = "CREATE TABLE IF NOT EXISTS Kasety (IdKasety INTEGER PRIMARY KEY, IdTytulu int(32), Dostepnosc BOOL)";
                command = new SQLiteCommand(query, con);
                command.ExecuteNonQuery();

                query = "CREATE TABLE IF NOT EXISTS Tytuly(IdTytulu INTEGER PRIMARY KEY, Tytul varchar(32), IdGatunku INT(32), KategoriaWiekowa INT(32), IdRezysera INT(32), Cena INT(32))";
                command = new SQLiteCommand(query, con);
                command.ExecuteNonQuery();

                query = "CREATE TABLE IF NOT EXISTS Rezyserzy(IdRezysera INTEGER PRIMARY KEY, Imie varchar(128), Nazwisko varchar(128))";
                command = new SQLiteCommand(query, con);
                command.ExecuteNonQuery();

                query = "CREATE TABLE IF NOT EXISTS Gatunki(IdGatunku INTEGER PRIMARY KEY, Gatunek varchar(128))";
                command = new SQLiteCommand(query, con);
                command.ExecuteNonQuery();

                query = "CREATE TABLE IF NOT EXISTS Wypozyczenia(IdWypozyczenia INTEGER PRIMARY KEY, IdPracownikaWypozyczajacego INT(32), IdPracownikaPrzyjmujacego INT(32), IdKlienta INT(32), IdLista INT(32), Data DATETIME)";
                command = new SQLiteCommand(query, con);
                command.ExecuteNonQuery();

                query = "CREATE TABLE IF NOT EXISTS ListaKasetWypozyczenia(IdWypozyczenia INTEGER, IdKasety INT(32))";
                command = new SQLiteCommand(query, con);
                command.ExecuteNonQuery();

                query = "CREATE TABLE IF NOT EXISTS Kolejka(IdKolejki INTEGER PRIMARY KEY, IdKlienta INT(32), IdTytulu INT(32))";
                command = new SQLiteCommand(query, con);
                command.ExecuteNonQuery();

                query = "CREATE TABLE IF NOT EXISTS Ustawienia(IdUstawienia INTEGER PRIMARY KEY, WysokoscKary INT(32), IloscDniDoZwrotu INT(32))";
                command = new SQLiteCommand(query, con);
                command.ExecuteNonQuery();

                query = "INSERT INTO Ustawienia (IdUstawienia, WysokoscKary, IloscDniDoZwrotu) VALUES (1, 0, 14)";
                command = new SQLiteCommand(query, con);
                command.ExecuteNonQuery();
            }
            else
            {
                con = new SQLiteConnection("Data Source=KasetyDB.sqlite;Version=3;");
                con.Open();
            }
        }

        public void insertUser(string Imie, string Nazwisko, DateTime DataUrodzenia, string Adres, string Ulica, string KodPocztowy, string Email, string NrTelefonu, string Rola)
        {
            int day = DataUrodzenia.Day; int month = DataUrodzenia.Month; int year = DataUrodzenia.Year;
            string query = "INSERT INTO OSOBY (Imie, Nazwisko, DataUrodzenia, Adres, Ulica, KodPocztowy, Email, nrTel, Rola) VALUES ('" + Imie + "','" + Nazwisko + "','" + DataUrodzenia.ToString("yyyy-MM-dd") + "','" + Adres + "','" + Ulica
                + "','" + KodPocztowy + "','" + Email + "','" + NrTelefonu + "','" + Rola + "')";
            SQLiteCommand command = new SQLiteCommand(query, con);
            command.ExecuteNonQuery();
        }

        public Person retriveUser(int id)
        {
            Person person = new Person();
            string query = "SELECT * FROM OSOBY WHERE IdOsoby=" + id.ToString();
            SQLiteCommand command = new SQLiteCommand(query, con);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                person.Id = Int32.Parse(reader["IdOsoby"].ToString());
                person.SetName(reader["Imie"].ToString());
                person.SetSurrname(reader["Nazwisko"].ToString());
                person.SetAddress(reader["Adres"].ToString());
                person.SetStreet(reader["Ulica"].ToString());
                person.SetZipCode(reader["KodPocztowy"].ToString());
                person.SetPhoneNumber(reader["nrTel"].ToString());
                person.SetEmail(reader["Email"].ToString());
                person.SetRole(reader["Rola"].ToString());
                person.SetBirthDate(DateTime.Parse(reader["DataUrodzenia"].ToString()));
            }
            return person;
        }
        public List<Person> retriveUser()
        {
            List<Person> list = new List<Person>();
            string query = "SELECT * FROM OSOBY";
            SQLiteCommand command = new SQLiteCommand(query, con);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Person person = new Person();
                person.Id = Int32.Parse(reader["IdOsoby"].ToString());
                person.SetName(reader["Imie"].ToString());
                person.SetSurrname(reader["Nazwisko"].ToString());
                person.SetAddress(reader["Adres"].ToString());
                person.SetStreet(reader["Ulica"].ToString());
                person.SetZipCode(reader["KodPocztowy"].ToString());
                person.SetPhoneNumber(reader["nrTel"].ToString());
                person.SetEmail(reader["Email"].ToString());
                person.SetRole(reader["Rola"].ToString());
                person.SetBirthDate(DateTime.Parse(reader["DataUrodzenia"].ToString()));
                list.Add(person);
            }
            return list;
        }
        public List<Person> retriveSprzedawcy()
        {
            List<Person> list = new List<Person>();
            string query = "SELECT * FROM OSOBY WHERE Rola='Pracownik'";
            SQLiteCommand command = new SQLiteCommand(query, con);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Person person = new Person();
                person.Id = Int32.Parse(reader["IdOsoby"].ToString());
                person.SetName(reader["Imie"].ToString());
                person.SetSurrname(reader["Nazwisko"].ToString());
                person.SetAddress(reader["Adres"].ToString());
                person.SetStreet(reader["Ulica"].ToString());
                person.SetZipCode(reader["KodPocztowy"].ToString());
                person.SetPhoneNumber(reader["nrTel"].ToString());
                person.SetEmail(reader["Email"].ToString());
                person.SetRole(reader["Rola"].ToString());
                person.SetBirthDate(DateTime.Parse(reader["DataUrodzenia"].ToString()));
                list.Add(person);
            }
            return list;
        }

        public void updateUser(int id, string Imie, string Nazwisko, DateTime DataUrodzenia, string Adres, string Ulica, string KodPocztowy, string Email, string NrTelefonu, string Rola)
        {
            string query = "UPDATE OSOBY SET Imie='"+Imie+"', Nazwisko='"+Nazwisko+"', DataUrodzenia='"+ DataUrodzenia.ToString("yyyy-MM-dd")+"', Adres='"+Adres+"', Ulica='"+Ulica+"', KodPocztowy='"+KodPocztowy+"', Email='"+Email+"', NrTel='"+NrTelefonu+"',Rola='"+Rola+"' WHERE IdOsoby='"+id.ToString()+"';";
            SQLiteCommand command = new SQLiteCommand(query, con);
            command.ExecuteNonQuery();
        }

        public void insertTitle(string Title, string Gatunek, string RezyserImie, string RezyserNazwisko, int KategoriaWiekowa, int Cena)
        {
            int idGatunku = -1; int idRezysera = -1;
            string query = "SELECT * FROM Gatunki";
            SQLiteCommand command = new SQLiteCommand(query, con);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (reader["Gatunek"].ToString().Equals(Gatunek.ToString())) Int32.TryParse(reader["IdGatunku"].ToString(), out idGatunku);
            }
            if (idGatunku.Equals(-1))
            {
                query = "INSERT INTO GATUNKI (Gatunek) VALUES ('"+Gatunek+"')";
                command = new SQLiteCommand(query, con);
                command.ExecuteNonQuery();
                query = "SELECT * FROM Gatunki";
                command = new SQLiteCommand(query, con);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    if (reader["Gatunek"].ToString().Equals(Gatunek)) Int32.TryParse(reader["IdGatunku"].ToString(), out idGatunku);
                }
            }
            query = "SELECT * FROM Rezyserzy";
            command = new SQLiteCommand(query, con);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (reader["Imie"].ToString().Equals(RezyserImie) && reader["Nazwisko"].ToString().Equals(RezyserNazwisko)) Int32.TryParse(reader["IdRezysera"].ToString(), out idRezysera);
            }
            if (idRezysera.Equals(-1))
            {
                query = "INSERT INTO Rezyserzy (Imie, Nazwisko) VALUES ('" + RezyserImie + "','"+RezyserNazwisko+"')";
                command = new SQLiteCommand(query, con);
                command.ExecuteNonQuery();
                query = "SELECT * FROM Rezyserzy";
                command = new SQLiteCommand(query, con);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    if (reader["Imie"].ToString().Equals(RezyserImie) && reader["Nazwisko"].ToString().Equals(RezyserNazwisko)) Int32.TryParse(reader["IdRezysera"].ToString(), out idRezysera);
                }
            }
            query = "INSERT INTO Tytuly (Tytul, IdGatunku, KategoriaWiekowa, IdRezysera, Cena) VALUES ('"+Title+"', '"+idGatunku.ToString()+"', '"+KategoriaWiekowa.ToString()+"', '"+idRezysera.ToString()+"', '"+Cena.ToString()+"')";
            command = new SQLiteCommand(query, con);
            command.ExecuteNonQuery();
        }

        public bool InsertCassette(string title, string genre,string name, string lname, int agecat, int price)
        {
            int idTitle = -1;
            string query = "SELECT * FROM Tytuly";
            SQLiteCommand command = new SQLiteCommand(query, con);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (reader["Tytul"].ToString().Equals(title)) Int32.TryParse(reader["IdTytulu"].ToString(), out idTitle);
            }
            if (idTitle.Equals(-1))
            {
                insertTitle(title, genre, name, lname, agecat, price);
                query = "SELECT IdTytulu FROM Tytuly WHERE Tytul='" + title + "';";
                command = new SQLiteCommand(query, con);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Int32.TryParse(reader["IdTytulu"].ToString(), out idTitle);
                }
            }
            query = "INSERT INTO Kasety (IdTytulu, Dostepnosc) VALUES (" + idTitle + ", 1);";
            command = new SQLiteCommand(query, con);
            command.ExecuteNonQuery();
            //insert kasety;
            return true;
        }

        public void updateCassette(string idkasety, string title, string genre, string name, string lname, int agecat, int price)
        {
            string query = "SELECT * FROM Gatunki"; string idgatunku = "", idrezysera = "";
            SQLiteCommand command = new SQLiteCommand(query, con);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (reader["Gatunek"].ToString().Equals(genre)) idgatunku = reader["IdGatunku"].ToString();
            }
            if (idgatunku.Length == 0)
            {
                query = "INSERT INTO Gatunki (Gatunek) VALUES ('" + genre + "');";
                command = new SQLiteCommand(query, con);
                command.ExecuteNonQuery();
                query = "SELECT * FROM Gatunki";
                command = new SQLiteCommand(query, con);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    if (reader["Gatunek"].ToString().Equals(genre)) idgatunku = reader["IdGatunku"].ToString();
                }
            }

            query = "SELECT * FROM Rezyserzy";
            command = new SQLiteCommand(query, con);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (reader["Imie"].ToString().Equals(name) && reader["Nazwisko"].ToString().Equals(lname)) idrezysera = reader["IdRezysera"].ToString();
            }
            if (idrezysera.Length == 0)
            {
                query = "INSERT INTO Rezyserzy (Imie, Nazwisko) VALUES ('" + name + "','" + lname + "');";
                command = new SQLiteCommand(query, con);
                command.ExecuteNonQuery();
                query = "SELECT * FROM Rezyserzy";
                command = new SQLiteCommand(query, con);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    if (reader["Imie"].ToString().Equals(name) && reader["Nazwisko"].ToString().Equals(lname)) idrezysera = reader["IdRezysera"].ToString();
                }
            }

            query = "UPDATE Tytuly SET Tytul='" + title + "', IdGatunku='" + idgatunku + "', IdRezysera='" + idrezysera + "', KategoriaWiekowa='" + agecat.ToString() + "', Cena='" + price.ToString() + "' WHERE IdTytulu='" + idkasety + "'";
            command = new SQLiteCommand(query, con);
            command.ExecuteNonQuery();
        }

        public List<Cassette> getList()
        {
            string query = "SELECT K.IdKasety,K.Dostepnosc,T.Tytul,T.Cena,T.KategoriaWiekowa,G.Gatunek,R.Imie,R.Nazwisko FROM Kasety K, Tytuly T, Gatunki G, Rezyserzy R WHERE K.IdTytulu=T.IdTytulu AND T.IdGatunku=G.IdGatunku AND T.IdRezysera=R.IdRezysera;";
            List<Cassette> lista = new List<Cassette>();
            SQLiteCommand command = new SQLiteCommand(query, con);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int id;
                Int32.TryParse(reader["IdKasety"].ToString(), out id);
                string title = reader["Tytul"].ToString();
                string genre = reader["Gatunek"].ToString() ;
                string director = reader["Imie"].ToString()+' '+reader["Nazwisko"].ToString();
                int age;
                Int32.TryParse(reader["KategoriaWiekowa"].ToString(), out age) ;
                int price;
                Int32.TryParse(reader["Cena"].ToString(), out price);
                bool av;
                bool.TryParse(reader["Dostepnosc"].ToString(), out av);
                Cassette cas = new Cassette(id, title, genre, director, age, price, av);
                lista.Add(cas);
            }
            return lista;
        }
        public List<Cassette> getList(string tytul)
        {
            string query = "SELECT K.IdKasety,K.Dostepnosc,T.Tytul,T.Cena,T.KategoriaWiekowa,G.Gatunek,R.Imie,R.Nazwisko FROM Kasety K, Tytuly T, Gatunki G, Rezyserzy R WHERE K.IdTytulu=T.IdTytulu AND T.IdGatunku=G.IdGatunku AND T.IdRezysera=R.IdRezysera AND T.Tytul='"+tytul+"';";
            List<Cassette> lista = new List<Cassette>();
            SQLiteCommand command = new SQLiteCommand(query, con);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int id;
                Int32.TryParse(reader["IdKasety"].ToString(), out id);
                string title = reader["Tytul"].ToString();
                string genre = reader["Gatunek"].ToString();
                string director = reader["Imie"].ToString() + ' ' + reader["Nazwisko"].ToString();
                int age;
                Int32.TryParse(reader["KategoriaWiekowa"].ToString(), out age);
                int price;
                Int32.TryParse(reader["Cena"].ToString(), out price);
                bool av;
                bool.TryParse(reader["Dostepnosc"].ToString(), out av);
                Cassette cas = new Cassette(id, title, genre, director, age, price, av);
                lista.Add(cas);
            }
            return lista;
        }
        public List<Cassette> getKaseta()
        {
            string query = "SELECT K.IdKasety,K.Dostepnosc,T.Tytul,T.Cena,T.KategoriaWiekowa,G.Gatunek,R.Imie,R.Nazwisko FROM Kasety K, Tytuly T, Gatunki G, Rezyserzy R WHERE K.IdTytulu=T.IdTytulu AND T.IdGatunku=G.IdGatunku AND T.IdRezysera=R.IdRezysera;";
            List<Cassette> lista = new List<Cassette>();
            SQLiteCommand command = new SQLiteCommand(query, con);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int id;
                Int32.TryParse(reader["IdKasety"].ToString(), out id);
                string title = reader["Tytul"].ToString();
                string genre = reader["Gatunek"].ToString();
                string director = reader["Imie"].ToString() + ' ' + reader["Nazwisko"].ToString();
                int age;
                Int32.TryParse(reader["KategoriaWiekowa"].ToString(), out age);
                int price;
                Int32.TryParse(reader["Cena"].ToString(), out price);
                bool av;
                bool.TryParse(reader["Dostepnosc"].ToString(), out av);
                Cassette cas = new Cassette(id, title, genre, director, age, price, av);
                lista.Add(cas);
            }
            return lista;
        }
        public List<Titles> getTitles()
        {
            string query = "SELECT T.IdTytulu,T.Tytul,T.Cena,T.KategoriaWiekowa,G.Gatunek,R.Imie,R.Nazwisko FROM Tytuly T, Gatunki G, Rezyserzy R WHERE T.IdGatunku=G.IdGatunku AND T.IdRezysera=R.IdRezysera;";
            List<Titles> lista = new List<Titles>();
            SQLiteCommand command = new SQLiteCommand(query, con);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int id = Int32.Parse(reader["IdTytulu"].ToString());
                
                string title = reader["Tytul"].ToString();
                string genre = reader["Gatunek"].ToString();
                string director = reader["Imie"].ToString() + ' ' + reader["Nazwisko"].ToString();
                int age;
                Int32.TryParse(reader["KategoriaWiekowa"].ToString(), out age);
                int price;
                Int32.TryParse(reader["Cena"].ToString(), out price);
                
                Titles cas = new Titles(id, title, genre, director, age, price);
                lista.Add(cas);
            }
            return lista;
        }
        public Title getTitles(int index)
        {
            string query = "SELECT T.IdTytulu,T.Tytul,T.Cena,T.KategoriaWiekowa,G.Gatunek,R.Imie,R.Nazwisko FROM Tytuly T, Gatunki G, Rezyserzy R WHERE T.IdTytulu='"+index+"' AND T.IdGatunku=G.IdGatunku AND T.IdRezysera=R.IdRezysera;";
            Title t = new Title() ;
            SQLiteCommand command = new SQLiteCommand(query, con);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int id = Int32.Parse(reader["IdTytulu"].ToString());

                t.Titl = reader["Tytul"].ToString();
                t.Genre = reader["Gatunek"].ToString();
                
                t.DirectorName = reader["Imie"].ToString();
                t.DirectorLastName=reader["Nazwisko"].ToString();
                int age;
                Int32.TryParse(reader["KategoriaWiekowa"].ToString(), out age);
                t.Age = age;
                int price;
                Int32.TryParse(reader["Cena"].ToString(), out price);
                t.Price = price;

                 
                
            }
            return t;
        }

        public bool Wypozyczenie(int IdPracownikaWypozyczajacego,
                                          int IdKlienta,
                                          List<string> Kasety)
        {
            DateTime now = new DateTime(); now = DateTime.Now;
            int IdListy=0;
            string query = "SELECT IdWypozyczenia FROM ListaKasetWypozyczenia";
            SQLiteCommand command = new SQLiteCommand(query, con);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                if(!reader.HasRows) { IdListy = 1; break; }
                Int32.TryParse(reader["IdWypozyczenia"].ToString(), out IdListy);
            }
            IdListy++;
            foreach (string Kaseta in Kasety)
            {
                query = "INSERT INTO ListaKasetWypozyczenia (IdWypozyczenia, IdKasety) VALUES ('" + IdListy.ToString() +"','"+ Kaseta +"')";
                command = new SQLiteCommand(query, con);
                command.ExecuteNonQuery();
                query = "UPDATE Kasety SET Dostepnosc = 0 WHERE IdKasety='"+Kaseta+"'";
                command = new SQLiteCommand(query, con);
                command.ExecuteNonQuery();
            }
            query = "INSERT INTO Wypozyczenia (IdPracownikaWypozyczajacego, IdPracownikaPrzyjmujacego, IdKlienta, IdLista, Data) VALUES ('"+IdPracownikaWypozyczajacego.ToString()+"', 'empty'," +
                    "'"+IdKlienta.ToString()+"', '"+IdListy.ToString()+"', '"+now.ToString("yyyy-MM-dd") + "')";
            command = new SQLiteCommand(query, con);
            command.ExecuteNonQuery();
            return true;
        }

        public ReturnTheCassette Oddanie(int IdPracownikaPrzyjmujacego, int idKasety)
        {
            int pay=0, price=0, DaysToReturn=0, punishment=0;
            string query = "SELECT WysokoscKary, IloscDniDoZwrotu FROM USTAWIENIA";
            SQLiteCommand command = new SQLiteCommand(query, con);
            SQLiteDataReader reader= command.ExecuteReader();
            while(reader.Read())
            {
                Int32.TryParse(reader["WysokoscKary"].ToString(), out punishment);
                Int32.TryParse(reader["IloscDniDoZwrotu"].ToString(), out DaysToReturn);
            }
            query = "SELECT IdTytulu FROM KASETY WHERE IdKasety='" + idKasety + "'";
            command = new SQLiteCommand(query, con);
            reader = command.ExecuteReader();
            string idtytulu = "";
            while(reader.Read())
            {
                idtytulu = reader["IdTytulu"].ToString();
            }
            query = "SELECT Cena FROM Tytuly WHERE IdTytulu='" + idtytulu + "'";
            command = new SQLiteCommand(query, con);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                Int32.TryParse(reader["Cena"].ToString(), out price);
            }
            pay += price;
            query = "UPDATE Kasety SET Dostepnosc=1 WHERE IdKasety='" + idKasety + "'";
            command = new SQLiteCommand(query, con);
            command.ExecuteNonQuery();

            int idListyWypozyczenia = 0;
            query = "SELECT * FROM ListaKasetWypozyczenia WHERE IdKasety=" + idKasety + "";
            command = new SQLiteCommand(query, con);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                Int32.TryParse(reader["IdWypozyczenia"].ToString(), out idListyWypozyczenia);
            }
            query = "DELETE FROM ListaKasetWypozyczenia WHERE IdKasety='"+idKasety+"'";
            command = new SQLiteCommand(query, con);
            command.ExecuteNonQuery();

            query = "SELECT * FROM Wypozyczenia WHERE IdLista=" + idListyWypozyczenia + "";
            command = new SQLiteCommand(query, con);
            reader = command.ExecuteReader(); DateTime DataWypozyczenia=new DateTime(), teraz; double delay;
            while (reader.Read())
            {
                DataWypozyczenia = DateTime.Parse(reader["Data"].ToString());
            }
            teraz = DateTime.Now;
            delay = (teraz - DataWypozyczenia).TotalDays;
            delay -= getIloscDniDoZwrotu();
            if (delay < 0) delay = 0;
            for (int i = 0; i < delay; i++) pay += punishment;

            int idKlientaWKolejce = 0;
            query = "SELECT * FROM Kolejka WHERE IdTytulu="+idtytulu+" LIMIT 1";
            command = new SQLiteCommand(query, con);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                Int32.TryParse(reader["IdKlienta"].ToString(), out idKlientaWKolejce);
            }

            return new ReturnTheCassette(pay, delay, idKlientaWKolejce);
        }

        public void AddClientToQueue(string IdKlienta, string IdTytulu)
        {
            string query = "INSERT INTO Kolejka (IdKlienta, IdTytulu) VALUES ('" + IdKlienta + "', '" + IdTytulu + "');";
            SQLiteCommand command = new SQLiteCommand(query, con);
            command.ExecuteNonQuery();
        }

        public double TwojaStara()
        {
            con.Close();
            return 666.00073;
        }

        public void SetSettings(int WysokoscKary, int IloscDniDoZwrotu)
        {
            string query = "UPDATE Ustawienia SET WysokoscKary='"+WysokoscKary.ToString()+"', IloscDniDoZwrotu='"+IloscDniDoZwrotu.ToString()+"' WHERE IdUstawienia=1";
            SQLiteCommand command = new SQLiteCommand(query, con);
            command.ExecuteNonQuery();
        }

        public int getIloscDniDoZwrotu()
        {
            int x=0;
            string query = "SELECT IloscDniDoZwrotu FROM Ustawienia WHERE IdUstawienia=1";
            SQLiteCommand command = new SQLiteCommand(query, con);
            SQLiteDataReader reader= command.ExecuteReader();
            while (reader.Read())
            {
                Int32.TryParse(reader["IloscDniDoZwrotu"].ToString(), out x);
            }
            return x;
        }

        public int getKara()
        {
            int x = 0;
            string query = "SELECT WysokoscKary FROM Ustawienia WHERE IdUstawienia=1";
            SQLiteCommand command = new SQLiteCommand(query, con);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Int32.TryParse(reader["WysokoscKary"].ToString(), out x);
            }
            return x;
        }

        public bool EscapeSQL(string makesurethisshitaintaquery)
        {
            string s = makesurethisshitaintaquery;

            string pat = "DROP TABLE|INSERT|DELETE|UPDATE TABLE|INNER JOIN|JOIN LEFT|JOIN RIGHT|SELECT|DROP DATABASE|;|--| --| ==| -- |.--.";
            Regex r = new Regex(pat, RegexOptions.IgnoreCase);
            Match match = r.Match(s);
            if(match.Success)
            {
                SystemSounds.Beep.Play();
                return true;
            }
            return false;
        }

        public bool isAvailable(int id)
        {

            string query = "SELECT Dostepnosc FROM Kasety WHERE IdKasety=" + id + ";";
            SQLiteCommand command = new SQLiteCommand(query, con);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                bool av;
                bool.TryParse(reader["Dostepnosc"].ToString(), out av);
                return av;
            }
            return false;
        }

        public bool isAvailableByTitle(int id)
        {

            string query = "SELECT Dostepnosc FROM Kasety WHERE IdTytulu=" + id + ";";
            SQLiteCommand command = new SQLiteCommand(query, con);
            SQLiteDataReader reader = command.ExecuteReader();
            bool av=false;
            while (reader.Read())
            {
                if (bool.Parse(reader["Dostepnosc"].ToString()) == true)
                {
                    av = true;
                }
                
                
            }
            return av;
            
        }

    }
}
