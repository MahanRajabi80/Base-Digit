using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Base_Digit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBin_Click(object sender, EventArgs e)
        {
            int a;
            a = Convert.ToInt32(txtDigit10.Text);
            lblBin.Text = Convert.ToString(a, 2);
        }

        private void btnOct_Click(object sender, EventArgs e)
        {
            int a;
            a = Convert.ToInt32(txtDigit10.Text);
            lblOct.Text = Convert.ToString(a, 8);
        }

        private void btnHex_Click(object sender, EventArgs e)
        {
            int a;
            a = Convert.ToInt32(txtDigit10.Text);
            lblHex.Text = Convert.ToString(a, 16);
        }
    }
}
