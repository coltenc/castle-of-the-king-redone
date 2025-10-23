//string that allows the game to repeat if the player wises.
string again = "yes";

//reapeats when the player wishes.
do
{
    //randomizes the outcome of each door and the amount of doors.
    Random random = new Random();
    int door = random.Next(5, 10);
    int king = random.Next(1, door);
    int treasure = random.Next(1, door);
    int streasure = random.Next(1, door);
    int ttreasure = random.Next(1, door);
    int exit = 0;

    //makes sure that the treasure isnt the same as the king door.
    while (king == treasure)
    {
        treasure = random.Next(1, door);
    }
    while (king == streasure)
    {
        streasure = random.Next(1, door);
    }
    while (king == ttreasure)
    {
        ttreasure = random.Next(1, door);
    }
    Console.WriteLine(king);
    Console.WriteLine(streasure);
    Console.WriteLine(ttreasure);
    Console.WriteLine(treasure);

    //picking the door the person wants.
    Console.WriteLine($"There are {door} amount of doors");
    Console.WriteLine($"one door will lead to the king, some may lead to treasure");
    Console.WriteLine("but the rest will lead to your demise");
    Console.WriteLine("which door will you choose (has to be a number)");
    int x = Convert.ToInt32(Console.ReadLine());

    //takes the players guess and takes it to the processing stage.
    do
    {
        switch (x)
        {
            case 1:
                exit = 1;
                break;

            case 2:
                exit = 1;
                break;

            case 3:
                exit = 1;
                break;

            case 4:
                exit = 1;
                break;

            case 5:
                exit = 1;
                break;

            case 6:
                exit = 1;
                break;

            case 7:
                exit = 1;
                break;

            case 8:
                exit = 1;
                break;

            case 9:
                exit = 1;
                break;

            case 10:
                exit = 1;
                break;

            default:
                Console.WriteLine("Please pick a door");
                break;
        }
    } while (exit == 0);

    //processing stage to see if the guess is right or not.
    if (x == king)
    {
        Console.WriteLine("You found the king congradulations!!!!");
    }
    else
    {
        if (x == treasure || x == streasure || x == ttreasure)
        {
            Console.WriteLine("Congradulations you found some treasure!!!!");
        }
        else
        {
            Console.WriteLine("You have found your demise please try again later!!");
        }
    }
    
    //asks to repeat the game.
    Console.WriteLine("Would you like to play again? (yes/no)");
    again = Console.ReadLine() + "";
    Console.WriteLine();
    Console.WriteLine();

} while (again == "yes");