using System;
using System.Drawing;
using System.Drawing.Imaging;

public class Convolution
{
    public static Bitmap ApplyConvolution(Bitmap image, int[] matrix, int factor, int offset)
    {
        Bitmap result = new Bitmap(image.Width, image.Height);

        BitmapData bmData = image.LockBits(new Rectangle(0, 0, image.Width, image.Height),
                                           ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);
        BitmapData resultData = result.LockBits(new Rectangle(0, 0, result.Width, result.Height),
                                                 ImageLockMode.WriteOnly, PixelFormat.Format24bppRgb);

        int stride = bmData.Stride;
        IntPtr scan0 = bmData.Scan0;
        IntPtr resultScan0 = resultData.Scan0;

        unsafe
        {
            byte* p = (byte*)(void*)scan0;
            byte* pResult = (byte*)(void*)resultScan0;
            int width = image.Width;
            int height = image.Height;
            int matrixSize = 3;

            for (int y = 1; y < height - 1; y++)
            {
                for (int x = 1; x < width - 1; x++)
                {
                    int red = 0, green = 0, blue = 0;

                    for (int i = -1; i <= 1; i++)
                    {
                        for (int j = -1; j <= 1; j++)
                        {
                            int pixelRed = p[((y + i) * stride) + ((x + j) * 3) + 2];
                            int pixelGreen = p[((y + i) * stride) + ((x + j) * 3) + 1];
                            int pixelBlue = p[((y + i) * stride) + ((x + j) * 3)];

                            int weight = matrix[(i + 1) * matrixSize + (j + 1)];

                            red += pixelRed * weight;
                            green += pixelGreen * weight;
                            blue += pixelBlue * weight;
                        }
                    }

                    red = Math.Max(0, Math.Min(255, (red / factor) + offset));
                    green = Math.Max(0, Math.Min(255, (green / factor) + offset));
                    blue = Math.Max(0, Math.Min(255, (blue / factor) + offset));

                    pResult[(y * stride) + (x * 3)] = (byte)blue;
                    pResult[(y * stride) + (x * 3) + 1] = (byte)green;
                    pResult[(y * stride) + (x * 3) + 2] = (byte)red;
                }
            }
        }

        image.UnlockBits(bmData);
        result.UnlockBits(resultData);

        return result;
    }

    public static Bitmap GaussianBlur(Bitmap image)
    {
        int[] matrix =
        {
            1, 2, 1,
            2, 4, 2,
            1, 2, 1
        };
        int factor = 16;
        int offset = 0;
        return ApplyConvolution(image, matrix, factor, offset);
    }

    public static Bitmap Sharpen(Bitmap image)
    {
        int[] matrix =
        {
            0, -2, 0,
            -2, 11, -2,
            0, -2, 0
        };
        int factor = 3;
        int offset = 0;
        return ApplyConvolution(image, matrix, factor, offset);
    }

    public static Bitmap MeanRemoval(Bitmap image)
    {
        int[] matrix =
        {
            -1, -1, -1,
            -1, 9, -1,
            -1, -1, -1
        };
        int factor = 1;
        int offset = 0;
        return ApplyConvolution(image, matrix, factor, offset);
    }

    public static Bitmap Emboss(Bitmap image)
    {
        int[] matrix =
        {
            -2, -1, 0,
            -1, 1, 1,
            0, 1, 2
        };
        int factor = 1;
        int offset = 0;
        return ApplyConvolution(image, matrix, factor, offset);
    }

    public static Bitmap EmbossLaplascian(Bitmap image)
    {
        int[] matrix =
        {
            -1, 0, -1,
            0, 4, 0,
            -1, 0, -1
        };
        int factor = 1;
        int offset = 127;
        return ApplyConvolution(image, matrix, factor, offset);
    }

    public static Bitmap HorzVertical(Bitmap image)
    {
        int[] matrix =
        {
            0, -1, 0,
            -1, 4, -1,
            0, -1, 0
        };
        int factor = 1;
        int offset = 127;
        return ApplyConvolution(image, matrix, factor, offset);
    }

    public static Bitmap AllDirections(Bitmap image)
    {
        int[] matrix =
        {
            -1, -1, -1,
            -1, 8, -1,
            -1, -1, -1
        };
        int factor = 1;
        int offset = 127;
        return ApplyConvolution(image, matrix, factor, offset);
    }

    public static Bitmap Lossy(Bitmap image)
    {
        int[] matrix =
        {
            1, -2, 1,
            -2, 4, -2,
            -2, 1, -2
        };
        int factor = 1;
        int offset = 127;
        return ApplyConvolution(image, matrix, factor, offset);
    }

    public static Bitmap HorizontalOnly(Bitmap image)
    {
        int[] matrix =
        {
            0, 0, 0,
            -1, 2, -1,
            0, 0, 0
        };
        int factor = 1;
        int offset = 127;
        return ApplyConvolution(image, matrix, factor, offset);
    }

    public static Bitmap VerticalOnly(Bitmap image)
    {
        int[] matrix =
        {
            0, -1, 0,
            0, 2, 0,
            0, -1, 0
        };
        int factor = 1;
        int offset = 127;
        return ApplyConvolution(image, matrix, factor, offset);
    }

    public static Bitmap EdgeEnhance(Bitmap image)
    {
        int[] matrix =
        {
            0, 0, 0,
            -1, 1, 0,
            0, 0, 0
        };
        int factor = 1;
        int offset = 0;
        return ApplyConvolution(image, matrix, factor, offset);
    }

    public static Bitmap EdgeDetection(Bitmap image)
    {
        int[] matrix =
        {
            0, 1, 1,
            1, -4, 1,
            0, 1, 0
        };
        int factor = 1;
        int offset = 0;
        return ApplyConvolution(image, matrix, factor, offset);
    }
}
