using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Allow customer to pass in own set of num/word pairs. As many
/// as they would like.
/// Unit test for 15 and other relevant use cases.
/// Use NUnit as the framework for testing.
/// Extra credit: add a build script to build solution and project.
/// any standard build script to compile, run tests, etc.
/// setup git source control in a fashion that would allow the team
/// to work in a CI manner.
/// Put on github when done and send Rayne the URL.
/// </summary>
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
