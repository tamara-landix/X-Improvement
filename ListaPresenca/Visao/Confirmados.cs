using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaPresenca.Visao
{
    public partial class Confirmados : Form
    {
        public static string pathDatabase = Directory.GetParent(Directory.GetParent(Application.StartupPath).FullName).FullName + "\\database\\landix_database.db3";
        public static SQLiteConnection Conexao;
        public static string strConn = "Data Source=" + pathDatabase + "";

        public Confirmados()
        {
            InitializeComponent();

            ConectaBD();
            CarregaGrid();
        }

        void ConectaBD()
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

        private void CarregaGrid()
        {
            DataTable dt = new DataTable();
            string sql = "SELECT * FROM CONFIRMADOS";

            SQLiteDataAdapter da = new SQLiteDataAdapter(sql, strConn);
            da.Fill(dt);

            dgv_confirmados.DataSource = dt.DefaultView;

            dgv_confirmados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

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
    }
}
