using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SimpleSortColors
{
    class ShellSort : Sort
    {
        public ShellSort(int[] Values, Bitmap bitmap)
            : base(Values, "Shell Sort", bitmap)
        { }

        public override void sort()
        {
            List<int> gaps = new List<int>();
            int recent = 1;
            gaps.Add(recent);
            while(recent < values.Length)
            {
                recent = (int)Math.Ceiling(2.25 * gaps.Last() + 1);
                if (recent < values.Length) gaps.Add(recent);
            }

            gaps.Reverse();

            foreach(int gap in gaps)
            {
                for (int i = gap; i < values.Length; i++)
                {
                    int j = 0;
                    int temp = values[i];
                    for ( j = i; j >= gap && values[j - gap] > temp; j -= gap)
                    {
                        //values[j] = values[j - gap];
                        swap(j, j - gap);
                    }

                    //values[j] = temp;
                }
            }
        }
    }
}
