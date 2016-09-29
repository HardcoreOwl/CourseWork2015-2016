using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using System.Numerics;

namespace FilterCreator
{
    public class FastFourier
    {
        public Bitmap Image;
        public int[,] GR,GG,GB;
        public static int wd, hg;
        public Complex[][,] Fourier = new Complex[3][,];
        //public Complex[,] GFourier = new Complex[hg, wd];
        //public Complex[,] BFourier = new Complex[hg, wd];
        protected int range, style, power;
        public bool pass;

        public FastFourier(Bitmap b, int range, bool pass, int style, int power)
        {
            this.range = range;
            this.pass = pass;
            this.style = style;
            this.power = power;
            Image = (Bitmap)b.Clone();
            wd = Image.Width;
            hg = Image.Height;
            ReadImage();
            Forward();
        }

        private void ReadImage()
        {
            GR = new int[hg, wd];
            GG = new int[hg, wd];
            GB = new int[hg, wd];
            BitmapData bitmapData1 = Image.LockBits(new Rectangle(0, 0, Image.Width, Image.Height),
                                     ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);
            unsafe
            {
                byte* imagePointer1 = (byte*)bitmapData1.Scan0;

                for (int i = 0; i < bitmapData1.Height; i++)
                {
                    for (int j = 0; j < bitmapData1.Width; j++)
                    {
                        GB[i, j] = imagePointer1[0];
                        GG[i, j] = imagePointer1[1];
                        GR[i, j] = imagePointer1[2];
                        imagePointer1 += 3;
                    }
                    imagePointer1 += bitmapData1.Stride - (bitmapData1.Width * 3);
                }
            }
            Image.UnlockBits(bitmapData1);
            return;
        }

        public double D(int a, int b)
        {
            return Math.Sqrt(a * a + b * b);
        }

        public Complex[][,] Filt(Complex[][,] Arr)
        {
            double h=0;
            for (int i = -hg / 2; i < hg / 2; i++)
                for (int j = -wd / 2; j < wd / 2; j++)
                {

                    if (style == 0)
                    {
                        if (D(i, j) <= range) h = 1;
                        else h = 0;
                        if (pass) h = 1 - h;
                    }
                    if (style == 1)
                    {
                        h = Math.Exp(-D(i, j) * D(i, j) / (2 * range * range));
                        if (pass) h = 1 - h;
                    }
                    if (style == 2)
                    {
                        h = 1 / (1 + Math.Pow(D(i, j) / range, 2 * power));
                        if (pass) h = 1 / (1 + Math.Pow(range / D(i, j), 2 * power));
                    }
                    for (int q = 0; q < 3; q++)
                    {
                        Arr[q][hg / 2 + i, wd / 2 + j] *= h;
                    }
                }
            return Arr;
        }

        public void Forward()
        {
            Fourier[0] = new Complex[hg, wd];
            Fourier[1] = new Complex[hg, wd];
            Fourier[2] = new Complex[hg, wd];
            for (int i = 0; i < hg; i++)
                for (int j = 0; j < wd; j++)
                {
                    Fourier[0][i, j] = GB[i, j] * (Math.Pow(-1, i + j + 1)); 
                    Fourier[1][i, j] = GG[i, j] * (Math.Pow(-1, i + j + 1));
                    Fourier[2][i, j] = GR[i, j] * (Math.Pow(-1, i + j + 1)); 
                }
            Complex[][,] t = fft2d(Fourier,true);
            //t = Shift(t);
            t = Filt(t);
            //t = Shift(t);
            Fourier = fft2d(t,false);
            for (int i = 0; i < hg; i++)
                for (int j = 0; j < wd; j++)
                {
                    Fourier[0][i, j] = Fourier[0][i, j].Real * (Math.Pow(-1, i + j + 1));
                    Fourier[1][i, j] = Fourier[1][i, j].Real * (Math.Pow(-1, i + j + 1));
                    Fourier[2][i, j] = Fourier[2][i, j].Real * (Math.Pow(-1, i + j + 1));
                }
           
        }

        public static Complex W(int k, int N)
        {
            if (k % N == 0) return 1;
            double arg = -2 * Math.PI * k / N;
            return new Complex(Math.Cos(arg), Math.Sin(arg));
        }

        public static Complex[][,] fft2d(Complex[][,] F,bool dir)
        {
            Complex[][] temp = new Complex[3][];
            Complex[][,] outp = new Complex[3][,];
            for (int q = 0; q < 3; q++)
            {
                temp[q] = new Complex[wd];
                outp[q] = new Complex[hg, wd];
            }
            double c1 = 0;
            for (int i = 0; i < hg; i++)
            {
                for (int j = 0; j < wd; j++)
                {
                    for (int q = 0; q < 3; q++)
                        outp[q][i, j] = F[q][i, j];
                }
            }
            if (dir) c1 = 1.0 / wd;
            else c1 = 1.0;
            for (int i = 0; i < hg; i++)
            {
                for (int j = 0; j < wd; j++)
                {
                    for (int q = 0; q < 3; q++)
                        temp[q][j] = outp[q][i, j];
                }
                temp = fft(temp);
                for (int j = 0; j < wd; j++)
                {
                    for (int q = 0; q < 3; q++)
                        outp[q][i, j] = temp[q][j] * c1;
                }
            }
            if (dir) c1 = 1.0 / hg;
            else c1 = 1.0;
            for (int q = 0; q < 3; q++)
                temp[q] = new Complex[hg];
            for (int i = 0; i < wd; i++)
            {
                
                for (int j = 0; j < hg; j++)
                {
                    for (int q = 0; q < 3; q++)
                        temp[q][j] = outp[q][j, i];
                }
                temp = fft(temp);
                for (int j = 0; j < hg; j++)
                {
                    for (int q = 0; q < 3; q++)
                        outp[q][j, i] = temp[q][j] * c1;
                }
            }

            return outp;
        }

        public static Complex[][] fft(Complex[][] x)
        {
            Complex[][] X = new Complex[3][];
            int N = x[0].Length;
            if (N == 2)
            {
                for (int q = 0; q < 3; q++)
                {
                    X[q] = new Complex[2];
                    X[q][0] = x[q][0] + x[q][1];
                    X[q][1] = x[q][0] - x[q][1];
                }
            }
            else
            {
                Complex[][] x_even = new Complex[3][];
                Complex[][] x_odd = new Complex[3][];
                for (int q = 0; q < 3; q++)
                {
                    x_even[q] = new Complex[N / 2];
                    x_odd[q] = new Complex[N / 2];

                    for (int i = 0; i < N / 2; i++)
                    {
                        x_even[q][i] = x[q][2 * i];
                        x_odd[q][i] = x[q][2 * i + 1];
                    }
                }
                Complex[][] X_even = fft(x_even);
                Complex[][] X_odd = fft(x_odd);
                X = new Complex[3][];
                for (int q = 0; q < 3; q++)
                {
                    X[q] = new Complex[N];
                }
                for (int q = 0; q < 3; q++)
                {
                    for (int i = 0; i < N / 2; i++)
                    {
                        X[q][i] = X_even[q][i] + W(i, N) * X_odd[q][i];
                        X[q][i + N / 2] = X_even[q][i] - W(i, N) * X_odd[q][i];
                    }
                }
            }
            return X;
        }

    
    }
    
}