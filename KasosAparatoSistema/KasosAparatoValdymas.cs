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
            //var _prekesRepozitorija = new PrekesRepozitorija();
            //var prekes = _prekesRepozitorija.Retrieve();
            //dataGridView1.DataSource = prekes;
            dataGridView1.Rows.Add(txt_pavadinimas.Text, txt_barkodas.Text, txt_kaina.Text, txt_kategorija.Text);
        }

        private void Istrinti()
        {
            foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.RemoveAt(item.Index);
            }
        }
        private void button_istrinti_Click(object sender, EventArgs e)
        {
            Istrinti();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }
    }
}
