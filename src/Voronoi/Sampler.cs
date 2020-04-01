using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;
using System.ComponentModel;
using BenTools.Data;
using BenTools.Mathematics;

namespace Voronoi
{
    internal sealed class Sampler : IDisposable
    {
        public enum Distribution
        {
            Uniform = 1,
            Normal = 2,
            UniformNormal = 3
        }

        public double ClusterSize
        {
            get;
            set;
        }
        public double Variance
        {
            get;
            set;
        }
        public int ClusterCount
        {
            get;
            set;
        }

        Color[,] image;
        Color?[,] sampledImage;

        public void Dispose()
        {
            image = null;
            sampledImage = null;

        }

        public Sampler(Image image)
        {
            this.image = BitmapToColorArray((Bitmap)image);
        }

        /// <summary>
        /// Metoda nacte pole barev z bitmapy
        /// </summary>
        /// <param name="bmp">Bitmapa, ze ktere se budou cist data</param>
        /// <returns>Pole barev</returns>
        public unsafe static Color[,] BitmapToColorArray(Bitmap bmp)
        {
            if (bmp == null)
                return null;

            Color[,] img = new Color[bmp.Width, bmp.Height];
            BitmapData data = bmp.LockBits(new Rectangle(0, 0, bmp.Width, bmp.Height), ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);

            for (int y = 0; y < data.Height; y++)
            {
                // vypocte ukazatel na zacatek y-teho radku
                int* retPos = (int*)((int)data.Scan0 + (y * data.Stride));

                int x = 0;
                while (x < data.Width)
                {
                    // vyplni pixel nahodnou barvou
                    img[x, y] = Color.FromArgb(*retPos);

                    // posun na dalsi pixel
                    retPos++; x++;
                }
            }
            bmp.UnlockBits(data);

            return img;
        }

        /// <summary>
        /// Metoda vytvori Bitmapu z pole barev
        /// </summary>
        /// <param name="pixels">Zadane pole barev</param>
        /// <returns>Vytvorena bitmapa</returns>
        public unsafe static Bitmap ColorArrayToBitmap(Color?[,] pixels)
        {
            if (pixels == null)
                return null;

            Bitmap bmp = new Bitmap(pixels.GetLength(0), pixels.GetLength(1));
            BitmapData data = bmp.LockBits(new Rectangle(0, 0, bmp.Width, bmp.Height), ImageLockMode.WriteOnly, PixelFormat.Format32bppArgb);

            for (int y = 0; y < data.Height; y++)
            {
                // vypocte ukazatel na zacatek y-teho radku
                int* retPos = (int*)((int)data.Scan0 + (y * data.Stride));

                int x = 0;
                while (x < data.Width)
                {
                    if (pixels[x, y] != null)
                    {
                        // vyplni pixel nahodnou barvou
                        *retPos = pixels[x, y].Value.ToArgb();
                    }
                    else
                    {
                        *retPos = Color.White.ToArgb();
                    }
                    // posun na dalsi pixel
                    retPos++; x++;
                }
            }
            bmp.UnlockBits(data);

            return bmp;
        }

        public Image Sample(Distribution distribution, int percent)
        {
            if (image == null)
                return null;

            int width = image.GetLength(0);
            int height = image.GetLength(1);
            int pixelCount = width * height;

            int count = (int)((float)(0.005f * percent * pixelCount) / 100f);
            int clusterCount = ClusterCount; //(int)(0.001f * (float)count);

            sampledImage = new Color?[width, height];

            double x = 0;
            double y = 0;

            double xOffset = 0;
            double yOffset = 0;

            for (int t = 0, clustert = -1; t < count; t++, clustert++)
            {
                switch (distribution)
                {
                    case Distribution.Uniform:
                        x = RandomProvider.NextUniform() * width;
                        y = RandomProvider.NextUniform() * height;
                        break;
                    case Distribution.Normal:
                        x = RandomProvider.NextNormal(0, width - 1, Variance);
                        y = RandomProvider.NextNormal(0, height - 1, Variance);
                        break;
                    case Distribution.UniformNormal:
                        if (clustert == clusterCount || clustert == -1)
                        {
                            xOffset = RandomProvider.NextUniform(ClusterSize, width - ClusterSize);
                            yOffset = RandomProvider.NextUniform(ClusterSize, height - ClusterSize);
                            clustert = 0;
                        }

                        x = xOffset + RandomProvider.NextNormal(-ClusterSize, ClusterSize, Variance);
                        y = yOffset + RandomProvider.NextNormal(-ClusterSize, ClusterSize, Variance);

                        break;

                    default: continue;
                }

                int lx = (int)x;
                int ly = (int)y;
                
                sampledImage[lx, ly] = image[lx, ly];
            }

            return ColorArrayToBitmap(sampledImage);
        }

        public BenTools.Data.HashSet<Vector> GetSampledData()
        {
            BenTools.Data.HashSet<Vector> sampledData = new BenTools.Data.HashSet<Vector>();
            sampledData.Clear();

            if (sampledImage == null)
                return null;

            for (int i = 0; i < sampledImage.GetLength(0); i++)
            {
                for (int j = 0; j < sampledImage.GetLength(1); j++)
                {
                    Color? c = sampledImage[i, j];

                    if (c != null)
                    {
                        sampledData.Add(new Vector(i, j));
                    }
                }
            }

            return sampledData;
        }
    }
}
