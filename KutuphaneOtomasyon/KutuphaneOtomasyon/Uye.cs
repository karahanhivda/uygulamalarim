using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneOtomasyon
{
    public class Uye : IUye
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int UyeNo { get; set; }
        public List<Kitap> OduncKitaplar { get; set; }
        public string UyeAdi { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string UyeSoyadi { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Uye(string ad, string soyad, int uyeNo)
        {
            Ad = ad;
            Soyad = soyad;
            UyeNo = uyeNo;
            OduncKitaplar = new List<Kitap>();
        }

        public void OduncAl(Kitap kitap)
        {
            if (kitap.KitapDurumu == Durum.OduncAlabilir)
            {
                OduncKitaplar.Add(kitap);
                kitap.KitapDurumu = Durum.OduncVerildi;
                Console.WriteLine($"{kitap.Baslik} kitabı ödünç alındı.");
            }
            else
            {
                Console.WriteLine($"{kitap.Baslik} kitabı şu anda ödünç verilemez.");
            }
        }

        public void IadeEt(Kitap kitap)
        {
            if (OduncKitaplar.Contains(kitap))
            {
                OduncKitaplar.Remove(kitap);
                kitap.KitapDurumu = Durum.OduncAlabilir;
                Console.WriteLine($"{kitap.Baslik} kitabı iade edildi.");
            }
            else
            {
                Console.WriteLine($"{kitap.Baslik} kitabı sizin tarafınızdan ödünç alınmamış.");
            }
        }

        public void OduncKitaplariListele()
        {
            Console.WriteLine($"\n{Ad} {Soyad} isimli üyenin ödünç aldığı kitaplar:");
            if (OduncKitaplar.Count == 0)
            {
                Console.WriteLine(" - Ödünç alınan kitap yok.");
            }
            else
            {
                foreach (var kitap in OduncKitaplar)
                {
                    Console.WriteLine($" - {kitap.GetBilgi()}");
                }
            }
        }

        public void IadeEt()
        {
            throw new NotImplementedException();
        }
    }
}
