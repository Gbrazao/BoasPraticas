
namespace BoasPraticas.Service.Cenarios
{
    /// <summary>
    /// Classe responsável pelas informações e métodos do Produto.
    /// </summary>
    public class Produto
    {
        public string Nome { get; set; }
        public string Categoria { get; set; }
        public decimal Preco { get; set; }

        public void CalcularDesconto(decimal desconto)
        {
            Preco = Preco - Preco * desconto;
            Console.WriteLine($"{Nome} tem um novo preço: {Preco}");
        }
    }


    /// <summary>
    /// Classe responsável pelas informações e métodos de Serviço do Produto.
    /// </summary>
    public class ProdutoService
    {
        public void AplicarDesconto(List<Produto> produtos, decimal percentualDesconto)
        {
            foreach (var produto in produtos)
            {
                produto.CalcularDesconto(percentualDesconto);
            }
        }
    }
}
