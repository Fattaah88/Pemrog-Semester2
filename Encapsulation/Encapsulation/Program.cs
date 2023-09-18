using System;

class Mahasiswa
{
    public string Nama { get; set; }

    public int NIM { get; set; }

    public string Alamat { get; set; }

    public Mahasiswa(string nama, int nim, string alamat)
    {
        Nama = nama;
        NIM = nim;
        Alamat = alamat;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Nama: {Nama}");
        Console.WriteLine($"NIM:{NIM}");
        Console.WriteLine($"Alamat: {Alamat}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        var mahasiswa = new Mahasiswa("Fattaah Herdansyah Alhamiid", 4814, "Karanganyar");

        mahasiswa.DisplayInfo();
    }
}