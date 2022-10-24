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
using System.Text.RegularExpressions;
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

            NaujaRegistracija(tb_naujasPrisijungimoVardas.Text, tb_NaujasSlaptazodis.Text, tb_PakartotiSlaptazodi.Text);
            
        }
        
        private void NaujaRegistracija(string naujasPrisijungimoVardas, string naujasSlaptazodis, string pakartotiSlaptazodi)
        {

            var darbuotojuRepozitorija = new DarbuotojasRepozitorija();
            var darbuotojuListas = darbuotojuRepozitorija.Retrieve();
            int paskutinioDarbuotojoId = darbuotojuListas.Max(r => r.Id);
            int id = paskutinioDarbuotojoId + 1;

            int kiekZodziuPrisijungimoVarde = naujasPrisijungimoVardas.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Count();
            int kiekZodziuSlaptazodyje = naujasSlaptazodis.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Count();
            int kiekZodziupakartotameSlaptazodyje = pakartotiSlaptazodi.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Count();
            if (kiekZodziuPrisijungimoVarde > 1 || kiekZodziuSlaptazodyje > 1 || kiekZodziupakartotameSlaptazodyje > 1)
            {
                MessageBox.Show("Prisijungimo vardas ir slaptažodis turi būti sudarytas iš vieno žodžio");
                return;
            }
            if(naujasPrisijungimoVardas.EndsWith(" ") || naujasSlaptazodis.EndsWith(" ") || pakartotiSlaptazodi.EndsWith(" ")
                || naujasPrisijungimoVardas.StartsWith(" ") || naujasSlaptazodis.StartsWith(" ") || pakartotiSlaptazodi.StartsWith(" "))
            {
                MessageBox.Show("Patikrinkite ar nepalikote tarpų");
                return;
            }

            if (String.IsNullOrEmpty(naujasPrisijungimoVardas) || String.IsNullOrEmpty(naujasSlaptazodis) || String.IsNullOrEmpty(pakartotiSlaptazodi))
            {
                MessageBox.Show("Prašome užpildyti visus reikalingus duomenis");
                return;
            }

            if (darbuotojuListas.Any(a => a.Vardas == naujasPrisijungimoVardas))
            {
                MessageBox.Show("Vartotojas su tokiu vardu jau egzistuoja");
                return;
            }

            if (naujasSlaptazodis != pakartotiSlaptazodi)
            {
                MessageBox.Show("Blogai įvestas slaptažodis");
                return;
            }
            else
            {
                File.AppendAllText(@"C:\Users\petre\Desktop\CodeAcademy\KasosAparatoSistema\Darbuotojai.txt",
                            string.Format("\n{0} {1} {2}", id, naujasPrisijungimoVardas, naujasSlaptazodis));
                MessageBox.Show("Registracija Pavyko");
                tb_naujasPrisijungimoVardas.Clear();
                tb_NaujasSlaptazodis.Clear();
                tb_PakartotiSlaptazodi.Clear();
            }
        }
    }
}
