using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_07
{
    interface ISorter<T>:IPrintable<T>
    {
        T[] Sort(T[] ArrayToSort);
    }
}
