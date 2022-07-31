using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 200254;
            musteri1.Ad = "Muhammet";
            musteri1.Soyad = "Yılmaz";
            musteri1.Tc = 14587632483;


            Musteri musteri2 = new Musteri();
            musteri2.Id = 200255;
            musteri2.Ad = "Yunus";
            musteri2.Soyad = "tekin";
            musteri2.Tc = 25476345911;

            Musteri musteri3 = new Musteri();
            musteri3.Id = 200256;
            musteri3.Ad = "Furkan";
            musteri3.Soyad = "Gültekin";
            musteri3.Tc = 21744632451;

            Musteri musteri4 = new Musteri();
            musteri4.Id = 200257;
            musteri4.Ad = "Kağan";
            musteri4.Soyad = "Okut";
            musteri4.Tc = 24113365479;

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3, musteri4 };
            MusteriManager musterimanager = new MusteriManager();

            musterimanager.MusteriEkle(musteri1);
            musterimanager.MusteriSil(musteri2);
            musterimanager.Musterilisteleme(musteri3);
            musterimanager.Musterilisteleme(musteri4);

            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.Id + " - " + musteri.Ad+ " " + musteri.Soyad + " " + musteri.Tc);
            }
            

            



        }
    }
}
