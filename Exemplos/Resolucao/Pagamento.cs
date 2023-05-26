namespace BoasPraticas.Service.Cenarios.Resolucao
{
 
    /// <summary>
    /// Classe responsável por Processar o Pagamento.
    /// </summary>
    public abstract class FormaPagamento
    {
        public abstract void ProcessarPagamento();
    }

    public class PagamentoCartaoCredito : FormaPagamento
    {
        public override void ProcessarPagamento()
        {
            //Pagamento processado via cartao de crédito.
        }
    }

    public class PagamentoTransferenciaBancaria : FormaPagamento
    {
        public override void ProcessarPagamento()
        {
            //Pagamento processado via transferencia bancaria.
        }
    }

    public class PagamentoPayPal : FormaPagamento
    {
        public override void ProcessarPagamento()
        {
            //Pagamento processado via PayPal.
        }
    }

    public class PagamentoDinheiro : FormaPagamento
    {
        public override void ProcessarPagamento()
        {
            //Pagamento processado via Dinheiro.
        }
    }

    public class PagamentoProcessor
    {
        public void ProcessarPagamento(FormaPagamento formaPagamento)
        {
            formaPagamento.ProcessarPagamento();
        }
    }
}
