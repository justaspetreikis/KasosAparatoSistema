using KasosAparatoSistema.Repozitorijos;
using KasosAparatoSistema.Models;

namespace KasosAparatoSistema
{
    public partial class Prisijungimas : Form
    {
        public Prisijungimas()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_VartotojoVardas(object sender, EventArgs e)
        {

        }

        private void buttonPrisijungti_Click(object sender, EventArgs e)
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
                    Pardavimai pardavimai = new Pardavimai();
                    KasosAparatoValdymas nextForm = new KasosAparatoValdymas();
                    this.Hide();
                    //nextForm.ShowDialog();
                    pardavimai.ShowDialog();
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