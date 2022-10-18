using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KasosAparatoSistema.Models;
using KasosAparatoSistema.Repozitorijos;

namespace KasosAparatoSistema.Services
{
    internal class PardavimuAtaskaita
    {
        DarbuotojasRepozitorija _darbuotojasRepozitorija;
        PrekesRepozitorija _prekesRepozitorija;

        public PardavimuAtaskaita(DarbuotojasRepozitorija darbuotojasRepozitorija, PrekesRepozitorija prekesRepozitorija)
        {
            _darbuotojasRepozitorija = darbuotojasRepozitorija;
            _prekesRepozitorija = prekesRepozitorija;
        }
        public List<Pardavimai> PardavimuSkaiciavimas()
        {
            return null;
        }
        
    }
}
