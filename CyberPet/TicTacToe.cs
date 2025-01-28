using System.Threading.Tasks.Dataflow;

class TicTacToe
{
    public static string[,] showGrid = new string[3, 3];
    public bool game = true;
    public static List<string> playerPoints = new List<string>();
    public static List<string> aiPoints = new List<string>();

    public void Game()
    {
        Welcome();
        ChangeGrid();
        while (game)
        {
            Displayhit();
            PlayerPlace();
            AiPlace();
            CheckWinner();
        }


    }

    private static void Welcome()
    {
        Console.WriteLine("                              Welcome to TicTacToe!");
    }

    private static void PlayerPlace()
    {
        Console.WriteLine("Which x position do you want to place it? (1-3)");
        int x = Convert.ToInt16(Console.ReadLine()) - 1;
        Console.WriteLine("Which y position do you want to place it? (1-3)");
        int y = Convert.ToInt16(Console.ReadLine()) - 1;
        string coords = Convert.ToString(x) + Convert.ToString(y);

        for (int i = 0; i < 1; i++)
        {
            if (i == 0)
            {
                if (showGrid[y, x] == "~")
                {
                    showGrid[y, x] = "O";
                    playerPoints.Add(coords);
                }
            }
            else
            {
                Console.WriteLine("You can't place it here");
                i--;
            }

        }
    }

    private static void AiPlace()
    {
        Random rand = new Random();
        int x = rand.Next(3);
        int y = rand.Next(3);
        string coords = Convert.ToString(x) + Convert.ToString(y);
        for (int i = 0; i < 1; i++)
        {
            if (i == 0)
            {
                if (showGrid[y, x] == "~")
                {
                    showGrid[y, x] = "X";
                    aiPoints.Add(coords);
                }
                else
                {
                    i--;
                }
            }
            else
            {
                break;
            }
        }
    }

    public void ChangeGrid()
    {
        for (int j = 0; j < 3; j++)
        {
            for (int k = 0; k < 3; k++)
            {
                showGrid[j, k] = "~";
            }
        }
    }

    public void Displayhit()
    {
        Console.WriteLine("Y X 1  2  3");
        for (int j = 0; j < 3; j++)
        {
            Console.Write($"{j + 1}  ");
            for (int k = 0; k < 3; k++)
            {
                Console.Write($"|{showGrid[j, k]}|");
            }
            Console.WriteLine();
        }
    }

    public bool IsBoardFull()
    {
        int count = 0;
        for (int j = 0; j < 3; j++)
        {
            for (int k = 0; k < 3; k++)
            {
               if (showGrid[j, k] != "~")
                {
                    count++;
                }
            }
        }
        if (count == 9)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public string CheckWinner()
    {
        if (IsBoardFull())
        {
            return "Tie";
        }
        else
        {
            return "Player";
        }

    }
}