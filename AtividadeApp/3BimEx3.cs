using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtividadeApp
{
    public partial class frm3BimEx3 : Form
    {
        public frm3BimEx3()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string nome;
            int idade;
            char sexo;
            double salario, renda;
            nome = txtNome.Text;
            idade = int.Parse(txtIdade.Text);
            sexo = txtSexo.Text[0];
            salario = Convert.ToDouble(txtSalario.Text);
            renda = 0;
            if (sexo == 'M' || sexo == 'm')
            {
                if (idade >= 30)
                    renda = salario + 100;
                else
                    renda = salario + 50;
            }
            else if (sexo == 'F' || sexo == 'f')
            {
                if (idade >= 30)
                    renda = salario + 250;
                else
                    renda = salario + 150;
            }
            if (renda != 0)
                txtRenda.Text = nome + ", você recebe R$" + renda.ToString();
            else
                txtRenda.Text = "Erro de digitação em sexo (M/F).";
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenu menu = new frmMenu();
            Hide();
            menu.Show();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtIdade.Clear();
            txtSexo.Clear();
            txtSalario.Clear();
            txtRenda.Clear();
            txtNome.Focus();
        }
    }
}
