



int turnCounter = 0;
string turnName = "Initiator";
string firstRow = "     ";
string secondRow = "     ";
string thirdRow = "     ";
short boardScore = 0;
short AA;
short AB;
short AC;
short BA;
short BB;
short BC;
short CA;
short CB;
short CC;
short playerScore = 0;
int computerScore = 0;
string unusedDigits = "1 2 3 4 5 6 7 8 9";
bool gameStart = false;

Console.WriteLine("------------------ Round 0 ------------------\n");

Console.WriteLine($"    1 2 3          Turn : {turnCounter} / {turnName}               Digits left:");
Console.WriteLine($"  + - - - +                                         {unusedDigits}");
Console.WriteLine($"1 |       |        Board Score    : {boardScore}        ");
Console.WriteLine($"2 |       |                                 ");
Console.WriteLine($"3 |       |        Player Score   : {playerScore}        ");
Console.WriteLine($"  + - - - +        Computer Score : {computerScore}         ");
Console.WriteLine("                                                  ");
Console.WriteLine("Selected digit :                                   ");


string userInput;
short inputCounter = 0;
string tempString;
bool included;
short userInputShort;
do
{
    Console.SetCursorPosition(17, 9);
    userInput = Console.ReadLine();
    userInputShort = Convert.ToInt16(userInput);
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
            included = false;
            if (AA == userInputShort) included = true;
            if (AB == userInputShort) included = true;
            if (AC == userInputShort) included = true;
            if (BA == userInputShort) included = true;
            if (BB == userInputShort) included = true;
            if (BC == userInputShort) included = true;
            if (CA == userInputShort) included = true;
            if (CB == userInputShort) included = true;
            if (CC == userInputShort) included = true;
            if (!included)
            {
                inputCounter++;
                tempString = "";
                for (int i = 0; i < 2 * Convert.ToInt16(userInput) - 2;i++)
                    tempString += unusedDigits[i];
                tempString += 'X';
                for (int i = 2 * Convert.ToInt16(userInput) - 1; i < unusedDigits.Length; i++)
                    tempString += unusedDigits[i];
                unusedDigits = tempString;
                
            }


            break;
        default: 
            break;

    }
    switch (inputCounter)
    {
        case 1:
            AA = userInputShort;
            break;
        case 2:
            AB = userInputShort;
            break;
        case 3:
            AC = userInputShort;
            break;
        case 4:
            BA = userInputShort;
            break;
        case 5:
            BB = userInputShort;
            break;
        case 6:
            BC = userInputShort;
            break;
        case 7:
            CA = userInputShort;
            break;
        case 8:
            CB = userInputShort;
            break;
        case 9:
            CC = userInputShort;
            gameStart = true;
            break;
        case 0:
        default:
            break;
    }
    Console.Clear();
    Console.WriteLine("------------------ Round 0 ------------------\n");

    Console.WriteLine($"    1 2 3          Turn : {turnCounter} / {turnName}               Digits left:");
    Console.WriteLine($"  + - - - +                                         {unusedDigits}");
    Console.WriteLine($"1 | {AA} {AB} {AC} |        Board Score    : {boardScore}        ");
    Console.WriteLine($"2 | {BA} {BB} {BC} |                                 ");
    Console.WriteLine($"3 | {CA} {CB} {CC} |        Player Score   : {playerScore}        ");
    Console.WriteLine($"  + - - - +        Computer Score : {computerScore}         ");
    Console.WriteLine("                                                  ");
    Console.WriteLine("Selected digit :                                   ");


} while (gameStart == false);

Console.Clear();
Console.WriteLine("------------------ Round 0 ------------------\n");

Console.WriteLine($"    1 2 3          Turn : {turnCounter} / {turnName}               Digits left:");
Console.WriteLine($"  + - - - +                                         {unusedDigits}");
Console.WriteLine($"1 | {AA} {AB} {AC} |        Board Score    : {boardScore}        ");
Console.WriteLine($"2 | {BA} {BB} {BC} |                                 ");
Console.WriteLine($"3 | {CA} {CB} {CC} |        Player Score   : {playerScore}        ");
Console.WriteLine($"  + - - - +        Computer Score : {computerScore}         ");
Console.WriteLine("                                                  ");
Console.WriteLine("Selected digit :                                   ");