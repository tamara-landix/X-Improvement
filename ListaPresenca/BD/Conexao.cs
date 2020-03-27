using System.Data.Common;

namespace BD
{
    public static class Conexao
    {
        public static DbConnection conexao;

        public static DbConnection Connection
        {
            get { return conexao; }
        }

        /// <summary>
        /// Abre a conexão com o banco de dados
        /// </summary>
        /// <returns>True -> Conexão aberta com sucesso</returns>
        public static bool Open()
        {
            try
            {
                string connectionString = "Database=LDXPROJETO;Server=codorna.fw.landix.com.br;User ID=LDXPROJETO;Password=4ZUCyrRz;";
                conexao = new System.Data.SqlClient.SqlConnection(connectionString);
                conexao.Open();

                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
