using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_07
{
    interface IPrintable<T>
    {
        void Print(T[] arrayToPrint);
    }
}
