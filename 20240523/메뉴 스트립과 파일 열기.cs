using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp26
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void 열기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "그림 파일 (*.jpg,*.png,*.gif,*.bmp)|*.jpg;*.png;*.gif;*.bmp"; // 화면에 표시될 확장자 , 실제 표시되는 확장자

            DialogResult result = ofd.ShowDialog();

            if (result == DialogResult.Cancel)
                return;
            pictureBox1.Image = Bitmap.FromFile(ofd.FileName);
        }

        private void 닫기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("프로그램을 종료합니다.~~");
            this.Close();
        }
    }
}
