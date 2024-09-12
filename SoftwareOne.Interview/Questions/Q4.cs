// ReSharper disable AccessToModifiedClosure
namespace SoftwareOne.Interview.Questions;

internal class Q4
{
    public void Test()
    {
        for (int i = 0; i < 10; i++)
        {
            Task.Factory.StartNew(() => Console.WriteLine(i));
        }
    }
}