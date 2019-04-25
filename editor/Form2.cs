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
    public partial class Form2 : Form
    {
        //RichTextBox是一种可用于显示、输入和操作格式文本，除了可以实现TextBox的所有功能，还能提供富文本的显示功能。 控件除具有TextBox 控件的所有功能外，还能设定文字颜色、字体和段落格式，支持字符串查找功能，支持rtf格式等功能。
        public RichTextBox richtextbox;
        public int start = 0;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)   //查找下一个
        {
            richtextbox.SelectionColor = Color.Blue;    //显示为蓝色
            string str;
            str = textBox1.Text;    //str即为输入的记事本内容
            if (checkBox1.Checked)     //判断是否区分大小写
            {
                if (radioButton2.Checked)    //判断是否是向下查找
                {
                    checkUp(str);    //区分大小写向上查找
                }
                else
                {
                    checkDown(str);   //否则就是区分大小写向下查找
                }
            }
            else
            {
                if (radioButton1.Checked)
                {
                    uncheckDown(str);
                }
                else
                {
                    uncheckUp(str);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)     //取消
        {
            this.Close();    //关闭窗体
        }

        public void checkDown(string ss)      //区分大小写向下查找
        {
            int c = 0;
            int b = 0;
            try
            {
                c = richtextbox.SelectionStart;   //获取选择区域的开始位置
                b = richtextbox.Text.IndexOf(ss, c + ss.Length, StringComparison.CurrentCulture);
                richtextbox.SelectionStart = b;
                richtextbox.SelectionLength = ss.Length;
                richtextbox.SelectionColor = Color.Red;     //显示为红色
            }
            catch
            {
                MessageBox.Show("已查到文档的末尾", "查找结束对话框", MessageBoxButtons.OK);
                this.textBox1.SelectionStart = c;
                this.textBox1.SelectionLength = ss.Length;
            }
        }

        public void checkUp(string ss)     //区分大小写向上查找
        {
            int c = 0;
            int b = 0;
            try
            {
                c = richtextbox.SelectionStart;
                b = richtextbox.Text.IndexOf(ss, c - ss.Length, StringComparison.CurrentCulture);
                richtextbox.SelectionStart = b;
                richtextbox.SelectionLength = ss.Length;
                richtextbox.SelectionColor = Color.Red;     //显示为红色
            }
            catch
            {
                MessageBox.Show("已查到文档的末尾", "查找结束对话框", MessageBoxButtons.OK);
                this.textBox1.SelectionStart = c;
                this.textBox1.SelectionLength = ss.Length;
            }
        }

        public void uncheckDown(string ss)     //不区分大小写向下查找
        {
            int c = 0;
            int b = 0;
            try
            {
                c = richtextbox.SelectionStart;
                b = richtextbox.Text.IndexOf(ss, c + ss.Length, StringComparison.CurrentCultureIgnoreCase);
                richtextbox.SelectionStart = b;
                richtextbox.SelectionLength = ss.Length;
                richtextbox.SelectionColor = Color.Red;     //显示为红色
            }
            catch
            {
                MessageBox.Show("已查到文档的末尾", "查找结束对话框", MessageBoxButtons.OK);
                this.textBox1.SelectionStart = c;
                this.textBox1.SelectionLength = ss.Length;
            }
        }

        public void uncheckUp(string ss)     //不区分大小写向上查找
        {
            int c = 0;
            int b = 0;
            try
            {
                c = richtextbox.SelectionStart;
                b = richtextbox.Text.IndexOf(ss, c - ss.Length, StringComparison.CurrentCultureIgnoreCase);
                richtextbox.SelectionStart = b;
                richtextbox.SelectionLength = ss.Length;
                richtextbox.SelectionColor = Color.Red;     //显示为红色
            }
            catch
            {
                MessageBox.Show("已查到文档的末尾", "查找结束对话框", MessageBoxButtons.OK);
                this.textBox1.SelectionStart = c;
                this.textBox1.SelectionLength = ss.Length;
            }
        }
    }
}
