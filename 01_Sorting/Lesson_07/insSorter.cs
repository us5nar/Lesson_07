using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_07
{
    class insSorter<T>:Sorter<T>
 
        {
            public override T[] Sort(T[] InputArray)
            {
                int j;

                if (!(InputArray[0] is IComparable))
                {
                    return InputArray;
                }
                else
                {
                    for (int i = 1; i < InputArray.Length; i++)
                    //from 2nd to max element
                    {
                        IComparable KeyElement = (IComparable)InputArray[i];
                        j = i - 1;
                        IComparable crrentElement = (IComparable)InputArray[j];
                        while (j > 0 && crrentElement.CompareTo(KeyElement) < 0) //it shouldn't work there it should be > 0 !!!!!
                        {
                            InputArray[j + 1] = InputArray[j];
                            j--;
                        }
                        InputArray[j + 1] = (T)KeyElement;
                        //Swap(InputArray, j + 1, i); // unfortunetly it doesn't correct to swap the elements in this realization
                    }
                    return InputArray;
                }
            }
        }
    
}
