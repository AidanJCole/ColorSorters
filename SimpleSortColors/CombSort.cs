using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SimpleSortColors
{
    class CombSort : Sort
    {
        public CombSort(int[] aValue, Bitmap bitmap) 
            :base(aValue, "Comb Sort", bitmap)
        {

        }

        public override void sort()
        {
            int gap = values.Length;
            float shrink = 1.3f;

            while(gap > 0)
            {
                gap = (int)(gap / shrink);
               
                for (int i = 0; i < values.Length - gap; i++)
                {
                    if (values[i] > values[i + gap])
                    {
                        swap(i, i + gap);
                    }

                }
            }
            gap = 1;
            for (int i = 0; i < values.Length - gap; i++)
            {
                if (values[i] > values[i + gap])
                {
                    swap(i, i + gap);
                }

            }
        }
    }
}
