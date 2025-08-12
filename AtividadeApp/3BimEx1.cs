using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace AtividadeApp
{
    public partial class frm3BimEx1 : Form
    {
        public frm3BimEx1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double publico, popular, geral, arquibancada, cadeira, rdp, rdg, rda, rdc, rendaTotal;
            publico = Convert.ToDouble(txtPublico.Text);
            popular = publico * 0.1;
            geral = publico * 0.5;
            arquibancada = publico * 0.3;
            cadeira = publico * 0.1;
            rendaTotal = 0;
            if (popular > 0)
            {
                rdp = popular * 5;
                rendaTotal += rdp;
            }
            if (geral > 0)
            {
                rdg = geral * 10;
                rendaTotal += rdg;
            }
            if (arquibancada > 0)
            {
                rda = arquibancada * 20;
                rendaTotal += rda;
            }
            if (cadeira > 0)
            {
                rdc = cadeira * 30;
                rendaTotal += rdc;
            }
            txtRenda.Text = rendaTotal.ToString();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtPublico.Clear();
            txtRenda.Clear();
            txtPublico.Focus();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenu menu = new frmMenu();
            Hide();
            menu.Show();
        }
    }
}
