#pragma warning disable CA1822
namespace SoftwareOne.Interview.Questions;

public class Q2
{
    public class Shape
    {
    }

    public class Circle : Shape
    {
    }

    public class Painter
    {
        public void Draw(Shape shape)
        {
            Console.WriteLine("Drawing shape");
        }

        public void Draw(Circle shape)
        {
            Console.WriteLine("Drawing circle");
        }
    }

    public class PainterProcessor
    {
        public void Process(Shape shape)
        {
            var painter = new Painter();
            painter.Draw(shape);
        }
    }
}