namespace BoasPraticas.Service.Resolucao
{
    internal class Promocao
    {
        public enum TipoCliente
        {
            ClienteComum = 1,
            ClienteVIP = 2,
            ClienteNovo = 3
        }

        const int PORCENTAGEM_DESCONTO_COMUM_NOVO = 5;
        const int PORCENTAGEM_DESCONTO_VIP = 10;

        /// <summary>
        /// Método responsável por aplicar promoção com base no tipo do cliente
        /// </summary>
        /// <param name="valor">Valor da compra do cliente</param>
        /// <param name="tipoCliente">Tipo do cadastro do cliente</param>
        /// <returns>Valor da compra com a promoção aplicada</returns>
        public decimal Aplicar(decimal valor, TipoCliente tipoCliente)
        {
            decimal valorAplicado = 0;

            if (tipoCliente == TipoCliente.ClienteComum)
            {
                decimal porcentagem = valor * PORCENTAGEM_DESCONTO_COMUM_NOVO / 100;
                valorAplicado = valor - porcentagem;
            }
            else if (tipoCliente == TipoCliente.ClienteVIP)
            {
                decimal porcentagem = valor * PORCENTAGEM_DESCONTO_VIP / 100;
                valorAplicado = valor - porcentagem;
            }
            else if (tipoCliente == TipoCliente.ClienteNovo)
            {
                decimal porcentagem = valor * PORCENTAGEM_DESCONTO_COMUM_NOVO / 100;
                valorAplicado = valor - porcentagem;
            }

            return valorAplicado;
        }

    }
}
