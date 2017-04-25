using System;
using Sorting.Alg;


namespace Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 123, 543, 654, 34, 645, 75, 234, 98, 23, 1, 5658, 980, 56, 231, 6, 35, 8, 923, 68, 34 } ;
            
            int[] c = InsertionSort.Sort(a, true);
            Console.WriteLine("Insertion sort, count: " + InsertionSort.counter);
            foreach (int i in c)
            {
                Console.Write(i + "  ");
            }
            c = SelectionSort.Sort(a, true);
            Console.WriteLine();
            Console.WriteLine("Selection sort, count: " + SelectionSort.counter);
            Console.WriteLine();
            foreach (int i in c)
            {
                Console.Write(i + "  ");
            }
            c = BubbleSort.Sort(a, true);
            Console.WriteLine();
            Console.WriteLine("Bubble sort, count: " + BubbleSort.counter);
            foreach (int i in c)
            {
                Console.Write(i + "  ");
            }
            Console.ReadKey();
        }
    }
}
