using System;
using System.Collections.Generic;
using MySqlConnector;

namespace exercicio_3_Alex_Ferreira_Santos.Models
{
    public class CarrinhoRepository  : repository
    {
        public List<Carrinho> carrinho(int? id){
            conexao.Open();
            string sql=$"select * from produto inner join carrinho on produto.idProduto=carrinho.idProdutos where idUsuarios={id}";
            MySqlCommand comando = new MySqlCommand(sql,conexao);
            MySqlDataReader reader = comando.ExecuteReader();
            List<Carrinho> lista = new List<Carrinho>();
            while (reader.Read())
            {
                Carrinho c =new Carrinho();
                c.idUsuarios=id;
                c.idCarrinho=reader.GetInt32("idCarrinho");
                c.idProdutos=reader.GetInt32("idProdutos");
                c.nomeProduto=reader.IsDBNull(reader.GetOrdinal("nomeProduto"))?null:reader.GetString("nomeProduto");
                c.fotoProduto=reader.IsDBNull(reader.GetOrdinal("fotoProduto"))?null:reader.GetString("fotoProduto");
                c.categoriaProduto=reader.IsDBNull(reader.GetOrdinal("categoriaProduto"))?null:reader.GetString("categoriaProduto");
                c.precoProduto=reader.IsDBNull(reader.GetOrdinal("precoProduto"))?0:reader.GetDouble("precoProduto");
                c.promocaoProduto=reader.IsDBNull(reader.GetOrdinal("promocaoProduto"))?0:reader.GetDouble("promocaoProduto");
                lista.Add(c);
            }
            conexao.Close();
            return lista;
        }
        public void insert(Carrinho c,int? id){
            conexao.Open();
            string sql="insert into carrinho(idProdutos,idUsuarios) values(@idProduto,@idUsuario)";
            MySqlCommand comando = new MySqlCommand(sql,conexao);
            comando.Parameters.AddWithValue("@idProduto",c.idProdutos);
            comando.Parameters.AddWithValue("@idUsuario",id);
            comando.ExecuteNonQuery();
            conexao.Close();
        }
        public void remove(Carrinho c,int? id){
            conexao.Open();
            string sql=$"delete from carrinho where idCarrinho={c.idCarrinho} and idUsuarios={id}";
            MySqlCommand comando = new MySqlCommand(sql,conexao);
            comando.ExecuteNonQuery();
            conexao.Close();
        }
    }
}