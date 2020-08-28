using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using MySqlConnector;

namespace exercicio_3_Alex_Ferreira_Santos.Models
{
    public class CurtidosRepository : repository
    {
        public List<Curtidos> curtidos(int id){
            conexao.Open();
            string sql=$"select * from produto inner join curtidos on produto.idProduto=curtidos.idProduto where idUsuario={id}";
            MySqlCommand comando = new MySqlCommand(sql,conexao);
            MySqlDataReader reader = comando.ExecuteReader();
            List<Curtidos> lista = new List<Curtidos>();
            while (reader.Read())
            {
                Curtidos c =new Curtidos();
                c.idUsuario=id;
                c.idCurtidos=reader.GetInt32("idCurtido");
                c.idProduto=reader.GetInt32("idProduto");
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
        public void insert(Curtidos c){
            conexao.Open();
            string sql="insert into curtidos(idProduto,idUsuario) values(@idProduto,@idUsuario)";
            MySqlCommand comando = new MySqlCommand(sql,conexao);
            comando.Parameters.AddWithValue("@idProduto",c.idProduto);
            comando.Parameters.AddWithValue("@idUsuario",c.idUsuario);
            comando.ExecuteNonQuery();
            conexao.Close();
        }
        public void delete(Curtidos c){
            conexao.Open();
            string sql="DELETE FROM curtidos WHERE idProduto=@idProduto and idUsuario=@idUsuario";
            MySqlCommand comando = new MySqlCommand(sql,conexao);
            comando.Parameters.AddWithValue("@idProduto",c.idProduto);
            comando.Parameters.AddWithValue("@idUsuario",c.idUsuario);
            comando.ExecuteNonQuery();
            conexao.Close();
        }
    }
}