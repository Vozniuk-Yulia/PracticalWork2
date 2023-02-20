using System;
namespace Task4
{
    delegate int WorkWithLine(string line);
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> strings = new List<string> { "grape", "apple", "cucumber", "tomatos", "oil" };
            WorkWithLine length = s => s.Length;
            foreach (string line in strings)
            {
                Console.WriteLine($"{line}: {length(line)}");
            }
        }
    }
}