namespace BitirmeProjesi
{
    partial class Raporlar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Raporlar));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnYuksekLisansYurtDisi = new System.Windows.Forms.Button();
            this.btnYuksekLisans = new System.Windows.Forms.Button();
            this.btnDoktoraTurkiye = new System.Windows.Forms.Button();
            this.btnDoktoraYurtdisi = new System.Windows.Forms.Button();
            this.btnDoktoraYapan = new System.Windows.Forms.Button();
            this.btnYuksekLisansTurkiye = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1070, 133);
            this.panel1.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Red;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(3, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1064, 30);
            this.panel2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(429, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Rapor Alma Sayfası";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(112, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(354, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "MEZUN BİLGİ SİSTEMİ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(103, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnYuksekLisansYurtDisi);
            this.groupBox1.Controls.Add(this.btnYuksekLisans);
            this.groupBox1.Controls.Add(this.btnDoktoraTurkiye);
            this.groupBox1.Controls.Add(this.btnDoktoraYurtdisi);
            this.groupBox1.Controls.Add(this.btnDoktoraYapan);
            this.groupBox1.Controls.Add(this.btnYuksekLisansTurkiye);
            this.groupBox1.Location = new System.Drawing.Point(15, 152);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(290, 319);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Eğitim Bilgileri Raporlar";
            // 
            // btnYuksekLisansYurtDisi
            // 
            this.btnYuksekLisansYurtDisi.Location = new System.Drawing.Point(6, 165);
            this.btnYuksekLisansYurtDisi.Name = "btnYuksekLisansYurtDisi";
            this.btnYuksekLisansYurtDisi.Size = new System.Drawing.Size(266, 23);
            this.btnYuksekLisansYurtDisi.TabIndex = 5;
            this.btnYuksekLisansYurtDisi.Text = "Yurt Dışında Yüksek Lisans Yapan Öğrencileri Listele";
            this.btnYuksekLisansYurtDisi.UseVisualStyleBackColor = true;
            this.btnYuksekLisansYurtDisi.Click += new System.EventHandler(this.btnYuksekLisansYurtDisi_Click);
            // 
            // btnYuksekLisans
            // 
            this.btnYuksekLisans.Location = new System.Drawing.Point(6, 107);
            this.btnYuksekLisans.Name = "btnYuksekLisans";
            this.btnYuksekLisans.Size = new System.Drawing.Size(266, 23);
            this.btnYuksekLisans.TabIndex = 4;
            this.btnYuksekLisans.Text = "Yüksek Lisans Yapan Öğrencileri Listele";
            this.btnYuksekLisans.UseVisualStyleBackColor = true;
            this.btnYuksekLisans.Click += new System.EventHandler(this.btnYuksekLisans_Click);
            // 
            // btnDoktoraTurkiye
            // 
            this.btnDoktoraTurkiye.Location = new System.Drawing.Point(6, 49);
            this.btnDoktoraTurkiye.Name = "btnDoktoraTurkiye";
            this.btnDoktoraTurkiye.Size = new System.Drawing.Size(266, 23);
            this.btnDoktoraTurkiye.TabIndex = 3;
            this.btnDoktoraTurkiye.Text = "Türkiye\'de Doktora Yapan Öğrencileri Listele";
            this.btnDoktoraTurkiye.UseVisualStyleBackColor = true;
            this.btnDoktoraTurkiye.Click += new System.EventHandler(this.btnDoktoraTurkiye_Click);
            // 
            // btnDoktoraYurtdisi
            // 
            this.btnDoktoraYurtdisi.Location = new System.Drawing.Point(6, 78);
            this.btnDoktoraYurtdisi.Name = "btnDoktoraYurtdisi";
            this.btnDoktoraYurtdisi.Size = new System.Drawing.Size(266, 23);
            this.btnDoktoraYurtdisi.TabIndex = 2;
            this.btnDoktoraYurtdisi.Text = "Yurtdışında Doktora Yapan Öğrencileri Listele";
            this.btnDoktoraYurtdisi.UseVisualStyleBackColor = true;
            this.btnDoktoraYurtdisi.Click += new System.EventHandler(this.btnDoktoraYurtdisi_Click);
            // 
            // btnDoktoraYapan
            // 
            this.btnDoktoraYapan.Location = new System.Drawing.Point(6, 20);
            this.btnDoktoraYapan.Name = "btnDoktoraYapan";
            this.btnDoktoraYapan.Size = new System.Drawing.Size(266, 23);
            this.btnDoktoraYapan.TabIndex = 1;
            this.btnDoktoraYapan.Text = "Doktora Yapan Öğrencileri Listele";
            this.btnDoktoraYapan.UseVisualStyleBackColor = true;
            this.btnDoktoraYapan.Click += new System.EventHandler(this.btnDoktoraYapan_Click);
            // 
            // btnYuksekLisansTurkiye
            // 
            this.btnYuksekLisansTurkiye.Location = new System.Drawing.Point(6, 136);
            this.btnYuksekLisansTurkiye.Name = "btnYuksekLisansTurkiye";
            this.btnYuksekLisansTurkiye.Size = new System.Drawing.Size(266, 23);
            this.btnYuksekLisansTurkiye.TabIndex = 0;
            this.btnYuksekLisansTurkiye.Text = "Türkiye\'de Yüksek Lisans Yapan Öğrencileri Listele";
            this.btnYuksekLisansTurkiye.UseVisualStyleBackColor = true;
            this.btnYuksekLisansTurkiye.Click += new System.EventHandler(this.btnYuksekLisansTurkiye_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.Location = new System.Drawing.Point(311, 152);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(771, 319);
            this.dataGridView1.TabIndex = 14;
            // 
            // Raporlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 483);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Raporlar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Raporlar";
            this.Load += new System.EventHandler(this.Raporlar_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnYuksekLisansYurtDisi;
        private System.Windows.Forms.Button btnYuksekLisans;
        private System.Windows.Forms.Button btnDoktoraTurkiye;
        private System.Windows.Forms.Button btnDoktoraYurtdisi;
        private System.Windows.Forms.Button btnDoktoraYapan;
        private System.Windows.Forms.Button btnYuksekLisansTurkiye;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}