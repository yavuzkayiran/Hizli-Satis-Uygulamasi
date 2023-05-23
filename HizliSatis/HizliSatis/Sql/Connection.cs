using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.IO;
using HizliSatis.AppMpdels;
using Newtonsoft.Json.Linq;

namespace HizliSatis
{



    class ConnectionClass
    {

        public SqlConnection con;
        /// <summary>
        /// veritabanı bağlantısı yapmak için kullandığımız sınıfımız
        /// ilgili veritabanı için kullanılan connection string aşağıda tariflenmiştir.
        /// </summary>
        public ConnectionClass() {
            try
            {

                JObject settingsJSON=(JObject) configFile.readConfig();

                //string connString = "Data Source="+ settingsJSON["DataBaseName"].ToString() + ";database=HizliSatis;Integrated Security=True";


                string connString = "Data Source=DESKTOP-87IUBD0;database=HizliSatis;Integrated Security=True";


                this.con = new SqlConnection(@connString);
            }
            catch (Exception e) {
                System.Diagnostics.Debug.WriteLine(e.ToString());
            }
        }


        public SqlConnection conn
        {
            get
            {
                return this.con;
            }
            set
            {
                this.con = value;
            }
        }


    }
}
