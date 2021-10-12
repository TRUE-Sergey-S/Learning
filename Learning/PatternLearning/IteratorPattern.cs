using System;
using System.Collections;

namespace Learning
{
    class IteratorPattern
    {
        public class Storage : IEnumerable, IEnumerator
        {
            private string[] storager;
            private int position = -1;
            public Storage(string[] _storager) {
                storager = _storager;
            }

            public IEnumerator GetEnumerator()
            {
                return storager.GetEnumerator();
            }

            public object Current {
                get {
                    if (position == -1 || position >= storager.Length)
                    {
                        throw new InvalidOperationException();
                    }
                    return storager[position];
                }
            }

            public bool MoveNext()
            {
                if (position < storager.Length - 1)
                {
                    position++;
                    return true;
                }
                else
                    return false;
            }

            public void Reset()
            {
                position = -1;
            }
        }
    }
}
