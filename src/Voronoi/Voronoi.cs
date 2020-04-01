using System;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using BenTools.Data;
using BenTools.Mathematics;

using scg = System.Collections.Generic;

namespace Voronoi
{
    class Voronoi : IDisposable
    {
        HashSet<Vector> points;
        scg.Dictionary<Vector, scg.List<PointF>> polygons;
        Image image;
        int progress = 0;

        struct WPointF
        {
            public double weight;
            public PointF point;
        }

        public void Dispose()
        {

        }

        public Voronoi(HashSet<Vector> sampledData)
        {
            this.points = sampledData;
        }

        public int GetProgressOfComputing()
        {
            return progress;
        }

        private scg.Dictionary<Vector, scg.List<PointF>> GetRegions(VoronoiGraph graph)
        {
            scg.Dictionary<Vector, scg.List<PointF>> output = new scg.Dictionary<Vector, scg.List<PointF>>();

            int i = 0;
            foreach (Vector v in this.points)
            {
                if (!output.ContainsKey(v))
                {
                    output.Add(v, new scg.List<PointF>());

                    foreach (VoronoiEdge edge in graph.Edges)
                    {
                        AddEdgeForVectorRegion(output, edge, v);
                    }
                }

                this.progress = 30 + (int)(((float)i / (float)this.points.Count) * 55f);

                i++;
            }

            scg.Dictionary<Vector, scg.List<PointF>> newOutput = new scg.Dictionary<Vector, scg.List<PointF>>();

            foreach(scg.KeyValuePair<Vector, scg.List<PointF>> region in output)
            {
                scg.List<WPointF> sort = SortRegion(region);

                newOutput.Add(region.Key, new scg.List<PointF>());

                foreach (WPointF pointf in sort)
                {
                    newOutput[region.Key].Add(pointf.point);
                }
            }

            output = newOutput;

            return output;
        }

        private scg.List<WPointF> SortRegion(scg.KeyValuePair<Vector, scg.List<PointF>> region)
        {
            scg.List<WPointF> sort = new scg.List<WPointF>();
            scg.List<PointF> lp = region.Value;

            float x = (float)region.Key[0];
            float y = (float)region.Key[1];

            for (int k = 0; k < region.Value.Count; k++)
            {
                PointF originalPoint = lp[k];

                PointF dir = new PointF(x, y);
                dir.X -= originalPoint.X;
                dir.Y -= originalPoint.Y;
                dir.X *= (float)(1.0 / Math.Sqrt(dir.X * dir.X + dir.Y * dir.Y));

                double alfa = Math.Acos(dir.X);

                if (dir.Y < 0)
                    alfa *= -1;

                WPointF p = new WPointF() { point = originalPoint, weight = alfa };
                sort.Add(p);
            }

            sort.Sort(new Comparison<WPointF>(PointComparer));
            return sort;
        }

        private int PointComparer(WPointF obj1, WPointF obj2)
        {
            if (obj1.weight > obj2.weight)
                return 1;
            else if (obj1.weight < obj2.weight)
                return -1;

            return 0;
        }

        public void AddEdgeForVectorRegion(scg.Dictionary<Vector, scg.List<PointF>> output, VoronoiEdge edge, Vector vector)
        {
            PointF p = new PointF((float)edge.VVertexA[0], (float)edge.VVertexA[1]);
            PointF p2 = new PointF((float)edge.VVertexB[0], (float)edge.VVertexB[1]);

            if (float.IsInfinity(p2.X))
            {
                p2.X = (float)edge.FixedPoint[0] + 1000f * (float)edge.DirectionVector[0];
            }

            if (float.IsInfinity(p2.Y))
            {
                p2.Y = (float)edge.FixedPoint[1] + 1000f * (float)edge.DirectionVector[1];
            }

            if (edge.LeftData.Equals(vector))
            {
                if (!output[vector].Contains(p))
                    output[vector].Add(p);

                if (!output[vector].Contains(p2))
                    output[vector].Add(p2);
            }

            if (edge.RightData.Equals(vector))
            {
                if (!output[vector].Contains(p))
                    output[vector].Add(p);

                if (!output[vector].Contains(p2))
                    output[vector].Add(p2);
            }
        }

        public Image ComputeVoronoiMap(Image image, bool drawEdges)
        {
            if (image == null || this.points.Count <= 0)
                return null;

            this.progress = 5;

            VoronoiGraph graph = Fortune.ComputeVoronoiGraph(this.points);
            Color[,] colors = Sampler.BitmapToColorArray((Bitmap)image);

            int width = colors.GetLength(0) - 1;
            int height = colors.GetLength(1) - 1;

            image = (Image)new Bitmap(width + 1, height + 1);
            Graphics g = Graphics.FromImage(image);

            this.progress = 30;

            polygons = GetRegions(graph);

            this.progress = 92;

            foreach (scg.KeyValuePair<Vector, scg.List<PointF>> region in polygons)
            {
                Vector v = region.Key;
                int ix = Math.Min(Math.Max((int)Math.Round(v[0]), 0), width);
                int iy = Math.Min(Math.Max((int)Math.Round(v[1]), 0), height);

                PointF[] ps = region.Value.ToArray();
                
                g.FillPolygon(new SolidBrush(colors[ix, iy]), ps, FillMode.Alternate);
            }

            g.Flush();

            this.image = image;

            this.progress = 95;

            if (drawEdges)
                DrawEdges(image);

            this.progress = 100;

            return image;
        }

        public void DrawEdges(Image image)
        {
            Graphics g = Graphics.FromImage(image);

            foreach (scg.KeyValuePair<Vector, scg.List<PointF>> region in polygons)
            {
                PointF[] ps = region.Value.ToArray();
                g.DrawPolygon(Pens.Black, ps);
            }

            g.Flush();
        }

        public Image GetVoronoiMap()
        {
            return image;
        }

    }
}
