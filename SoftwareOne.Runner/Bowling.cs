using System.Collections;
using SoftwareOne.Interview;

namespace SoftwareOne.Runner;

public class Bowling
{
    [Theory]
    [ClassData(typeof(BowlingTestData))]
    public void Succeed(string[] input, string[] output)
    {
        // Arrange
        Assignment assignment = new Assignment();

        // Act
        var rs = assignment.Solve(input);

        // Assert
        Assert.Equal(output, rs);
    }
}

internal class BowlingTestData : IEnumerable<object[]>
{
    public IEnumerator<object[]> GetEnumerator()
    {
        yield return
        [
            new[] { "12345123451234512345" },  new[] { "60" },
            new[] { "XXXXXXXXXXXX" },  new[] { "300" },
            new[] { "9-9-9-9-9-9-9-9-9-9-" },  new[] { "90" },
            new[] { "5/5/5/5/5/5/5/5/5/5/5" },  new[] { "150" },
        ];
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}