using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RageQuit
{
    class RageQuit
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToUpper();
            string pattern = @"(\D+)(\d+)";
            Regex regex = new Regex(pattern);
            int count = 0;
            StringBuilder output = new StringBuilder();

            MatchCollection collection = regex.Matches(input);

            foreach (Match match in collection)
            {
                for (int i = 0; i < int.Parse(match.Groups[2].ToString()); i++)
                {
                    output.Append(match.Groups[1]);
                }
            }

            count = output.ToString().Distinct().Count();

            Console.WriteLine($"Unique symbols used: {count}");
            Console.WriteLine($"{output}");
        }
    }
}
