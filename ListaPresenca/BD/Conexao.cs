using System.Collections.Generic;
using System.Data.Common;
using System.Windows.Forms;

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
        private static bool Open()
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

        /// <summary>
        /// Trata a abertura de conexão com o banco de dados
        /// </summary>
        /// <returns>True -> Conexão aberta</returns>
        public static bool AbrirConexao()
        {
            if (!Open())
            {
                List<string> parametros = new List<string>();

                foreach (var item in Connection.ConnectionString.Split(';'))
                {
                    if (!item.Contains("Password"))
                    {
                        parametros.Add(item);
                    }
                }

                string dadosConexao = string.Empty;

                foreach (var item in parametros)
                {
                    dadosConexao = string.Concat(dadosConexao, "\n", item);
                }

                string mensage = string.Concat("Não foi possível conectar ao banco de dados.", "\n",
                                               "\n", "Por favor verifique a disponibilidade do banco:", "\n",
                                               dadosConexao);

                MessageBox.Show(mensage, "Erro...", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }

            return true;
        }
    }
}
