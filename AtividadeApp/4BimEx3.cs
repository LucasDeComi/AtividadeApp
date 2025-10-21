using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtividadeApp
{
    public partial class frm4BimEx3 : Form
    {
        int i = -1;
        List<double> totalArea = new List<double>();
        public frm4BimEx3()
        {
            InitializeComponent();
        }

        private void btnCalcularWhile_Click(object sender, EventArgs e)
        {
            int qtde = Convert.ToInt32(txtQtde.Text);
            if(i == -1)
            {
                txtQtde.Enabled = false;
                txtLargura.Enabled = true;
                txtAltura.Enabled = true;
                btnCalcularDoWhile.Enabled = false;
                btnCalcularFor.Enabled = false;
                txtLargura.Focus();
                txtArea.Clear();
                i++;
            }
            else
            {
                double largura, altura, area;
                largura = Convert.ToDouble(txtLargura.Text);
                altura = Convert.ToDouble(txtAltura.Text);
                area = largura * altura;
                totalArea.Add(area);
                txtLargura.Clear();
                txtAltura.Clear();
                txtLargura.Focus();
                i++;
            }
            if (i == qtde)
            {
                double soma = 0;
                i = 0;
                while (i < totalArea.Count)
                {
                    soma += totalArea[i];
                    i++;
                }
                txtArea.Text = soma.ToString();
                i = -1;
                totalArea.Clear();
                txtQtde.Enabled = true;
                txtLargura.Enabled = false;
                txtAltura.Enabled = false;
                btnCalcularDoWhile.Enabled = true;
                btnCalcularFor.Enabled = true;
            }
        }

        private void btnCalcularDoWhile_Click(object sender, EventArgs e)
        {
            int qtde = Convert.ToInt32(txtQtde.Text);
            if (i == -1)
            {
                txtQtde.Enabled = false;
                txtLargura.Enabled = true;
                txtAltura.Enabled = true;
                btnCalcularWhile.Enabled = false;
                btnCalcularFor.Enabled = false;
                txtLargura.Focus();
                txtArea.Clear();
                i++;
            }
            else
            {
                double largura, altura, area;
                largura = Convert.ToDouble(txtLargura.Text);
                altura = Convert.ToDouble(txtAltura.Text);
                area = largura * altura;
                totalArea.Add(area);
                txtLargura.Clear();
                txtAltura.Clear();
                txtLargura.Focus();
                i++;
            }
            if (i == qtde)
            {
                double soma = 0;
                i = 0;
                do
                {
                    soma += totalArea[i];
                    i++;
                } while (i < totalArea.Count);
                txtArea.Text = soma.ToString();
                i = -1;
                totalArea.Clear();
                txtQtde.Enabled = true;
                txtLargura.Enabled = false;
                txtAltura.Enabled = false;
                btnCalcularWhile.Enabled = true;
                btnCalcularFor.Enabled = true;
            }
        }

        private void btnCalcularFor_Click(object sender, EventArgs e)
        {
            int qtde = Convert.ToInt32(txtQtde.Text);
            if (i == -1)
            {
                txtQtde.Enabled = false;
                txtLargura.Enabled = true;
                txtAltura.Enabled = true;
                btnCalcularWhile.Enabled = false;
                btnCalcularDoWhile.Enabled = false;
                txtLargura.Focus();
                txtArea.Clear();
                i++;
            }
            else
            {
                double largura, altura, area;
                largura = Convert.ToDouble(txtLargura.Text);
                altura = Convert.ToDouble(txtAltura.Text);
                area = largura * altura;
                totalArea.Add(area);
                txtLargura.Clear();
                txtAltura.Clear();
                txtLargura.Focus();
                i++;
            }
            if (i == qtde)
            {
                double soma = 0;
                for (i = 0; i < totalArea.Count; i++)
                    soma += totalArea[i];
                txtArea.Text = soma.ToString();
                i = -1;
                totalArea.Clear();
                txtQtde.Enabled = true;
                txtLargura.Enabled = false;
                txtAltura.Enabled = false;
                btnCalcularWhile.Enabled = true;
                btnCalcularDoWhile.Enabled = true;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtLargura.Clear();
            txtAltura.Clear();
            if (i == -1)
            {
                txtQtde.Clear();
                txtArea.Clear();
                txtQtde.Focus();
            }
            else
                txtLargura.Focus();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenu menu = new frmMenu();
            Hide();
            menu.Show();
        }
    }
}
