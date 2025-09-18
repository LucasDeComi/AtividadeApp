using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtividadeApp
{
    public partial class frm3BimProva1 : Form
    {
        public frm3BimProva1()
        {
            InitializeComponent();
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            frmMenu menu = new frmMenu();
            Hide();
            menu.Show();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int id;
            double nota1, nota2, nota3, ME, MA;
            string conceito, situacao;
            id = int.Parse(txtId.Text);
            nota1 = Convert.ToDouble(txtNota1.Text);
            nota2 = Convert.ToDouble(txtNota2.Text);
            nota3 = Convert.ToDouble(txtNota3.Text);
            ME = Convert.ToDouble(txtME.Text);
            MA = (nota1 + nota2 * 2 + nota3 * 3 + ME) / 7;
            conceito = "";
            situacao = "";
            if(MA >= 9)
            {
                conceito = "A";
                situacao = "Aprovado";
            }
            else if(MA >= 7.5)
            {
                conceito = "B";
                situacao = "Aprovado";
            }
            else if(MA >= 6)
            {
                conceito = "C";
                situacao = "Aprovado";
            }
            else if(MA >= 4)
            {
                conceito = "D";
                situacao = "Reprovado";
            }
            else
            {
                conceito = "E";
                situacao = "Reprovado";
            }
            txtId.Text = id.ToString();
            txtNota1.Text = nota1.ToString();
            txtNota2.Text = nota2.ToString();
            txtNota3.Text = nota3.ToString();
            txtME.Text = ME.ToString();
            txtMA.Text = MA.ToString();
            txtConceito.Text = conceito;
            txtSituacao.Text = situacao;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtId.Clear();
            txtNota1.Clear();
            txtNota2.Clear();
            txtNota3.Clear();
            txtME.Clear();
            txtMA.Clear();
            txtConceito.Clear();
            txtSituacao.Clear();
            txtId.Focus();
        }
    }
}
