using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = Environment.GetEnvironmentVariable("Release_ReleaseName") ?? $"Manual-{Environment.MachineName}";
            Console.WriteLine($"Hello World! {name}");
        }
    }
}
