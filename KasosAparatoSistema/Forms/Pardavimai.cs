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
            //PrekesRepozitorija prekesRepozitorija = new PrekesRepozitorija();
            //var listas = prekesRepozitorija.Retrieve();
            //comboBox1.DataSource = listas;
            //comboBox1.DisplayMember = "Barkodas";

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

            dataGridViewPpardavimai.Rows.Add(clock.Text.ToString(), tb_pavadinimas.Text, tb_kaina.Text.ToString(), tb_vienetuKiekis.Text.ToString(), (double.Parse(tb_vienetuKiekis.Text) * double.Parse(tb_kaina.Text)).ToString());

            File.AppendAllText(@"C:\Users\petre\Desktop\CodeAcademy\KasosAparatoSistema\VisiPardavimai.txt",
            string.Format("{0} {1} {2} {3} {4}\n",clock.Text.ToString(), tb_pavadinimas.Text, tb_kaina.Text.ToString(), tb_vienetuKiekis.Text.ToString(), (double.Parse(tb_vienetuKiekis.Text) * double.Parse(tb_kaina.Text)).ToString()));
            File.AppendAllText(@"C:\Users\petre\Desktop\CodeAcademy\KasosAparatoSistema\Pardavimai" + DateTime.Today.ToString("yyyyMMdd") + ".txt",
            string.Format("{0} {1} {2} {3} {4}\n", clock.Text.ToString(), tb_pavadinimas.Text, tb_kaina.Text.ToString(), tb_vienetuKiekis.Text.ToString(), (double.Parse(tb_vienetuKiekis.Text) * double.Parse(tb_kaina.Text)).ToString())) ;

            double sum = 0;
            double vienetas = double.Parse(tb_vienetuKiekis.Text);
            double kaina = double.Parse(tb_kaina.Text);
            sum += vienetas * kaina; //kaip paskaičiuoti bendrą prekių sumą

            tb_suma.Text = sum.ToString();
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

        private void tb_suma_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button_Baigti_Click(object sender, EventArgs e)
        {
            while (dataGridViewPpardavimai.Rows.Count > 0)
            {
                dataGridViewPpardavimai.Rows.Remove(dataGridViewPpardavimai.Rows[0]);
            }

            tb_suma.Clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

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
