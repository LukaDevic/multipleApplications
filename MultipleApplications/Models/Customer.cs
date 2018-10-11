using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MultipleApplications.Models
{
    public class Customer
    {
        public int Id { get; set; }        
        public int JMBG { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Adresa { get; set; }
        public string Telefon { get; set; }
        public string Status { get; set; } //Aktivan ili neaktivan
        public int TeorijskaObuka { get; set; }
        public int TeorijskiIspit { get; set; }
        public int PrakticnaObuka { get; set; }
        public int PrakticanIspit { get; set; }
        public int BrojDodatnihCasova { get; set; }
        public int PlacenoZaDodatneCasove { get; set; }
        public bool DaLiKoristiAkciju { get; set; }
        public int AkcijskaCena { get; set; }
        public bool PlacenoSve { get; set; }
    }
}


