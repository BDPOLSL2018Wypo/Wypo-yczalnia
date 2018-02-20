﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

/*
 * 
 * Dodawanie userów jest
 * Wyciąganie userów po id jest
 * Dodawanie tytułów jest
 * Tworzenie tabel jest
 * 
 * 
 * 
 * */
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
            }
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

            query = "CREATE TABLE IF NOT EXISTS Wypozyczenia(IdWypozyczenia INTEGER PRIMARY KEY, IdPracownikaWypozyczajacego INT(32), IdPracownikaPrzymujacego INT(32), IdKlienta INT(32), IdLista INT(32), Data DATETIME)";
            command = new SQLiteCommand(query, con);
            command.ExecuteNonQuery();

            query = "CREATE TABLE IF NOT EXISTS ListaKasetWypozyczenia(IdWypozyczenia INTEGER PRIMARY KEY, IdKasety INT(32))";
            command = new SQLiteCommand(query, con);
            command.ExecuteNonQuery();

            query = "CREATE TABLE IF NOT EXISTS Kolejka(IdKolejki INTEGER PRIMARY KEY, IdKlienta INT(32), IdTytulu INT(32))";
            command = new SQLiteCommand(query, con);
            command.ExecuteNonQuery();

            query = "CREATE TABLE IF NOT EXISTS Ustawienia(IdUstawienia INTEGER PRIMARY KEY, WysokoscKary INT(32), IloscDniDoZwrotu INT(32))";
            command = new SQLiteCommand(query, con);
            command.ExecuteNonQuery();
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
            string query = "UPDATE OSOBY SET Imie='"+Imie+"', Nazwisko='"+Nazwisko+"', DataUrodzenia='"+ DataUrodzenia.ToString("yyyy-MM-dd")+"', Adres='"+Adres+"', Ulica='"+Ulica+"', KodPocztowy='"+KodPocztowy+"', Email='"+Email+"', NrTel='"+NrTelefonu+"' WHERE IdOsoby='"+id.ToString()+"';";
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

        public bool OdpierdolWypozyczenie(int IdPracownikaWypozyczajacego,
                                          int IdKlienta,
                                          List<string> Kasety)
        {
            DateTime now = new DateTime();
            int IdListy=0;
            string query = "SELECT MAX(IdWypozyczenia) FROM ListaKasetWypozyczenia";
            SQLiteCommand command = new SQLiteCommand(query, con);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Int32.TryParse(reader["IdWypozyczenia"].ToString(), out IdListy);
            }
            IdListy++;
            foreach (string Kaseta in Kasety)
            {
                query = "INSERT INTO ListaKasetWypozyczenia (IdWypozyczenia, IdKasety) VALUES ('" + IdListy.ToString() +"','"+ Kaseta +"'";
                command = new SQLiteCommand(query, con);
                command.ExecuteNonQuery();
                query = "UPADETE TABLE Kasety SET Dostepnosc=0 WHERE IdKasety='"+Kaseta+"'";
            }
            query = "INSERT INTO Wypozyczenia (IdPracownikaWypozyczajacego, IdPracownikaPrzyjmujacego, IdKlienta, IdLista, Data) VALUES ('"+IdPracownikaWypozyczajacego.ToString()+"', 'empty'," +
                    "'"+IdListy.ToString()+"', '"+IdKlienta.ToString()+"', '"+now.ToString("yyyy-MM-dd") + "')";
            command = new SQLiteCommand(query, con);
            command.ExecuteNonQuery();
            return true;
        }

        public void OdpierdolOddanieKasety(int IdPracownikaPrzyjmujacego, int idKlienta, List<string> ListaKaset)
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

        }

        public double TwojaStara()
        {
            con.Close();
            return 666.00073;
        }

    }
}
