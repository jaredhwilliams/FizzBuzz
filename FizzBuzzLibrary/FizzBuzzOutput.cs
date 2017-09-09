using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.Library
{
    public class FizzBuzzOutput
    {
        public IEnumerable<string> GetFizzBuzzOutput(List<KeyValuePair<int, string>> pairs, int upperBound)
        {
            for (int i = 1; i <= upperBound; ++i)
            {
                var currentOutput = string.Empty;
                if (pairs != null)
                {
                    foreach (var pair in pairs)
                    {
                        if (i % pair.Key == 0)
                            currentOutput += pair.Value;
                    }
                }
                if (string.IsNullOrEmpty(currentOutput))
                    currentOutput += i.ToString();

                yield return currentOutput;
            }
        }
    }
}
