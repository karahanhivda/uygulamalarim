using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneOtomasyon
{
    public class KitapTarih : Kitap
    {
        public string Donem { get; set; }
        public KitapTarih(string isbn, string baslik, string yazar, int yayinYili, string donem) : base(isbn, baslik, yazar, yayinYili)
        {
            Donem = donem;
        }

        public override string GetBilgi()
        {
            return $"{base.GetBilgi()} | Dönem: {Donem}";
        }
    }
}
