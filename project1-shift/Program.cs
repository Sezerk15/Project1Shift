
int roundCount = 0;
int turnCounter = 0;
string turnName = "Initiator";
string firstRow = "     ";
string secondRow = "     ";
string thirdRow = "     ";
int boardScore = 0;
int AA = 0;
int AB = 0;
int AC = 0; 
int BA = 0;
int BB = 0;
int BC = 0;
int CA = 0;
int CB = 0;
int CC = 0;
int playerScore = 0;
int computerScore = 0;
string unusedDigits = "1 2 3 4 5 6 7 8 9";
bool gameStart = false;

Console.WriteLine($"------------------ Round {roundCount} ------------------\n");

Console.WriteLine($"    1 2 3          Turn : {turnCounter} / {turnName}               Digits left:");
Console.WriteLine($"  + - - - +                                         {unusedDigits}");
Console.WriteLine($"1 |       |        Board Score    : {boardScore}        ");
Console.WriteLine($"2 |       |                                 ");
Console.WriteLine($"3 |       |        Player Score   : {playerScore}        ");
Console.WriteLine($"  + - - - +        Computer Score : {computerScore}         ");
Console.WriteLine("                                                  ");
Console.WriteLine("Selected digit :                                   ");

int inputCounter = 0;
string tempString;
bool included;
int userInputByte;
do
{
    Console.SetCursorPosition(17, 9);

    userInputByte = Convert.ToInt16(Console.ReadLine());
    switch (userInputByte)
    {
        case 1:
        case 2:
        case 3:
        case 4:
        case 5:
        case 6:
        case 7:
        case 8:
        case 9:
            included = false;
            if (AA == userInputByte) included = true;
            if (AB == userInputByte) included = true;
            if (AC == userInputByte) included = true;
            if (BA == userInputByte) included = true;
            if (BB == userInputByte) included = true;
            if (BC == userInputByte) included = true;
            if (CA == userInputByte) included = true;
            if (CB == userInputByte) included = true;
            if (CC == userInputByte) included = true;
            if (!included)
            {
                inputCounter++;
                tempString = "";
                for (int i = 0; i < 2 * userInputByte - 2;i++)
                    tempString += unusedDigits[i];
                tempString += 'X';
                for (int i = 2 * userInputByte - 1; i < unusedDigits.Length; i++)
                    tempString += unusedDigits[i];
                unusedDigits = tempString;
                switch (inputCounter)
                {
                    case 1:
                        AA = userInputByte;
                        firstRow = AA + "    ";
                        break;
                    case 2:
                        AB = userInputByte;
                        firstRow = AA + " " + AB + "  ";
                        break;
                    case 3:
                        AC = userInputByte;
                        firstRow = AA + " " + AB + " " + AC;
                        break;
                    case 4:
                        BA = userInputByte;
                        secondRow = BA + "    ";
                        break;
                    case 5:
                        BB = userInputByte;
                        secondRow = BA + " " + BB + "  ";
                        break;
                    case 6:
                        BC = userInputByte;
                        secondRow = BA + " " + BB + " " + BC;
                        break;
                    case 7:
                        CA = userInputByte;
                        thirdRow = CA + "    ";
                        break;
                    case 8:
                        CB = userInputByte;
                        thirdRow = CA + " " + CB + "  ";
                        break;
                    case 9:
                        CC = userInputByte;
                        thirdRow = CA + " " + CB + " " + CC;
                        gameStart = true;
                        break;
                    default:
                        break;
                }

            }
            break;
        default: 
            break;

    }



    Console.Clear();
    Console.WriteLine($"------------------ Round {roundCount} ------------------\n");

    Console.WriteLine($"    1 2 3          Turn : {turnCounter} / {turnName}               Digits left:");
    Console.WriteLine($"  + - - - +                                         {unusedDigits}");
    Console.WriteLine($"1 | {firstRow} |        Board Score    : {boardScore}        ");
    Console.WriteLine($"2 | {secondRow} |                                 ");
    Console.WriteLine($"3 | {thirdRow} |        Player Score   : {playerScore}        ");
    Console.WriteLine($"  + - - - +        Computer Score : {computerScore}         ");
    Console.WriteLine("                                                  ");
    Console.WriteLine("Selected digit :                                   ");


} while (gameStart == false);

do
{
    bool turn = false; //to define whose turn is this//
    turnName = "Player";
    turnCounter = 1;
    roundCount++;
    int point = 0;
    Console.Clear();
    if ((AA == AB + 1 && AB == AC + 1) || (AC == AB + 1 && AB == AA + 1))//checks first row//
    {
        point++;
    }
    if ((BA == BB + 1 && BB == BC + 1) || (BC == BB + 1 && BB == BA + 1))//checks second row(two direction)//
    {
        point++;
    }
    if ((CA == CB + 1 && CB == CC + 1) || (CC == CB + 1 && CB == CA + 1))//checks third row(two direction)//
    {
        point++;
    }
    if ((AA == BA + 1 && BA == CA + 1) || (BA == AA + 1 && CA == BA + 1))//checks first column(two direction)//
    {
        point++;
    }
    if ((AB == BB + 1 && BB == CB + 1) || (BB == AB + 1 && CB == BB + 1))//checks second column(two direction)//
    {
        point++;
    }
    if ((AC == BC + 1 && BC == CC + 1) || (BC == AC + 1 && CC == BC + 1))//checks third column(two direction)//
    {
        point++;
    }
    if ((AA== BB + 1 && BB == CC + 1) || (BB == AA + 1 && CC == BB + 1))//checks diagonal from left top to right bottom //
    {
        point++;
    }
    if ((AC == BB + 1 && BB == CA + 1) || (CA == BB + 1 && BB== AC + 1))//checks diagonal from right top to left bottom//
    {
        point++;
    }
    boardScore = point * point;

    if (boardScore == 0 && turn == false) //if turn is false then it is player's point//
    {
        if ((AA == AB + 1 && AB == AC + 1) || (AC == AB + 1 && AB == AA + 1))
        {
            point++;
        }
        if ((BA == BB + 1 && BB == BC + 1) || (BC == BB + 1 && BB == BA + 1))
        {
            point++;
        }
        if ((CA == CB + 1 && CB == CC + 1) || (CC == CB + 1 && CB == CA + 1))
        {
            point++;
        }
        if ((AA == BA + 1 && BA == CA + 1) || (BA == AA + 1 && CA == BA + 1))
        {
            point++;
        }
        if ((AB == BB + 1 && BB == CB + 1) || (BB == AB + 1 && CB == BB + 1))
        {
            point++;
        }
        if ((AC == BC + 1 && BC == CC + 1) || (BC == AC + 1 && CC == BC + 1))
        {
            point++;
        }
        if ((AA == BB + 1 && BB == CC + 1) || (BB == AA + 1 && CC == BB + 1))
        {
            point++;
        }
        if ((AC == BB + 1 && BB == CA + 1) || (CA == BB + 1 && BB == AC + 1))
        {
            point++;
        }
        boardScore = point * point;
        playerScore = boardScore;
    }
    else if (boardScore == 0 && turn == true) //if not the point is computer's//
    {
        if ((AA == AB + 1 && AB == AC + 1) || (AC == AB + 1 && AB == AA + 1))
        {
            point++;
        }
        if ((BA == BB + 1 && BB == BC + 1) || (BC == BB + 1 && BB == BA + 1))
        {
            point++;
        }
        if ((CA == CB + 1 && CB == CC + 1) || (CC == CB + 1 && CB == CA + 1))
        {
            point++;
        }
        if ((AA == BA + 1 && BA == CA + 1) || (BA == AA + 1 && CA == BA + 1))
        {
            point++;
        }
        if ((AB == BB + 1 && BB == CB + 1) || (BB == AB + 1 && CB == BB + 1))
        {
            point++;
        }
        if ((AC == BC + 1 && BC == CC + 1) || (BC == AC + 1 && CC == BC + 1))
        {
            point++;
        }
        if ((AA == BB + 1 && BB == CC + 1) || (BB == AA + 1 && CC == BB + 1))
        {
            point++;
        }
        if ((AC == BB + 1 && BB == CA + 1) || (CA == BB + 1 && BB == AC + 1))
        {
            point++;
        }
        boardScore = point * point;
        computerScore = boardScore;
    }


    Console.WriteLine($"------------------ Round {roundCount} ------------------\n");

    Console.WriteLine($"    1 2 3          Turn : {turnCounter} / {turnName}");
    Console.WriteLine($"  + - - - +                                        ");
    Console.WriteLine($"1 | {firstRow} |        Board Score    : {boardScore}        ");
    Console.WriteLine($"2 | {secondRow} |                                 ");
    Console.WriteLine($"3 | {thirdRow} |        Player Score   : {playerScore}        ");
    Console.WriteLine($"  + - - - +        Computer Score : {computerScore}         ");
    Console.WriteLine("                                                  ");
    Console.WriteLine("Selected digit :                                   ");

    turn = true;
} while (roundCount < 5);