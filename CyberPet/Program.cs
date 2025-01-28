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
            art = "     (()__(()\r\n     /       \\ \r\n    ( /    \\  \\\r\n     \\ o o    /\r\n     (_()_)__/ \\             \r\n    / _,==.____ \\\r\n   (   |--|      )\r\n   /\\_.|__|'-.__/\\_\r\n  / (        /     \\ \r\n  \\  \\      (      /\r\n   )  '._____)    /    \r\n(((____.--(((____/";

        }
        else if (type == "DOG" || type == "2")
        {
            myPet = new PUPPY { Name = name, Size = size, Colour = colour };
            art = "    ___\r\n __/_  `.  .-\"\"\"-.\r\n \\_,` | \\-'  /   )`-')\r\n  \"\") `\"`    \\  ((`\"`\r\n ___Y  ,    .'7 /|\r\n(_,___/...-` (_/_/ ";
        }
        else if (type == "CAT" || type == "3")
        {
            myPet = new KITTY { Name = name, Size = size, Colour = colour };
            art = "  /\\_/\\  (\r\n ( ^.^ ) _)\r\n   \\\"/  (\r\n ( | | )\r\n(__d b__)";
        }
        // If a pet was successfully created, display its details
        if (myPet != null)
        {
            myPet.alive = true;
            Console.WriteLine($"You created a {myPet.GetType().Name} named {((dynamic)myPet).Name}, a {((dynamic)myPet).Colour} {myPet.GetType().Name}, with size {((dynamic)myPet).Size}.");
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("Invalid pet type selected.");
        }
        while (myPet.alive)
        {
            Console.Clear();
            Console.WriteLine(((dynamic)myPet).Name);
            Console.WriteLine($"Age: {myPet.age}");
            Console.WriteLine($"Hunger: {myPet.hunger} / 100");
            Console.WriteLine($"Happiness: {myPet.happiness} / 100");
            Console.WriteLine($"Loyalty: {myPet.loyalty} / 100");
            Console.WriteLine($"Fatness: {myPet.fatness} / 100");
            Console.WriteLine($"Tiredness: {myPet.tiredness} / 100");
            Console.WriteLine(art);
            Console.WriteLine("What do you want to do?\n1. Feed\n2. Play\n3. Sleep\n4. Pass");
            string decision = Console.ReadLine().ToUpper();
            Decision(decision, myPet);
            callCheckStatus();
            callEvents();
            myPet.rounds += 1;
        }
    }

    static void Feed(Pet myPet)
    {
        Console.WriteLine("What do you want to feed them?\n1. Burger hunger:50 fatness:30 loyalty:5 happiness:20\n2. Pizza hunger:40 fatness:20 loyalty:0 happiness:10\n3. Carrot hunger:20 fatness:0 loyalty:-20 happiness:-15\n4. Milk hunger:15 fatness:5 loyalty:-15 happiness:-25\n5. Cookie hunger:5 fatness:15 loyalty:30 happiness:25\n6. Bamboo hunger:5 fatness:5 loyalty:10 happiness:10");
        string eats = Console.ReadLine()?.ToUpper(); // Taking input and ensuring it's uppercase
        myPet.tiredness += 30;

        switch (eats)
        {
            case "1":
            case "BURGER":
                myPet.hunger += 50;
                myPet.fatness += 30;
                myPet.loyalty += 5;
                myPet.happiness += 20;
                Console.WriteLine("You fed the pet a Burger!");
                Console.ReadLine();
                break;

            case "2":
            case "PIZZA":
                myPet.hunger += 40;
                myPet.fatness += 20;
                myPet.loyalty += 0;
                myPet.happiness += 10;
                Console.WriteLine("You fed the pet a Pizza!");
                Console.ReadLine();
                break;

            case "3":
            case "CARROT":
                myPet.hunger += 20;
                myPet.fatness += 0;
                myPet.loyalty -= 20;
                myPet.happiness -= 15;
                Console.WriteLine("You fed the pet a Carrot!");
                Console.ReadLine();
                break;

            case "4":
            case "MILK":
                myPet.hunger += 15;
                myPet.fatness += 5;
                myPet.loyalty -= 15;
                myPet.happiness -= 25;
                Console.WriteLine("You fed the pet Milk!");
                Console.ReadLine();
                break;

            case "5":
            case "COOKIE":
                myPet.hunger += 5;
                myPet.fatness += 15;
                myPet.loyalty += 30;
                myPet.happiness += 25;
                myPet.alive = false;
                Console.WriteLine("You fed the pet Cookie!, but its poisionus for them so they died :(");
                Console.ReadLine();
                break;
            case "6":
            case "BAMBOO":
                if (myPet.GetType().Name == "PANDA")
                {
                    myPet.hunger += 20;
                    myPet.fatness += 5;
                    myPet.loyalty += 30;
                    myPet.happiness += 40;
                }
                else
                {
                    myPet.hunger += 5;
                    myPet.fatness += 5;
                    myPet.loyalty += 10;
                    myPet.happiness += 10;
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
                myPet.hunger -= 20;
                myPet.tiredness -= 20;
                Console.WriteLine("You made them sleep for 5 hours!");
                Console.ReadLine();
                break;

            case "2":
            case "8":
                myPet.hunger -= 40;
                myPet.tiredness -= 40;
                Console.WriteLine("You made them sleep for 8 hours!");
                Console.ReadLine();
                break;

            case "3":
            case "12":
                myPet.hunger -= 65;
                myPet.tiredness -= 65;
                Console.WriteLine("You made them sleep for 12 hours!");
                Console.ReadLine();
                break;

            case "4":
            case "24":
                myPet.hunger -= 100;
                myPet.tiredness -= 100;
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
        Console.WriteLine("Which game do you want to play?\n1. NumberGuess\n2. Battleships\n3. TicTacToe");
        string play = Console.ReadLine().ToUpper();
        switch (play)
        {
            case "1" or "NUMBERGUESS":
                callNumberGuess();
                break;
            case "2" or "BATTLESHIPS":
                callBattleships();
                break;
            case "3" or "TICTACTOE":
                callTicTacToe();
                break;
        }
        
    } 

    static void Decision(string decision, Pet myPet)
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
            case "666":
                RandomEvents events = new RandomEvents();
                bool kidnapped = events.Kidnapped(myPet, 9);
                if (kidnapped)
                {
                    Console.WriteLine("You never came back from hell, what a shame.");
                    myPet.alive = false;
                }
                break;
            default:
                myPet.rounds -= 1;
                Console.WriteLine("That option doesnt exist.");
                Console.ReadLine();
                break;
        }
    }

    static void callBattleships()
    {
        Battleship battleships = new Battleship();
        battleships.BattleShips();
        bool res = battleships.CheckGameStatus();
        if (res == true)
        {
            myPet.tiredness += 20;
            myPet.hunger -= 30;
            myPet.loyalty += 30;
            myPet.happiness += 30;
            myPet.fatness -= 30;
        }
        else if (res == false)
        {
            myPet.tiredness += 40;
            myPet.hunger -= 50;
            myPet.loyalty += 10;
            myPet.happiness += 20;
            myPet.fatness -= 10;
        }
    }

    static void callTicTacToe()
    {
        TicTacToe tictac = new TicTacToe();
        tictac.Game();
        string res = tictac.CheckWinner();
        if (res == "Player")
        {
            myPet.tiredness += 20;
            myPet.hunger -= 30;
            myPet.loyalty += 30;
            myPet.happiness += 30;
            myPet.fatness -= 30;
        }
        else if (res == "Tie")
        {
            myPet.tiredness += 40;
            myPet.hunger -= 50;
            myPet.loyalty += 10;
            myPet.happiness += 20;
            myPet.fatness -= 10;
        }
    }

    static void callNumberGuess()
    {
        NumberGuess numberguess = new NumberGuess();
        numberguess.NumberGuessing(myPet);
    }

    static void callCheckStatus()
    {
        CheckStatus checkstatus = new CheckStatus();
        checkstatus.Check(myPet);
    }
    
    static void callEvents()
    {
        CheckStatus checkstatus = new CheckStatus();
        checkstatus.callMethods(myPet);
        Console.ReadLine();
    }
}