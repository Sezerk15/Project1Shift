﻿


bool playAgain = true;
//GAMEEE
while (playAgain)
{
    
    // DEĞİŞKENLER
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


    //BAŞLAMA
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

    //INPUT ALMA
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
                    for (int i = 0; i < 2 * userInputByte - 2; i++)
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

    // OYUN
    do
    {
        //TAHTA OLUŞTURMA
        if (roundCount != 0)
        {
            var rand = new Random();
            AA = 0;
            AB = 0;
            AC = 0;
            BA = 0;
            BB = 0;
            BC = 0;
            CA = 0;
            CB = 0;
            CC = 0;
            //AA
            int num = 0;
            do
            {
                num = rand.Next(9) + 1;
                if (AA != num && AB != num && AC != num && BA != num && BB != num && BC != num && CA != num && CB != num && CC != num)
                {
                    if (AA == 0)
                    {
                        AA = num;
                    }
                    else if (AB == 0)
                    {
                        AB = num;
                    }
                    else if (AC == 0)
                    {
                        AC = num;
                    }
                    else if (BA == 0)
                    {
                        BA = num;

                    }
                    else if (BB == 0)
                    {
                        BB = num;
                    }
                    else if (BC == 0)
                    {
                        BC = num;
                    }
                    else if (CA == 0)
                    {
                        CA = num;
                    }
                    else if (CB == 0)
                    {
                        CB = num;
                    }
                    else if (CC == 0)
                    {
                        CC = num;
                    }
                }
            }
            while (CC == 0);

            Console.Clear();
            Console.WriteLine($"------------------ Round {roundCount} ------------------\n");
            Console.WriteLine($"    1 2 3          Turn : {turnCounter} / {turnName}               Digits left:");
            Console.WriteLine($"  + - - - +                                         {unusedDigits}");
            Console.WriteLine($"1 | {(AA != 0 ? AA : " ")} {(AB != 0 ? AB : " ")} {(AC != 0 ? AC : " ")} |        Board Score    : {boardScore}        ");
            Console.WriteLine($"2 | {(BA != 0 ? BA : " ")} {(BB != 0 ? BB : " ")} {(BC != 0 ? BC : " ")} |                                 ");
            Console.WriteLine($"3 | {(CA != 0 ? CA : " ")} {(CB != 0 ? CB : " ")} {(CC != 0 ? CC : " ")} |        Player Score   : {playerScore}        ");
            Console.WriteLine($"  + - - - +        Computer Score : {computerScore}         ");
            Console.WriteLine("                                                  ");
            Console.WriteLine("Selected digit :                                   ");
        }


        //TAHTA PUANI HESAPLAMA
        turnCounter = 1;
        roundCount++;
        bool getPoint = true;
        int point = 0;
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
        if ((AA == BB + 1 && BB == CC + 1) || (BB == AA + 1 && CC == BB + 1))//checks diagonal from left top to right bottom //
        {
            point++;
        }
        if ((AC == BB + 1 && BB == CA + 1) || (CA == BB + 1 && BB == AC + 1))//checks diagonal from right top to left bottom//
        {
            point++;
        }
        boardScore = point * point;


        if (boardScore > 0)
        {
            getPoint = false;
        }

        //OYUN BAŞLAMA
        while (true)
        {
            //OYUNCU SIRASI
            bool playerMoved = false;
            turnName = "Player";
            while (!playerMoved)
            {
                Console.Clear();
                Console.WriteLine($"------------------ Round {roundCount} ------------------\n");
                Console.WriteLine($"    1 2 3          Turn : {turnCounter} / {turnName}");
                Console.WriteLine($"  + - - - +");
                Console.WriteLine($"1 | {(AA != 0 ? AA : " ")} {(AB != 0 ? AB : " ")} {(AC != 0 ? AC : " ")} |        Board Score    : {boardScore}        ");
                Console.WriteLine($"2 | {(BA != 0 ? BA : " ")} {(BB != 0 ? BB : " ")} {(BC != 0 ? BC : " ")} |                                 ");
                Console.WriteLine($"3 | {(CA != 0 ? CA : " ")} {(CB != 0 ? CB : " ")} {(CC != 0 ? CC : " ")} |        Player Score   : {playerScore}        ");
                Console.WriteLine($"  + - - - +        Computer Score : {computerScore}         ");
                Console.WriteLine("                                                  ");
                Console.WriteLine("Command :                                   ");
                Console.SetCursorPosition(10, 9);
                String stringInput = Console.ReadLine() ?? "";
                int temp = 0;
                switch (stringInput)
                {
                    case "1":
                        temp = AA;
                        AA = AB;
                        AB = AC;
                        AC = temp;
                        playerMoved = true;
                        break;
                    case "2":
                        temp = BA;
                        BA = BB;
                        BB = BC;
                        BC = temp;
                        playerMoved = true;
                        break;
                    case "3":
                        temp = CA;
                        CA = CB;
                        CB = CC;
                        CC = temp;
                        playerMoved = true;
                        break;
                    case "4":
                        temp = AA;
                        AA = BA;
                        BA = CA;
                        CA = temp;
                        playerMoved = true;
                        break;
                    case "5":
                        temp = AB;
                        AB = BB;
                        BB = CB;
                        CB = temp;
                        playerMoved = true;
                        break;
                    case "6":
                        temp = AC;
                        AC = BC;
                        BC = CC;
                        CC = temp;
                        playerMoved = true;
                        break;
                }
            }

            point = 0;
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
            if ((AA == BB + 1 && BB == CC + 1) || (BB == AA + 1 && CC == BB + 1))//checks diagonal from left top to right bottom //
            {
                point++;
            }
            if ((AC == BB + 1 && BB == CA + 1) || (CA == BB + 1 && BB == AC + 1))//checks diagonal from right top to left bottom//
            {
                point++;
            }
            boardScore = point * point;

            if (!getPoint && boardScore == 0)
            {
                getPoint = true;
            }

            if (getPoint && boardScore > 0)
            {
                playerScore = boardScore;
                break;
            }



            //BILGISAYAR SIRASI
            turnName = "Conputer";


            //BILGISAYAR HAMLE SEÇMESİ
            String aIMoveMaxPoint = "1";
            int maxPoint = 0;

            String aIMoveMinPoint = "1";
            int minPoint = int.MaxValue;


            //Command 1
            int tempAA = AB;
            int tempAB = AC;
            int tempAC = AA;
            int tempBA = BA;
            int tempBB = BB;
            int tempBC = BC;
            int tempCA = CA;
            int tempCB = CB;
            int tempCC = CC;
            int tempPoint = 0;
            if ((tempAA == tempAB + 1 && tempAB == tempAC + 1) || (tempAC == tempAB + 1 && tempAB == tempAA + 1))//checks first row//
            {
                tempPoint++;
            }
            if ((tempBA == tempBB + 1 && tempBB == tempBC + 1) || (tempBC == tempBB + 1 && tempBB == tempBA + 1))//checks second row(two direction)//
            {
                tempPoint++;
            }
            if ((tempCA == tempCB + 1 && tempCB == tempCC + 1) || (tempCC == tempCB + 1 && tempCB == tempCA + 1))//checks third row(two direction)//
            {
                tempPoint++;
            }
            if ((tempAA == tempBA + 1 && tempBA == tempCA + 1) || (tempBA == tempAA + 1 && tempCA == tempBA + 1))//checks first column(two direction)//
            {
                tempPoint++;
            }
            if ((tempAB == tempBB + 1 && tempBB == tempCB + 1) || (tempBB == tempAB + 1 && tempCB == tempBB + 1))//checks second column(two direction)//
            {
                tempPoint++;
            }
            if ((tempAC == tempBC + 1 && tempBC == tempCC + 1) || (tempBC == tempAC + 1 && tempCC == tempBC + 1))//checks third column(two direction)//
            {
                tempPoint++;
            }
            if ((tempAA == tempBB + 1 && tempBB == tempCC + 1) || (tempBB == tempAA + 1 && tempCC == tempBB + 1))//checks diagonal from left top to right bottom //
            {
                tempPoint++;
            }
            if ((tempAC == tempBB + 1 && tempBB == tempCA + 1) || (tempCA == tempBB + 1 && tempBB == tempAC + 1))//checks diagonal from right top to left bottom//
            {
                tempPoint++;
            }
            if (maxPoint < tempPoint)
            {
                aIMoveMaxPoint = "1";
                maxPoint = tempPoint;
            }
            if (minPoint > tempPoint)
            {
                aIMoveMinPoint = "1";
                minPoint = tempPoint;
            }

            //Command 2
            tempAA = AA;
            tempAB = AB;
            tempAC = AC;
            tempBA = BB;
            tempBB = BC;
            tempBC = BA;
            tempCA = CA;
            tempCB = CB;
            tempCC = CC;
            tempPoint = 0;
            if ((tempAA == tempAB + 1 && tempAB == tempAC + 1) || (tempAC == tempAB + 1 && tempAB == tempAA + 1))//checks first row//
            {
                tempPoint++;
            }
            if ((tempBA == tempBB + 1 && tempBB == tempBC + 1) || (tempBC == tempBB + 1 && tempBB == tempBA + 1))//checks second row(two direction)//
            {
                tempPoint++;
            }
            if ((tempCA == tempCB + 1 && tempCB == tempCC + 1) || (tempCC == tempCB + 1 && tempCB == tempCA + 1))//checks third row(two direction)//
            {
                tempPoint++;
            }
            if ((tempAA == tempBA + 1 && tempBA == tempCA + 1) || (tempBA == tempAA + 1 && tempCA == tempBA + 1))//checks first column(two direction)//
            {
                tempPoint++;
            }
            if ((tempAB == tempBB + 1 && tempBB == tempCB + 1) || (tempBB == tempAB + 1 && tempCB == tempBB + 1))//checks second column(two direction)//
            {
                tempPoint++;
            }
            if ((tempAC == tempBC + 1 && tempBC == tempCC + 1) || (tempBC == tempAC + 1 && tempCC == tempBC + 1))//checks third column(two direction)//
            {
                tempPoint++;
            }
            if ((tempAA == tempBB + 1 && tempBB == tempCC + 1) || (tempBB == tempAA + 1 && tempCC == tempBB + 1))//checks diagonal from left top to right bottom //
            {
                tempPoint++;
            }
            if ((tempAC == tempBB + 1 && tempBB == tempCA + 1) || (tempCA == tempBB + 1 && tempBB == tempAC + 1))//checks diagonal from right top to left bottom//
            {
                tempPoint++;
            }
            if (maxPoint < tempPoint)
            {
                aIMoveMaxPoint = "2";
                maxPoint = tempPoint;
            }
            if (minPoint > tempPoint)
            {
                aIMoveMinPoint = "2";
                minPoint = tempPoint;
            }

            //Command 3
            tempAA = AA;
            tempAB = AB;
            tempAC = AC;
            tempBA = BA;
            tempBB = BB;
            tempBC = BC;
            tempCA = CB;
            tempCB = CC;
            tempCC = CA;
            tempPoint = 0;
            if ((tempAA == tempAB + 1 && tempAB == tempAC + 1) || (tempAC == tempAB + 1 && tempAB == tempAA + 1))//checks first row//
            {
                tempPoint++;
            }
            if ((tempBA == tempBB + 1 && tempBB == tempBC + 1) || (tempBC == tempBB + 1 && tempBB == tempBA + 1))//checks second row(two direction)//
            {
                tempPoint++;
            }
            if ((tempCA == tempCB + 1 && tempCB == tempCC + 1) || (tempCC == tempCB + 1 && tempCB == tempCA + 1))//checks third row(two direction)//
            {
                tempPoint++;
            }
            if ((tempAA == tempBA + 1 && tempBA == tempCA + 1) || (tempBA == tempAA + 1 && tempCA == tempBA + 1))//checks first column(two direction)//
            {
                tempPoint++;
            }
            if ((tempAB == tempBB + 1 && tempBB == tempCB + 1) || (tempBB == tempAB + 1 && tempCB == tempBB + 1))//checks second column(two direction)//
            {
                tempPoint++;
            }
            if ((tempAC == tempBC + 1 && tempBC == tempCC + 1) || (tempBC == tempAC + 1 && tempCC == tempBC + 1))//checks third column(two direction)//
            {
                tempPoint++;
            }
            if ((tempAA == tempBB + 1 && tempBB == tempCC + 1) || (tempBB == tempAA + 1 && tempCC == tempBB + 1))//checks diagonal from left top to right bottom //
            {
                tempPoint++;
            }
            if ((tempAC == tempBB + 1 && tempBB == tempCA + 1) || (tempCA == tempBB + 1 && tempBB == tempAC + 1))//checks diagonal from right top to left bottom//
            {
                tempPoint++;
            }
            if (maxPoint < tempPoint)
            {
                aIMoveMaxPoint = "3";
                maxPoint = tempPoint;
            }

            if (minPoint > tempPoint)
            {
                aIMoveMinPoint = "3";
                minPoint = tempPoint;
            }

            //Command 4
            tempAA = BA;
            tempAB = AB;
            tempAC = AC;
            tempBA = CA;
            tempBB = BB;
            tempBC = BC;
            tempCA = AA;
            tempCB = CB;
            tempCC = CC;
            tempPoint = 0;
            if ((tempAA == tempAB + 1 && tempAB == tempAC + 1) || (tempAC == tempAB + 1 && tempAB == tempAA + 1))//checks first row//
            {
                tempPoint++;
            }
            if ((tempBA == tempBB + 1 && tempBB == tempBC + 1) || (tempBC == tempBB + 1 && tempBB == tempBA + 1))//checks second row(two direction)//
            {
                tempPoint++;
            }
            if ((tempCA == tempCB + 1 && tempCB == tempCC + 1) || (tempCC == tempCB + 1 && tempCB == tempCA + 1))//checks third row(two direction)//
            {
                tempPoint++;
            }
            if ((tempAA == tempBA + 1 && tempBA == tempCA + 1) || (tempBA == tempAA + 1 && tempCA == tempBA + 1))//checks first column(two direction)//
            {
                tempPoint++;
            }
            if ((tempAB == tempBB + 1 && tempBB == tempCB + 1) || (tempBB == tempAB + 1 && tempCB == tempBB + 1))//checks second column(two direction)//
            {
                tempPoint++;
            }
            if ((tempAC == tempBC + 1 && tempBC == tempCC + 1) || (tempBC == tempAC + 1 && tempCC == tempBC + 1))//checks third column(two direction)//
            {
                tempPoint++;
            }
            if ((tempAA == tempBB + 1 && tempBB == tempCC + 1) || (tempBB == tempAA + 1 && tempCC == tempBB + 1))//checks diagonal from left top to right bottom //
            {
                tempPoint++;
            }
            if ((tempAC == tempBB + 1 && tempBB == tempCA + 1) || (tempCA == tempBB + 1 && tempBB == tempAC + 1))//checks diagonal from right top to left bottom//
            {
                tempPoint++;
            }
            if (maxPoint < tempPoint)
            {
                aIMoveMaxPoint = "4";
                maxPoint = tempPoint;
            }
            if (minPoint > tempPoint)
            {
                aIMoveMinPoint = "4";
                minPoint = tempPoint;
            }

            //Command 5
            tempAA = AA;
            tempAB = BB;
            tempAC = AC;
            tempBA = BA;
            tempBB = CB;
            tempBC = BC;
            tempCA = CA;
            tempCB = AB;
            tempCC = CC;
            tempPoint = 0;
            if ((tempAA == tempAB + 1 && tempAB == tempAC + 1) || (tempAC == tempAB + 1 && tempAB == tempAA + 1))//checks first row//
            {
                tempPoint++;
            }
            if ((tempBA == tempBB + 1 && tempBB == tempBC + 1) || (tempBC == tempBB + 1 && tempBB == tempBA + 1))//checks second row(two direction)//
            {
                tempPoint++;
            }
            if ((tempCA == tempCB + 1 && tempCB == tempCC + 1) || (tempCC == tempCB + 1 && tempCB == tempCA + 1))//checks third row(two direction)//
            {
                tempPoint++;
            }
            if ((tempAA == tempBA + 1 && tempBA == tempCA + 1) || (tempBA == tempAA + 1 && tempCA == tempBA + 1))//checks first column(two direction)//
            {
                tempPoint++;
            }
            if ((tempAB == tempBB + 1 && tempBB == tempCB + 1) || (tempBB == tempAB + 1 && tempCB == tempBB + 1))//checks second column(two direction)//
            {
                tempPoint++;
            }
            if ((tempAC == tempBC + 1 && tempBC == tempCC + 1) || (tempBC == tempAC + 1 && tempCC == tempBC + 1))//checks third column(two direction)//
            {
                tempPoint++;
            }
            if ((tempAA == tempBB + 1 && tempBB == tempCC + 1) || (tempBB == tempAA + 1 && tempCC == tempBB + 1))//checks diagonal from left top to right bottom //
            {
                tempPoint++;
            }
            if ((tempAC == tempBB + 1 && tempBB == tempCA + 1) || (tempCA == tempBB + 1 && tempBB == tempAC + 1))//checks diagonal from right top to left bottom//
            {
                tempPoint++;
            }
            if (maxPoint < tempPoint)
            {
                aIMoveMaxPoint = "5";
                maxPoint = tempPoint;
            }
            if (minPoint > tempPoint)
            {
                aIMoveMinPoint = "5";
                minPoint = tempPoint;
            }
            //Command 6
            tempAA = AA;
            tempAB = AB;
            tempAC = BC;
            tempBA = BA;
            tempBB = BB;
            tempBC = CC;
            tempCA = CA;
            tempCB = CB;
            tempCC = AC;
            tempPoint = 0;
            if ((tempAA == tempAB + 1 && tempAB == tempAC + 1) || (tempAC == tempAB + 1 && tempAB == tempAA + 1))//checks first row//
            {
                tempPoint++;
            }
            if ((tempBA == tempBB + 1 && tempBB == tempBC + 1) || (tempBC == tempBB + 1 && tempBB == tempBA + 1))//checks second row(two direction)//
            {
                tempPoint++;
            }
            if ((tempCA == tempCB + 1 && tempCB == tempCC + 1) || (tempCC == tempCB + 1 && tempCB == tempCA + 1))//checks third row(two direction)//
            {
                tempPoint++;
            }
            if ((tempAA == tempBA + 1 && tempBA == tempCA + 1) || (tempBA == tempAA + 1 && tempCA == tempBA + 1))//checks first column(two direction)//
            {
                tempPoint++;
            }
            if ((tempAB == tempBB + 1 && tempBB == tempCB + 1) || (tempBB == tempAB + 1 && tempCB == tempBB + 1))//checks second column(two direction)//
            {
                tempPoint++;
            }
            if ((tempAC == tempBC + 1 && tempBC == tempCC + 1) || (tempBC == tempAC + 1 && tempCC == tempBC + 1))//checks third column(two direction)//
            {
                tempPoint++;
            }
            if ((tempAA == tempBB + 1 && tempBB == tempCC + 1) || (tempBB == tempAA + 1 && tempCC == tempBB + 1))//checks diagonal from left top to right bottom //
            {
                tempPoint++;
            }
            if ((tempAC == tempBB + 1 && tempBB == tempCA + 1) || (tempCA == tempBB + 1 && tempBB == tempAC + 1))//checks diagonal from right top to left bottom//
            {
                tempPoint++;
            }
            if (maxPoint < tempPoint)
            {
                aIMoveMaxPoint = "6";
                maxPoint = tempPoint;
            }
            if (minPoint > tempPoint)
            {
                aIMoveMinPoint = "6";
                minPoint = tempPoint;
            }





            //BILGISAYAR HAMLESİ
            int tempt = 0;
            switch (getPoint ? aIMoveMaxPoint : aIMoveMinPoint)
            {
                case "1":
                    tempt = AA;
                    AA = AB;
                    AB = AC;
                    AC = tempt;

                    break;
                case "2":
                    tempt = BA;
                    BA = BB;
                    BB = BC;
                    BC = tempt;

                    break;
                case "3":
                    tempt = CA;
                    CA = CB;
                    CB = CC;
                    CC = tempt;

                    break;
                case "4":
                    tempt = AA;
                    AA = BA;
                    BA = CA;
                    CA = tempt;

                    break;
                case "5":
                    tempt = AB;
                    AB = BB;
                    BB = CB;
                    CB = tempt;

                    break;
                case "6":
                    tempt = AC;
                    AC = BC;
                    BC = CC;
                    CC = tempt;

                    break;
            }

            point = 0;
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
            if ((AA == BB + 1 && BB == CC + 1) || (BB == AA + 1 && CC == BB + 1))//checks diagonal from left top to right bottom //
            {
                point++;
            }
            if ((AC == BB + 1 && BB == CA + 1) || (CA == BB + 1 && BB == AC + 1))//checks diagonal from right top to left bottom//
            {
                point++;
            }
            boardScore = point * point;

            if (!getPoint && boardScore == 0)
            {
                getPoint = true;
            }

            if (getPoint && boardScore > 0)
            {
                computerScore = boardScore;
                break;
            }

        }



        Console.Clear();
        Console.WriteLine($"------------------ Round {roundCount} ------------------\n");
        Console.WriteLine($"    1 2 3          Turn : {turnCounter} / {turnName}");
        Console.WriteLine($"  + - - - + ");
        Console.WriteLine($"1 | {(AA != 0 ? AA : " ")} {(AB != 0 ? AB : " ")} {(AC != 0 ? AC : " ")} |        Board Score    : {boardScore}        ");
        Console.WriteLine($"2 | {(BA != 0 ? BA : " ")} {(BB != 0 ? BB : " ")} {(BC != 0 ? BC : " ")} |                                 ");
        Console.WriteLine($"3 | {(CA != 0 ? CA : " ")} {(CB != 0 ? CB : " ")} {(CC != 0 ? CC : " ")} |        Player Score   : {playerScore}        ");
        Console.WriteLine($"  + - - - +        Computer Score : {computerScore}         ");
        Console.WriteLine(value: "                                                  ");


    } while (roundCount < 5);
    
    



    bool isSelected = false;
    bool selectedButton = true;
    Console.CursorVisible = false;
    while (!isSelected)
    {   
       
        Console.Clear();
        Console.WriteLine(" ");
        Console.WriteLine("             Wanna Play Again ?                   ");
        Console.WriteLine("");
        Console.Write(value: "           ");
        if (selectedButton)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
        }
        Console.Write(value: "Yes");
        Console.ResetColor();
        Console.Write(value: "                ");
        if(!selectedButton){
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
        }
        Console.Write(value: "No");
        Console.ResetColor();

        var ch = Console.ReadKey(false).Key;
        switch (ch)
        {
            case ConsoleKey.LeftArrow:
                selectedButton = true;
                
                break;
            case ConsoleKey.RightArrow:
                selectedButton = false;
                break;
            case ConsoleKey.Enter:
                isSelected = true;
                playAgain = !selectedButton;
                break;
        }
    }
    Console.CursorVisible = true;
}