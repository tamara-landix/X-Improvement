namespace ListaPresenca.Visao
{
    partial class Confirmados
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
            this.dgv_confirmados = new System.Windows.Forms.DataGridView();
            this.pan_botoes = new System.Windows.Forms.Panel();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.btn_alterar = new System.Windows.Forms.Button();
            this.pan_principal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_confirmados)).BeginInit();
            this.pan_botoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // pan_principal
            // 
            this.pan_principal.BackColor = System.Drawing.SystemColors.Window;
            this.pan_principal.Controls.Add(this.dgv_confirmados);
            this.pan_principal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pan_principal.Location = new System.Drawing.Point(0, 0);
            this.pan_principal.Name = "pan_principal";
            this.pan_principal.Size = new System.Drawing.Size(654, 311);
            this.pan_principal.TabIndex = 0;
            // 
            // dgv_confirmados
            // 
            this.dgv_confirmados.AllowUserToAddRows = false;
            this.dgv_confirmados.AllowUserToDeleteRows = false;
            this.dgv_confirmados.AllowUserToResizeRows = false;
            this.dgv_confirmados.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgv_confirmados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_confirmados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_confirmados.Location = new System.Drawing.Point(0, 0);
            this.dgv_confirmados.Name = "dgv_confirmados";
            this.dgv_confirmados.ReadOnly = true;
            this.dgv_confirmados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_confirmados.Size = new System.Drawing.Size(654, 311);
            this.dgv_confirmados.TabIndex = 0;
            // 
            // pan_botoes
            // 
            this.pan_botoes.BackColor = System.Drawing.SystemColors.Window;
            this.pan_botoes.Controls.Add(this.btn_excluir);
            this.pan_botoes.Controls.Add(this.btn_alterar);
            this.pan_botoes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pan_botoes.Location = new System.Drawing.Point(0, 282);
            this.pan_botoes.Name = "pan_botoes";
            this.pan_botoes.Size = new System.Drawing.Size(654, 29);
            this.pan_botoes.TabIndex = 2;
            // 
            // btn_excluir
            // 
            this.btn_excluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(158)))), ((int)(((byte)(217)))));
            this.btn_excluir.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_excluir.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_excluir.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_excluir.Location = new System.Drawing.Point(75, 0);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(75, 29);
            this.btn_excluir.TabIndex = 1;
            this.btn_excluir.Text = "Excluir";
            this.btn_excluir.UseVisualStyleBackColor = false;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // btn_alterar
            // 
            this.btn_alterar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(158)))), ((int)(((byte)(217)))));
            this.btn_alterar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_alterar.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_alterar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_alterar.Location = new System.Drawing.Point(0, 0);
            this.btn_alterar.Name = "btn_alterar";
            this.btn_alterar.Size = new System.Drawing.Size(75, 29);
            this.btn_alterar.TabIndex = 2;
            this.btn_alterar.Text = "Alterar";
            this.btn_alterar.UseVisualStyleBackColor = false;
            this.btn_alterar.Click += new System.EventHandler(this.btn_alterar_Click);
            // 
            // Confirmados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 311);
            this.Controls.Add(this.pan_botoes);
            this.Controls.Add(this.pan_principal);
            this.Name = "Confirmados";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Confirmados";
            this.pan_principal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_confirmados)).EndInit();
            this.pan_botoes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pan_principal;
        private System.Windows.Forms.DataGridView dgv_confirmados;
        private System.Windows.Forms.Panel pan_botoes;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Button btn_alterar;
    }
}