namespace ImageProcessingActivity
{
    public static class Features
    {
        public static Bitmap BasicCopy(Bitmap original)
        {
            return new Bitmap(original);
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

        public static Bitmap Histogram(Bitmap original)
        {
            Bitmap result = new Bitmap(original.Width, original.Height);
            int[] red = new int[256];
            int[] green = new int[256];
            int[] blue = new int[256];
            for (int x = 0; x < original.Width; x++)
            {
                for (int y = 0; y < original.Height; y++)
                {
                    Color pixel = original.GetPixel(x, y);
                    red[pixel.R]++;
                    green[pixel.G]++;
                    blue[pixel.B]++;
                }
            }
            int max = Math.Max(red.Max(), Math.Max(green.Max(), blue.Max()));
            for (int i = 0; i < 256; i++)
            {
                red[i] = red[i] * 100 / max;
                green[i] = green[i] * 100 / max;
                blue[i] = blue[i] * 100 / max;
            }
            for (int x = 0; x < original.Width; x++)
            {
                for (int y = 0; y < original.Height; y++)
                {
                    Color pixel = original.GetPixel(x, y);
                    int r = red[pixel.R];
                    int g = green[pixel.G];
                    int b = blue[pixel.B];
                    Color histogram = Color.FromArgb(r, g, b);
                    result.SetPixel(x, y, histogram);
                }
            }
            return result;
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
    }
}
