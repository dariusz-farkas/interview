namespace SoftwareOne.Interview.Questions;

public class Q1
{
    public class Shape
    {
        public virtual void Draw()
        {
            Console.WriteLine("Drawing shape");
        }
    }

    public class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing circle");
        }
    }
}