using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KasosAparatoSistema.Models
{
    public class Prekes
    {
        public string DarbuotojoVardas { get; set; }
        public long Barkodas { get; set; }
        public string Pavadinimas { get; set; }
        public double Kaina { get; set; }
        public string Kategorija { get; set; }

        public Prekes(string darbtuojoVardas, long barkodas, string pavadinimas, double kaina, string kategorija)
        {
            DarbuotojoVardas = darbtuojoVardas;
            Kategorija = kategorija;
            Barkodas = barkodas;
            Pavadinimas = pavadinimas;
            Kaina = kaina;
        }

    }
}
