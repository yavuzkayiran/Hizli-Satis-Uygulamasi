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
    public partial class Rapor : Form
    {
        public Rapor()
        {
            InitializeComponent();
        }
        querryClass querry = new querryClass();
        List<Models.stokModel> stoklist = new List<Models.stokModel>();
        List<Models.raporModel> toplamSatisList =new List<Models.raporModel>();
        private void toplamSatisRaporlama()
        {
            toplamSatisList = querry.toplamSatisListesi(baslangicTarihi.Text,bitisTarihi.Text);

            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }
           //
          //      chart1.Series.Add("INDIRIMSIZ");
          
            chart1.Series["SATIS"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chart1.Series["INDIRIMSIZ"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chart1.Series["INDIRIMSIZ"].BorderWidth = 3;
            chart1.Series["SATIS"].BorderWidth = 3;
            chart1.Series["INDIRIMSIZ"].LegendText = "İndirimsiz Satılanlar";
            chart1.Series["SATIS"].LegendText = "İndirimli Satılanlar";
            chart1.Series["INDIRIMSIZ"].IsVisibleInLegend = true;
            for (int i = 0; i < toplamSatisList.Count; i++)
            {
                chart1.Series["INDIRIMSIZ"].Points.Add(Math.Round(toplamSatisList[i].Indirimsiz,2));
                chart1.Series["SATIS"].Points.Add(Math.Round(toplamSatisList[i].Indirimli,2));
                chart1.Series["SATIS"].Points[i].AxisLabel = toplamSatisList[i].Tarih.Split(' ')[0];
               
                chart1.Series["SATIS"].Points[i].Color = Color.Blue;
                chart1.Series["SATIS"].Points[i].LabelForeColor = Color.Blue;
                chart1.Series["SATIS"].Points[i].Font = new System.Drawing.Font("Times", 14f,FontStyle.Bold);
                chart1.Series["INDIRIMSIZ"].Points[i].Color = Color.Red;
                chart1.Series["INDIRIMSIZ"].Points[i].LabelForeColor = Color.Red;
                chart1.Series["INDIRIMSIZ"].Points[i].Font = new System.Drawing.Font("Times", 14f, FontStyle.Bold);

            }



            chart1.Series[0].LabelForeColor = Color.Black;

        }
        private void toplamUrunMiktari()
        {
            int toplamKg=0;
            toplamSatisList = querry.toplamUrunListesi(Int32.Parse(gosterilecekUrunSayisi.Value.ToString()),baslangicTarihi.Text, bitisTarihi.Text);

            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }

            chart1.Series["SATIS"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            chart1.Series["SATIS"].LegendText = "Satılan Miktar";
            chart1.Series["INDIRIMSIZ"].IsVisibleInLegend = false;
            for (int i = 0; i < toplamSatisList.Count; i++)
            {
                chart1.Series["SATIS"].Points.Add(toplamSatisList[i].ToplamUrunMiktari);

                chart1.Series["SATIS"].Points[i].Label = toplamSatisList[i].ToplamUrunMiktari.ToString();
                chart1.Series["SATIS"].Points[i].LabelForeColor = Color.Red;
                chart1.Series["SATIS"].Points[i].AxisLabel= toplamSatisList[i].UrunAdi;
                chart1.Series["SATIS"].Points[i].Color = Color.Blue;
                chart1.Series["SATIS"].Points[i].LabelForeColor = Color.Blue;
                chart1.Series["SATIS"].Points[i].Font = new System.Drawing.Font("Times", 14f, FontStyle.Bold);

                try
                {
                    if (int.Parse(toplamSatisList[i].BarkodNo) <= 1000)//kofte barkode
                    {

                        toplamKg += (toplamSatisList[i].ToplamUrunMiktari * int.Parse(toplamSatisList[i].BarkodNo));

                    }
                }
                catch (Exception)
                {

                   
                }
               

            }
            labelKg.Text = toplamKg.ToString() ;


            chart1.Series[0].LabelForeColor = Color.Black;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            chart1.Visible = true;
            if (comboBox1.SelectedIndex == 0)
            {
                toplamSatisRaporlama();
            }else if (comboBox1.SelectedIndex == 1)
            {
                toplamUrunMiktari();
            }
            /*foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }
       
            for (int i = 0; i <stoklist.Count ; i++)
            {
                chart1.Series["STOK"].Points.Add(stoklist[i].getToplamMiktar());
               chart1.Series["STOK"].Points[i].AxisLabel = stoklist[i].getUrunAdi();
               chart1.Series["STOK"].Points[i].Label= stoklist[i].getUrunAdi();


                if (stoklist[i].getToplamMiktar()>30)
                {
                    chart1.Series["STOK"].Points[i].Color = Color.Aqua;
                }
                else
                {
                    chart1.Series["STOK"].Points[i].Color = Color.Red;

                }
            }
          


            */
            chart1.ChartAreas[0].AxisX.LabelStyle.Angle = -55;

        }

        private void Rapor_Load(object sender, EventArgs e)
        {
            stoklist = querry.stokListesi(0,"");
            //   toplamSatisList = querry.toplamSatisListesi();b
            baslangicTarihi.Value = DateTime.Today.AddDays(-7);
            chart1.Visible = false;
            chart1.Width = this.Width;
            comboBox1.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           gosterilecekUrunSayisi.Visible = comboBox1.SelectedIndex == 1;
            button1.PerformClick();
          
        }

        private void Rapor_Resize(object sender, EventArgs e)
        {
           // chart1.Width = this.Width;
        }
    }
}
