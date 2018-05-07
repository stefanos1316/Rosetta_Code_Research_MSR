using System;
using System.Drawing;

class Program
{
    static void Main()
    {
        Bitmap img1 = new Bitmap("../Lenna50.jpg");
        Bitmap img2 = new Bitmap("../Lenna100.jpg");
 
        if (img1.Size != img2.Size)
        {
            Console.Error.WriteLine("Images are of different sizes");
            return;
        }
 
        float diff = 0;
 	for (int i = 0; i < 10000; ++i) {
        for (int y = 0; y < img1.Height; y++)
        {
            for (int x = 0; x < img1.Width; x++)
            {
                diff += (float)Math.Abs(img1.GetPixel(x, y).R - img2.GetPixel(x, y).R) / 255;
                diff += (float)Math.Abs(img1.GetPixel(x, y).G - img2.GetPixel(x, y).G) / 255;
                diff += (float)Math.Abs(img1.GetPixel(x, y).B - img2.GetPixel(x, y).B) / 255;
            }
        }
 	}
      //  Console.WriteLine("diff: {0} %", 100 * diff / (img1.Width * img1.Height * 3));
    }
}
