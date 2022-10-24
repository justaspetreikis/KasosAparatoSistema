using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KasosAparatoSistema.Models;
using KasosAparatoSistema.Repozitorijos;

namespace KasosAparatoSistema.Services
{
    internal class VisuPardavimuAtaskaita
    {
        public string PardavimuAtaskaita(List<PrekiuPardavimai> pardavimuListas, string laikotarpis)
        {
            string pardavimuAtaskaita = "";
            if(laikotarpis == "dienos")
            {
                pardavimuAtaskaita = "<style type=\"text/css\">" +
                    ".praejimoInfo {width: 500px;border-collapse: collapse;}" +
                    ".praejimoInfo td {border: 1px solid black;}" +
                    ".praejimoInfo tr:nth-child(even) {background-color: #E4FFB7;}" +
                    ".praejimoInfo tr:nth-child(odd) {background-color: #EFFFD2;}" +
                    ".header {text-align: center;font-weight: bolder;background-color: #80B327;color: white;}" +
                    "</style>" +
                    "<table class=\"praejimoInfo\">" +
                    "<tbody><tr>" +
                    "<td class=\"header\" colspan=\"6\">Vienos Dienos Pardavimų Ataskaita</td>" +
                    "</tr>" +
                    "<tr class=\"mainRow\">" +
                    "<td>Diena</td>" +
                    "<td>Laikas</td>" +
                    "<td>Darbuotojas</td>" +
                    "<td>Prekė</td>" +
                    "<td>Kiekis</td>" +
                    "<td>Suma</td>" +
                    "</tr>";
                foreach (var pardavimas in pardavimuListas)
                {
                    pardavimuAtaskaita = pardavimuAtaskaita + ($"<tr class=\"altRow\">" +
                        $"<td>{pardavimas.KadaParduotaDiena.ToShortDateString()}</td>" +
                        $"<td>{pardavimas.KadaParduotaLaikas.ToShortTimeString()}</td>" +
                        $"<td>{pardavimas.PrisijungesDarbuotojas}</td>" +
                        $"<td>{pardavimas.PrekėsPavadinimas}</td>" +
                        $"<td>{pardavimas.PrekesKiekis}</td>" +
                        $"<td>{pardavimas.PardavimoSuma}</td>" +
                        $"</tr>").ToString();
                }
                pardavimuAtaskaita = pardavimuAtaskaita + "</tbody></table>";
                File.Delete(@"C:\Users\petre\Desktop\CodeAcademy\KasosAparatoSistema\KasosAparatoSistema\bin\Debug\net6.0-windows\DienosPardavimuAtaskaita.html");
                File.AppendAllText("DienosPardavimuAtaskaita.html", pardavimuAtaskaita);
            }
            else if(laikotarpis == "viso laikotarpio")
                {
                pardavimuAtaskaita = "<style type=\"text/css\">" +
                ".praejimoInfo {width: 500px;border-collapse: collapse;}" +
                ".praejimoInfo td {border: 1px solid black;}" +
                ".praejimoInfo tr:nth-child(even) {background-color: #E4FFB7;}" +
                ".praejimoInfo tr:nth-child(odd) {background-color: #EFFFD2;}" +
                ".header {text-align: center;font-weight: bolder;background-color: #80B327;color: white;}" +
                "</style>" +
                "<table class=\"praejimoInfo\">" +
                "<tbody><tr>" +
                "<td class=\"header\" colspan=\"6\">Visų Pardavimų Ataskaita</td>" +
                "</tr>" +
                "<tr class=\"mainRow\">" +
                "<td>Diena</td>" +
                "<td>Laikas</td>" +
                "<td>Darbuotojas</td>" +
                "<td>Prekė</td>" +
                "<td>Kiekis</td>" +
                "<td>Suma</td>" +
                "</tr>";
                foreach (var pardavimas in pardavimuListas)
                {
                    pardavimuAtaskaita = pardavimuAtaskaita + ($"<tr class=\"altRow\">" +
                        $"<td>{pardavimas.KadaParduotaDiena.ToShortDateString()}</td>" +
                        $"<td>{pardavimas.KadaParduotaLaikas.ToShortTimeString()}</td>" +
                        $"<td>{pardavimas.PrisijungesDarbuotojas}</td>" +
                        $"<td>{pardavimas.PrekėsPavadinimas}</td>" +
                        $"<td>{pardavimas.PrekesKiekis}</td>" +
                        $"<td>{pardavimas.PardavimoSuma}</td>" +
                        $"</tr>").ToString();
                }
                pardavimuAtaskaita = pardavimuAtaskaita + "</tbody></table>";
                File.Delete(@"C:\Users\petre\Desktop\CodeAcademy\KasosAparatoSistema\KasosAparatoSistema\bin\Debug\net6.0-windows\VisuPardavimuAtaskaita.html");
                File.AppendAllText("VisuPardavimuAtaskaita.html", pardavimuAtaskaita);
            }
            return pardavimuAtaskaita;
        }
       
    }
    
}
