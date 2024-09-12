using SoftwareOne.Interview.Questions;
using SoftwareOne.Runner.Items;
using Xunit.Abstractions;
using static SoftwareOne.Interview.Questions.Q2;

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
        var painter = new Painter();
        painter.Draw(new Shape());
        painter.Draw(new Circle());

        var processor = new PainterProcessor();
        processor.Process(new Circle());
    }
}