using System;
using System.Windows.Forms;

namespace ListaPresenca.Visao
{
    public partial class Principal : Form
    {
        #region Construtores

        /// <summary>
        /// Construtor
        /// </summary>
        public Principal()
        {
            InitializeComponent();
        }

        #endregion Construtores

        #region Eventos

        /// <summary>Evento executado ao acionar o botão "Confirmar Presença"</summary>
        /// <param name="sender">Referência ao controle que disparou o evento</param>
        /// <param name="e">Armazena informações do evento que foi acionado</param></param>
        private void btn_confirmarPresenca_Click(object sender, EventArgs e)
        {
            Cadastro formCadastro = new Cadastro();
            formCadastro.ShowDialog();
        }

        /// <summary>Evento executado ao acionar o botão "Ver Confirmados"</summary>
        /// <param name="sender">Referência ao controle que disparou o evento</param>
        /// <param name="e">Armazena informações do evento que foi acionado</param></param>
        private void btn_lista_Click(object sender, EventArgs e)
        {
            Senha formSenha = new Senha();
            var result = formSenha.ShowDialog();

            formSenha.Close();
        }

        #endregion Eventos
    }
}
