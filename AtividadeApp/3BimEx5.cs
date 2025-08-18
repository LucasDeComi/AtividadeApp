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
    public partial class frm3BimEx5 : Form
    {
        public frm3BimEx5()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double altura, peso, imc;
            altura = Convert.ToDouble(txtAltura.Text);
            peso = Convert.ToDouble(txtPeso.Text);
            imc = peso / Math.Pow(altura, 2);
            txtImc.Text = imc.ToString();
            if(imc < 17)
            {
                txtClassificacao.Text = "Magreza Severa";
            }
            else if (imc < 18.5)
            {
                txtClassificacao.Text = "Magreza Leve";
            }
            else if (imc < 25)
            {
                txtClassificacao.Text = "Peso Normal";
            }
            else if (imc < 30)
            {
                txtClassificacao.Text = "Sobrepeso";
            }
            else if (imc < 35)
            {
                txtClassificacao.Text = "Obesidade Classe I";
            }
            else if (imc < 40)
            {
                txtClassificacao.Text = "Obesidade Classe II";
            }
            else
            {
                txtClassificacao.Text = "Obesidade Classe III";
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtAltura.Clear();
            txtPeso.Clear();
            txtImc.Clear();
            txtClassificacao.Clear();
            txtAltura.Focus();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenu frmMenu = new frmMenu();
            Hide();
            frmMenu.Show();
        }
    }
}
