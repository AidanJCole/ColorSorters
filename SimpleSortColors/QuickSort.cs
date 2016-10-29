using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SimpleSortColors
{
    class QuickSort : Sort
    {
        public QuickSort(int[] values, Bitmap myBitmap)
            :base(values, "Quick Sort", myBitmap)
        {

        }

        public override void sort()
        {
            recurSort(0, values.Length - 1);
        }

        private void recurSort(int i, int j)
        {
            if (i >= j)
                return;

            int mid = (int)Math.Ceiling((i + j) / 2.0);
            int median = Math.Max(Math.Min(values[i], values[mid]), Math.Min(Math.Max(values[i], values[mid]), values[j]));
            if (median == values[i])
                median = i;
            else if (median == values[mid])
                median = mid;
            else
                median = j;

            swap(median, i);

            mid = partition(i + 1, j);

            recurSort(i, mid - 1);
            recurSort(mid + 1, j);
        }

        private int partition(int i, int j)
        {
            int left = i, right = j;
            while (left < right)
            {
                while (values[left] <= values[i - 1] && left <= j && left < right) left++;
                while (values[right] >= values[i - 1] && right >= i) right--;
                if(right > left)
                    swap(left, right);
            }
            swap(i - 1, right);
            return right;
        }
    }
}
