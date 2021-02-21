using ClassMetotDemo;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine($"{musteri.Ad} {musteri.Soyad} added.");
        }
        public void Listele(Musteri musteri)
        {
            Console.WriteLine($"Id: {musteri.Id}");
            Console.WriteLine($"Ad: {musteri.Ad}");
            Console.WriteLine($"Soyad: {musteri.Soyad}");
            Console.WriteLine($"Yaş: {musteri.Yas}");
        }
        public void Sil(Musteri musteri)
        {
            Console.WriteLine($"{musteri.Ad} {musteri.Soyad} deleted.");
        }
    }
}