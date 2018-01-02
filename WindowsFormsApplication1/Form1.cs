using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            ulong factorial = 1;
            uint n;
            n=uint.Parse(textBox1.Text);
            for (uint i = 2; i <= n; i++)
            {
                factorial *= i;
            }
            textBox2.Text = factorial.ToString();
            //return factorial;
        }
    }
}
