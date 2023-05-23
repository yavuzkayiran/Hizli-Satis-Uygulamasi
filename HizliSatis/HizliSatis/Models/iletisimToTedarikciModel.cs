
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32.SafeHandles;
using System.Runtime.InteropServices;

namespace HizliSatis.Models
{
    class iletisimToTedarikciModel : IDisposable
    {
        private int id;
        private int iletisimId;
        private int tedarikciId;
        private string value;


        bool disposed = false;
        SafeHandle handle = new SafeFileHandle(IntPtr.Zero, true);
        public iletisimToTedarikciModel(int id, int iletisimId, int tedarikciId, string value)
        {
            this.id = id;
            this.iletisimId = iletisimId;
            this.tedarikciId = tedarikciId;
            this.value = value;
        }

        public int Id { get => id; set => id = value; }
        public int IletisimId { get => iletisimId; set => iletisimId = value; }
        public int MusteriId { get => tedarikciId; set => tedarikciId = value; }
        public string Value { get => value; set => this.value = value; }

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
