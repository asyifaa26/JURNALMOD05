using System;
using System.Globalization;
public class Penjumlahan
{
    public void JumlahTigaAngka<T>(T no1, T no2, T no3)
    {
        dynamic hasil1 = no1;
        dynamic hasil2 = no2;
        dynamic hasil3 = no3;
        dynamic hasil;

        hasil = hasil1 + hasil2 + hasil3;
        Console.WriteLine("Hasil Penjumlahan: " + hasil);
    }
}

class program
{
    static void Main(string[] args)
    {
        Penjumlahan jumlah = new Penjumlahan();
        jumlah.JumlahTigaAngka<long>(22, 30, 29);
        // NIM : 1302223029
    }
}
