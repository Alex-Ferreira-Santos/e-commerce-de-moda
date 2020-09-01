using System.Collections.Generic;
using MySqlConnector;
using System;

namespace exercicio_3_Alex_Ferreira_Santos.Models
{
    public class ProdutoRepository : repository
    {
        public void insert(Produto p){
            conexao.Open();
            string sql="INSERT INTO produto(fotoProduto,nomeProduto,precoProduto,categoriaProduto,promocaoProduto) values(@foto,@nome,@preco,@categoria,@promocao)";
            MySqlCommand comando = new MySqlCommand(sql,conexao);
            comando.Parameters.AddWithValue("@foto",p.foto);
            comando.Parameters.AddWithValue("@nome",p.nome);
            comando.Parameters.AddWithValue("@preco",p.preco);
            comando.Parameters.AddWithValue("@categoria",p.categoria);
            comando.Parameters.AddWithValue("@promocao",p.promocao);
            comando.ExecuteNonQuery();
            conexao.Close();
        }
        public List<Produto> select(string categoria){
            conexao.Open();
            string sql="SELECT * FROM produto order by idProduto desc";
            if(categoria!=null){
                sql=$"SELECT * FROM produto WHERE categoriaProduto='{categoria}' order by idProduto desc";
            }
            if(categoria=="novidade"){
                sql="SELECT * FROM produto ORDER BY idProduto DESC limit 9";
            }
            MySqlCommand comando = new MySqlCommand(sql,conexao);
            MySqlDataReader reader = comando.ExecuteReader();
            List<Produto> lista = new List<Produto>();
            while (reader.Read())
            {
                Produto p =new Produto();
                p.id=reader.GetInt32("idProduto");
                p.nome=reader.IsDBNull(reader.GetOrdinal("nomeProduto"))?null:reader.GetString("nomeProduto");
                p.foto=reader.IsDBNull(reader.GetOrdinal("fotoProduto"))?null:reader.GetString("fotoProduto");
                p.categoria=reader.IsDBNull(reader.GetOrdinal("categoriaProduto"))?null:reader.GetString("categoriaProduto");
                p.preco=reader.IsDBNull(reader.GetOrdinal("precoProduto"))?0:reader.GetDouble("precoProduto");
                p.promocao=reader.IsDBNull(reader.GetOrdinal("promocaoProduto"))?0:reader.GetDouble("promocaoProduto");
                lista.Add(p);
            }
            conexao.Close();
            return lista;
        }
        public List<Produto> promocao(){
            conexao.Open();
            string sql="SELECT * FROM produto WHERE promocaoProduto<>0 order by idProduto desc limit 3";
            MySqlCommand comando = new MySqlCommand(sql,conexao);
            MySqlDataReader reader = comando.ExecuteReader();
            List<Produto> lista = new List<Produto>();
            while (reader.Read())
            {
                Produto p =new Produto();
                p.id=reader.GetInt32("idProduto");
                p.nome=reader.IsDBNull(reader.GetOrdinal("nomeProduto"))?null:reader.GetString("nomeProduto");
                p.foto=reader.IsDBNull(reader.GetOrdinal("fotoProduto"))?null:reader.GetString("fotoProduto");
                p.categoria=reader.IsDBNull(reader.GetOrdinal("categoriaProduto"))?null:reader.GetString("categoriaProduto");
                p.preco=reader.IsDBNull(reader.GetOrdinal("precoProduto"))?0:reader.GetDouble("precoProduto");
                p.promocao=reader.IsDBNull(reader.GetOrdinal("promocaoProduto"))?0:reader.GetDouble("promocaoProduto");
                lista.Add(p);
            }
            conexao.Close();
            return lista;
        }
        public List<Produto> novo(){
            conexao.Open();
            string sql="SELECT * FROM produto ORDER BY idProduto DESC limit 3";
            MySqlCommand comando = new MySqlCommand(sql,conexao);
            MySqlDataReader reader = comando.ExecuteReader();
            List<Produto> lista = new List<Produto>();
            while (reader.Read())
            {
                Produto p =new Produto();
                p.id=reader.GetInt32("idProduto");
                p.nome=reader.IsDBNull(reader.GetOrdinal("nomeProduto"))?null:reader.GetString("nomeProduto");
                p.foto=reader.IsDBNull(reader.GetOrdinal("fotoProduto"))?null:reader.GetString("fotoProduto");
                p.categoria=reader.IsDBNull(reader.GetOrdinal("categoriaProduto"))?null:reader.GetString("categoriaProduto");
                p.preco=reader.IsDBNull(reader.GetOrdinal("precoProduto"))?0:reader.GetDouble("precoProduto");
                p.promocao=reader.IsDBNull(reader.GetOrdinal("promocaoProduto"))?0:reader.GetDouble("promocaoProduto");
                lista.Add(p);
            }
            conexao.Close();
            return lista;
        }
        
        public void update(Produto p){
            conexao.Open();
            string sql="UPDATE produto SET nomeProduto=@nome,fotoProduto=@foto,categoriaProduto=@categoria,precoProduto=@preco,promocaoProduto=@promocao WHERE idProduto=@id";
            MySqlCommand comando = new MySqlCommand(sql,conexao);
            comando.Parameters.AddWithValue("@id",p.id);
            comando.Parameters.AddWithValue("@nome",p.nome);
            comando.Parameters.AddWithValue("@foto",p.foto);
            comando.Parameters.AddWithValue("@categoria",p.categoria);
            comando.Parameters.AddWithValue("@preco",p.preco);
            comando.Parameters.AddWithValue("@promocao",p.promocao);
            comando.ExecuteNonQuery();
            conexao.Close();
        }
        public void delete(Produto p){
            conexao.Open();
            string sql="DELETE FROM produto WHERE fotoProduto=@foto and nomeProduto=@nome and idProduto=@id";
            MySqlCommand comando = new MySqlCommand(sql,conexao);
            comando.Parameters.AddWithValue("@id",p.id);
            comando.Parameters.AddWithValue("@foto",p.foto);
            comando.Parameters.AddWithValue("@nome",p.nome);
            comando.ExecuteNonQuery();
            conexao.Close();
        }
    }
}