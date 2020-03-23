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

namespace ListaPresenca
{
    public partial class Cadastro : Form
    {
        public static string pathDatabase = Directory.GetParent(Directory.GetParent(Application.StartupPath).FullName).FullName + "\\database\\landix_database.db3";
        public static SQLiteConnection Conexao;
        public static string strConn = "Data Source=" + pathDatabase + "";

        public Cadastro()
        {
            InitializeComponent();

            ConectaBD();
        }

        public Cadastro(string email)
        {
            InitializeComponent();

            ConectaBD();

            AbreEdicao(email);
        }

        void ConectaBD()
        {
            try
            {
                Conexao = new SQLiteConnection(strConn);
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

        private void btn_confirmar_Click(object sender, EventArgs e)
        {
            if (Gravar())
            {
                MessageBox.Show("Confirmação incluída com sucesso!");
                this.Close();
            }
        }

        private bool Gravar()
        {
            try
            {
                var cmd = Conexao.CreateCommand();
                cmd.CommandText = " INSERT INTO CONFIRMADOS (NOME, EMAIL, ACOMPANHANTE, QTDFILHOS) " +
                                  " VALUES ('" + txt_nome.Text + "', '" + txt_email.Text + lbl_sufixoEmail.Text + "', '" + txt_acompanhante.Text + "', '" + numericUpDown1.Value.ToString() + "') ";

                cmd.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível incluir o registro!\n\n" + ex.Message, "Erro", MessageBoxButtons.OK);
                return false;
            }
        }

        private void AbreEdicao(string email)
        {
            DataTable dt = new DataTable();
            string sql = "SELECT * FROM CONFIRMADOS WHERE EMAIL = '" + email + "'";

            SQLiteDataAdapter da = new SQLiteDataAdapter(sql, strConn);
            da.Fill(dt);

            var nome = dt.Columns["NOME"];

            txt_nome.Text = dt.Columns["NOME"].ColumnName;
            txt_email.Text = dt.Columns["EMAIL"].ColumnName;
            txt_acompanhante.Text = dt.Columns["ACOMPANHANTE"].ColumnName;
            numericUpDown1.Text = dt.Columns["QTDFILHOS"].ColumnName;
        }
    }
}
