using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace SimpleSortColors
{
    class MergeSort : Sort
    {
        public MergeSort(int[] values, Bitmap myBitmap)
            :base(values, "Merge Sort", myBitmap)
        {

        }

        public override void sort()
        {
            recurSort(0, values.Length-1);
        }

        private int[] recurSort(int i, int j)
        {
            if(j == i)
            {
                return new int[] { values[i] };
            }
            int mid = (i + j) / 2;

            int[] a1 = recurSort(i, mid);
            int[] a2 = recurSort(mid + 1, j);

            int token1 = 0;
            int token2 = 0;

            for (int v = 0; v < a1.Length + a2.Length; v++)
            {
                if (a1.Length == token1)
                {
                    values[i + v] = a2[token2];
                    token2++;
                }
                else if (a2.Length == token2)
                {
                    values[i + v] = a1[token1];
                    token1++;
                }
                else if(a1[token1] > a2[token2])
                {
                    values[i+v] = a2[token2];
                    token2++;
                }
                else
                {
                    values[i + v] = a1[token1];
                    token1++;
                }
            }
            DrawArray();
            int[] temp = new int[j-i+1];
            Array.Copy(values, i, temp, 0, j - i+1);
            return temp;
        }
    }
}
