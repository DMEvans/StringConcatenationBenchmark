namespace StringConcatenationBenchmark
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;

    public static class Test1
    {
        public static void Run(List<string> testSample)
        {
            var sw = new Stopwatch();

            sw.Start();

            var output = string.Empty;

            testSample.ForEach(x =>
            {
                output += x + ",";
            });

            sw.Stop();

            output = null;

            GC.Collect();

            Console.WriteLine("Test 1: {0}ms - Manual string concatenation", sw.ElapsedMilliseconds);
        }
    }
}