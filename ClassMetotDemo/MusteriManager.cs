using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriEkle(Musteri musteri) 
        {
            Console.WriteLine(musteri.Id+" "+musteri.Ad+" "+musteri.Soyad+" "+musteri.Tc+" "+"Eklendi");
        }
        public void MusteriSil(Musteri musteri) 
        {
            Console.WriteLine(musteri.Id + " " + musteri.Ad + " " + musteri.Soyad + " " + musteri.Tc + " " + "Silindi");

        }
        public void Musterilisteleme(Musteri musteri) 
        {
            Console.WriteLine(musteri.Id + " " + musteri.Ad + " " + musteri.Soyad + " " + musteri.Tc+" "+"listelendi");
        }
    }
}
