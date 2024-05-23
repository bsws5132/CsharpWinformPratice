using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp24
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TreeNode petRoot = new TreeNode("동물");
            TreeNode carRoot = new TreeNode("자동차");

            treeView1.Nodes.Add(petRoot);
            treeView1.Nodes.Add(carRoot);

            TreeNode dogTree = new TreeNode("강아지");
            dogTree.Nodes.Add("강아지1");
            dogTree.Nodes.Add("강아지2");
            petRoot.Nodes.Add(dogTree);

            TreeNode catTree = new TreeNode("고양이");
            catTree.Nodes.Add("고양이1");
            catTree.Nodes.Add("고양이2");
            petRoot.Nodes.Add(catTree);

            TreeNode birdTree = new TreeNode("새");
            birdTree.Nodes.Add("새1");
            birdTree.Nodes.Add("새2");
            petRoot.Nodes.Add(birdTree);


            TreeNode sedanTree = new TreeNode("승용차");
            sedanTree.Nodes.Add("그랜저");
            sedanTree.Nodes.Add("소나타");
            carRoot.Nodes.Add(sedanTree);

            TreeNode truckTree = new TreeNode("화물차");
            truckTree.Nodes.Add("1톤");
            truckTree.Nodes.Add("2.5톤");
            carRoot.Nodes.Add(truckTree);

            TreeNode busTree = new TreeNode("버스");
            busTree.Nodes.Add("30인");
            busTree.Nodes.Add("60인");
            carRoot.Nodes.Add(busTree);


            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Text == "강아지1")
                pictureBox1.Image = Bitmap.FromFile("D:\\2206058\\WindowsFormsApp24\\dog1.png");
            else if (e.Node.Text == "강아지2")
                pictureBox1.Image = Bitmap.FromFile("D:\\2206058\\WindowsFormsApp24\\dog2.png");
            else if (e.Node.Text == "고양이1")
                pictureBox1.Image = Bitmap.FromFile("D:\\2206058\\WindowsFormsApp24\\cat1.png");
            else if (e.Node.Text == "고양이2")
                pictureBox1.Image = Bitmap.FromFile("D:\\2206058\\WindowsFormsApp24\\cat2.png");
            else if (e.Node.Text == "새1")
                pictureBox1.Image = Bitmap.FromFile("D:\\2206058\\WindowsFormsApp24\\bird1.png");
            else if (e.Node.Text == "새2")
                pictureBox1.Image = Bitmap.FromFile("D:\\2206058\\WindowsFormsApp24\\bird2.png");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox1.Checked)
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            else
                pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
        }
    }
}
