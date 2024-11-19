class RedHeadDuck : Duck, IFlyable, IQuackable, ISwimmable
{
    public override void Display()
    {
        Console.WriteLine("Displaying a RedHead Duck");
    }

    public void Fly()
    {
        Console.WriteLine("RedHead Duck is flying");
    }

    public void Quack()
    {
        Console.WriteLine("Quack, quack!!");
    }
    public void Swim()
    {
        Console.WriteLine("RedHead Duck is swimming");
    }
}