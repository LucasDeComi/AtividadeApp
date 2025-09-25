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
    public partial class frm3BimProva2 : Form
    {
        public frm3BimProva2()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int cod;
            double preco, total, desconto;
            string msg;
            cod = Convert.ToInt32(txtCod.Text);
            preco = Convert.ToDouble(txtPreco.Text);
            switch(cod)
            {
                case 1:
                    desconto = 5 / 100.0;
                    break;
                case 2:
                    desconto = 15 / 100.0;
                    break;
                case 3:
                    desconto = 7 / 100.0;
                    break;
                case 4:
                    desconto = 12 / 100.0;
                    break;
                case 5:
                    desconto = 20 / 100.0;
                    break;
                default:
                    desconto = 0;
                    msg = "Produto importado. Sem desconto";
                    txtMsg.Text = msg;
                    break;
            }
            total = preco * desconto;
            txtTotal.Text = total.ToString();
            Console.WriteLine(desconto);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCod.Clear();
            txtMsg.Clear();
            txtPreco.Clear();
            txtTotal.Clear();
            txtCod.Focus();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenu menu = new frmMenu();
            Hide();
            menu.Show();
        }
    }
}
