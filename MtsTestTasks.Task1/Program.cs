using System.Diagnostics;
using System.Runtime.InteropServices;

namespace MtsTestTasks.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                FailProcess1();
            }
            catch
            {
            }

            Console.WriteLine("Failed to fail process!");
            Console.ReadKey();
        }

        static void FailProcess1()
        {
            Process.GetCurrentProcess().Kill();
        }

        static void FailProcess2()
        {
            Environment.Exit(0);
        }

        static async void FailProcess3()
        {
            throw new Exception();
        }

        static void FailProcess4()
        {
            FailProcess4();
        }

        static void FailProcess5()
        {
            Environment.FailFast("Error");
        }

        static void FailProcess6()
        {
            object p = 0;
            IntPtr pnt = (IntPtr)0x123456789;
            Marshal.StructureToPtr(p, pnt, false);
        }
    }
}
