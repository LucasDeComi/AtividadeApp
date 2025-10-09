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
            double f;
            while(i <= 100)
            {
                f = (i * 1.8) + 32;
                txtC.Text += i.ToString() + "\n";
                txtF.Text += f.ToString() + "\n";
                i += 10;
            }
        }
    }
}
