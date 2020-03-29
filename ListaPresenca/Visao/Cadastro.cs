using BD;
using System;
using System.Data;
using System.Data.Common;
using System.Windows.Forms;

namespace Visao
{
    public partial class Cadastro : Form
    {
        #region Variáveis

        /// <summary>
        /// Define se é uma edição de cadastro
        /// </summary>
        public bool ehEdicao = false;

        #endregion Variáveis

        #region Construtores

        /// <summary>
        /// Construtor
        /// </summary>
        public Cadastro()
        {
            InitializeComponent();

            this.Text = "Inclusão";
        }

        /// <summary>
        /// Construtor
        /// </summary>
        /// <param name="email">E-mail</param>
        public Cadastro(string email)
        {
            InitializeComponent();

            this.Text = "Edição";
            ehEdicao = true;

            AbreEdicao(email);
        }

        #endregion Construtores

        #region Eventos

        /// <summary>Evento executado ao acionar o botão confirmar</summary>
        /// <param name="sender">Referência ao controle que disparou o evento</param>
        /// <param name="e">Armazena informações do evento que foi acionado</param>
        private void btn_confirmar_Click(object sender, EventArgs e)
        {
            if (Validacao())
            {
                if (Gravar())
                {
                    MessageBox.Show("Confirmação " + (ehEdicao ? "alterada" :  "incluída") + " com sucesso!", "Sucesso...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }

        /// <summary>Evento executado ao digitar nos campos de texto</summary>
        /// <param name="sender">Referência ao controle que disparou o evento</param>
        /// <param name="e">Armazena informações do evento que foi acionado</param>
        private void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = false;

            // Trata aspas
            if (e.KeyChar.Equals('\'') || e.KeyChar.Equals('\"'))
            {
                e.Handled = true;
            }
        }

        #endregion Eventos

        #region Métodos

        /// <summary>
        /// Valida preenchimento dos campos
        /// </summary>
        /// <returns></returns>
        private bool Validacao()
        {
            if (string.IsNullOrEmpty(txt_nome.Text))
            {
                MessageBox.Show("Preencha o seu nome!", "Campo em branco...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_nome.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txt_email.Text))
            {
                MessageBox.Show("Preencha o seu e-mail!", "Campo em branco...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_email.Focus();
                return false;
            }

            if (txt_email.Text.Contains("@"))
            {
                MessageBox.Show("E-mail inválido:\n" + txt_email.Text + lbl_sufixoEmail.Text, "Alerta...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_email.Focus();
                return false;
            }

            if (this.VerificaConfirmacao(txt_email.Text + lbl_sufixoEmail.Text))
            {
                MessageBox.Show(string.Concat("Sua presença já foi confirmada anteriormente.", "\n", "Caso queira alterar, entre em contato com gente@landix.com.br"), "Alerta...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_email.Focus();
                return false;
            }

            return true;
        }

        /// <summary>
        /// Grava confirmação de presença
        /// </summary>
        /// <returns></returns>
        private bool Gravar()
        {
            try
            {
                string email = (txt_email.Text + lbl_sufixoEmail.Text).ToLower();

                DbCommand cmd = Conexao.Connection.CreateCommand();

                if (ehEdicao)
                {
                    cmd.CommandText = " UPDATE CONFIRMADOS " +
                                      " SET NOME = '" + txt_nome.Text + "', ACOMPANHANTE = '" + txt_acompanhante.Text + "' " +
                                      " WHERE EMAIL = '" + email + "'";
                }
                else
                {
                    cmd.CommandText = " INSERT INTO CONFIRMADOS (NOME, EMAIL, ACOMPANHANTE) " +
                                      " VALUES ('" + txt_nome.Text + "', '" + email + "', '" + txt_acompanhante.Text + "') ";
                }

                cmd.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível incluir o registro!\n\n" + ex.Message, "Erro", MessageBoxButtons.OK);
                return false;
            }
        }

        /// <summary>
        /// Abre o cadastro para editar os dados
        /// </summary>
        /// <param name="email"></param>
        private void AbreEdicao(string email)
        {
            string sql = "SELECT NOME, REPLACE(EMAIL, '" + lbl_sufixoEmail.Text + "', '') AS EMAIL, ACOMPANHANTE FROM CONFIRMADOS WHERE EMAIL = '" + email + "'";

            DbCommand cmd = Conexao.Connection.CreateCommand();
            cmd.CommandText = sql;

            DbDataReader reader = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(reader);

            txt_nome.DataBindings.Add("Text", dt, "NOME");
            txt_email.DataBindings.Add("Text", dt, "EMAIL");
            txt_acompanhante.DataBindings.Add("Text", dt, "ACOMPANHANTE");

            txt_email.Enabled = false;
        }

        /// <summary>
        /// Verifica se já existe confirmação para o e-mail informado
        /// </summary>
        /// <param name="email">E-mail a ser buscado</param>
        /// <returns>True -> Confirmação encontrada</returns>
        private bool VerificaConfirmacao(string email)
        {
            string sql = "SELECT * FROM CONFIRMADOS WHERE EMAIL = '" + email + "'";

            DbCommand cmd = Conexao.Connection.CreateCommand();
            cmd.CommandText = sql;

            DbDataReader reader = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(reader);

            if (dt.Rows.Count > 0)
            {
                return true;
            }

            return false;
        }

        #endregion Métodos
    }
}
