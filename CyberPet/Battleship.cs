
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

    public void BattleShips()
    {
        ChangeGrid();
        Welcome();
        PlaceShip();
        GameLoop();

    }

    public void Welcome()
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

    public void PlaceShip()
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
            CheckGameStatus();
        }
    }


    public void ChangeGrid()
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

    public void Displayhit()
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

    public void ExecuteAttack()
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

    public bool CheckGameStatus()
    {
        bool b = false;
        if (battleships == 0)
        {
            Console.Clear();
            game = false;
            Console.WriteLine("__   __           __        __          _ \r\n\\ \\ / /__  _   _  \\ \\      / /__  _ __ | |\r\n \\ V / _ \\| | | |  \\ \\ /\\ / / _ \\| '_ \\| |\r\n  | | (_) | |_| |   \\ V  V / (_) | | | |_|\r\n  |_|\\___/ \\__,_|    \\_/\\_/ \\___/|_| |_(_)");
            Console.WriteLine("                                  .                   .\r\n                              _..-''\"\"\"\\          _.--'\"\"\"\\\r\n                              |         L         |        \\\r\n                  _           / _.-.---.\\.        / .-.----.\\\r\n                _/-|---     _/<\"---'\"\"\"\"\"\\\\`.    /-'--''\"\"\"\"\"\\\r\n               |       \\     |            L`.`-. |            L\r\n               /_.-.---.L    |            \\  \\  `|            J`.\r\n             _/--'\"\"\"\"  \\    F            \\L  \\  |             L\r\n               L      `. L  J  _.---.-\"\"\"-.\\`. L_/ _.--|\"\"\"\"\"--.\\ `.\r\n               |        \\+. /-\"__.--'\"\"\"\"   \\ `./'\"---'\"\"\"\"\"\"   \\`. `.\r\n               F   _____ \\ `F\"        `.     \\  \\                L `.\r\n              /.-'\"_|---'\"\\ |           `    JL |                 L  `.`.\r\n             <-'\"\"         \\|    _.-.------._ A J    _.-.-----`.--|   ``.`.\r\n              L         `. |/.-'\"_.-`---'\"\"\\.\"| /-'\"---'\"\"\"\"\"   \\`.\\.  \\ `.`.\r\n              |  _.------\\.<'\"\"\"            L\\ L\\                `.`\\`. \\  `.\r\n         _.-'//'\"--'\"\"\"   L\\|       ________\\ `.F     ___.-------._L \\ `-\\   \\`.\r\n        /___| F             F _.--'\"_|-------L  /_.-'\"_.-|-'\"\"\"\"\"\"\"\\  L   L   `.`.\r\n            | F  _.-'|\"\"\"\"\"/'\"-'\"\"\"          J <'\"\"\"                L J   |     `.`.\r\n            |/-'-''/|\"\"\\ )-|\\                 F \\                   |  L .'\"\"\"`\\\"\"-\\\\_\r\n             F`-'-'-(`-')  | \\                F  \\                  |___`\"\"\"`.\"\"`.-'\"\r\n------------/        `-'---|  F               L   L             __     |\"\"\"\"\"`-'\"__________\r\n          .'_         |    |__L          __  J__  |    _.--'\"\"\"\"   `\".----'\".'\r\n         '\"\"\"\"\"\"\"\"\"\"\"\"|--._+--F _.-'\"\"||\"   \"\"\"___/.-'\"   ||-'\"/\"\"\"\"\" \\_. .'\r\n         J------------(___\\__/'_____.--------'-------'\"\"\"\"\"\"\"\"           /\r\n         `-.                                        _.__.__.__.____     J_.-._\r\n    .'`-._ (-`--`---.'--._`---._.-'`-._.-'_.-'``-._'               `-''-'\r\n\r\n------------------------------------------------\r\n");
            Console.WriteLine("Ai doesn't have any battleships left");
            Console.ReadKey();
            Console.ReadLine();
            b = true;
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
            b = false;
        }
        return b;
    }
}