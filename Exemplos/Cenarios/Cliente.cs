namespace BoasPraticas.Service.Cenarios
{
    /// <summary>
    /// Classe responsável pelas informações e funcionalidades do Cliente.
    /// </summary>
    public class Cliente
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Endereco { get; set; }


        /// <summary>
        /// Método responsável por Validar se o Cliente está apto para cadastramento.
        /// </summary>
        /// <param name="cliente"></param>
        public void ValidarCliente(Cliente cliente)
        {         
        }

        /// <summary>
        /// Método responsável por salvar o cliente no banco de dados
        /// </summary>
        /// <param name="cliente"></param>
        public void SalvarCliente(Cliente cliente)
        {          
        }

        /// <summary>
        /// Método responsável por enviar email para o cliente.
        /// </summary>
        /// <param name="message"></param>
        public void EnviarEmail(string message, string email)
        {            
        }
    }
}
