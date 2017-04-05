namespace StringConcatenationBenchmark
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Text;

    public static class Test5
    {
        public static void Run(List<string> testSample)
        {
            var sw = new Stopwatch();

            sw.Start();

            var builder = new StringBuilder();
            int i = 1;

            testSample.ForEach(x =>
            {
                builder.Append("Test String")
                       .Append(" ")
                       .Append(i)
                       .Append(" = ")
                       .Append(x)
                       .Append(",");
                ++i;
            });

            var output = builder.ToString();

            sw.Stop();

            output = null;

            GC.Collect();

            Console.WriteLine("Test 5: {0}ms - Append Chaining", sw.ElapsedMilliseconds);
        }
    }
}