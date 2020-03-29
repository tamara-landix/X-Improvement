using Visao;
using System;
using System.Windows.Forms;
using BD;

namespace ListaPresenca
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (!Conexao.Open())
            {
                string mensage = string.Concat("Não foi possível conectar ao banco de dados.", "\n",
                                               "\n", "Por favor verifique a disponibilidade do banco:", "\n",
                                               "\n", Conexao.Connection.ConnectionString.Replace(";", "\n"));

                MessageBox.Show(mensage, "Erro...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Application.Run(new Principal());
            }
        }
    }
}
