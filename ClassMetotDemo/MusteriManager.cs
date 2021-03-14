using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        Musteri musteri = new Musteri();
        

        public void MusteriEkleme(Musteri musteri)
        {
            Console.WriteLine("Müşteri Eklendi! Müşteri Bilgileri: " 
                + musteri.Id + " "
                + musteri.MusteriAdi + " "
                + musteri.MusteriSoyadi + " "
                + musteri.MusteriYasi + " "
                + musteri.Cinsiyet);
        } 

        public void MusteriListeleme(Musteri[] musteriler)
        {
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine("Müşteriler Listelendi: Müşteri"+musteri.Id + " " + musteri.MusteriAdi + " " + musteri.MusteriSoyadi );
            }
        }

        public void MusteriSilme(Musteri musteri)
        {
            Console.WriteLine(musteri.Id + " " + musteri.MusteriAdi + " " + musteri.MusteriSoyadi + " müşterisi silindi.");
        }

    }
}
