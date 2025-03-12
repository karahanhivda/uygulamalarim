using System;
using KutuphaneOtomasyon;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Kütüphane nesnesi oluşturuluyor
            Kutuphane kutuphane = new Kutuphane();

            // Üyeler oluşturuluyor
            Uye uye1 = new Uye("Ahmet", "Yılmaz", 1);
            Uye uye2 = new Uye("Mehmet", "Kara", 2);

            // Kütüphaneye üyeler ekleniyor
            kutuphane.UyeEkle(uye1);
            kutuphane.UyeEkle(uye2);

            // Kitaplar oluşturuluyor
            Kitap kitap1 = new KitapBilim("123456", "C# Programming", "John Doe", 2020, "Bilgisayar Bilimleri");
            Kitap kitap2 = new KitapRoman("654321", "OOP in C#", "Jane Doe", 2021, "Bilim Kurgu");
            Kitap kitap3 = new KitapTarih("789456", "Tarihi Anlatan Roman", "Ali Veli", 2018, "Osmanlı Dönemi");

            // Kitaplar kütüphaneye ekleniyor
            kutuphane.KitapEkle(kitap1);
            kutuphane.KitapEkle(kitap2);
            kutuphane.KitapEkle(kitap3);

            // Kütüphanedeki durum gösteriliyor
            kutuphane.KutuphaneDurumuGoster();

            // Kitap ödünç verme
            kutuphane.KitapOduncVer(1, "C# Programming");

            // Kütüphanedeki durum tekrar gösteriliyor
            kutuphane.KutuphaneDurumuGoster();

            // Üyenin ödünç aldığı kitapları listelemesi
            uye1.OduncKitaplariListele();

            // Kitap iade alma
            kutuphane.KitapIadeAl(1, "C# Programming");

            // Kütüphanedeki durum tekrar gösteriliyor
            kutuphane.KutuphaneDurumuGoster();

            // Üyenin ödünç aldığı kitapları tekrar listelemesi
            uye1.OduncKitaplariListele();

            Console.ReadLine(); // Programın kapanmaması için
        }
    }
}
