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
            var prekesRepozitorija = new PrekesRepozitorija();

            string prisijungimoVardas = tbVartotojoVardas.Text;
            string slaptazodis = tbSlaptazodis.Text;
            var _darbuotojasRepozitorija = new DarbuotojasRepozitorija();
            var darbuotojuVardai = _darbuotojasRepozitorija.Retrieve();  
            if (darbuotojuVardai.Any(x => x.Vardas == prisijungimoVardas))
            {
                string reikalingasSlaptazodis = _darbuotojasRepozitorija.Retrieve(prisijungimoVardas).Slaptazodis.ToString();
                if (slaptazodis == reikalingasSlaptazodis)
                {
                    VartotojoId = tbVartotojoVardas.Text.ToString();
                    //Pardavimai pardavimai = new Pardavimai();
                    //PrekiuIvedimas prekiuPridejimas = new PrekiuIvedimas();
                    var pasirinkimai = new form_pasirinkimai();
                    this.Hide();
                    pasirinkimai.ShowDialog();
                    //prekiuPridejimas.ShowDialog();
                    //pardavimai.ShowDialog();
                    this.Close();

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
        private void Prisijungimas_Load(object sender, EventArgs e)
        {
            
        }
    }
}