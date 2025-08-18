namespace AtividadeApp
{
    partial class frm3BimEx1
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
            this.lblPublico = new System.Windows.Forms.Label();
            this.lblRenda = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.txtPublico = new System.Windows.Forms.TextBox();
            this.txtRenda = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblPublico
            // 
            this.lblPublico.AutoSize = true;
            this.lblPublico.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPublico.Location = new System.Drawing.Point(132, 96);
            this.lblPublico.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPublico.Name = "lblPublico";
            this.lblPublico.Size = new System.Drawing.Size(132, 24);
            this.lblPublico.TabIndex = 0;
            this.lblPublico.Text = "Público Total";
            // 
            // lblRenda
            // 
            this.lblRenda.AutoSize = true;
            this.lblRenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRenda.Location = new System.Drawing.Point(132, 207);
            this.lblRenda.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRenda.Name = "lblRenda";
            this.lblRenda.Size = new System.Drawing.Size(123, 24);
            this.lblRenda.TabIndex = 1;
            this.lblRenda.Text = "Renda Total";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(100, 332);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(146, 37);
            this.btnCalcular.TabIndex = 2;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(352, 332);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(146, 37);
            this.btnLimpar.TabIndex = 3;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(594, 332);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(146, 37);
            this.btnVoltar.TabIndex = 4;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // txtPublico
            // 
            this.txtPublico.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPublico.Location = new System.Drawing.Point(342, 93);
            this.txtPublico.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPublico.Name = "txtPublico";
            this.txtPublico.Size = new System.Drawing.Size(372, 28);
            this.txtPublico.TabIndex = 5;
            // 
            // txtRenda
            // 
            this.txtRenda.Enabled = false;
            this.txtRenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRenda.Location = new System.Drawing.Point(342, 205);
            this.txtRenda.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtRenda.Name = "txtRenda";
            this.txtRenda.Size = new System.Drawing.Size(372, 28);
            this.txtRenda.TabIndex = 6;
            // 
            // frm3BimEx1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 408);
            this.ControlBox = false;
            this.Controls.Add(this.txtRenda);
            this.Controls.Add(this.txtPublico);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblRenda);
            this.Controls.Add(this.lblPublico);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frm3BimEx1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "_3BimEx1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPublico;
        private System.Windows.Forms.Label lblRenda;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.TextBox txtPublico;
        private System.Windows.Forms.TextBox txtRenda;
    }
}