﻿namespace Markdown
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl = new MetroFramework.Controls.MetroTabControl();
            this.tabPage_HTML = new MetroFramework.Controls.MetroTabPage();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.tabPage_MD = new MetroFramework.Controls.MetroTabPage();
            this.fastColoredTextBox1 = new FastColoredTextBoxNS.FastColoredTextBox();
            this.tabPage_Hilfe = new MetroFramework.Controls.MetroTabPage();
            this.webBrowser_hilfe = new System.Windows.Forms.WebBrowser();
            this.metroLabel_speichern = new MetroFramework.Controls.MetroLabel();
            this.tabControl.SuspendLayout();
            this.tabPage_HTML.SuspendLayout();
            this.tabPage_MD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fastColoredTextBox1)).BeginInit();
            this.tabPage_Hilfe.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage_HTML);
            this.tabControl.Controls.Add(this.tabPage_MD);
            this.tabControl.Controls.Add(this.tabPage_Hilfe);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(20, 60);
            this.tabControl.Multiline = true;
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1203, 878);
            this.tabControl.TabIndex = 2;
            this.tabControl.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl_Selected);
            // 
            // tabPage_HTML
            // 
            this.tabPage_HTML.Controls.Add(this.webBrowser1);
            this.tabPage_HTML.HorizontalScrollbarBarColor = true;
            this.tabPage_HTML.Location = new System.Drawing.Point(4, 35);
            this.tabPage_HTML.Name = "tabPage_HTML";
            this.tabPage_HTML.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_HTML.Size = new System.Drawing.Size(1195, 839);
            this.tabPage_HTML.TabIndex = 0;
            this.tabPage_HTML.Text = "HTML Vorschau";
            this.tabPage_HTML.VerticalScrollbarBarColor = true;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(3, 3);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1189, 833);
            this.webBrowser1.TabIndex = 2;
            // 
            // tabPage_MD
            // 
            this.tabPage_MD.Controls.Add(this.fastColoredTextBox1);
            this.tabPage_MD.HorizontalScrollbarBarColor = true;
            this.tabPage_MD.Location = new System.Drawing.Point(4, 35);
            this.tabPage_MD.Name = "tabPage_MD";
            this.tabPage_MD.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_MD.Size = new System.Drawing.Size(1195, 839);
            this.tabPage_MD.TabIndex = 1;
            this.tabPage_MD.Text = "Markdown Text";
            this.tabPage_MD.VerticalScrollbarBarColor = true;
            // 
            // fastColoredTextBox1
            // 
            this.fastColoredTextBox1.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.fastColoredTextBox1.AutoScrollMinSize = new System.Drawing.Size(2, 14);
            this.fastColoredTextBox1.BackBrush = null;
            this.fastColoredTextBox1.CharHeight = 14;
            this.fastColoredTextBox1.CharWidth = 8;
            this.fastColoredTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fastColoredTextBox1.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.fastColoredTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fastColoredTextBox1.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.fastColoredTextBox1.IndentBackColor = System.Drawing.Color.White;
            this.fastColoredTextBox1.IsReplaceMode = false;
            this.fastColoredTextBox1.LineNumberColor = System.Drawing.Color.RoyalBlue;
            this.fastColoredTextBox1.Location = new System.Drawing.Point(3, 3);
            this.fastColoredTextBox1.Name = "fastColoredTextBox1";
            this.fastColoredTextBox1.Paddings = new System.Windows.Forms.Padding(0);
            this.fastColoredTextBox1.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.fastColoredTextBox1.Size = new System.Drawing.Size(1189, 833);
            this.fastColoredTextBox1.TabIndex = 4;
            this.fastColoredTextBox1.Zoom = 100;
            this.fastColoredTextBox1.TextChanged += new System.EventHandler<FastColoredTextBoxNS.TextChangedEventArgs>(this.fastColoredTextBox1_TextChanged);
            this.fastColoredTextBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fastColoredTextBox1_KeyDown);
            // 
            // tabPage_Hilfe
            // 
            this.tabPage_Hilfe.Controls.Add(this.webBrowser_hilfe);
            this.tabPage_Hilfe.HorizontalScrollbarBarColor = true;
            this.tabPage_Hilfe.Location = new System.Drawing.Point(4, 35);
            this.tabPage_Hilfe.Name = "tabPage_Hilfe";
            this.tabPage_Hilfe.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Hilfe.Size = new System.Drawing.Size(1195, 839);
            this.tabPage_Hilfe.TabIndex = 2;
            this.tabPage_Hilfe.Text = "Hilfe";
            this.tabPage_Hilfe.VerticalScrollbarBarColor = true;
            // 
            // webBrowser_hilfe
            // 
            this.webBrowser_hilfe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser_hilfe.Location = new System.Drawing.Point(3, 3);
            this.webBrowser_hilfe.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser_hilfe.Name = "webBrowser_hilfe";
            this.webBrowser_hilfe.Size = new System.Drawing.Size(1189, 833);
            this.webBrowser_hilfe.TabIndex = 3;
            // 
            // metroLabel_speichern
            // 
            this.metroLabel_speichern.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel_speichern.AutoSize = true;
            this.metroLabel_speichern.Location = new System.Drawing.Point(1150, 67);
            this.metroLabel_speichern.Name = "metroLabel_speichern";
            this.metroLabel_speichern.Size = new System.Drawing.Size(66, 19);
            this.metroLabel_speichern.TabIndex = 3;
            this.metroLabel_speichern.Text = "Speichern";
            this.metroLabel_speichern.Visible = false;
            this.metroLabel_speichern.Click += new System.EventHandler(this.metroLabel_speichern_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(1224, 958);
            this.Controls.Add(this.metroLabel_speichern);
            this.Controls.Add(this.tabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(20, 60, 1, 20);
            this.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.SystemShadow;
            this.Text = "Markdown Editor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.tabControl.ResumeLayout(false);
            this.tabPage_HTML.ResumeLayout(false);
            this.tabPage_MD.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fastColoredTextBox1)).EndInit();
            this.tabPage_Hilfe.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.WebBrowser webBrowser1;
        private MetroFramework.Controls.MetroTabControl tabControl;
        private MetroFramework.Controls.MetroTabPage tabPage_HTML;
        private MetroFramework.Controls.MetroTabPage tabPage_MD;
        private MetroFramework.Controls.MetroLabel metroLabel_speichern;
        private MetroFramework.Controls.MetroTabPage tabPage_Hilfe;
        private System.Windows.Forms.WebBrowser webBrowser_hilfe;
        private FastColoredTextBoxNS.FastColoredTextBox fastColoredTextBox1;
    }
}

