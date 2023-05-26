namespace BoasPraticas.Service.Cenarios
{
    internal class Promocao
    {

        /// <summary>
        /// Método responsável por aplicar promoção com base no tipo do cliente
        /// </summary>
        /// <param name="valor">Valor da compra do cliente</param>
        /// <param name="tipoCliente">Tipo do cadastro do cliente</param>
        /// <returns>Valor da compra com a promoção aplicada</returns>
        public decimal Aplicar(decimal valor, int tipoCliente)
        {
            decimal valorAplicado = 0;

            if (tipoCliente == 1) //1: Cliente Comum
            {
                decimal porcentagem = valor * 5 / 100;
                valorAplicado = valor - porcentagem;
            }
            else if (tipoCliente == 2) //2: Cliente VIP
            {
                decimal porcentagem = valor * 10 / 100;
                valorAplicado = valor - porcentagem;
            }
            else if (tipoCliente == 3) //3: Cliente Novo
            {
                decimal porcentagem = valor * 5 / 100;
                valorAplicado = valor - porcentagem;
            }

            return valorAplicado;
        }

    }
}
