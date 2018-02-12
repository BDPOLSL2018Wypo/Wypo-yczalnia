using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kasety
{
    class Person
    {
        private string Imie, Nazwisko, Adres, Ulica, KodPocztowy, AdresEmail, nrTel, Rola;
        private DateTime DataUrodzenia;
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
            Rola = Role;
            DataUrodzenia = BirthDate;
        }
        public string GetName() { return Imie; }
        public string GetSurrname() { return Nazwisko; }
        public string GetAddress() { return Adres; }
        public string GetStreet() { return Ulica; }
        public string GetZipCode() { return KodPocztowy; }
        public string GetEmail() { return AdresEmail; }
        public string GetPhoneNumber() { return nrTel; }
        public string GetRole() { return Rola; }
        public DateTime GetBirthDate() { return DataUrodzenia; }
        public void SetName(string Name) { Imie = Name; }
        public void SetSurrname(string Surrname) { Nazwisko = Surrname; }
        public void SetAddress(string Address) { Adres = Address; }
        public void SetStreet(string Street) { Ulica = Street; }
        public void SetZipCode(string ZipCode) { KodPocztowy = ZipCode; }
        public void SetEmail(string Email) { AdresEmail = Email; }
        public void SetPhoneNumber(string PhoneNumber) { nrTel = PhoneNumber; }
        public void SetRole(string Role) { Rola = Role; }
        public void SetBirthDate(DateTime BirthDate) { DataUrodzenia = BirthDate; }
        public void SetBirthDate(int Day, int Month, int Year) { DataUrodzenia = new DateTime(Year, Month, Day); }
    }
}
