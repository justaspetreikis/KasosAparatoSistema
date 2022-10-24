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

            int barkodas = 2;
            PrekesRepozitorija prekesRepozitoria = new PrekesRepozitorija();
            var expected = "Duona";

            //Act

            var actual = (prekesRepozitoria.Retrieve(barkodas).Pavadinimas).ToString();

            // Assert
            Assert.Equal(expected, actual);
            Assert.True(actual == expected);
            Assert.IsType<string>(actual);
        }

    }
}