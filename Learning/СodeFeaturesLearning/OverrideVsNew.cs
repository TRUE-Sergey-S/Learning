using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningPractice
{
    public class OverrideVsNew
    {
        public class BaseClassNew {
           public void PrintMessage1() {
                Console.WriteLine("BC - PrintMessage 1");
           }
            public void PrintMessage2()
            {
                Console.WriteLine("BC - PrintMessage 2");
            }
        }
        public class DerivedClassNew : BaseClassNew {
            public new void PrintMessage2()
            {
                Console.WriteLine("DC - PrintMessage 2");
            }
        }

        public class BaseClassOverride
        {
            public void PrintMessage1()
            {
                Console.WriteLine("BC - PrintMessage 1");
            }
            public virtual void PrintMessage2()
            {
                Console.WriteLine("BC - PrintMessage 2");
            }
        }
        public class DerivedClassOverride : BaseClassOverride
        {
            public override void PrintMessage2()
            {
                Console.WriteLine("DC - PrintMessage 2");
            }
        }
    }
}
