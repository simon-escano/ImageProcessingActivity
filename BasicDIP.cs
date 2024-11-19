using System.Drawing.Imaging;

namespace ImageProcessingActivity
{
    public static class BasicDIP
    {
        public static Bitmap BasicCopy(Bitmap original)
        {
            Bitmap copy = new Bitmap(original.Width, original.Height);
            for (int x = 0; x < original.Width; x++)
            {
                for (int y = 0; y < original.Height; y++)
                {
                    Color pixel = original.GetPixel(x, y);
                    copy.SetPixel(x, y, pixel);
                }
            }
            return copy;
        }

        public static Bitmap ColorInversion(Bitmap original)
        {
            Bitmap result = new Bitmap(original.Width, original.Height);
            for (int x = 0; x < original.Width; x++)
            {
                for (int y = 0; y < original.Height; y++)
                {
                    Color pixel = original.GetPixel(x, y);
                    Color inverted = Color.FromArgb(255 - pixel.R, 255 - pixel.G, 255 - pixel.B);
                    result.SetPixel(x, y, inverted);
                }
            }
            return result;
        }

        public static Bitmap Greyscale(Bitmap original)
        {
            Bitmap result = new Bitmap(original.Width, original.Height);
            for (int x = 0; x < original.Width; x++)
            {
                for (int y = 0; y < original.Height; y++)
                {
                    Color pixel = original.GetPixel(x, y);
                    int average = (pixel.R + pixel.G + pixel.B) / 3;
                    Color greyscale = Color.FromArgb(average, average, average);
                    result.SetPixel(x, y, greyscale);
                }
            }
            return result;
        }

        public static Bitmap Histogram(Bitmap original, PictureBox processed)
        {
            Bitmap greyscaleImage = Greyscale(original);

            int[] histData = new int[256];
            for (int x = 0; x < greyscaleImage.Width; x++)
            {
                for (int y = 0; y < greyscaleImage.Height; y++)
                {
                    Color pixel = greyscaleImage.GetPixel(x, y);
                    histData[pixel.R]++;
                }
            }

            int histWidth = processed.Width;
            int histHeight = processed.Height;
            Bitmap histImage = new Bitmap(histWidth, histHeight);
            using (Graphics g = Graphics.FromImage(histImage))
            {
                g.Clear(Color.White);
                int max = histData.Max();
                for (int i = 0; i < histData.Length; i++)
                {
                    int barHeight = (int)((histData[i] / (float)max) * histHeight);
                    g.DrawLine(Pens.Black, i, histHeight, i, histHeight - barHeight);
                }
            }

            return histImage;
        }

        public static Bitmap Sepia(Bitmap original)
        {
            Bitmap result = new Bitmap(original.Width, original.Height);
            for (int x = 0; x < original.Width; x++)
            {
                for (int y = 0; y < original.Height; y++)
                {
                    Color pixel = original.GetPixel(x, y);
                    int r = (int)(pixel.R * 0.393 + pixel.G * 0.769 + pixel.B * 0.189);
                    int g = (int)(pixel.R * 0.349 + pixel.G * 0.686 + pixel.B * 0.168);
                    int b = (int)(pixel.R * 0.272 + pixel.G * 0.534 + pixel.B * 0.131);
                    r = Math.Min(r, 255);
                    g = Math.Min(g, 255);
                    b = Math.Min(b, 255);
                    Color sepia = Color.FromArgb(r, g, b);
                    result.SetPixel(x, y, sepia);
                }
            }
            return result;
        }

        public static Bitmap Subtraction(Color color, Bitmap original, Bitmap background)
        {
            Bitmap result = new Bitmap(original.Width, original.Height);

            Rectangle rect = new Rectangle(0, 0, original.Width, original.Height);
            BitmapData originalData = original.LockBits(rect, ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);
            BitmapData backgroundData = background.LockBits(rect, ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);
            BitmapData resultData = result.LockBits(rect, ImageLockMode.WriteOnly, PixelFormat.Format24bppRgb);

            int stride = originalData.Stride;
            IntPtr originalPtr = originalData.Scan0;
            IntPtr backgroundPtr = backgroundData.Scan0;
            IntPtr resultPtr = resultData.Scan0;

            byte[] originalBytes = new byte[stride * original.Height];
            byte[] backgroundBytes = new byte[stride * background.Height];
            byte[] resultBytes = new byte[stride * result.Height];

            System.Runtime.InteropServices.Marshal.Copy(originalPtr, originalBytes, 0, originalBytes.Length);
            System.Runtime.InteropServices.Marshal.Copy(backgroundPtr, backgroundBytes, 0, backgroundBytes.Length);

            int subtractGreyValue = (color.R + color.G + color.B) / 3;
            int threshold = 5;

            for (int y = 0; y < original.Height; y++)
            {
                for (int x = 0; x < original.Width; x++)
                {
                    int index = y * stride + x * 3;
                    int originalGreyValue = (originalBytes[index + 2] + originalBytes[index + 1] + originalBytes[index]) / 3;

                    if (Math.Abs(originalGreyValue - subtractGreyValue) > threshold)
                    {
                        resultBytes[index] = originalBytes[index];
                        resultBytes[index + 1] = originalBytes[index + 1];
                        resultBytes[index + 2] = originalBytes[index + 2];
                    }
                    else
                    {
                        resultBytes[index] = backgroundBytes[index];
                        resultBytes[index + 1] = backgroundBytes[index + 1];
                        resultBytes[index + 2] = backgroundBytes[index + 2];
                    }
                }
            }

            System.Runtime.InteropServices.Marshal.Copy(resultBytes, 0, resultPtr, resultBytes.Length);

            original.UnlockBits(originalData);
            background.UnlockBits(backgroundData);
            result.UnlockBits(resultData);

            return result;
        }
    }
}