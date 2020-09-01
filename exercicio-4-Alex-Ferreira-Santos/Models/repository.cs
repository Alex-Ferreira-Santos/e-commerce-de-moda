using MySqlConnector;

namespace exercicio_3_Alex_Ferreira_Santos.Models
{
    public class repository
    {
        protected const string _stringConexao="Database=moda;Data Source=localhost;User Id=root";
        protected MySqlConnection conexao = new MySqlConnection(_stringConexao);
    }
}