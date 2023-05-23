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
    public partial class Tedarikci : Form
    {
        public Tedarikci()
        {
            InitializeComponent();
        }
        querryClass querry = new querryClass();
        List<Models.tedarikciModel> tedarikciList;
        string selectedMenuButtonTag = "";
        List<Models.iletisimModel> iletisimList;
        Models.iletisimBilgisiModel iletisimBilgisi = new Models.iletisimBilgisiModel();
        Point point;
        int selectedRowIndex;
        private void Tedarikci_Load(object sender, EventArgs e)
        {
            iletisimList = querry.iletisimListesi();
            panel3.Width = 250;
            panel3.Left = this.Width;
            panel3.Height = this.Height;
            panel2.Height = this.Height;
            panel2.Width = this.Width - (panel3.Width + 145);
            //  panel2.Height = this.Height;
            // panel2.Width = this.Width - 385;
            fillGrid();
            iletisimTipComboBox.Items.Clear();
            point = new Point(iletisimTipComboBox.Location.X, iletisimTipComboBox.Location.Y + 5);
           // menuButtonVisibleOperation(menuEkleButton.Tag.ToString());
            menuEkleButton.PerformClick();

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
        private void Tedarikci_Resize(object sender, EventArgs e)
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
                    if (((Button)x).Tag != null && ((Button)x).Tag.ToString() == tag )
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

       

              // menuButtonVisibleOperation(tag);

        

            operationButtonsVisible(tag);

            panel2.Height = this.Height;
            panel3.Height = this.Height;
            panel2.Width = this.Width - (panel3.Width + 145);
            panel3.Left = panel1.Width + panel2.Width;

        }

        private void menuButtonsPress(object sender, EventArgs e)
        {
            if ((sender as Button).Tag.ToString()=="add")
            {
                tumunuTemizle();
            }
            rightMenuOperation((sender as Button).Tag.ToString());
        }

        private void menuButtonVisibleOperation(string tag)
        {
           
            int value = panel3.Width;
            if (value == 0)
            {
                selectedMenuButtonTag = tag;
                panel3.Width = 250;
                operationButtonsVisible(tag);

            }
            else if (value == 250 && tag == selectedMenuButtonTag )
            {
                selectedMenuButtonTag = "";
                panel3.Width = 0;
               
            }
            else
            {
                selectedMenuButtonTag = tag;
                operationButtonsVisible(tag);
            }
                


            //foreach (Control x in this.panel6.Controls)
            //{
            //    if (x is Button)
            //    {
            //        if (((Button)x).Tag != null && ((Button)x).Tag.ToString() == tag)
            //        {
            //            ((Button)x).Visible = true;
            //        }
            //        else if (((Button)x).Tag != null)
            //            ((Button)x).Visible = false;

            //    }

            //}



        }
        private void fillGrid()
        {
          
            tedarikciGridView.Rows.Clear();
            tedarikciList = querry.tedarikciListesi();
            for (int i = 0; i < tedarikciList.Count; i++)
            {
                DataGridViewRow row = (DataGridViewRow)tedarikciGridView.Rows[0].Clone();
                
                row.Cells[0].Value = tedarikciList[i].getTicariUnvan();
                row.Cells[1].Value = tedarikciList[i].getYetkili();
               
                tedarikciGridView.Rows.Add(row);

            }
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
            buttn.Tag = textBox.Text + "^" + i + "^" + itemIndex;
            if (iletisimList[i].MultiLine == 0)
            {
                //  MessageBox.Show("Tek");

                textBox.Height = 40;
                textBox.Width = 225;
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
                textBox.Width = 225;
                point.Y += 25;
                textBox.Multiline = true;
                textBox.Location = point;
                buttn.Location = new Point(point.X + 195, point.Y);
                point.Y += 50;
                iletisimBilgisi.iletisimtipiEkle(textBox, iletisimList[i].Id);

                panel5.Controls.Add(textBox);
                //    panel5.Controls.Add(buttn);
                itemIndex++;
            }

        }
        private void iletisim(int i, string text)
        {
            TextBox textBox = new TextBox();
            Button buttn = new Button();
            buttn.Text = "";
            textBox.Tag = iletisimList[i].IletisimTipi;
            textBox.Text =text;
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
            TextBox tb = (sender as TextBox);
            if (tb.Tag.ToString() == tb.Text)
            {
                tb.Text = "";
                tb.ForeColor = Color.Black;
            }
        }
        private void TextBox_Leave(object sender, EventArgs e)
        {
            TextBox tb = (sender as TextBox);
            if (tb.Text == "")
            {
                tb.Text = tb.Tag.ToString();
                tb.ForeColor = Color.Silver;
            }
        }

        private void musteriSilButton_Click(object sender, EventArgs e)
        {
            
            if (querry.deleteTedarikci(tedarikciList[selectedRowIndex]))
            {
                tumunuTemizle();
                fillGrid();                
                MessageBox.Show("Silme İşlemi Başarılı");
               
            }
        }

        private void musteriEkleButton_Click(object sender, EventArgs e)
        {
            Models.tedarikciModel tedarikci = new Models.tedarikciModel(0, ticariUnvanText.Text, yetkiliAdiText.Text);
            if (querry.insertTedarikci(tedarikci, iletisimBilgisi))
            {
                tumunuTemizle();
                fillGrid();
                
            }
                
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
        private void tumunuTemizle()
        {
            ticariUnvanText.Clear();
            yetkiliAdiText.Clear();

            temizle();
            duzenle();
            // rightMenuOperation((sender as Button).Tag.ToString());
        }
        private void tedarikciGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            temizle();
            try
            {
                selectedRowIndex = e.RowIndex;
                ticariUnvanText.Text = tedarikciGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                yetkiliAdiText.Text = tedarikciGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                string a = "";
              
                for (int i = 0; i < (tedarikciList[e.RowIndex].IletisimBilgisi.Count); i++)
                {
                    a += tedarikciList[e.RowIndex].IletisimBilgisi[i].IletisimId + " - ";

                    iletisim(tedarikciList[e.RowIndex].IletisimBilgisi[i].IletisimId-1, tedarikciList[e.RowIndex].IletisimBilgisi[i].Value);
                }

              //  MessageBox.Show(a);
                rightMenuOperation(menuGuncelleButton.Tag.ToString());
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

        private void tedarikciGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void searchText_TextChanged(object sender, EventArgs e)
        {
            tedarikciGridView.Rows.Clear();
            tedarikciList = querry.tedarikciSearch(searchText.Text);

            for (int i = 0; i < tedarikciList.Count; i++)
            {
                DataGridViewRow row = (DataGridViewRow)tedarikciGridView.Rows[0].Clone();

                row.Cells[0].Value = tedarikciList[i].getTicariUnvan();
                row.Cells[1].Value = tedarikciList[i].getYetkili();

                tedarikciGridView.Rows.Add(row);

            }

        }

        private void musteriGuncelleButton_Click(object sender, EventArgs e)
        {
           

            tedarikciList[selectedRowIndex].setTicariUnvan(ticariUnvanText.Text);
            tedarikciList[selectedRowIndex].setYetkili(yetkiliAdiText.Text);

            for (int i = 0; i < tedarikciList[selectedRowIndex].IletisimBilgisi.Count; i++)
            {
                tedarikciList[selectedRowIndex].IletisimBilgisi[i].Value = iletisimBilgisi.GetTextList()[i];
            }


            querry.UpdateTedarikci(tedarikciList[selectedRowIndex]);

            tumunuTemizle();
            fillGrid();
           
        }
    }
}
