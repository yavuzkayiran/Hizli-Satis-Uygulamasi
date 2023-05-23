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
    public partial class Musteri : Form
    {
        public Musteri()
        {
            InitializeComponent();
        }
        string selectedMenuButtonTag = "";
        querryClass querry = new querryClass();
        List<Models.musteriModel> musteriList;
        List<Models.iletisimModel> iletisimList;
        Models.iletisimBilgisiModel iletisimBilgisi = new Models.iletisimBilgisiModel();
        Point point;
        int selectedRowIndex;

        private void Musteri_Load(object sender, EventArgs e)
        {
            iletisimList=querry.iletisimListesi();
            panel3.Width = 0;
            panel3.Left = this.Width;
            panel3.Height = this.Height;
            panel2.Height = this.Height;
            panel2.Width = this.Width - (panel3.Width + 145);
            fillGrid();
            iletisimTipComboBox.Items.Clear();
            point = new Point(iletisimTipComboBox.Location.X, iletisimTipComboBox.Location.Y+5);

            duzenle();
         
            // panel2.Height = this.Height;
            // panel2.Width = this.Width - 385;
        }
        void duzenle()
        {
            for (int i = 0; i < iletisimList.Count; i++)
            {
                iletisimTipComboBox.Items.Add(iletisimList[i].IletisimTipi);
                iletisimTipComboBox.SelectedIndex = 0;

                iletisim(i);

            }
        }
        private void fillGrid()
        {

            musteriGridView.Rows.Clear();
            musteriList = querry.musteriListesi();
            for (int i = 0; i < musteriList.Count; i++)
            {
                DataGridViewRow row = (DataGridViewRow)musteriGridView.Rows[0].Clone();

                row.Cells[0].Value = musteriList[i].Adi;
                row.Cells[1].Value = musteriList[i].Soyadi;
                row.Cells[2].Value = musteriList[i].VergiNo;
                row.Cells[3].Value = musteriList[i].VergiDairesi;
                row.Cells[4].Value = musteriList[i].IndirimOrani;

                musteriGridView.Rows.Add(row);

            }
        }
        private void Musteri_Resize(object sender, EventArgs e)
        {
            panel2.Height = this.Height;
            panel2.Width = this.Width - (panel3.Width + 145);

            // panel2.Height = this.Height;
            // panel2.Width = this.Width - 385;
        }
        private void operationButtonsVisible(string tag)
        {
            foreach (Control x in this.panel6.Controls)
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
            else { 
                selectedMenuButtonTag = tag;
        }
            operationButtonsVisible(tag);

            panel2.Height = this.Height;
            panel3.Height = this.Height;
            panel2.Width = this.Width - (panel3.Width + 145);
            panel3.Left = panel1.Width + panel2.Width;

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

        private void iletisimTipEkleButton_Click(object sender, EventArgs e)
        {

            iletisim(iletisimTipComboBox.SelectedIndex);
        }
        int itemIndex = 0;
        private void iletisim(int i)
        {
            TextBox textBox = new TextBox();
            Button buttn = new Button();
            buttn.Text = "";
            textBox.Text = iletisimList[i].IletisimTipi;
            textBox.Tag = textBox.Text;
            textBox.ForeColor = Color.Silver;
            textBox.Enter += TextBox_Enter;
            textBox.Leave += TextBox_Leave;
            buttn.Height = 20;
            buttn.Width = 30;
            buttn.BackgroundImage = HizliSatis.Properties.Resources.close;
            buttn.BackgroundImageLayout = ImageLayout.Stretch;
            buttn.FlatStyle = FlatStyle.Standard;
            buttn.BackColor = SystemColors.AppWorkspace;
         //   buttn.Click += Remove_Button_Clik;
            buttn.Tag = textBox.Text+"^"+i+"^"+itemIndex;
            if (iletisimList[i].MultiLine == 0)
            {
                //  MessageBox.Show("Tek");

                textBox.Height = 40;
                textBox.Width = 190;
                point.Y += 25;
                textBox.Location = point;
                buttn.Location = new Point(point.X + 195, point.Y);
                iletisimBilgisi.iletisimtipiEkle(textBox, iletisimList[i].Id);
                panel5.Controls.Add(textBox);
            //    panel5.Controls.Add(buttn);
                itemIndex++;
            }
            else
            {
                textBox.Height = 70;
                textBox.Width = 190;
                point.Y += 25;
                textBox.Multiline = true;
                textBox.Location = point;
                buttn.Location = new Point(point.X + 195, point.Y);
                point.Y += 50;
              
                iletisimBilgisi.iletisimtipiEkle(textBox, iletisimList[i].Id);

                panel5.Controls.Add(textBox);
             //   panel5.Controls.Add(buttn);
                itemIndex++;
            }
        }
        private void iletisim(int i,string text)
        {
            TextBox textBox = new TextBox();
            Button buttn = new Button();
            buttn.Text = "";
            textBox.Tag = iletisimList[i].IletisimTipi;
            textBox.Text = text;
      
            textBox.Enter += TextBox_Enter;
            textBox.Leave += TextBox_Leave;
            buttn.Height = 20;
            buttn.Width = 30;
            buttn.BackgroundImage = HizliSatis.Properties.Resources.close;
            buttn.BackgroundImageLayout = ImageLayout.Stretch;
            buttn.FlatStyle = FlatStyle.Standard;
            buttn.BackColor = SystemColors.AppWorkspace;
            //   buttn.Click += Remove_Button_Clik;
            buttn.Tag = textBox.Text + "^" + i + "^" + itemIndex;
            if (iletisimList[i].MultiLine == 0)
            {
                //  MessageBox.Show("Tek");

                textBox.Height = 40;
                textBox.Width = 190;
                point.Y += 25;
                textBox.Location = point;
                buttn.Location = new Point(point.X + 195, point.Y);
                iletisimBilgisi.iletisimtipiEkle(textBox, iletisimList[i].Id);
                panel5.Controls.Add(textBox);
                //    panel5.Controls.Add(buttn);
                itemIndex++;
            }
            else
            {
                textBox.Height = 70;
                textBox.Width = 190;
                point.Y += 25;
                textBox.Multiline = true;
                textBox.Location = point;
                buttn.Location = new Point(point.X + 195, point.Y);
                point.Y += 50;

                iletisimBilgisi.iletisimtipiEkle(textBox, iletisimList[i].Id);

                panel5.Controls.Add(textBox);
                //   panel5.Controls.Add(buttn);
                itemIndex++;
            }
        }
        /*  private void Remove_Button_Clik(object sender, EventArgs e)
          {
              Button btn = (sender as Button);
              string[] tagData = btn.Tag.ToString().Split('^');
              string tag = tagData[0];
              int id = Convert.ToInt32(tagData[1]);
              int index= Convert.ToInt32(tagData[2]);
              foreach (Control x in this.panel5.Controls)
              {
                  if (x is Button)
                  {
                      if (((Button)x).Tag != null && ((Button)x).Tag.ToString()== btn.Tag.ToString())
                      {
                          ((Button)x).Visible = false;
                      }

                  }
                  if (x is TextBox)
                  {
                      if (((TextBox)x).Tag != null && ((TextBox)x).Tag.ToString()==tag)
                      {
                       //   ((TextBox)x).Visible = false;
                          iletisimBilgisi.removeIletisimBilgisi(((TextBox)x), iletisimList[id].Id);
                          panel5.Controls.Remove(((TextBox)x));
                          panel5.Refresh();
                      }
                      panel5.Refresh();

                  }

              }
          }*/

        private void TextBox_Enter(object sender, EventArgs e)
        {
           TextBox tb=(sender as TextBox);
            if (tb.Tag.ToString() == tb.Text)
            {
                tb.Text = "";
                tb.ForeColor = Color.Black;
            }
        }
        private void TextBox_Leave(object sender, EventArgs e)
        {
            TextBox tb = (sender as TextBox);
            if ( tb.Text=="")
            {
                tb.Text = tb.Tag.ToString();
                tb.ForeColor = Color.Silver;
            }
        }

        private void musteriEkleButton_Click(object sender, EventArgs e)
        {
            Models.musteriModel musteri = new Models.musteriModel(0, musteriAdiText.Text, musteriSoyadiText.Text, vergiNoText.Text, vergiDairesiText.Text, float.Parse(indirimOraniText.Text));
           if( querry.insertMusteri(musteri, iletisimBilgisi))           
                MessageBox.Show("Eklendi");
           else
                MessageBox.Show("Hata");
        }

        List<TextBox> panelTextBoxes = new List<TextBox>();
        private void temizle()
        {
            foreach (Control item in panel5.Controls)
            {
                if (item is TextBox)
                {
                    ((TextBox)item).Visible = false;
                    iletisimBilgisi.removeIletisimBilgisi((((TextBox)item)));
                    panelTextBoxes.Add(((TextBox)item));
                     
                }
            }
            point = new Point(iletisimTipComboBox.Location.X, iletisimTipComboBox.Location.Y + 5);
          
            foreach (TextBox item in panelTextBoxes)
            {
                item.Dispose();
            }
        }
        private void musteriGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            temizle();

            // temizle yaptıgı zaman paneldeki textleri siler ancak tutarsız çalışıyor 
            //aynıları tedarikçi içinde geçerlidir 
            try
            {
                selectedRowIndex = e.RowIndex;
                musteriAdiText.Text = musteriGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                musteriSoyadiText.Text = musteriGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                vergiNoText.Text = musteriGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                vergiDairesiText.Text = musteriGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                indirimOraniText.Text = musteriGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
                string a = "";
                for (int i = 0; i < (musteriList[e.RowIndex].IletisimBilgisi.Count); i++)
                {
                    a += musteriList[e.RowIndex].IletisimBilgisi[i].IletisimId + " - ";

                    iletisim(musteriList[e.RowIndex].IletisimBilgisi[i].IletisimId - 1, musteriList[e.RowIndex].IletisimBilgisi[i].Value);
                    //iletisim metodundan ikitane var birinin parametresi farklı olusturup içerisine veri yazsın diye text te yollanır 
                }

                MessageBox.Show(a);


                //TODO: Basınca iletisim() fonksiyonu çalıştırılacak önce panel 5 temizlencek ekleme butonu hariç
                //BU günlük bu kadar 
                //YARIN YORGUN OLMAZSAM BAKARIM 
                //SQLDE AÇIK OLAN SORGU ÖNELİ ANLAMAYA ÇALIŞ querryClass musteriListesi() fonksiyonundaki

            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());
            }
        }

        private void musteriSilButton_Click(object sender, EventArgs e)
        {
           
                if ( querry.deleteMusteri(musteriList[selectedRowIndex]))
            {
                MessageBox.Show("Silme İşlemi Başarılı");

            }
        }
    }
}
