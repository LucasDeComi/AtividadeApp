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
    public partial class frm4BimEx1 : Form
    {
        public frm4BimEx1()
        {
            InitializeComponent();
        }

        private void btnCalcularWhile_Click(object sender, EventArgs e)
        {
            int num, produto = 0, i = 1;
            string tabuada = "";
            num = Convert.ToInt32(txtNum.Text);
            if (num < 10 && num > 0)
            {
                while(i <= 10)
                {
                    produto += num;
                    tabuada += num.ToString() + " X " + i.ToString() + " = " + produto.ToString() + Environment.NewLine;
                    i++;
                }
                txtTabuada.Text = tabuada;
            }
            else
            {
                MessageBox.Show("O programa lê apenas números de 1 a 9");
                txtNum.Clear();
                txtNum.Focus();
            }
        }

        private void btnCalcularDoWhile_Click(object sender, EventArgs e)
        {
            int num, produto = 0, i = 1;
            string tabuada = "";
            num = Convert.ToInt32(txtNum.Text);
            if (num < 10 && num > 0)
            {
                do
                {
                    produto += num;
                    tabuada += num.ToString() + " X " + i.ToString() + " = " + produto.ToString() + Environment.NewLine;
                    i++;
                } while(i <= 10);
                txtTabuada.Text = tabuada;
            }
            else
            {
                MessageBox.Show("O programa lê apenas números de 1 a 9");
                txtNum.Clear();
                txtNum.Focus();
            }
        }

        private void btnCalcularFor_Click(object sender, EventArgs e)
        {
            int num, produto = 0;
            string tabuada = "";
            num = Convert.ToInt32(txtNum.Text);
            if (num < 10 && num > 0)
            {
                for(int i = 1; i <= 10; i++)
                {
                    produto += num;
                    tabuada += num.ToString() + " X " + i.ToString() + " = " + produto.ToString() + Environment.NewLine;
                }
                txtTabuada.Text = tabuada;
            }
            else
            {
                MessageBox.Show("O programa lê apenas números de 1 a 9");
                txtNum.Clear();
                txtNum.Focus();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNum.Clear();
            txtTabuada.Clear();
            txtNum.Focus();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenu menu = new frmMenu();
            Hide();
            menu.Show();
        }
    }
}
