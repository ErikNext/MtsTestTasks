namespace MtsTestTasks.Task4
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] array = new int[9] { 2, 5, 10, 4, 3, 12, 158, 7, 65 };

            var x = Sort(array, 3, 158);

            foreach (var b in x)
            {
                Console.WriteLine($"{b} ");
            }
        }


        // Не понял для чего нам SortFactor, поэтому просто отсортировал

        public static IEnumerable<int> Sort(IEnumerable<int> inputStream, int sortFactor, int maxValue)
        {
            if (sortFactor < 0)
                throw new ArgumentOutOfRangeException($"{nameof(sortFactor)} must be a positive number");

            if (maxValue > 2000)
                throw new ArgumentOutOfRangeException($"{nameof(maxValue)} must be positive and cannot exceed 2000");

            var array = inputStream.ToArray();
            int temp;

            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }

            return array;
        }
    }
}