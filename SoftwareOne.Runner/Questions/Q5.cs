using SoftwareOne.Runner.Items;
using Xunit.Abstractions;
using Question = SoftwareOne.Interview.Questions.Q5;

namespace SoftwareOne.Runner.Questions;

public class Q5
{
    public Q5(ITestOutputHelper output)
    {
        Console.SetOut(new TestWriter(output));
    }

    [Fact]
    public void Test()
    {
        Question.Main();
    }
}