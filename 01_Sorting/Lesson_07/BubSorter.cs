using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_07
{
    class BubSorter<T>:Sorter<T>
    {
        public override T[] Sort(T[] InputArray)
        {
            if (!(InputArray[0] is IComparable))
            {
                return InputArray;
            }
            bool elementsSwapped = true;
            while (elementsSwapped)
            //Sort untill no sapping is present
            {
                elementsSwapped = false;
                int n = 0;
                do
                {
                    IComparable currentValue = (IComparable)InputArray[n];
                    IComparable nextVale = (IComparable)InputArray[n + 1];
                    if (currentValue.CompareTo(nextVale) > 0)
                    {
                        Swap(InputArray, n + 1, n);
                        elementsSwapped = true;
                    }
                    n++;
                }
                while (n < InputArray.Length - 1);
            }
            return InputArray;
        }
    }
}
