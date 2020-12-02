using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Webprojekt_Niederhauser.Models
{
    public enum Klasse
    {
        ccm50,ccm125,ccmViel, sonstiges
    }
    public class Artikel
    {
        public int ID { get; set; }
        public string Marke { get; set; }
        public string Bezeichnung { get; set; }
        public DateTime Baujahr { get; set; }
        public decimal Preis { get; set; }
        public Klasse Klasse { get; set; }

        public Artikel() : this(0, "", "", DateTime.MinValue, 0.0m, Klasse.sonstiges) { }

        public Artikel(int id, String marke, String bezeichnung, DateTime baujahr, decimal preis, Klasse klasse) 
        {
            this.ID = id;
            this.Marke = marke;
            this.Bezeichnung = bezeichnung;
            this.Baujahr = baujahr;
            this.Preis = preis;
            this.Klasse = Klasse;
        }
        public override string ToString()
        {
            return this.ID + " " + this.Marke + " " + this.Bezeichnung + " " + this.Baujahr + " " + this.Preis + " Euro " + this.Klasse;
        }
    }
}
