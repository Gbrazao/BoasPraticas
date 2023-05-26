namespace BoasPraticas.Service.Cenarios.Resolucao
{

    /// <summary>
    /// Interface responsável por conter todas as funcionalidades do Funcionário.
    /// </summary>
    public interface IFuncionario
    {
        void Trabalhar();
        void Almocar();
        void Descansar();
    }

    /// <summary>
    /// Interface responsável por conter todas as funcionalidades do Funcionário de Atendimento.
    /// </summary>
    public interface IFuncionarioAtendimento
    {
        void AtenderTelefone();
    }

    /// <summary>
    /// Interface responsável por conter todas as funcionalidades do Funcionário Operacional.
    /// </summary>
    public interface IFuncionarioOperacional
    {
        void FazerRelatorio();
    }


    /// <summary>
    /// Classe responsável por conter as funcionalidades do Gerente.
    /// </summary>
    public class Gerente : IFuncionario, IFuncionarioOperacional
    {
        public void Almocar()
        {
            throw new NotImplementedException();
        }

        public void Descansar()
        {
            throw new NotImplementedException();
        }

        public void FazerRelatorio()
        {
            throw new NotImplementedException();
        }

        public void Trabalhar()
        {
            throw new NotImplementedException();
        }
    }

    public class Recepcionista : IFuncionario, IFuncionarioAtendimento
    {
        public void Almocar()
        {
            throw new NotImplementedException();
        }

        public void AtenderTelefone()
        {
            throw new NotImplementedException();
        }

        public void Descansar()
        {
            throw new NotImplementedException();
        }

        public void Trabalhar()
        {
            throw new NotImplementedException();
        }
    }

    public class Estagiario : IFuncionario
    {
        public void Almocar()
        {
            throw new NotImplementedException();
        }

        public void Descansar()
        {
            throw new NotImplementedException();
        }

        public void Trabalhar()
        {
            throw new NotImplementedException();
        }
    }

}
