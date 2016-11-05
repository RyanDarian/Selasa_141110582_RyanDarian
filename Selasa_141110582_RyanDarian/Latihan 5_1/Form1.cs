using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan_5_1
{
    public partial class Form1 : Form
    {
        Form2 Form2;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (FontFamily fontType in FontFamily.Families)
            {
                fontfamily.Items.Add(fontType.Name.ToString());
            }

            for (int i = 8; i <= 73; i += 2)
            {
                fontsize.Items.Add(i);
            }
            fontsize.SelectedIndex = 2;
            fontfamily.Text = "Times New Roman";
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            ((RichTextBox)sender).Tag = "true";
        }

        private void Boldbtn_Click(object sender, EventArgs e)
        {
            System.Drawing.Font choosed = rtb1.SelectionFont;
            System.Drawing.FontStyle currentFont = FontStyle.Regular;
            if (rtb1.SelectionFont.Italic == true && rtb1.SelectionFont.Underline == true)
                currentFont = FontStyle.Italic | FontStyle.Underline;
            else if (rtb1.SelectionFont.Italic == true)
                currentFont = FontStyle.Italic;
            else if (rtb1.SelectionFont.Underline == true)
                currentFont = FontStyle.Underline;

            if (rtb1.SelectionFont.Bold != true)
            {
                currentFont |= FontStyle.Bold;
                Boldbtn.BackColor = System.Drawing.SystemColors.ButtonShadow;
            }
            else
                Boldbtn.BackColor = System.Drawing.Color.Transparent;
            rtb1.SelectionFont = new Font(choosed.FontFamily, choosed.Size, currentFont);
        }

        private void Italicbtn_Click(object sender, EventArgs e)
        {
            System.Drawing.Font choosed = rtb1.SelectionFont;
            System.Drawing.FontStyle currentFont = FontStyle.Regular;
            if (rtb1.SelectionFont.Bold == true && rtb1.SelectionFont.Underline == true)
                currentFont = FontStyle.Bold | FontStyle.Underline;
            else if (rtb1.SelectionFont.Bold == true)
                currentFont = FontStyle.Bold;
            else if (rtb1.SelectionFont.Underline == true)
                currentFont = FontStyle.Underline;

            if (rtb1.SelectionFont.Italic != true)
            {
                currentFont |= FontStyle.Italic;
                Italicbtn.BackColor = System.Drawing.SystemColors.ButtonShadow;
            }
            else
                Italicbtn.BackColor = System.Drawing.Color.Transparent;
            rtb1.SelectionFont = new Font(choosed.FontFamily, choosed.Size, currentFont);
        }

        private void Underlinebtn_Click(object sender, EventArgs e)
        {
            System.Drawing.Font choosed = rtb1.SelectionFont;
            System.Drawing.FontStyle currentFont = FontStyle.Regular;
            if (rtb1.SelectionFont.Bold == true && rtb1.SelectionFont.Italic == true)
                currentFont = FontStyle.Bold | FontStyle.Italic;
            else if (rtb1.SelectionFont.Bold == true)
                currentFont = FontStyle.Bold;
            else if (rtb1.SelectionFont.Italic == true)
                currentFont = FontStyle.Italic;

            if (rtb1.SelectionFont.Underline != true)
            {
                currentFont |= FontStyle.Underline;
                Underlinebtn.BackColor = System.Drawing.SystemColors.ButtonShadow;
            }
            else
                Underlinebtn.BackColor = System.Drawing.Color.Transparent;
            rtb1.SelectionFont = new Font(choosed.FontFamily, choosed.Size, currentFont);
        }

        private void Colorbtn_Click(object sender, EventArgs e)
        {
            DialogResult Warna = colorDialog1.ShowDialog();
            if (Warna == DialogResult.OK)
            {
                rtb1.SelectionColor = colorDialog1.Color;
            }
        }

        private void fontsize_SelectedIndexChanged(object sender, EventArgs e)
        {
            rtb1.SelectionFont = new Font(rtb1.SelectionFont.FontFamily, int.Parse(fontsize.SelectedItem.ToString()));
        }

        private void fontfamily_SelectedIndexChanged(object sender, EventArgs e)
        {
            rtb1.SelectionFont = new Font(fontfamily.SelectedItem.ToString(), rtb1.SelectionFont.Size);
        }

        private void Backgroundbtn_Click(object sender, EventArgs e)
        {
            DialogResult Warna = colorDialog1.ShowDialog();
            if (Warna == DialogResult.OK)
            {
                rtb1.SelectionBackColor = colorDialog1.Color;
            }
        }

        private void rtb1_TextChanged(object sender, EventArgs e)
        {
            ((RichTextBox)sender).Tag = "true";
        }

        private void New_Click(object sender, EventArgs e)
        {
            if (rtb1.Tag == "true")
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*|Rich Textbox Format (*.rtf)|*.rtf";
                save.FilterIndex = 3;
                save.RestoreDirectory = true;

                DialogResult result = MessageBox.Show("Do you want to save changes ?", "First Application", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {
                    if (save.ShowDialog() == System.Windows.Forms.DialogResult.OK && save.FileName.Length > 0)
                    {
                        rtb1.SaveFile(save.FileName, RichTextBoxStreamType.PlainText);
                    }
                    ActiveForm.Hide();
                    Form1 newform = new Form1();
                    newform.ShowDialog();
                }
                else if (result == DialogResult.No)
                {
                    ActiveForm.Hide();
                    Form1 newform = new Form1();
                    newform.ShowDialog();
                }
            }
            else
            {
                ActiveForm.Hide();
                Form1 newform = new Form1();
                newform.ShowDialog();
            }
        }

        private void Open_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.InitialDirectory = "c:\\";
            open.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*|Rich Textbox Format (*.rtf)|*.rtf";
            open.FilterIndex = 3;
            open.RestoreDirectory = true;

            if (open.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                rtb1.LoadFile(open.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*|Rich Textbox Format (*.rtf)|*.rtf";
            save.FilterIndex = 3;
            save.RestoreDirectory = true;

            if (save.ShowDialog() == System.Windows.Forms.DialogResult.OK && save.FileName.Length > 0)
            {
                rtb1.SaveFile(save.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            if (rtb1.Tag == "true")
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*|Rich Textbox Format (*.rtf)|*.rtf";
                save.FilterIndex = 3;
                save.RestoreDirectory = true;

                DialogResult result = MessageBox.Show("Do you want to save changes ?", "First Application", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {
                    if (save.ShowDialog() == System.Windows.Forms.DialogResult.OK && save.FileName.Length > 0)
                    {
                        rtb1.SaveFile(save.FileName, RichTextBoxStreamType.PlainText);
                    }
                }
                else if (result == DialogResult.No)
                {
                    Application.ExitThread();
                }
            }
            else
            {
                Application.Exit();
            }
        }

        public string backColor
        {
            get { return rtb1.BackColor.Name; }
            set { rtb1.BackColor = Color.FromName(value); }
        }

        private void Editor_Click(object sender, EventArgs e)
        {
            if (Form2 == null || !Form2.IsHandleCreated)
            {
                Form2 = new Form2();
                Form2.MdiParent = this;
                rtb1.SendToBack();
                Form2.BringToFront();
            }
            Form2.Show();
        }

        private void rtb1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.KlikKanan.Show(this, e.X, e.Y);
                if (rtb1.SelectionLength == 0)
                {
                    KlikKanan.Items[0].Enabled = false;
                    KlikKanan.Items[2].Enabled = false;
                }
                else
                {
                    KlikKanan.Items[0].Enabled = true;
                    KlikKanan.Items[2].Enabled = true;
                }
            }
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtb1.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtb1.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtb1.Paste();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtb1.SelectedText = "";
        }

        


    }
}
