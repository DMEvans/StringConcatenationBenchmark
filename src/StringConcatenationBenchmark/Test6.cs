﻿namespace StringConcatenationBenchmark
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Text;

    public static class Test6
    {
        public static void Run(List<string> testSample)
        {
            var sw = new Stopwatch();

            sw.Start();

            var builder = new StringBuilder();
            int i = 1;

            testSample.ForEach(x =>
            {
                builder.Append($"Test String {i} = {x},");
                ++i;
            });

            var output = builder.ToString();

            sw.Stop();

            output = null;

            GC.Collect();

            Console.WriteLine("Test 6: {0}ms - String Interpolation", sw.ElapsedMilliseconds);
        }
    }
}