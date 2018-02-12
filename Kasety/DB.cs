using System;
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

       



    }
}
