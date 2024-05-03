using MySqlConnector;

namespace EmpresaABC
{
    class Conexao
    {
        private static string connString = "Server=localhost;Port=3306;Database=dbloja;Uid=root;Pwd=";

        private static MySqlConnection con = null;

        public static MySqlConnection obterConexao()
        {
            con = new MySqlConnection(connString);
            try
            {
                con.Open();
            }
            catch (MySqlException)
            {
                con = null;
            }
            return con;

        }
        public static void fecharConexao()
        {
            if (con != null)
            {
                con.Close();
            }
        }
    }
}
