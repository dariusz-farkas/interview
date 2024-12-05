using SoftwareOne.Interview.Questions;
using SoftwareOne.Runner.Items;
using Xunit.Abstractions;

namespace SoftwareOne.Runner.Questions;

public class Q3
{
    public Q3(ITestOutputHelper output)
    {
        Console.SetOut(new TestWriter(output));
    }

    [Fact]
    public void Test()
    {
        Interview.Questions.Q3.Main();
    }
}