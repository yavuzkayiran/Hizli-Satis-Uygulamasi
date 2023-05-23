using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32.SafeHandles;
using System.Runtime.InteropServices;
namespace HizliSatis.Models
{
    class tedarikciModel : IDisposable
    {
        private int id;
        private string ticariUnvan;
        private string yetkili;
        private List<Models.iletisimToTedarikciModel> iletisimBilgisi;

        bool disposed = false;
        SafeHandle handle = new SafeFileHandle(IntPtr.Zero, true);

        public tedarikciModel(int id, string ticariUnvan, string yetkili)
        {


            this.id = id;
            this.ticariUnvan = ticariUnvan;
            this.yetkili = yetkili;
           
        }
        public tedarikciModel(int id, string ticariUnvan, string yetkili, List<Models.iletisimToTedarikciModel> iletisimBilgisi)
        {


            this.id = id;
            this.ticariUnvan = ticariUnvan;
            this.yetkili = yetkili;
            this.iletisimBilgisi = iletisimBilgisi;
        }

        public string TicariUnvan { get => ticariUnvan; set => ticariUnvan = value; }
        public string Yetkili { get => yetkili; set => yetkili = value; }
        internal List<iletisimToTedarikciModel> IletisimBilgisi { get => iletisimBilgisi; set => iletisimBilgisi = value; }

        public int getId()
        {
            return this.id;
        }

        public void setId(int id)
        {
            this.id = id;
        }

        public string getTicariUnvan()
        {
            return this.ticariUnvan;
        }
        public void setTicariUnvan(string ticariUnvan)
        {
            this.ticariUnvan = ticariUnvan;
        }

        public string getYetkili()
        {
            return this.yetkili;
        }
        public void setYetkili(string yetkili)
        {
            this.yetkili = yetkili;
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
