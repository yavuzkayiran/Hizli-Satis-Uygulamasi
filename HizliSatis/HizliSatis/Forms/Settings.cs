using HizliSatis.AppMpdels;
using HizliSatis.Models;
using Newtonsoft.Json.Linq;
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
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }
        querryClass querry = new querryClass();
        List<Models.stokModel> stokList;
        List<Models.hizliSatisToUrunModel> hizliSatisToUrunList;
        int secilenUrunSayisi = 0;
        string filepath = "config.json";
        string result = string.Empty;
        private JObject settingsJSON;
        private string settingsJSONLoad;

        private void Settings_Load(object sender, EventArgs e)
        {
            
            stokList = querry.stokListesi(0, "");
            hizliSatisToUrunList = querry.hizlisatisList();
            fillGrid();
            secilenUrunLabel.Text = "0";



            //using  (StreamReader r = new StreamReader(filepath))
            //{
            //    var json = r.ReadToEnd();
            //    var jobj = JObject.Parse(json);
            //    foreach (var item in jobj.Properties())
            //    {
            //        item.Value = item.Value.ToString().Replace("v1", "v2");
            //    }
            //    settingsJSON = jobj;
            // //   MessageBox.Show(jobj.GetValue("MaximumHizliSatisSayisi").ToString());
            //   /// jobj["MaximumHizliSatisSayisi"] = 50;
            //  //  result = jobj.ToString();
            //}

            
            settingsJSON =(JObject)configFile.readConfig();


            if (bool.Parse(settingsJSON["BaslangictaFisOlustur"].ToString()))
            {
                button2.BackColor = Color.Green;
              
            }
            else
            {
                button2.BackColor = Color.Red;
              
            }
            fillSecilenGrid();
            maxSecimSayisi.Minimum = Int32.Parse(secilenUrunLabel.Text);
            settingsJSONLoad = settingsJSON.ToString();

            //    File.WriteAllText(filepath, result);
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
          
                stokGridView.Rows.Add(row);

            }

        }
        private void fillSecilenGrid()
        {
            secilenUrunlerGridView.Rows.Clear();
            secilenUrunSayisi = 0;
            maxSecimSayisi.Value = Convert.ToInt32(settingsJSON["MaximumHizliSatisSayisi"].ToString());
            StnsayisiNumber.Value = Convert.ToInt32(settingsJSON["SutunSayisi"].ToString());
            for (int i = 0; i < hizliSatisToUrunList.Count; i++)
            {
                DataGridViewRow row = (DataGridViewRow)secilenUrunlerGridView.Rows[0].Clone();
                row.Cells[0].Value = hizliSatisToUrunList[i].BarkodNo;
                row.Cells[1].Value = hizliSatisToUrunList[i].UrunAdi;
                secilenUrunlerGridView.Rows.Add(row);
                secilenUrunSayisi++;
            }
            secilenUrunLabel.Text = secilenUrunSayisi.ToString();
        }
        public Image byteArrayToImage(byte[] bytesArr)
        {
            MemoryStream memstr = new MemoryStream(bytesArr);
            Image img = Image.FromStream(memstr);
            return img;
        }
       private Boolean addHizliSatis(int selectedIndex)
        {
            
            if(secilenUrunSayisi< maxSecimSayisi.Value)
            {
                int secilenUrunID = stokList[selectedIndex].getId();
                int i = 0;
                Boolean urunVar = false;
                while (i < hizliSatisToUrunList.Count)
                {
                    if (hizliSatisToUrunList[i].UrunId != secilenUrunID)
                        i++;
                    else
                    {
                        urunVar = true;
                        break;
                    }
                }
                if (!urunVar)
                {
                    Boolean islem = querry.insertHizliSatis(secilenUrunID);
                    if (islem) secilenUrunSayisi++;
                    secilenUrunLabel.Text = secilenUrunSayisi.ToString();
                return islem;
                }
                else
                {
                    MessageBox.Show("AYNI URUNDEN EKLEME YAPILAMAZ");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("MAXİMUM "+ maxSecimSayisi.Value.ToString()+ " Seçim yapabilirsiniz");
                return false;

            }
               
           
        }
        private void stokGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                if (addHizliSatis(e.RowIndex))
                {

                    hizliSatisToUrunList = querry.hizlisatisList();
                    fillSecilenGrid();


                }


            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());
            }
        }

        private void maxSecimSayisi_ValueChanged(object sender, EventArgs e)
        {
            settingsJSON["MaximumHizliSatisSayisi"] = maxSecimSayisi.Value;

        }
        private void Settings_FormClosing(object sender, FormClosingEventArgs e)
        {
           
            if (settingsJSON.ToString() != settingsJSONLoad)
            {


                DialogResult dialogResult = MessageBox.Show("Değişiklikler kaydedilsin mi ?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    configFile.writeConfig(settingsJSON.ToString());
                   // result = settingsJSON.ToString();
                    //File.WriteAllText(filepath, result);
                }
            }

        }

        private void StnsayisiNumber_ValueChanged(object sender, EventArgs e)
        {
            settingsJSON["SutunSayisi"] = StnsayisiNumber.Value;

        }

        private void secilenUrunlerGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show((hizliSatisToUrunList[e.RowIndex].UrunAdi).ToString() + "  Hızlı Satıştan Kaldırılsın mı? ","Uyarı",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (dialogResult==DialogResult.Yes &&querry.deleteHizliSatis(hizliSatisToUrunList[e.RowIndex].UrunId))
            {
                hizliSatisToUrunList = querry.hizlisatisList();
                fillSecilenGrid();
            }
        }

        private void stokGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Forms.AddUser addUser = new AddUser();
            addUser.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (bool.Parse(settingsJSON["BaslangictaFisOlustur"].ToString()))
            { 
                 button2.BackColor = Color.Red;
                settingsJSON["BaslangictaFisOlustur"] = false;
            }
            else
            {
              button2.BackColor = Color.Green;
                settingsJSON["BaslangictaFisOlustur"] = true;

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            searchOperation();
        }

        private void searchOperation()
        {
            if (barkodRadio.Checked)
            {
                if (textBox1.Text.Length>0&&textBox1.Text[textBox1.Text.Length-1]=='e')
                {
                    textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
                }
                stokList = querry.stokListesi(1, textBox1.Text);
                fillGrid();
            }
            else if (urunRadio.Checked)
            {
                stokList = querry.stokListesi(2, textBox1.Text);
                fillGrid();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            searchOperation();
        }
    }
}
