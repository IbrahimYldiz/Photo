using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Photo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string resim;
        private void BtnResimSec_Click(object sender, EventArgs e)
        {
            // OpenFileDialog fileDialog = new OpenFileDialog();
            // fileDialog.Filter = "PNG |*.png| Resim Dosyası|*.png";
            openFileDialog1.Title = "Resim Seç";
            openFileDialog1.FileName = "Resim Seç";
            openFileDialog1.Filter = "Jpeg (*.jpeg)|*.jpeg|Jpg (*.jpg)|*.jpg|PNG (*.png)|*.png";
            openFileDialog1.ShowDialog();
            resim = openFileDialog1.FileName;

            
        }
        Color color;
        private void BtnRenkSec_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            color = colorDialog1.Color;
        }
        Bitmap bitmap;
        private void BtnYazdir_Click(object sender, EventArgs e)
        {
            if (TxtBoyut.Text.Trim() != "" && TxtMetin.Text.Trim() != "")
            {
                bitmap = new Bitmap(resim);
                Graphics gr = Graphics.FromImage(bitmap);
                gr.DrawString(TxtMetin.Text, new Font("Microsoft Sans Serif", Convert.ToInt16(TxtBoyut.Text), FontStyle.Bold), new SolidBrush(color), 50, 60);
                pictureBox1.Image = bitmap;
            }
            else
            {
                MessageBox.Show("Lütfen Girmek İstediğiniz Yazıyı Giriniz ve Yazı Boyutunu Giriniz");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

           
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Title = "Resim Kaydet";
            saveFileDialog1.FileName = "Resim Kaydet";
            saveFileDialog1.Filter = "Jpeg (*.jpeg)|*.jpeg|Jpg (*.jpg)|*.jpg|PNG (*.png)|*.png";
            saveFileDialog1.ShowDialog();
            bitmap.Save(saveFileDialog1.FileName);
        }
    }
}
