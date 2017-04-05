namespace StringConcatenationBenchmark
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;

    public static class Test3
    {
        public static void Run(List<string> testSample)
        {
            var sw = new Stopwatch();

            sw.Start();

            var output = string.Join(",", testSample.ToArray());

            sw.Stop();

            output = null;

            GC.Collect();

            Console.WriteLine("Test 3: {0}ms - string.Join()", sw.ElapsedMilliseconds);
        }
    }
}