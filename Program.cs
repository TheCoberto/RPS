Console.WriteLine("Welcome to RPS! Best of 5 rounds. Press any key to start.");
Console.ReadLine();

bool gameOn = true;
bool passesValidation;
string userInput = "";
int selection = 0;
int humanScore = 0;
int computerScore = 0;

while (gameOn == true)
{
    Console.Clear();
    Console.WriteLine("Human:" + humanScore + " Computer:" + computerScore);
    Console.WriteLine();
    Console.WriteLine("Please make a selection:");
    Console.WriteLine("");
    Console.WriteLine("1. Rock");
    Console.WriteLine("2. Paper");
    Console.WriteLine("3. Scissors");
    Console.WriteLine("");

    passesValidation = false;

    while (passesValidation == false)
    {
        userInput = Console.ReadLine();

        int.TryParse(userInput, out selection);

        if (selection != 1 && selection != 2 && selection != 3)
        {
            passesValidation = false;
            Console.WriteLine("Please select rock, paper, or scissors.");
        }
        else
        {
            passesValidation = true;

            if (selection == 1)
                Console.WriteLine("You have chosen rock!");

            if (selection == 2)
                Console.WriteLine("You have chosen paper!");

            if (selection == 3)
                Console.WriteLine("You have chosen scissors!");
        }
    }

    var random = new Random();
    var randomNumber = random.Next(1, 4);

    if (randomNumber == 1)
        Console.WriteLine("Computer has chosen rock!");

    if (randomNumber == 2)
        Console.WriteLine("Computer has chosen paper!");

    if (randomNumber == 3)
        Console.WriteLine("Computer has chosen scissors!");

    if (selection == randomNumber) // Tie game
        Console.WriteLine("It's a tie!");

    if (selection == 1 && randomNumber == 2) // Rock loses to Paper
    {
        Console.WriteLine("You lose!");
        computerScore++;
    }
    if (selection == 1 && randomNumber == 3) // Rock beats Scissors
    {
        Console.WriteLine("You win!");
        humanScore++;
    }
    if (selection == 2 && randomNumber == 1) // Paper beats Rock
    {
        Console.WriteLine("You win!");
        humanScore++;
    }
    if (selection == 2 && randomNumber == 3) // Paper loses to Scissors
    {
        Console.WriteLine("You lose!");
        computerScore++;
    }
    if (selection == 3 && randomNumber == 1) // Scissors loses to Rock
    {
        Console.WriteLine("You lose!");
        computerScore++;
    }
    if (selection == 3 && randomNumber == 2) // Scissors beats Paper
    {
        Console.WriteLine("You win!");
        humanScore++;
    }

    Console.WriteLine("");
    Console.WriteLine("Press any key to continue...");
    Console.ReadLine();

    if (humanScore == 5)
    {
        Console.Clear();
        DisplayFinalScore();
        Console.WriteLine("Congratulations! You won the game! That took a lot of skill.");
        gameOn = false;
        Console.ReadLine();

    }
    if (computerScore == 5)
    {
        Console.Clear();
        DisplayFinalScore();
        Console.WriteLine("Boo! You lost the game. Oh well. It's just luck after all.");
        gameOn = false;
        Console.ReadLine();
    }

    if (gameOn == false)
    {
        Console.Clear();
        Console.WriteLine("Do you want to player another game? If so, write 'yes'.");
        var poop = Console.ReadLine();
        if (poop.ToLower() == "yes")
        {
            gameOn = true;
            humanScore = 0;
            computerScore = 0;
        }
    }
}

void DisplayFinalScore()
{
    Console.WriteLine("Final Score");
    Console.WriteLine("-----------");
    Console.WriteLine("Human:" + humanScore + " Computer:" + computerScore);
    Console.WriteLine();
}