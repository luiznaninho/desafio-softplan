using System;

namespace DesafioSoftplan.Domain
{
    public class TaxaJuros
    {

        private readonly decimal taxaJuros = 0.01M;

        public TaxaJuros()
        {

        }

        public decimal getTaxaJuros()
        {
            return this.taxaJuros;
        }
    }
}
