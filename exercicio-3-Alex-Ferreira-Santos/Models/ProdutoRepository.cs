using System.Collections.Generic;
using MySqlConnector;

namespace exercicio_3_Alex_Ferreira_Santos.Models
{
    public class ProdutoRepository : repository
    {
        public void insert(Produto p){
            conexao.Open();
            string sql="INSERT INTO produto(fotoProduto,nomeProduto,precoProduto,categoriaProduto,promocaoProduto) values(@foto,@nome,@preco,@categoria,@promocao)";
            MySqlCommand comando = new MySqlCommand(sql,conexao);
            comando.Parameters.AddWithValue("@foto",p.image);
            comando.Parameters.AddWithValue("@nome",p.nome);
            comando.Parameters.AddWithValue("@preco",p.preco);
            comando.Parameters.AddWithValue("@categoria",p.categoria);
            comando.Parameters.AddWithValue("@promocao",p.promocao);
            
        }
        public List<Produto> select(Produto po){
            conexao.Open();
            string sql="SELECT * FROM produto WHERE idUsuario=@idUsuario";
            MySqlCommand comando = new MySqlCommand(sql,conexao);
            comando.Parameters.AddWithValue("@idUsuario",po.idUsuario);
            List<Produto> lista = new List<Produto>();
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                Produto p =new Produto();
                p.id=reader.GetInt32("idProduto");
                p.nome=reader.IsDBNull(reader.GetOrdinal("nomeProduto"))?null:reader.GetString("nomeProduto");
                p.image=reader.IsDBNull(reader.GetOrdinal("fotoProduto"))?null:reader.GetString("fotoProduto");
                p.categoria=reader.IsDBNull(reader.GetOrdinal("categoriaProduto"))?null:reader.GetString("categoriaProduto");
                p.preco=reader.IsDBNull(reader.GetOrdinal("precoProduto"))?0:reader.GetDecimal("precoProduto");
                p.promocao=reader.IsDBNull(reader.GetOrdinal("promocaoProduto"))?0:reader.GetDecimal("promocaoProduto");
                lista.Add(p);
            }
            conexao.Close();
            return lista;
        }
        public void update(Produto p){
            conexao.Open();
            string sql="UPDATE produto SET nomeProduto=@nome,fotoProduto=@foto,categoriaProduto=@categoria,precoProduto=@preco,promocaoProduto=@promocao WHERE idProduto=@id";
            MySqlCommand comando = new MySqlCommand(sql,conexao);
            comando.Parameters.AddWithValue("@nome",p.nome);
            comando.Parameters.AddWithValue("@foto",p.image);
            comando.Parameters.AddWithValue("@categoria",p.categoria);
            comando.Parameters.AddWithValue("@preco",p.preco);
            comando.Parameters.AddWithValue("@promocao",p.promocao);
            comando.ExecuteNonQuery();
            conexao.Close();
        }
        public void delete(Produto p){
            conexao.Open();
            string sql="DELETE FROM usuario WHERE idProduto=@id AND fotoProduto=@foto AND nomeProduto=@nome";
            MySqlCommand comando = new MySqlCommand(sql,conexao);
            comando.Parameters.AddWithValue("@id",p.id);
            comando.Parameters.AddWithValue("@foto",p.image);
            comando.Parameters.AddWithValue("@nome",p.nome);
            comando.ExecuteNonQuery();
            conexao.Close();
        }
    }
}