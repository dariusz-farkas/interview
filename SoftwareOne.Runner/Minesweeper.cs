using SoftwareOne.Interview;
using System.Collections;

namespace SoftwareOne.Runner;

public class Minesweeper
{
    [Theory]
    [ClassData(typeof(MinesweeperTestData))]
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


internal class MinesweeperTestData : IEnumerable<object[]>
{
    public IEnumerator<object[]> GetEnumerator()
    {
        yield return
        [
            new[] { 
                "4 4",
                "* . . .",
                ". . . .",
                ". * . .",
                ". . . ."
            },  new[]
            {
                "* 1 0 0",
                "2 2 1 0",
                "1 * 1 0",
                "1 1 1 0"
            },
            new[] { 
                "3 5",
                "* * . . .",
                ". . . . .",
                ". * . . ."
            },  new[]
            {
                "* * 1 0 0",
                "3 3 2 0 0",
                "1 * 1 0 0"
            }
        ];
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}