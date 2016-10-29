using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SimpleSortColors
{
    public class BubbleSort : Sort
    {
        public BubbleSort(int[] values, Bitmap myBitmap)
            :base(values, "Bubble Sort", myBitmap)
        {

        }
        
        public override void sort()
        {
            bool sorted = false;
            while (!sorted)
            {
                sorted = true;
                for(int i = 0; i < values.Length -1; i++)
                {
                    if(values[i] > values[i + 1])
                    {
                        swap(i, i + 1);
                        sorted = false;
                    }
                }
            }
        }
    }
}
