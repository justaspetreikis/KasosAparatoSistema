using KasosAparatoSistema.Repozitorijos;
using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace KasosAparatoSistema.Forms
{
    public partial class Registracija : Form
    {
        public Registracija()
        {
            InitializeComponent();
        }

        private void Registracija_Load(object sender, EventArgs e)
        {

        }

        private void button_grizti_Click(object sender, EventArgs e)
        {
            var prisijungimas = new Prisijungimas();
            this.Hide();
            prisijungimas.ShowDialog();
        }

        private void button_registruotis_Click(object sender, EventArgs e)
        {

            var darbuotojuRepozitorija = new DarbuotojasRepozitorija();
            var darbuotojuListas = darbuotojuRepozitorija.Retrieve();
            int paskutinioDarbuotojoId = darbuotojuListas.Max(r => r.Id);
            int id = paskutinioDarbuotojoId + 1;

            if (darbuotojuListas.Any(a => a.Vardas == tb_naujasPrisijungimoVardas.Text))
            {
                MessageBox.Show("Vartotojas su tokiu vardu jau egzistuoja");
                return;
            }
            if (tb_NaujasSlaptazodis.Text != tb_PakartotiSlaptazodi.Text)
            {
                MessageBox.Show("Blogai įvestas slaptažodis");
                return;
            }
            else
            {
                File.AppendAllText(@"C:\Users\petre\Desktop\CodeAcademy\KasosAparatoSistema\Darbuotojai.txt",
                            string.Format("\n{0} {1} {2}", id, tb_naujasPrisijungimoVardas.Text, tb_NaujasSlaptazodis.Text));
                MessageBox.Show("Registracija Pavyko");
                tb_naujasPrisijungimoVardas.Clear();
                tb_NaujasSlaptazodis.Clear();
                tb_PakartotiSlaptazodi.Clear();
            }
            
        }
    }
}
