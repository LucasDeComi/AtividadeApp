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
    public partial class frmVetorMatrizEx3 : Form
    {
        double[] B = new double[30];
        public frmVetorMatrizEx3()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string[] entrada = txtA.Lines;
            double[] A = new double[30];
            if (entrada.Length < 30)
            {
                MessageBox.Show("Por favor, insira 30 números.");
                txtA.Focus();
                return;
            }
            txtA.Clear();
            txtB.Clear();
            txtPesquisar.Enabled = true;
            for(int i = 0; i < 30; i++)
            {
                A[i] = Convert.ToDouble(entrada[i]);
                B[i] = Math.Pow(A[i], 3);
                txtA.Text += A[i].ToString() + Environment.NewLine;
                txtB.Text += B[i].ToString() + Environment.NewLine;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtA.Clear();
            txtB.Clear();
            txtPesquisar.Clear();
            txtPesquisar.Enabled = false;
            txtA.Focus();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenu menu = new frmMenu();
            Hide();
            menu.Show();
        }

        private void txtA_TextChanged(object sender, EventArgs e)
        {
            string[] entrada = txtA.Lines;
            int qtde = 0;
            for (int i = 0; i < entrada.Length; i++)
            {
                if (double.TryParse(entrada[i], out double valor))
                {
                    qtde++;
                }
            }
            txtQtde.Text = qtde.ToString();
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            string pesquisa = txtPesquisar.Text;
            txtB.Clear();
            for (int i = 0; i < 30; i++)
            {
                if (B[i].ToString().Contains(pesquisa))
                {
                    txtB.Text += B[i].ToString() + Environment.NewLine;
                }
            }
        }
    }
}
