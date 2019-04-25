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
    public partial class Form4 : Form
    {
        public RichTextBox richText;
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str1,str2;
            str1 = textBox1.Text;
            str2 = richText.SelectedText;
            richText.SelectedText = str1;
            richText.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();   //关闭窗体
        }
    }
}
