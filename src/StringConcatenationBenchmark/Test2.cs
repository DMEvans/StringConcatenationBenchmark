namespace StringConcatenationBenchmark
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Text;

    public static class Test2
    {
        public static void Run(List<string> testSample)
        {
            var sw = new Stopwatch();

            sw.Start();

            var builder = new StringBuilder();

            testSample.ForEach(x =>
            {
                builder.Append(x + ",");
            });

            var output = builder.ToString();

            sw.Stop();

            output = null;

            GC.Collect();

            Console.WriteLine("Test 2: {0}ms - StringBuilder.Append()", sw.ElapsedMilliseconds);
        }
    }
}