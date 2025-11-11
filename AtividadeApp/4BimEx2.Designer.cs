namespace AtividadeApp
{
    partial class frm4BimEx2
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
            this.lblCelsius = new System.Windows.Forms.Label();
            this.lblFahrenheit = new System.Windows.Forms.Label();
            this.txtC = new System.Windows.Forms.TextBox();
            this.txtF = new System.Windows.Forms.TextBox();
            this.btnCalcularWhile = new System.Windows.Forms.Button();
            this.btnCalcularDoWhile = new System.Windows.Forms.Button();
            this.btnCalcularFor = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCelsius
            // 
            this.lblCelsius.AutoSize = true;
            this.lblCelsius.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCelsius.Location = new System.Drawing.Point(264, 36);
            this.lblCelsius.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCelsius.Name = "lblCelsius";
            this.lblCelsius.Size = new System.Drawing.Size(40, 29);
            this.lblCelsius.TabIndex = 0;
            this.lblCelsius.Text = "°C";
            // 
            // lblFahrenheit
            // 
            this.lblFahrenheit.AutoSize = true;
            this.lblFahrenheit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFahrenheit.Location = new System.Drawing.Point(437, 36);
            this.lblFahrenheit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFahrenheit.Name = "lblFahrenheit";
            this.lblFahrenheit.Size = new System.Drawing.Size(38, 29);
            this.lblFahrenheit.TabIndex = 1;
            this.lblFahrenheit.Text = "°F";
            // 
            // txtC
            // 
            this.txtC.Enabled = false;
            this.txtC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtC.Location = new System.Drawing.Point(251, 86);
            this.txtC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtC.Multiline = true;
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(75, 360);
            this.txtC.TabIndex = 1;
            this.txtC.TabStop = false;
            // 
            // txtF
            // 
            this.txtF.Enabled = false;
            this.txtF.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtF.Location = new System.Drawing.Point(421, 86);
            this.txtF.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtF.Multiline = true;
            this.txtF.Name = "txtF";
            this.txtF.Size = new System.Drawing.Size(79, 360);
            this.txtF.TabIndex = 12;
            // 
            // btnCalcularWhile
            // 
            this.btnCalcularWhile.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcularWhile.Location = new System.Drawing.Point(637, 110);
            this.btnCalcularWhile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCalcularWhile.Name = "btnCalcularWhile";
            this.btnCalcularWhile.Size = new System.Drawing.Size(284, 49);
            this.btnCalcularWhile.TabIndex = 22;
            this.btnCalcularWhile.Text = "Calcular (while)";
            this.btnCalcularWhile.UseVisualStyleBackColor = true;
            this.btnCalcularWhile.Click += new System.EventHandler(this.btnCalcularWhile_Click);
            // 
            // btnCalcularDoWhile
            // 
            this.btnCalcularDoWhile.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcularDoWhile.Location = new System.Drawing.Point(637, 180);
            this.btnCalcularDoWhile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCalcularDoWhile.Name = "btnCalcularDoWhile";
            this.btnCalcularDoWhile.Size = new System.Drawing.Size(284, 49);
            this.btnCalcularDoWhile.TabIndex = 23;
            this.btnCalcularDoWhile.Text = "Calcular (do... while)";
            this.btnCalcularDoWhile.UseVisualStyleBackColor = true;
            this.btnCalcularDoWhile.Click += new System.EventHandler(this.btnCalcularDoWhile_Click);
            // 
            // btnCalcularFor
            // 
            this.btnCalcularFor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcularFor.Location = new System.Drawing.Point(637, 252);
            this.btnCalcularFor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCalcularFor.Name = "btnCalcularFor";
            this.btnCalcularFor.Size = new System.Drawing.Size(284, 49);
            this.btnCalcularFor.TabIndex = 24;
            this.btnCalcularFor.Text = "Calcular (for)";
            this.btnCalcularFor.UseVisualStyleBackColor = true;
            this.btnCalcularFor.Click += new System.EventHandler(this.btnCalcularFor_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(637, 326);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(284, 49);
            this.btnLimpar.TabIndex = 25;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(637, 398);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(284, 49);
            this.btnVoltar.TabIndex = 26;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            // 
            // frm4BimEx2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.ControlBox = false;
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCalcularFor);
            this.Controls.Add(this.btnCalcularDoWhile);
            this.Controls.Add(this.btnCalcularWhile);
            this.Controls.Add(this.txtF);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.lblFahrenheit);
            this.Controls.Add(this.lblCelsius);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frm4BimEx2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Looping - Exercício 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCelsius;
        private System.Windows.Forms.Label lblFahrenheit;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.TextBox txtF;
        private System.Windows.Forms.Button btnCalcularWhile;
        private System.Windows.Forms.Button btnCalcularDoWhile;
        private System.Windows.Forms.Button btnCalcularFor;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnVoltar;
    }
}