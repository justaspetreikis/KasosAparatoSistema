using KasosAparatoSistema.Models;
using KasosAparatoSistema.Repozitorijos;
using KasosAparatoSistema.Services;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KasosAparatoSistema.Forms
{
    public partial class form_pasirinkimai : Form
    {
        public form_pasirinkimai()
        {
            InitializeComponent();
        }

        private void button_prekiuIvedimas_Click(object sender, EventArgs e)
        {
            var prekiuIvedimas = new PrekiuIvedimas();
            this.Hide();
            prekiuIvedimas.ShowDialog();
        }

        private void button_KasosAparatas_Click(object sender, EventArgs e)
        {
            var kasosAparatas = new Pardavimai();
            this.Hide();
            kasosAparatas.ShowDialog();
        }

        private void butto_atsijungti_Click(object sender, EventArgs e)
        {
            var prisijungimas = new Prisijungimas();
            this.Hide();
            prisijungimas.ShowDialog();
        }
        private void button_VisuPardavimuAtaskaita_Click(object sender, EventArgs e)
        {
            
            var prekiuPardavimaiRepozitorija = new PrekiuPardavimaiRepozitorija();
            List<PrekiuPardavimai> visiPardavimai = prekiuPardavimaiRepozitorija.GrazintiLista("");

            var visuPardavimuAtasakita = new VisuPardavimuAtaskaita();
            visuPardavimuAtasakita.PardavimuAtaskaita(visiPardavimai, "viso laikotarpio");

            ProcessStartInfo info = new ProcessStartInfo();
            info.FileName = @"C:\Users\petre\Desktop\CodeAcademy\KasosAparatoSistema\KasosAparatoSistema\bin\Debug\net6.0-windows\VisuPardavimuAtaskaita.html";
            info.UseShellExecute = true;
            Process.Start(info);

        }

        private void form_pasirinkimai_Load(object sender, EventArgs e)
        {
            tb_vartotojas.Text = Prisijungimas.VartotojoId;
        }

        private void button_sesijosPardavimųAtaskaita_Click(object sender, EventArgs e)
        {
            var prekiuPardavimaiRepozitorija = new PrekiuPardavimaiRepozitorija();
            List<PrekiuPardavimai> visiPardavimai = prekiuPardavimaiRepozitorija.GrazintiLista("dienos");

            var visuPardavimuAtasakita = new VisuPardavimuAtaskaita();
            visuPardavimuAtasakita.PardavimuAtaskaita(visiPardavimai, "dienos");

            ProcessStartInfo info = new ProcessStartInfo();
            info.FileName = @"C:\Users\petre\Desktop\CodeAcademy\KasosAparatoSistema\KasosAparatoSistema\bin\Debug\net6.0-windows\DienosPardavimuAtaskaita.html";
            info.UseShellExecute = true;
            Process.Start(info);
        }
    }
}
