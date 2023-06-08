namespace Interface.Services
{
    interface IServicoDePagamentoOnline
    {

        double JurosSimples(double valor, int meses);
        double TaxaDePagamento(double valor);
        
    }
}
