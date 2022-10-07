using System;
using System.Collections;
using System.Collections.Generic;

namespace Module3HM1
{
    public class ArrEnumerator : IEnumerator<int>
    {
        public int[] numbers;

        int position = -1;

        public ArrEnumerator(int[] numbers)
        {
            this.numbers = numbers;
        }

        public int Current
        {
            get
            {
                if (position == -1)
                {
                    throw new InvalidOperationException();
                }
                if (position >= numbers.Length)
                {
                    throw new InvalidOperationException();
                }
                return numbers[position];
            }
        }

        object IEnumerator.Current => throw new NotImplementedException();

        public bool MoveNext()
        {
            if (position < numbers.Length - 1)
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

        public void Dispose() { }
    }
}

