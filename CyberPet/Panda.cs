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