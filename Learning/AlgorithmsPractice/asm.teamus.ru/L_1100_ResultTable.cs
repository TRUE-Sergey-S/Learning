using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningPractice
{
    class ResultTable_1100
    {
        struct Team
        {
            public int Id;
            public byte Score;
        }
        public void StartMethod() {
            int teamCount = int.Parse(Console.ReadLine());
            var teamArray = new Team[teamCount];
            for (int i = 0; i < teamCount; i++)
            {
                char ch = (char)Console.Read();
                int digit = 0;
                while (ch != '\n')
                {
                    if (ch == ' ')
                    {
                        teamArray[i].Id = (int)digit;
                        digit = 0;
                        ch = (char)Console.Read();
                    }
                    if (ch == '\r')
                    {
                        teamArray[i].Score = (byte)digit;
                    }
                    else
                    {
                        digit = (digit * 10) + (ch - '0');
                    }
                    ch = (char)Console.Read();
                }
            }
            foreach (var item in teamArray.OrderByDescending(x => x.Score))
            {
                Console.Write(item.Id);
                Console.Write(' ');
                Console.WriteLine(item.Score);
            }
        }
    }
}
