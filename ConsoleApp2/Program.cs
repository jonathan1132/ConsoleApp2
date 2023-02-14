using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var result = new Dictionary<int, string>
            {
                {1, "asd" },
                {2, "ok" },
            };

            result.ToList().ForEach(x =>
            Console.WriteLine($"{x.Key} - {x.Value}"));
        }
    }
}
