using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace REMA
{
    public class Graficos
    {
        private Calculos cal;
        private Parametros par;
        private float Vymin, Vymax;
        private float Mymin, Mymax;

        public Graficos(Calculos c, Parametros p)
        {
            cal = c;
            par = p;

            var tv = encontrarMinMaxV(c);
            var tm = encontrarMinMaxM(c);

            Vymin = tv.Item1 * (float)1.7;
            Vymax = tv.Item2 * (float)1.7;
            Mymin = tm.Item1 * (float)1.7;
            Mymax = tm.Item2 * (float)1.7;
        }

        private Tuple<float,float> encontrarMinMaxM(Calculos c)
        {
            float max = (float)0.0;
            float min = (float)0.0;

            var m1 = getMinMax(c.plotM1, (float)0.0, (float)cal.LP);
            var m2 = getMinMax(c.plotM2, (float)cal.LP, (float)cal.LF);
            var m3 = getMinMax(c.plotM3, (float)cal.LF, (float)cal.LT);
            
            if (min > m1.Item1) min = m1.Item1;
            if (min > m2.Item1) min = m2.Item1;
            if (min > m3.Item1) min = m3.Item1;
            if (max < m1.Item2) max = m1.Item2;
            if (max < m2.Item2) max = m2.Item2;
            if (max < m3.Item2) max = m3.Item2;

            return new Tuple<float,float> (min,max) ;
        }

        private Tuple<float, float> encontrarMinMaxV(Calculos c)
        {
            float max = (float)0.0;
            float min = (float)0.0;

            var v1 = getMinMax(c.plotV1, (float)0.0, (float)cal.LP);
            var v2 = getMinMax(c.plotV2, (float)cal.LP, (float)cal.LF);
            var v3 = getMinMax(c.plotV3, (float)cal.LF, (float)cal.LT);

            if (min > v1.Item1) min = v1.Item1;
            if (min > v2.Item1) min = v2.Item1;
            if (min > v3.Item1) min = v3.Item1;
            if (max < v1.Item2) max = v1.Item2;
            if (max < v2.Item2) max = v2.Item2;
            if (max < v3.Item2) max = v3.Item2;

            return new Tuple<float, float>(min, max);
        }

        private Tuple<float, float> getMinMax(Func<float, float> F, float xmin, float xmax)
        {
            float dx = (float)0.001;
            float max = (float)0.0;
            float min = (float)0.0;
            float fx = (float)0.0;

            for (float x = xmin; x <= xmax; x += dx)
            {
                fx = F(x);
                if (fx > max) max = fx;
                if (fx < min) min = fx;
            }
            return new Tuple<float, float>(min, max);
        }

        public void PlotV1(PictureBox gr)
        {
            MakeGraph(gr, cal.plotV1, (float)0.0, (float)cal.LP,
                Vymin, Vymax);
        }
        public void PlotV2(PictureBox gr)
        {
            MakeGraph(gr, cal.plotV2, (float)cal.LP, (float)cal.LF,
                Vymin, Vymax);
        }
        public void PlotV3(PictureBox gr)
        {
            MakeGraph(gr, cal.plotV3, (float)cal.LF, (float)cal.LT,
                Vymin, Vymax);
        }
        public void PlotM1(PictureBox gr)
        {
            MakeGraph(gr, cal.plotM1, (float)0.0, (float)cal.LP,
                Mymin, Mymax);
        }
        public void PlotM2(PictureBox gr)
        {
            MakeGraph(gr, cal.plotM2, (float)cal.LP, (float)cal.LF,
                Mymin, Mymax);
        }
        public void PlotM3(PictureBox gr)
        {
            MakeGraph(gr, cal.plotM3, (float)cal.LF, (float)cal.LT,
                Mymin, Mymax);
        }

        private void MakeGraph(PictureBox picGraph, Func<float, float> F, float xmin, float xmax, float ymin, float ymax)
        {

            // Make the Bitmap.
            int wid = picGraph.ClientSize.Width;
            int hgt = picGraph.ClientSize.Height;
            Bitmap bm = new Bitmap(wid, hgt);
            using (Graphics gr = Graphics.FromImage(bm))
            {
                gr.SmoothingMode = SmoothingMode.AntiAlias;

                // Transform to map the graph bounds to the Bitmap.
                RectangleF rect = new RectangleF(
                    xmin, ymin, xmax - xmin, ymax - ymin);
                PointF[] pts =
                {
                    new PointF(0, hgt),
                    new PointF(wid, hgt),
                    new PointF(0, 0),
                };
                gr.Transform = new Matrix(rect, pts);

                // Draw the graph.
                using (Pen graph_pen = new Pen(Color.Blue, 0))
                {
                    // Draw the axes.
                    gr.DrawLine(graph_pen, xmin, 0, xmax, 0);
                    gr.DrawLine(graph_pen, 0, ymin, 0, ymax);
                    for (int x = (int)xmin; x <= xmax; x++)
                    {
                        gr.DrawLine(graph_pen, x, -0.1f, x, 0.1f);
                    }
                    //for (int y = (int)ymin; y <= ymax; y++)
                    //{
                    //    gr.DrawLine(graph_pen, -0.1f, y, 0.1f, y);
                    //}
                    graph_pen.Color = Color.Red;

                    // See how big 1 pixel is horizontally.
                    Matrix inverse = gr.Transform;
                    inverse.Invert();
                    PointF[] pixel_pts =
                    {
                new PointF(0, 0),
                new PointF(1, 0)
            };
                    inverse.TransformPoints(pixel_pts);
                    float dx = pixel_pts[1].X - pixel_pts[0].X;
                    dx /= 2;

                    // Loop over x values to generate points.
                    List<PointF> points = new List<PointF>();
                    for (float x = xmin; x <= xmax; x += dx)
                    {
                        bool valid_point = false;
                        try
                        {
                            // Get the next point.
                            float y = F(x);

                            // If the slope is reasonable,
                            // this is a valid point.
                            if (points.Count == 0) valid_point = true;
                            else
                            {
                                float dy = y - points[points.Count - 1].Y;
                                if (Math.Abs(dy / dx) < 1000)
                                    valid_point = true;
                            }
                            if (valid_point) points.Add(new PointF(x, y));
                        }
                        catch
                        {
                        }

                        // If the new point is invalid, draw
                        // the points in the latest batch.
                        if (!valid_point)
                        {
                            if (points.Count > 1)
                                gr.DrawLines(graph_pen, points.ToArray());
                            points.Clear();
                        }

                    }

                    // Draw the last batch of points.
                    if (points.Count > 1)
                        gr.DrawLines(graph_pen, points.ToArray());
                }
            }

            // Display the result.
            picGraph.Image = bm;
        }
    }
}
