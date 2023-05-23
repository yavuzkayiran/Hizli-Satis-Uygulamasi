using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32.SafeHandles;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace HizliSatis.Models
{

    class iletisimBilgisiModel : IDisposable
    {
      
        private List<int> eklenenIletisimIdList;
        private List<TextBox> textBoxes;
        
        bool disposed = false;
        SafeHandle handle = new SafeFileHandle(IntPtr.Zero, true);
        public iletisimBilgisiModel()
        {
            this.eklenenIletisimIdList = new List<int>();
            this.textBoxes = new List<TextBox>();
        }
        public void iletisimtipiEkle(TextBox textBox,int iletisimTipId)
        {
            textBoxes.Add(textBox);
            eklenenIletisimIdList.Add(iletisimTipId);
        }

        public List<string> GetTextList()
        {
            List<string> iletisimTipleri = new List<string>();
            foreach (var item in textBoxes)
            {
                iletisimTipleri.Add(item.Text!=item.Tag.ToString()?item.Text:"");
            }
            return iletisimTipleri;
        }

        public List<int> GetEklenenIletisimIdList()
        {
           
            return eklenenIletisimIdList;
        }

       public void removeIletisimBilgisi(TextBox textBox,int iletisimTipId)
        {
            textBoxes.Remove(textBox);
            eklenenIletisimIdList.Remove(iletisimTipId);
            MessageBox.Show(textBoxes.Count + "----" + eklenenIletisimIdList.Count);
        }
        public void removeIletisimBilgisi(TextBox textBox)
        {
           
           int index=textBoxes.IndexOf(textBox);
            eklenenIletisimIdList.RemoveAt(index);
            textBoxes.Remove(textBox);
         //   MessageBox.Show(textBoxes.Count + "----" + eklenenIletisimIdList.Count);
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
