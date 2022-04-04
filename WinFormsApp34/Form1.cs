using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp34
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBoxoutputhasil_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelhasil_Click(object sender, EventArgs e)
        {

        }

        private void textBoxoutputkalimat_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxoutputhuruf_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonkonversi_Click(object sender, EventArgs e)
        {
            //textBoxoutputkalimat.Text = textBoxoutputhasil.Text;
            //textBoxoutputhuruf.Text = textBoxoutputhasil.Text;
            string s1 = "";
            string textBoxoutputkalimat = "Kalimat";
            string s2 = "";
            string textBoxoutputhuruf = "Huruf";
            s1 += "";
            s2 += "";
        }

        private void textBoxoutputmenjadi_TextChanged(object sender, EventArgs e)
        {
            string str = "A";

            StringBuilder strB = new StringBuilder(str);

            strB[0] = 'C';
        }
    }
}
