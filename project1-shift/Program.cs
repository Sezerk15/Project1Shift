



int turnCounter = 0;
string turnName = "Initiator";
string firstRow = "     ";
string secondRow = "     ";
string thirdRow = "     ";
short boardScore = 0;
short playerScore = 0;
int computerScore = 0;
string unusedDigits = "1 2 3 4 5 6 7 8 9";
bool gameStart = false;

Console.WriteLine("------------------ Round 0 ------------------\n");

Console.WriteLine($"    1 2 3          Turn : {turnCounter} / {turnName}               Digits left:");
Console.WriteLine($"  + - - - +                                         {unusedDigits}");
Console.WriteLine($"1 | {firstRow} |        Board Score    : {boardScore}        ");
Console.WriteLine($"2 | {secondRow} |                                 ");
Console.WriteLine($"3 | {thirdRow} |        Player Score   : {playerScore}        ");
Console.WriteLine($"  + - - - +        Computer Score : {computerScore}         ");
Console.WriteLine("                                                  ");
Console.WriteLine("Selected digit :                                   ");


string userInput;
short inputCounter = 0;
string boardTotal = "";
string tempString;
do
{
    Console.SetCursorPosition(17, 9);
    userInput = Console.ReadLine();
    switch (userInput)
    {
        case "1":
        case "2":
        case "3":
        case "4":
        case "5":
        case "6":
        case "7":
        case "8":
        case "9":
            if (!boardTotal.Contains(userInput)) { 
                boardTotal += userInput;
                inputCounter++;
                
            }

            break;
        default: 
            break;

    }
    switch (inputCounter)
    {
        case 1:
            firstRow = String.Format("{0}    ", boardTotal[0]);
            break;
        case 2:
            firstRow = String.Format("{0} {1}  ", boardTotal[0], boardTotal[1]);
            break;
        case 3:
            firstRow = String.Format("{0} {1} {2}", boardTotal[0], boardTotal[1], boardTotal[2]);
            break;
        case 4:
            secondRow = String.Format("{0}    ", boardTotal[3]);
            break;
        case 5:
            secondRow = String.Format("{0} {1}  ", boardTotal[3], boardTotal[4]);
            break;
        case 6:
            secondRow = String.Format("{0} {1} {2}", boardTotal[3], boardTotal[4], boardTotal[5]);
            break;
        case 7:
            thirdRow = String.Format("{0}    ", boardTotal[6]);
            break;
        case 8:
            thirdRow = String.Format("{0} {1}  ", boardTotal[6], boardTotal[7]);
            break;
        case 9:
            thirdRow = String.Format("{0} {1} {2}", boardTotal[6], boardTotal[7], boardTotal[8]);
            gameStart = true;
            break;
        case 0:
        default:
            break;
    }
    Console.Clear();
    Console.WriteLine("------------------ Round {0} ------------------\n");

    Console.WriteLine($"    1 2 3          Turn : {turnCounter} / {turnName}               Digits left:");
    Console.WriteLine($"  + - - - +                                         {unusedDigits}");
    Console.WriteLine($"1 | {firstRow} |        Board Score    : {boardScore}        ");
    Console.WriteLine($"2 | {secondRow} |                                 ");
    Console.WriteLine($"3 | {thirdRow} |        Player Score   : {playerScore}        ");
    Console.WriteLine($"  + - - - +        Computer Score : {computerScore}         ");
    Console.WriteLine("                                                  ");
    Console.WriteLine("Selected digit :                                   ");


} while (gameStart == false);

int currentScore = 0;
for (int i = 0; i < 9; i += 3)
{
    if (Math.Abs(Convert.ToInt16(boardTotal[i].ToString()) - Convert.ToInt16(boardTotal[i+1].ToString())) == 1 &&
    Math.Abs(Convert.ToInt16(boardTotal[i+1].ToString()) - Convert.ToInt16(boardTotal[i+2].ToString())) == 1)
    {
        currentScore++;
    }
}
for (int i = 0; i < 3; i ++)
{
    if (Math.Abs(Convert.ToInt16(boardTotal[i].ToString()) - Convert.ToInt16(boardTotal[i + 3].ToString())) == 1 &&
    Math.Abs(Convert.ToInt16(boardTotal[i + 3].ToString()) - Convert.ToInt16(boardTotal[i + 6].ToString())) == 1)
    {
        currentScore++;
    }
}
if (Math.Abs(Convert.ToInt16(boardTotal[0].ToString()) - Convert.ToInt16(boardTotal[4].ToString())) == 1 &&
    Math.Abs(Convert.ToInt16(boardTotal[4].ToString()) - Convert.ToInt16(boardTotal[8].ToString())) == 1)
{
    currentScore++;
}
if (Math.Abs(Convert.ToInt16(boardTotal[2].ToString()) - Convert.ToInt16(boardTotal[4].ToString())) == 1 &&
    Math.Abs(Convert.ToInt16(boardTotal[4].ToString()) - Convert.ToInt16(boardTotal[6].ToString())) == 1)
{
    currentScore++;
}
currentScore = currentScore * currentScore;
boardScore = Convert.ToInt16(currentScore);

Console.Clear();
Console.WriteLine("------------------ Round 0 ------------------\n");

Console.WriteLine($"    1 2 3          Turn : {turnCounter} / {turnName}               Digits left:");
Console.WriteLine($"  + - - - +                                         {unusedDigits}");
Console.WriteLine($"1 | {firstRow} |        Board Score    : {boardScore}        ");
Console.WriteLine($"2 | {secondRow} |                                 ");
Console.WriteLine($"3 | {thirdRow} |        Player Score   : {playerScore}        ");
Console.WriteLine($"  + - - - +        Computer Score : {computerScore}         ");
Console.WriteLine("                                                  ");
Console.WriteLine("Selected digit :                                   ");