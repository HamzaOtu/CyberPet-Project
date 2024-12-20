using CyberPet;
using System;
using System.ComponentModel;

namespace CyberPet
{
    // Base Pet class
    class Pet
    {
        public int Age { get; set; }
        public int Hunger { get; set; }
        public int Happiness { get; set; }
        public int Loyalty { get; set; }
        public bool Alive { get; set; }
        public int Fatness { get; set; }
        public bool Obesity { get; set; }
        public int Tiredness { get; set; }
        public int rounds { get; set; }
        public int obesity_rounds { get; set; }
        public int hunger_rounds { get; set; }
        public int tiredness_rounds { get; set; }

        public Pet()
        {
            Age = 0;
            Hunger = 50;
            Happiness = 20;
            Alive = true;
            Loyalty = 10;
            Fatness = 20;
            Obesity = false;
            Tiredness = 0;
        }
    }

    // Kitty class inheriting from Pet
    internal class KITTY : Pet
    {
        public string? Type { get; set; }
        public string? Name { get; set; }
        public string? Colour { get; set; }
        public int Size { get; set; }

        public KITTY() : base()
        {
            Type = "Cat";
            Name = "Kitty";
            Colour = "Unknown";
            Size = 0;
        }
    }

    // Puppy class inheriting from Pet
    internal class PUPPY : Pet
    {
        public string? Type { get; set; }
        public string? Name { get; set; }
        public string? Colour { get; set; }
        public int Size { get; set; }

        public PUPPY() : base()
        {
            Type = "Dog";
            Name = "Puppy";
            Colour = "Unknown";
            Size = 0;
        }
    }

    // Panda class inheriting from Pet
    internal class PANDA : Pet
    {
        public string? Type { get; set; }
        public string? Name { get; set; }
        public string? Colour { get; set; }
        public int Size { get; set; }

        public PANDA() : base()
        {
            Type = "Panda";
            Name = "Panda";
            Colour = "Black & White";
            Size = 0;
        }
    }

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

    class Battleship
    {
        public static int[,] playerGrid = new int[10, 10];
        public static int[,] aiGrid = new int[10, 10];
        public static string[,] hitGrid = new string[10, 10];
        public static List<string> playerPoints = new List<string>();
        public static List<string> aiPoints = new List<string>();
        public static int battleships;
        public static int b_left;
        public static int money = 1000;
        public static int multiplier = 1;
        public static bool game = true;
        public static List<string> aihit = new List<string>();
        public static List<string> phit = new List<string>();
        public static int amount;
        private Pet myPet;

        public void BattleShips(Pet myPet)
        {
            ChangeGrid();
            Welcome();
            PlaceShip();
            GameLoop();
            this.myPet = myPet;

        }

        public static void Welcome()
        {
            Console.WriteLine("                              Welcome to Battleships!");
            Console.WriteLine("                                  .                   .\r\n                              _..-''\"\"\"\\          _.--'\"\"\"\\\r\n                              |         L         |        \\\r\n                  _           / _.-.---.\\.        / .-.----.\\\r\n                _/-|---     _/<\"---'\"\"\"\"\"\\\\`.    /-'--''\"\"\"\"\"\\\r\n               |       \\     |            L`.`-. |            L\r\n               /_.-.---.L    |            \\  \\  `|            J`.\r\n             _/--'\"\"\"\"  \\    F            \\L  \\  |             L\r\n               L      `. L  J  _.---.-\"\"\"-.\\`. L_/ _.--|\"\"\"\"\"--.\\ `.\r\n               |        \\+. /-\"__.--'\"\"\"\"   \\ `./'\"---'\"\"\"\"\"\"   \\`. `.\r\n               F   _____ \\ `F\"        `.     \\  \\                L `.\r\n              /.-'\"_|---'\"\\ |           `    JL |                 L  `.`.\r\n             <-'\"\"         \\|    _.-.------._ A J    _.-.-----`.--|   ``.`.\r\n              L         `. |/.-'\"_.-`---'\"\"\\.\"| /-'\"---'\"\"\"\"\"   \\`.\\.  \\ `.`.\r\n              |  _.------\\.<'\"\"\"            L\\ L\\                `.`\\`. \\  `.\r\n         _.-'//'\"--'\"\"\"   L\\|       ________\\ `.F     ___.-------._L \\ `-\\   \\`.\r\n        /___| F             F _.--'\"_|-------L  /_.-'\"_.-|-'\"\"\"\"\"\"\"\\  L   L   `.`.\r\n            | F  _.-'|\"\"\"\"\"/'\"-'\"\"\"          J <'\"\"\"                L J   |     `.`.\r\n            |/-'-''/|\"\"\\ )-|\\                 F \\                   |  L .'\"\"\"`\\\"\"-\\\\_\r\n             F`-'-'-(`-')  | \\                F  \\                  |___`\"\"\"`.\"\"`.-'\"\r\n------------/        `-'---|  F               L   L             __     |\"\"\"\"\"`-'\"__________\r\n          .'_         |    |__L          __  J__  |    _.--'\"\"\"\"   `\".----'\".'\r\n         '\"\"\"\"\"\"\"\"\"\"\"\"|--._+--F _.-'\"\"||\"   \"\"\"___/.-'\"   ||-'\"/\"\"\"\"\" \\_. .'\r\n         J------------(___\\__/'_____.--------'-------'\"\"\"\"\"\"\"\"           /\r\n         `-.                                        _.__.__.__.____     J_.-._\r\n    .'`-._ (-`--`---.'--._`---._.-'`-._.-'_.-'``-._'               `-''-'\r\n\r\n------------------------------------------------\r\n");
            for (int i = 1; i < 2; i++)
            {
                Console.WriteLine("How many ships there should be (1-100):");
                amount = int.Parse(Console.ReadLine());
                if (amount > 100)
                {
                    Console.Clear();
                    Console.WriteLine("Please choose a number below 100!");
                    i--;
                }
            }
        }

        public static void PlaceShip()
        {
            battleships = amount;

            try
            {
                for (int i = 0; i < amount; i++)
                {
                    Console.WriteLine("Put an X coordinate (0-9):");
                    int p_x_pos = int.Parse(Console.ReadLine());
                    Console.WriteLine("Put a Y coordinate (0-9):");
                    int p_y_pos = int.Parse(Console.ReadLine());
                    if (playerGrid[p_y_pos, p_x_pos] == 0)
                    {
                        playerGrid[p_y_pos, p_x_pos] += 1;
                        string pl_x_pos = Convert.ToString(p_x_pos);
                        string pl_y_pos = Convert.ToString(p_y_pos);
                        string new_p_pos = pl_x_pos + " " + pl_y_pos;
                        playerPoints.Add(new_p_pos);
                    }
                    else
                    {
                        Console.WriteLine("There is already a ship there");
                        i--;
                    }
                }
                b_left = playerPoints.Count();
            }
            catch (IndexOutOfRangeException)
            {
                Console.Clear();
                Console.WriteLine("That is out of range!");
                Console.WriteLine("You have been punished!");
                Console.WriteLine($"You only have {playerPoints.Count} ships!");
                b_left = playerPoints.Count();
            }
            catch (FormatException)
            {
                Console.Clear();
                Console.WriteLine("That is not a number!");
                Console.WriteLine("You have been punished!");
                Console.WriteLine($"You only have {playerPoints.Count} ships!");
                b_left = playerPoints.Count();
            }

            for (int i = 0; i < amount; i++)
            {
                Random rand = new Random();
                int x_pos = rand.Next(10);
                int y_pos = rand.Next(10);
                if (aiGrid[y_pos, x_pos] == 0)
                {
                    aiGrid[y_pos, x_pos] += 1;
                }
                else
                {
                    i--;
                }
                string s_x_pos = Convert.ToString(y_pos);
                string s_y_pos = Convert.ToString(x_pos);
                string new_pos = s_y_pos + " " + s_x_pos;
                aiPoints.Add(new_pos);
            }
        }

        public void GameLoop()
        {
            while (game)
            {
                Displayhit();
                Console.WriteLine("Attack(A) or Shop(S)");
                string answer = Console.ReadLine();

                if (answer.ToUpper() == "ATTACK" || answer.ToUpper() == "A")
                {
                    ExecuteAttack();
                }
                else if (answer.ToUpper() == "SHOP" || answer.ToUpper() == "S")
                {
                    BuyAbility();
                }

                AIAttack();
                CheckGameStatus(myPet);
            }
        }


        public static void ChangeGrid()
        {
            for (int j = 0; j < 10; j++)
            {
                for (int k = 0; k < 10; k++)
                {
                    hitGrid[j, k] = "~";
                }
            }
        }

        public static void DisplayGrid()
        {
            Console.WriteLine("Y X 0  1  2  3  4  5  6  7  8  9");
            for (int j = 0; j < 10; j++)
            {
                Console.Write($"{j}  ");
                for (int k = 0; k < 10; k++)
                {
                    Console.Write($"|{playerGrid[j, k]}|");
                }
                Console.WriteLine();
            }
        }

        public static void Displayhit()
        {
            Console.WriteLine("Y X 0  1  2  3  4  5  6  7  8  9");
            for (int j = 0; j < 10; j++)
            {
                Console.Write($"{j}  ");
                for (int k = 0; k < 10; k++)
                {
                    Console.Write($"|{hitGrid[j, k]}|");
                }
                Console.WriteLine();
            }
        }

        public static void ExecuteAttack()
        {
            for (int a = 1; a < 2; a++)
            {
                try
                {
                    Console.WriteLine("Which x position do you want to attack? (0 - 9)");
                    int attackX = int.Parse(Console.ReadLine());
                    Console.WriteLine("Which y position do you want to attack? (0 - 9)");
                    int attackY = int.Parse(Console.ReadLine());
                    string new_x_new = Convert.ToString(attackY);
                    string new_y_new = Convert.ToString(attackX);
                    string new_new_pos = new_y_new + " " + new_x_new;
                    if (!phit.Contains(new_new_pos))
                    {
                        if (aiGrid[attackY, attackX] == 1)
                        {
                            Console.Clear();
                            aiGrid[attackY, attackX] = 0;
                            Console.WriteLine("You hit a ship!");
                            string a_x_pos = Convert.ToString(attackY);
                            string a_y_pos = Convert.ToString(attackX);
                            string new_a_pos = a_y_pos + " " + a_x_pos;
                            aiPoints.Remove(new_a_pos);
                            battleships--;
                            money += 100;
                            multiplier = 1;
                            phit.Add(new_new_pos);
                            hitGrid[attackY, attackX] = "X";
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("You missed!");
                            money += 5 * multiplier;
                            multiplier = Math.Min(multiplier + 1, 5);
                            phit.Add(new_new_pos);
                            hitGrid[attackY, attackX] = "X";
                        }
                        Console.WriteLine($"You have {money} Dollars\nAi has {battleships} battleships left");
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("You already shot there, pick new coordinates!\nHere is all the coordinates you shot marked as X!");
                        Displayhit();
                        a--;
                    }
                }
                catch (IndexOutOfRangeException)
                {
                    Console.Clear();
                    Console.WriteLine("Such position doesn't exist!");
                }
                catch (FormatException)
                {
                    Console.Clear();
                    Console.WriteLine("Only enter numbers!");
                }
            }
        }

        public static void BuyAbility()
        {
            Console.WriteLine($"You have {money} Dollars \nWhich ability would you like to buy: \nRadar:300 \nShield:400 \nNew:500 \nGrid:1000 \nNuke:2000");
            string ability = Console.ReadLine();

            switch (ability.ToUpper())
            {
                case "RADAR":
                    if (money >= 300)
                    {
                        Console.Clear();
                        money -= 300;
                        Console.WriteLine($"You have {money} Dollars\nThere is a ship at coordinates {aiPoints[0]}");
                        aiPoints.RemoveAt(0);
                    }
                    else
                    {
                        Console.WriteLine("Insufficient Funds");
                    }
                    break;

                case "SHIELD":
                    if (money >= 400)
                    {
                        {
                            Console.Clear();
                            Console.WriteLine("Here are the coordinates of your battleships");
                            DisplayGrid();
                            Console.WriteLine("Choose the x coordinate of the battleship");
                            int pro_x = int.Parse(Console.ReadLine());
                            Console.WriteLine("Choose the y coordinate of the battleship");
                            int pro_y = int.Parse(Console.ReadLine());
                            if (playerGrid[pro_y, pro_x] != 0)
                            {
                                playerGrid[pro_y, pro_x] += 1;
                                money -= 400;
                            }
                            else
                            {
                                Console.WriteLine("There are no battleships there");
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Insufficient Funds");
                    }
                    break;

                case "NEW":
                    if (money >= 500)
                    {
                        {
                            Console.Clear();
                            DisplayGrid();
                            Console.WriteLine("Choose an x coordinate for your new battleship");
                            int new_x = int.Parse(Console.ReadLine());
                            Console.WriteLine("Choose an y coordinate for your new battleship");
                            int new_y = int.Parse(Console.ReadLine());
                            playerGrid[new_y, new_x] += 1;
                            b_left++;
                            money -= 500;
                            string new_x_new = Convert.ToString(new_y);
                            string new_y_new = Convert.ToString(new_x);
                            string new_new_pos = new_y_new + " " + new_x_new;
                            playerPoints.Add(new_new_pos);
                            aihit.Remove(new_new_pos);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Insufficient Funds");
                    }
                    break;

                case "GRID":
                    if (money >= 1000)
                    {
                        {
                            Console.Clear();
                            Console.WriteLine("Here is the Ai's grid");
                            money -= 1000;
                            Console.WriteLine("Y X 0  1  2  3  4  5  6  7  8  9");
                            for (int j = 0; j < 10; j++)
                            {
                                Console.Write($"{j}  ");
                                for (int k = 0; k < 10; k++)
                                {
                                    Console.Write($"|{aiGrid[j, k]}|");
                                }
                                Console.WriteLine();
                            }
                            Console.WriteLine("");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Insufficient Funds");
                    }
                    break;

                case "NUKE":
                    if (money >= 2000)
                    {
                        {
                            Console.Clear();
                            money -= 2000;
                            battleships = 0;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Insufficient Funds");
                    }
                    break;

                default:
                    Console.WriteLine("Invalid ability");
                    break;
            }
        }

        public static void AIAttack()
        {
            for (int a = 1; a < 2; a++)
            {
                Random rand = new Random();
                int ai_a_x_pos = rand.Next(10);
                int ai_a_y_pos = rand.Next(10);
                string new_x_new = Convert.ToString(ai_a_y_pos);
                string new_y_new = Convert.ToString(ai_a_x_pos);
                string new_new_pos = new_y_new + " " + new_x_new;
                if (!aihit.Contains(new_new_pos))
                {
                    if (playerGrid[ai_a_y_pos, ai_a_x_pos] != 0)
                    {
                        playerGrid[ai_a_y_pos, ai_a_x_pos] -= 1;
                        if (playerGrid[ai_a_y_pos, ai_a_x_pos] == 0)
                        {
                            Console.WriteLine("You lost a battleship!");
                            b_left--;
                            Console.WriteLine("You have " + b_left + " battleships left!");
                            aihit.Add(new_new_pos);
                        }
                        else
                        {
                            Console.WriteLine("One of your battleships lost one life");
                            Console.WriteLine("You have " + b_left + " battleships left!");
                            aihit.Add(new_new_pos);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Ai has missed!");
                        Console.WriteLine("You have " + b_left + " battleships left!");
                    }
                }
                else
                {
                    a--;
                }
            }

        }

        public static void CheckGameStatus(Pet myPet)
        {
            if (battleships == 0)
            {
                Console.Clear();
                game = false;
                Console.WriteLine("__   __           __        __          _ \r\n\\ \\ / /__  _   _  \\ \\      / /__  _ __ | |\r\n \\ V / _ \\| | | |  \\ \\ /\\ / / _ \\| '_ \\| |\r\n  | | (_) | |_| |   \\ V  V / (_) | | | |_|\r\n  |_|\\___/ \\__,_|    \\_/\\_/ \\___/|_| |_(_)");
                Console.WriteLine("                                  .                   .\r\n                              _..-''\"\"\"\\          _.--'\"\"\"\\\r\n                              |         L         |        \\\r\n                  _           / _.-.---.\\.        / .-.----.\\\r\n                _/-|---     _/<\"---'\"\"\"\"\"\\\\`.    /-'--''\"\"\"\"\"\\\r\n               |       \\     |            L`.`-. |            L\r\n               /_.-.---.L    |            \\  \\  `|            J`.\r\n             _/--'\"\"\"\"  \\    F            \\L  \\  |             L\r\n               L      `. L  J  _.---.-\"\"\"-.\\`. L_/ _.--|\"\"\"\"\"--.\\ `.\r\n               |        \\+. /-\"__.--'\"\"\"\"   \\ `./'\"---'\"\"\"\"\"\"   \\`. `.\r\n               F   _____ \\ `F\"        `.     \\  \\                L `.\r\n              /.-'\"_|---'\"\\ |           `    JL |                 L  `.`.\r\n             <-'\"\"         \\|    _.-.------._ A J    _.-.-----`.--|   ``.`.\r\n              L         `. |/.-'\"_.-`---'\"\"\\.\"| /-'\"---'\"\"\"\"\"   \\`.\\.  \\ `.`.\r\n              |  _.------\\.<'\"\"\"            L\\ L\\                `.`\\`. \\  `.\r\n         _.-'//'\"--'\"\"\"   L\\|       ________\\ `.F     ___.-------._L \\ `-\\   \\`.\r\n        /___| F             F _.--'\"_|-------L  /_.-'\"_.-|-'\"\"\"\"\"\"\"\\  L   L   `.`.\r\n            | F  _.-'|\"\"\"\"\"/'\"-'\"\"\"          J <'\"\"\"                L J   |     `.`.\r\n            |/-'-''/|\"\"\\ )-|\\                 F \\                   |  L .'\"\"\"`\\\"\"-\\\\_\r\n             F`-'-'-(`-')  | \\                F  \\                  |___`\"\"\"`.\"\"`.-'\"\r\n------------/        `-'---|  F               L   L             __     |\"\"\"\"\"`-'\"__________\r\n          .'_         |    |__L          __  J__  |    _.--'\"\"\"\"   `\".----'\".'\r\n         '\"\"\"\"\"\"\"\"\"\"\"\"|--._+--F _.-'\"\"||\"   \"\"\"___/.-'\"   ||-'\"/\"\"\"\"\" \\_. .'\r\n         J------------(___\\__/'_____.--------'-------'\"\"\"\"\"\"\"\"           /\r\n         `-.                                        _.__.__.__.____     J_.-._\r\n    .'`-._ (-`--`---.'--._`---._.-'`-._.-'_.-'``-._'               `-''-'\r\n\r\n------------------------------------------------\r\n");
                Console.WriteLine("Ai doesn't have any battleships left");
                Console.ReadKey();
                Console.ReadLine();
                myPet.Tiredness += 20;
                myPet.Happiness += 40;
                myPet.Hunger -= 20;
                myPet.Loyalty += 40;
            }
            else if (b_left == 0)
            {
                Console.Clear();
                game = false;
                Console.WriteLine("__   __            _              _   _ \r\n\\ \\ / /__  _   _  | |    ___  ___| |_| |\r\n \\ V / _ \\| | | | | |   / _ \\/ __| __| |\r\n  | | (_) | |_| | | |__| (_) \\__ \\ |_|_|\r\n  |_|\\___/ \\__,_| |_____\\___/|___/\\__(_)");
                Console.WriteLine("--    .-\"\"-.\r\n   ) (     )\r\n  (   )   (\r\n     /     )\r\n    (_    _)                     0_,-.__\r\n      (_  )_                     |_.-._/\r\n       (    )                    |_--..\\\r\n        (__)                     |__--_/\r\n     |''   ``\\                   |\r\n     |        \\                  |      /b.\r\n     |         \\  ,,,---===?A`\\  |  ,==y'\r\n   ___,,,,,---==\"\"\\        |M] \\ | ;|\\ |>\r\n           _   _   \\   ___,|H,,---==\"\"\"\"bno,\r\n    o  O  (_) (_)   \\ /          _     AWAW/\r\n                     /         _(+)_  dMM/\r\n      \\@_,,,,,,---==\"   \\      \\\\|//  MW/\r\n--''''\"                         ===  d/\r\n                                    //\r\n                                    ,'__________________________\r\n   \\    \\    \\     \\               ,/~~~~~~~~~~~~~~~~~~~~~~~~~~~\r\n                         _____    ,'  ~~~   .-\"\"-.~~~~~~  .-\"\"-.\r\n      .-\"\"-.           ///==---   /`-._ ..-'      -.__..-'\r\n            `-.__..-' =====\\\\\\\\\\\\ V/  .---\\.\r\n PGMG                 ~~~~~~~~~~~~, _',--/_.\\  .-\"\"-.\r\n                            .-\"\"-.___` --  \\|         -.__..-\r\n\r\n------------------------------------------------\r\n");
                Console.WriteLine("You don't have any battleships left");
                Console.ReadKey();
                Console.ReadLine();
                myPet.Tiredness += 40;
                myPet.Happiness += 20;
                myPet.Hunger -= 40;
                myPet.Loyalty += 20;
            }
        }
    }
}