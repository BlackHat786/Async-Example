using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncExample
{
   public class Program
    {
        static void Main(string[] args)
        {
            Work();
            Done();
            Today();
            Console.ReadKey();
        }

        static void Work()
        {
            Console.Write("Welcome ");
        }

        static async Task Done()
        {
            await Task.Delay(1000); //Creates a task that completes after a specified number of milliseconds.
            Console.Write("To Async Programming");
        }

        static void Today()
        {
            Console.Write(" Class, ");
        }
    }
}
