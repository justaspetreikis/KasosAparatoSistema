using KasosAparatoSistema.Models;
using KasosAparatoSistema.Repozitorijos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace KasosAparatoSistema
{
    public partial class KasosAparatoValdymas : Form
    {
        public KasosAparatoValdymas()
        {
            InitializeComponent();
        }
        private void button_prideti_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(txt_barkodas.Text, txt_pavadinimas.Text, txt_kaina.Text, txt_kategorija.Text);
            File.AppendAllText(@"C:\Users\petre\Desktop\CodeAcademy\KasosAparatoSistema\Prekes.txt",
                string.Format("\n{0} {1} {2} {3}", txt_barkodas.Text, txt_pavadinimas.Text, txt_kaina.Text, txt_kategorija.Text));
        }

        private void Istrinti()
        {
            foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.RemoveAt(item.Index); // sugalvoti kaip kartu ištrinti eilutę iš txt failo.
            }
        }
        private void button_istrinti_Click(object sender, EventArgs e)
        {
            Istrinti();
        }

        private void button_ikeltiSarasa_Click(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines(@"C:\Users\petre\Desktop\CodeAcademy\KasosAparatoSistema\Prekes.txt"); //pakeisti su dataSource metodu
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

    }
}
