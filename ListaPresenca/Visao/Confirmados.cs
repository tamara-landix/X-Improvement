using System;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;

namespace ListaPresenca.Visao
{
    public partial class Confirmados : Form
    {
        #region Variáveis

        public static string pathDatabase = Directory.GetParent(Directory.GetParent(Application.StartupPath).FullName).FullName + "\\database\\landix_database.db3";
        public static SQLiteConnection Conexao;
        public static string strConn = "Data Source=" + pathDatabase + "";

        #endregion Variáveis

        #region Construtores

        /// <summary>
        /// Construtor
        /// </summary>
        public Confirmados()
        {
            InitializeComponent();

            ConectaBD();
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
                var cmd = Conexao.CreateCommand();
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
            DataTable dt = new DataTable();
            string sql = "SELECT NOME, EMAIL, ACOMPANHANTE FROM CONFIRMADOS";

            SQLiteDataAdapter da = new SQLiteDataAdapter(sql, strConn);
            da.Fill(dt);

            dgv_confirmados.DataSource = dt.DefaultView;

            dgv_confirmados.Columns[0].HeaderText = "Nome";
            dgv_confirmados.Columns[1].HeaderText = "E-mail";
            dgv_confirmados.Columns[2].HeaderText = "Nome do Acompanhante";
        }

        /// <summary>
        /// Conecta com o banco de dados
        /// </summary>
        private void ConectaBD()
        {
            try
            {
                Conexao = new SQLiteConnection("Data Source=" + pathDatabase + "");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro :" + ex.Message);
            }
            finally
            {
                if (Conexao.State == ConnectionState.Open)
                {
                    Conexao.Close();
                }
            }

            Conexao.Open();
        }

        #endregion Métodos
    }
}
