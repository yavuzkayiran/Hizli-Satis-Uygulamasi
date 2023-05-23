using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32.SafeHandles;
using System.Runtime.InteropServices;
namespace HizliSatis.Models
{
    class faturaToStokModel : IDisposable
    {
        private int id;
        private int faturaId;
        private int stokId;
        private int adet;
       

        bool disposed = false;
        SafeHandle handle = new SafeFileHandle(IntPtr.Zero, true);
        public faturaToStokModel(int id, int faturaId, int stokId, int adet)
        {


            this.id = id;
            this.faturaId = faturaId;
            this.stokId = stokId;
            this.adet = adet;
           

        }

        public int Id { get => id; set => id = value; }
        public int FaturaId { get => faturaId; set => faturaId = value; }
        public int StokId { get => stokId; set => stokId = value; }
        public int Adet { get => adet; set => adet = value; }

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
