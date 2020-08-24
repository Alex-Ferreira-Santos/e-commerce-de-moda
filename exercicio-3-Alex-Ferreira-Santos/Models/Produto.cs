namespace exercicio_3_Alex_Ferreira_Santos.Models
{
    public class Produto
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string image { get; set; }
        public decimal preco { get; set; }
        public string categoria { get; set; }
        public decimal promocao { get; set; }
        public int idUsuario { get; set; }
    }
}