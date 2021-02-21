
using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.MusteriId = 001;
            musteri1.Ad = "Fatih";
            musteri1.Soyad = "Gedik";
            musteri1.Yas = 26;

            MusteriManager musmanager = new MusteriManager();

            musmanager.Ekle(musteri1);
            musmanager.Listele(musteri1);
            musmanager.Sil(musteri1);

        }
    }
}
