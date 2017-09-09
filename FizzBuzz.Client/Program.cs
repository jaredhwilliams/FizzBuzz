using FizzBuzz.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            var fbo = new FizzBuzzOutput();
            var pairs = new List<KeyValuePair<int, string>>()
            {
                new KeyValuePair<int, string>(3, "Fizz"),
                new KeyValuePair<int, string>(5, "Buzz"),
            };
            int upperBound = 15;

            var fbOutput = fbo.GetFizzBuzzOutput(pairs, upperBound);

            foreach(var result in fbOutput)
                Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
