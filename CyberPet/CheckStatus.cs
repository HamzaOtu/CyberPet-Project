class CheckStatus
{
    public void Check(Pet myPet)
    {
        if (myPet.tiredness > 100)
        {
            myPet.tiredness = 100;
        }
        else if (myPet.tiredness < 0)
        {
            myPet.tiredness = 0;
        }
        if (myPet.hunger > 100)
        {
            myPet.hunger = 100;
        }
        else if (myPet.hunger < 0)
        {
            myPet.hunger = 0;
        }
        if (myPet.loyalty > 100)
        {
            myPet.loyalty = 100;
        }
        else if (myPet.loyalty < 0)
        {
            myPet.loyalty = 0;
        }
        if (myPet.fatness > 100)
        {
            myPet.fatness = 100;
        }
        else if (myPet.fatness < 0)
        {
            myPet.fatness = 0;
        }
        if (myPet.happiness > 100)
        {
            myPet.happiness = 100;
        }
        else if (myPet.happiness < 0)
        {
            myPet.happiness = 0;
        }
        if (myPet.fatness > 80)
        {
            myPet.obesity = true;
            Console.WriteLine("Your pet is obese make them work out!");
            Console.ReadLine();
        }
        if (myPet.rounds == 5)
        {
            myPet.rounds = 0;
            myPet.age += 1;
        }
        if (myPet.age > 30)
        {
            Random random = new Random();
            int survive = random.Next(100);
            if (survive > 10)
            {
                myPet.alive = false;
                Console.WriteLine("Your pet died of old age :(");
                Console.ReadLine();
            }
        }
        if (myPet.age > 25)
        {
            Random random = new Random();
            int survive = random.Next(100);
            if (survive > 30)
            {
                myPet.alive = false;
                Console.WriteLine("Your pet died of old age :(");
                Console.ReadLine();
            }
        }
        if (myPet.age > 20)
        {
            Random random = new Random();
            int survive = random.Next(100);
            if (survive > 65)
            {
                myPet.alive = false;
                Console.WriteLine("Your pet died of old age :(");
                Console.ReadLine();
            }
        }
        if (myPet.age > 16)
        {
            Random random = new Random();
            int survive = random.Next(100);
            if (survive > 90)
            {
                myPet.alive = false;
                Console.WriteLine("Your pet died of old age :(");
                Console.ReadLine();
            }
        }
        if (myPet.age > 12)
        {
            Random random = new Random();
            int survive = random.Next(100);
            if (survive == 100)
            {
                myPet.alive = false;
                Console.WriteLine("Your pet died of old age :(");
                Console.ReadLine();
            }
        }
        if (myPet.obesity == true)
        {
            myPet.obesityRounds += 1;
        }
        else
        {
            myPet.obesityRounds = 0;
        }
        if (myPet.obesityRounds == 5)
        {
            myPet.alive = false;
            Console.WriteLine("Your pet died of obesity, you didnt look after him :(");
            Console.ReadLine();
        }
        if (myPet.hunger < 20)
        {
            myPet.hungerRounds += 1;
        }
        else
        {
            myPet.hungerRounds = 0;
        }
        if (myPet.hungerRounds == 5)
        {
            myPet.alive = false;
            Console.WriteLine("Your pet starved to death, you didnt look after him :(");
            Console.ReadLine();
        }
        if (myPet.tiredness > 80)
        {
            myPet.tirednessRounds += 1;
        }
        else
        {
            myPet.tirednessRounds = 0;
        }
        if (myPet.tirednessRounds == 5)
        {
            myPet.alive = false;
            Console.WriteLine("Your pet overworked, you didnt look after him :(");
            Console.ReadLine();
        }

        if(myPet.age == -300)
        {
            Console.WriteLine("Your pet transformed into a God and flew away to heavens, turning you into one of his forever servants, you reached Ending : Into The Heavens");
            Console.WriteLine("                        _.- -.\r\n                      _/\"\"\"',. ` ,ooooo.___\r\n                    .'`'\\    `. \\\"''''`\"\"\"PP8ooo._\r\n                   (  .-)`.    `.\\            '`\"P8oo_\r\n                ,o8P\\ `-.  `.     `.               ``Y8o.\r\n             ,dPP'   `.  `. '-.  ,.`-._                `Y8o_\r\n           d8P'        \\. `.  (`-. `-._/     -.\\/.-       `Yb.\r\n         d8P            `( ') `',`-._.`                     `Y8.\r\n       ,8P      /'.      )  (   ).-'   \\            .'\\      `Yb_\r\n      dP'       )  '.    `-._)_/    \\             .'  (        `8L\r\n    ,8P         \\    '.    \\  `.  \\    `.       .'    /          Yb\r\n   ,8P           '.*   '.       .-=^=-.       .'   *.'            Yb\r\n  ,8P   -.\\/.-    )  `.  \\     ;:)(\\)(/`     /  .'  (              Yb\r\n  8P            .'     :  '.  (`(/ (/ /(.  .'  :     `.     -.\\/.-  8b\r\n d8'          .'  *     \\   \\//,)<*)(*>(.\\/   /    *   `.           `8.\r\n,8P          '.             (/():  ^  :(\\(              .'           Yb\r\nd8             '-._   \"-    )( :)._=_.(: ))   -\"    _.-'             `8.\r\n8P               \\         ( ))(()   ( )(( )         /                8b\r\n8b               '.  *   .'  .           .  `.   *  .'                8b\r\n8b    -.\\/.-       ''--.'  .''  .  :  .  ''.  '.--''                  8b\r\nYb                    `  -`_* `._.` `._.` *_`-  `                    ,8P\r\nY8.                   \\  '. '- '       ' -' .'  /                    d8'\r\n 8b                            '   ^ .-'                             8P\r\n Y8.                    ^ -._  |`-.''.-`\\  _.- ^      ~       -._   d8'\r\n  Yb    ~   ^ _ .-  '         /     . `-.\\     ~    ,   ^- _  _    ,8P\r\n   8b        ~           ~   '.,-._  `. .':  ` -._          ~      8P\r\n    Yb              ,   .-   |     '`--.__]        ~         .   ,8F\r\n     Yb         ~            |     '     /                ~     ,8P\r\n      Y8L           . - ~    '     |    '    ~      .  `-._     o8'\r\n        Yb.     .              ,     ~             ~          d8P\r\n         `Yb.        ~                    ~   ` -._         d8P\r\n           `Y8L           ~       ~           ,  .       _o8P\r\n              YYb._        _.-'                       _o8P'\r\n                `\"Ybo._           ,     ~         _,o8P'\r\n                    `\"P8oo._                __ooo8P\"'\r\n                        `'\"YPP8oooooooooooLGB\"''\r\n                              `''''''''''");
            myPet.alive = false;
        }
        
    }

    public void callMethods(Pet myPet)
    {
        Random rand = new Random();
        int chances = rand.Next(100);
        if (myPet.age <= -300)
        {
            chances = 0;
        }
        RandomEvents events = new RandomEvents();
        bool babycoming = events.BabyComing(chances);

        if (babycoming)
        {
            Console.WriteLine($"{((dynamic)myPet).Name} has had a baby!!!!");
            myPet.hunger -= 30;
            myPet.fatness += 60;
            myPet.tiredness += 60;
            myPet.happiness -= 50;
            Check(myPet);
        }

        bool ranaway = events.RanAway(myPet, chances);

        if (ranaway)
        {
            Console.WriteLine($"{((dynamic)myPet).Name} has ran away!!!!");
            myPet.alive = false;
        }

        bool carcrash = events.CarCrash(myPet, chances);

        if (carcrash)
        {
            Console.WriteLine($"A car crashed into {((dynamic)myPet).Name}!!!!!");
            Check(myPet);
            myPet.alive = false;
        }

        bool isill = events.IsIll(myPet, chances);

        if (isill)
        {
            Console.WriteLine($"{((dynamic)myPet).Name} got ill and died!!!");
            Check(myPet);
            myPet.alive = false;
        }

        bool tacos = events.SoftTacos(myPet, chances);

        if (tacos)
        {
            Console.WriteLine("The tacos were so yummy and magical. Pet has max stats and even de-aged once, enjoy!!!!!!!");
            myPet.happiness = 100;
            myPet.tiredness = 0;
            myPet.loyalty = 100;
            myPet.fatness = 0;
            myPet.hunger = 100;
            myPet.age -= 1;
            Check(myPet);
        }
        
        bool kidnapped = events.Kidnapped(myPet, chances);

        if (kidnapped)
        {
            Console.WriteLine("You never came back from hell, what a shame.");
            myPet.alive = false;
        }
    }
}