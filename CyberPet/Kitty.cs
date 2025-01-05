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