using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KasosAparatoSistema.Models
{
    public class Prekes
    {
        public long Barkodas { get; set; }
        public string Pavadinimas { get; set; }
        public double Kaina { get; set; }
        public string Kategorija { get; set; }

        public Prekes(long barkodas, string pavadinimas, double kaina, string kategorija)
        {
            Kategorija = kategorija;
            Barkodas = barkodas;
            Pavadinimas = pavadinimas;
            Kaina = kaina;
        }

    }
}
