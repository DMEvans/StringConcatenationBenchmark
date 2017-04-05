namespace StringConcatenationBenchmark
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public static class Randomizer
    {
        private const string _characterSet = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";

        public static List<string> GetRandomStrings(int count, int stringLength)
        {
            var stringList = new List<string>();

            for (int i = 0; i < count; ++i)
            {
                var random = new Random(i);

                var newString = new StringBuilder();

                for (int j = 0; j < stringLength; ++j)
                {
                    var index = random.Next(0, _characterSet.Length - 1);

                    newString.Append(_characterSet[index]);
                }

                stringList.Add(newString.ToString());
            }

            return stringList;
        }
    }
}