using System;

namespace TravelApp
{
    class Tiket
    {
        public string Nama { get; set; }
        public string NIK { get; set; }
        public string NoTelepon { get; set; }
        public string NomorKartuVaksin { get; set; }
        public string Alamat { get; set; }
        public Tiket(string nama, string nik, string noTelepon, string nomorKartuVaksin, string alamat)
        {
            Nama = nama;
            NIK = nik;
            NoTelepon = noTelepon;
            NomorKartuVaksin = nomorKartuVaksin;
            Alamat = alamat;
        }

        public static Tiket PesanTiket()
        {
            Console.WriteLine("Silakan masukkan data Anda.");
            Console.Write("Masukkan Nama Anda: ");
            string nama = Console.ReadLine();

            Console.Write("Masukkan NIK Anda: ");
            string nik = Console.ReadLine();

            Console.Write("Masukkan Nomor Telepon Anda: ");
            string noTelepon = Console.ReadLine();

            Console.Write("Masukkan Nomor Kartu Vaksin Anda: ");
            string nomorKartuVaksin = Console.ReadLine();

            Console.Write("Masukkan Alamat Rumah: ");
            string alamat = Console.ReadLine();

            Tiket tiket = new Tiket(nama, nik, noTelepon, nomorKartuVaksin, alamat);

            Console.WriteLine("\nTerima kasih! Berikut adalah data pemesanan tiket Anda:");
            Console.WriteLine($"Nama: {tiket.Nama}\nNIK: {tiket.NIK}\nNomor Telepon: {tiket.NoTelepon}\nNomor Kartu Vaksin: {tiket.NomorKartuVaksin}\nAlamat Rumah: {tiket.Alamat}");

            return tiket;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Tiket tiket = Tiket.PesanTiket();
        }
    }
}