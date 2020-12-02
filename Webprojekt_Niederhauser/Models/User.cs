using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Webprojekt_Niederhauser.Models
{
    public enum Geschlecht
    {
        male, female, notSpecified
    }
    public class User
    {
            public string Vorname { get; set; }
            public string Nachname { get; set; }
            public Geschlecht Geschlecht { get; set; }
            public DateTime Geburtsdatum { get; set; }
            public string Email { get; set; }

            public string Passwort { get; set; }

            public User() : this("", "", Geschlecht.notSpecified, DateTime.MinValue, "", "") { }

            public User(String vorname, String nachname, Geschlecht geschlecht, DateTime geburtsdatum, string email, string passwort)
            {
                this.Vorname = vorname;
                this.Nachname = nachname;
                this.Geschlecht = geschlecht;
                this.Geburtsdatum = geburtsdatum;
                this.Email = email;
                this.Passwort = passwort;
            }
            public override string ToString()
            {
                return this.Vorname + " " + this.Nachname + " " + this.Geschlecht + " " + this.Geburtsdatum + " " + this.Email + " " + this.Passwort;
            }

        
    }
}
