# interview

Interview assignments

## Assignment I

Create a program, which, given a valid sequence of rolls for one line of American Ten-Pin Bowling, produces the total
score for the game. This is a summary of the rules of the game:
 - Each game, or "line" of bowling, includes ten turns, or "frames" for the bowler. 
 - In each frame, the bowler gets up to two tries to knock down all the pins. 
 - If in two tries, he fails to knock them all down, his score for that frame is the total number of pins knocked down
   in his two tries. 
 - If in two tries he knocks them all down, this is called a "spare" and his score for the frame is ten plus the number
   of pins knocked down on his next throw (in his next turn). 
 - If on his first try in the frame he knocks down all the pins, this is called a "strike". His turn is over, and his
   score for the frame is ten plus the simple total of the pins knocked down in his next two rolls. 
 - If he gets a spare or strike in the last (tenth) frame, the bowler gets to throw one or two more bonus balls,
   respectively. - These bonus throws are taken as part of the same turn. If the bonus throws knock down all the pins, 
   the process does not repeat: the bonus throws are only used to calculate the score of the final frame.
 - The game score is the total of all frame scores.

Here are some things that the program will not do:
 - We will not check for valid rolls. 
 - We will not check for correct number of rolls and frames. 
 - We will not provide scores for intermediate frames.

The input is a score card from a finished bowling game, where "X" stands for a strike, "-" for no pins bowled, and "/"
means a spare. Otherwise figures 1-9 indicate how many pins were knocked down in that throw. Sample games:

12345123451234512345

always hitting pins without getting spares or strikes, a total score of 60

XXXXXXXXXXXX

a perfect game, 12 strikes, giving a score of 300

9-9-9-9-9-9-9-9-9-9-

heartbreak - 9 pins down each round, giving a score of 90

5/5/5/5/5/5/5/5/5/5/5

a spare every round, giving a score of 150.

## Assignment II

Have you ever played Minesweeper? Well, the goal of the game is to find all the mines within an MxN field. To help you, 
the game shows a number in a square which tells you how many mines there are adjacent to that square. For instance, take
the following 4x4 field with 2 mines (which are represented by an * character):

* . . .
. . . .
. * . .
. . . .

The same field including the hint numbers described above would look like this:

* 1 0 0
2 2 1 0
1 * 1 0
1 1 1 0

You should write a program that takes input as follows:
The input will consist of an arbitrary number of fields. The first line of each field contains two integers n and m 
(0 < n,m <= 100) which stands for the number of lines and columns of the field respectively. The next n lines contains exactly m characters and represent the field. Each safe square is represented by an "." character (without the quotes) 
and each mine square is represented by an "*" character (also without the quotes). The first field line where n = m = 0
represents the end of input and should not be processed.

Your program should produce output as follows: 
For each field, you must print the following message in a line alone:

Field #x:

Where x stands for the number of the field (starting from 1).
The next n lines should contain the field with the "." characters replaced by the number of adjacent mines to that
square.
There must be an empty line between field outputs.

This is the acceptance test input:

4 4
* . . .
. . . .
. * . .
. . . .
3 5
* * . . .
. . . . .
. * . . .
0 0

and output:

Field #1:

* 1 0 0
2 2 1 0
1 * 1 0
1 1 1 0

Field #2:

* * 1 0 0
3 3 2 0 0
1 * 1 0 0
