using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.IO;
using System.Diagnostics;

namespace BlobAnalisys
{
    public partial class MainForm : Form
    {
        public DirectBitmap mainDBmp, binDBmp, gradDXDBmp, gradDYDBmp, gradFDBmp;
        public Stopwatch timer;
        public MainForm()
        {
            InitializeComponent();
            init();
        }

        //not implemented yet
        private void init()
        {
            bin_btn.Enabled = false;
            gradED_btn.Enabled = false;

            timer = new Stopwatch();

            pb1.Click += pb_Click;
            pb2.Click += pb_Click;
            pb3.Click += pb_Click;
            pb4.Click += pb_Click;
        }
        
        private void openImg_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFD = new OpenFileDialog();
            openFD.Filter = "Bitmaps|*.bmp|*.jpeg|*.jpg";

            if (openFD.ShowDialog() == DialogResult.OK)
            {
                timer.Restart();
                using (Bitmap mainBmp = (Bitmap)(Bitmap.FromFile(openFD.FileName)))
                {
                    mainDBmp = new DirectBitmap(mainBmp.Width, mainBmp.Height);
                    for (int y = 0; y < mainBmp.Height; y++)
                    {
                        for (int x = 0; x < mainBmp.Width; x++)
                        {
                            mainDBmp.SetPixel(x, y, mainBmp.GetPixel(x, y));
                        }
                    }
                }
                timer.Stop();
                string file_path = Path.GetDirectoryName(openFD.FileName);
                Console.WriteLine("Image {0} has been opened!", file_path);
                Console.WriteLine("Took {0} milliseconds", timer.ElapsedMilliseconds);
                Console.WriteLine("Total pixels: {0}", mainDBmp.Bitmap.Width * mainDBmp.Bitmap.Height);
                pb1.Image = mainDBmp.Bitmap;
                bin_btn.Enabled = true;
            }
        }

        private void bin_btn_Click(object sender, EventArgs e)
        {
            if (mainDBmp == null) return;
            timer.Restart();
            binDBmp = new DirectBitmap(mainDBmp.Width, mainDBmp.Height);
            for (int y = 1; y < mainDBmp.Height - 1; y++)
            {
                for (int x = 1; x < mainDBmp.Width - 1; x++)
                {
                    Color c = mainDBmp.GetPixel(x, y);
                    int avg = (int)((c.R + c.G + c.B) / 3);
                    binDBmp.SetPixel(x, y, Color.FromArgb(avg, avg, avg));
                    //Console.WriteLine(binBmp.GetPixel(x,y));
                }
            }
            Console.WriteLine("Binarization is done!");
            Console.WriteLine("Took {0} milliseconds", timer.ElapsedMilliseconds);
            binDBmp.Bitmap.Save(@"C:\Users\Silver\Desktop\Tests\BinarizationTest.bmp");
            pb2.Image = binDBmp.Bitmap;
            gradED_btn.Enabled = true;

        }

        private void gradED_btn_Click(object sender, EventArgs e)
        {
            if (binDBmp == null) return;
            if (sobel3_radio.Checked) sobel3x3();
            else if (sobel5_radio.Checked) sobel5x5();
            else if (scharr_radio.Checked) scharr();

        }//gradED_btn
        public void sobel3x3()
        {
            int[,] sobelDX = new int[3, 3]
            {{-1, 0, 1},
            {-2, 0, 2},
            {-1, 0, 1}};
            int[,] sobelDY = new int[3, 3]
            {{-1,-2,-1},
            {0, 0, 0 },
            {1, 2, 1 }};

            timer.Restart();
            Console.WriteLine("Convolving DX with sobel 3x3");
            gradDXDBmp = new DirectBitmap(binDBmp.Width, binDBmp.Height);
            Convolve(sobelDX, gradDXDBmp);
            timer.Stop();
            Console.WriteLine("Took {0} milliseconds", timer.ElapsedMilliseconds);
            lbl2.Text = "Sobel DX";
            pb2.Image = gradDXDBmp.Bitmap;

            Console.WriteLine("Convolving DY with sobel 3x3");
            timer.Restart();
            gradDYDBmp = new DirectBitmap(binDBmp.Width, binDBmp.Height);
            Convolve(sobelDY, gradDYDBmp);
            timer.Stop();
            Console.WriteLine("Took {0} milliseconds", timer.ElapsedMilliseconds);
            lbl3.Text = "Sobel DY";
            pb3.Image = gradDYDBmp.Bitmap;

            Console.WriteLine("Creating Gradient of sobel 3x3");
            timer.Restart();
            gradFDBmp = new DirectBitmap(gradDXDBmp.Width, gradDXDBmp.Height);
            CombineDirectBitmaps(gradDXDBmp, gradDYDBmp, gradFDBmp);
            timer.Stop();
            Console.WriteLine("Took {0} milliseconds", timer.ElapsedMilliseconds);
            lbl4.Text = "Sobel DX/DY";
            pb4.Image = gradFDBmp.Bitmap;
        }
        public void sobel5x5()
        {
            int[,] sobelDX = new int[5, 5]
            {{2,2,4,2,2},
            {1,1,2,1,1},
            {0,0,0,0,0},
            {-1,-1,-2,-1,-1},
            {-2,-2,-4,-2,-2}};
            int[,] sobelDY = new int[5, 5]
            {{2,1,0,-1,-2},
            {2,1,0,-1,-2},
            {4,2,0,-2,-4},
            {2,1,0,-1,-2},
            {2,1,0,-1,-2}};

            timer.Restart();
            Console.WriteLine("Convolving DX with sobel 5x5");
            gradDXDBmp = new DirectBitmap(binDBmp.Width, binDBmp.Height);
            Convolve(sobelDX, gradDXDBmp);
            timer.Stop();
            Console.WriteLine("Took {0} milliseconds", timer.ElapsedMilliseconds);
            lbl2.Text = "Sobel DX";
            pb2.Image = gradDXDBmp.Bitmap;

            Console.WriteLine("Convolving DY with sobel 5x5");
            timer.Restart();
            gradDYDBmp = new DirectBitmap(binDBmp.Width, binDBmp.Height);
            Convolve(sobelDY, gradDYDBmp);
            timer.Stop();
            Console.WriteLine("Took {0} milliseconds", timer.ElapsedMilliseconds);
            lbl3.Text = "Sobel DY";
            pb3.Image = gradDYDBmp.Bitmap;

            Console.WriteLine("Creating Gradient of sobel 5x5");
            timer.Restart();
            gradFDBmp = new DirectBitmap(gradDXDBmp.Width, gradDXDBmp.Height);
            CombineDirectBitmaps(gradDXDBmp, gradDYDBmp, gradFDBmp);
            timer.Stop();
            Console.WriteLine("Took {0} milliseconds", timer.ElapsedMilliseconds);
            lbl4.Text = "Sobel DX/DY";
            pb4.Image = gradFDBmp.Bitmap;
        }
        public void scharr()
        {
            int[,] scharrDX = new int[3, 3]
            {{3, 0, -3},
            {10, 0, -10},
            {3, 0, -3}};
            int[,] scharrDY = new int[3, 3]
            {{3,10,3},
            {0, 0, 0 },
            {-3,-10,-3}};

            timer.Restart();
            Console.WriteLine("Convolving DX with scharr 3x3");
            gradDXDBmp = new DirectBitmap(binDBmp.Width, binDBmp.Height);
            Convolve(scharrDX, gradDXDBmp);
            timer.Stop();
            Console.WriteLine("Took {0} milliseconds", timer.ElapsedMilliseconds);
            lbl2.Text = "Scharr DX";
            pb2.Image = gradDXDBmp.Bitmap;

            Console.WriteLine("Convolving DY with scharr 3x3");
            timer.Restart();
            gradDYDBmp = new DirectBitmap(binDBmp.Width, binDBmp.Height);
            Convolve(scharrDY, gradDYDBmp);
            timer.Stop();
            Console.WriteLine("Took {0} milliseconds", timer.ElapsedMilliseconds);
            lbl3.Text = "Scharr DY";
            pb3.Image = gradDYDBmp.Bitmap;

            Console.WriteLine("Creating Gradient of scharr 3x3");
            timer.Restart();
            gradFDBmp = new DirectBitmap(gradDXDBmp.Width, gradDXDBmp.Height);
            CombineDirectBitmaps(gradDXDBmp, gradDYDBmp, gradFDBmp);
            timer.Stop();
            Console.WriteLine("Took {0} milliseconds", timer.ElapsedMilliseconds);
            lbl4.Text = "Scharr DX/DY";
            pb4.Image = gradFDBmp.Bitmap;
        }

        public void Convolve(int[,] kernel, DirectBitmap resImg, int stepSize = 1)
        {
            if (kernel == null) return;

            int threshold = int.Parse(th_textBox.Text);
            // resImg = new DirectBitmap(binDBmp.Width, binDBmp.Height);
            int window = (int)(Math.Sqrt(kernel.Length)/2.0);
            for (int y = window; y < binDBmp.Height - window; y += stepSize)
            {
                for (int x = window; x < binDBmp.Width - window; x += stepSize)
                {
                    int convResult = 0;
                    for (int kx = 0; kx < Math.Sqrt(kernel.Length); kx++)
                    {
                        for (int ky = 0; ky < Math.Sqrt(kernel.Length); ky++)
                        {
                            convResult += kernel[kx, ky] * binDBmp.GetPixel(x - window + kx, y - window + ky).R;
                        }//ky
                    }//kx

                    //Console.WriteLine(convResult);
                    convResult = Math.Abs(convResult);
                    //Simple Threshold
                    if (convResult > 255) convResult = 255;
                    //Hysteresis Threshold - not implemented
                    //if < T0 - not an edge
                    //if >= T1 - an edge
                    //if >T0 && <T1 - edge if nearby edge
                    int edgeColor = 255 - convResult;
                    if (convResult > threshold) resImg.SetPixel(x, y, Color.FromArgb(255, edgeColor,edgeColor,edgeColor));
                    else resImg.SetPixel(x, y, Color.White);
                }//x
            }//y
        }
        public void CombineDirectBitmaps(DirectBitmap img1, DirectBitmap img2, DirectBitmap res)
        {
            if (img1.Width != img2.Width || img1.Height != img2.Height) return;
            for (int y = 0; y < res.Height; y++)
            {
                for (int x = 0; x < res.Width; x++)
                {
                    int px1 = (int)img1.GetPixel(x, y).R;//GetBrightness() * 255;
                    int px2 = (int)img2.GetPixel(x, y).R;// GetBrightness() * 255;
                    int color = Math.Min(px1, px2);//Math.Max(px1, px2);
                    //Console.WriteLine("1: " + px1 + " 2: " + px2);
                    /*if (color == 0) res.SetPixel(x, y, Color.Red);
                    else*/ res.SetPixel(x, y, Color.FromArgb(255, color, color, color));
                }//x
            }//y
            Console.WriteLine("Image combination is done!");
            res.Bitmap.Save(@"C:\Users\Silver\Desktop\Tests\DxDyGradTest.bmp");
        }//CombineDirectBitmaps

        public void OpenImageInForm(PictureBox pb, string name = "")
        {
            DisplayImageForm dif = new DisplayImageForm();
            dif.SetImage((Bitmap)pb.Image);
            if (name == "") dif.SetName(pb.Name);
            else dif.SetName(name);

            dif.Show();
        }

        private void pb_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            OpenImageInForm(pb);
        }
        private void radio_Click(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            switch (rb.Name)
            {
                case "sobel3_radio":
                    sobel3_radio.Checked = true;
                    sobel5_radio.Checked = false;
                    scharr_radio.Checked = false;
                    custom_radio.Checked = false;
                    break;
                case "sobel5_radio":
                    sobel3_radio.Checked = false;
                    sobel5_radio.Checked = true;
                    scharr_radio.Checked = false;
                    custom_radio.Checked = false;
                    break;
                case "scharr_radio":
                    sobel3_radio.Checked = false;
                    sobel5_radio.Checked = false;
                    scharr_radio.Checked = true;
                    custom_radio.Checked = false;
                    break;
                case "custom_radio":
                    sobel3_radio.Checked = false;
                    sobel5_radio.Checked = false;
                    scharr_radio.Checked = false;
                    custom_radio.Checked = true;
                    break;
            }//switch
        }//radio Click

    }//Class (form1)
}
