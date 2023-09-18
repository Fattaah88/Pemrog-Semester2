using System;

public class Mobill
{
    public virtual void Start()
    {
        Console.WriteLine("Kendaraan telah nyala!");
    }
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
        Mobill mobill = new Mobill();
        mobill.Start();

        Mobil mobil1 = new Mobil();
        mobil1.Start();

        Mobill mobil2 = new Mobil();
        mobil2.Start();
    }
}
