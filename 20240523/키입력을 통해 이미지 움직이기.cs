using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp25
{
   
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            Image img = pictureBox1.Image;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
           

            if (e.KeyCode == Keys.Up) 
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y + 10);
            }

            if(e.KeyCode == Keys.Down) 
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X , pictureBox1.Location.Y - 10);
            }

            if (e.KeyCode == Keys.Left)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X - 10, pictureBox1.Location.Y);
            }

            if(e.KeyCode == Keys.Right)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X + 10, pictureBox1.Location.Y);
            }

            if(e.KeyCode == Keys.A)
            {
                img.RotateFlip(RotateFlipType.Rotate270FlipNone);
            }

            if (e.KeyCode == Keys.D)
            {
                img.RotateFlip(RotateFlipType.Rotate90FlipNone);
            }
        }
    }
}
