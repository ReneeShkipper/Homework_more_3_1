abstract class Planet
{
    public abstract void Name();
    public abstract void Movement();
    public abstract void Life();
}

class Earth : Planet
{
    public override void Name()
    {
        Console.WriteLine("It's the Earth");
    }
    public override void Movement()
    {
        Console.WriteLine("This planet flies around the Sun");
    }
    public override void Life()
    {
        Console.WriteLine("There is life on this planet");
    }
}
class Moon : Planet 
{
    public override void Name()
    {
        Console.WriteLine("It's the Moon");
    }
    public override void Movement()
    {
        Console.WriteLine("This satellite flies around planet Earth");
    }
    public override void Life()
    {
        Console.WriteLine("There is no life on this satellite");
    }
}

class Program
{
    static void Main()
    {
        Planet[] planets = new Planet[2];
        Earth earth1 = new Earth();
        Moon moon1 = new Moon();
        planets[0] = earth1;
        planets[1] = moon1;
        foreach (var item in planets)
        {
            item.Name();
            item.Movement();
            item.Life();
        }
    }
}