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

        public static Bitmap Subtraction(Bitmap original, Bitmap background)
        {
            Bitmap result = new Bitmap(original.Width, original.Height);
            // TODO : Implement subtraction
            return result;
        }
    }
}
