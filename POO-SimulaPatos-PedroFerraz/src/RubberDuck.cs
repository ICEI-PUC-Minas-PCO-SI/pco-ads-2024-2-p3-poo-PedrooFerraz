class RubberDuck : Duck, IQuackable, ISwimmable
{
    public override void Display()
    {
        Console.WriteLine("Displaying a Rubber Duck");
    }

    public void Quack()
    {
        Console.WriteLine("Quack, quack!!");
    }

    public void Swim()
    {
        Console.WriteLine("Rubber Duck is swimming");
    }
}