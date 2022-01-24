using ClassMetotDemo;
using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Ad = "Ramazan";
            musteri1.Soyad = "Küçükkoç";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Ad = "Ahmet";
            musteri2.Soyad = "Sahin";

            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.Ad = "Ali";
            musteri3.Soyad = "Kartal";


            MusteriManager musteriManager = new MusteriManager();

            Musteri[] musteriler = new Musteri[] {
            musteri1,musteri2,musteri3
            };     
            musteriManager.Ekleme(musteri3);
            Console.WriteLine("-------------------Ekleme Bitti----------------");    
            foreach (var item in musteriler)
            {
                musteriManager.Listeleme(item);
            }
            Console.WriteLine("-------------------Listeleme Bitti----------------");
            musteriManager.Silme(musteri2);
            Console.WriteLine("-------------------Silme Bitti----------------");
        }
    }
}
