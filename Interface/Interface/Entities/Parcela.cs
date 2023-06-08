using System.Globalization;

namespace Interface.Entities
{
    internal class Parcela
    {
        public DateTime DataFinal { get; set; }
        public double Valor { get; set; }

        public Parcela(DateTime dataFinal, double valor)
        {
            DataFinal = dataFinal;
            Valor = valor;
        }

        public override string ToString()
        {
            return $"{DataFinal.ToString("dd/MM/yyyy")} - {Valor.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
