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
