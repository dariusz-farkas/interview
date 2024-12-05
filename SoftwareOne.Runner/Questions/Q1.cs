using SoftwareOne.Runner.Items;
using Xunit.Abstractions;

namespace SoftwareOne.Runner.Questions;

public class Q1
{
    public Q1(ITestOutputHelper output)
    {
        Console.SetOut(new TestWriter(output));
    }

    [Fact]
    public void Test()
    {
        for (int i = 0; i < 10; i++)
        {
            Task.Factory.StartNew(() => Console.WriteLine(i));
        }
    }
}