namespace exercicio_3_Alex_Ferreira_Santos.Models
{
    public class Carrinho
    {
        public int idCarrinho { get; set; }
        public string fotoProduto { get; set; }
        public string nomeProduto { get; set; }
        public double precoProduto  {get; set; }
        public double precoTotal=0;
        public string categoriaProduto { get; set; }
        public double promocaoProduto { get; set; }
        public int idProdutos { get; set; }
        public int? idUsuarios { get; set; }
    }
}