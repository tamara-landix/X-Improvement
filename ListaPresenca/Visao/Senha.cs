using System;
using System.Windows.Forms;

namespace Visao
{
    public partial class Senha : Form
    {
        #region Construtores

        /// <summary>
        /// Construtor
        /// </summary>
        public Senha()
        {
            InitializeComponent();
        }

        #endregion Construtores

        #region Eventos

        /// <summary>Evento executado ao acionar o botão acessar</summary>
        /// <param name="sender">Referência ao controle que disparou o evento</param>
        /// <param name="e">Armazena informações do evento que foi acionado</param>
        private void btn_acessar_Click(object sender, EventArgs e)
        {
            ValidaSenha();
        }

        /// <summary>Evento executado ao digitar no campo de senha</summary>
        /// <param name="sender">Referência ao controle que disparou o evento</param>
        /// <param name="e">Armazena informações do evento que foi acionado</param>
        private void txt_senha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ValidaSenha();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        #endregion Eventos

        #region Métodos

        /// <summary>
        /// Valida a senha digitada
        /// </summary>
        private void ValidaSenha()
        {
            if (this.GerarMD5(txt_senha.Text) == "827CCB0EEA8A706C4C34A16891F84E7B")
            {
                Confirmados formConfirmados = new Confirmados();
                formConfirmados.ShowDialog();

                this.Close();
                formConfirmados.Close();
            }
            else
            {
                MessageBox.Show("Senha inválida!", "Erro...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_senha.SelectAll();
            }
        }
        
        /// <summary>
        /// Gera senha criptografada
        /// </summary>
        /// <param name="senha">Senha</param>
        /// <returns>Senha criptografa</returns>
        public string GerarMD5(string senha)
        {
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(senha);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                System.Text.StringBuilder sb = new System.Text.StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }

                return sb.ToString();
            }
        }

        #endregion Métodos
    }
}
