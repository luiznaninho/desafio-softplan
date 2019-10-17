using System;

namespace DesafioSoftplan.Domain
{
    public class CalculaJuros
    {

        public CalculaJuros()
        {

        }

        public double RealizaCalculo(double valorInicial, int meses, double taxaJuros)
        {
            double valorFinal = valorInicial * Math.Pow((1 + taxaJuros), meses);
            valorFinal = Math.Truncate(100 * valorFinal) / 100;
            return valorFinal;
        }
    }
}
