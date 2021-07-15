using System;
using System.Collections.Generic;

namespace ch3_sec25_generic_method
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args is null)
            {
                throw new ArgumentNullException(nameof(args));
            }

            var listFirst = new List<string>() { "a", "b", "C" };
            var listSecond = new List<string>() { "D", "e", "最後は日本語" };
            var comma = new CommaSeparatedListBuilder();

            comma.Add(listFirst);
            comma.Add(listSecond);
            Console.WriteLine(comma.ToString());
        }
    }
}
