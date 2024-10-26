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
            KitapAdı = "Aylin";
            YazarAdı = "Ayşe";
            YazarSoyadı = "Kulin";
            SayfaSayısı = 398;
            YayınEvi = "Ramiz Kitapevi";
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
            Console.WriteLine($"Kitap Adı: {KitapAdı} | Yazar Adı: {YazarAdı} | Yazar Soyadı: {YazarSoyadı} | " +
                              $"Sayfa Sayısı: {SayfaSayısı} | Yayın Evi: {YayınEvi} | Kayıt Tarihi: {tarih}");
        }
    }
    //Class: Benzer özelliklere ve davranışlara sahip nesneleri tanımlayan bir şablondur.

    //Property: Sınıf içinde tanımlanan, nesne verilerine erişim sağlayan değişkenlerdir.

    //New: Yeni bir nesne oluşturmak için kullanılan anahtar kelimedir.

    //Constructor: Bir sınıfın nesnesi oluşturulduğunda otomatik olarak çağrılan ve başlangıç değerlerini atayan özel bir metottur.
}
