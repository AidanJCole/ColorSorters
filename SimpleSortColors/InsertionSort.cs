using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SimpleSortColors
{
    class InsertionSort : Sort
    {
        public InsertionSort(int[] values, Bitmap myBitmap)
            :base(values, "Insertion Sort", myBitmap)
        {

        }

        public override void sort()
        {
            for (int i = 1; i < values.Length; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    if(values[j] < values[j-1])
                    {
                        swap(j-1, j);
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }
    }
}
