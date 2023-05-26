namespace BoasPraticas.Service.Resolucao
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Endereco { get; set; }
    }


    public interface IClienteRepository
    {
        public void SalvarCliente(Cliente cliente);
    }
    public interface IClienteEmailService
    {
        public void EnviarEmail(string message);
    }

    public interface ICustomerValidator
    {
        public bool Validate(Cliente cliente);
    }

    public class ClienteService
    {
        private readonly IClienteEmailService _emailService;
        private readonly IClienteRepository _clienteRepository;
        private readonly ICustomerValidator _customerValidator;

        public ClienteService(IClienteEmailService emailService, IClienteRepository clienteRepository, ICustomerValidator customerValidator)
        {
            _emailService = emailService;
            _clienteRepository = clienteRepository;
            _customerValidator = customerValidator;
        }

        public void Criar(Cliente cliente)
        {
            if (_customerValidator.Validate(cliente))
            {
                _clienteRepository.SalvarCliente(cliente);
                _emailService.EnviarEmail("Bem vindo!");
            }
            else
            {
                throw new ArgumentException("Cliente Inválido");
            }
        }
    }
}
