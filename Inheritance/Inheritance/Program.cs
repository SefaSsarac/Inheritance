using Inheritance;

class Program
{
    static void Main(string[] args)
    {
        // Öğrenci Nesnesi Oluşturma ve Değer Atama
        Ogrenci ogrenci1 = new Ogrenci();
        ogrenci1.Ad = "Ali";
        ogrenci1.Soyad = "Yılmaz";
        ogrenci1.OgrenciNumarasi = 12345;

        // Öğrenci Bilgilerini Yazdırma
        Console.WriteLine("Öğrenci Bilgileri:");
        ogrenci1.OgrenciBilgileriniYazdir();
        Console.WriteLine();  // Satır arasında boşluk bırakmak için

        // Öğretmen Nesnesi Oluşturma ve Değer Atama
        Ogretmen ogretmen1 = new Ogretmen();
        ogretmen1.Ad = "Ayşe";
        ogretmen1.Soyad = "Demir";
        ogretmen1.Maas = 7500.50m;

        // Öğretmen Bilgilerini Yazdırma
        Console.WriteLine("Öğretmen Bilgileri:");
        ogretmen1.OgretmenBilgileriniYazdir();
    }
}