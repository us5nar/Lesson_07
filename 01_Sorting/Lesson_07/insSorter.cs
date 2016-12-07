using System;
namespace Lesson_07
{
    class insSorter<T>:Sorter<T>
         {
            public override T[] Sort()
            {
                int j;
                if (!(inputArray[0] is IComparable))
                {
                    return inputArray;
                }
                else
                {
                    for (int i = 1; i < inputArray.Length; i++)
                    //from 2nd to max element
                    {
                        IComparable KeyElement = (IComparable)inputArray[i];
                        j = i - 1;
                        IComparable crrentElement = (IComparable)inputArray[j];
                        while (j > 0 && crrentElement.CompareTo(KeyElement) < 0) //it shouldn't work there it should be > 0 !!!!!
                        {
                            inputArray[j + 1] = inputArray[j];
                            j--;
                        }
                        inputArray[j + 1] = (T)KeyElement;
                        //Swap(InputArray, j + 1, i); // unfortunetly it doesn't correct to swap the elements in this realization
                    }
                    return inputArray;
                }
            }
        }
}
