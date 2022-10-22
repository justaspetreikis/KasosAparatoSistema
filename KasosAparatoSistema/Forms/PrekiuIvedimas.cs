using KasosAparatoSistema.Forms;
using KasosAparatoSistema.Models;
using KasosAparatoSistema.Repozitorijos;
using Microsoft.VisualBasic.ApplicationServices;
using System;
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
        private void button_prideti_Click(object sender, EventArgs e) //leisti ivesti tik gerus duomenis
        {

            dataGridView1.Rows.Add(tb_vartotojas.Text, txt_barkodas.Text, txt_pavadinimas.Text, txt_kaina.Text, comboBox1.Text);
            File.AppendAllText(@"C:\Users\petre\Desktop\CodeAcademy\KasosAparatoSistema\Prekes.txt",
                string.Format("\n{0} {1} {2} {3} {4}", tb_vartotojas.Text, txt_barkodas.Text, txt_pavadinimas.Text, txt_kaina.Text, comboBox1.Text));
        }

        private void Istrinti()
        {

            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(rowIndex);
            List<string> lines = new List<string>(File.ReadAllLines(@"C:\Users\petre\Desktop\CodeAcademy\KasosAparatoSistema\Prekes.txt"));
            lines.RemoveAt(rowIndex);
            File.WriteAllLines(@"C:\Users\petre\Desktop\CodeAcademy\KasosAparatoSistema\Prekes.txt", lines.ToArray());
        }
        private void button_istrinti_Click(object sender, EventArgs e)
        {
            Istrinti();
        }
        private void tb_vartotojas_TextChanged(object sender, EventArgs e)
        {

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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
