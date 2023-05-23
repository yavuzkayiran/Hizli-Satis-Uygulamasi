using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32.SafeHandles;
using System.Runtime.InteropServices;
namespace HizliSatis.Models
{

    class stokModel : IDisposable
    {
        private int     id;
        private string  barkodNo;
        private string  urunAdi;
        private string  ticariUnvan;
        private string  sonKulTrh;
        private string  birimAdi;
        private int miktar;
        private int birimAdet;
        private int toplamMiktar;
        private float   kdv;
        private float   birimFiyat;
        private float birimAdetFiyat;
        private float satisFiyati;
        private byte[] image;

        bool disposed = false;
        SafeHandle handle = new SafeFileHandle(IntPtr.Zero, true);
        public stokModel(
            int id, 
            string barkodNo,
            string urunAdi,
            string ticariUnvan,
            string sonKulTrh,
            string birimAdi, 
            int miktar,
            int birimAdet,///
            int toplamMiktar,//
             float kdv,
            float birimFiyat,
            float birimAdetFiyat,//
            float satisFiyati,//
            byte[] image
            )
        {
              
           
            this.id = id;
            this.barkodNo = barkodNo;
            this.urunAdi = urunAdi;
            this.ticariUnvan = ticariUnvan;
            this.sonKulTrh = sonKulTrh;
            this.birimAdi = birimAdi;

            this.miktar = miktar;
            this.birimAdet = birimAdet;
            this.toplamMiktar = toplamMiktar;
            this.kdv = kdv;
            this.birimFiyat = birimFiyat;
            this.birimAdetFiyat = birimAdetFiyat;
            this.satisFiyati = satisFiyati;
            this.image = image;
        }

        public int getId()
        {
            return this.id;
        }

        public void setId(int id)
        {
            this.id = id;
        }

        public string getBarkodNo()
        {
            return this.barkodNo;
        }
        public void setBarkodNo(string barkodNo)
        {
            this.barkodNo = barkodNo;
        }

        public string getUrunAdi()
        {
            return this.urunAdi;
        }
        public void setUrunAdi(string urunAdi)
        {
            this.urunAdi = urunAdi;
        }

        public string getSonKulTrh()
        {
            return this.sonKulTrh;
        }
        public void setSonKulTrh(string sonKulTrh)
        {
            this.sonKulTrh = sonKulTrh;
        }
        public byte[] getImage()
        {
            return this.image;
        }
        public void setImage(byte[] image)
        {
            this.image = image;
        }

      //  tedarikciId birimId miktar kdv birimFiyat
        public string getTicariUnvan()
        {
            return this.ticariUnvan;
        }
        public void setTicariUnvan(string ticariUnvan)
        {
            this.ticariUnvan = ticariUnvan;
        }

        public string getBirimAdi()
        {
            return this.birimAdi;
        }
        public void setBirimAdi(string birimAdi)
        {
            this.birimAdi = birimAdi;
        }

        public int getMiktar()
        {
            return this.miktar;
        }
        public void setMiktar(int miktar)
        {
            this.miktar = miktar;
        }

        public int getBirimAdet()
        {
            return this.birimAdet;
        }
        public void setBirimAdet(int birimAdet)
        {
            this.birimAdet = birimAdet;
        }

        public int getToplamMiktar()
        {
            return this.toplamMiktar;
        }
        public void setToplamMiktar(int toplamMiktar)
        {
            this.toplamMiktar = toplamMiktar;
        }

        public float getKdv()
        {
            return this.kdv;
        }
        public void setKdv(float kdv)
        {
            this.kdv = kdv;
        }

        public float getBirimFiyat()
        {
            return this.birimFiyat;
        }
        public void setBirimFiyat(float birimFiyat)
        {
            this.birimFiyat = birimFiyat;
        }

        public float getBirimAdetFiyat()
        {
            return this.birimAdetFiyat;
        }
        public void setBirimAdetFiyat(float birimAdetFiyat)
        {
            this.birimAdetFiyat = birimAdetFiyat;
        }

        public float getSatisFiyati()
        {
            return this.satisFiyati;
        }
        public void setSatisFiyati(float satisFiyati)
        {
            this.satisFiyati = satisFiyati;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
                return;

            if (disposing)
            {
                handle.Dispose();
                // Free any other managed objects here.
                //
            }

            // Free any unmanaged objects here.
            //
            disposed = true;
        }

    }
}
