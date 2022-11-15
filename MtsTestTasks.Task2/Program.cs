using System.Globalization;

namespace MtsTestTasks.Task2
{
    class Program
    {
        static readonly IFormatProvider _ifp = CultureInfo.InvariantCulture;

        class Number
        {
            readonly int _number;

            public Number(int number)
            {
                _number = number;
            }

            public static string operator + (Number obj1, string obj2)
            {
                return Convert.ToString(obj1._number + Int32.Parse(obj2));
            }

            public override string ToString()
            {
                return _number.ToString(_ifp);
            }
        }

        static void Main(string[] args)
        {
            int someValue1 = 10;
            int someValue2 = 5;

            string result = new Number(someValue1) + someValue2.ToString(_ifp);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}