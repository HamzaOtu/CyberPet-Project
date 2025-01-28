using System.Threading.Channels;

class RandomEvents
{
    public bool BabyComing(int chances)
    {
        bool isBaby = false;
        if (chances  == 10)
        {
            isBaby = true;
        }
        else
        {
            isBaby = false;
        }
        return isBaby;
    }

    public bool RanAway(Pet myPet,int chances)
    {
        bool ranaway = false;
        if (myPet.loyalty < 15)
        {
            if (chances < 80 && chances > 55)
            {
                ranaway = true;
            }
            else
            {
                ranaway = false;
            }
        }
        else
        {
            ranaway = false;
        }
        return ranaway;
    }

    public bool CarCrash(Pet myPet, int chances)
    {
        bool crash = false;
        if (chances < 34 && chances > 30)
        {
            crash = true;
            Console.WriteLine("A car crashed into your pet will you take him to the vet? Y/N");
            string answer = Console.ReadLine().ToUpper();
            if (answer == "Y")
            {
                Random rand = new Random();
                int survive = rand.Next(3);
                if ( survive < 2)
                {
                    crash = false;
                    myPet.happiness -= 30;
                    myPet.tiredness += 30;
                    myPet.loyalty += 30;
                    myPet.fatness -= 50;
                    Console.WriteLine($"A car crashed into {((dynamic)myPet).Name} but he survived!!!!!");
                }
            }
            else
            {
                Console.WriteLine("You didnt even try ._.");
            }
        }
        return crash;
    }

    public bool IsIll(Pet myPet, int chances)
    {
        bool ill = false;
        if (chances < 19 && chances > 13)
        {
            ill = true;
            Console.WriteLine("Your pet got ill will you take him to the vet? Y/N");
            string answer = Console.ReadLine().ToUpper();
            if (answer == "Y")
            {
                Random rand = new Random();
                int survive = rand.Next(12);
                if (survive < 9)
                {
                    ill = false;
                    Console.WriteLine($"{((dynamic)myPet).Name} got ill but survived!!!");
                    myPet.happiness -= 30;
                    myPet.tiredness += 30;
                    myPet.loyalty += 30;
                    myPet.fatness -= 50;
                }
            }
            else
            {
                Console.WriteLine("You didnt even try ._.");
            }
        }
        return ill;
    }

    public bool SoftTacos(Pet myPet, int chances)
    {
        bool found = false;
        if (chances == 1)
        {
            found = true;
            Console.WriteLine($"{((dynamic)myPet).Name} has found some soft tacos!!!!!!!!");
        }
        return found;
    }

    public bool Kidnapped(Pet myPet, int chances)
    {
        bool kidnapped = false;
        if (chances < 10 && chances > 7)
        {
            kidnapped = true;
            Console.WriteLine("Your pet got kidnapped by demons and is now in hell, will you go there to help him? Y/N");
            string will_go = Console.ReadLine().ToUpper(); 
            if (will_go == "Y")
            {
                int strength = 0;
                Console.WriteLine("Choose a weapon(1-4): 1.Sword 2.Glock 3.Princess Wand 4.Ryan Chen");
                string weapon = Console.ReadLine();
                switch (weapon)
                {
                    case "1":
                        strength += 10;
                        break;
                    case "2":
                        strength += 15;
                        break;
                    case "3":
                        strength += 50;
                        break;
                    case "4":
                        strength += 100;
                        break;
                }
                Console.WriteLine("Here is the first demon you need to fight!!!");
                Console.ReadLine();
                if (strength > 5)
                {
                    Console.WriteLine("You defeated him!!!");
                    Console.ReadLine();
                    Console.WriteLine("Will you go left or right?");
                    string l_or_r = Console.ReadLine().ToUpper();
                    if (l_or_r == "LEFT")
                    {
                        Console.WriteLine("Thats the demon lord, he is too strong for you to kill him, you died to his aura!!!");
                        Console.WriteLine("          .                                                      .\r\n        .n                   .                 .                  n.\r\n  .   .dP                  dP                   9b                 9b.    .\r\n 4    qXb         .       dX                     Xb       .        dXp     t\r\ndX.    9Xb      .dXb    __                         __    dXb.     dXP     .Xb\r\n9XXb._       _.dXXXXb dXXXXbo.                 .odXXXXb dXXXXb._       _.dXXP\r\n 9XXXXXXXXXXXXXXXXXXXVXXXXXXXXOo.           .oOXXXXXXXXVXXXXXXXXXXXXXXXXXXXP\r\n  `9XXXXXXXXXXXXXXXXXXXXX'~   ~`OOO8b   d8OOO'~   ~`XXXXXXXXXXXXXXXXXXXXXP'\r\n    `9XXXXXXXXXXXP' `9XX'          `98v8P'          `XXP' `9XXXXXXXXXXXP'\r\n        ~~~~~~~       9X.          .db|db.          .XP       ~~~~~~~\r\n                        )b.  .dbo.dP'`v'`9b.odb.  .dX(\r\n                      ,dXXXXXXXXXXXb     dXXXXXXXXXXXb.\r\n                     dXXXXXXXXXXXP'   .   `9XXXXXXXXXXXb\r\n                    dXXXXXXXXXXXXb   d|b   dXXXXXXXXXXXXb\r\n                    9XXb'   `XXXXXb.dX|Xb.dXXXXX'   `dXXP\r\n                     `'      9XXXXXX(   )XXXXXXP      `'\r\n                              XXXX X.`v'.X XXXX\r\n                              XP^X'`b   d'`X^XX\r\n                              X. 9  `   '  P )X\r\n                              `b  `       '  d'\r\n                               `             '");
                        Console.ReadLine();
                    }
                    else if (l_or_r == "RIGHT")
                    {
                        Console.WriteLine("Here comes the second demon");
                        Console.ReadLine();
                        if (strength > 12)
                        {
                            Console.WriteLine("You defeated this one too, thats great!!!");
                            Console.ReadLine();
                            Console.WriteLine("But Here comes the third one!!!");
                            Console.ReadLine();
                            if (strength > 45)
                            {
                                Console.WriteLine("You defeated him, thats almost all of them!!!");
                                Console.ReadLine();
                                Console.WriteLine("Go left or forward?");
                                string l_or_f = Console.ReadLine().ToUpper();
                                if (l_or_f == "FORWARD")
                                {
                                    Console.WriteLine("Its the demon lord, with your pet next to him, now go and save him!!!");
                                    Console.ReadLine();
                                    if (strength > 50)
                                    {
                                        Console.WriteLine("You defeated him and saved your pet and millions of other pets, you turned his head into a trophy and will hang it on your wall forever, well done!!");
                                        kidnapped = false;
                                        Console.WriteLine("You became a hero, you and your pet are now celebrities and youve got given gifts by god, your pet now will live for a very long time!!");
                                        myPet.happiness = 100;
                                        myPet.tiredness = 0;
                                        myPet.loyalty = 100;
                                        myPet.fatness = 0;
                                        myPet.hunger = 100;
                                        myPet.age -= 100;
                                    }
                                    else if( strength == 50)
                                    {
                                        Random rand = new Random();
                                        int survive = rand.Next(2);
                                        if (survive == 0)
                                        {
                                            Console.WriteLine("You defeated him and saved your pet and millions of other pets, you turned his head into a trophy and will hang it on your wall forever, well done!!");
                                            kidnapped = false;
                                            Console.ReadLine();
                                        }
                                        else
                                        {
                                            Console.WriteLine("You got defeated, he oblitirated your body and made fun of you during every second of it, you lost your pride, honour and your pet :(");
                                            Console.WriteLine("          .                                                      .\r\n        .n                   .                 .                  n.\r\n  .   .dP                  dP                   9b                 9b.    .\r\n 4    qXb         .       dX                     Xb       .        dXp     t\r\ndX.    9Xb      .dXb    __                         __    dXb.     dXP     .Xb\r\n9XXb._       _.dXXXXb dXXXXbo.                 .odXXXXb dXXXXb._       _.dXXP\r\n 9XXXXXXXXXXXXXXXXXXXVXXXXXXXXOo.           .oOXXXXXXXXVXXXXXXXXXXXXXXXXXXXP\r\n  `9XXXXXXXXXXXXXXXXXXXXX'~   ~`OOO8b   d8OOO'~   ~`XXXXXXXXXXXXXXXXXXXXXP'\r\n    `9XXXXXXXXXXXP' `9XX'          `98v8P'          `XXP' `9XXXXXXXXXXXP'\r\n        ~~~~~~~       9X.          .db|db.          .XP       ~~~~~~~\r\n                        )b.  .dbo.dP'`v'`9b.odb.  .dX(\r\n                      ,dXXXXXXXXXXXb     dXXXXXXXXXXXb.\r\n                     dXXXXXXXXXXXP'   .   `9XXXXXXXXXXXb\r\n                    dXXXXXXXXXXXXb   d|b   dXXXXXXXXXXXXb\r\n                    9XXb'   `XXXXXb.dX|Xb.dXXXXX'   `dXXP\r\n                     `'      9XXXXXX(   )XXXXXXP      `'\r\n                              XXXX X.`v'.X XXXX\r\n                              XP^X'`b   d'`X^XX\r\n                              X. 9  `   '  P )X\r\n                              `b  `       '  d'\r\n                               `             '");
                                            Console.ReadLine();
                                        }
                                    }
                                }
                                else if (l_or_f == "LEFT")
                                {
                                    Console.WriteLine("You fell in a trap, you found yor pet but now both of you will get tortured together!!!");
                                    Console.WriteLine("          .                                                      .\r\n        .n                   .                 .                  n.\r\n  .   .dP                  dP                   9b                 9b.    .\r\n 4    qXb         .       dX                     Xb       .        dXp     t\r\ndX.    9Xb      .dXb    __                         __    dXb.     dXP     .Xb\r\n9XXb._       _.dXXXXb dXXXXbo.                 .odXXXXb dXXXXb._       _.dXXP\r\n 9XXXXXXXXXXXXXXXXXXXVXXXXXXXXOo.           .oOXXXXXXXXVXXXXXXXXXXXXXXXXXXXP\r\n  `9XXXXXXXXXXXXXXXXXXXXX'~   ~`OOO8b   d8OOO'~   ~`XXXXXXXXXXXXXXXXXXXXXP'\r\n    `9XXXXXXXXXXXP' `9XX'          `98v8P'          `XXP' `9XXXXXXXXXXXP'\r\n        ~~~~~~~       9X.          .db|db.          .XP       ~~~~~~~\r\n                        )b.  .dbo.dP'`v'`9b.odb.  .dX(\r\n                      ,dXXXXXXXXXXXb     dXXXXXXXXXXXb.\r\n                     dXXXXXXXXXXXP'   .   `9XXXXXXXXXXXb\r\n                    dXXXXXXXXXXXXb   d|b   dXXXXXXXXXXXXb\r\n                    9XXb'   `XXXXXb.dX|Xb.dXXXXX'   `dXXP\r\n                     `'      9XXXXXX(   )XXXXXXP      `'\r\n                              XXXX X.`v'.X XXXX\r\n                              XP^X'`b   d'`X^XX\r\n                              X. 9  `   '  P )X\r\n                              `b  `       '  d'\r\n                               `             '");
                                    Console.ReadLine();
                                }
                            }
                            else
                            {
                                Console.WriteLine("You died to him :(!");
                                Console.WriteLine("          .                                                      .\r\n        .n                   .                 .                  n.\r\n  .   .dP                  dP                   9b                 9b.    .\r\n 4    qXb         .       dX                     Xb       .        dXp     t\r\ndX.    9Xb      .dXb    __                         __    dXb.     dXP     .Xb\r\n9XXb._       _.dXXXXb dXXXXbo.                 .odXXXXb dXXXXb._       _.dXXP\r\n 9XXXXXXXXXXXXXXXXXXXVXXXXXXXXOo.           .oOXXXXXXXXVXXXXXXXXXXXXXXXXXXXP\r\n  `9XXXXXXXXXXXXXXXXXXXXX'~   ~`OOO8b   d8OOO'~   ~`XXXXXXXXXXXXXXXXXXXXXP'\r\n    `9XXXXXXXXXXXP' `9XX'          `98v8P'          `XXP' `9XXXXXXXXXXXP'\r\n        ~~~~~~~       9X.          .db|db.          .XP       ~~~~~~~\r\n                        )b.  .dbo.dP'`v'`9b.odb.  .dX(\r\n                      ,dXXXXXXXXXXXb     dXXXXXXXXXXXb.\r\n                     dXXXXXXXXXXXP'   .   `9XXXXXXXXXXXb\r\n                    dXXXXXXXXXXXXb   d|b   dXXXXXXXXXXXXb\r\n                    9XXb'   `XXXXXb.dX|Xb.dXXXXX'   `dXXP\r\n                     `'      9XXXXXX(   )XXXXXXP      `'\r\n                              XXXX X.`v'.X XXXX\r\n                              XP^X'`b   d'`X^XX\r\n                              X. 9  `   '  P )X\r\n                              `b  `       '  d'\r\n                               `             '");
                                Console.ReadLine();
                            }
                        }
                        else
                        {
                            Console.WriteLine("You died to him :(!");
                            Console.WriteLine("          .                                                      .\r\n        .n                   .                 .                  n.\r\n  .   .dP                  dP                   9b                 9b.    .\r\n 4    qXb         .       dX                     Xb       .        dXp     t\r\ndX.    9Xb      .dXb    __                         __    dXb.     dXP     .Xb\r\n9XXb._       _.dXXXXb dXXXXbo.                 .odXXXXb dXXXXb._       _.dXXP\r\n 9XXXXXXXXXXXXXXXXXXXVXXXXXXXXOo.           .oOXXXXXXXXVXXXXXXXXXXXXXXXXXXXP\r\n  `9XXXXXXXXXXXXXXXXXXXXX'~   ~`OOO8b   d8OOO'~   ~`XXXXXXXXXXXXXXXXXXXXXP'\r\n    `9XXXXXXXXXXXP' `9XX'          `98v8P'          `XXP' `9XXXXXXXXXXXP'\r\n        ~~~~~~~       9X.          .db|db.          .XP       ~~~~~~~\r\n                        )b.  .dbo.dP'`v'`9b.odb.  .dX(\r\n                      ,dXXXXXXXXXXXb     dXXXXXXXXXXXb.\r\n                     dXXXXXXXXXXXP'   .   `9XXXXXXXXXXXb\r\n                    dXXXXXXXXXXXXb   d|b   dXXXXXXXXXXXXb\r\n                    9XXb'   `XXXXXb.dX|Xb.dXXXXX'   `dXXP\r\n                     `'      9XXXXXX(   )XXXXXXP      `'\r\n                              XXXX X.`v'.X XXXX\r\n                              XP^X'`b   d'`X^XX\r\n                              X. 9  `   '  P )X\r\n                              `b  `       '  d'\r\n                               `             '");
                            Console.ReadLine();
                        }
                    }
                }
                else
                {
                    Console.WriteLine("You died to him :(!");
                    Console.WriteLine("          .                                                      .\r\n        .n                   .                 .                  n.\r\n  .   .dP                  dP                   9b                 9b.    .\r\n 4    qXb         .       dX                     Xb       .        dXp     t\r\ndX.    9Xb      .dXb    __                         __    dXb.     dXP     .Xb\r\n9XXb._       _.dXXXXb dXXXXbo.                 .odXXXXb dXXXXb._       _.dXXP\r\n 9XXXXXXXXXXXXXXXXXXXVXXXXXXXXOo.           .oOXXXXXXXXVXXXXXXXXXXXXXXXXXXXP\r\n  `9XXXXXXXXXXXXXXXXXXXXX'~   ~`OOO8b   d8OOO'~   ~`XXXXXXXXXXXXXXXXXXXXXP'\r\n    `9XXXXXXXXXXXP' `9XX'          `98v8P'          `XXP' `9XXXXXXXXXXXP'\r\n        ~~~~~~~       9X.          .db|db.          .XP       ~~~~~~~\r\n                        )b.  .dbo.dP'`v'`9b.odb.  .dX(\r\n                      ,dXXXXXXXXXXXb     dXXXXXXXXXXXb.\r\n                     dXXXXXXXXXXXP'   .   `9XXXXXXXXXXXb\r\n                    dXXXXXXXXXXXXb   d|b   dXXXXXXXXXXXXb\r\n                    9XXb'   `XXXXXb.dX|Xb.dXXXXX'   `dXXP\r\n                     `'      9XXXXXX(   )XXXXXXP      `'\r\n                              XXXX X.`v'.X XXXX\r\n                              XP^X'`b   d'`X^XX\r\n                              X. 9  `   '  P )X\r\n                              `b  `       '  d'\r\n                               `             '");
                    Console.ReadLine();
                }

            }
            else
            {
                Console.WriteLine("You didnt even try ._., your pet will get tortured by demons forever.");
                Console.WriteLine("          .                                                      .\r\n        .n                   .                 .                  n.\r\n  .   .dP                  dP                   9b                 9b.    .\r\n 4    qXb         .       dX                     Xb       .        dXp     t\r\ndX.    9Xb      .dXb    __                         __    dXb.     dXP     .Xb\r\n9XXb._       _.dXXXXb dXXXXbo.                 .odXXXXb dXXXXb._       _.dXXP\r\n 9XXXXXXXXXXXXXXXXXXXVXXXXXXXXOo.           .oOXXXXXXXXVXXXXXXXXXXXXXXXXXXXP\r\n  `9XXXXXXXXXXXXXXXXXXXXX'~   ~`OOO8b   d8OOO'~   ~`XXXXXXXXXXXXXXXXXXXXXP'\r\n    `9XXXXXXXXXXXP' `9XX'          `98v8P'          `XXP' `9XXXXXXXXXXXP'\r\n        ~~~~~~~       9X.          .db|db.          .XP       ~~~~~~~\r\n                        )b.  .dbo.dP'`v'`9b.odb.  .dX(\r\n                      ,dXXXXXXXXXXXb     dXXXXXXXXXXXb.\r\n                     dXXXXXXXXXXXP'   .   `9XXXXXXXXXXXb\r\n                    dXXXXXXXXXXXXb   d|b   dXXXXXXXXXXXXb\r\n                    9XXb'   `XXXXXb.dX|Xb.dXXXXX'   `dXXP\r\n                     `'      9XXXXXX(   )XXXXXXP      `'\r\n                              XXXX X.`v'.X XXXX\r\n                              XP^X'`b   d'`X^XX\r\n                              X. 9  `   '  P )X\r\n                              `b  `       '  d'\r\n                               `             '");
                Console.ReadLine();
            }
        }
        return kidnapped;
    }
}