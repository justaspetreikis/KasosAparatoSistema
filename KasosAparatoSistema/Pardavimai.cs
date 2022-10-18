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
            long barkodas = long.Parse(tb_iveskiteBarkoda.Text);
            var prekesRepozitorija = new PrekesRepozitorija();
            var prekesInformacija = prekesRepozitorija.Retrieve(barkodas); 
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
            if (string.IsNullOrEmpty(tb_vienetuKiekis.Text))
            {
                return;
            }
            int sum = 0;
            prekiuList.Items.Clear();
            File.AppendAllText(@"C:\Users\petre\Desktop\CodeAcademy\KasosAparatoSistema\Pardavimai.txt",
            string.Format("{0} {1} {2} {3} {4}\n",clock.Text.ToString(), tb_pavadinimas.Text, tb_kaina.Text.ToString(), tb_vienetuKiekis.Text.ToString(), (double.Parse(tb_vienetuKiekis.Text) * double.Parse(tb_kaina.Text)).ToString()));
            string[] lines = File.ReadAllLines(@"C:\Users\petre\Desktop\CodeAcademy\KasosAparatoSistema\Pardavimai.txt");
            foreach(string line in lines)
            {
                prekiuList.Items.Add(line);
                tb_suma.Text = sum.ToString();
            }
            tb_iveskiteBarkoda.Clear();
            tb_vienetuKiekis.Clear();
            tb_vienetuKiekis.ReadOnly = true;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            clock.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void tb_suma_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
