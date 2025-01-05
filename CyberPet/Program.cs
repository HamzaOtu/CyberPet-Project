// Main Program
class Program
{
    public static Pet myPet = null;
    static void Main()
    {
        string art = "";
        // Get user input for pet details
        Console.WriteLine("What type of pet do you want?\n1. Panda\n2. Dog\n3. Cat");
        string type = Console.ReadLine()?.ToUpper() ?? "CAT"; // Default to "CAT" if no input
        Console.WriteLine($"What do you want to name your pet?");
        string name = Console.ReadLine() ?? "Unknown";
        Console.WriteLine($"What do you want the size of your pet to be?");
        int size = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine($"What do you want the colour of your pet to be?");
        string colour = Console.ReadLine() ?? "Unknown";

        if (type == "PANDA" || type == "1")
        {
            myPet = new PANDA { Name = name, Size = size, Colour = colour };
            art = "     (()__(()\r\n     /       \\ \r\n    ( /    \\  \\\r\n     \\ o o    /\r\n     (_()_)__/ \\             \r\n    / _,==.____ \\\r\n   (   |--|      )\r\n   /\\_.|__|'-.__/\\_\r\n  / (        /     \\ \r\n  \\  \\      (      /\r\n   )  '._____)    /    \r\n(((____.--(((____/mrf";
        }
        else if (type == "DOG" || type == "2")
        {
            myPet = new PUPPY { Name = name, Size = size, Colour = colour };
            art = "    ___\r\n __/_  `.  .-\"\"\"-.\r\n \\_,` | \\-'  /   )`-')\r\n  \"\") `\"`    \\  ((`\"`\r\n ___Y  ,    .'7 /|\r\n(_,___/...-` (_/_/ sk";
        }
        else if (type == "CAT" || type == "3")
        {
            myPet = new KITTY { Name = name, Size = size, Colour = colour };
            art = "  /\\_/\\  (\r\n ( ^.^ ) _)\r\n   \\\"/  (\r\n ( | | )\r\n(__d b__)";
        }
        // If a pet was successfully created, display its details
        if (myPet != null)
        {
            myPet.Alive = true;
            Console.WriteLine($"You created a {myPet.GetType().Name} named {((dynamic)myPet).Name}, a {((dynamic)myPet).Colour} {myPet.GetType().Name}, with size {((dynamic)myPet).Size}.");
        }
        else
        {
            Console.WriteLine("Invalid pet type selected.");
        }
        while (myPet.Alive)
        {
            Console.Clear();
            Console.WriteLine(((dynamic)myPet).Name);
            Console.WriteLine($"Age: {myPet.Age}");
            Console.WriteLine($"Hunger: {myPet.Hunger} / 100");
            Console.WriteLine($"Happiness: {myPet.Happiness} / 100");
            Console.WriteLine($"Loyalty: {myPet.Loyalty} / 100");
            Console.WriteLine($"Fatness: {myPet.Fatness} / 100");
            Console.WriteLine($"Tiredness: {myPet.Tiredness} / 100");
            Console.WriteLine(art);
            Console.WriteLine("What do you want to do?\n1. Feed\n2. Play\n3. Sleep\n4. Pass");
            string decision = Console.ReadLine().ToUpper();
            Decision(decision, myPet);
            Check(myPet);
            myPet.rounds += 1;
        }
    }

static void Feed(Pet myPet)
{
Console.WriteLine("What do you want to feed them?\n1. Burger hunger:50 fatness:30 loyalty:5 happiness:20\n2. Pizza hunger:40 fatness:20 loyalty:0 happiness:10\n3. Carrot hunger:20 fatness:0 loyalty:-20 happiness:-15\n4. Milk hunger:15 fatness:5 loyalty:-15 happiness:-25\n5. Cookie hunger:5 fatness:15 loyalty:30 happiness:25\n6. Bamboo hunger:5 fatness:5 loyalty:10 happiness:10");
string eats = Console.ReadLine()?.ToUpper(); // Taking input and ensuring it's uppercase
myPet.Tiredness += 30;

switch (eats)
    {
    case "1":
    case "BURGER":
        myPet.Hunger += 50;
        myPet.Fatness += 30;
        myPet.Loyalty += 5;
        myPet.Happiness += 20;
        Console.WriteLine("You fed the pet a Burger!");
        Console.ReadLine();
        break;

    case "2":
    case "PIZZA":
        myPet.Hunger += 40;
        myPet.Fatness += 20;
        myPet.Loyalty += 0;
        myPet.Happiness += 10;
        Console.WriteLine("You fed the pet a Pizza!");
        Console.ReadLine();
        break;

    case "3":
    case "CARROT":
        myPet.Hunger += 20;
        myPet.Fatness += 0;
        myPet.Loyalty -= 20;
        myPet.Happiness -= 15;
        Console.WriteLine("You fed the pet a Carrot!");
        Console.ReadLine();
        break;

    case "4":
    case "MILK":
        myPet.Hunger += 15;
        myPet.Fatness += 5;
        myPet.Loyalty -= 15;
        myPet.Happiness -= 25;
        Console.WriteLine("You fed the pet Milk!");
        Console.ReadLine();
        break;

    case "5":
    case "COOKIE":
            myPet.Hunger += 5;
            myPet.Fatness += 15;
            myPet.Loyalty += 30;
            myPet.Happiness += 25;
            myPet.Alive = false;
            Console.WriteLine("You fed the pet Cookie!, but its poisionus for them so they died :(");
            Console.ReadLine();
            break;
    case "6":
    case "BAMBOO":
            if (myPet.GetType().Name == "PANDA")
                {
                    myPet.Hunger += 20;
                    myPet.Fatness += 5;
                    myPet.Loyalty += 30;
                    myPet.Happiness += 40;
                }
            else
                {
                    myPet.Hunger += 5;
                    myPet.Fatness += 5;
                    myPet.Loyalty += 10;
                    myPet.Happiness += 10;
                }
            Console.WriteLine("You fed the pet Bamboo!");
            Console.ReadLine();
            break;


    default:
        Console.WriteLine("Invalid choice! Please choose a valid option.");
        break;
    }
}

    static void Sleep(Pet myPet)
    {
        Console.WriteLine("How long do you want them to sleep for:\n1. 5 hours hunger:-20 tiredness:-20\n2. 8 hours hunger:-40 tiredness:-40\n3. 12 hours hunger:-65 tiredness:-65\n4. 24 hours hunger:-100 tiredness:-100");
        string sleep = Console.ReadLine();
        switch (sleep)
        {
            case "1":
            case "5":
                myPet.Hunger -= 20;
                myPet.Tiredness -= 20;
                Console.WriteLine("You made them sleep for 5 hours!");
                Console.ReadLine();
                break;

            case "2":
            case "8":
                myPet.Hunger -= 40;
                myPet.Tiredness -= 40;
                Console.WriteLine("You made them sleep for 8 hours!");
                Console.ReadLine();
                break;

            case "3":
            case "12":
                myPet.Hunger -= 65;
                myPet.Tiredness -= 65;
                Console.WriteLine("You made them sleep for 12 hours!");
                Console.ReadLine();
                break;

            case "4":
            case "24":
                myPet.Hunger -= 100;
                myPet.Tiredness -= 100;
                Console.WriteLine("You made them sleep for 24 hours!");
                Console.ReadLine();
                break;


            default:
                Console.WriteLine("Invalid choice! Please choose a valid option.");
                break;
        }
    }

    static void Play(Pet myPet)
    {
        Console.WriteLine("Which game do you want to play?\n1. NumberGuess\n2. Battleships");
        string play = Console.ReadLine().ToUpper();
        switch (play)
        {
            case "1" or "NUMBERGUESS":
                NumberGuess(myPet);
                break;
            case "2" or "BATTLESHIPS":
                callBattleships();
                break;
        }

    }

    static void Decision(string decision,Pet myPet)
    {
        switch (decision)
        {
            case "1" or "FEED":
                Feed(myPet);
                break;
            case "2" or "PLAY":
                Play(myPet);
                break;
            case "3" or "SLEEP":
                Sleep(myPet);
                break;
            case "4" or "PASS":

                break;
            default:
                Console.WriteLine("That option doesnt exist.");
                break;
        }
    }
    static void Check(Pet myPet)
    {
        if (myPet.Tiredness > 100)
        {
            myPet.Tiredness = 100;
        }
        else if (myPet.Tiredness < 0)
        {
            myPet.Tiredness = 0;
        }
        if (myPet.Hunger > 100)
        {
            myPet.Hunger = 100;
        }
        else if (myPet.Hunger < 0)
        {
            myPet.Hunger = 0;
        }
        if (myPet.Loyalty > 100)
        {
            myPet.Loyalty = 100;
        }
        else if (myPet.Loyalty < 0)
        {
            myPet.Loyalty = 0;
        }
        if (myPet.Fatness > 100)
        {
            myPet.Fatness = 100;
        }
        else if (myPet.Fatness < 0)
        {
            myPet.Fatness = 0;
        }
        if (myPet.Happiness > 100)
        {
            myPet.Happiness = 100;
        }
        else if (myPet.Happiness < 0)
        {
            myPet.Happiness = 0;
        }
        if (myPet.Fatness > 80)
        {
            myPet.Obesity = true;
            Console.WriteLine("Your pet is obese make them work out!");
            Console.ReadLine();
        }
        if (myPet.rounds == 5)
        {
            myPet.rounds = 0;
            myPet.Age += 1;
        }
        if (myPet.Age > 30)
        {
            Random random = new Random();
            int survive = random.Next(100);
            if (survive > 10)
            {
                myPet.Alive = false;
                Console.WriteLine("Your pet died of old age :(");
                Console.ReadLine();
            }
        }
        if (myPet.Age > 25)
        {
            Random random = new Random();
            int survive = random.Next(100);
            if (survive > 30)
            {
                myPet.Alive = false;
                Console.WriteLine("Your pet died of old age :(");
                Console.ReadLine();
            }
        }
        if (myPet.Age > 20)
        {
            Random random = new Random();
            int survive = random.Next(100);
            if (survive > 65)
            {
                myPet.Alive = false;
                Console.WriteLine("Your pet died of old age :(");
                Console.ReadLine();
            }
        }
        if (myPet.Age > 16)
        {
            Random random = new Random();
            int survive = random.Next(100);
            if (survive > 90)
            {
                myPet.Alive = false;
                Console.WriteLine("Your pet died of old age :(");
                Console.ReadLine();
            }
        }
        if (myPet.Age > 12)
        {
            Random random = new Random();
            int survive = random.Next(100);
            if (survive == 100)
            {
                myPet.Alive = false;
                Console.WriteLine("Your pet died of old age :(");
                Console.ReadLine();
            }
        }     
        if (myPet.Obesity == true)
        {
            myPet.obesity_rounds += 1;
        }
        if (myPet.obesity_rounds == 5)
        {
            myPet.Alive = false;
            Console.WriteLine("Your pet died of obesity, you didnt look after him :(");
            Console.ReadLine();
        }
        if (myPet.Hunger < 20)
        {
            myPet.hunger_rounds += 1;
        }
        if (myPet.hunger_rounds == 5)
        {
            myPet.Alive = false;
            Console.WriteLine("Your pet starved to death, you didnt look after him :(");
            Console.ReadLine();
        }
        if (myPet.Tiredness > 80)
        {
            myPet.tiredness_rounds += 1;
        }
        if (myPet.tiredness_rounds == 5)
        {
            myPet.Alive = false;
            Console.WriteLine("Your pet overworked, you didnt look after him :(");
            Console.ReadLine();
        }
    }

    static void callBattleships()
    {
        Battleship battleships = new Battleship();
        battleships.BattleShips(myPet);
            
    }

    static void NumberGuess(Pet myPet)
    {
        int guesses = 0;
        Random random = new Random();
        int number = random.Next(10);
        for (int i = 0; i < 1; i++)
        {
            Console.WriteLine("Guess a number between 0-9");
            int guess = Convert.ToInt16(Console.ReadLine());
            if (guesses < 2)
            {
                if (guess == number)
                {
                    Console.WriteLine("You guessed it correct!");
                    Console.ReadLine();
                    myPet.Tiredness += 20;
                    myPet.Loyalty += 20;
                    myPet.Hunger -= 20;
                    myPet.Happiness += 30;
                }
                else
                {
                    Console.WriteLine("You guessed it wrong!");
                    i--;
                    myPet.Tiredness += 15;
                    myPet.Loyalty += 5;
                    myPet.Hunger -= 15;
                    myPet.Happiness += 5;
                    guesses ++;
                    Console.WriteLine($"Guesses left: {3 - guesses}");
                    if (guess > number)
                    {
                        Console.WriteLine("Your guess was too high!");
                    }
                    else
                    {
                        Console.WriteLine("Your guess was too low");
                    }
                }
            }
            else
            {
                Console.WriteLine($"You ran out of guesses!\nCorrect number was {number}!");
                Console.ReadLine();
            }
        }
    }
}
