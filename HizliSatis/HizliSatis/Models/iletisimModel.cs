using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32.SafeHandles;
using System.Runtime.InteropServices;
namespace HizliSatis.Models
{

    class iletisimModel : IDisposable
    {
        private int id;
        private string iletisimTipi;
        private int multiLine;


        bool disposed = false;
        SafeHandle handle = new SafeFileHandle(IntPtr.Zero, true);
        public iletisimModel(int id, string iletisimTipi,int multiLine)
        {


            this.id = id;
            this.iletisimTipi = iletisimTipi;
            this.multiLine = multiLine;




        }

        public int Id { get => id; set => id = value; }
        public string IletisimTipi { get => iletisimTipi; set => iletisimTipi = value; }
        public int MultiLine { get => multiLine; set => multiLine = value; }

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
