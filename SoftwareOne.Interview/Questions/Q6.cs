using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// ReSharper disable All

namespace SoftwareOne.Interview.Questions;

public class Q6
{
    delegate void Printer();

    public static void Main()
    {
        var printers = new List<Printer>();
        for (int i = 0; i < 10; i++)
        {
            printers.Add(delegate { Console.WriteLine(i); });
        }

        foreach (var printer in printers)
        {
            printer();
        }
    }
}