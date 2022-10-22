using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KasosAparatoSistema.Models
{
    public class PrekiuPardavimai
    {
        public DateTime KadaParduotaDiena { get; set; }
        public DateTime KadaParduotaLaikas { get; set; }
        public string PrekėsPavadinimas { get; set; }
        public int PrekesKiekis { get; set; }
        public double PardavimoSuma { get; set; }
        public List<PrekiuPardavimai> ParduotosPrekes { get; set; }

        public PrekiuPardavimai()
        {

        }

        public PrekiuPardavimai(DateTime kadaParduotaDiena, DateTime kadaParduotaLaikas, string prekėsPavadinimas, int prekesKiekis, double pardavimoSuma)
        {
            KadaParduotaDiena = kadaParduotaDiena;
            KadaParduotaLaikas = kadaParduotaLaikas;
            PrekėsPavadinimas = prekėsPavadinimas;
            PrekesKiekis = prekesKiekis;
            PardavimoSuma = pardavimoSuma;
        }
    }
}
