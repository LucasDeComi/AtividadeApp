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
    public partial class frm3BimEx2 : Form
    {
        public frm3BimEx2()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int livros, valor;
            livros = int.Parse(txtLivros.Text);
            if (livros > 10)
                valor = livros * 8;
            else
                valor = livros * 12;
            txtTotal.Text = valor.ToString();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtLivros.Clear();
            txtTotal.Clear();
            txtLivros.Focus();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenu menu = new frmMenu();
            Hide();
            menu.Show();
        }
    }
}
