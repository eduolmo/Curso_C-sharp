using Interface.Entities;

namespace Interface.Services
{
    internal class ProcessamentoDeContrato
    {

        private IServicoDePagamentoOnline _servicoPagamentoOnline;

        public ProcessamentoDeContrato(IServicoDePagamentoOnline servicoPagamentoOnline)
        {
            _servicoPagamentoOnline = servicoPagamentoOnline;
        }

        public void ProcessarContrato(Contrato contrato, int meses)
        {
            double parcelaBasica = contrato.ValorTotal / meses;

            for(int i = 1; i <= meses; i++){

                DateTime dataFinal = contrato.Data.AddMonths(i);

                double valorParcela = parcelaBasica + _servicoPagamentoOnline.JurosSimples(parcelaBasica, i);
                valorParcela += _servicoPagamentoOnline.TaxaDePagamento(valorParcela);

                Parcela p = new Parcela(dataFinal,valorParcela);

                contrato.AddParcela(p);
            }

        }
    }
}
