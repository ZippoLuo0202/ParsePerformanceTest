using System;
using System.Collections.Generic;
using System.Text;

namespace ParsePerformanceTest
{
    public class Program
    {
        private const int Frequency = 10000;
        private const string CorrectString = "187145";
        private const string ErrorString = "gyikgvbkuyiv";

        private static void Main(string[] args)
        {
            var data = new RandomServices(Frequency).GetRandomList();//取得亂數size*2(數字+字串)
            var intTryParseLogic =  new IntTryParseLogic(CorrectString, ErrorString);
            var intParseLogic = new IntParseLogic(CorrectString, ErrorString);
            Console.WriteLine($"成功轉型測試數:{Frequency}\n失敗轉型測試數:{Frequency}\n亂數轉型測試數:{Frequency*2}\n");

            Console.WriteLine(intTryParseLogic.Successful(Frequency));
            Console.WriteLine(intParseLogic.Successful(Frequency));
            Console.WriteLine("\n");
            Console.WriteLine(intTryParseLogic.Unsuccessful(Frequency));
            Console.WriteLine(intParseLogic.Unsuccessful(Frequency));
            Console.WriteLine("\n");
            Console.WriteLine(intTryParseLogic.RandomConversion(data));
            Console.WriteLine(intParseLogic.RandomConversion(data));

            Console.ReadLine();
        }

        
    }

    
}
