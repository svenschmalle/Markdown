using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Markdig.Extensions;

namespace Markdown
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
            string mdtext = "#Überschrift";

            string outmd = Markdig.Markdown.ToHtml(File.ReadAllText("test.md"));

            File.WriteAllText("out.html", outmd);
            */

            var pipeline = new Markdig.MarkdownPipelineBuilder().Build();
            var result = Markdig.Markdown.ToHtml(File.ReadAllText("test.md"), pipeline);
            File.WriteAllText("out.html", result);
        }
    }
}
