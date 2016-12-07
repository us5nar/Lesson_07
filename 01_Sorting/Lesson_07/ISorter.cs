namespace Lesson_07
{
    interface ISorter<T>:IPrintable<T>
    {
        T[] Sort();
    }
}