using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto_xp
{
    public partial class Form : System.Windows.Forms.Form
    {
        public string[] values = new string[10];
        public int i = 0;

        public Form()
        {
            InitializeComponent();
        }

        private void Cor_Click(object sender, EventArgs e)
        {


            if (TT.Text == String.Empty || i <= 9)
            { values[i] = TT.Text; TT.Text = String.Empty; TT.Focus(); i++; }

            BoxT.Text = String.Empty;
            TT.Focus();

            for (int x = 9; x >= 0; x--)
            {
                if (values[x] != null)
                { BoxT.Text += values[x] + System.Environment.NewLine; }
            }
        }
        

        private void Del_Click(object sender, EventArgs e)
        {
            values[i] = null;
            i--;

            BoxT.Text = String.Empty;
            TT.Focus();

            for (int x = 9; x >= 0; x--) {
                if (values[x] != null) { BoxT.Text += values[i] + System.Environment.NewLine; }
            }
        }

        private void test_Click(object sender, EventArgs e)
        {
            MessageBox.Show(values[9]);
        }
    }
}
