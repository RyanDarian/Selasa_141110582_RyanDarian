using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.Drawing.Text;

namespace Latihan_5_1
{
    public partial class Form2 : Form
    {
        Form1 main = (Form1)Form1.ActiveForm;
        public Form2()
        {
            InitializeComponent();
            Color warna = new Color();
            PropertyInfo[] p = warna.GetType().GetProperties();

            BGColor.DrawMode = DrawMode.OwnerDrawFixed;

            foreach (PropertyInfo c in p)
            {
                if (c.PropertyType == typeof(System.Drawing.Color))
                {
                    BGColor.Items.Add(c.Name);
                }
            }
            this.BGColor.DrawItem += new DrawItemEventHandler(BGColor_DItem);
        }

        private void BGColor_DItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index >= 0)
            {
                Graphics g = e.Graphics;
                Brush brush = new SolidBrush(e.BackColor);
                Brush tBrush = new SolidBrush(e.ForeColor);

                g.FillRectangle(brush, e.Bounds);
                string s = (string)this.BGColor.Items[e.Index].ToString();
                SolidBrush b = new SolidBrush(Color.FromName(s));
                e.Graphics.DrawRectangle(Pens.Black, 2, e.Bounds.Top + 1, 20, 11);
                e.Graphics.FillRectangle(b, 3, e.Bounds.Top + 2, 19, 10);
                e.Graphics.DrawString(s, this.Font, Brushes.Black, 25, e.Bounds.Top);
                brush.Dispose();
                tBrush.Dispose();
            }
            e.DrawFocusRectangle();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            BGColor.Text = main.rtb1.BackColor.Name;
            treeView1.SelectedNode = treeView1.Nodes[0].Nodes[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            main.backColor = BGColor.Text;
            this.Dispose();
            main.rtb1.BringToFront();
            main.rtb1.Focus();
            main.rtb1.SelectionStart = main.rtb1.SelectionLength;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
            main.rtb1.BringToFront();
            main.rtb1.Focus();
            main.rtb1.SelectionStart = main.rtb1.SelectionLength;
        }
    }
}
