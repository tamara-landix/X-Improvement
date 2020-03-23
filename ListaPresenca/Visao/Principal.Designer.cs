namespace ListaPresenca.Visao
{
    partial class Principal
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
            this.btn_lista = new System.Windows.Forms.Button();
            this.btn_confirmarPresenca = new System.Windows.Forms.Button();
            this.lbl_inicial = new System.Windows.Forms.Label();
            this.pan_principal.SuspendLayout();
            this.SuspendLayout();
            // 
            // pan_principal
            // 
            this.pan_principal.BackColor = System.Drawing.Color.SkyBlue;
            this.pan_principal.Controls.Add(this.btn_lista);
            this.pan_principal.Controls.Add(this.btn_confirmarPresenca);
            this.pan_principal.Controls.Add(this.lbl_inicial);
            this.pan_principal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pan_principal.Location = new System.Drawing.Point(0, 0);
            this.pan_principal.Name = "pan_principal";
            this.pan_principal.Size = new System.Drawing.Size(609, 280);
            this.pan_principal.TabIndex = 0;
            // 
            // btn_lista
            // 
            this.btn_lista.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_lista.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_lista.Location = new System.Drawing.Point(305, 107);
            this.btn_lista.Name = "btn_lista";
            this.btn_lista.Size = new System.Drawing.Size(304, 173);
            this.btn_lista.TabIndex = 2;
            this.btn_lista.Text = "Visualizar Confirmados";
            this.btn_lista.UseVisualStyleBackColor = true;
            this.btn_lista.Click += new System.EventHandler(this.btn_lista_Click);
            // 
            // btn_confirmarPresenca
            // 
            this.btn_confirmarPresenca.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_confirmarPresenca.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_confirmarPresenca.Location = new System.Drawing.Point(0, 107);
            this.btn_confirmarPresenca.Name = "btn_confirmarPresenca";
            this.btn_confirmarPresenca.Size = new System.Drawing.Size(304, 173);
            this.btn_confirmarPresenca.TabIndex = 1;
            this.btn_confirmarPresenca.Text = "Confirmar Presença";
            this.btn_confirmarPresenca.UseVisualStyleBackColor = true;
            this.btn_confirmarPresenca.Click += new System.EventHandler(this.btn_confirmarPresenca_Click);
            // 
            // lbl_inicial
            // 
            this.lbl_inicial.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_inicial.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_inicial.Location = new System.Drawing.Point(0, 0);
            this.lbl_inicial.Name = "lbl_inicial";
            this.lbl_inicial.Size = new System.Drawing.Size(609, 107);
            this.lbl_inicial.TabIndex = 0;
            this.lbl_inicial.Text = "Olá!\r\nTem festa chegando \\o/";
            this.lbl_inicial.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 280);
            this.Controls.Add(this.pan_principal);
            this.Name = "Principal";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Landix 21 Anos";
            this.pan_principal.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pan_principal;
        private System.Windows.Forms.Button btn_lista;
        private System.Windows.Forms.Button btn_confirmarPresenca;
        private System.Windows.Forms.Label lbl_inicial;
    }
}