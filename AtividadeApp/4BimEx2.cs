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
    public partial class frm4BimEx2 : Form
    {
        public frm4BimEx2()
        {
            InitializeComponent();
        }

        private void btnCalcularWhile_Click(object sender, EventArgs e)
        {
            int i = 10;
            double F;
            while(i <= 100)
            {
                F = (i * 1.8) + 32;
                txtC.Text += String.Format("\n" + i.ToString());
                txtF.Text += String.Format("\n" + F.ToString());
                i += 10;
            }
        }

        private void btnCalcularDoWhile_Click(object sender, EventArgs e)
        {
            int i = 10;
            double F;
            do
            {
                F = (i * 1.8) + 32;
                txtC.Text += String.Format("\n" + i.ToString());
                txtF.Text += String.Format("\n" + F.ToString());
                i += 10;
            } while(i <= 100);
        }

        private void btnCalcularFor_Click(object sender, EventArgs e)
        {
            double F;
            for(int i = 10; i <= 100; i += 10)
            {
                F = (i * 1.8) + 32;
                txtC.Text += String.Format("\n" + i.ToString());
                txtF.Text += String.Format("\n" + F.ToString());
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtC.Clear();
            txtF.Clear();
        }
    }
}
