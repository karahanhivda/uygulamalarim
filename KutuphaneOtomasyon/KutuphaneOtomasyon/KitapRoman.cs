using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneOtomasyon
{
    public class KitapRoman : Kitap
    {
        public string Tur {  get; set; }
        public KitapRoman(string isbn, string baslik, string yazar, int yayinYili, string tur) : base(isbn, baslik, yazar, yayinYili)
        {
            Tur = tur;
        }

        public override string GetBilgi()
        {
            return $"{base.GetBilgi()} | Tür: {Tur}";
        }
    }
}
