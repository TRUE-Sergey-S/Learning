using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternLearning
{
    class StrategyPattern
    {
        private IStrategy _strategy;
        public interface IStrategy
        {
            int MakeAnAction(List<int> intList);
        }

        public StrategyPattern() {}
        
        public StrategyPattern(IStrategy strategy)
        {
            _strategy = strategy;
        }

        public void SetStrategy(IStrategy strategy)
        {
            _strategy = strategy;
        }

        public void UseStrategy(List<int> intList) {
            var result = _strategy.MakeAnAction(intList);
            Console.WriteLine(result);
        }

        internal class SumStrategy : IStrategy
        {
            public int MakeAnAction(List<int> intList)
            {
                Console.WriteLine("Do sum strategy");
                return intList.Sum();
            }
        }

        internal class MultipliStrategy : IStrategy
        {
            public int MakeAnAction(List<int> intList)
            {
                Console.WriteLine("Do multiplication strategy");
                int MultipliSumm = 0;
                foreach (var item in intList)
                {
                    if (MultipliSumm != 0)
                    {
                        MultipliSumm *= item;
                    }
                    else { MultipliSumm = item; }
                }
                return MultipliSumm;
            }
        }

        internal class MaxValueStrategy : IStrategy
        {
            public int MakeAnAction(List<int> intList)
            {
                Console.WriteLine("Do max value strategy");
                return intList.Max();
            }
        }
    }
}
