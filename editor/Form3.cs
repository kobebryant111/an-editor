using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TXT
{
    public partial class Form3 : Form
    {
        public int start = 0;
        public RichTextBox richText;
        public Form3()
        {
            InitializeComponent();
        }
        public Form3(RichTextBox rtb)
        {
            richText = rtb;
        }
        private void button1_Click(object sender, EventArgs e)     //查找下一个
        {
            string str1;    //存放要查找的文本
            str1 = textBox1.Text.Trim();
            richText.SelectionColor = Color.Blue;
            start = richText.Find(str1, start, RichTextBoxFinds.MatchCase);    //查找下一个
            if (start == -1)
            {
                MessageBox.Show("已查找到文档的结尾", "查找结束对话框", MessageBoxButtons.OK);
                start = 0;
            }
            else
            {
                start = start + str1.Length;
            }
            richText.SelectionColor = Color.Red;
            richText.Focus();
        }

        //这里的替换窗口本身就是区分大小写的吧
        private void button2_Click(object sender, EventArgs e)  //替换
        {
            string str1, str2;
            str1 = textBox1.Text;
            str2 = textBox2.Text;
            richText.SelectionColor = Color.Blue;
            start = richText.Find(str1, start, RichTextBoxFinds.MatchCase);    //查找下一个,这里本身就是区分大小写的
            if (start == -1)
            {
                MessageBox.Show("已查找到文档的结尾", "查找结束对话框", MessageBoxButtons.OK);
                start = 0;
            }
            else
            {
                start = start + str1.Length;
                richText.SelectedText = str2;   //替换掉原本选中的字符
            }
            richText.SelectionColor = Color.Red;
            richText.Focus();
        }

        private void button3_Click(object sender, EventArgs e)     //全部替换
        {
            string str1, str2;
            str1 = textBox1.Text;
            str2 = textBox2.Text;
            start = 0;
            start = richText.Find(str1, start, RichTextBoxFinds.MatchCase);    //查找下一个
            while (start != -1)
            {
                richText.SelectedText = str2;
                start += str2.Length;
                start = richText.Find(str1, start, RichTextBoxFinds.MatchCase);
            }
            MessageBox.Show("已查找到文档的结尾", "查找结束对话框", MessageBoxButtons.OK);
            start = 0;
            richText.Focus();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();   //关闭窗体
        }
    }
}
