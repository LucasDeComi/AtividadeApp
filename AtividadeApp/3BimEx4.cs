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
    public partial class frm3BimEx4 : Form
    {
        public frm3BimEx4()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int codigo = int.Parse(txtCodigo.Text);
            switch(codigo)
            {
                case 100:
                    txtNome.Text = "Cachorro Quente";
                    txtPreco.Text = "25,00";
                    break;
                case 101:
                    txtNome.Text = "Bauru";
                    txtPreco.Text = "15,00";
                    break;
                case 102:
                    txtNome.Text = "X-Burguer";
                    txtPreco.Text = "35,00";
                    break;
                case 103:
                    txtNome.Text = "Triplo X-Burguer";
                    txtPreco.Text = "47,00";
                    break;
                default:
                    txtNome.Text = "Lanche Inexistente";
                    txtPreco.Text = "Lanches: 100, 101, 102, 103";
                    break;
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenu menu = new frmMenu();
            Hide();
            menu.Show();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCodigo.Clear();
            txtNome.Clear();
            txtPreco.Clear();
            txtCodigo.Focus();
        }
    }
}
