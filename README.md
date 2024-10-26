# 📚 Patika Kütüphane Project

Bu proje, **Patika.dev** platformundaki bir kütüphane uygulaması örneği olarak geliştirilmiştir. Kitap bilgilerini saklayarak her bir kitabın detaylarını konsola yazdırmayı sağlar. Proje, **Nesne Yönelimli Programlama (OOP)** prensiplerine uygun olarak yazılmıştır.

## 🛠️ Kullanılan Teknolojiler
- 💻 **C#** (.NET Framework)
- 🧑‍💻 **Nesne Yönelimli Programlama (OOP)**

## 📂 Proje Yapısı
Proje içerisinde **Kutuphane** adlı bir sınıf bulunmaktadır. Bu sınıf, kitap bilgilerini tutar ve `Yazdır()` metodu ile detayları ekrana yazdırır.

### ✨ Sınıf Özellikleri:
- 📖 **KitapAdı**: Kitabın adı  
- ✍️ **YazarAdı**: Yazarın adı  
- 🧑‍🎨 **YazarSoyadı**: Yazarın soyadı  
- 📄 **SayfaSayısı**: Kitabın sayfa sayısı (0'dan küçük olamaz)  
- 🏢 **YayınEvi**: Yayınevi  
- 🗓️ **YayınTarihi**: Yayın tarihi (otomatik olarak bugünün tarihi atanır)

## 🚀 Kurulum ve Çalıştırma

1. Proje dosyasını klonla veya indir:
   ```bash
   git clone https://github.com/kullanici-adi/Patika-Kutuphane-Project.git
 
## 🎯 Kod Kullanım Örneği 
```csharp
namespace Patika_Kütüphane_Project
{
    public class Kutuphane
    {
        // Propertiler 
        private int _SayfaSayısı;
        public string KitapAdı { get; set; }
        public string YazarAdı { get; set; }
        public string YazarSoyadı { get; set; }
        public string YayınEvi { get; set; }
        public DateTime YayınTarihi { get; set; }

        public int SayfaSayısı
        {
            get => _SayfaSayısı;
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Geçersiz Sayfa Sayısı");
                }
                else
                {
                    _SayfaSayısı = value;
                }
            }
        }

        // Default Constructor
        public Kutuphane()
        {
            YayınTarihi = DateTime.Now;
        }

        // Parametreli Constructor
        public Kutuphane(string kitapAdı, string yazarAdı, string yazarSoyadı, int sayfaSayısı, string yayınEvi)
        {
            // Constructor parametrelerini property'lere atıyoruz
            this.KitapAdı = kitapAdı;
            this.YazarAdı = yazarAdı;
            this.YazarSoyadı = yazarSoyadı;
            this.SayfaSayısı = sayfaSayısı;
            this.YayınEvi = yayınEvi;
            this.YayınTarihi = DateTime.Now.Date;
        }

        public void Yazdır()
        {
            string tarih = YayınTarihi.ToString("dd.MM.yyyy");
            Console.WriteLine($"Kitap Adı: {KitapAdı} | Yazar Adı: {YazarAdı} | Yazar Soyad

