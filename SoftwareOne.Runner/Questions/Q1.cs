using SoftwareOne.Runner.Items;
using Xunit.Abstractions;

using Question = SoftwareOne.Interview.Questions.Q1;

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
        var s1 = new Question.Shape();
        s1.Draw();

        var s2 = new Question.Circle();
        s2.Draw();

        Question.Shape s3 = new Question.Circle();
        s3.Draw();
    }
}