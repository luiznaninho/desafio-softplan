using DesafioSoftplan.Domain;
using System;
using Xunit;

namespace DesafioSoftplanUnitTest.DomainTest
{
    public class TaxaJurosTest
    {
        [Fact]
        public void TaxaJuros_Valid()
        {
            // arrange
            TaxaJuros objTaxaJuros = new TaxaJuros();
            decimal esperado = 0.01M;

            // act
            decimal atual = objTaxaJuros.getTaxaJuros();

            // assert
            Assert.Equal(esperado, atual);
        }
    }
}
