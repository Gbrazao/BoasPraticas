namespace BoasPraticas.Service.Cenarios
{

    /// <summary>
    /// Interface responsável por conter todas as funcionalidades do Funcionário.
    /// </summary>
    public interface IFuncionario
    {
        void Trabalhar();
        void Almocar();
        void Descansar();
        void AtenderTelefone();
        void FazerRelatorio();
    }

    /// <summary>
    /// Classe responsável por conter as funcionalidades do Gerente.
    /// </summary>
    public class Gerente : IFuncionario
    {
        public void Trabalhar()
        {
            Console.WriteLine("O Analista está trabalhando");
        }

        public void Almocar()
        {
            Console.WriteLine("O Analista está almoçando");
        }

        public void Descansar()
        {
            Console.WriteLine("O Analista está descansando");
        }

        public void FazerRelatorio()
        {
            Console.WriteLine("O Analista está fazendo um relatório");
        }

        public void AtenderTelefone()
        {
            Console.WriteLine("O Analista está atendendo o telefone");
        }
    }


}
