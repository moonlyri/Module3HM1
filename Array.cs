using System;
using System.Collections;
using System.Linq;
using System.Collections.Generic;

namespace Module3HM1
{
    public class MyArray<T> : IEnumerable
    {
        private T[] array = new T[5];
        private int[] numbers;

        public int Size { get; set; }

        public int Count { get; set; }

        public int Capasity { get; set; }

        public int index { get; set; }

        public MyArray()
        {
            Size = 0;
            Capasity = 0;
            Count = 0;
            array = new T[Capasity];
        }

        public IEnumerator GetEnumerator()
        {
            return new ArrEnumerator(numbers);
        }

        public void Add(T item)
        {
            ResizeArray(ref array, item);
        }

        private void ResizeArray(ref T[] array, T item)
        {
            throw new NotImplementedException();
        }

        public void AddRange(IEnumerable<T> count)
        {
            foreach (var item in count)
            {
                Add(item);
            }
        }

        public bool Remove(T item)
        {
            var index = Array.IndexOf(array, item);
            RemoveAt(index);
            return true;
        }
    
        public T[] GetArray()
        {
            return array;
        }

        public void RemoveAt(int index)
        {
            for (int i = index; i < array.Length - 1; i++)
            {
                array[i] = array[i + 1];
            }
            Array.Resize(ref array, array.Length - 1);
        }

        public void Sort(ref T[] array, IComparable<T> comparer)
        {
            Array.Sort(array, (Array)comparer);
        }
    }
}