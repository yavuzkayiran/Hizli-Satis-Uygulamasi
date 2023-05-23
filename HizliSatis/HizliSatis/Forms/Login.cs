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
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace HizliSatis
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        querryClass querry = new querryClass();
        private void Form1_Load(object sender, EventArgs e)
        {
            //Data Source=ASUS;database=HizliSatis;Integrated Security=True
            //Data Source=TRTSQL16;database=controlsystem;User ID=ctrlsys;Password=ctrl2017*sys

            // MessageBox.Show("AAAA  " + mq.stokListesi()[0].getUrunAdi());




        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (querry.LoginUser(new Models.userModel(0,userNameText.Text,passwordText.Text)))
            {
                Forms.Main main = new Forms.Main(this);
                 this.Hide();
                 main.ShowDialog();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı Veya Parola Yanlış  Tekrar Deneyin","Hatalı Kullanıcı Girişi ",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
         
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {


            //string filepath = "config.json";
            //string result = string.Empty;
            //using (StreamReader r = new StreamReader(filepath))
            //{
            //    var json = r.ReadToEnd();
            //    var jobj = JObject.Parse(json);
            //    foreach (var item in jobj.Properties())
            //    {
            //        item.Value = item.Value.ToString().Replace("v1", "v2");
            //    }
             
            //    MessageBox.Show(jobj.GetValue("MaximumHizliSatisSayisi").ToString());
            //    jobj["MaximumHizliSatisSayisi"] = 50;
            //     result = jobj.ToString();
            //}
            
            //File.WriteAllText(filepath, result);
        }
    }
}
