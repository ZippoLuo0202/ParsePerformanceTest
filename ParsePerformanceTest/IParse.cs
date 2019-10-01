using System;
using System.Collections.Generic;
using System.Text;

namespace ParsePerformanceTest
{
    public interface IParse
    {
        string Successful(int frequency);
        string Unsuccessful(int frequency);
        string RandomConversion(List<string> data);
        
    }
}
