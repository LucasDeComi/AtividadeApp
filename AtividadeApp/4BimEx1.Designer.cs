namespace AtividadeApp
{
    partial class frm4BimEx1
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
            this.lblNum = new System.Windows.Forms.Label();
            this.lblTabuada = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.txtTabuada = new System.Windows.Forms.TextBox();
            this.btnCalcularDoWhile = new System.Windows.Forms.Button();
            this.btnCalcularWhile = new System.Windows.Forms.Button();
            this.btnCalcularFor = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum.Location = new System.Drawing.Point(105, 96);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(156, 24);
            this.lblNum.TabIndex = 0;
            this.lblNum.Text = "Número (1 a 9):";
            // 
            // lblTabuada
            // 
            this.lblTabuada.AutoSize = true;
            this.lblTabuada.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTabuada.Location = new System.Drawing.Point(105, 160);
            this.lblTabuada.Name = "lblTabuada";
            this.lblTabuada.Size = new System.Drawing.Size(98, 24);
            this.lblTabuada.TabIndex = 1;
            this.lblTabuada.Text = "Tabuada:";
            // 
            // txtNum
            // 
            this.txtNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNum.Location = new System.Drawing.Point(274, 93);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(340, 29);
            this.txtNum.TabIndex = 2;
            // 
            // txtTabuada
            // 
            this.txtTabuada.Enabled = false;
            this.txtTabuada.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTabuada.Location = new System.Drawing.Point(274, 157);
            this.txtTabuada.Name = "txtTabuada";
            this.txtTabuada.Size = new System.Drawing.Size(340, 29);
            this.txtTabuada.TabIndex = 3;
            // 
            // btnCalcularDoWhile
            // 
            this.btnCalcularDoWhile.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcularDoWhile.Location = new System.Drawing.Point(77, 326);
            this.btnCalcularDoWhile.Name = "btnCalcularDoWhile";
            this.btnCalcularDoWhile.Size = new System.Drawing.Size(216, 39);
            this.btnCalcularDoWhile.TabIndex = 4;
            this.btnCalcularDoWhile.Text = "Calcular (do... while)";
            this.btnCalcularDoWhile.UseVisualStyleBackColor = true;
            this.btnCalcularDoWhile.Click += new System.EventHandler(this.btnCalcularDoWhile_Click);
            // 
            // btnCalcularWhile
            // 
            this.btnCalcularWhile.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcularWhile.Location = new System.Drawing.Point(77, 272);
            this.btnCalcularWhile.Name = "btnCalcularWhile";
            this.btnCalcularWhile.Size = new System.Drawing.Size(216, 39);
            this.btnCalcularWhile.TabIndex = 5;
            this.btnCalcularWhile.Text = "Calcular (while)";
            this.btnCalcularWhile.UseVisualStyleBackColor = true;
            this.btnCalcularWhile.Click += new System.EventHandler(this.btnCalcularWhile_Click);
            // 
            // btnCalcularFor
            // 
            this.btnCalcularFor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcularFor.Location = new System.Drawing.Point(77, 382);
            this.btnCalcularFor.Name = "btnCalcularFor";
            this.btnCalcularFor.Size = new System.Drawing.Size(216, 39);
            this.btnCalcularFor.TabIndex = 6;
            this.btnCalcularFor.Text = "Calcular (for)";
            this.btnCalcularFor.UseVisualStyleBackColor = true;
            this.btnCalcularFor.Click += new System.EventHandler(this.btnCalcularFor_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(357, 326);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(113, 39);
            this.btnLimpar.TabIndex = 7;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(548, 326);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(100, 39);
            this.btnVoltar.TabIndex = 8;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // frm4BimEx1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCalcularFor);
            this.Controls.Add(this.btnCalcularWhile);
            this.Controls.Add(this.btnCalcularDoWhile);
            this.Controls.Add(this.txtTabuada);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.lblTabuada);
            this.Controls.Add(this.lblNum);
            this.Name = "frm4BimEx1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exercício 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.Label lblTabuada;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.TextBox txtTabuada;
        private System.Windows.Forms.Button btnCalcularDoWhile;
        private System.Windows.Forms.Button btnCalcularWhile;
        private System.Windows.Forms.Button btnCalcularFor;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnVoltar;
    }
}