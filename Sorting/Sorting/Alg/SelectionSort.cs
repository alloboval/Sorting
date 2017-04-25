namespace Sorting.Alg
{
    class SelectionSort
    {
        public static int counter;
        public static int[] Sort(int[] values, bool flag)
        {
            counter = 0;
            for(int i = 0; i < values.Length - 1; i++)
            {
                int min = i;
                for(int j = i + 1; j < values.Length; j++)
                    {
                        if (flag ? (values[j] < values[min]) : (values[j] > values[min]))
                        {
                            min = j;
                        }
                    }
                int buff = values[i];
                values[i] = values[min];
                values[min] = buff;
                counter++; 
            }
            return values;
        }
    }
}
