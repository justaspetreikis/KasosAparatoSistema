using KasosAparatoSistema.Repozitorijos;
using KasosAparatoSistema.Models;
using System.Security.Cryptography.X509Certificates;
using System.IO;
using KasosAparatoSistema.Forms;

namespace KasosAparatoSistema
{
    public partial class Prisijungimas : Form
    {
        public static string VartotojoId = ""; 
        public Prisijungimas()
        {
            InitializeComponent();
        }
        public void buttonPrisijungti_Click(object sender, EventArgs e)
        {
            
            PrisijungimoDuomenuPatikrinimas(tbVartotojoVardas.Text, tbSlaptazodis.Text);
            
        }
        private void Prisijungimas_Load(object sender, EventArgs e)
        {
            
        }

        private void button_registracija_Click(object sender, EventArgs e)
        {
            var registracija = new Registracija();
            this.Hide();
            registracija.ShowDialog();
          
        }
        private void PrisijungimoDuomenuPatikrinimas(string prisijungimoVardas, string slaptazodis)
        {
            var _darbuotojasRepozitorija = new DarbuotojasRepozitorija();
            var darbuotojuVardai = _darbuotojasRepozitorija.Retrieve();
            if (darbuotojuVardai.Any(x => x.Vardas == prisijungimoVardas))
            {
                string reikalingasSlaptazodis = _darbuotojasRepozitorija.Retrieve(prisijungimoVardas).Slaptazodis.ToString();
                if (slaptazodis == reikalingasSlaptazodis)
                {
                    VartotojoId = tbVartotojoVardas.Text.ToString();
                    var pasirinkimai = new form_pasirinkimai();
                    this.Hide();
                    pasirinkimai.ShowDialog();

                }
                else
                {
                    MessageBox.Show("blogas slaptaþodis");
                    return;
                }
            }
            else
            {
                MessageBox.Show("blogas prisijungimas arba slaptaþodis");
            }
        }
    }
}