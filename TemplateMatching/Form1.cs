using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemplateMatching
{
    public partial class TemplateMatching : Form
    {
        Bitmap objBitmapA, objBitmapI, objBitmapU, 
            objBitmapE, objBitmapO, objBitmapNew;
        int[,] CitraA = new int[100, 100];  
        int[,] CitraI = new int[100, 100];
        int[,] CitraU = new int[100, 100];
        int[,] CitraE = new int[100, 100];
        int[,] CitraO = new int[100, 100];
        int[,] CitraNew = new int[100, 100];
        double dA, dI, dU, dE, dO;
        public TemplateMatching()
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
            objBitmapU = objBitmapU = LoadImage(objBitmapU, pictureBox3);
        }

        private void BtnLoadE_Click(object sender, EventArgs e)
        {
            objBitmapE = LoadImage(objBitmapE, pictureBox4);
        }

        private void BtnLoadO_Click(object sender, EventArgs e)
        {
            objBitmapO = LoadImage(objBitmapO, pictureBox5);
        }

        private void BtnLoadNew_Click(object sender, EventArgs e)
        {
            objBitmapNew = LoadImage(objBitmapNew, pictureBox6);
        }

        private void EkstraksiCitra(Bitmap objBitmap, int[,] Citra)
        {
            for (int x = 0; x < objBitmap.Width; x++)
                for (int y = 0; y < objBitmap.Height; y++)
                {
                    Color wc = objBitmap.GetPixel(x, y);
                    int wcr = wc.R;
                    int wcg = wc.G;
                    int wcb = wc.B;
                    int c = (int)((wcr + wcg + wcb) / 3);
                    Citra[x, y] = (int)c;
                }
        }

        private void BtnJarak_Click(object sender, EventArgs e)
        {
            EkstraksiCitra(objBitmapA, CitraA);
            EkstraksiCitra(objBitmapI, CitraI);
            EkstraksiCitra(objBitmapU, CitraU);
            EkstraksiCitra(objBitmapE, CitraE);
            EkstraksiCitra(objBitmapO, CitraO);
            EkstraksiCitra(objBitmapNew, CitraNew);

            dA = 0; dI = 0; dU = 0; dE = 0; dO = 0;
            for (int x = 0; x < objBitmapNew.Width; x++)
                for (int y = 0; y < objBitmapNew.Height; y++)
                {
                    dA = dA + ((CitraA[x, y] - CitraNew[x, y]) * (CitraA[x, y] - CitraNew[x, y]));
                    dI = dI + ((CitraI[x, y] - CitraNew[x, y]) * (CitraI[x, y] - CitraNew[x, y]));
                    dU = dU + ((CitraU[x, y] - CitraNew[x, y]) * (CitraU[x, y] - CitraNew[x, y]));
                    dE = dE + ((CitraE[x, y] - CitraNew[x, y]) * (CitraE[x, y] - CitraNew[x, y]));
                    dO = dO + ((CitraO[x, y] - CitraNew[x, y]) * (CitraO[x, y] - CitraNew[x, y]));
                }
            dA = Math.Sqrt(dA); dI = Math.Sqrt(dI); dU = Math.Sqrt(dU); dE = Math.Sqrt(dE); dO = Math.Sqrt(dO);
            textBoxA.Text = dA.ToString(); 
            textBoxI.Text = dI.ToString(); 
            textBoxU.Text = dU.ToString();
            textBoxE.Text = dE.ToString();
            textBoxO.Text = dO.ToString();
        }
    }
}
