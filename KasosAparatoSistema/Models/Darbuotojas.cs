using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KasosAparatoSistema.Models
{
    public class Darbuotojas
    {
        public int Id { get; set; }
        public string Vardas { get; set; }
        public string Slaptazodis { get; set; }

        public Darbuotojas(int id, string vardas, string slaptazodis)
        {
            Id = id;
            Vardas = vardas;
            Slaptazodis = slaptazodis;
        }
    }
}
