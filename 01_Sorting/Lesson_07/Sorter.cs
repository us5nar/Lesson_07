using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_07
{
    abstract class Sorter<T> : ISorter<T>
    //Inherits Print and Sort methods from interfaces
    //implements swap
    {
        public abstract T[] Sort(T[] arrayToSort); //Will be created in cilds
        public void Print(T[] arrayToPrint)
        {
            Console.WriteLine("_____________SORTED_______________");
            foreach (T element in arrayToPrint)
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
