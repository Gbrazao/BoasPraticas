
namespace BoasPraticas.Service.Resolucao
{
    public interface IProduto
    {
        void CalcularDesconto(decimal desconto);
    }

    public class Product : IProduto
    {
        string Nome { get; set; }
        string Categoria { get; set; }
        decimal Preco { get; set; }

        public void CalcularDesconto(decimal desconto)
        {
            Preco = Preco - (Preco * desconto);
            Console.WriteLine($"{Nome} has a new price: {Nome}");
        }
    }

    public interface IProdutoService
    {
        void AplicarDesconto(List<IProduto> products, decimal percentualDesconto);
    }

    public class ProdutoService : IProdutoService
    {
        public void AplicarDesconto(List<IProduto> produtos, decimal percentualDesconto)
        {
            foreach (var produto in produtos)
            {
                produto.CalcularDesconto(percentualDesconto);
            }
        }
    }

}
