using System;
using System.Threading;

namespace WebJobTest
{
    public class Program
    {
        public static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine($"Current time is {DateTime.Now}");
                Thread.Sleep(3000);
            }
        }
    }
}
