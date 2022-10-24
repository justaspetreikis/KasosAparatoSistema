using KasosAparatoSistema.Forms;
using KasosAparatoSistema.Models;
using KasosAparatoSistema.Repozitorijos;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace KasosAparatoSistema
{
    public partial class PrekiuIvedimas : Form
    {
        public PrekiuIvedimas()
        {
            InitializeComponent();
        }
        private void button_prideti_Click(object sender, EventArgs e) 
        {
            long barkodas;
            double kaina;
            var prekiuRepozitorija = new PrekesRepozitorija();
            var prekiuListas = prekiuRepozitorija.Retrieve();
            bool ivestaGeraKaina = double.TryParse(txt_kaina.Text, out kaina);
            bool ivestasGerasBarkodas = long.TryParse(txt_barkodas.Text, out barkodas);
            bool barkodasEgzistuoja = prekiuListas.Any(a => a.Barkodas == barkodas);
            int kiekZodziuPavadinime = txt_pavadinimas.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Count();
            if (ivestasGerasBarkodas == false)
            {
                MessageBox.Show("Blogai įvestas barkodas");
                return;
            }

            if (barkodasEgzistuoja == true)
            {
                MessageBox.Show("Prekė su tokiu barkodu jau egzistuoja");
                return;
            }

            if (ivestaGeraKaina == false)
            {
                MessageBox.Show("Blogai nurodyta prekės kaina (kainai įvesti naudojamas kablelis)");
                return;
            }
            
            if (kiekZodziuPavadinime > 1)
            {
                MessageBox.Show("Prekės pavadinimas turi būti sudarytas iš vieno žodžio");
                return;
            }

            dataGridView1.Rows.Add(tb_vartotojas.Text, txt_barkodas.Text, txt_pavadinimas.Text, txt_kaina.Text, comboBox1.Text);
            File.AppendAllText(@"C:\Users\petre\Desktop\CodeAcademy\KasosAparatoSistema\Prekes.txt",
                string.Format("{0} {1} {2} {3} {4}\n", tb_vartotojas.Text, txt_barkodas.Text, txt_pavadinimas.Text, txt_kaina.Text, comboBox1.Text));
        }

        private void Istrinti()
        {

            int pasirinktaEilute = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(pasirinktaEilute);
            List<string> lines = new List<string>(File.ReadAllLines(@"C:\Users\petre\Desktop\CodeAcademy\KasosAparatoSistema\Prekes.txt"));
            lines.RemoveAt(pasirinktaEilute);
            File.WriteAllLines(@"C:\Users\petre\Desktop\CodeAcademy\KasosAparatoSistema\Prekes.txt", lines.ToArray());
        }
        private void button_istrinti_Click(object sender, EventArgs e)
        {
            Istrinti();
        }

        private void KasosAparatoValdymas_Load(object sender, EventArgs e)
        {
            var prekiuRepozitorija = new PrekesRepozitorija();
            var prekes = prekiuRepozitorija.Retrieve();
            foreach (var kategorija in prekes)
            {
                if (!comboBox1.Items.Contains(kategorija.Kategorija))
                comboBox1.Items.Add(kategorija.Kategorija);
            }

            tb_vartotojas.Text = Prisijungimas.VartotojoId;

            string[] lines = File.ReadAllLines(@"C:\Users\petre\Desktop\CodeAcademy\KasosAparatoSistema\Prekes.txt");
            string[] values;
            for (int i = 0; i < lines.Length; i++)
            {
                values = lines[i].ToString().Split(" ");
                string[] row = new string[values.Length];

                for (int j = 0; j < values.Length; j++)
                {
                    row[j] = values[j].Trim();
                }

                dataGridView1.Rows.Add((row));
            }
        }

        private void button_grižti_Click(object sender, EventArgs e)
        {
            var pasirinkimai = new form_pasirinkimai();
            this.Hide();
            pasirinkimai.ShowDialog();
        }

    }
}
