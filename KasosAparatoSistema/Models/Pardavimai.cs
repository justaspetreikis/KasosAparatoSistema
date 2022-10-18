using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KasosAparatoSistema.Models
{
    public class Pardavimai
    {
        public int PardavimoId { get; set; }
        public DateTime KadaParduota { get; set; }
        public string PrekėsPavadinimas { get; set; }
        public int PrekesKiekis { get; set; }
        public double PardavimoSuma { get; set; }
        public List<Pardavimai> ParduotosPrekes { get; set; }
        public Pardavimai(int pardavimoId, DateTime kadaParduota, string prekėsPavadinimas, int prekesKiekis, double pardavimoSuma)
        {
            PardavimoId = pardavimoId;
            KadaParduota = kadaParduota;
            PrekėsPavadinimas = prekėsPavadinimas;
            PrekesKiekis = prekesKiekis;
            PardavimoSuma = pardavimoSuma;
        }
    }
}
