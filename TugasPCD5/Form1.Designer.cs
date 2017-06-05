namespace TugasPCD5
{
    partial class SegmentasiHuruf
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
            this.BtnOpen = new System.Windows.Forms.Button();
            this.BtnDetectPoint = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.BtnKoordinat = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnAbsis = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnOpen
            // 
            this.BtnOpen.Location = new System.Drawing.Point(37, 12);
            this.BtnOpen.Name = "BtnOpen";
            this.BtnOpen.Size = new System.Drawing.Size(100, 30);
            this.BtnOpen.TabIndex = 0;
            this.BtnOpen.Text = "Open Image";
            this.BtnOpen.UseVisualStyleBackColor = true;
            this.BtnOpen.Click += new System.EventHandler(this.BtnOpen_Click);
            // 
            // BtnDetectPoint
            // 
            this.BtnDetectPoint.Location = new System.Drawing.Point(173, 12);
            this.BtnDetectPoint.Name = "BtnDetectPoint";
            this.BtnDetectPoint.Size = new System.Drawing.Size(100, 30);
            this.BtnDetectPoint.TabIndex = 1;
            this.BtnDetectPoint.Text = "Deteksi Titik";
            this.BtnDetectPoint.UseVisualStyleBackColor = true;
            this.BtnDetectPoint.Click += new System.EventHandler(this.BtnDetectPoint_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(37, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 500);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(173, 51);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 500);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // BtnKoordinat
            // 
            this.BtnKoordinat.Location = new System.Drawing.Point(311, 12);
            this.BtnKoordinat.Name = "BtnKoordinat";
            this.BtnKoordinat.Size = new System.Drawing.Size(100, 30);
            this.BtnKoordinat.TabIndex = 4;
            this.BtnKoordinat.Text = "Isi Koordinat";
            this.BtnKoordinat.UseVisualStyleBackColor = true;
            this.BtnKoordinat.Click += new System.EventHandler(this.BtnKoordinat_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(311, 51);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(300, 500);
            this.dataGridView1.TabIndex = 5;
            // 
            // BtnAbsis
            // 
            this.BtnAbsis.Location = new System.Drawing.Point(646, 12);
            this.BtnAbsis.Name = "BtnAbsis";
            this.BtnAbsis.Size = new System.Drawing.Size(100, 30);
            this.BtnAbsis.TabIndex = 6;
            this.BtnAbsis.Text = "Koordinat Absis";
            this.BtnAbsis.UseVisualStyleBackColor = true;
            this.BtnAbsis.Click += new System.EventHandler(this.BtnAbsis_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(646, 51);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(150, 500);
            this.dataGridView2.TabIndex = 7;
            // 
            // SegmentasiHuruf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 563);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.BtnAbsis);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtnKoordinat);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnDetectPoint);
            this.Controls.Add(this.BtnOpen);
            this.Name = "SegmentasiHuruf";
            this.Text = "Segmentasi Huruf";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnOpen;
        private System.Windows.Forms.Button BtnDetectPoint;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button BtnKoordinat;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnAbsis;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}

