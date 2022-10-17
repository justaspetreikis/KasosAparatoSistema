using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KasosAparatoSistema.Models;

namespace KasosAparatoSistema.Repozitorijos
{
    public class DarbuotojasRepozitorija
    {
        public List<Darbuotojas> DarbuotojuListas { get; set; }

        public DarbuotojasRepozitorija()
        {
            DarbuotojuListas = new List<Darbuotojas>();
            string path = @"C:\Users\petre\Desktop\CodeAcademy\KasosAparatoSistema\Darbuotojai.txt";
            string[] darbuotojuPrisijungimai = File.ReadAllLines(path);
            foreach (string darbuotojas in darbuotojuPrisijungimai)
            {
                int id = int.Parse(darbuotojas.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)[0]);
                string darbuotojoVardas = darbuotojas.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)[1];
                string slaptazodis = darbuotojas.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)[2];

                DarbuotojuListas.Add(new Darbuotojas(id, darbuotojoVardas, slaptazodis));
            }   

        }
        public List<Darbuotojas> Retrieve()
        {
            return DarbuotojuListas;
        }

        public Darbuotojas Retrieve(string darbuotojoVardas)
        {
            return DarbuotojuListas.Where(x => x.Vardas == darbuotojoVardas).FirstOrDefault();
        }
    }
}
