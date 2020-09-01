namespace exercicio_3_Alex_Ferreira_Santos.Models
{
    public class Curtidos
    {
        public int idCurtidos { get; set; }
        public string fotoProduto { get; set; }
        public string nomeProduto { get; set; }
        public double precoProduto  {get; set; }
        public string categoriaProduto { get; set; }
        public double promocaoProduto { get; set; }
        public int idProduto { get; set; }
        public int? idUsuario { get; set; }
    }
}