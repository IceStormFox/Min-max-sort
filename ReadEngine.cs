using System.Diagnostics;

namespace Min_max_sort
{
    internal class ReadEngine
    {
        public static void Reader(string path)
        {
            string czytnik;
            int indeks = 0;
            int[] array = new int[200000];
            Stopwatch timer = new Stopwatch();
            StreamReader dane;

            dane = new StreamReader(path);
            while ((czytnik = dane.ReadLine()) != null)
            {
                array[indeks] = int.Parse(czytnik);
                indeks++;
            }

            timer.Start();
            SortEngine.Sort(array);
            timer.Stop();


            Console.WriteLine("Czas wykonania sortowania: {0} ms", timer.ElapsedMilliseconds);
        }
    }
}
