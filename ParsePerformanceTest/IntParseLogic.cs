using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace ParsePerformanceTest
{
    public class IntParseLogic: IParse
    {
        private readonly string _correctString;
        private readonly string _errorString;

        public IntParseLogic(string correctString,string errorString)
        {
            _correctString = correctString;
            _errorString = errorString;
        }

        public string Successful(int frequency)
        {
            var sw = Stopwatch.StartNew();
            
            for (var i = 0; i < frequency; i++)
            {
                getInt(_correctString);
            }
            sw.Stop();
            return $"Parse成功轉型: {sw.Elapsed}\r";
        }

        public string Unsuccessful(int frequency)
        {
            var sw = Stopwatch.StartNew();

            for (var i = 0; i < frequency; i++)
            {
                getInt(_errorString);
            }
            sw.Stop();
            return $"Parse失敗轉型: {sw.Elapsed}\r";
        }

        public string RandomConversion(List<string> data)
        {
            var sw = Stopwatch.StartNew();

            foreach (var item in data)
            {
                getInt(item);
            }
            sw.Stop();
            return $"Parse轉型-使用亂數: {sw.Elapsed}\r";
        }

        private int getInt(string objStr)
        {
            int retint = 0;
            try
            {
                retint = int.Parse(objStr);
            }
            catch
            {
                retint = 0;
            }
            return retint;
        }
    }
}
