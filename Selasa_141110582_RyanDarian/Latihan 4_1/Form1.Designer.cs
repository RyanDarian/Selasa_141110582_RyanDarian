namespace Latihan_3_1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.SizeLabel = new System.Windows.Forms.ToolStripLabel();
            this.fontsize = new System.Windows.Forms.ToolStripComboBox();
            this.BoldBtn = new System.Windows.Forms.ToolStripButton();
            this.ItalicBtn = new System.Windows.Forms.ToolStripButton();
            this.UnderlineBtn = new System.Windows.Forms.ToolStripButton();
            this.FontFamilyLabel = new System.Windows.Forms.ToolStripLabel();
            this.fontfamily = new System.Windows.Forms.ToolStripComboBox();
            this.ColorBtn = new System.Windows.Forms.ToolStripButton();
            this.Backgroundbtn = new System.Windows.Forms.ToolStripButton();
            this.rtb1 = new System.Windows.Forms.RichTextBox();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.New = new System.Windows.Forms.ToolStripMenuItem();
            this.Open = new System.Windows.Forms.ToolStripMenuItem();
            this.Save = new System.Windows.Forms.ToolStripMenuItem();
            this.Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SizeLabel,
            this.fontsize,
            this.BoldBtn,
            this.ItalicBtn,
            this.UnderlineBtn,
            this.FontFamilyLabel,
            this.fontfamily,
            this.ColorBtn,
            this.Backgroundbtn});
            this.toolStrip1.Location = new System.Drawing.Point(0, 25);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(525, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
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
            this.fontsize.Size = new System.Drawing.Size(75, 25);
            this.fontsize.SelectedIndexChanged += new System.EventHandler(this.fontsize_SelectedIndexChanged);
            this.fontsize.Click += new System.EventHandler(this.FontSize_Click);
            // 
            // BoldBtn
            // 
            this.BoldBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BoldBtn.Image = ((System.Drawing.Image)(resources.GetObject("BoldBtn.Image")));
            this.BoldBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BoldBtn.Name = "BoldBtn";
            this.BoldBtn.Size = new System.Drawing.Size(23, 22);
            this.BoldBtn.Text = "B";
            this.BoldBtn.Click += new System.EventHandler(this.BoldBtn_Click);
            // 
            // ItalicBtn
            // 
            this.ItalicBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ItalicBtn.Image = ((System.Drawing.Image)(resources.GetObject("ItalicBtn.Image")));
            this.ItalicBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ItalicBtn.Name = "ItalicBtn";
            this.ItalicBtn.Size = new System.Drawing.Size(23, 22);
            this.ItalicBtn.Text = "I";
            this.ItalicBtn.Click += new System.EventHandler(this.ItalicBtn_Click);
            // 
            // UnderlineBtn
            // 
            this.UnderlineBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.UnderlineBtn.Image = ((System.Drawing.Image)(resources.GetObject("UnderlineBtn.Image")));
            this.UnderlineBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.UnderlineBtn.Name = "UnderlineBtn";
            this.UnderlineBtn.Size = new System.Drawing.Size(23, 22);
            this.UnderlineBtn.Text = "U";
            this.UnderlineBtn.Click += new System.EventHandler(this.UnderlineBtn_Click);
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
            // ColorBtn
            // 
            this.ColorBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ColorBtn.Image = ((System.Drawing.Image)(resources.GetObject("ColorBtn.Image")));
            this.ColorBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ColorBtn.Name = "ColorBtn";
            this.ColorBtn.Size = new System.Drawing.Size(23, 22);
            this.ColorBtn.Text = "ColorBtn";
            this.ColorBtn.Click += new System.EventHandler(this.ColorBtn_Click);
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
            this.rtb1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtb1.Location = new System.Drawing.Point(-3, 53);
            this.rtb1.Name = "rtb1";
            this.rtb1.Size = new System.Drawing.Size(528, 431);
            this.rtb1.TabIndex = 1;
            this.rtb1.Text = "";
            this.rtb1.TextChanged += new System.EventHandler(this.rtb1_TextChanged);
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(525, 25);
            this.toolStrip2.TabIndex = 2;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.New,
            this.Open,
            this.Save,
            this.Exit});
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 485);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.rtb1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel SizeLabel;
        private System.Windows.Forms.ToolStripComboBox fontsize;
        private System.Windows.Forms.ToolStripButton BoldBtn;
        private System.Windows.Forms.ToolStripButton ItalicBtn;
        private System.Windows.Forms.ToolStripButton UnderlineBtn;
        private System.Windows.Forms.ToolStripLabel FontFamilyLabel;
        private System.Windows.Forms.ToolStripComboBox fontfamily;
        private System.Windows.Forms.ToolStripButton ColorBtn;
        private System.Windows.Forms.RichTextBox rtb1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem New;
        private System.Windows.Forms.ToolStripMenuItem Open;
        private System.Windows.Forms.ToolStripMenuItem Save;
        private System.Windows.Forms.ToolStripMenuItem Exit;
        private System.Windows.Forms.ToolStripButton Backgroundbtn;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
    }
}

