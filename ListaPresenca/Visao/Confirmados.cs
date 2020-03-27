using BD;
using System;
using System.Data;
using System.Data.Common;
using System.Windows.Forms;

namespace Visao
{
    public partial class Confirmados : Form
    {
        #region Construtores

        /// <summary>
        /// Construtor
        /// </summary>
        public Confirmados()
        {
            InitializeComponent();

            CarregaGrid();
        }

        #endregion Construtores

        #region Eventos

        /// <summary>Evento executado ao acionar o botão alterar</summary>
        /// <param name="sender">Referência ao controle que disparou o evento</param>
        /// <param name="e">Armazena informações do evento que foi acionado</param></param>
        private void btn_alterar_Click(object sender, EventArgs e)
        {
            if (dgv_confirmados.CurrentRow == null)
            {
                MessageBox.Show("Selecione um registro!", "Alerta...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Cadastro formCadastro = new Cadastro(dgv_confirmados.CurrentRow.Cells["EMAIL"].Value.ToString());
            if (formCadastro.ShowDialog() == DialogResult.OK)
            {
                CarregaGrid();
            }
        }

        /// <summary>Evento executado ao acionar o botão excluir</summary>
        /// <param name="sender">Referência ao controle que disparou o evento</param>
        /// <param name="e">Armazena informações do evento que foi acionado</param></param>
        private void btn_excluir_Click(object sender, EventArgs e)
        {
            if (dgv_confirmados.CurrentRow == null)
            {
                MessageBox.Show("Selecione um registro!", "Alerta...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            string email = dgv_confirmados.CurrentRow.Cells["EMAIL"].Value.ToString();
            if (MessageBox.Show("Deseja realmente excluir a confirmação para o usuário '" + email + "'?", "Confirma...", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Excluir(email);

                CarregaGrid();
            }
        }

        #endregion Eventos

        #region Métodos

        /// <summary>
        /// Excluir o registro selecionado
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        private bool Excluir(string email)
        {
            try
            {
                DbCommand cmd = Conexao.Connection.CreateCommand();
                cmd.CommandText = " DELETE FROM CONFIRMADOS WHERE EMAIL = '" + email + "' ";

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
        /// Carrega o grid com as informações do confirmados
        /// </summary>
        private void CarregaGrid()
        {
            string sql = "SELECT NOME, EMAIL, ACOMPANHANTE FROM CONFIRMADOS";

            DbCommand cmd = Conexao.Connection.CreateCommand();
            cmd.CommandText = sql;

            DbDataReader reader = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(reader);

            dgv_confirmados.DataSource = dt.DefaultView;

            dgv_confirmados.Columns[0].HeaderText = "Nome";
            dgv_confirmados.Columns[1].HeaderText = "E-mail";
            dgv_confirmados.Columns[2].HeaderText = "Nome do Acompanhante";
        }

        #endregion Métodos
    }
}
