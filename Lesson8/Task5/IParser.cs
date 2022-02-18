namespace Lesson8.Task5
{
    internal interface IParser<T>
    {
        T Parse(string line, char separator);

    }
}