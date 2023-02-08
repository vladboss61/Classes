namespace Online4.Classes;


enum LogType
{
    Error,
    Info,
    Warning
}

enum Day
{
    Monday,
    Thusday,
    Wendnesday
}

enum Light
{
    On,
    Off
}


public static class Functions
{
    static Functions()
    {
        Console.WriteLine("Static is executed.");
    }

    public static double Calcumation(int n)
    {
        return Math.Sqrt(n) * 25;
    }
}

public class Dog
{
    public string Name {
        get
        {
            return _name;
        }
        set
        {
            if(string.IsNullOrEmpty(value))
            {
                _name = "Dog Dog";
            }

            _name = value;
        }
    }

    public static Collar Collar { get; set; } = new Collar();

    private string _name;
    private bool _alive;
    protected int _age;
    protected int _countBarks;

    private static int AllDogsBarks;

    static Dog()
    {
        Console.WriteLine("Static cctor");
    }

    public Dog(string name)
    {
        Collar = new Collar();
        _name = name;
        _alive = true;
        _age = 0;
        _countBarks = 0;

        Console.WriteLine("Hello Dog: " + name);
    }

    public Dog()
    {
        Console.WriteLine("I'm empty");
    }

    public void Bark()
    {
        _countBarks++;
        AllDogsBarks++;
        Console.WriteLine(_name +": Gav Gav");
    }
    
    public int GetCountBarks()
    {
        return _countBarks;
    }

    public void PrintName()
    {
        Console.WriteLine(_name);
    }

    public string GetName()
    {
        return _name;
    }

    public static void PrintAllBarks()
    {
        Console.WriteLine("All Dogs Count Barks: " + AllDogsBarks);
    }
}

public class Collar 
{
    public string Color { get; set; }
    
    public string Name { get; set; }
}



public class SpecificDog : Dog
{
    public void FlyToMood()
    {
        Console.WriteLine("Ohh im in space.");
    }

    public override string ToString()
    {
        return base.ToString();
    }
}


public class Program
{
    public static void Main(string[] args)
    {
        var logger = new Logger();
        logger.LogWarning("log error");
        logger.LogWarning("log error");
        logger.LogWarning("log error");

        File.WriteAllText("log.error.txt", logger.MessageWarning);

        using (var streamWriter = new StreamWriter("log1.txt"))
        {
            for (int i = 0; i < 10; i++)
            {
                streamWriter.WriteLine("From Code: " + i.ToString());
            }
        }

        File.WriteAllText("log.txt", "Hello From memory");

        Day day = Day.Wendnesday;
        int number = (int)day;

        Console.WriteLine("Now: " + DateTime.Now);

        Functions.Calcumation(100);
        Dog den = new Dog("Den");
        den.Name = "asdsad";
        var name = den.Name;

        den.Bark();
        den.Bark();
        den.Bark();
        den.Bark();
        den.Bark();

        den.GetName();
        Console.WriteLine(den.GetCountBarks());


        Dog john = new Dog("John");

        john.Bark();
        john.Bark();

        Console.WriteLine(john.GetCountBarks());
        Dog.PrintAllBarks();

        var specificDog = new SpecificDog();

        Dog empty = new Dog();
    }
}