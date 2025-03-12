using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneOtomasyon
{
    public interface IUye
    {
        public string UyeAdi { get; set; }
        public string UyeSoyadi { get; set; }
        public int UyeNo { get; set; }
        List<Kitap> OduncKitaplar { get; set; }

        void OduncAl(Kitap kitap);
        void IadeEt();
        void OduncKitaplariListele();
    }
}
