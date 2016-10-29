using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SimpleSortColors
{
    class StoogeSort : Sort
    {
        public StoogeSort(int[] Values, Bitmap myBitmap)
            :base(Values, "Stooge Sort", myBitmap)
        {

        }

        public override void sort()
        {
            recurSort(0, values.Length - 1);
        }

        private void recurSort(int i, int j)
        {
            if (values[i] > values[j])
            {
                swap(i, j);
            }

            if((j-i+1) > 2)
            {
                int t = (j - i + 1) / 3;
                recurSort(i, j - t);
                recurSort(i + t, j);
                recurSort(i, j - t);
            }
        }
    }
}
