using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Voronoi
{
    /// <summary>
    /// RandomProvider.  Provides random numbers of all data types
    /// in specified ranges.  It also contains a couple of methods
    /// from Normally (Gaussian) distributed random numbers and 
    /// Exponentially distributed random numbers.
    /// </summary>
    public sealed class RandomProvider
    {
        private static Random rnd = new Random();
        private static bool useLast = false;
        private static double y2;


        private RandomProvider()
        {

        }

        public static double NextUniform()
        {
            return rnd.NextDouble();
        }

        public static double NextUniform(double min, double max)
        {
            return min + rnd.NextDouble() * (max - min);
        }

        public static double NextNormal()
        {
            double x1, x2, w, y1;

            if (useLast)
            {
                y1 = y2;
                useLast = false;
            }
            else
            {
                do
                {
                    x1 = 2.0 * NextUniform() - 1.0;
                    x2 = 2.0 * NextUniform() - 1.0;
                    w = x1 * x1 + x2 * x2;
                } while (w >= 1.0);

                w = Math.Sqrt((-2.0 * Math.Log(w, Math.E)) / w);
                y1 = x1 * w;
                y2 = x2 * w;
                useLast = true;
            }

            return y1;
        }

        public static double NextNormal(double min, double max)
        {
            //for 4 are 99.98% of all random points between min and max (variance 2.4 - 98.36%) 
            return NextNormal(min, max, 4.0);
        }

        public static double NextNormal(double min, double max, double variance)
        {
            double average = (min + max) * 0.5f;
            double escala = (max - average) / variance;
            double x = escala * NextNormal() + average;

            x = Math.Max(x, min);
            x = Math.Min(x, max);

            return x;
        }
    }
}
