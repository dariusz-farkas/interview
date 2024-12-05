using SoftwareOne.Interview.Questions;
using SoftwareOne.Runner.Items;
using Xunit.Abstractions;

namespace SoftwareOne.Runner.Questions;

public class Q2
{
    public Q2(ITestOutputHelper output)
    {
        Console.SetOut(new TestWriter(output));
    }

    [Fact]
    public void Test()
    {
        Interview.Questions.Q2.Main();
    }
}