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
            this.lblCelsius.Location = new System.Drawing.Point(198, 29);
            this.lblCelsius.Name = "lblCelsius";
            this.lblCelsius.Size = new System.Drawing.Size(31, 24);
            this.lblCelsius.TabIndex = 0;
            this.lblCelsius.Text = "°C";
            // 
            // lblFahrenheit
            // 
            this.lblFahrenheit.AutoSize = true;
            this.lblFahrenheit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFahrenheit.Location = new System.Drawing.Point(328, 29);
            this.lblFahrenheit.Name = "lblFahrenheit";
            this.lblFahrenheit.Size = new System.Drawing.Size(30, 24);
            this.lblFahrenheit.TabIndex = 1;
            this.lblFahrenheit.Text = "°F";
            // 
            // txtC
            // 
            this.txtC.Enabled = false;
            this.txtC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtC.Location = new System.Drawing.Point(185, 70);
            this.txtC.Multiline = true;
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(69, 293);
            this.txtC.TabIndex = 1;
            this.txtC.TabStop = false;
            // 
            // txtF
            // 
            this.txtF.Enabled = false;
            this.txtF.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtF.Location = new System.Drawing.Point(310, 70);
            this.txtF.Multiline = true;
            this.txtF.Name = "txtF";
            this.txtF.Size = new System.Drawing.Size(69, 293);
            this.txtF.TabIndex = 12;
            // 
            // btnCalcularWhile
            // 
            this.btnCalcularWhile.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcularWhile.Location = new System.Drawing.Point(478, 89);
            this.btnCalcularWhile.Name = "btnCalcularWhile";
            this.btnCalcularWhile.Size = new System.Drawing.Size(213, 40);
            this.btnCalcularWhile.TabIndex = 22;
            this.btnCalcularWhile.Text = "Calcular (while)";
            this.btnCalcularWhile.UseVisualStyleBackColor = true;
            this.btnCalcularWhile.Click += new System.EventHandler(this.btnCalcularWhile_Click);
            // 
            // btnCalcularDoWhile
            // 
            this.btnCalcularDoWhile.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcularDoWhile.Location = new System.Drawing.Point(478, 146);
            this.btnCalcularDoWhile.Name = "btnCalcularDoWhile";
            this.btnCalcularDoWhile.Size = new System.Drawing.Size(213, 40);
            this.btnCalcularDoWhile.TabIndex = 23;
            this.btnCalcularDoWhile.Text = "Calcular (do... while)";
            this.btnCalcularDoWhile.UseVisualStyleBackColor = true;
            // 
            // btnCalcularFor
            // 
            this.btnCalcularFor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcularFor.Location = new System.Drawing.Point(478, 205);
            this.btnCalcularFor.Name = "btnCalcularFor";
            this.btnCalcularFor.Size = new System.Drawing.Size(213, 40);
            this.btnCalcularFor.TabIndex = 24;
            this.btnCalcularFor.Text = "Calcular (for)";
            this.btnCalcularFor.UseVisualStyleBackColor = true;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(478, 265);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(213, 40);
            this.btnLimpar.TabIndex = 25;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(478, 323);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(213, 40);
            this.btnVoltar.TabIndex = 26;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            // 
            // frm4BimEx2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Name = "frm4BimEx2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exercício 2";
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