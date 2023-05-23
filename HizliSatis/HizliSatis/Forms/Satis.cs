using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HizliSatis.Forms
{
    public partial class Satis : Form
    {
        public Satis()
        {
            InitializeComponent();
        }
        querryClass querry = new querryClass();
        List<Models.stokModel> stokList;
        List<Models.birimModel> birimList;
        List<Models.tedarikciModel> tedarikciList;
        List<Models.musteriModel> musteriList;
        List<Models.hizliSatisToUrunModel> hizliSatisList;
        List<Button> buttonList = new List<Button>();
        List<Models.faturaToStokModel> faturaToStokList = new List<Models.faturaToStokModel>();

        private int selectedRowIndex = -1;
        private int faturaId=-1;
        int SutunSayisi = 3;
        string filepath = "config.json";
        private JObject settingsJSON;
        Point point;
        bool faturaDurum = false;
        private void Satis_Load(object sender, EventArgs e)
        {
            panel1.Left = 0;
            panel1.Width = (this.Width / 2) - 5;
            panel2.Left = panel1.Width +5;
            panel2.Width = (this.Width / 2) - 5;
            panel3.Height = 75;
            panel3.Left = panel1.Width + 5;
            panel3.Width = (this.Width / 2) - 5;

         
            using (StreamReader r = new StreamReader(filepath))
            {
                var json = r.ReadToEnd();
                var jobj = JObject.Parse(json);
                foreach (var item in jobj.Properties())
                {
                    item.Value = item.Value.ToString().Replace("v1", "v2");
                }
                settingsJSON = jobj;
                //   MessageBox.Show(jobj.GetValue("MaximumHizliSatisSayisi").ToString());
                /// jobj["MaximumHizliSatisSayisi"] = 50;
                //  result = jobj.ToString();
            }
            SutunSayisi =Int32.Parse(settingsJSON["SutunSayisi"].ToString());
            loadData();
            hizlisatisLoad();
            //Açılışta Yeni Fiş Oluştur Ayara Bağlanacak
            if (bool.Parse(settingsJSON["BaslangictaFisOlustur"].ToString()) && settingsJSON["FaturaId"].ToString()=="-1")
            {                
                yeniFisOlustur();
            }
            else if (settingsJSON["FaturaId"].ToString()!="-1")
            {
                faturaId = Int32.Parse(settingsJSON["FaturaId"].ToString());
                faturaToStokList = querry.faturaToStokListesi(faturaId);
                fisfillGrid();
         faturaDurum = true;

            }


            ///Durum 1: Ayara Bağlı Durumu : Bu durumda ayar true ise her açılışta bu yeni fiş açı çalıştır
            ///false ise ürün eklemeden önce !!!!bir kere !!!!!!
            ///
            ///Durum 2: Kullanıcı fiş oluşturdıu sayfadan çıkacak soru sor
            ///oluşturduğunuz fiş kalsın mı silinsin mi?
            ///Silinsin derse
            ///tüm ürünler için 
            ///kalsın derse settings json da fatura id diye bi değere oluşmuş fatura id sini yaz
            ///sayfa yeniden açılırken Durum1 deki if den önce!!!! settingsde fatura id varmı bak varsa bu
            ///fatura ıd sini fatura id ye ekle faturaTo stok tan bu fatura idsinie göre select çek
            ///yoksa 1. durum neyi gerektiryorsa onu yap
            //   fisfillGrid();


        }
        private void loadData()
        {
            stokList = querry.stokListesi(0, "");
            tedarikciList = querry.tedarikciListesi();
            birimList = querry.birimListesi();
            musteriList = querry.musteriListesi();
            hizliSatisList = querry.hizlisatisList();
            fillGrid();
        
           // hizlisatisLoad();
        }
        private void hizlisatisLoad()
        {
             point = new Point(0, 0);

            int hizliSatisCount = hizliSatisList.Count;

            int satirSayisi = hizliSatisCount / SutunSayisi + 1;

            for (int i = 0; i < hizliSatisCount; i++)
            {
                Button btn = new Button();
                btn.BackgroundImageLayout = ImageLayout.Stretch;
                btn.ImageAlign=ContentAlignment.TopCenter;
                btn.TextAlign = ContentAlignment.BottomCenter;
                btn.BackgroundImage = byteArrayToImage(hizliSatisList[i].Image);
                btn.BringToFront();
                btn.Text = hizliSatisList[i].UrunAdi +"\n ("+hizliSatisList[i].ToplamMiktar.ToString()+")";
                if (hizliSatisList[i].ToplamMiktar == 0) btn.Enabled = false;
                btn.Tag = hizliSatisList[i].BarkodNo+"^"+i;
                btn.Height = tabPage1.Height / satirSayisi - 5;
                btn.Width = tabPage1.Width / SutunSayisi - 5;
                btn.Click += Btn_Click;
                btn.MouseHover += Btn_Hover;
                btn.MouseLeave += Btn_Leave;
                if (i%SutunSayisi==0&& i!=0)
                {
                    point = new Point(0,point.Y+btn.Height+5);
                   
                }
                else if( i!=0)
                 point = new Point(point.X + btn.Width + 5, point.Y);
             

                btn.Location=point;
                buttonList.Add(btn);
                tabPage1.Controls.Add(btn);
            }
        }

        private void Btn_Leave(object sender, EventArgs e)
        {
            labelUrunText.Text = "";
        }

        private void Btn_Hover(object sender, EventArgs e)
        {          
            labelUrunText.Text = (sender as Button).Text;
        }

        private void temizle()
        { // point = new Point(0,0);
            int hizliSatisCount = hizliSatisList.Count;
           // if(buttonList.Count)
            for (int i = 0; i < hizliSatisCount; i++)
            {
                buttonList[i].Text= hizliSatisList[i].UrunAdi + "\n (" + hizliSatisList[i].ToplamMiktar.ToString() + ")";


            }



/*
                foreach (Control item in buttonList)
            {
                if (item is Button)
                {
                    ((Button)item).Visible = false;
                    tabPage1.Controls.Remove((Button)item);
                }
            }
            foreach (Button item in buttonList)
            {
              
                item.Dispose();
            }
            buttonList = new List<Button>();*/
        }
        private void Btn_Click(object sender, EventArgs e)
        {


            stokList = querry.stokListesi(1, (sender as Button).Tag.ToString().Split('^')[0]);
          
            fillGrid();            // stokGridView_CellClick(stokGridView, new DataGridViewCellEventArgs (0,0));
 
            Forms.NumerPad numerPad = new Forms.NumerPad();
            numerPad.ShowDialog();
            if (!numerPad.Cancel)
            {
                adetText.Text = numerPad.Adet.ToString();
                
                selectedRowIndex = 0;

                DataGridViewRow row = (DataGridViewRow)satisFisiGrid.Rows[0].Clone();
               
                // MessageBox.Show("stok sayısı :" + stokList.Count.ToString());
                row.Cells[0].Value = stokGridView.Rows[selectedRowIndex].Cells[2].Value.ToString();
                row.Cells[1].Value = adetText.Text;
                row.Cells[2].Value = stokGridView.Rows[selectedRowIndex].Cells[4].Value.ToString();
                //row.Cells[3].Value = stokGridView.Rows[selectedRowIndex].Cells[11].Value.ToString();//
                row.Cells[3].Value = (float.Parse(adetText.Text) * float.Parse(stokGridView.Rows[selectedRowIndex].Cells[4].Value.ToString())).ToString();
                urunFiyatLabel.Text = stokGridView.Rows[selectedRowIndex].Cells[4].Value.ToString();
                // textBox1.Text = stokGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                //   textBox2.Text = stokGridView.Rows[e.RowIndex].Cells[2].Value.ToString();


                if (addProductOperation())
                {
                    // //TODO : stok model olustur  urunu cek  FİYATI YANLIŞ DÖNUYOR 

                    #region Çalışmayan Stok

                    /* Models.stokModel eklenecek = null;

                    eklenecek.setUrunAdi(stokGridView.Rows[selectedRowIndex].Cells[2].Value.ToString());
                    eklenecek.setBirimAdet(Int32.Parse(adetText.Text));
                    eklenecek.setSatisFiyati(Int32.Parse(stokGridView.Rows[selectedRowIndex].Cells[12].Value.ToString()));
                    eklenecek.setKdv(float.Parse(stokGridView.Rows[selectedRowIndex].Cells[11].Value.ToString()));
                    // MessageBox.Show("stok sayısı :" + stokList.Count.ToString());

                    // textBox1.Text = stokGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                    //   textBox2.Text = stokGridView.Rows[e.RowIndex].Cells[2].Value.ToString();


                  


                        row.Cells[0].Value = eklenecek.getUrunAdi();
                        row.Cells[1].Value = eklenecek.getBirimAdet();
                        row.Cells[2].Value = eklenecek.getSatisFiyati();
                        row.Cells[3].Value = eklenecek.getKdv();//
                        row.Cells[4].Value = eklenecek.getBirimAdet() * eklenecek.getSatisFiyati();
                        urunFiyatLabel.Text = eklenecek.getSatisFiyati().ToString();

                    */
                    #endregion 



                    satisFisiGrid.Rows.Add(row);
                    totalPriceLabel.Text = Math.Round((float.Parse(totalPriceLabel.Text.ToString())+float.Parse(row.Cells[3].Value.ToString())),2).ToString();
                    adetText.Text = "1";

                    //int index = Convert.ToInt32((sender as Button).Tag.ToString().Split('^')[1]);
                    //hizliSatisList[index].ToplamMiktar = hizliSatisList[index].ToplamMiktar-Convert.ToInt32(adetText.Text.ToString());

                    //(sender as Button).Text = hizliSatisList[index].UrunAdi + "\n (" + hizliSatisList[index].ToplamMiktar.ToString() + ")";

                }

                hizliSatisList = querry.hizlisatisList();

                temizle();
                //  hizlisatisLoad();
            }
            else
            {
              //  MessageBox.Show("iptal edildi");
            }

                //selectedRowIndex = e.RowIndex;
                //if (addProductOperation())
                //{

                //    DataGridViewRow row = (DataGridViewRow)satisFisiGrid.Rows[0].Clone();
                //    row.Cells[0].Value = stokGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                //    row.Cells[1].Value = adetText.Text;
                //    row.Cells[2].Value = stokGridView.Rows[e.RowIndex].Cells[12].Value.ToString();
                //    row.Cells[3].Value = stokGridView.Rows[e.RowIndex].Cells[11].Value.ToString();//
                //    row.Cells[4].Value = (float.Parse(adetText.Text) * float.Parse(stokGridView.Rows[e.RowIndex].Cells[12].Value.ToString())).ToString();
                //    urunFiyatLabel.Text = stokGridView.Rows[e.RowIndex].Cells[12].Value.ToString();
                //    // textBox1.Text = stokGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                //    // textBox2.Text = stokGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                //    satisFisiGrid.Rows.Add(row);

                //    totalPriceLabel.Text = (float.Parse(totalPriceLabel.Text.ToString()) + (float.Parse(adetText.Text) * float.Parse(stokGridView.Rows[e.RowIndex].Cells[12].Value.ToString()))).ToString();

                //}
            }

        private void yeniFisOlustur()
        {
            DateTime localDate = DateTime.Now;
            string date = localDate.ToString("yyyy-MM-dd");
            string time = localDate.ToString("HH:mm:ss");    
            Models.faturaModel fm = new Models.faturaModel(0, date, time, musteriList[0].Id, 0, musteriList[0].IndirimOrani, 0,false);
            faturaId = querry.insertFatura(fm);
            if (faturaId < 0)
            {
                MessageBox.Show("Fatura Açılamadı");
            }
            else
            {
                faturaDurum = true;
            }
        }
        private void fisfillGrid()
        {
            satisFisiGrid.Rows.Clear();


            Models.stokModel sm = null;


           faturaToStokList=querry.faturaToStokListesi(faturaId);


            for (int i = 0; i < faturaToStokList.Count; i++)
            {

                for (int j = 0; j < stokList.Count; j++)
                {
                    if (faturaToStokList[i].StokId == stokList[j].getId())
                    {
                        sm = stokList[j];
                        break;
                    }

                }
                DataGridViewRow row = (DataGridViewRow)satisFisiGrid.Rows[0].Clone();

                row.Cells[0].Value = sm.getUrunAdi();
                row.Cells[1].Value = faturaToStokList[i].Adet;
                row.Cells[2].Value = sm.getSatisFiyati();//
               // row.Cells[3].Value = sm.getKdv();
                row.Cells[3].Value = faturaToStokList[i].Adet*float.Parse(sm.getSatisFiyati().ToString());

                totalPriceLabel.Text = Math.Round((float.Parse(totalPriceLabel.Text.ToString()) + faturaToStokList[i].Adet * float.Parse(sm.getSatisFiyati().ToString())),2).ToString();

                satisFisiGrid.Rows.Add(row);

            }


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

               // row.Cells[3].Value = stokList[i].getTicariUnvan();//
               // row.Cells[4].Value = stokList[i].getSonKulTrh();
               // row.Cells[5].Value = stokList[i].getBirimAdi();///
               // row.Cells[6].Value = stokList[i].getMiktar();
               // row.Cells[7].Value = stokList[i].getBirimAdet();
                row.Cells[3].Value = stokList[i].getToplamMiktar();
                //row.Cells[9].Value = stokList[i].getBirimFiyat();
               // row.Cells[10].Value = stokList[i].getBirimAdetFiyat();
               // row.Cells[11].Value = stokList[i].getKdv();
                row.Cells[4].Value = stokList[i].getSatisFiyati();

                stokGridView.Rows.Add(row);

            }
         
        } 



        private void stokGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                selectedRowIndex = e.RowIndex;
                if (addProductOperation())
                {
                  
                    DataGridViewRow row = (DataGridViewRow)satisFisiGrid.Rows[0].Clone();
                    row.Cells[0].Value = stokGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                    row.Cells[1].Value = adetText.Text;
                    row.Cells[2].Value = stokGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
                  //  row.Cells[3].Value = stokGridView.Rows[e.RowIndex].Cells[11].Value.ToString();//
                    row.Cells[3].Value = (float.Parse(adetText.Text) * float.Parse(stokGridView.Rows[e.RowIndex].Cells[4].Value.ToString())).ToString();
                    urunFiyatLabel.Text = stokGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
                   // textBox1.Text = stokGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                   // textBox2.Text = stokGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                    satisFisiGrid.Rows.Add(row);

                    totalPriceLabel.Text = Math.Round((float.Parse(totalPriceLabel.Text.ToString()) + (float.Parse(adetText.Text) * float.Parse(stokGridView.Rows[e.RowIndex].Cells[4].Value.ToString()))),2).ToString();

                }
                adetText.Text = "1";
                textBox1.Text = "";


            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());
            }
        }
        public Image byteArrayToImage(byte[] bytesArr)
        {
            MemoryStream memstr = new MemoryStream(bytesArr);
            Image img = Image.FromStream(memstr);
            return img;
        }
        private void Satis_Resize(object sender, EventArgs e)
        {
            panel1.Left = 0;
            panel1.Width = (this.Width / 2) - 5;
            panel2.Left = panel1.Width + 5;
            panel2.Width = (this.Width / 2) - 5;
            panel3.Height = 50;
            panel3.Left = panel1.Width + 5;
            panel3.Width = (this.Width / 2) - 5;
        }

        private Boolean addProductOperation()
        {
            if (!faturaDurum)
            {
                yeniFisOlustur();
            }
            if (faturaDurum)
            {  
            int adet = Convert.ToInt32(adetText.Text.ToString());
            Models.stokModel sm = stokList[selectedRowIndex];
            if (sm.getToplamMiktar() >= adet)
            {
                Models.faturaToStokModel faturaToStokModel = new Models.faturaToStokModel(0, faturaId, sm.getId(), adet);
                faturaToStokList.Add(faturaToStokModel);
                if (querry.insertFaturaToStok(faturaToStokModel))
                {
                    
                    if (selectedRowIndex >= 0)
                    {
                            //todo: change adet text
                        adetText.Text =  adet.ToString();
                       // loadData();
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Stok Miktarı Güncellenirker Hata Oluştu");
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("Beklenmedik Bir Hata Oluştu");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Üründen Yeterli Miktarda Yok");
                return false;
            }
        }
            else
            {
                MessageBox.Show("Oluşmuş Fatura Bulunamadı");

                return false;
            }
        }




        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            
                if (checkBox1.Checked &&textBox1.Text.Length>0 && textBox1.Text[textBox1.Text.Length-1]=='e')
            {
              textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);

               
                stokList = querry.stokListesi(1, textBox1.Text);
                fillGrid();

                // stokGridView_CellClick(stokGridView, new DataGridViewCellEventArgs (0,0));

                try
                {
                    selectedRowIndex = 0;

                    DataGridViewRow row = (DataGridViewRow)satisFisiGrid.Rows[0].Clone();

                    // MessageBox.Show("stok sayısı :" + stokList.Count.ToString());
                    row.Cells[0].Value = stokGridView.Rows[selectedRowIndex].Cells[2].Value.ToString();
                    row.Cells[1].Value = adetText.Text;
                    row.Cells[2].Value = stokGridView.Rows[selectedRowIndex].Cells[4].Value.ToString();
                    //row.Cells[3].Value = stokGridView.Rows[selectedRowIndex].Cells[11].Value.ToString();//
                    row.Cells[3].Value = (float.Parse(adetText.Text) * float.Parse(stokGridView.Rows[selectedRowIndex].Cells[4].Value.ToString())).ToString();
                    urunFiyatLabel.Text = stokGridView.Rows[selectedRowIndex].Cells[4].Value.ToString();
                    // textBox1.Text = stokGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                    //   textBox2.Text = stokGridView.Rows[e.RowIndex].Cells[2].Value.ToString();


                    if (addProductOperation())
                    {



                        satisFisiGrid.Rows.Add(row);

                        totalPriceLabel.Text = Math.Round((float.Parse(totalPriceLabel.Text.ToString()) + (float.Parse(adetText.Text) * float.Parse(stokGridView.Rows[selectedRowIndex].Cells[4].Value.ToString()))),2).ToString();

                    }
                  


                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine(ex.ToString());
                }
                textBox1.Clear();
            }
            else if(!checkBox1.Checked)
            {
                stokList = querry.stokListesi(1, textBox1.Text);
                fillGrid();
            }
            // MessageBox.Show(textBox1.Text);
      

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            stokList = querry.stokListesi(2, textBox2.Text);
            fillGrid();
        }

        private void satisFisiGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = 0;
            Models.stokModel sm = null;
            while (i < stokList.Count)
            {
                if (faturaToStokList[e.RowIndex].StokId == stokList[i].getId())
                {
                    sm = stokList[i];
                    break;
                }

                i++;
            }

            if (e.ColumnIndex==-1||DialogResult.OK == MessageBox.Show(sm.getUrunAdi() + " Sepetten Kaldırılsın mı?", "Uyarı", MessageBoxButtons.OKCancel, MessageBoxIcon.Question))
            {

                if (sm != null && querry.deleteFaturaToStok(faturaToStokList[e.RowIndex]))
                {
                   
                    if (e.RowIndex >= 0)
                    {
                        float toplamFiyat = float.Parse(totalPriceLabel.Text.ToString());
                        int adet= faturaToStokList[e.RowIndex].Adet;
                        float satisFiyati = sm.getSatisFiyati();
                        float sonuc = ((adet * satisFiyati));
                        float sonuc2 = toplamFiyat - sonuc;
                        totalPriceLabel.Text = (Math.Round(sonuc2,2)).ToString();

                        satisFisiGrid.Rows.RemoveAt(e.RowIndex);
                        faturaToStokList.RemoveAt(e.RowIndex);
                        loadData();
                        temizle();
                    }
                    else
                    {
                        MessageBox.Show("Stok Miktarı Güncellenirker Hata Oluştu");

                    }
                }
                else
                {
                    MessageBox.Show("Bir Hata asdasd Oluştu");

                }
            }
        }

        private void tabPage1_Enter(object sender, EventArgs e)
        {
           //
            hizliSatisList = querry.hizlisatisList();
            temizle();
            // hizlisatisLoad();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (float.Parse(paraGirisText.Text) >= float.Parse(totalPriceLabel.Text))
            {
                if (!querry.updateFatura(new Models.faturaModel(faturaId, "", "", musteriList[0].Id, float.Parse(totalPriceLabel.Text), musteriList[0].IndirimOrani, (float.Parse(totalPriceLabel.Text) - (float.Parse(totalPriceLabel.Text) * musteriList[0].IndirimOrani / 100)), true)))
                {
                    MessageBox.Show("Satış Yapılırken Bir Sorunla Karşılaşıldı.");
                }
                else
                {
                    if ( 0 != ((float.Parse(paraGirisText.Text) - float.Parse(totalPriceLabel.Text))))
                    {
                        MessageBox.Show("Para Üstü: " + (float.Parse(paraGirisText.Text) - float.Parse(totalPriceLabel.Text)).ToString());

                    }

                    faturaId = -1;
                    faturaDurum = false;
                    fisfillGrid();
                    totalPriceLabel.Text = "00,00";
                    paraGirisText.Text = "0";
                }
            }
            else
            {
                MessageBox.Show("Ücret Yeterli Değil.");
            }
        }

        private void Satis_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (faturaId > 0)
            {
                DialogResult dialog = MessageBox.Show("Oluşturulan Fiş Silinsin mi ?", "UYARI", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    for (int i = faturaToStokList.Count(); i > 0; i--)
                    {
                        loadData();
                        satisFisiGrid_CellClick(satisFisiGrid, new DataGridViewCellEventArgs(-1,0));

                    }
                    querry.deleteFatura(faturaId);
                    settingsJSON["FaturaId"] = -1;
                    File.WriteAllText(filepath, settingsJSON.ToString());
                }
                else if (dialog == DialogResult.No)
                {
                    settingsJSON["FaturaId"] = faturaId;
                    File.WriteAllText(filepath, settingsJSON.ToString());
                }
                else if (dialog == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
            else
            {
                settingsJSON["FaturaId"] = faturaId;
                File.WriteAllText(filepath, settingsJSON.ToString());
            }
        }

        private void satisFisiGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            stokList = querry.stokListesi(0, "");
            fillGrid();
            this.ActiveControl = textBox1;
           
        }

        private void totalPriceLabel_TextChanged(object sender, EventArgs e)
        {
            paraGirisText.Text = totalPriceLabel.Text;

        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
          
           
        }  

        private void Satis_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void stokGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
