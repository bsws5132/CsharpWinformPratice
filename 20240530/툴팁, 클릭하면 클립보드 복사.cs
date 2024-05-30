using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp29
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
         Clipboard.SetText(textBox1.Text);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Clipboard.SetText(textBox2.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(textBox1, textBox1.Text);
            toolTip1.SetToolTip(textBox2, textBox2.Text);
        }
    }
}
