using System;
using System.Collections.Generic;

namespace Module3HM1
{
    public class Result
    {
        private bool _status;

        public bool Status
        {
            get { return _status; }
        }

        public Result(bool status)
        {
            _status = status;
        }
    }

    public class ArrayComparer<T> : IComparer<T>
    {
        public int Compare(T x, T Y)
        {
            if (x.GetHashCode() > Y.GetHashCode())
            {
                return 1;
            }
            else if (x.GetHashCode() < Y.GetHashCode())
            {
                return -1;
            }

            return 0;
        }
    }
}

