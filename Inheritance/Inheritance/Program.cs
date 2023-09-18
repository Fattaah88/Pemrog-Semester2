using System;

public class Mobill
{
    public string Merk { get; set; }
    public string Model { get; set; }
    public int TahunKeluar { get; set; }
}

public class Mobil : Mobill
{
    public void Start()
    {
        Console.WriteLine("Mobil telah nyala!");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Mobil mobil = new Mobil();
        mobil.Merk = "GTR";
        mobil.Model = "Super Car";
        mobil.TahunKeluar = 2018;

        Console.WriteLine("Merk : " + mobil.Merk);
        Console.WriteLine("Model : " + mobil.Model);
        Console.WriteLine("Tahun : " + mobil.TahunKeluar);

        mobil.Start();
    }
}