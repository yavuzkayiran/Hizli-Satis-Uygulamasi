using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace HizliSatis.Models
{
    class hizliSatisToUrunModel : IDisposable
    {
        private int id;
        private string urunAdi;
        private int urunId;
        private string barkodNo;
        private int toplamMiktar;
        private byte[] image;


        bool disposed = false;
        SafeHandle handle = new SafeFileHandle(IntPtr.Zero, true);
        public hizliSatisToUrunModel(int id, int urunId)
        {
            this.id = id;
            this.urunId = urunId;   
        }
        public hizliSatisToUrunModel(int id, int urunId,string urunAdi, string barkodNo, int toplamMiktar, byte[]image)
        {
            this.id = id;
            this.urunId = urunId;
            this.urunAdi = urunAdi;
            this.barkodNo = barkodNo;
            this.toplamMiktar = toplamMiktar;
            this.image = image;
        }

        public int Id { get => id; set => id = value; }
        public string UrunAdi { get => urunAdi; set => urunAdi = value; }
        public int UrunId { get => urunId; set => urunId = value; }
        public string BarkodNo { get => barkodNo; set => barkodNo = value; }
        public int ToplamMiktar { get => toplamMiktar; set => toplamMiktar = value; }
        public byte[] Image { get => image; set => image = value; }

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
