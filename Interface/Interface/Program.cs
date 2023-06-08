using System.Globalization;
using Interface.Entities;
using Interface.Services;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter contract data");
            Console.Write("Number: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Date (dd/MM/yyyy): ");
            DateTime data = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.Write("Contract value: ");
            double valorTotal = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Contrato contrato = new Contrato(numero,data,valorTotal);

            Console.Write("Enter number of installments: ");
            int meses = int.Parse(Console.ReadLine());

            ServicoPaypal sp = new ServicoPaypal();
            ProcessamentoDeContrato pc = new ProcessamentoDeContrato(sp);
            pc.ProcessarContrato(contrato,meses);

            Console.WriteLine("PARCELAS: ");
            foreach (Parcela parcela in contrato.Parcelas)
            {
                Console.WriteLine(parcela);
            }

        }
    }
}










