namespace ListaPresenca
{
    partial class Cadastro
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pan_principal = new System.Windows.Forms.Panel();
            this.pan_filhos = new System.Windows.Forms.Panel();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.lbl_filhos = new System.Windows.Forms.Label();
            this.pan_acompanhante = new System.Windows.Forms.Panel();
            this.txt_acompanhante = new System.Windows.Forms.TextBox();
            this.lbl_acompanhante = new System.Windows.Forms.Label();
            this.pan_email = new System.Windows.Forms.Panel();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.lbl_sufixoEmail = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.pan_nome = new System.Windows.Forms.Panel();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.pan_botoes = new System.Windows.Forms.Panel();
            this.btn_confirmar = new System.Windows.Forms.Button();
            this.pan_principal.SuspendLayout();
            this.pan_filhos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.pan_acompanhante.SuspendLayout();
            this.pan_email.SuspendLayout();
            this.pan_nome.SuspendLayout();
            this.pan_botoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // pan_principal
            // 
            this.pan_principal.BackColor = System.Drawing.SystemColors.Window;
            this.pan_principal.Controls.Add(this.pan_filhos);
            this.pan_principal.Controls.Add(this.pan_acompanhante);
            this.pan_principal.Controls.Add(this.pan_email);
            this.pan_principal.Controls.Add(this.pan_nome);
            this.pan_principal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pan_principal.Location = new System.Drawing.Point(0, 0);
            this.pan_principal.Name = "pan_principal";
            this.pan_principal.Size = new System.Drawing.Size(516, 127);
            this.pan_principal.TabIndex = 0;
            // 
            // pan_filhos
            // 
            this.pan_filhos.BackColor = System.Drawing.SystemColors.Window;
            this.pan_filhos.Controls.Add(this.numericUpDown1);
            this.pan_filhos.Controls.Add(this.lbl_filhos);
            this.pan_filhos.Dock = System.Windows.Forms.DockStyle.Top;
            this.pan_filhos.Location = new System.Drawing.Point(0, 72);
            this.pan_filhos.Name = "pan_filhos";
            this.pan_filhos.Size = new System.Drawing.Size(516, 24);
            this.pan_filhos.TabIndex = 5;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Dock = System.Windows.Forms.DockStyle.Left;
            this.numericUpDown1.Location = new System.Drawing.Point(146, 0);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(50, 20);
            this.numericUpDown1.TabIndex = 1;
            // 
            // lbl_filhos
            // 
            this.lbl_filhos.AutoSize = true;
            this.lbl_filhos.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbl_filhos.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_filhos.Location = new System.Drawing.Point(0, 0);
            this.lbl_filhos.Name = "lbl_filhos";
            this.lbl_filhos.Size = new System.Drawing.Size(146, 16);
            this.lbl_filhos.TabIndex = 0;
            this.lbl_filhos.Text = "Quantidade de Filhos:";
            // 
            // pan_acompanhante
            // 
            this.pan_acompanhante.BackColor = System.Drawing.SystemColors.Window;
            this.pan_acompanhante.Controls.Add(this.txt_acompanhante);
            this.pan_acompanhante.Controls.Add(this.lbl_acompanhante);
            this.pan_acompanhante.Dock = System.Windows.Forms.DockStyle.Top;
            this.pan_acompanhante.Location = new System.Drawing.Point(0, 48);
            this.pan_acompanhante.Name = "pan_acompanhante";
            this.pan_acompanhante.Size = new System.Drawing.Size(516, 24);
            this.pan_acompanhante.TabIndex = 4;
            // 
            // txt_acompanhante
            // 
            this.txt_acompanhante.Dock = System.Windows.Forms.DockStyle.Right;
            this.txt_acompanhante.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txt_acompanhante.Location = new System.Drawing.Point(168, 0);
            this.txt_acompanhante.MaxLength = 100;
            this.txt_acompanhante.Name = "txt_acompanhante";
            this.txt_acompanhante.Size = new System.Drawing.Size(348, 21);
            this.txt_acompanhante.TabIndex = 1;
            // 
            // lbl_acompanhante
            // 
            this.lbl_acompanhante.AutoSize = true;
            this.lbl_acompanhante.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbl_acompanhante.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_acompanhante.Location = new System.Drawing.Point(0, 0);
            this.lbl_acompanhante.Name = "lbl_acompanhante";
            this.lbl_acompanhante.Size = new System.Drawing.Size(170, 16);
            this.lbl_acompanhante.TabIndex = 0;
            this.lbl_acompanhante.Text = "Nome do Acompanhante:";
            // 
            // pan_email
            // 
            this.pan_email.BackColor = System.Drawing.SystemColors.Window;
            this.pan_email.Controls.Add(this.txt_email);
            this.pan_email.Controls.Add(this.lbl_sufixoEmail);
            this.pan_email.Controls.Add(this.lbl_email);
            this.pan_email.Dock = System.Windows.Forms.DockStyle.Top;
            this.pan_email.Location = new System.Drawing.Point(0, 24);
            this.pan_email.Name = "pan_email";
            this.pan_email.Size = new System.Drawing.Size(516, 24);
            this.pan_email.TabIndex = 3;
            // 
            // txt_email
            // 
            this.txt_email.Dock = System.Windows.Forms.DockStyle.Right;
            this.txt_email.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_email.Location = new System.Drawing.Point(54, 0);
            this.txt_email.MaxLength = 86;
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(365, 21);
            this.txt_email.TabIndex = 1;
            // 
            // lbl_sufixoEmail
            // 
            this.lbl_sufixoEmail.AutoSize = true;
            this.lbl_sufixoEmail.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbl_sufixoEmail.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sufixoEmail.Location = new System.Drawing.Point(419, 0);
            this.lbl_sufixoEmail.Name = "lbl_sufixoEmail";
            this.lbl_sufixoEmail.Size = new System.Drawing.Size(97, 16);
            this.lbl_sufixoEmail.TabIndex = 2;
            this.lbl_sufixoEmail.Text = "@landix.com.br";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbl_email.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_email.Location = new System.Drawing.Point(0, 0);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(51, 16);
            this.lbl_email.TabIndex = 0;
            this.lbl_email.Text = "E-mail:";
            // 
            // pan_nome
            // 
            this.pan_nome.BackColor = System.Drawing.SystemColors.Window;
            this.pan_nome.Controls.Add(this.txt_nome);
            this.pan_nome.Controls.Add(this.lbl_nome);
            this.pan_nome.Dock = System.Windows.Forms.DockStyle.Top;
            this.pan_nome.Location = new System.Drawing.Point(0, 0);
            this.pan_nome.Name = "pan_nome";
            this.pan_nome.Size = new System.Drawing.Size(516, 24);
            this.pan_nome.TabIndex = 2;
            // 
            // txt_nome
            // 
            this.txt_nome.Dock = System.Windows.Forms.DockStyle.Right;
            this.txt_nome.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txt_nome.Location = new System.Drawing.Point(54, 0);
            this.txt_nome.MaxLength = 100;
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(462, 21);
            this.txt_nome.TabIndex = 1;
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbl_nome.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome.Location = new System.Drawing.Point(0, 0);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(48, 16);
            this.lbl_nome.TabIndex = 0;
            this.lbl_nome.Text = "Nome:";
            // 
            // pan_botoes
            // 
            this.pan_botoes.BackColor = System.Drawing.SystemColors.Window;
            this.pan_botoes.Controls.Add(this.btn_confirmar);
            this.pan_botoes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pan_botoes.Location = new System.Drawing.Point(0, 98);
            this.pan_botoes.Name = "pan_botoes";
            this.pan_botoes.Size = new System.Drawing.Size(516, 29);
            this.pan_botoes.TabIndex = 1;
            // 
            // btn_confirmar
            // 
            this.btn_confirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(158)))), ((int)(((byte)(217)))));
            this.btn_confirmar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_confirmar.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_confirmar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_confirmar.Location = new System.Drawing.Point(441, 0);
            this.btn_confirmar.Name = "btn_confirmar";
            this.btn_confirmar.Size = new System.Drawing.Size(75, 29);
            this.btn_confirmar.TabIndex = 1;
            this.btn_confirmar.Text = "Confirmar";
            this.btn_confirmar.UseVisualStyleBackColor = false;
            this.btn_confirmar.Click += new System.EventHandler(this.btn_confirmar_Click);
            // 
            // Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 127);
            this.Controls.Add(this.pan_botoes);
            this.Controls.Add(this.pan_principal);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Cadastro";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cadastro";
            this.pan_principal.ResumeLayout(false);
            this.pan_filhos.ResumeLayout(false);
            this.pan_filhos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.pan_acompanhante.ResumeLayout(false);
            this.pan_acompanhante.PerformLayout();
            this.pan_email.ResumeLayout(false);
            this.pan_email.PerformLayout();
            this.pan_nome.ResumeLayout(false);
            this.pan_nome.PerformLayout();
            this.pan_botoes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pan_principal;
        private System.Windows.Forms.Panel pan_filhos;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label lbl_filhos;
        private System.Windows.Forms.Panel pan_acompanhante;
        private System.Windows.Forms.TextBox txt_acompanhante;
        private System.Windows.Forms.Label lbl_acompanhante;
        private System.Windows.Forms.Panel pan_email;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Panel pan_nome;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Panel pan_botoes;
        private System.Windows.Forms.Button btn_confirmar;
        private System.Windows.Forms.Label lbl_sufixoEmail;
    }
}

