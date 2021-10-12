using System;
using System.Linq;

namespace Learning
{
    public class L_1025_DemocracyInDanger
    {
        //O(n*log n)
        public class Electorate
        {
            public void FindElectorateGroupCounCount()
            {
                int electorateGroupCount = int.Parse(Console.ReadLine());
                if (electorateGroupCount % 2 != 0 && electorateGroupCount >= 1 && electorateGroupCount <= 101)
                {
                    var electorateGroup = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                    Array.Sort(electorateGroup);
                    int needToWinElectorateGroup = electorateGroupCount / 2;
                    int result = 0;
                    for (int i = 0; i <= needToWinElectorateGroup; i++)
                    {
                        result += (electorateGroup[i] / 2) + 1;
                    }
                    Console.WriteLine(result);
                }
            }
        }
    }
}
