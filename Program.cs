using System;
using System.Collections;

namespace Module3HM1
{
    public class Program 
    {
        static void Main(string[] args)
        {
            var firstArray = new MyArray<int>();
            firstArray.Add(1);
            firstArray.Add(2);
            firstArray.Add(5);
            firstArray.Add(8);
            firstArray.Add(31);
            firstArray.Remove(1);
            firstArray.RemoveAt(3);
        }
    }
}
