using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32.SafeHandles;
using System.Runtime.InteropServices;
namespace HizliSatis.Models
{

    class birimModel : IDisposable
    {
        private int     id;
        private string  birimAdi;
        private int     birimAdet;
      
 

        bool disposed = false;
        SafeHandle handle = new SafeFileHandle(IntPtr.Zero, true);
        public birimModel(int id, string birimAdi,int birimAdet)
        {
              
           
            this.id = id;
            this.birimAdi = birimAdi;
            this.birimAdet = birimAdet;
       
       
        }

        public int getId()
        {
            return this.id;
        }

        public void setId(int id)
        {
            this.id = id;
        }

        public string getBirimAdi()
        {
            return this.birimAdi;
        }
        public void setBirimAdi(string birimAdi)
        {
            this.birimAdi = birimAdi;
        }


        public int getBirimAdet()
        {
            return this.birimAdet;
        }
        public void setBirimAdet(int birimAdet)
        {
            this.birimAdet = birimAdet;
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
