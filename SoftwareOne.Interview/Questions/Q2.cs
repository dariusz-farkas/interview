#pragma warning disable CS8618
#pragma warning disable CS4014

namespace SoftwareOne.Interview.Questions;

public class Q2
{
    private static string result;

    public static void Main()
    {
        SaySomething();
        Console.WriteLine(result);
    }

    static async Task SaySomething()
    {
        await Task.Delay(50);
        result = "Hello, World!";
    }
}