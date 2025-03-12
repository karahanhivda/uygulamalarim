using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneOtomasyon
{
    public class Kutuphane
    {
        private List<Kitap> kitaplar = new List<Kitap>();
        private List<Uye> uyeler = new List<Uye>();

        // Kütüphaneye kitap ekleme metodu
        public void KitapEkle(Kitap kitap)
        {
            kitaplar.Add(kitap);
            Console.WriteLine($"{kitap.Baslik} kitabı kütüphaneye eklendi.");
        }

        // Kütüphaneye üye ekleme metodu
        public void UyeEkle(Uye uye)
        {
            uyeler.Add(uye);
            Console.WriteLine($"{uye.Ad} {uye.Soyad} adlı kişi kütüphaneye üye olarak eklendi.");
        }

        // Kitap ödünç verme metodu
        public void KitapOduncVer(int uyeNo, string kitapBaslik)
        {
            Uye uye = uyeler.FirstOrDefault(u => u.UyeNo == uyeNo);
            Kitap kitap = kitaplar.FirstOrDefault(k => k.Baslik == kitapBaslik);

            if (uye != null && kitap != null)
            {
                uye.OduncAl(kitap);
            }
            else
            {
                Console.WriteLine("Üye veya kitap bulunamadı.");
            }
        }

        // Kitap iade alma metodu
        public void KitapIadeAl(int uyeNo, string kitapBaslik)
        {
            Uye uye = uyeler.FirstOrDefault(u => u.UyeNo == uyeNo);
            Kitap kitap = kitaplar.FirstOrDefault(k => k.Baslik == kitapBaslik);

            if (uye != null && kitap != null)
            {
                uye.IadeEt(kitap);
            }
            else
            {
                Console.WriteLine("Üye veya kitap bulunamadı.");
            }
        }

        // Kütüphane durumu görüntüleme metodu
        public void KutuphaneDurumuGoster()
        {
            Console.WriteLine("\nKütüphanedeki Kitaplar:");
            foreach (var kitap in kitaplar)
            {
                Console.WriteLine($" - {kitap.GetBilgi()} | Durum: {kitap.KitapDurumu}");
            }

            Console.WriteLine("\nKütüphanedeki Üyeler:");
            foreach (var uye in uyeler)
            {
                Console.WriteLine($" - {uye.Ad} {uye.Soyad} (Üye No: {uye.UyeNo})");
            }
        }
    }
}
