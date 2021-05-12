using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3._12_Steerable_filters
{
    public partial class frame : Form
    {
        Bitmap image_bitmap;

        public frame()
        {
            InitializeComponent();
        }

        private void Load_image(object sender, EventArgs e)
        {
            try
            {
                System.Windows.Forms.OpenFileDialog dlg = new System.Windows.Forms.OpenFileDialog();
                dlg.FileName = "Document";
                dlg.DefaultExt = ".jpg";
                dlg.Filter = "Text documents (.jpg)|*.jpg";

                DialogResult result = dlg.ShowDialog();

                string filename = dlg.FileName;

                image_bitmap = new Bitmap(filename);

                img_main.Image = image_bitmap;

            }
            catch { }
        }

        private void Gaussian_d1(object sender, EventArgs e)
        {
            int new_size = 10;
            double[,] new_gau = Gaussian(new_size, 2);

            string str = "";

            for (int i = 0; i < new_size; i++)
            {
                for (int j = 0; j < new_size; j++)
                {
                    str += Math.Round(new_gau[i, j], 4) + " ";
                }
                str += "\r\n";
            }

            MessageBox.Show(str);
        }

        public double[,] Gaussian(int size, double sigma)
        {
            double[,] gauss = new double[size, size];

            int mid = size / 2;
            //MessageBox.Show(mid.ToString());

            for (int x = 0; x < size; x++)
            {
                for (int y = 0; y < size; y++)
                {
                    gauss[x, y] = (1 / (2 * Math.PI * Math.Pow(sigma, 2))) * 
                        Math.Pow(Math.E, -(Math.Pow(x - mid, 2) + Math.Pow(y - mid, 2)) / (2 * Math.Pow(sigma, 2)));
                }
            }

            return gauss;
        }

        private void Frame_Load(object sender, EventArgs e)
        {

        }
    }
}
