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
    public partial class frmVetorMatrizEx1 : Form
    {
        public frmVetorMatrizEx1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string[] entrada = txtA.Lines;
            double[] A = new double[15]; 
            double[] B = new double[15];
            if(entrada.Length < 15)
            {
                MessageBox.Show("Por favor, insira 15 números.");
                txtA.Focus();
                return;
            }
            txtA.Clear();
            txtB.Clear();
            for (int i = 0; i < 15; i++)
            {
                A[i] = Convert.ToDouble(entrada[i]);
                B[i] = Math.Pow(A[i], 2);
                txtA.Text += A[i].ToString() + Environment.NewLine;
                txtB.Text += B[i].ToString() + Environment.NewLine;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtA.Clear();
            txtB.Clear();
            txtA.Focus();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenu menu = new frmMenu();
            Hide();
            menu.Show();
        }
    }
}
