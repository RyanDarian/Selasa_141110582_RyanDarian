namespace Latihan_2_1
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
            this.Tanggal = new System.Windows.Forms.NumericUpDown();
            this.Bulan = new System.Windows.Forms.DomainUpDown();
            this.Tambah = new System.Windows.Forms.Button();
            this.Hapus = new System.Windows.Forms.Button();
            this.Kalender = new System.Windows.Forms.MonthCalendar();
            this.Lahir = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Tanggal)).BeginInit();
            this.SuspendLayout();
            // 
            // Tanggal
            // 
            this.Tanggal.Location = new System.Drawing.Point(14, 17);
            this.Tanggal.Name = "Tanggal";
            this.Tanggal.Size = new System.Drawing.Size(133, 20);
            this.Tanggal.TabIndex = 0;
            this.Tanggal.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Bulan
            // 
            this.Bulan.Location = new System.Drawing.Point(153, 17);
            this.Bulan.Name = "Bulan";
            this.Bulan.Size = new System.Drawing.Size(131, 20);
            this.Bulan.TabIndex = 1;
            this.Bulan.Text = "Bulan";
            // 
            // Tambah
            // 
            this.Tambah.Location = new System.Drawing.Point(290, 14);
            this.Tambah.Name = "Tambah";
            this.Tambah.Size = new System.Drawing.Size(85, 23);
            this.Tambah.TabIndex = 2;
            this.Tambah.Text = "Tambah";
            this.Tambah.UseVisualStyleBackColor = true;
            this.Tambah.Click += new System.EventHandler(this.Tambah_Click);
            // 
            // Hapus
            // 
            this.Hapus.Location = new System.Drawing.Point(381, 14);
            this.Hapus.Name = "Hapus";
            this.Hapus.Size = new System.Drawing.Size(83, 23);
            this.Hapus.TabIndex = 3;
            this.Hapus.Text = "Hapus";
            this.Hapus.UseVisualStyleBackColor = true;
            this.Hapus.Click += new System.EventHandler(this.Hapus_Click);
            // 
            // Kalender
            // 
            this.Kalender.CalendarDimensions = new System.Drawing.Size(2, 2);
            this.Kalender.Location = new System.Drawing.Point(14, 49);
            this.Kalender.Name = "Kalender";
            this.Kalender.TabIndex = 4;
            // 
            // Lahir
            // 
            this.Lahir.AutoSize = true;
            this.Lahir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lahir.Location = new System.Drawing.Point(12, 369);
            this.Lahir.Name = "Lahir";
            this.Lahir.Size = new System.Drawing.Size(161, 20);
            this.Lahir.TabIndex = 5;
            this.Lahir.Text = "Tanggal Lahir : 1 April";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 443);
            this.Controls.Add(this.Lahir);
            this.Controls.Add(this.Kalender);
            this.Controls.Add(this.Hapus);
            this.Controls.Add(this.Tambah);
            this.Controls.Add(this.Bulan);
            this.Controls.Add(this.Tanggal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Tanggal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown Tanggal;
        private System.Windows.Forms.DomainUpDown Bulan;
        private System.Windows.Forms.Button Tambah;
        private System.Windows.Forms.Button Hapus;
        private System.Windows.Forms.MonthCalendar Kalender;
        private System.Windows.Forms.Label Lahir;
    }
}

