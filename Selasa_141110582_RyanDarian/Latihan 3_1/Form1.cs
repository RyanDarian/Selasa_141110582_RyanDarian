﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan_3_1
{
    public partial class Form1 : Form
    {
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

        private void FontSize_Click(object sender, EventArgs e)
        {

        }

        private void BoldBtn_Click(object sender, EventArgs e)
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
                BoldBtn.BackColor = System.Drawing.SystemColors.ButtonShadow;
            }
            else
                BoldBtn.BackColor = System.Drawing.Color.Transparent;
            rtb1.SelectionFont = new Font(choosed.FontFamily, choosed.Size, currentFont);
        }

        private void ItalicBtn_Click(object sender, EventArgs e)
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
                ItalicBtn.BackColor = System.Drawing.SystemColors.ButtonShadow;
            }
            else
                ItalicBtn.BackColor = System.Drawing.Color.Transparent;
            rtb1.SelectionFont = new Font(choosed.FontFamily, choosed.Size, currentFont);
        }

        private void UnderlineBtn_Click(object sender, EventArgs e)
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
                UnderlineBtn.BackColor = System.Drawing.SystemColors.ButtonShadow;
            }
            else
                UnderlineBtn.BackColor = System.Drawing.Color.Transparent;
            rtb1.SelectionFont = new Font(choosed.FontFamily, choosed.Size, currentFont);
        }

        private void ColorBtn_Click(object sender, EventArgs e)
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
    }
}
