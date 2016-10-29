using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SimpleSortColors
{
    class GnomeSort : Sort
    {

        public GnomeSort(int[] Values, Bitmap aBitmap)
            : base(Values, "GnomeSort", aBitmap)
        {

        }
        public override void sort()
        {
            int pos = 1;
            while (pos < values.Length)
            {
                if (values[pos] >= values[pos - 1])
                    pos++;
                else {
                    swap(pos, pos - 1);
                    if (pos > 1)
                        pos--;
                }
                 
            }
        }
        
    }
}
