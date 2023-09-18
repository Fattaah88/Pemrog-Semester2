using System;

public abstract class Mobill
{
    public abstract void Start();
}

public class Mobil : Mobill
{
    public override void Start()
    {
        Console.WriteLine("Mobil telah nyala!");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Mobil mobil1 = new Mobil();
        mobil1.Start();
    }
}
