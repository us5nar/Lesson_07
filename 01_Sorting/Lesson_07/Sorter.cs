using System;

namespace Lesson_07
{
    abstract class Sorter<T> : ISorter<T>
    //Inherits Print and Sort methods from interfaces
    //implements swap
    {
        public T[] inputArray;
        public abstract T[] Sort(); //Will be created in cilds
        public void Print()
        {
            Console.WriteLine("_____________SORTED_______________");
            foreach (T element in inputArray)
            {
                Console.WriteLine("{0,6}", element);
            }
        }
        protected T[] Swap(T[] arrayToSwap, int indexA, int indexB)
        {
            T temp = arrayToSwap[indexA];
            arrayToSwap[indexA] = arrayToSwap[indexB];
            arrayToSwap[indexB] = temp;
            return arrayToSwap;
        }
    }
}
