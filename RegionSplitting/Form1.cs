using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegionSplitting
{
    public partial class RegionSplitting : Form
    {
        Bitmap objBitmapA, objBitmapI, objBitmapU,
            objBitmapE, objBitmapO, objBitmapBaru;
        int[,] MatriksA = new int[100, 100];
        int[,] MatriksI = new int[100, 100];
        int[,] MatriksU = new int[100, 100];
        int[,] MatriksE = new int[100, 100];
        int[,] MatriksO = new int[100, 100];
        int[,] MatriksBaru = new int[100, 100];
        int selectedMatriks, val;
        int[] reg, regA, regI, regU, regE, regO, regBaru;
        double dA, dI, dU, dE, dO;
        public RegionSplitting()
        {
            InitializeComponent();
        }

        private Bitmap LoadImage(Bitmap objBitmap, PictureBox pictureBox)
        {
            DialogResult d = openFileDialog1.ShowDialog();
            if (d == DialogResult.OK)
            {
                objBitmap = new Bitmap(openFileDialog1.FileName);
                pictureBox.Image = objBitmap;
            }
            return objBitmap;
        }

        private void BtnLoadA_Click(object sender, EventArgs e)
        {
            objBitmapA = LoadImage(objBitmapA, pictureBox1);
        }

        private void BtnLoadI_Click(object sender, EventArgs e)
        {
            objBitmapI = LoadImage(objBitmapI, pictureBox2);
        }

        private void BtnLoadU_Click(object sender, EventArgs e)
        {
            objBitmapU = LoadImage(objBitmapU, pictureBox3);
        }

        private void BtnLoadE_Click(object sender, EventArgs e)
        {
            objBitmapE = LoadImage(objBitmapE, pictureBox4);
        }

        private void BtnLoadO_Click(object sender, EventArgs e)
        {
            objBitmapO = LoadImage(objBitmapO, pictureBox5);
        }

        private void BtnLoadBaru_Click(object sender, EventArgs e)
        {
            objBitmapBaru = LoadImage(objBitmapBaru, pictureBox6);
        }

        private int[,] MatriksBiner(Bitmap objBitmap, int[,] Matriks, DataGridView dataGridView)
        {
            for (int x = 0; x < objBitmap.Width; x++)
                for (int y = 0; y < objBitmap.Height; y++)
                {
                    Color w = objBitmap.GetPixel(x, y);
                    int wr = w.R;
                    int wg = w.G;
                    int wb = w.B;
                    int c = (int)((wr + wg + wb) / 3);
                    if (c > 127)
                        c = 0;
                    else
                        c = 255;
                    c = (int)c / 255;
                    Matriks[x, y] = c;
                }

            for (int i = 0; i < objBitmap.Width; i++)
            {
                DataGridViewColumn newCol = new DataGridViewColumn();
                DataGridViewCell cell = new DataGridViewTextBoxCell();
                newCol.CellTemplate = cell;
                newCol.HeaderText = (i + 1).ToString();
                newCol.Name = "Oke";
                newCol.Visible = true;
                newCol.Width = 100;
                dataGridView.Columns.Add(newCol);
                dataGridView.Rows.Add(cell);
            }
            dataGridView.Rows.Add(objBitmap.Height);

            for (int i = 0; i < objBitmap.Height; i++)
                for (int j = 0; j < objBitmap.Width; j++)
                    dataGridView.Rows[i].Cells[j].Value = Matriks[j, i].ToString();

            return Matriks;
        }

        private void BtnMatriksA_Click(object sender, EventArgs e)
        {
            MatriksA = MatriksBiner(objBitmapA, MatriksA, dataGridView1);
        }

        private void BtnMatriksI_Click(object sender, EventArgs e)
        {
            MatriksI = MatriksBiner(objBitmapI, MatriksI, dataGridView2);
        }

        private void BtnMatriksU_Click(object sender, EventArgs e)
        {
            MatriksU = MatriksBiner(objBitmapU, MatriksU, dataGridView3);
        }

        private void BtnMatriksE_Click(object sender, EventArgs e)
        {
            MatriksE = MatriksBiner(objBitmapE, MatriksE, dataGridView4);
        }

        private void BtnMatriksO_Click(object sender, EventArgs e)
        {
            MatriksO = MatriksBiner(objBitmapO, MatriksO, dataGridView5);
        }

        private void BtnMatriksBaru_Click(object sender, EventArgs e)
        {
            MatriksBaru = MatriksBiner(objBitmapBaru, MatriksBaru, dataGridView11);
        }

        private int[] RegionSplit(int[,] Matriks, int row, DataGridView dataGridView)
        {
            if (row == 2)
                reg = new int[4];
            else if (row == 5)
                reg = new int[25];

            int count = 0; int bb = 0; int ba = val;
            for (int i = 0; i < row; i++)
            {
                int kb = 0; int ka = val; int sum = 0;
                for (int j = 0; j < row; j++)
                {
                    DataGridViewColumn newCol = new DataGridViewColumn();
                    DataGridViewCell cell = new DataGridViewTextBoxCell();
                    newCol.CellTemplate = cell;
                    newCol.Name = "Column";
                    newCol.Visible = true;
                    
                    dataGridView.Columns.Add(newCol);
                    dataGridView.Rows.Add();
                    for (int x = bb; x < ba; x++)
                        for (int y = kb; y < ka; y++)
                            sum = sum + Matriks[x, y];
                    reg[count] = sum;
                    dataGridView[i, j].Value = reg[count].ToString();
                    kb = ka + 1;
                    ka = ka + val;
                    count = count + 1;
                    sum = 0;
                }
                bb = ba + 1;
                ba = ba + val;
            }
            return reg;
        }

        private void BtnRegionSplittingA_Click(object sender, EventArgs e)
        {
            regA = RegionSplit(MatriksA, selectedMatriks, dataGridView6);
        }

        private void BtnRegionSplittingI_Click(object sender, EventArgs e)
        {
            regI = RegionSplit(MatriksI, selectedMatriks, dataGridView7);
        }

        private void BtnRegionSplittingU_Click(object sender, EventArgs e)
        {
            regU = RegionSplit(MatriksU, selectedMatriks, dataGridView8);
        }

        private void BtnRegionSplittingE_Click(object sender, EventArgs e)
        {
            regE = RegionSplit(MatriksE, selectedMatriks, dataGridView9);
        }

        private void BtnRegionSplittingO_Click(object sender, EventArgs e)
        {
            regO = RegionSplit(MatriksO, selectedMatriks, dataGridView10);
        }

        private void BtnRegionSplittingBaru_Click(object sender, EventArgs e)
        {
            regBaru = RegionSplit(MatriksBaru, selectedMatriks, dataGridView12);
        }

        private void comboBoxMatriks_SelectedIndexChanged(object sender, EventArgs e)
        {
            String matriksSelected = comboBoxMatriks.SelectedItem.ToString();

            if (matriksSelected == "Matriks 2X2")
            {
                label1.Text = matriksSelected;
                selectedMatriks = 2;
                val = 40;
            }
            else if (matriksSelected == "Matriks 5X5")
            {
                label1.Text = matriksSelected;
                selectedMatriks = 5;
                val = 20;
            }
        }

        private void BtnJarak_Click(object sender, EventArgs e)
        {
            dA = 0; dI = 0; dU = 0; dE = 0; dO = 0;
            for (int i = 0; i < reg.Length; i++)
            {
                dA = dA + ((regA[i] - regBaru[i]) * (regA[i] - regBaru[i]));
                dI = dI + ((regI[i] - regBaru[i]) * (regI[i] - regBaru[i]));
                dU = dU + ((regU[i] - regBaru[i]) * (regU[i] - regBaru[i]));
                dE = dE + ((regE[i] - regBaru[i]) * (regE[i] - regBaru[i]));
                dO = dO + ((regO[i] - regBaru[i]) * (regO[i] - regBaru[i]));
            }
            dA = Math.Sqrt(dA); dI = Math.Sqrt(dI); dU = Math.Sqrt(dU); dE = Math.Sqrt(dE); dO = Math.Sqrt(dO);
            textBox1.Text = dA.ToString();
            textBox2.Text = dI.ToString();
            textBox3.Text = dU.ToString();
            textBox4.Text = dE.ToString();
            textBox5.Text = dO.ToString();
        }
    }
}
