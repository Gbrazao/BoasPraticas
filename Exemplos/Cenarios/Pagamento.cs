namespace BoasPraticas.Service.Cenarios
{
    public class Pagamento
    {
        /// <summary>
        /// Método responsável por Processar um pagamento com base no Tipo de Pagamento
        /// </summary>
        /// <param name="tipoPagamento">Tipo de pagamento selecionado.</param>
        /// <exception cref="ArgumentException">Pagamento Inválido</exception>
        public void ProcessarPagamento(string tipoPagamento)
        {
            if (tipoPagamento == "CartaoCredito")
            {
                // Processar pagamento com cartão de crédito
            }
            else if (tipoPagamento == "TransferenciaBancaria")
            {
                // Processar pagamento com transferência bancária
            }
            else if (tipoPagamento == "PayPal")
            {
                // Processar pagamento com PayPal
            }
            else if (tipoPagamento == "Dinheiro")
            {
                // Processar pagamento com PayPal
            }
            else
            {
                throw new ArgumentException("Método de pagamento inválido.");
            }
        }
    }
}
