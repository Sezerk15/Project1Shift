


                                          // Initialization of necessary variables.
byte roundCount = 0;
int turnCounter = 0;
string turnName = "Initiator";

                                    // Rows of the board are stored as strings.
string firstRow = "     ";
string secondRow = "     ";
string thirdRow = "     ";

                             // Board and player scores are stored as bytes since they can only be 0, 1, 4 or 9.
byte boardScore = 0;
byte playerScore = 0;
int computerScore = 0;

                    // Digit 'slots' are stored as individual variables. AA represents i1j1 AB represents i1j2 etc.
byte AA = 0;
byte AB = 0;
byte AC = 0;
byte BA = 0;
byte BB = 0;
byte BC = 0;
byte CA = 0;
byte CB = 0;
byte CC = 0;


string unusedDigits = "1 2 3 4 5 6 7 8 9";
bool gameStart = false;
byte inputCounter = 0;
string tempString;
bool included;
byte userInputByte;

                                 // Below is a blueprint of the game board.
Console.WriteLine($"------------------ Round {roundCount} ------------------\n");
Console.WriteLine($"    1 2 3          Turn : {turnCounter} / {turnName}               Digits left:");
Console.WriteLine($"  + - - - +                                         {unusedDigits}");
Console.WriteLine($"1 |       |        Board Score    : {boardScore}        ");
Console.WriteLine($"2 |       |                                 ");
Console.WriteLine($"3 |       |        Player Score   : {playerScore}        ");
Console.WriteLine($"  + - - - +        Computer Score : {computerScore}         ");
Console.WriteLine("                                                  ");
Console.WriteLine("Selected digit :                                   ");

                                      // GAME BOARD INITIALIZATION LOOP
do
{
    Console.SetCursorPosition(17, 9);
                                 // Input is stored as byte since only digits from 1 to 9 are accepted.
    userInputByte = Convert.ToByte(Console.ReadLine());
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
            {                    // Code below only works if given digit has not yet been included in the board.
                inputCounter++;
                tempString = "";
                for (byte i = 0; i < 2 * userInputByte - 2;i++)
                    tempString += unusedDigits[i];
                tempString += 'X';
                for (int i = 2 * userInputByte - 1; i < unusedDigits.Length; i++)
                    tempString += unusedDigits[i];
                unusedDigits = tempString;
                switch (inputCounter)
                {                         // Board is updated top-to-bottom left-to-right with every 'correct' input.
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
                    case 9:           // Once 9 digits have been entered, the initialization stage ends and the game begins.
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


                                       // Board is updated with every input.
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
    turnName = "Player";
    turnCounter = 1;
    roundCount++;
    Console.Clear();
    Console.WriteLine($"------------------ Round {roundCount} ------------------\n");

    Console.WriteLine($"    1 2 3          Turn : {turnCounter} / {turnName}");
    Console.WriteLine($"  + - - - +                                        ");
    Console.WriteLine($"1 | {firstRow} |        Board Score    : {boardScore}        ");
    Console.WriteLine($"2 | {secondRow} |                                 ");
    Console.WriteLine($"3 | {thirdRow} |        Player Score   : {playerScore}        ");
    Console.WriteLine($"  + - - - +        Computer Score : {computerScore}         ");
    Console.WriteLine("                                                  ");
    Console.WriteLine("Selected digit :                                   ");
} while (roundCount < 5);