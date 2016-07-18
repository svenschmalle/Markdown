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
using MetroFramework.Forms;

namespace Markdown
{
    public partial class Form1 : MetroForm
    {
        private string[] _args;
        private string AktuellerDateiName;
        private string OriginalText;
        private Markdig.MarkdownPipeline _Pipeline;
        
        public Form1(string[] args)
        {
            InitializeComponent();
            _args = args;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (_args.Length == 0)
            {
                OriginalText = "# Neue Seite\r\nDer Seiten-Inhalt kann über \"Markdown Text\" geändert werden.";
            }
            else
            {
                AktuellerDateiName = _args[0];
                OriginalText = File.ReadAllText(AktuellerDateiName);
            }

            this.SuspendLayout();
            this.textBox1.Text = OriginalText;

            var pipelineb = new Markdig.MarkdownPipelineBuilder();
            pipelineb = Markdig.MarkdownExtensions.UseBootstrap(pipelineb);
            pipelineb = Markdig.MarkdownExtensions.UsePipeTables(pipelineb);
            pipelineb = Markdig.MarkdownExtensions.UseTaskLists(pipelineb);
            pipelineb = Markdig.MarkdownExtensions.UseGridTables(pipelineb);
            pipelineb = Markdig.MarkdownExtensions.UseAdvancedExtensions(pipelineb);
            _Pipeline = pipelineb.Build();

            webBrowser1.ScriptErrorsSuppressed = true;
            webBrowser1.DocumentText = RenderMarkDown(this.textBox1.Text);
            webBrowser_hilfe.ScriptErrorsSuppressed = true;
            webBrowser_hilfe.DocumentText = RenderMarkDown(Resource.Hilfe);
            this.ResumeLayout(true);
        }

        private void tabControl_Selected(object sender, TabControlEventArgs e)
        {
            if (e.TabPage == tabPage_HTML)
            {
                webBrowser1.DocumentText = RenderMarkDown(this.textBox1.Text);
                metroLabel_speichern.Visible = false;
            }
            else
            {
                metroLabel_speichern.Visible = true;
            }           
        }


        private string RenderMarkDown(string MarkDownText)
        {
            string HTML = Markdig.Markdown.ToHtml(MarkDownText, _Pipeline);

            string WebseiteHTML = @"<!DOCTYPE HTML>
                                <html>
                                <head>
                                <!-- Das neueste kompilierte und minimierte CSS -->
                                <link rel=stylesheet href=https://maxcdn.bootstrapcdn.com/bootstrap/3.3.5/css/bootstrap.min.css>
                                <!--Optionales Theme-- >
                                <link rel=stylesheet href=https://maxcdn.bootstrapcdn.com/bootstrap/3.3.5/css/bootstrap-theme.min.css>
                                <!--Das neueste kompilierte und minimierte JavaScript-- >
                                <script src=https://maxcdn.bootstrapcdn.com/bootstrap/3.3.5/js/bootstrap.min.js></script>
                                </head>
                                <body>" + HTML +
                                @"</body></html>";

            return  WebseiteHTML;
        }

        private void metroLabel_speichern_Click(object sender, EventArgs e)
        {
            // DateiAuswahl, falls es sich um eine neue Datei handelt
            if (string.IsNullOrEmpty(AktuellerDateiName))
            {
                SaveFileDialog SaveDlg = new SaveFileDialog();
                SaveDlg.Filter = "Markdown Dateien (*.md)|*.md|Alle Dateien (*.*)|*.*";
                SaveDlg.ShowDialog();
                AktuellerDateiName = SaveDlg.FileName;
            }

            if (!string.IsNullOrEmpty(AktuellerDateiName))
            {
                OriginalText = this.textBox1.Text;
                File.WriteAllText(AktuellerDateiName, this.textBox1.Text);
                this.Style = MetroFramework.MetroColorStyle.Green;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != OriginalText)
            {
                this.Style = MetroFramework.MetroColorStyle.Orange;
            }
        }
    }
}
