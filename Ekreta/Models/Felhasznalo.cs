using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ekreta.Models
{
    public class Felhasznalo
    {
        public Felhasznalo()
        {
        }

        public Felhasznalo(string felhasznaloNev, string jelszo, string teljesNev, int szerepkor)
        {
            FelhasznaloNev = felhasznaloNev;
            Jelszo = jelszo;
            TeljesNev = teljesNev;
            Szerepkor = szerepkor;
        }
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string FelhasznaloNev { get; set; }
        public string Jelszo { get; set; }
        public string TeljesNev { get; set; }
        public int Szerepkor { get; set; }
    }
}
