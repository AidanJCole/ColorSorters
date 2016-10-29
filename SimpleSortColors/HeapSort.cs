using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SimpleSortColors
{
    class HeapSort : Sort
    {
        public HeapSort(int[] aValue, Bitmap aBitmap)
            : base(aValue, "Heap Sort", aBitmap)
        {

        }

        public override void sort()
        {
            // Build a heap out of the array
            heapify();

            int end = values.Length - 1;
            while(end > 0)
            {
                swap(end, 0);
                end -= 1;
                siftDown(0, end);
                int i = 0;
            }
            
        }

        private void heapify()
        {
            int start = values.Length - 1;

            while (start >= 0)
            {
                siftDown(start, values.Length - 1);
                start--;
            }
        }

        private void siftDown(int start, int end)
        {
            if (start == end) return;
            while(start < end)
            {
                int r = getRightChild(start);
                int l = getLeftChild(start);

                int bigger = r > end && l > end ? start :
                    r > end ? l :
                    l > end ? r :
                    values[r] < values[l] ? l : r;

                if(values[start] >= values[bigger])
                {
                    return;
                }
                else
                {
                    
                        swap(start, bigger);
                        start = bigger;
                    
                }
                if (start > end)
                        return;
            }
        }

        private int getParent(int i)
        {
            return (i - 1) / 2;
        }

        private int getLeftChild(int i)
        {
            return 2 * i + 1;
        }

        private int getRightChild(int i)
        {
            return 2 * i + 2;
        }
    }
}
