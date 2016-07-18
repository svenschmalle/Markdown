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
        private string _AktuellerDateiName;
        private string _OriginalText;
        private string _OriginalTextAuto;
        private Markdig.MarkdownPipeline _Pipeline;
        private Timer _Timer;
        private functions _func;

        public Form1(string[] args)
        {
            InitializeComponent();
            _args = args;
            _Timer = new Timer();
            _func = new functions();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (_args.Length == 0)
            {
                _OriginalText = "# Neue Seite\r\nDer Seiten-Inhalt kann über \"Markdown Text\" geändert werden.";
                this.textBox1.Text = _OriginalText;
            }
            else
            {
                // Übergebene Datei laden
                _AktuellerDateiName = _args[0];
                _OriginalText = File.ReadAllText(_AktuellerDateiName);
                _OriginalTextAuto = File.ReadAllText(_AktuellerDateiName);
                this.textBox1.Text = _OriginalText;

                if (File.Exists(_func.getSaveFile(_AktuellerDateiName)))
                {
                    DialogResult dlr = MessageBox.Show("Es wurde eine Auto-Save Datei gefunden, soll diese geladen werden?", "Auto-Save Datei laden?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dlr == DialogResult.Yes)
                    {
                        _OriginalTextAuto = File.ReadAllText(_func.getSaveFile(_AktuellerDateiName));
                        this.textBox1.Text = _OriginalTextAuto;
                    }
                }
            }

            this.SuspendLayout();

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
            webBrowser_hilfe.DocumentText = RenderMarkDown(_func.getResourceFile("Markdown.Resources.Hilfe.md"));
            this.ResumeLayout(true);

            // Timer für Auto-Save erstellen
            _Timer.Interval = 1000 * 10; // 10 Sek
            _Timer.Enabled = true;
            _Timer.Start();
            _Timer.Tick += Timer_Tick;

            // Pfad für Auto-Save erstellen falls nicht vorhanden
            _func.makeSavePath();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(_AktuellerDateiName))
            {
                Speichern(true);
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F11)
            {
                if (this.WindowState == FormWindowState.Maximized)
                {
                    this.WindowState = FormWindowState.Normal;
                }
                else
                {
                    this.WindowState = FormWindowState.Maximized;
                }
            }
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
                                <!-- Das neueste kompilierte und minimierte CSS-->
                                <!--<link rel=stylesheet href=https://maxcdn.bootstrapcdn.com/bootstrap/3.3.5/css/bootstrap.min.css>-->
                                <!--Optionales Theme-->
                                <!--<link rel=stylesheet href=https://maxcdn.bootstrapcdn.com/bootstrap/3.3.5/css/bootstrap-theme.min.css>-->
                                <!--Das neueste kompilierte und minimierte JavaScript-->
                                <!--<script src=https://maxcdn.bootstrapcdn.com/bootstrap/3.3.5/js/bootstrap.min.js></script>-->
                                <style>" + _func.getResourceFile("Markdown.Resources.bootstrap.min.css") + @"</style>
                                <style>" + _func.getResourceFile("Markdown.Resources.bootstrap-theme.min.css") + @"</style>
                                <script language=javascript>" + _func.getResourceFile("Markdown.Resources.jquery.min.js") + @"</script>
                                <script language=javascript>" + _func.getResourceFile("Markdown.Resources.bootstrap.min.js") + @"</script>
                                </head>
                                <body>" + HTML +
                                @"</body></html>";

            return  WebseiteHTML;
        }

        private void Speichern(bool auto)
        {
            // DateiAuswahl, falls es sich um eine neue Datei handelt
            if (string.IsNullOrEmpty(_AktuellerDateiName))
            {
                SaveFileDialog SaveDlg = new SaveFileDialog();
                SaveDlg.Filter = "Markdown Dateien (*.md)|*.md|Alle Dateien (*.*)|*.*";
                SaveDlg.ShowDialog();
                _AktuellerDateiName = SaveDlg.FileName;
            }

            if (!string.IsNullOrEmpty(_AktuellerDateiName))
            {
                // Beim Automatischen speichern soll in eine seperate Datei gespeichert werden
                if (auto && _OriginalTextAuto!= this.textBox1.Text)
                {
                    _OriginalTextAuto = this.textBox1.Text;                   
                    File.WriteAllText(_func.getSaveFile(_AktuellerDateiName), this.textBox1.Text);
                }

                // Beim Normalen speichern soll in die Original-Datei gespeichert werden
                if (!auto && _OriginalText != this.textBox1.Text)
                {
                    _OriginalText = this.textBox1.Text;
                    File.WriteAllText(_AktuellerDateiName, this.textBox1.Text);
                    this.Style = MetroFramework.MetroColorStyle.Green;
                    
                    // Wenn durch den Anwender gespeichert wurde, kann das Save-File gelöscht werden
                    File.Delete(_func.getSaveFile(_AktuellerDateiName));
                }
            }
        }

        private void metroLabel_speichern_Click(object sender, EventArgs e)
        {
            Speichern(false);
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S)       // Ctrl-S Save
            {
                Speichern(false);
                e.SuppressKeyPress = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != _OriginalText)
            {
                this.Style = MetroFramework.MetroColorStyle.Orange;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_OriginalText != this.textBox1.Text)
            {
                DialogResult dlr = MessageBox.Show("Soll die Datei vor dem Beenden gespeichert werden?", "Speichern?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (dlr == DialogResult.Yes)
                {
                    Speichern(false);
                    // Nach dem Speichern kann das Save-File gelöscht werden
                    File.Delete(_func.getSaveFile(_AktuellerDateiName)); 
                }
                else if (dlr == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
