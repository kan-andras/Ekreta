using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ekreta.Models
{
    public class Osztaly
    {
        public Osztaly()
        {
        }

        public Osztaly(string osztalyNev, string teremId)
        {
            OsztalyNev = osztalyNev;
            TeremId = teremId;
        }
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string OsztalyNev { get; set; }
        public string TeremId { get; set; }
    }
}
