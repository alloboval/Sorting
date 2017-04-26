using System;
using Sorting.Alg;


namespace Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 123, 543, 654, 34, 645, 75, 234, 98, 23, 1, 5658, 980, 56, 231, 6, 35, 8, 923, 68, 34 } ;
            
            int[] c = MergeSort.Sort(a);
            c = SelectionSort.Sort(a, true);
            c = InsertionSort.Sort(a, true);
            c = BubbleSort.Sort(a, true);
        }
    }
}
