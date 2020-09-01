using System.Collections.Generic;
using MySqlConnector;

namespace exercicio_3_Alex_Ferreira_Santos.Models
{
    public class usuarioRepository : repository
    {
        public void insert(usuario u){
            conexao.Open();
            string sql="INSERT INTO usuario(nomeUsuario,emailUsuario, senhaUsuario, nascimentoUsuario, telefoneUsuario, tipoUsuario) values(@nome,@email, @senha, @nascimento, @telefone, @tipo)";
            MySqlCommand comando = new MySqlCommand(sql,conexao);
            comando.Parameters.AddWithValue("@nome",u.nome);
            comando.Parameters.AddWithValue("@email",u.email);
            comando.Parameters.AddWithValue("@senha",u.senha);
            comando.Parameters.AddWithValue("@nascimento",u.nascimento);
            comando.Parameters.AddWithValue("@telefone",u.telefone);
            comando.Parameters.AddWithValue("@tipo",u.tipo);
            comando.ExecuteNonQuery();
            conexao.Close();
        }
        public usuario login(usuario u){
            conexao.Open();
            string sql="SELECT * FROM usuario WHERE emailUsuario=@email and senhaUsuario=@senha";
            MySqlCommand comando=new MySqlCommand(sql,conexao);
            comando.Parameters.AddWithValue("@email",u.email);
            comando.Parameters.AddWithValue("@senha",u.senha);
            comando.Parameters.AddWithValue("@nome",u.nome);
            comando.Parameters.AddWithValue("@tipo",u.tipo);
            MySqlDataReader reader= comando.ExecuteReader();
            usuario user=null;
            if (reader.Read())
            {
                user=new usuario();
                user.id=reader.GetInt32("idUsuario");
                user.email=reader.IsDBNull(reader.GetOrdinal("emailUsuario"))?null:reader.GetString("emailUsuario");
                user.senha=reader.IsDBNull(reader.GetOrdinal("senhaUsuario"))?null:reader.GetString("senhaUsuario");
                user.nome=reader.GetString("nomeUsuario");
                user.tipo=reader.GetInt32("tipoUsuario");
            }
            conexao.Close();
            return user;
        }
        public void update(usuario u){
            conexao.Open();
            string sql="UPDATE usuario SET emailUsuario=@email,senhaUsuario=@senha WHERE idUsuario=@id";
            MySqlCommand comando = new MySqlCommand(sql,conexao);
            comando.Parameters.AddWithValue("@id",u.id);
            comando.Parameters.AddWithValue("@email",u.email);
            comando.Parameters.AddWithValue("@senha",u.senha);
            comando.ExecuteNonQuery();
            conexao.Close();
        }
        public void updateAdm(usuario u){
            conexao.Open();
            string sql="UPDATE usuario SET tipoUsuario=@tipo WHERE idUsuario=@id AND emailUsuario=@email AND nomeUsuario=@nome";
            MySqlCommand comando = new MySqlCommand(sql,conexao);
            comando.Parameters.AddWithValue("@id",u.id);
            comando.Parameters.AddWithValue("@nome",u.nome);
            comando.Parameters.AddWithValue("@email",u.email);
            comando.Parameters.AddWithValue("@tipo",u.tipo);
            comando.ExecuteNonQuery();
            conexao.Close();
        }
        public void delete(usuario u){
            conexao.Open();
            string sql="DELETE FROM usuario WHERE idUsuario=@id and emailUsuario=@email and senhaUsuario=@senha and nascimentoUsuario=@nascimento and telefoneUsuario=@telefone";
            MySqlCommand comando = new MySqlCommand(sql,conexao);
            comando.Parameters.AddWithValue("@id", u.id);
            comando.Parameters.AddWithValue("@nascimento",u.nascimento);
            comando.Parameters.AddWithValue("@telefone",u.telefone);
            comando.Parameters.AddWithValue("@email",u.email);
            comando.Parameters.AddWithValue("@senha",u.senha);
            comando.ExecuteNonQuery();
            conexao.Close();
        }
    }
}