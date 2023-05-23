using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32.SafeHandles;
using System.Runtime.InteropServices;
namespace HizliSatis.Models
{
    class musteriModel : IDisposable
    {
        private int id;
        private string adi;
        private string soyadi;
        private string vergiNo;
        private string vergiDairesi;
        private float indirimOrani;
        private List<Models.iletisimToMusteriModel> iletisimBilgisi;

        bool disposed = false;
        SafeHandle handle = new SafeFileHandle(IntPtr.Zero, true);
        public musteriModel(int id, string adi, string soyadi,string vergiNo, string vergiDairesi,float indirimOrani)
        {


            this.id = id;
            this.adi = adi;
            this.soyadi = soyadi;
            this.vergiNo = vergiNo;
            this.vergiDairesi = vergiDairesi;
            this.indirimOrani = indirimOrani;

        }

        public musteriModel(int id, string adi, string soyadi, string vergiNo, string vergiDairesi, float indirimOrani,List<Models.iletisimToMusteriModel> iletisimBilgisi)
        {


            this.id = id;
            this.adi = adi;
            this.soyadi = soyadi;
            this.vergiNo = vergiNo;
            this.vergiDairesi = vergiDairesi;
            this.indirimOrani = indirimOrani;
            this.iletisimBilgisi = iletisimBilgisi;

        }

        public int Id { get => id; set => id = value; }
        public string Adi { get => adi; set => adi = value; }
        public string Soyadi { get => soyadi; set => soyadi = value; }
        public string VergiNo { get => vergiNo; set => vergiNo = value; }
        public string VergiDairesi { get => vergiDairesi; set => vergiDairesi = value; }
        public float IndirimOrani { get => indirimOrani; set => indirimOrani = value; }
        internal List<iletisimToMusteriModel> IletisimBilgisi { get => iletisimBilgisi; set => iletisimBilgisi = value; }

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
