namespace Latihan_5_1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.New = new System.Windows.Forms.ToolStripMenuItem();
            this.Open = new System.Windows.Forms.ToolStripMenuItem();
            this.Save = new System.Windows.Forms.ToolStripMenuItem();
            this.Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.Editor = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.SizeLabel = new System.Windows.Forms.ToolStripLabel();
            this.fontsize = new System.Windows.Forms.ToolStripComboBox();
            this.Boldbtn = new System.Windows.Forms.ToolStripButton();
            this.Italicbtn = new System.Windows.Forms.ToolStripButton();
            this.Underlinebtn = new System.Windows.Forms.ToolStripButton();
            this.FontFamilyLabel = new System.Windows.Forms.ToolStripLabel();
            this.fontfamily = new System.Windows.Forms.ToolStripComboBox();
            this.Colorbtn = new System.Windows.Forms.ToolStripButton();
            this.Backgroundbtn = new System.Windows.Forms.ToolStripButton();
            this.rtb1 = new System.Windows.Forms.RichTextBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.KlikKanan = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.KlikKanan.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripDropDownButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(496, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.New,
            this.Open,
            this.Save,
            this.Exit});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(38, 22);
            this.toolStripDropDownButton1.Text = "File";
            // 
            // New
            // 
            this.New.Name = "New";
            this.New.Size = new System.Drawing.Size(152, 22);
            this.New.Text = "New";
            this.New.Click += new System.EventHandler(this.New_Click);
            // 
            // Open
            // 
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(152, 22);
            this.Open.Text = "Open";
            this.Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // Save
            // 
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(152, 22);
            this.Save.Text = "Save";
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Exit
            // 
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(152, 22);
            this.Exit.Text = "Exit";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Editor});
            this.toolStripDropDownButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton2.Image")));
            this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(62, 22);
            this.toolStripDropDownButton2.Text = "Settings";
            // 
            // Editor
            // 
            this.Editor.Name = "Editor";
            this.Editor.Size = new System.Drawing.Size(152, 22);
            this.Editor.Text = "Editor";
            this.Editor.Click += new System.EventHandler(this.Editor_Click);
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SizeLabel,
            this.fontsize,
            this.Boldbtn,
            this.Italicbtn,
            this.Underlinebtn,
            this.FontFamilyLabel,
            this.fontfamily,
            this.Colorbtn,
            this.Backgroundbtn});
            this.toolStrip2.Location = new System.Drawing.Point(0, 25);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(496, 25);
            this.toolStrip2.TabIndex = 1;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // SizeLabel
            // 
            this.SizeLabel.Name = "SizeLabel";
            this.SizeLabel.Size = new System.Drawing.Size(27, 22);
            this.SizeLabel.Text = "Size";
            // 
            // fontsize
            // 
            this.fontsize.Name = "fontsize";
            this.fontsize.Size = new System.Drawing.Size(121, 25);
            this.fontsize.SelectedIndexChanged += new System.EventHandler(this.fontsize_SelectedIndexChanged);
            // 
            // Boldbtn
            // 
            this.Boldbtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Boldbtn.Image = ((System.Drawing.Image)(resources.GetObject("Boldbtn.Image")));
            this.Boldbtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Boldbtn.Name = "Boldbtn";
            this.Boldbtn.Size = new System.Drawing.Size(23, 22);
            this.Boldbtn.Text = "Bold";
            this.Boldbtn.Click += new System.EventHandler(this.Boldbtn_Click);
            // 
            // Italicbtn
            // 
            this.Italicbtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Italicbtn.Image = ((System.Drawing.Image)(resources.GetObject("Italicbtn.Image")));
            this.Italicbtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Italicbtn.Name = "Italicbtn";
            this.Italicbtn.Size = new System.Drawing.Size(23, 22);
            this.Italicbtn.Text = "Italic";
            this.Italicbtn.Click += new System.EventHandler(this.Italicbtn_Click);
            // 
            // Underlinebtn
            // 
            this.Underlinebtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Underlinebtn.Image = ((System.Drawing.Image)(resources.GetObject("Underlinebtn.Image")));
            this.Underlinebtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Underlinebtn.Name = "Underlinebtn";
            this.Underlinebtn.Size = new System.Drawing.Size(23, 22);
            this.Underlinebtn.Text = "Underline";
            this.Underlinebtn.Click += new System.EventHandler(this.Underlinebtn_Click);
            // 
            // FontFamilyLabel
            // 
            this.FontFamilyLabel.Name = "FontFamilyLabel";
            this.FontFamilyLabel.Size = new System.Drawing.Size(31, 22);
            this.FontFamilyLabel.Text = "Font";
            // 
            // fontfamily
            // 
            this.fontfamily.Name = "fontfamily";
            this.fontfamily.Size = new System.Drawing.Size(121, 25);
            this.fontfamily.SelectedIndexChanged += new System.EventHandler(this.fontfamily_SelectedIndexChanged);
            // 
            // Colorbtn
            // 
            this.Colorbtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Colorbtn.Image = ((System.Drawing.Image)(resources.GetObject("Colorbtn.Image")));
            this.Colorbtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Colorbtn.Name = "Colorbtn";
            this.Colorbtn.Size = new System.Drawing.Size(23, 22);
            this.Colorbtn.Text = "Color";
            this.Colorbtn.Click += new System.EventHandler(this.Colorbtn_Click);
            // 
            // Backgroundbtn
            // 
            this.Backgroundbtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Backgroundbtn.Image = ((System.Drawing.Image)(resources.GetObject("Backgroundbtn.Image")));
            this.Backgroundbtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Backgroundbtn.Name = "Backgroundbtn";
            this.Backgroundbtn.Size = new System.Drawing.Size(26, 22);
            this.Backgroundbtn.Text = "BG";
            this.Backgroundbtn.Click += new System.EventHandler(this.Backgroundbtn_Click);
            // 
            // rtb1
            // 
            this.rtb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rtb1.Location = new System.Drawing.Point(0, 53);
            this.rtb1.Name = "rtb1";
            this.rtb1.Size = new System.Drawing.Size(496, 495);
            this.rtb1.TabIndex = 2;
            this.rtb1.Text = "";
            this.rtb1.TextChanged += new System.EventHandler(this.rtb1_TextChanged);
            this.rtb1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.rtb1_MouseUp);
            // 
            // KlikKanan
            // 
            this.KlikKanan.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.KlikKanan.Name = "contextMenuStrip1";
            this.KlikKanan.Size = new System.Drawing.Size(159, 92);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.cutToolStripMenuItem.Text = "Cut          Ctrl+X";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.cutToolStripMenuItem_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.copyToolStripMenuItem.Text = "Copy       Ctrl+C";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.pasteToolStripMenuItem.Text = "Paste       Ctrl+P";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.deleteToolStripMenuItem.Text = "Delete      Del";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 548);
            this.Controls.Add(this.rtb1);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.KlikKanan.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem New;
        private System.Windows.Forms.ToolStripMenuItem Open;
        private System.Windows.Forms.ToolStripMenuItem Save;
        private System.Windows.Forms.ToolStripMenuItem Exit;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
        private System.Windows.Forms.ToolStripMenuItem Editor;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripLabel SizeLabel;
        private System.Windows.Forms.ToolStripComboBox fontsize;
        private System.Windows.Forms.ToolStripButton Boldbtn;
        private System.Windows.Forms.ToolStripButton Italicbtn;
        private System.Windows.Forms.ToolStripButton Underlinebtn;
        private System.Windows.Forms.ToolStripLabel FontFamilyLabel;
        private System.Windows.Forms.ToolStripComboBox fontfamily;
        private System.Windows.Forms.ToolStripButton Colorbtn;
        private System.Windows.Forms.ToolStripButton Backgroundbtn;
        public System.Windows.Forms.RichTextBox rtb1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ContextMenuStrip KlikKanan;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    }
}