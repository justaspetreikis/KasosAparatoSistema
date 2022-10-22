using KasosAparatoSistema.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KasosAparatoSistema.Repozitorijos
{
    internal class PrekiuPardavimaiRepozitorija
    {
        public List<PrekiuPardavimai> VisuPardavimuListas { get; set; }
        public List<PrekiuPardavimai> VienosDienosPardavimuListas { get; set; }
        public PrekiuPardavimaiRepozitorija()
        {
            VienosDienosPardavimuListas = new List<PrekiuPardavimai>();
            VisuPardavimuListas = new List<PrekiuPardavimai>();
            string visi = @"C:\Users\petre\Desktop\CodeAcademy\KasosAparatoSistema\VisiPardavimai.txt";
            string dienos = @"C:\Users\petre\Desktop\CodeAcademy\KasosAparatoSistema\Pardavimai" + DateTime.Today.ToString("yyyyMMdd") + ".txt";
            string[] visiPardavimai = File.ReadAllLines(visi);
            string[] dienosPardavimai = File.ReadAllLines(dienos);
            foreach (string pardavimas in visiPardavimai)
            {
                DateTime diena = DateTime.Parse(pardavimas.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)[0]);
                DateTime laikas = DateTime.Parse(pardavimas.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)[1]);
                string pavadiniams = pardavimas.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)[2];
                int kiekis = int.Parse(pardavimas.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)[4]);
                double suma = double.Parse(pardavimas.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)[5]);

                VisuPardavimuListas.Add(new PrekiuPardavimai(diena, laikas, pavadiniams, kiekis, suma));
            }
            foreach (string pardavimas in dienosPardavimai)
            {
                DateTime diena = DateTime.Parse(pardavimas.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)[0]);
                DateTime laikas = DateTime.Parse(pardavimas.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)[1]);
                string pavadiniams = pardavimas.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)[2];
                int kiekis = int.Parse(pardavimas.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)[4]);
                double suma = double.Parse(pardavimas.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)[5]);

                VienosDienosPardavimuListas.Add(new PrekiuPardavimai(diena, laikas, pavadiniams, kiekis, suma));
            }
        }

        public List<PrekiuPardavimai> GrazintiLista(string laikotarpis)
        {
            if(laikotarpis == "dienos")
            {
                return VienosDienosPardavimuListas;
            }
            return VisuPardavimuListas;
        }

        public PrekiuPardavimai PasirinktosDienosListas(string diena)
        {
            return VisuPardavimuListas.Where(x => x.KadaParduotaDiena.ToShortDateString() == diena).FirstOrDefault();
        }

    }
}
