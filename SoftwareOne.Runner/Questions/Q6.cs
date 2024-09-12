using SoftwareOne.Runner.Items;
using Xunit.Abstractions;
using Question = SoftwareOne.Interview.Questions.Q6;

namespace SoftwareOne.Runner.Questions;

public class Q6
{
    public Q6(ITestOutputHelper output)
    {
        Console.SetOut(new TestWriter(output));
    }

    [Fact]
    public void Test()
    {
        Question.Main();
    }
}