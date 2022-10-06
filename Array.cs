using System;
using System.Collections;
using System.Linq;
using System.Collections.Generic;

namespace Module3HM1
{
    public class Arr : IEnumerable
    {
        int[] arr = { 1, 2, 3, 4, 5 };
        int item = 6;
        int index = 3;
        ArrayList List = new ArrayList();
        Queue queue = new Queue();
        public IEnumerator GetEnumerator()
        {
            return new ArrEnumerator(arr);
        }
        public void Add()
        {
            int[] result = (int[])arr.Append(item);
        }
        public void AddRange()
        {
            queue.Enqueue(item);
            List.Add(arr);
            List.AddRange(queue);
        }
        public Result Remove()
        {
            List.Remove(item);
            return new Result(true);
        }
        public static void Resize<T>(ref T[]? array, int newSize)
        {

        }
        public void RemoveAt()
        {
            for (int i = index; i < arr.Length - 1; i++)
            {
                arr[i] = arr[i + 1];
            }
            Array.Resize<int>(ref arr, arr.Length - 1);
        }
        public void Sort()
        {
            Array.Sort(arr);
        }
    }
}

