using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaPresenca.Visao
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void btn_confirmarPresenca_Click(object sender, EventArgs e)
        {
            Cadastro formCadastro = new Cadastro();
            formCadastro.ShowDialog();
        }

        private void btn_lista_Click(object sender, EventArgs e)
        {
            Confirmados formConfirmados = new Confirmados();
            formConfirmados.ShowDialog();
        }
    }
}
