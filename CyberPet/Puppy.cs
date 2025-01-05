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