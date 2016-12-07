using System;

namespace Lesson_07
{
    class BubSorter<T>:Sorter<T>
    {
        public override T[] Sort()
        {
             if (!(inputArray[0] is IComparable))
            {
                return inputArray;
            }
            bool elementsSwapped = true;
            while (elementsSwapped)
            //Sort untill no sapping is present
            {
                elementsSwapped = false;
                int n = 0;
                do
                {
                    IComparable currentValue = (IComparable)inputArray[n];
                    IComparable nextVale = (IComparable)inputArray[n + 1];
                    if (currentValue.CompareTo(nextVale) > 0)
                    {
                        Swap(inputArray, n + 1, n);
                        elementsSwapped = true;
                    }
                    n++;
                }
                while (n < inputArray.Length - 1);
            }
            return inputArray;
        }
    }
}
