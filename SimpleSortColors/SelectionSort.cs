using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SimpleSortColors
{
    class SelectionSort : Sort
    {
        public SelectionSort(int[] values, Bitmap myBitmap)
            :base(values, "Selection Sort", myBitmap)
        {

        }

        public override void sort()
        {
            for (int i = 0; i < values.Length - 1; i++)
            {
                int minj = i;
                for (int j = i+1; j < values.Length; j++)
                {
                    if(values[minj] > values[j])
                    {
                        minj = j;
                    }
                }
                if(minj != i)
                {
                    swap(minj, i);
                }
            }
        }
    }
}
