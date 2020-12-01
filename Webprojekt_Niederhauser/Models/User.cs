using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Webprojekt_Niederhauser.Models
{
    public class User
    {
        public enum Geschlecht
        {
            male, female, notSpecified
        }

            public string Vorname { get; set; }
            public string Nachname { get; set; }
            public Geschlecht geschlecht { get; set; }
            public DateTime Geburtsdatum { get; set; }
            public string Email { get; set; }

            public string Passwort { get; set; }

            public User() : this("", "", Geschlecht.notSpecified, DateTime.MinValue, "", "") { }

            public User(String vorname, String nachname, Geschlecht geschlecht, DateTime geburtsdatum, string email, string passwort)
            {
                this.Vorname = vorname;
                this.Nachname = nachname;
                this.geschlecht = geschlecht;
                this.Geburtsdatum = geburtsdatum;
                this.Email = email;
                this.Passwort = passwort;
            }
            public override string ToString()
            {
                return this.Vorname + " " + this.Nachname + " " + this.geschlecht + " " + this.Geburtsdatum + " " + this.Email + " " + this.Passwort;
            }

        
    }
}
