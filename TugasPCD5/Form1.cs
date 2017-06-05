using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TugasPCD5
{
    public partial class SegmentasiHuruf : Form
    {
        Bitmap objBitmap1, objBitmap2;
        int[,] matriks = new int[100,500];
        int[] koor_absis =  new int[500];
        int[,] koordinat = new int[2, 500];
        String[] koor = {"X", "Y"};
        int x = 0, y = 0;
        int absis = 0;
        public SegmentasiHuruf()
        {
            InitializeComponent();
        }

        private void BtnOpen_Click(object sender, EventArgs e)
        {
            DialogResult d = openFileDialog1.ShowDialog();
            if (d == DialogResult.OK)
            {
                objBitmap1 = new Bitmap(openFileDialog1.FileName);
                pictureBox1.Image = objBitmap1;
            }
        }

        private void BtnDetectPoint_Click(object sender, EventArgs e)
        {
            objBitmap2 = new Bitmap(objBitmap1);
            for (int x = 0; x < objBitmap1.Width; x++)
                for (int y = 0; y < objBitmap1.Height; y++)
                {
                    int sumwr = 0; int sumwg = 0; int sumwb = 0;
                    int[] k = { -1, -1, -1, -1, 8, -1, -1, -1, -1 };
                    if ((x > 0 && y > 0) && (x < objBitmap1.Width - 1 && y < objBitmap1.Height - 1))
                    {
                        int hitung = 0;
                        for (int i = -1; i <= 1; i++)
                            for (int j = -1; j <= 1; j++)
                            {
                                Color w = objBitmap1.GetPixel(x + i, y + j);
                                int wr = k[hitung] * w.R;
                                int wg = k[hitung] * w.G;
                                int wb = k[hitung] * w.B;
                                sumwr += wr; sumwg += wg; sumwb += wb;
                                hitung++;
                            }
                    }
                    int rr = sumwr; int gg = sumwg; int bb = sumwb;
                    if (rr > 255) rr = 255; if (rr < 0) rr = 0;
                    if (gg > 255) gg = 255; if (gg < 0) gg = 0;
                    if (bb > 255) bb = 255; if (bb < 0) bb = 0;
                    int xg = (int)(rr + gg + bb / 3);
                    if (xg > 127) xg = 255;
                    else xg = 0;
                    matriks[x, y] = (int)xg / 255;
                    Color new_w = Color.FromArgb(rr, gg, bb);
                    objBitmap2.SetPixel(x, y, new_w);
                }
            pictureBox2.Image = objBitmap2; 
        }

        private void BtnKoordinat_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < objBitmap2.Width; i++)
            {
                DataGridViewColumn newCol = new DataGridViewColumn();
                DataGridViewCell cell = new DataGridViewTextBoxCell();
                newCol.CellTemplate = cell;
                newCol.HeaderText = (i + 1).ToString();
                newCol.Visible = true;
                newCol.Width = 100;
                dataGridView1.Columns.Add(newCol);
                dataGridView1.Rows.Add(cell);
            }
            dataGridView1.Rows.Add(objBitmap2.Height);
            for (int i = 0; i < objBitmap2.Height; i++)
                for (int j = 0; j < objBitmap2.Width; j++)
                    dataGridView1.Rows[i].Cells[j].Value = matriks[j, i].ToString();
        }

        private void BtnAbsis_Click(object sender, EventArgs e)
        {
            Boolean cek = false;
            for (int i = 0; i < objBitmap2.Height; i++)
            {
                for (int j = 0; j < objBitmap2.Width; j++)
                {
                    if (matriks[j, i] == 1)
                        absis = i;
                    else if (matriks[j, i] == 0)
                        cek = true;
                }
                if (cek && absis != 0)
                    koor_absis[i] = absis;
                absis = 0;
            }
            DataGridViewColumn newCol = new DataGridViewColumn();
            DataGridViewCell cell = new DataGridViewTextBoxCell();
            newCol.CellTemplate = cell;
            newCol.HeaderText = "Koordinat X";
            newCol.Visible = true;
            dataGridView2.Columns.Add(newCol);
            dataGridView2.Rows.Add(cell);
            dataGridView2.Rows.Add(objBitmap2.Height);
            for (int i = 0; i < objBitmap2.Height; i++)
                dataGridView2.Rows[i].Cells[0].Value = koor_absis[i].ToString();
        }
    }
}
