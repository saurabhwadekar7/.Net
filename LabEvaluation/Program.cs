namespace LabEvaluation
{    class SelectionSort<T> where T : IComparable<T>
    {
        public static void Sort(T[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                int minIndex = i;

                for (int j = i + 1; j < array.Length; j++)
                    if (array[j].CompareTo(array[minIndex]) < 0)
                        minIndex = j;

                (array[i], array[minIndex]) = (array[minIndex], array[i]);
            }
        }
    }

    class Program
    {
        static void Main()
        {
            decimal[] decimals = { 2.8m, 5.2m, 5.8m, 2.1m, 4.7m };
            SelectionSort<decimal>.Sort(decimals);
            Console.WriteLine("Sorted Decimals: " + string.Join(" ", decimals));

            int[] integers = { 13, 12, 52, 24, 44 };
            SelectionSort<int>.Sort(integers);
            Console.WriteLine("Sorted Integers: " + string.Join(" ", integers));

            float[] floats = { 3.5f, 1.2f, 5.8f, 2.1f, 4.7f };
            SelectionSort<float>.Sort(floats);
            Console.WriteLine("Sorted Floats: " + string.Join(" ", floats));

            double[] doubles = { 3.5, 1.2, 5.8, 2.1, 4.7 };
            SelectionSort<double>.Sort(doubles);
            Console.WriteLine("Sorted Doubles: " + string.Join(" ", doubles));
        }
    }

}