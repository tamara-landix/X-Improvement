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

            if (Conexao.AbrirConexao())
            {
                Application.Run(new Principal());
            }
        }
    }
}
