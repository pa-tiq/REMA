using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REMA
{
    public class Graficos
    {
        public Graficos(Graphics gr)
        {
            PlotFunction(gr);
        }

        private void PlotFunction(float xmin, float ymin, float xmax, float ymax,float dx, float dy)
        {
            Graphics gr;
            // Plot the function.
            using (Pen thin_pen = new Pen(Color.Black, 0))
            {
                // Horizontal comparisons.
                for (float x = xmin; x <= xmax; x += dx)
                {
                    float last_y = F1(x, ymin);
                    for (float y = ymin + dy; y <= ymax; y += dy)
                    {
                        float next_y = F1(x, y);
                        if (
                            ((last_y <= 0f) && (next_y >= 0f)) ||
                            ((last_y >= 0f) && (next_y <= 0f))
                           )
                        {
                            // Plot this point.
                            gr.DrawLine(thin_pen, x, y - dy, x, y);
                        }
                        last_y = next_y;
                    }
                } // Horizontal comparisons.

                // Vertical comparisons.
                for (float y = ymin + dy; y <= ymax; y += dy)
                {
                    float last_x = F1(xmin, y);
                    for (float x = xmin + dx; x <= xmax; x += dx)
                    {
                        float next_x = F1(x, y);
                        if (
                            ((last_x <= 0f) && (next_x >= 0f)) ||
                            ((last_x >= 0f) && (next_x <= 0f))
                           )
                        {
                            // Plot this point.
                            gr.DrawLine(thin_pen, x - dx, y, x, y);
                        }
                        last_x = next_x;
                    }
                } // Vertical comparisons.
            } // using thin_pen.
        }

        // The function.
        // x^3 / (Abs(y) + 1) - 4 * x^2 + 4 * x * y^2 - y * 6 + 6 = 0
        private float F1(float x, float y)
        {
            return (float)(x * x * x /
                (Math.Abs(y) + 1) - 4 * x * x + 4 * x * y * y - y * 6 + 6);
        }
    }
}
