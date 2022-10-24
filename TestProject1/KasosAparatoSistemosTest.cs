using KasosAparatoSistema.Repozitorijos;
using KasosAparatoSistema.Forms;
using KasosAparatoSistema;

namespace TestProject1
{
    public class KasosAparatoSistemosTest
    {
        [Fact]
        public void PrekesRepozitorija_RetrieveMetodas_IvestasBarkodasGrazinaTeisingaPrekesPavadinima()
        {
            // Arrange

            int barkodas = 1;
            PrekesRepozitorija prekesRepozitoria = new PrekesRepozitorija();
            var expected = "Batonas";

            //Act
            var actual = (prekesRepozitoria.Retrieve(barkodas).Pavadinimas).ToString();

            // Assert
            Assert.Equal(expected, actual);
            Assert.True(actual == expected);
            Assert.IsType<string>(actual);
        }

        [Fact]
        public void DarbuotojasRepozitorija_RetrieveMetodas_IvestasPrisijungimoVardasGrazinaTeisingaSlaptazodi()
        {
            // Arrange
            string darbuotojoVardas = "admin";
            DarbuotojasRepozitorija darbuotojoRepozitorija = new DarbuotojasRepozitorija();
            var expected = "admin";        

            //Act
            var actual = (darbuotojoRepozitorija.Retrieve(darbuotojoVardas).Slaptazodis).ToString();

            // Assert
            Assert.Equal(expected, actual);

        }
    }
}