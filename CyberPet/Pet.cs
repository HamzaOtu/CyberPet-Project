class Pet
{
    public int age { get; set; }
    public int hunger { get; set; }
    public int happiness { get; set; }
    public int loyalty { get; set; }
    public bool alive { get; set; }
    public int fatness { get; set; }
    public bool obesity { get; set; }
    public int tiredness { get; set; }
    public int rounds { get; set; }
    public int obesityRounds { get; set; }
    public int hungerRounds { get; set; }
    public int tirednessRounds { get; set; }

    public Pet()
    {
        initializePet();
    }

    private void initializePet()
    {
        this.age = 0;
        this.hunger = 50;
        this.happiness = 20;
        this.alive = true;
        this.loyalty = 15;
        this.fatness = 20;
        this.obesity = false;
        this.tiredness = 0;
    }
}
