using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Xml.Linq;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace FilterCreator
{
    public partial class MainForm : Form
    {
        private Bitmap MainImage;
        private Bitmap prevBmp;
        OpenFileDialog oi;
        SaveFileDialog si;
        public BinaryFormatter ser = new BinaryFormatter();
        public Filter LastFilter=new Filter();

        public List<Filter> FilterList1 = new List<Filter>();

        public List<CustomFilter> AllCustomFilters = new List<CustomFilter>();

        public MainForm()
        {
            //Filter f = new Filter();
            //ser = new XmlSerializer(typeof(Filter));        
            MainImage = new Bitmap(2, 2);
            InitializeComponent();
            oi = new OpenFileDialog();
            oi.RestoreDirectory = true;
            oi.InitialDirectory = "C:\\";
            oi.FilterIndex = 1;
            oi.Filter = "bmp Files (*.bmp)|*.bmp|*.jpg|png Files (*.png)|*.png |jpg Files (*.jpg)";

            si = new SaveFileDialog();
            si.RestoreDirectory = true;
            si.InitialDirectory = "C:\\";
            si.FilterIndex = 1;
            si.Filter = "bmp Files (*.bmp)|*.bmp|*.jpg|png Files (*.png)|*.png |jpg Files (*.jpg)";
            this.Invalidate();
        }
        //Не описан в пз
        private void MainForm_Load(object sender, EventArgs e)
        {
            //InitializeComponent();
            try
            {
                DeSer(); 
                MFl.DataSource = AllCustomFilters;
                MFl.DisplayMember = "CustomFilterName"; //CustomFilter.CustomFilterName;
            }
            catch (Exception)
            { AllCustomFilters = new List<CustomFilter>(); }
        }

        public void DeSer()
        {
            using (FileStream fs = new FileStream("CustomFilters.bin", FileMode.OpenOrCreate))
            {
                AllCustomFilters = (List<CustomFilter>)ser.Deserialize(fs);
            }
        }
        public void Ser()
        {
            using (FileStream fs = new FileStream("CustomFilters.bin", FileMode.OpenOrCreate))
            {
                ser.Serialize(fs, AllCustomFilters);
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            int h = MainImage.Height;
            int w = MainImage.Width;
            double coef = Math.Max(w, h)>512?512.0/Math.Max(w, h):1;
            g.DrawImage(MainImage, new Rectangle(2, 2, ((int)(MainImage.Width * coef)), ((int)(MainImage.Height* coef))));
        }     

        private void openImage_but_Click(object sender, EventArgs e)
        {
            if(oi.ShowDialog() == DialogResult.OK)
            {
                MainImage = (Bitmap)Bitmap.FromFile(oi.FileName, false);
                prevBmp = (Bitmap)MainImage.Clone();
                complexFbox.Enabled = false;
                FilterList1 = new List<Filter>();
                this.Invalidate();
            }
            сохранитьToolStripMenuItem.Enabled = true;
            
            pixel_box.SelectedIndex = 0;
        }

      
        //public double[,] Convoluate(double[,] a, double[,] b)
        //{
        //    int wofs = b.GetLength(0)/2; int hofs =b.GetLength(1)/2;
        //    int w = a.GetLength(0);
        //    int h = a.GetLength(1);
        //    double[,] Outa = new double[w,h];
            
        //    //double r = Math.Sqrt(Math.Pow((wofs),2)+Math.Pow(hofs,2));
        //    double[,] Temp = new double[w+wofs+1,h+hofs+1];
        //    for(int i=wofs;i<w+wofs;i++)
        //        for(int j=hofs;j<h+hofs;j++)
        //        {
        //            double value=0;
        //            for (int k = 0; k < b.GetLength(0); k++)
        //                for (int l = 0; l < b.GetLength(1); l++)
        //                    value += Temp[i - k, j - l] * b[k, l];
        //        }

        //    for(int i=0;i<w;i++)
        //        for(int j=0;j<h;j++)
        //        {
        //            Outa[i, j] = Temp[i + wofs + 1, j + hofs + 1];
        //        }
        //    return Outa;
        //}

    //    public void UseFilter(Filter f)
    //    {

    //        if (f is ConvFilter) ConvolutionFilter(((ConvFilter)f));
    //        if (f is Pix)
    //        {
    //            Pix p = (Pix)f;
    //            if (f.name == "Грейскеил") Grayscale();
    //            if (f.name == "Негатив") Invert();
    //            if (f.name == "Яркость")
    //            {
    //                Brightness((int)p.Pars[0]);
    //            }
    //            if (f.name == "Гамма")
    //            {
    //                Gamma(p.Pars[0], p.Pars[1], p.Pars[2]);
    //            }
    //            if (f.name == "Цвет")
    //            {
    //                Colorr(p.Pars[0], p.Pars[1], p.Pars[2]);
    //            }

    //            if (f.name == "Контраст")
    //            {

    //                Brightness((int)p.Pars[0]);
    //            }
    //        }
    //}
           //Добавить запоминание

        private void saveFilter_Click(object sender, EventArgs e)
        {
            complexFbox.Enabled = false;
            CustomFilter f = new CustomFilter(FilterList1, Namel.Text);
            AllCustomFilters.Add(f);
            FilterList1 = new List<Filter>();
            LastFilter = new Filter();
            Ser();
            DeSer();
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(si.ShowDialog() == DialogResult.OK)
            {
                string saveFilePath = si.FileName;
                if (System.IO.File.Exists(saveFilePath))
                    System.IO.File.Delete(saveFilePath);
            }
        }

        private void undonebut_Click(object sender, EventArgs e)
        {
            addChangeBut.Enabled = false;
            MainImage = (Bitmap)prevBmp.Clone();
            this.Invalidate();
        }

        private void createNewFilterBut_Click(object sender, EventArgs e)
        {
            complexFbox.Enabled = true;
            addChangeBut.Enabled = false;
            if (!CheckPow(MainImage.Width) || !CheckPow(MainImage.Height)) freqbox.Enabled = false;
        }

        private void addChangeBut_Click(object sender, EventArgs e)
        {
            FilterList1.Add(LastFilter);
            prevBmp = (Bitmap)MainImage.Clone();
        }

        # region Fourier region
        private bool CheckPow(int a)
        {
            bool q = true;
            do
            {
                if (a % 2 != 0 && a != 1) q = false;
                a /= 2;
            } while (a != 1 && q);
            return q;
        }

        private void FourierP(Complex[][,] F)
        {
            BitmapData bmData = MainImage.LockBits(new Rectangle(0, 0, MainImage.Width, MainImage.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            int stride = bmData.Stride;
            int w = MainImage.Width;
            int h = MainImage.Height;
            System.IntPtr Scan0 = bmData.Scan0;
            unsafe
            {
                byte* p = (byte*)(void*)Scan0;

                int nOffset = stride - MainImage.Width * 3;
                int nPixel;

                for (int y = 0; y < MainImage.Height; ++y)
                {
                    for (int x = 0; x < MainImage.Width; ++x)
                    {
                        nPixel = (int)F[2][h - y - 1, w - x - 1].Real;
                        nPixel = Math.Max(nPixel, 0);
                        p[2] = (byte)Math.Min(255, nPixel);

                        nPixel = (int)F[1][h - y - 1, w - x - 1].Real;
                        nPixel = Math.Max(nPixel, 0);
                        p[1] = (byte)Math.Min(255, nPixel);

                        nPixel = (int)F[0][h - y - 1, w - x - 1].Real;
                        nPixel = Math.Max(nPixel, 0);
                        p[0] = (byte)Math.Min(255, nPixel);

                        p += 3;
                    }
                    p += nOffset;
                }
            }
            MainImage.UnlockBits(bmData);
        }

        private void furier_but_Click(object sender, EventArgs e)
        {
            if (CheckPow(MainImage.Width) && CheckPow(MainImage.Height))
            {
                int range, style, power;
                bool pass;
                FreqForm ff = new FreqForm();
                ff.ShowDialog();
                if (ff.DialogResult == DialogResult.OK)
                {
                    range = ff.range;
                    style = ff.style;
                    pass = ff.pass;
                    power = ff.power;
                    prevBmp = (Bitmap)MainImage.Clone();
                    FastFourier f = new FastFourier(MainImage, range, pass, style, power);
                    FourierP(f.Fourier);
                    LastFilter = new Filter("Частотный фильтр");
                    LastFilter.Pass = pass;
                    LastFilter.Style = style;
                    LastFilter.Range = range;
                    addChangeBut.Enabled = true;
                }
                else MessageBox.Show("Фильтр не был задан!");
                this.Invalidate();
            }
            else
            {
                furier_but.Enabled = false;
                MessageBox.Show("Изображение имеет неподходящий размер.\nПопробуйте использовать изображения, стороны которого - степени двойки.");
            }
        }
        #endregion

        #region Matrix region
        private void ConvolutionBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            int p = ConvolutionBox.SelectedIndex;
            if (p != 0)
            {
                prevBmp = (Bitmap)MainImage.Clone();
                addChangeBut.Enabled = true;
            }
            if (p == 1)
            {
                LastFilter = new Filter("Размытие 3x3");
                LastFilter.CoM =
                new double[,] { { 0.111 , 0.111 , 0.111 }, 
                                { 0.111 , 0.111 , 0.111 }, 
                                { 0.111 , 0.111 , 0.111 }  };
                ConvolutionFilter(LastFilter);
                this.Invalidate();
            }
            if (p == 2)
            {
                LastFilter = new Filter("Размытие по Гауссу");
                LastFilter.CoM =
                new double[,] { { 0.0625, 0.125, 0.0625, }, 
                                { 0.125, 0.25, 0.125, }, 
                                { 0.0625, 0.125, 0.0625, }, };
                ConvolutionFilter(LastFilter);
                this.Invalidate();
            }
            if (p == 4)
            {
                LastFilter = new Filter("Тиснение");
                LastFilter.CoM =
                new double[,] { { -1, -1, -1, }, 
                                { -1, 9, -1, }, 
                                { -1, -1, -1, }, };
                ConvolutionFilter(LastFilter);
                this.Invalidate();
            }
            if (p == 3)
            {
                LastFilter = new Filter("Выделение границ");
                LastFilter.CoM =
                new double[,] { { 0 , 1 , 0 }, 
                                { 1 , -4 , 1 }, 
                                { 0 , 1 , 0 }  };
                ConvolutionFilter(LastFilter);
                this.Invalidate();
            }
            if (p == 4)
            {
                LastFilter = new Filter("Повышение контраста");
                LastFilter.CoM =
                new double[,] { { 0 , -1 , 0 }, 
                                { -1 , 5 , -1 }, 
                                { 0 , -1 , 0 }  };
                ConvolutionFilter(LastFilter);
                this.Invalidate();
            }
        }

        private void kernel_but_Click(object sender, EventArgs e)
        {
            try
            {
                int h, w;
                if (int.TryParse(h_box.Text, out h) && int.TryParse(w_box.Text, out w) && h % 2 == 1 && w % 2 == 1 && h > 0 && w > 0)
                {
                    LinearMatrix lm = new LinearMatrix(h, w);
                    lm.ShowDialog();
                    if (lm.DialogResult != DialogResult.OK)
                    {
                        MessageBox.Show("Фильтр не был задан!");
                    }
                    else
                    {
                        Filter f = new Filter("Пользовательский");
                        f.CoM = lm.Matr;
                        LastFilter = f;
                        ConvolutionFilter(f);
                        this.Invalidate();
                    }
                }
                else MessageBox.Show("Введены некорректные данные!\nПожалуйста введите положительные нечетные числа!");
            }
            catch (Exception)
            {
                MessageBox.Show("Что-то пошло не так!");
            }
        }
        
        public void ConvolutionFilter(Filter filter)
        {
            BitmapData MainImageData = MainImage.LockBits(new Rectangle(0, 0,
                                     MainImage.Width, MainImage.Height),
                                     ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);
            byte[] pixelBuffer = new byte[MainImageData.Stride * MainImageData.Height];
            byte[] resultBuffer = new byte[MainImageData.Stride * MainImageData.Height];
            Marshal.Copy(MainImageData.Scan0, pixelBuffer, 0, pixelBuffer.Length);
            MainImage.UnlockBits(MainImageData);
            double blue = 0.0;
            double green = 0.0;
            double red = 0.0;
            int fw = filter.CoM.GetLength(1);
            int fh = filter.CoM.GetLength(0);
            int fOff = (fw - 1) / 2;
            int calcOffset = 0;
            int byteOffset = 0;
            for (int i = fOff; i < MainImage.Height - fOff; i++)
            {
                for (int j = fOff; j < MainImage.Width - fOff; j++)
                {
                    blue = 0;
                    green = 0;
                    red = 0;

                    byteOffset = i * MainImageData.Stride + j * 4;

                    for (int y = -fOff;
                        y <= fOff; y++)
                    {
                        for (int x = -fOff;
                            x <= fOff; x++)
                        {
                            calcOffset = byteOffset + (x * 4) + (y * MainImageData.Stride);
                            blue += (double)(pixelBuffer[calcOffset]) * filter.CoM[y + fOff, x + fOff];
                            green += (double)(pixelBuffer[calcOffset + 1]) * filter.CoM[y + fOff, x + fOff];
                            red += (double)(pixelBuffer[calcOffset + 2]) * filter.CoM[y + fOff, x + fOff];
                        }
                    }
                    if (blue > 255)
                    { blue = 255; }
                    else if (blue < 0)
                    { blue = 0; }
                    if (green > 255)
                    { green = 255; }
                    else if (green < 0)
                    { green = 0; }
                    if (red > 255)
                    { red = 255; }
                    else if (red < 0)
                    { red = 0; }
                    resultBuffer[byteOffset] = (byte)(blue);
                    resultBuffer[byteOffset + 1] = (byte)(green);
                    resultBuffer[byteOffset + 2] = (byte)(red);
                    resultBuffer[byteOffset + 3] = 255;
                }
            }
            MainImage = new Bitmap(MainImageData.Width, MainImageData.Height);
            MainImageData = MainImage.LockBits(new Rectangle(0, 0,
                                     MainImage.Width, MainImage.Height),
                                     ImageLockMode.WriteOnly, PixelFormat.Format32bppArgb);
            Marshal.Copy(resultBuffer, 0, MainImageData.Scan0, resultBuffer.Length);
            MainImage.UnlockBits(MainImageData);
        }
        #endregion

        #region 1pixfilter processing

        private void pixel_box_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            MainImage = (Bitmap)prevBmp.Clone();
            this.Invalidate();
            string p = pixel_box.SelectedItem.ToString();
            if (p != "")
            {
                prevBmp = (Bitmap)MainImage.Clone();
                addChangeBut.Enabled = true;
            }
            if (p == "Грейскейл")
            {
                Grayscale();
                LastFilter = new Filter("Грейскеил");
            }
            if (p == "Негатив")
            {
                Invert();
                LastFilter = new Filter("Негатив");
            }
            if (p == "Яркость")
            {
                BrightnessCont bf = new BrightnessCont();
                bf.ShowDialog();
                if (bf.DialogResult == DialogResult.OK)
                {
                    LastFilter = new Filter("Яркость");
                    LastFilter.Params = new List<double>();
                    LastFilter.Params.Add(bf.valu);
                    Brightness((int)bf.valu);
                }
            }
            if (p == "Гамма")
            {
                ColorGamma bf = new ColorGamma();
                bf.ShowDialog();
                if (bf.DialogResult == DialogResult.OK)
                {
                    LastFilter = new Filter("Гамма");
                    Gamma(bf.r, bf.g, bf.b);
                    LastFilter.Params = new List<double>();
                    LastFilter.Params.Add(bf.r);
                    LastFilter.Params.Add(bf.g);
                    LastFilter.Params.Add(bf.b);
                }
            }
            if (p == "Цвет")
            {
                ColorGamma bf = new ColorGamma();
                bf.ShowDialog();
                bf.sw = false;
                if (bf.DialogResult == DialogResult.OK)
                {
                    LastFilter = new Filter("Цвет");
                    Colorr(bf.r, bf.g, bf.b);
                    LastFilter.Params = new List<double>();
                    LastFilter.Params.Add(bf.r);
                    LastFilter.Params.Add(bf.g);
                    LastFilter.Params.Add(bf.b);
                }
            }
            if (p == "Контраст")
            {
                BrightnessCont bf = new BrightnessCont();
                bf.ShowDialog();
                bf.sw = false;
                if (bf.DialogResult == DialogResult.OK)
                {
                    LastFilter = new Filter("Контраст");
                    LastFilter.Params = new List<double>();
                    LastFilter.Params.Add(bf.valu);
                    Contrast((sbyte)bf.valu);
                }
            }
            this.Invalidate();
        }

        public void Grayscale()
        {
            BitmapData bmData = MainImage.LockBits(new Rectangle(0, 0, MainImage.Width, MainImage.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            int stride = bmData.Stride;
            System.IntPtr Scan0 = bmData.Scan0;
            unsafe
            {
                byte* p = (byte*)(void*)Scan0;

                int nOffset = stride - MainImage.Width * 3;

                byte red, green, blue;

                for (int y = 0; y < MainImage.Height; ++y)
                {
                    for (int x = 0; x < MainImage.Width; ++x)
                    {
                        blue = p[0];
                        green = p[1];
                        red = p[2];

                        p[0] = p[1] = p[2] = (byte)(.299 * red + .587 * green + .114 * blue);

                        p += 3;
                    }
                    p += nOffset;
                }
            }
            MainImage.UnlockBits(bmData);
        }

        public void Invert()
        {
            BitmapData bmData = MainImage.LockBits(new Rectangle(0, 0, MainImage.Width, MainImage.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);

            int stride = bmData.Stride;
            System.IntPtr Scan0 = bmData.Scan0;

            unsafe
            {
                byte* p = (byte*)(void*)Scan0;

                int nOffset = stride - MainImage.Width * 3;
                int nWidth = MainImage.Width * 3;

                for (int y = 0; y < MainImage.Height; ++y)
                {
                    for (int x = 0; x < nWidth; ++x)
                    {
                        p[0] = (byte)(255 - p[0]);
                        ++p;
                    }
                    p += nOffset;
                }
            }

            MainImage.UnlockBits(bmData);
        }

        public void Brightness(double nBrightness)
        {
            BitmapData bmData = MainImage.LockBits(new Rectangle(0, 0, MainImage.Width, MainImage.Height), ImageLockMode.ReadWrite, MainImage.PixelFormat);
            int stride = bmData.Stride;
            System.IntPtr Scan0 = bmData.Scan0;
            int nVal = 0;
            unsafe
            {
                byte* p = (byte*)(void*)Scan0;
                int nOffset = stride - MainImage.Width * 3;
                int nWidth = MainImage.Width * 3;
                for (int y = 0; y < MainImage.Height; ++y)
                {
                    for (int x = 0; x < nWidth; ++x)
                    {
                        nVal = (int)(p[0] + nBrightness);

                        if (nVal < 0) nVal = 0;
                        if (nVal > 255) nVal = 255;

                        p[0] = (byte)nVal;

                        ++p;
                    }
                    p += nOffset;
                }
            }
            MainImage.UnlockBits(bmData);
        }

        public void Contrast(sbyte nContrast)
        {
            double pixel = 0, contrast = (100.0 + nContrast) / 100.0;
            contrast *= contrast;
            int red, green, blue;
            BitmapData bmData = MainImage.LockBits(new Rectangle(0, 0, MainImage.Width, MainImage.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            int stride = bmData.Stride;
            System.IntPtr Scan0 = bmData.Scan0;
            unsafe
            {
                byte* p = (byte*)(void*)Scan0;

                int nOffset = stride - MainImage.Width * 3;

                for (int y = 0; y < MainImage.Height; ++y)
                {
                    for (int x = 0; x < MainImage.Width; ++x)
                    {
                        blue = p[0];
                        green = p[1];
                        red = p[2];

                        pixel = red / 255.0;
                        pixel -= 0.5;
                        pixel *= contrast;
                        pixel += 0.5;
                        pixel *= 255;
                        if (pixel < 0) pixel = 0;
                        if (pixel > 255) pixel = 255;
                        p[2] = (byte)pixel;

                        pixel = green / 255.0;
                        pixel -= 0.5;
                        pixel *= contrast;
                        pixel += 0.5;
                        pixel *= 255;
                        if (pixel < 0) pixel = 0;
                        if (pixel > 255) pixel = 255;
                        p[1] = (byte)pixel;

                        pixel = blue / 255.0;
                        pixel -= 0.5;
                        pixel *= contrast;
                        pixel += 0.5;
                        pixel *= 255;
                        if (pixel < 0) pixel = 0;
                        if (pixel > 255) pixel = 255;
                        p[0] = (byte)pixel;

                        p += 3;
                    }
                    p += nOffset;
                }
            }


            MainImage.UnlockBits(bmData);
        }

        public void Gamma(double r1, double g1, double b1)
        {
            byte[] redGamma = new byte[256];
            byte[] greenGamma = new byte[256];
            byte[] blueGamma = new byte[256];

            double red = 1 / Math.Max(0.1, Math.Min(5.0, r1));
            double green = 1 / Math.Max(0.1, Math.Min(5.0, g1));
            double blue = 1 / Math.Max(0.1, Math.Min(5.0, b1));
            for (int i = 0; i < 256; ++i)
            {
                redGamma[i] = (byte)Math.Min(255, (int)((255.0 * Math.Pow(i / 255.0, red)) + 0.5));
                greenGamma[i] = (byte)Math.Min(255, (int)((255.0 * Math.Pow(i / 255.0, green)) + 0.5));
                blueGamma[i] = (byte)Math.Min(255, (int)((255.0 * Math.Pow(i / 255.0, blue)) + 0.5));
            }
            BitmapData bmData = MainImage.LockBits(new Rectangle(0, 0, MainImage.Width, MainImage.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);

            int stride = bmData.Stride;
            System.IntPtr Scan0 = bmData.Scan0;
            unsafe
            {
                byte* p = (byte*)(void*)Scan0;

                int nOffset = stride - MainImage.Width * 3;

                for (int y = 0; y < MainImage.Height; ++y)
                {
                    for (int x = 0; x < MainImage.Width; ++x)
                    {
                        p[2] = redGamma[p[2]];
                        p[1] = greenGamma[p[1]];
                        p[0] = blueGamma[p[0]];

                        p += 3;
                    }
                    p += nOffset;
                }
            }
            MainImage.UnlockBits(bmData);
        }

        public void Colorr(double red, double green, double blue)
        {
            BitmapData bmData = MainImage.LockBits(new Rectangle(0, 0, MainImage.Width, MainImage.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);

            int stride = bmData.Stride;
            System.IntPtr Scan0 = bmData.Scan0;
            unsafe
            {
                byte* p = (byte*)(void*)Scan0;

                int nOffset = stride - MainImage.Width * 3;
                int nPixel;

                for (int y = 0; y < MainImage.Height; ++y)
                {
                    for (int x = 0; x < MainImage.Width; ++x)
                    {
                        nPixel = p[2] + (int)red;
                        nPixel = Math.Max(nPixel, 0);
                        p[2] = (byte)Math.Min(255, nPixel);

                        nPixel = p[1] + (int)green;
                        nPixel = Math.Max(nPixel, 0);
                        p[1] = (byte)Math.Min(255, nPixel);

                        nPixel = p[0] + (int)blue;
                        nPixel = Math.Max(nPixel, 0);
                        p[0] = (byte)Math.Min(255, nPixel);

                        p += 3;
                    }
                    p += nOffset;
                }
            }
            MainImage.UnlockBits(bmData);
        }
        #endregion

        private void MFl_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        
    }
}
