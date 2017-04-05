namespace StringConcatenationBenchmark
{
    using System;

    internal class Program
    {
        private static void Main(string[] args)
        {
            Experiment1();
            Console.WriteLine();
            Experiment2();

            Console.ReadKey();
        }

        private static void Experiment1()
        {
            var stringCount = 100000;
            var stringLength = 15;

            Console.WriteLine("Converting a list of {0} random strings of {1} characters to a single comma-separated string", stringCount, stringLength);
            Console.WriteLine();

            var testSample = Randomizer.GetRandomStrings(stringCount, stringLength);

            Test1.Run(testSample);
            Test2.Run(testSample);
            Test3.Run(testSample);

            testSample = null;

            GC.Collect();
        }

        private static void Experiment2()
        {
            var stringCount = 5000000;
            var stringLength = 15;

            var testSample = Randomizer.GetRandomStrings(stringCount, stringLength);

            Console.WriteLine("Converting a list of {0} random strings of {1} characters to a comma-separated formatted string", stringCount, stringLength);
            Console.WriteLine("Output Format: Test String {i} = {string}");
            Console.WriteLine("Example: Test String 1 = asnfjdjasafuafu,Test String 2 = 8sjHFYF73jsjf2s,Test String 3 = q9rasfUGafqr38K,...");
            Console.WriteLine();

            Test4.Run(testSample);
            Test5.Run(testSample);
            Test6.Run(testSample);

            testSample = null;

            GC.Collect();
        }
    }
}