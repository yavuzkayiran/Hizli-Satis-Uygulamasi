using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32.SafeHandles;
using System.Runtime.InteropServices;
namespace HizliSatis.Models
{
    class faturaModel : IDisposable
    {
        private int id;
        private string tarih;
        private string saat;
        private int musteriId;
        private float araToplam;
        private float indirim;
        private float genelToplam;
        private bool hesapDurum;

        bool disposed = false;
        SafeHandle handle = new SafeFileHandle(IntPtr.Zero, true);
        public faturaModel(int id, string tarih, string saat, int musteriId,float araToplam,float indirim, float genelToplam,bool hesapDurum)
        {


            this.id = id;
            this.tarih = tarih;
            this.saat = saat;
            this.musteriId = musteriId;
            this.araToplam = araToplam;
            this.indirim = indirim;
            this.genelToplam = genelToplam;
            this.hesapDurum = hesapDurum;

        }

        public int Id { get => id; set => id = value; }
        public string Tarih { get => tarih; set => tarih = value; }
        public string Saat { get => saat; set => saat = value; }
        public int MusteriId { get => musteriId; set => musteriId = value; }
        public float AraToplam { get => araToplam; set => araToplam = value; }
        public float Indirim { get => indirim; set => indirim = value; }
        public float GenelToplam { get => genelToplam; set => genelToplam = value; }
        public bool HesapDurum { get => hesapDurum; set => hesapDurum = value; }

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
