namespace MtsTestTasks.Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new[] { 1, 2, 3, 4, 5 };

            var result = array.EnumerateFromTail(100);

            Console.WriteLine($"Result:");
            foreach (var item in result)
            {
                Console.Write($"({item.item}, {item.tail}) ");
            }
        }
    }

    static class Extensions
    {
        public static IEnumerable<(T item, int? tail)> EnumerateFromTail<T>(this IEnumerable<T> enumerable, int? tailLength)
        {
            var result = new List<(T, int?)>();

            var items = enumerable.ToList();

            int moreItems = 0;

            for (int i = 0; i < items.Count; i++)
            {
                moreItems = items.Count - i;

                if (moreItems <= tailLength)
                {
                    result.Add((items[i], moreItems - 1));
                }
                else
                {
                    result.Add((items[i], null));
                }
            }
            return result;
        }
    }
}