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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void mstiSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mstiEx1_Click(object sender, EventArgs e)
        {
            frmEx1 ex1 = new frmEx1();
            Hide();
            ex1.Show();
        }

        private void mstiEx2_Click(object sender, EventArgs e)
        {
            frmEx2 ex2 = new frmEx2();
            Hide();
            ex2.Show();
        }

        private void mstiEx3_Click(object sender, EventArgs e)
        {
            frmEx3 ex3 = new frmEx3();
            Hide();
            ex3.Show();
        }

        private void mstiEx4_Click(object sender, EventArgs e)
        {
            frmEx4 ex4 = new frmEx4();
            Hide();
            ex4.Show();
        }

        private void mstiEx5_Click(object sender, EventArgs e)
        {
            frmEx5 ex5 = new frmEx5();
            Hide();
            ex5.Show();
        }

        private void mstiEx6_Click(object sender, EventArgs e)
        {
            frmEx6 ex6 = new frmEx6();
            Hide();
            ex6.Show();
        }

        private void mstiEx7_Click(object sender, EventArgs e)
        {
            frmEx7 ex7 = new frmEx7();
            Hide();
            ex7.Show();
        }

        private void msti3BimEx1_Click(object sender, EventArgs e)
        {
            frm3BimEx1 ex1 = new frm3BimEx1();
            Hide();
            ex1.Show();
        }

        private void msti3BimEx2_Click(object sender, EventArgs e)
        {
            frm3BimEx2 ex2 = new frm3BimEx2();
            Hide();
            ex2.Show();
        }

        private void msti3BimEx3_Click(object sender, EventArgs e)
        {
            frm3BimEx3 ex3 = new frm3BimEx3();
            Hide();
            ex3.Show();
        }

        private void msti3BimEx4_Click(object sender, EventArgs e)
        {
            frm3BimEx4 ex4 = new frm3BimEx4();
            Hide();
            ex4.Show();
        }

        private void msti3BimEx5_Click(object sender, EventArgs e)
        {
            frm3BimEx5 ex5 = new frm3BimEx5();
            Hide();
            ex5.Show();
        }

        private void mstiProva1_Click(object sender, EventArgs e)
        {
            frm3BimProva1 prova1 = new frm3BimProva1();
            Hide();
            prova1.Show();
        }

        private void mstiProva2_Click(object sender, EventArgs e)
        {
            frm3BimProva2 prova2 = new frm3BimProva2();
            Hide();
            prova2.Show();
        }

        private void msti4BimEx1_Click(object sender, EventArgs e)
        {
            frm4BimEx1 ex1 = new frm4BimEx1();
            Hide();
            ex1.Show();
        }

        private void msti4BimEx2_Click(object sender, EventArgs e)
        {
            frm4BimEx2 ex2 = new frm4BimEx2();
            Hide();
            ex2.Show();
        }

        private void msti4BimEx3_Click(object sender, EventArgs e)
        {
            frm4BimEx3 ex3 = new frm4BimEx3();
            Hide();
            ex3.Show();
        }
    }
}
