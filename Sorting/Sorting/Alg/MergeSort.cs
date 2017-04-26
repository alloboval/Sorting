
namespace Sorting.Alg
{
    class MergeSort
    {
        public static double number;
        public static int[] Sort(int[] values)
        {
            if (values.Length > 1)
            {
                int[] left = new int[values.Length / 2];
                int[] right = new int[values.Length - left.Length];

                for (int i = 0; i < left.Length; i++)
                    left[i] = values[i];

                for (int i = 0; i < right.Length; i++)
                    right[i] = values[left.Length + i];

                if (left.Length > 1)
                    left = Sort(left);
                if (right.Length > 1)
                    right = Sort(right);

                values = MergeSorting(left, right);
            }

            return values;
        }

        public static int[] MergeSorting(int[] left, int[] right)
        {
            int[] buffer = new int[left.Length + right.Length];
            int i = 0;
            int l = 0;
            int r = 0;

            for (; i< buffer.Length; i++)
            {
                if (r >= right.Length)
                {
                    buffer[i] = left[l];
                    l++;
                }

                else if (l < left.Length && left[l] < right[r])
                {
                    buffer[i] = left[l];
                    l++;
                }

                else

                {
                    buffer[i] = right[r];
                    r++;

                    if (l < left.Length)
                        number += left.Length - l;
                }
            }
            return buffer;  
        }
    }
}
