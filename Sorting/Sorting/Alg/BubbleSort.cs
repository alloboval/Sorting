namespace Sorting.Alg
{
    class BubbleSort
    {
        public static int counter;
        public static int[] Sort(int[] values, bool flag)
        {
            counter = 0;
            int buf;
            int min = values[0];
            for(int i = 0; i < values.Length; i++)
                for(int j = 0; j < values.Length; j++)
                    if (flag ? (values[j] > values[i]) : ((values[j] < values[i])))
                    {
                        buf = values[i];
                        values[i] = values[j];
                        values[j] = buf;
                        counter++;
                    }
            return values;
        }
    }
}
