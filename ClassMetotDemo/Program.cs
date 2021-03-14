using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.MusteriAdi = "Ayşe";
            musteri1.MusteriSoyadi = "Kara";
            musteri1.MusteriYasi = 38;
            musteri1.Cinsiyet = "Kadın";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.MusteriAdi = "Fatih";
            musteri2.MusteriSoyadi = "Çevik";
            musteri2.MusteriYasi = 56;
            musteri2.Cinsiyet = "Erkek";

            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.MusteriAdi = "Bahar";
            musteri3.MusteriSoyadi = "Yıldız";
            musteri3.MusteriYasi = 26;
            musteri3.Cinsiyet = "Kadın";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.MusteriEkleme(musteri1);
            musteriManager.MusteriEkleme(musteri2);
            musteriManager.MusteriEkleme(musteri3);
            musteriManager.MusteriListeleme(musteriler);
            musteriManager.MusteriSilme(musteri3);

            Console.ReadKey();

        }
    }
}
