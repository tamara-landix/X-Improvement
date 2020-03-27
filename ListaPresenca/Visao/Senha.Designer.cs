namespace Visao
{
    partial class Senha
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pan_principal = new System.Windows.Forms.Panel();
            this.btn_acessar = new System.Windows.Forms.Button();
            this.txt_senha = new System.Windows.Forms.TextBox();
            this.lbl_restricao = new System.Windows.Forms.Label();
            this.pan_principal.SuspendLayout();
            this.SuspendLayout();
            // 
            // pan_principal
            // 
            this.pan_principal.BackColor = System.Drawing.Color.SkyBlue;
            this.pan_principal.Controls.Add(this.btn_acessar);
            this.pan_principal.Controls.Add(this.txt_senha);
            this.pan_principal.Controls.Add(this.lbl_restricao);
            this.pan_principal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pan_principal.Location = new System.Drawing.Point(0, 0);
            this.pan_principal.Name = "pan_principal";
            this.pan_principal.Size = new System.Drawing.Size(348, 132);
            this.pan_principal.TabIndex = 0;
            // 
            // btn_acessar
            // 
            this.btn_acessar.Location = new System.Drawing.Point(129, 104);
            this.btn_acessar.Name = "btn_acessar";
            this.btn_acessar.Size = new System.Drawing.Size(75, 23);
            this.btn_acessar.TabIndex = 2;
            this.btn_acessar.Text = "Acessar";
            this.btn_acessar.UseVisualStyleBackColor = true;
            this.btn_acessar.Click += new System.EventHandler(this.btn_acessar_Click);
            // 
            // txt_senha
            // 
            this.txt_senha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_senha.Location = new System.Drawing.Point(87, 78);
            this.txt_senha.Name = "txt_senha";
            this.txt_senha.PasswordChar = '*';
            this.txt_senha.Size = new System.Drawing.Size(162, 20);
            this.txt_senha.TabIndex = 1;
            this.txt_senha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_senha_KeyDown);
            // 
            // lbl_restricao
            // 
            this.lbl_restricao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_restricao.AutoSize = true;
            this.lbl_restricao.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_restricao.Location = new System.Drawing.Point(24, 18);
            this.lbl_restricao.Name = "lbl_restricao";
            this.lbl_restricao.Size = new System.Drawing.Size(284, 57);
            this.lbl_restricao.TabIndex = 0;
            this.lbl_restricao.Text = "ATENÇÃO!\r\nFuncionalidade restrita à equipe Gente.\r\nDigite a senha para acessar:";
            this.lbl_restricao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Senha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 132);
            this.Controls.Add(this.pan_principal);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Senha";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Senha";
            this.pan_principal.ResumeLayout(false);
            this.pan_principal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pan_principal;
        private System.Windows.Forms.Button btn_acessar;
        private System.Windows.Forms.TextBox txt_senha;
        private System.Windows.Forms.Label lbl_restricao;
    }
}