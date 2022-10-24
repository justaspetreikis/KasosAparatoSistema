using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KasosAparatoSistema.Repozitorijos;
using KasosAparatoSistema.Models;
using System.IO;
using Microsoft.VisualBasic;
using KasosAparatoSistema.Forms;

namespace KasosAparatoSistema
{
    public partial class Pardavimai : Form
    {
        public Pardavimai()
        {
            InitializeComponent();
        }

        private void button_ieskoti_Click(object sender, EventArgs e)
        {   
            if(string.IsNullOrEmpty(tb_iveskiteBarkoda.Text.ToString()))
            {
                MessageBox.Show("Įveskite barkodą");
                return;
            }
            long barkodas;
            bool arGeraiIvestasBarkodas = long.TryParse(tb_iveskiteBarkoda.Text, out barkodas);
            var prekesRepozitorija = new PrekesRepozitorija();
            var prekesInformacija = prekesRepozitorija.Retrieve(barkodas); 
            if(arGeraiIvestasBarkodas == false)
            {
                MessageBox.Show("Barkodo paieškoje nurodykite barkodo skaičius");
                return;
            }
            if (prekesInformacija == null)
            {
                MessageBox.Show("Prekė nerasta");
                return;
            }
            if (barkodas == prekesInformacija.Barkodas)
            {
                tb_pavadinimas.Text = prekesInformacija.Pavadinimas;
                tb_kaina.Text = prekesInformacija.Kaina.ToString();
                tb_vienetuKiekis.ReadOnly = false;
            }
            
        }

        private void button_prideti_Click(object sender, EventArgs e)
        {
            string prisijungesDarbuotojas = Prisijungimas.VartotojoId;

            if (string.IsNullOrEmpty(tb_vienetuKiekis.Text))
            {
                return;
            }
            int kiekis;
            bool arGeraiIvestasKiekis = int.TryParse(tb_vienetuKiekis.Text, out kiekis);
            if(arGeraiIvestasKiekis == false)
            {
                MessageBox.Show("blogai nurodytas kiekis");
                return;
            }

            dataGridViewPpardavimai.Rows.Add(clock.Text.ToString(), tb_pavadinimas.Text, tb_kaina.Text.ToString(), tb_vienetuKiekis.Text.ToString(), (double.Parse(tb_vienetuKiekis.Text) * double.Parse(tb_kaina.Text)).ToString());

            File.AppendAllText(@"C:\Users\petre\Desktop\CodeAcademy\KasosAparatoSistema\VisiPardavimai.txt",
            string.Format("{0} {1} {2} {3} {4} {5}\n",clock.Text.ToString(), tb_pavadinimas.Text, tb_kaina.Text.ToString(), tb_vienetuKiekis.Text.ToString(), (double.Parse(tb_vienetuKiekis.Text) * double.Parse(tb_kaina.Text)).ToString(), prisijungesDarbuotojas));
            File.AppendAllText(@"C:\Users\petre\Desktop\CodeAcademy\KasosAparatoSistema\Pardavimai" + DateTime.Today.ToString("yyyyMMdd") + ".txt",
            string.Format("{0} {1} {2} {3} {4} {5}\n", clock.Text.ToString(), tb_pavadinimas.Text, tb_kaina.Text.ToString(), tb_vienetuKiekis.Text.ToString(), (double.Parse(tb_vienetuKiekis.Text) * double.Parse(tb_kaina.Text)).ToString(), prisijungesDarbuotojas)) ;
            File.AppendAllText(@"C:\Users\petre\Desktop\CodeAcademy\KasosAparatoSistema\Suma.txt",
            String.Format("{0}\n", (double.Parse(tb_vienetuKiekis.Text) * double.Parse(tb_kaina.Text)).ToString()));

            string sumosFailas = @"C:\Users\petre\Desktop\CodeAcademy\KasosAparatoSistema\Suma.txt";
            string[] sumuListas = File.ReadAllLines(sumosFailas);
            List <double> sumos = new List<double>();
            foreach (string suma in sumuListas)
            {
                double sum = double.Parse(suma.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)[0]);
                sumos.Add(sum);
            }

            double bendraSuma = sumos.Sum(x => Convert.ToDouble(x));

            tb_suma.Text = bendraSuma.ToString();
            tb_pavadinimas.Clear();
            tb_kaina.Clear();
            tb_iveskiteBarkoda.Clear();
            tb_vienetuKiekis.Clear();
            tb_vienetuKiekis.ReadOnly = true;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            clock.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

        }

        private void button_Baigti_Click(object sender, EventArgs e)
        {
            while (dataGridViewPpardavimai.Rows.Count > 0)
            {
                dataGridViewPpardavimai.Rows.Remove(dataGridViewPpardavimai.Rows[0]);
            }
            File.Delete(@"C:\Users\petre\Desktop\CodeAcademy\KasosAparatoSistema\Suma.txt");
            tb_suma.Clear();
        }

        private void button_gristi_Click(object sender, EventArgs e)
        {
            var pasirinkimai = new form_pasirinkimai();
            this.Hide();
            pasirinkimai.ShowDialog();
        }

        private void Pardavimai_Load(object sender, EventArgs e)
        {
                tb_vartotojas.Text = Prisijungimas.VartotojoId;
        }

    }
}
