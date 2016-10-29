using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace SimpleSortColors
{
    public abstract class Sort
    {
        protected int[] values;
        public string name;
        public int depth = 0;
        protected Bitmap picture;
        protected List<Pen> brushes;
        protected Graphics graphicsObj;
        protected Bitmap prevArray;
        public Sort(int[] aValues, string aName, Bitmap aBitmap)
        {
            values = aValues;
            name = aName;
            picture = aBitmap;
            brushes = new List<Pen>();
            for (int i = 0; i < values.Length; i++)
            {
                float r, g, b;
                float hue = (float)i / values.Length;
                HSVtoRGB(out r, out g, out b, hue * 360, 1f, 1f);
                brushes.Add(new Pen(
                    new SolidBrush(
                        Color.FromArgb(
                            (int)Math.Round(r * 255), 
                            (int)Math.Round(g * 255), 
                            (int)Math.Round(b * 255)))));
            }

            graphicsObj = Graphics.FromImage(picture);

            DrawArray();
        }

        public abstract void sort();

        public void swap(int i, int j)
        {
            int temp = values[i];
            values[i] = values[j];
            values[j] = temp;

            // Do array drawing logic here
            
            DrawArray();
        }

        public void DrawArray()
        {
            
                for (int i = 0; i < values.Length; i++)
                {
                    graphicsObj.DrawRectangle(brushes[values[i]], i, depth, 1, 1);
                }
            
            depth++;
        }

        void HSVtoRGB(out float r, out float g, out float b, float h, float s, float v)
        {
            int i;
            float f, p, q, t;
            if (s == 0)
            {
                // achromatic (grey)
                r = g = b = v;
                return;
            }
            h /= 60;            // sector 0 to 5
            i = (int)Math.Floor(h);
            f = h - i;          // factorial part of h
            p = v * (1 - s);
            q = v * (1 - s * f);
            t = v * (1 - s * (1 - f));
            switch (i)
            {
                case 0:
                    r = v;
                    g = t;
                    b = p;
                    break;
                case 1:
                    r = q;
                    g = v;
                    b = p;
                    break;
                case 2:
                    r = p;
                    g = v;
                    b = t;
                    break;
                case 3:
                    r = p;
                    g = q;
                    b = v;
                    break;
                case 4:
                    r = t;
                    g = p;
                    b = v;
                    break;
                default:        // case 5:
                    r = v;
                    g = p;
                    b = q;
                    break;
            }
        }
    }
}
