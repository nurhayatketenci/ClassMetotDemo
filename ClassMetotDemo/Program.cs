using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MusteriManager musteriManager = new MusteriManager();


            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Name = "Nur";
            musteri1.Surname = "Hayat";
            musteri1.Tc = 54646878984;
            MusteriManager manager = new MusteriManager();
            manager.Add(musteri1);
            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Name = "İrem";
            musteri2.Surname = "Zehra";
            musteri2.Tc = 60844779631;
            manager.Add(musteri2);
            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.Name = "Ömer";
            musteri3.Surname = "Oğuz";
            musteri3.Tc = 60848779631;
            manager.Add(musteri3);
            manager.Update(musteri1);
            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };
            musteriManager.List(musteriler);
        }
    }
}
