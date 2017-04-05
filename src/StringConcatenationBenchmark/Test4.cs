namespace StringConcatenationBenchmark
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Text;

    public static class Test4
    {
        public static void Run(List<string> testSample)
        {
            var sw = new Stopwatch();

            sw.Start();

            var builder = new StringBuilder();
            int i = 1;
            var format = "Test String {0} = {1},";

            testSample.ForEach(x =>
            {
                builder.AppendFormat(format, i, x);
                ++i;
            });

            var output = builder.ToString();

            sw.Stop();

            output = null;

            GC.Collect();

            Console.WriteLine("Test 4: {0}ms - StringBuilder.AppendFormat()", sw.ElapsedMilliseconds);
        }
    }
}