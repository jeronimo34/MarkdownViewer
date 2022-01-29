using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Markdig;

namespace MarkdownViewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            var text = richTextBox1.Text;
            var html = Markdown.ToHtml(text);
            webBrowser1.DocumentText = html;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var sample = "# title\n## title2\n### title3\n<span style='color:red'>red</span>  \ntest test test  test test test";
            richTextBox1.Text = sample;
        }
    }
}
