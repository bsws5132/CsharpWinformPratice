using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
namespace WindowsFormsApp30
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void 글꼴및크기변경ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FontDialog fontD = new FontDialog();
            
            DialogResult result = fontD.ShowDialog();

            richTextBox1.Font = fontD.Font;
        }

        private void 파일저장ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            
            
            saveFileDialog.Filter = "텍스트 파일 (*.txt)|*.txt|모든 파일 (*.*)|*.*";
            DialogResult result = saveFileDialog.ShowDialog();

            string fileName = saveFileDialog.FileName;
            File.WriteAllText(fileName, richTextBox1.Text);
            // 저장 대화상자에서 사용자가 입력한 파일명으로 리치박스내의 글을 파일로 저장
        }

        private void 배경색상변경ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();

            DialogResult dialogResult = colorDialog.ShowDialog();

            richTextBox1.BackColor = colorDialog.Color;
        }

        private void 파일열기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "텍스트 파일 (*.txt)|*.txt|모든 파일 (*.*)|*.*";

            DialogResult dialogResult = openFileDialog.ShowDialog();
            string fileName = openFileDialog.FileName;
            richTextBox1.Text = File.ReadAllText(fileName);

        }

        private void 초기화ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
        }
    }
}
