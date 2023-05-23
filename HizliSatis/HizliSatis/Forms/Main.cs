using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HizliSatis.Forms
{
    public partial class Main : Form
    {
        private Form loginForm;
        public Main(Form loginForm)
        {
            InitializeComponent();
            this.loginForm = loginForm;
        }

        #region Form İşlemleri Button Boyutlandırma ve Close İşlemlerini İçerir
            /// <summary>
            /// Anasayfadaki butonların boyutlarını ayarlayan fonksiyon
            /// </summary>
            private void resizeOperation()
            {
                foreach (Control x in this.Controls)
                {
                    if (x is Button)
                    {
                        ((Button)x).Height = (this.Height / 3) - 20;
                        ((Button)x).Width = (this.Width / 2) - 20;
                    }
                }

                salesButton.Left = 10;
                customerButton.Left = 10;
                reportButton.Left = 10;

                stokButton.Left = 15 + salesButton.Width;
                tedarikciButton.Left = 15 + customerButton.Width;
                settingsButton.Left = 15 + reportButton.Width;

                salesButton.Top = 5;
                stokButton.Top = 5;  


                customerButton.Top = 10 + salesButton.Height;
                tedarikciButton.Top = 10 + stokButton.Height;

                reportButton.Top = 15 + salesButton.Height + customerButton.Height;
                settingsButton.Top = 15 + stokButton.Height + reportButton.Height;
            }

            //Form Açılırken Çalışacak event
            private void Main_Load(object sender, EventArgs e)
            {
                resizeOperation();
            }

            private void Main_Resize(object sender, EventArgs e)
            {
                resizeOperation();
            }

            //Uygulamadan çıkarken çalışacak event
            private void Main_FormClosing(object sender, FormClosingEventArgs e)
            {
                DialogResult dialogResult = MessageBox.Show("Uygulamadan çıkmak istediğinizden emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    loginForm.Close();
                }
                else if (dialogResult == DialogResult.No)
                {
                    e.Cancel = true;
                }

            }

        #endregion

        private void stokButton_Click(object sender, EventArgs e)
        {
            Forms.Stok stok = new Forms.Stok();
            stok.ShowDialog();

        }

        private void customerButton_Click(object sender, EventArgs e)
        {
            Forms.Musteri musteri = new Forms.Musteri();
            musteri.ShowDialog();
        }

        private void tedarikciButton_Click(object sender, EventArgs e)
        {
            Forms.Tedarikci tedarikci = new Forms.Tedarikci();
            tedarikci.ShowDialog();
        }

        private void salesButton_Click(object sender, EventArgs e)
        {
            Forms.Satis satis = new Forms.Satis();
            satis.ShowDialog();
        }

        private void reportButton_Click(object sender, EventArgs e)
        {
            Forms.Rapor rapor = new Forms.Rapor();
            rapor.ShowDialog();
          
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
      
            Forms.Settings ayarlar = new Forms.Settings();
            ayarlar.ShowDialog();
    

        }
    }
}
