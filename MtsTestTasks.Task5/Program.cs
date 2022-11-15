namespace MtsTestTasks.Task5;

class Program
{
    static void Main(string[] args)
    {
        Method1();
    }

    #region Method1

    static void Method1()
    {
        TransformToElephant();
        Console.WriteLine("Муха");
        Console.ReadKey();
    }

    static void TransformToElephant()
    {
        Console.WriteLine("Слон");
        Console.SetOut(TextWriter.Null);
    }

    #endregion

    #region Method2

    static void Method2()
    {
        Task.Run(() => TransformToElephant2());

        Console.WriteLine("Муха");
        Console.ReadKey();
    }

    static void TransformToElephant2()
    {
        Thread.Sleep(300);
        Console.WriteLine("Слон");
    }

    #endregion
}