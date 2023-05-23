using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32.SafeHandles;
using System.Runtime.InteropServices;
namespace HizliSatis.Models
{

    class userModel : IDisposable
    {
        private int id;
        private string kullaniciAdi;
        private string sifre;



        bool disposed = false;
        SafeHandle handle = new SafeFileHandle(IntPtr.Zero, true);

        public string KullaniciAdi { get => kullaniciAdi; set => kullaniciAdi = value; }
        public string Sifre { get => sifre; set => sifre = value; }
        public int Id { get => id; set => id = value; }

        public userModel(int id, string kullaniciAdi, string sifre)
        {


            this.id = id;
            this.kullaniciAdi = kullaniciAdi;
            this.sifre = sifre;


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
