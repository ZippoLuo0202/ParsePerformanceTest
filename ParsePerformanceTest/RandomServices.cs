using System;
using System.Collections.Generic;
using System.Text;

namespace ParsePerformanceTest
{
    public class RandomServices
    {
        private readonly int _size;

        public RandomServices(int size)
        {
            _size = size;
        }

        public List<string> GetRandomList()
        {
            var combineList = new List<string>();
            combineList.AddRange(GetStringRandom());
            combineList.AddRange(GetNumberRandom());
            return combineList;

        }

        public List<string> GetNumberRandom()
        {
            var rand = new Random();
            var randomList = new List<string>();

            for (var i = 0; i < _size; i++)
            {
                randomList.Add(Convert.ToString(rand.Next(10000)));
            }
            return randomList;
        }

        public List<string> GetStringRandom()
        {
            var rand = new Random();
            var randomList = new List<string>();
            
            for (var i = 0; i < _size; i++)
            {
                randomList.Add(Guid.NewGuid().ToString("n").Substring(0, 8));
            }
            return randomList;
        }
    }
}
