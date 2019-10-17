using DesafioSoftplan.Domain;
using System;
using Xunit;

namespace DesafioSoftplanUnitTest.DomainTest
{
    public class CalculaJurosTest
    {
        [Fact]
        public void CalculaJuros_Valid()
        {
            // arrange
            CalculaJuros objCalculaJuros = new CalculaJuros();
            double valorInicial = 2500;
            int meses = 12;
            double taxaJuros = 0.01;
            double esperado = 2817.06;

            // act
            double atual = objCalculaJuros.RealizaCalculo(valorInicial, meses, taxaJuros);

            // assert
            Assert.Equal(esperado, atual);
        }
    }
}
