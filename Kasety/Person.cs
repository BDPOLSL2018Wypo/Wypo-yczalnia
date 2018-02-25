using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kasety
{
    class Person
    {
        private int id;
        private string imie,nazwisko, adres, ulica, kodPocztowy, adresEmail, nrTel, rola;
        private DateTime dataUrodzenia;
        

        public string Nazwisko { get => nazwisko; set => nazwisko = value; }
        public string Imie { get => imie; set => imie = value; }
        public string Adres { get => adres; set => adres = value; }
        public string Ulica { get => ulica; set => ulica = value; }
        public string KodPocztowy { get => kodPocztowy; set => kodPocztowy = value; }
        public string AdresEmail { get => adresEmail; set => adresEmail = value; }
        public string NrTel { get => nrTel; set => nrTel = value; }
        public string Rola { get => rola; set => rola = value; }
        public DateTime DataUrodzenia { get => dataUrodzenia; set => dataUrodzenia = value; }
        public int Id { get => id; set => id = value; }

        public Person() { }
        public Person(string Name, string Surrname, string Address, string Street, string ZipCode, string PhoneNumber, string Email, string Role, DateTime BirthDate)
        {
            Imie = Name;
            Nazwisko = Surrname;
            Adres = Address;
            Ulica = Street;
            KodPocztowy = ZipCode;
            AdresEmail = Email;
            nrTel = PhoneNumber;
            rola = Role;
            DataUrodzenia = BirthDate;
        }
        public string GetName() { return Imie; }
        public string GetSurrname() { return Nazwisko; }
        public string GetAddress() { return Adres; }
        public string GetStreet() { return Ulica; }
        public string GetZipCode() { return KodPocztowy; }
        public string GetEmail() { return AdresEmail; }
        public string GetPhoneNumber() { return nrTel; }
        public string GetRole() { return rola; }
        public DateTime GetBirthDate() { return DataUrodzenia; }
        public void SetName(string Name) { Imie = Name; }
        public void SetSurrname(string Surrname) { Nazwisko = Surrname; }
        public void SetAddress(string Address) { Adres = Address; }
        public void SetStreet(string Street) { Ulica = Street; }
        public void SetZipCode(string ZipCode) { KodPocztowy = ZipCode; }
        public void SetEmail(string Email) { AdresEmail = Email; }
        public void SetPhoneNumber(string PhoneNumber) { nrTel = PhoneNumber; }
        public void SetRole(string Role) { rola = Role; }
        public void SetBirthDate(DateTime BirthDate) { DataUrodzenia = BirthDate; }
        public void SetBirthDate(int Day, int Month, int Year) { DataUrodzenia = new DateTime(Year, Month, Day); }
    }
}
