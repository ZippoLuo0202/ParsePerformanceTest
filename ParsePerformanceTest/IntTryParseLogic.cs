using System.Collections.Generic;
using System.Diagnostics;

namespace ParsePerformanceTest
{
    public class IntTryParseLogic: IParse
    {
        private readonly string _correctString;
        private readonly string _errorString;

        public IntTryParseLogic(string correctString, string errorString)
        {
            _correctString = correctString;
            _errorString = errorString;
        }

        public string Successful(int frequency)
        {
            var sw = Stopwatch.StartNew();

            for (var i = 0; i < frequency; i++)
            {
                ConversionString(_correctString);
            }
            sw.Stop();
            return $"TryParse成功轉型: {sw.Elapsed}\r";
        }

        public string Unsuccessful(int frequency)
        {
            var sw = Stopwatch.StartNew();

            for (var i = 0; i < frequency; i++)
            {
                ConversionString(_errorString);
            }
            sw.Stop();
            return $"TryParse失敗轉型: {sw.Elapsed}\r";
        }

        public string RandomConversion(List<string> data)
        {
            var sw = Stopwatch.StartNew();

            foreach (var item in data)
            {
                ConversionString(item);
            }
            sw.Stop();
            return $"TryParse轉型-使用亂數: {sw.Elapsed}\r";
        }

        private static int ConversionString(string str)
        {
            return int.TryParse(str, out var temp) ? temp : 0;
        }
    }
}