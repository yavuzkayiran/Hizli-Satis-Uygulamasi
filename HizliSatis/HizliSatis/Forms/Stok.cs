using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HizliSatis.Forms
{
    public partial class Stok : Form
    {
        public Stok()
        {
            InitializeComponent();
        }
        querryClass querry = new querryClass();
        List<Models.stokModel> stokList;
        List<Models.birimModel> birimList;
        List<Models.tedarikciModel> tedarikciList;
        string productImagePath = "";
        string selectedMenuButtonTag = "";
        private int selectedRowIndex = -1;
        bool isUpdateStok = false;


        private void Stok_Load(object sender, EventArgs e)
        {
            panel3.Width = 0;
            panel3.Left = this.Width;
            panel3.Height = this.Height;
            panel2.Height = this.Height;
            panel2.Width = this.Width - (panel3.Width + 145);

            sktDate.Format = DateTimePickerFormat.Custom;
            sktDate.CustomFormat = "yyyy-MM-dd";
            MessageBox.Show(sktDate.Value.ToString());
            loadData();
        }
        private void loadData()
        {
            stokList = querry.stokListesi(0, "");
            tedarikciList = querry.tedarikciListesi();

            birimList = querry.birimListesi();

            fillGrid();

        }
        private void Stok_Resize(object sender, EventArgs e)
        {
            panel2.Height = this.Height;
            panel2.Width = this.Width - (panel3.Width + 145);
        }

        private void fillGrid()
        {
            stokGridView.Rows.Clear();

            for (int i = 0; i < stokList.Count; i++)
            {
                DataGridViewRow row = (DataGridViewRow)stokGridView.Rows[0].Clone();
                row.Cells[0].Value = byteArrayToImage(stokList[i].getImage());
                row.Cells[1].Value = stokList[i].getBarkodNo();
                row.Cells[2].Value = stokList[i].getUrunAdi();
                row.Cells[3].Value = stokList[i].getTicariUnvan();//
                row.Cells[4].Value = stokList[i].getSonKulTrh();
                row.Cells[5].Value = stokList[i].getBirimAdi();///
                row.Cells[6].Value = stokList[i].getMiktar();
                row.Cells[7].Value = stokList[i].getBirimAdet();
                row.Cells[8].Value = stokList[i].getToplamMiktar();
                row.Cells[9].Value = stokList[i].getBirimFiyat();
                row.Cells[10].Value = stokList[i].getBirimAdetFiyat();
                row.Cells[11].Value = stokList[i].getKdv();
                row.Cells[12].Value = stokList[i].getSatisFiyati();

                stokGridView.Rows.Add(row);

            }
            fillComboBox();
        }
        public Image byteArrayToImage(byte[] bytesArr)
        {
            MemoryStream memstr = new MemoryStream(bytesArr);
            Image img = Image.FromStream(memstr);
            return img;
        }
        private void fillComboBox()
        {
            tedarikciCombo.Items.Clear();
            birimCombo.Items.Clear();
            kdvText.Text = "8";
            for (int i = 0; i < tedarikciList.Count; i++)
            {
                tedarikciCombo.Items.Add(tedarikciList[i].getTicariUnvan());
            }
            tedarikciCombo.SelectedIndex = 0;
            for (int i = 0; i < birimList.Count; i++)
            {
                birimCombo.Items.Add(birimList[i].getBirimAdi());
            }
            birimCombo.SelectedIndex = 0;

            //tedarikciCombo
            //birimCombo
        }

        private void stokGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                selectedRowIndex = e.RowIndex;
                stokImagePictureBox.Image = (Image)stokGridView.Rows[e.RowIndex].Cells[0].Value;
                barkodText.Text = stokGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                urunAdiText.Text = stokGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                tedarikciCombo.Text = stokGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                sktDate.Text = stokGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
                birimCombo.Text = stokGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
                // miktarText.Text = stokGridView.Rows[e.RowIndex].Cells[6].Value.ToString();
                miktarText.Text = "0";
                birimAdetText.Text = stokGridView.Rows[e.RowIndex].Cells[7].Value.ToString();
                toplamMiktarText.Text = stokGridView.Rows[e.RowIndex].Cells[8].Value.ToString();
                birimFiyatText.Text = stokGridView.Rows[e.RowIndex].Cells[9].Value.ToString();
                adetFiyatiText.Text = stokGridView.Rows[e.RowIndex].Cells[10].Value.ToString();
                kdvText.Text = stokGridView.Rows[e.RowIndex].Cells[11].Value.ToString();
                satisFiyatiText.Text = stokGridView.Rows[e.RowIndex].Cells[12].Value.ToString();

                isUpdateStok = true;

            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());
            }
        }


        private byte[] ImageToStream(string fileName)
        {
            MemoryStream stream = new MemoryStream();
            tryagain:
            try
            {

                stokImagePictureBox.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
            }
            catch (Exception ex)
            {
                goto tryagain;
            }

            return stream.ToArray();
        }

        private void loadImageButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Ürün Resmi Yükle";
                dlg.Filter = "Tüm dosyalar (*.*)|*.*|JPG Dosyaları (*.jpg)|*.jpg|JPEG Dosyaları (*.jpeg)|*.jpeg|PNG Dosyaları (*.png)|*.png|BMP Dosyaları (*.bmp)|*.bmp";

                if (dlg.ShowDialog() == DialogResult.OK)
                {


                    // Create a new Bitmap object from the picture file on disk,
                    // and assign that to the PictureBox.Image property
                    stokImagePictureBox.Image = new Bitmap(dlg.FileName);
                    productImagePath = dlg.FileName;
                }
            }
        }

        private void birimCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            birimAdetText.Text = birimList[birimCombo.SelectedIndex].getBirimAdet().ToString();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            searchOperation();
        }

        private void searchOperation()
        {
            if (barkodRadio.Checked)
            {
                if (searchText.Text.Length>0 && searchText.Text[searchText.Text.Length-1]=='e')
                {
                    searchText.Text = searchText.Text.Substring(0, searchText.Text.Length - 1);
                }
                stokList = querry.stokListesi(1, searchText.Text);
                fillGrid();
              
            }
            else if (urunNameRadio.Checked)
            {
                stokList = querry.stokListesi(2, searchText.Text);
                fillGrid();
              
            }
        }

        private void searchText_TextChanged(object sender, EventArgs e)
        {
            searchOperation();
        }
        private void menuButtonsPress(object sender, EventArgs e)
        {

            rightMenuOperation((sender as Button).Tag.ToString());
        }

        private int menuButtonVisibleOperation(int value, string tag)
        {
            if (value == 0)
            {
                selectedMenuButtonTag = tag;
                return 250;
            }
            else if (value == 250)
            {
                selectedMenuButtonTag = "";
                return 0;
            }
            return 0;

        }
        private void operationButtonsVisible(string tag)
        {
            foreach (Control x in this.panel3.Controls)
            {
                if (x is Button)
                {
                    if (((Button)x).Tag != null && ((Button)x).Tag.ToString() == tag)
                    {
                        ((Button)x).Visible = true;
                    }
                    else if (((Button)x).Tag != null)
                        ((Button)x).Visible = false;
                }

            }
        }
        private void rightMenuOperation(string tag)
        {

            if (tag == selectedMenuButtonTag || selectedMenuButtonTag == "")
            {

                panel3.Width = menuButtonVisibleOperation(panel3.Width, tag);

            }
            else
                selectedMenuButtonTag = tag;

            operationButtonsVisible(tag);

            panel2.Height = this.Height;
            panel3.Height = this.Height;
            panel2.Width = this.Width - (panel3.Width + 145);
            panel3.Left = panel1.Width + panel2.Width;

        }


        private void stokEkleButton_Click(object sender, EventArgs e)
        {
         //   MessageBox.Show(isUpdateStok.ToString()+"\n"+ (stokList[selectedRowIndex].getToplamMiktar() + Convert.ToInt32(toplamMiktarText.Text)));
            if (isUpdateStok)
            {
                Models.stokModel sm = new Models.stokModel(stokList[selectedRowIndex].getId(),
               barkodText.Text,
               urunAdiText.Text,
               tedarikciCombo.Text,
               sktDate.Text,
               birimCombo.Text,
               Convert.ToInt32(miktarText.Text),
                Convert.ToInt32(birimAdetText.Text),
               (stokList[selectedRowIndex].getToplamMiktar()+ Convert.ToInt32(toplamMiktarText.Text)),
               float.Parse(kdvText.Text),
                float.Parse(birimFiyatText.Text),
               float.Parse(adetFiyatiText.Text),
                float.Parse(satisFiyatiText.Text),
               ImageToStream(productImagePath));

                if (selectedRowIndex >= 0 && querry.updateStokAmount(sm, (stokList[selectedRowIndex].getToplamMiktar() + Convert.ToInt32(toplamMiktarText.Text))))
                {
                    loadData();
                }
                else
                {
                    MessageBox.Show("Bir Hata Oluştu");
                }
             
            }
            else
            {
                Models.stokModel sm = new Models.stokModel(0,
              barkodText.Text,
              urunAdiText.Text,
              tedarikciCombo.Text,
              sktDate.Text,
              birimCombo.Text,
              Convert.ToInt32(miktarText.Text),
               Convert.ToInt32(birimAdetText.Text),
               Convert.ToInt32(toplamMiktarText.Text),
              float.Parse(kdvText.Text),
               float.Parse(birimFiyatText.Text),
              float.Parse(adetFiyatiText.Text),
               float.Parse(satisFiyatiText.Text),
              ImageToStream(productImagePath));
                if (querry.insertStok(sm, birimList[birimCombo.SelectedIndex].getId(), tedarikciList[tedarikciCombo.SelectedIndex].getId()))
                {
                    loadData();
                }
                else
                {
                    MessageBox.Show("Bir Hata Oluştu");
                }
                //MessageBox.Show((double.Parse(adetFiyatiText.Text)).ToString() +"");
               

            }

            temizle();


        }

        private void stokGuncelleButton_Click(object sender, EventArgs e)
        {
           
            Models.stokModel sm = new Models.stokModel(stokList[selectedRowIndex].getId(),
                barkodText.Text,
                urunAdiText.Text,
                tedarikciCombo.Text,
                sktDate.Text,
                birimCombo.Text,
                Convert.ToInt32(toplamMiktarText.Text),
                 Convert.ToInt32(birimAdetText.Text),
                 Convert.ToInt32(toplamMiktarText.Text),
                float.Parse(kdvText.Text),
                 float.Parse(birimFiyatText.Text),
                float.Parse(adetFiyatiText.Text),
                 float.Parse(satisFiyatiText.Text),
                ImageToStream(productImagePath));
            if (selectedRowIndex >= 0 && querry.updateStok(sm, birimList[birimCombo.SelectedIndex].getId(), tedarikciList[tedarikciCombo.SelectedIndex].getId()))
            {
                loadData();
            }
            else
            {
                MessageBox.Show("Bir Hata Oluştu");
            }
            temizle();

        }

        private void stokSilButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Seçilen Ürünü Silmek İster Misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                if (selectedRowIndex >= 0 && querry.deleteStok(stokList[selectedRowIndex].getId()))
                {
                    loadData();
                }
                else
                {
                    MessageBox.Show("Bir Hata Oluştu");
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                // e.Cancel = true;
            }
            temizle();


        }
        private void captureImageButton_Click(object sender, EventArgs e)
        {
            Forms.Camera camera = new Forms.Camera();
            camera.ShowDialog();
            if (stokImagePictureBox != null)
            {
                stokImagePictureBox.Image = camera.pictureBox2.Image;
            }
            else
            {
                stokImagePictureBox.Image = HizliSatis.Properties.Resources.image;
            }
        }

        private void barkodText_TextChanged(object sender, EventArgs e)
        {
            if (barkodText.Text.Length>0&&barkodText.Text[barkodText.Text.Length - 1] == 'e')
            {
                barkodText.Text = barkodText.Text.Substring(0, barkodText.Text.Length - 1);
                urunAdiText.Focus();

               

            }



        }

        private void textFiled_TextChanged(object sender, EventArgs e)
        {
            try
            {
                toplamMiktarText.Text = (Convert.ToInt32(miktarText.Text) * Convert.ToInt32(birimAdetText.Text)).ToString();
                birimFiyatText.Text =(Convert.ToInt32(birimAdetText.Text)/ Convert.ToSingle(adetFiyatiText.Text)).ToString();
            }
            catch (Exception)
            {

            }
        }
        void temizle()
        {
            foreach (Control item in panel3.Controls)
            {
                if (item is TextBox || item is ComboBox)
                {
                    item.ResetText();
                }                             
            }
            adetFiyatiText.Text = "1";
            stokImagePictureBox.Image = HizliSatis.Properties.Resources.image;

        }

        private void stokGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void barkodRadio_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void urunAdiText_Enter(object sender, EventArgs e)
        {
            isUpdateStok = false;
            if (barkodText.Text != "")
            {

                stokList = querry.stokListesi(1, barkodText.Text);
                fillGrid();
                try
                {
                    selectedRowIndex = 0;
                    stokImagePictureBox.Image = (Image)stokGridView.Rows[0].Cells[0].Value;
                    barkodText.Text = stokGridView.Rows[0].Cells[1].Value.ToString();
                    urunAdiText.Text = stokGridView.Rows[0].Cells[2].Value.ToString();
                    tedarikciCombo.Text = stokGridView.Rows[0].Cells[3].Value.ToString();
                    sktDate.Text = stokGridView.Rows[0].Cells[4].Value.ToString();
                    birimCombo.Text = stokGridView.Rows[0].Cells[5].Value.ToString();
                    miktarText.Text = stokGridView.Rows[0].Cells[6].Value.ToString();
                    birimAdetText.Text = stokGridView.Rows[0].Cells[7].Value.ToString();
                    toplamMiktarText.Text = stokGridView.Rows[0].Cells[8].Value.ToString();
                    birimFiyatText.Text = stokGridView.Rows[0].Cells[9].Value.ToString();
                    adetFiyatiText.Text = stokGridView.Rows[0].Cells[10].Value.ToString();
                    kdvText.Text = stokGridView.Rows[0].Cells[11].Value.ToString();
                    satisFiyatiText.Text = stokGridView.Rows[0].Cells[12].Value.ToString();

                    isUpdateStok = true;


                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine(ex.ToString());
                }
                //  stokList = querry.stokListesi(0, "");
                //  fillGrid();


                //TODO: Pasif hale getirilmiş kod satırları  stok güncellemede yasanan isim sadece 
                //isim güncellemesi yapmaması birimcombovb comboların selected indexleri farklı gelmesidir...
            }
        }

        private void urunAdiText_TextChanged(object sender, EventArgs e)
        {

        }

        private void miktarText_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void satisFiyatiText_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',';
      
        }
    }
}
