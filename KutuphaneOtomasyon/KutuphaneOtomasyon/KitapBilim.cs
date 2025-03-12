using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneOtomasyon
{
    public class KitapBilim : Kitap
    {
        public KitapBilim(string isbn, string baslik, string yazar, int yayinYili, string bilimDali) : base(isbn, baslik, yazar, yayinYili)
        {
            BilimDali = bilimDali;
        }

        public string BilimDali { get; set; }
        public override string GetBilgi()
        {
            return $"{base.GetBilgi()} | Bilim Dalı: {BilimDali}";
        }

    }
}
