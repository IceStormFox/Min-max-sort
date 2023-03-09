namespace Min_max_sort
{
    internal class SortEngine
    {
        public static void Sort(int[] array)
        {
            int i, j, maxmin, indeks;

            for (i = 0; i < array.Length; i++)
            {
                maxmin = array[i];
                indeks = i;
                for (j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < maxmin)
                    {
                        maxmin = array[j];
                        indeks = j;
                    }
                }

                (array[indeks], array[i]) = (array[i], array[indeks]);
            }
        }
    }
}
