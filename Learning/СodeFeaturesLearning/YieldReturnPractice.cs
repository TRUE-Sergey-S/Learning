using System;
using System.Collections.Generic;

namespace Learning
{
    public class YieldReturnPractice
    {
        string[] stringArrey;
        public YieldReturnPractice() {
            int size = 10000;
            Random rnd = new Random();
            stringArrey = new string[size];
            for (int i = 0; i < stringArrey.Length; i++)
            {
                stringArrey[i] = rnd.Next(0, 1000000).ToString();
            }
        }
        public IEnumerable<string> GetArrey() {
            foreach (var item in stringArrey)
            {
                yield return item;
            }
        }
    }
}
