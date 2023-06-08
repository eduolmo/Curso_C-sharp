namespace Interface.Services
{
    internal class ServicoPaypal : IServicoDePagamentoOnline
    {

        public double JurosSimples(double valor, int meses)
        {
            return valor * meses * 0.01;
        }

        public double TaxaDePagamento(double valor)
        {
            return valor * 0.02;
        }

    }
}
