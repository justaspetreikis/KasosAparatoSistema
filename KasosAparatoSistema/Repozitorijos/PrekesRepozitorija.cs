using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KasosAparatoSistema.Models;

namespace KasosAparatoSistema.Repozitorijos
{
    public class PrekesRepozitorija
    {
        public List<Prekes> PrekiuListas { get; set; }

        public PrekesRepozitorija()

        {   PrekiuListas = new List<Prekes>();
            string path = @"C:\Users\petre\Desktop\CodeAcademy\KasosAparatoSistema\Prekes.txt";
            string[] prekes = File.ReadAllLines(path);
            foreach (string preke in prekes)
            {

                 string darbuotojoVardas = preke.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)[0];
                 long prekesbarkodas = long.Parse(preke.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)[1]);
                 string prekesPavadinimas = preke.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)[2];
                 double prekesKaina = double.Parse(preke.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)[3]);
                 string prekesKategorija = preke.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)[4];

                 PrekiuListas.Add(new Prekes(darbuotojoVardas, prekesbarkodas, prekesPavadinimas, prekesKaina, prekesKategorija));
            }

        }
        public List<Prekes> Retrieve()
        {
            return PrekiuListas;
        }

        public Prekes Retrieve(string kategorija)
        {
            return PrekiuListas.Where(x => x.Kategorija == kategorija).FirstOrDefault();
        }

        public Prekes Retrieve(long barkodas)
        {
            return PrekiuListas.Where(x => x.Barkodas == barkodas).FirstOrDefault();
        }
    }
    
}
