class NumberGuess
{
    public void NumberGuessing(Pet myPet)
    {
        int guesses = 0;
        Random random = new Random();
        int number = random.Next(10);
        for (int i = 0; i < 1; i++)
        {
            Console.WriteLine("Guess a number between 0-9");
            int guess = Convert.ToInt16(Console.ReadLine());
            if (guesses < 3)
            {
                if (guess == number)
                {
                    Console.WriteLine("You guessed it correct!");
                    Console.ReadLine();
                    myPet.tiredness += 20;
                    myPet.loyalty += 20;
                    myPet.hunger -= 20;
                    myPet.happiness += 30;
                    myPet.fatness -= 30;
                    break;
                }
                else
                {
                    Console.WriteLine("You guessed it wrong!");
                    i--;
                    myPet.tiredness += 15;
                    myPet.loyalty += 5;
                    myPet.hunger -= 15;
                    myPet.happiness += 5;
                    myPet.fatness -= 10;
                    guesses++;
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
            else if (guesses == 3)
            {
                Console.WriteLine($"You ran out of guesses!\nCorrect number was {number}!");
                Console.ReadLine();
            }
        }
    }
}