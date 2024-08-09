using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class BaseKisi
    {
        // Base Sınıf için Özellikler
        public string Ad { get; set; }
        public string Soyad { get; set; }

        // Base Sınıf için Metot
        public void AdSoyadYazdir()
        {
            Console.WriteLine($"Ad: {Ad}, Soyad: {Soyad}");
        }
    }

    public class Ogrenci : BaseKisi
    {
        // Ogrenci Sınıfı için İlave Özellik
        public int OgrenciNumarasi { get; set; }

        // Ogrenci Sınıfı için İlave Metot
        public void OgrenciBilgileriniYazdir()
        {
            Console.WriteLine($"Öğrenci Numarası: {OgrenciNumarasi}");
            AdSoyadYazdir();  // BaseKisi sınıfından gelen metodu çağırıyoruz
        }
    }

    public class Ogretmen : BaseKisi
    {
        // Ogretmen Sınıfı için İlave Özellik
        public decimal Maas { get; set; }

        // Ogretmen Sınıfı için İlave Metot
        public void OgretmenBilgileriniYazdir()
        {
            Console.WriteLine($"Maaş: {Maas} TL");
            AdSoyadYazdir();  // BaseKisi sınıfından gelen metodu çağırıyoruz
        }
    }
}
