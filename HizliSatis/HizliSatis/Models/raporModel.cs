using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HizliSatis.Models
{
    class raporModel
    {
        string tarih;
        float indirimli;
        float indirimsiz;
        int toplamUrunMiktari;
        string urunAdi;
        string barkodNo;

        public raporModel(int toplamUrunMiktari, string urunAdi,string barkodNo)
        {
            this.toplamUrunMiktari = toplamUrunMiktari;
            this.urunAdi = urunAdi;
            this.BarkodNo = barkodNo;
        }

        public raporModel(string tarih, float indirimli, float indirimsiz)
        {
            this.tarih = tarih;
            this.indirimli = indirimli;
            this.indirimsiz = indirimsiz;
        }

        public string Tarih { get => tarih; set => tarih = value; }
        public float Indirimli { get => indirimli; set => indirimli = value; }
        public float Indirimsiz { get => indirimsiz; set => indirimsiz = value; }
        public int ToplamUrunMiktari { get => toplamUrunMiktari; set => toplamUrunMiktari = value; }
        public string UrunAdi { get => urunAdi; set => urunAdi = value; }
        public string BarkodNo { get => barkodNo; set => barkodNo = value; }
    }
}
