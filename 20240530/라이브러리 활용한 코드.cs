﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary1;

namespace WindowsFormsApp28
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyCal myCal = new MyCal();
            double result = myCal.Add(Convert.ToDouble(textBox1.Text),Convert.ToDouble(textBox2.Text));

            textBox3.Text = result.ToString();

        }
    }
}
