namespace Sorting.Alg
{
    class InsertionSort
    {
        public static int counter;
        public static int[] Sort(int[] values, bool flag)
        {
            counter = 0;
            if (flag)
            {
                for (int i = 1; i < values.Length; i++)
                    for (int j = i; j > 0 && values[j - 1] > values[j]; j--)
                    {
                        counter++;
                        int buff = values[j - 1];
                        values[j - 1] = values[j];
                        values[j] = buff;
                    }
            }
            else
            {
                for (int i = 1; i < values.Length; i++)
                    for (int j = i; j > 0 && values[j - 1] < values[j]; j--)
                    {
                        int buff = values[j - 1];
                        values[j - 1] = values[j];
                        values[j] = buff;
                    }
            }
            return values;
        }
    }
}
