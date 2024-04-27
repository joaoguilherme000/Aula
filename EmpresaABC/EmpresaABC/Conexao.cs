using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace EmpresaABC
{
    class Conexao
    {
        private static string connString = "Server=localhost;Port=3306;Database=dbloja;Uid=admin;Pwd=admin";

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
