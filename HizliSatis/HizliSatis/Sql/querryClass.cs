using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Globalization;
using System.IO;
using System.Drawing;
using System.Windows.Forms;

namespace HizliSatis
{
    #region YAZILIMCI BİLGİSİ
    /// <summary>
    /// Bu proje Abdurrahman KAYAHAN tarafından yazılmıştır
    /// 
    /// </summary>

    #endregion

    class querryClass
    {
        // SqlConnection con = new SqlConnection();
        ConnectionClass dataCon = new ConnectionClass();

        public querryClass()
        {

        }

        public Boolean insertUser(Models.userModel userModel)
        {
            try
            {

                //   MessageBox.Show(faturaToStokModel.FaturaId + " " + faturaToStokModel.StokId + " " + faturaToStokModel.Adet);
                SqlCommand cmd = new SqlCommand();

                if (dataCon.con.State == ConnectionState.Closed)
                {
                    dataCon.con.Open();
                }
                cmd.Connection = dataCon.con;
                cmd.CommandText = "insert into UserTable(userName,password) values (@kullaniciAdi,@sifre)";
                cmd.Parameters.AddWithValue("@kullaniciAdi", userModel.KullaniciAdi);
                cmd.Parameters.AddWithValue("@sifre", userModel.Sifre);//


                cmd.ExecuteNonQuery();
                dataCon.con.Close();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return false;
            }

        }
        public Boolean LoginUser(Models.userModel userModel)
        {

            try
            {
                //   MessageBox.Show(faturaToStokModel.FaturaId + " " + faturaToStokModel.StokId + " " + faturaToStokModel.Adet);
                SqlCommand cmd = new SqlCommand();
                SqlDataReader dr;
                if (dataCon.con.State == ConnectionState.Closed)
                {
                    dataCon.con.Open();
                }
                cmd.Connection = dataCon.con;
                cmd.CommandText = "select * from UserTable   WHERE   userName Collate SQL_Latin1_General_CP1254_CS_AS = @kullaniciAdi  and password Collate SQL_Latin1_General_CP1254_CS_AS = @sifre";
                cmd.Parameters.AddWithValue("@kullaniciAdi", userModel.KullaniciAdi);
                cmd.Parameters.AddWithValue("@sifre", userModel.Sifre);


                dr = cmd.ExecuteReader();

                if (dr.Read())
                {

                    dataCon.con.Close();
                    return true;
                }
                dr.Close();
                return false;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return false;
            }

        }




        public List<Models.stokModel> stokListesi(int type, string search)
        {
            List<Models.stokModel> stokList = new List<Models.stokModel>();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader;

            cmd.CommandText = "select StokTable.id,StokTable.barkodNo,StokTable.urunAdi,TedarikciTable.ticariUnvan,StokTable.sonKulTrh,BirimTable.birimAdi,StokTable.miktar,BirimTable.birimAdet,StokTable.toplamMiktar, (StokTable.adetFiyati * BirimTable.birimAdet) as birimFiyati, StokTable.adetFiyati, StokTable.kdv, StokTable.satisFiyati, StokTable.image from StokTable join TedarikciTable on StokTable.tedarikciId = TedarikciTable.id join BirimTable on StokTable.birimId = BirimTable.id";
            if (type == 1)
            {
                cmd.CommandText += " where StokTable.barkodNo LIKE '%" + search + "%'";

            }
            else if (type == 2)
            {
                cmd.CommandText += " where StokTable.urunAdi LIKE '%" + search + "%'";
            }

            cmd.CommandType = CommandType.Text;
            cmd.Connection = dataCon.con;


            if (dataCon.con.State == ConnectionState.Closed)
            {

                dataCon.con.Open();

            }
            string sonuc = "";

            string barkodNo = "";
            string urunAdi = "";
            string ticariUnvan = "";
            string sonKulTrh = "";
            string birimAdi = "";
            int miktar = 0;
            int toplamMiktar = 0;
            int birimAdet = 0;
            float kdv = 0;
            float birimFiyat = 0;
            float birimAdetFiyat = 0;
            float satisFiyati = 0;
            byte[] image = null;
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {

                sonuc = (String.Format("{0}", reader["id"]));
                int id = Convert.ToInt32(sonuc);
                barkodNo = (String.Format("{0}", reader["barkodNo"]));
                urunAdi = (String.Format("{0}", reader["urunAdi"]));
                sonKulTrh = (String.Format("{0}", reader["sonKulTrh"])).Split(' ')[0];
                miktar = Convert.ToInt32(String.Format("{0}", reader["miktar"]));
                toplamMiktar = Convert.ToInt32(String.Format("{0}", reader["toplamMiktar"]));
                birimAdet = Convert.ToInt32(String.Format("{0}", reader["birimAdet"]));
                birimAdi = String.Format("{0}", reader["birimAdi"]);
                ticariUnvan = String.Format("{0}", reader["ticariUnvan"]);
                kdv = float.Parse(String.Format("{0}", reader["kdv"]));
                birimFiyat = float.Parse(String.Format("{0}", reader["birimFiyati"]));
                birimAdetFiyat = float.Parse(String.Format("{0}", reader["adetFiyati"]));
                satisFiyati = float.Parse(String.Format("{0}", reader["satisFiyati"]));
                image = (byte[])reader["image"];
                Models.stokModel stokObj = new Models.stokModel(id, barkodNo, urunAdi, ticariUnvan, sonKulTrh, birimAdi, miktar, birimAdet, toplamMiktar, kdv, birimFiyat, birimAdetFiyat, satisFiyati, image);

                stokList.Add(stokObj);
                //settingsCihazMarkaCombo.Items.Add(sonuc1);

            }
            //textBox1.Text = sonuc + "  " + sonuc1;
            dataCon.con.Close();
            return stokList;
        }


        public Boolean insertStok(Models.stokModel stokModel, int birimId, int tedarikciId)
        {
            try
            {

                SqlCommand cmd = new SqlCommand();

                if (dataCon.con.State == ConnectionState.Closed)
                {

                    dataCon.con.Open();

                }
                cmd.Connection = dataCon.con;
                cmd.CommandText = "insert into StokTable(barkodNo,urunAdi,tedarikciId,sonKulTrh,birimId,miktar,adetFiyati,kdv,satisFiyati,toplamMiktar,image) values (@barkodNo,@urunAdi,@tedarikciId,@sonKulTrh,@birimId,@miktar,@adetFiyati,@kdv,@satisFiyati,@toplamMiktar,@image)";
                cmd.Parameters.AddWithValue("@barkodNo", stokModel.getBarkodNo());
                cmd.Parameters.AddWithValue("@urunAdi", stokModel.getUrunAdi());
                cmd.Parameters.AddWithValue("@tedarikciId", tedarikciId);//
                cmd.Parameters.AddWithValue("@sonKulTrh", stokModel.getSonKulTrh());
                cmd.Parameters.AddWithValue("@birimId", birimId);//
                cmd.Parameters.AddWithValue("@miktar", stokModel.getMiktar());
                cmd.Parameters.AddWithValue("@kdv", stokModel.getKdv());
                cmd.Parameters.AddWithValue("@adetFiyati", stokModel.getBirimAdetFiyat());//
                cmd.Parameters.AddWithValue("@satisFiyati", stokModel.getSatisFiyati());//
                cmd.Parameters.AddWithValue("@toplamMiktar", stokModel.getMiktar() * stokModel.getBirimAdet());//
                cmd.Parameters.AddWithValue("@image", stokModel.getImage());

                cmd.ExecuteNonQuery();
                dataCon.con.Close();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return false;
            }

        }

        public List<Models.birimModel> birimListesi()
        {
            List<Models.birimModel> birimList = new List<Models.birimModel>();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader;

            cmd.CommandText = "Select * from BirimTable order by id asc";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = dataCon.con;


            if (dataCon.con.State == ConnectionState.Closed)
            {

                dataCon.con.Open();

            }
            string sonuc = "";

            string birimAdi = "";
            int birimAdet = 0;


            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                sonuc = (String.Format("{0}", reader["id"]));
                int id = Convert.ToInt32(sonuc);
                birimAdi = (String.Format("{0}", reader["birimAdi"]));
                birimAdet = Convert.ToInt32((String.Format("{0}", reader["birimAdet"])));


                Models.birimModel birimObj = new Models.birimModel(id, birimAdi, birimAdet);
                birimList.Add(birimObj);
                //settingsCihazMarkaCombo.Items.Add(sonuc1);

            }
            //textBox1.Text = sonuc + "  " + sonuc1;
            dataCon.con.Close();
            return birimList;
        }

        public List<Models.tedarikciModel> tedarikciListesi()
        {
            List<Models.tedarikciModel> tedarikciList = new List<Models.tedarikciModel>();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader;
            cmd.CommandText = "Select TedarikciTable.id,ticariUnvan,yetkili,IletisimToTedarikci.id as 'iletisimTableId' ,iletisimId,tedarikciId,value from TedarikciTable left join IletisimToTedarikci on tedarikciId=TedarikciTable.id  order by TedarikciTable.id asc";
            // cmd.CommandText = "Select * from TedarikciTable order by id asc";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = dataCon.con;


            if (dataCon.con.State == ConnectionState.Closed)
            {

                dataCon.con.Open();

            }
            string sonuc = "";

            string ticariUnvan = "";
            string yetkili = "";


            reader = cmd.ExecuteReader();
            int tempId = -1;
            int tedarikciId = -1;
            int iletisimId = -1;
            int iletisimTableId = -1;
            string value = "";

            while (reader.Read())
            {

                sonuc = (String.Format("{0}", reader["id"]));
                int id = Convert.ToInt32(sonuc);
                if (reader["tedarikciId"].ToString() != "")
                {
                    tedarikciId = Convert.ToInt32((String.Format("{0}", reader["tedarikciId"])));
                }
                else
                    tedarikciId = -9;
                if (tempId != tedarikciId)
                {
                    ticariUnvan = (String.Format("{0}", reader["ticariUnvan"]));
                    yetkili = (String.Format("{0}", reader["yetkili"]));
                    tempId = id;
                    List<Models.iletisimToTedarikciModel> tedarikciIletisimList = new List<Models.iletisimToTedarikciModel>();
                    if (tedarikciId != -9)
                    {
                        iletisimId = Convert.ToInt32((String.Format("{0}", reader["iletisimId"])));
                        iletisimTableId = Convert.ToInt32((String.Format("{0}", reader["iletisimTableId"])));
                        value = (String.Format("{0}", reader["value"]));
                        Models.iletisimToTedarikciModel iletisimModel = new Models.iletisimToTedarikciModel(iletisimTableId, iletisimId, tedarikciId, value);
                        tedarikciIletisimList.Add(iletisimModel);
                    }

                    Models.tedarikciModel tedarikciObj = new Models.tedarikciModel(id, ticariUnvan, yetkili, tedarikciIletisimList);
                    tedarikciList.Add(tedarikciObj);
                }
                else if (tedarikciId != -9)
                {
                    iletisimId = Convert.ToInt32((String.Format("{0}", reader["iletisimId"])));
                    value = (String.Format("{0}", reader["value"]));
                    iletisimTableId = Convert.ToInt32((String.Format("{0}", reader["iletisimTableId"])));
                    Models.iletisimToTedarikciModel iletisimModel = new Models.iletisimToTedarikciModel(iletisimTableId, iletisimId, tedarikciId, value);
                    tedarikciList[tedarikciList.Count - 1].IletisimBilgisi.Add(iletisimModel);

                }

            }
            //textBox1.Text = sonuc + "  " + sonuc1;
            dataCon.con.Close();
            return tedarikciList;
        }

        public List<Models.tedarikciModel> tedarikciSearch(string search)
        {
            List<Models.tedarikciModel> tedarikciList = new List<Models.tedarikciModel>();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader;
            cmd.CommandText = "Select TedarikciTable.id,ticariUnvan,yetkili,IletisimToTedarikci.id as 'iletisimTableId' ,iletisimId,tedarikciId,value from TedarikciTable left join IletisimToTedarikci on tedarikciId=TedarikciTable.id  where ticariUnvan LIKE '%" + search + "%' order by TedarikciTable.id asc";
            // cmd.CommandText = "Select * from TedarikciTable order by id asc";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = dataCon.con;


            if (dataCon.con.State == ConnectionState.Closed)
            {

                dataCon.con.Open();

            }
            string sonuc = "";

            string ticariUnvan = "";
            string yetkili = "";


            reader = cmd.ExecuteReader();
            int tempId = -1;
            int tedarikciId = -1;
            int iletisimId = -1;
            int iletisimTableId = -1;
            string value = "";

            while (reader.Read())
            {

                sonuc = (String.Format("{0}", reader["id"]));
                int id = Convert.ToInt32(sonuc);
                if (reader["tedarikciId"].ToString() != "")
                {
                    tedarikciId = Convert.ToInt32((String.Format("{0}", reader["tedarikciId"])));
                }
                else
                    tedarikciId = -9;
                if (tempId != tedarikciId)
                {
                    ticariUnvan = (String.Format("{0}", reader["ticariUnvan"]));
                    yetkili = (String.Format("{0}", reader["yetkili"]));
                    tempId = id;
                    List<Models.iletisimToTedarikciModel> tedarikciIletisimList = new List<Models.iletisimToTedarikciModel>();
                    if (tedarikciId != -9)
                    {
                        iletisimId = Convert.ToInt32((String.Format("{0}", reader["iletisimId"])));
                        iletisimTableId = Convert.ToInt32((String.Format("{0}", reader["iletisimTableId"])));
                        value = (String.Format("{0}", reader["value"]));
                        Models.iletisimToTedarikciModel iletisimModel = new Models.iletisimToTedarikciModel(iletisimTableId, iletisimId, tedarikciId, value);
                        tedarikciIletisimList.Add(iletisimModel);
                    }

                    Models.tedarikciModel tedarikciObj = new Models.tedarikciModel(id, ticariUnvan, yetkili, tedarikciIletisimList);
                    tedarikciList.Add(tedarikciObj);
                }
                else if (tedarikciId != -9)
                {
                    iletisimId = Convert.ToInt32((String.Format("{0}", reader["iletisimId"])));
                    value = (String.Format("{0}", reader["value"]));
                    iletisimTableId = Convert.ToInt32((String.Format("{0}", reader["iletisimTableId"])));
                    Models.iletisimToTedarikciModel iletisimModel = new Models.iletisimToTedarikciModel(iletisimTableId, iletisimId, tedarikciId, value);
                    tedarikciList[tedarikciList.Count - 1].IletisimBilgisi.Add(iletisimModel);

                }

            }
            //textBox1.Text = sonuc + "  " + sonuc1;
            dataCon.con.Close();
            return tedarikciList;
        }


        public List<Models.iletisimModel> iletisimListesi()
        {
            List<Models.iletisimModel> iletisimList = new List<Models.iletisimModel>();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader;

            cmd.CommandText = "Select * from IletisimTable order by id asc";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = dataCon.con;


            if (dataCon.con.State == ConnectionState.Closed)
            {

                dataCon.con.Open();

            }
            string sonuc = "";

            string iletisimTipi = "";



            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                sonuc = (String.Format("{0}", reader["id"]));
                int id = Convert.ToInt32(sonuc);
                iletisimTipi = (String.Format("{0}", reader["iletisimTipi"]));
                int multiLine = Convert.ToInt32((String.Format("{0}", reader["multiLine"])));


                Models.iletisimModel iletisimObj = new Models.iletisimModel(id, iletisimTipi, multiLine);
                iletisimList.Add(iletisimObj);
                //settingsCihazMarkaCombo.Items.Add(sonuc1);

            }
            //textBox1.Text = sonuc + "  " + sonuc1;
            dataCon.con.Close();
            return iletisimList;
        }


        public Boolean updateStok(Models.stokModel stokModel, int birimId, int tedarikciId)
        {
            try
            {

                SqlCommand cmd = new SqlCommand();

                if (dataCon.con.State == ConnectionState.Closed)
                {

                    dataCon.con.Open();

                }
                cmd.Connection = dataCon.con;
                cmd.CommandText = "update StokTable set barkodNo=@barkodNo,urunAdi=@urunAdi,tedarikciId=@tedarikciId,sonKulTrh=@sonKulTrh,birimId=@birimId,miktar=@miktar,adetFiyati=@adetFiyati,kdv=@kdv,satisFİyati=@satisFiyati,toplamMiktar=@toplamMiktar,image=@image where id=@id";
                cmd.Parameters.AddWithValue("@id", stokModel.getId());
                cmd.Parameters.AddWithValue("@barkodNo", stokModel.getBarkodNo());
                cmd.Parameters.AddWithValue("@urunAdi", stokModel.getUrunAdi());
                cmd.Parameters.AddWithValue("@tedarikciId", tedarikciId);//
                cmd.Parameters.AddWithValue("@sonKulTrh", stokModel.getSonKulTrh());
                cmd.Parameters.AddWithValue("@birimId", birimId);//
                cmd.Parameters.AddWithValue("@miktar", stokModel.getMiktar());
                cmd.Parameters.AddWithValue("@kdv", stokModel.getKdv());
                cmd.Parameters.AddWithValue("@adetFiyati", stokModel.getBirimAdetFiyat());//
                cmd.Parameters.AddWithValue("@satisFiyati", stokModel.getSatisFiyati());//
                cmd.Parameters.AddWithValue("@toplamMiktar", stokModel.getMiktar() * stokModel.getBirimAdet());//
                cmd.Parameters.AddWithValue("@image", stokModel.getImage());

                cmd.ExecuteNonQuery();
                dataCon.con.Close();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return false;
            }
        }

        public Boolean updateStokAmount(Models.stokModel stokModel, int amount)
        {
            try
            {

                SqlCommand cmd = new SqlCommand();

                if (dataCon.con.State == ConnectionState.Closed)
                {

                    dataCon.con.Open();

                }
                cmd.Connection = dataCon.con;
                cmd.CommandText = "update StokTable set toplamMiktar=@toplamMiktar where id=@id";
                cmd.Parameters.AddWithValue("@id", stokModel.getId());
                cmd.Parameters.AddWithValue("@toplamMiktar", amount);


                cmd.ExecuteNonQuery();
                dataCon.con.Close();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return false;
            }
        }
        public Boolean deleteStok(int stokId)
        {
            try
            {

                SqlCommand cmd = new SqlCommand();

                if (dataCon.con.State == ConnectionState.Closed)
                {

                    dataCon.con.Open();

                }
                cmd.Connection = dataCon.con;
                cmd.CommandText = "delete from StokTable where id=@id";
                cmd.Parameters.AddWithValue("@id", stokId);

                cmd.ExecuteNonQuery();
                dataCon.con.Close();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return false;
            }
        }

        public List<Models.musteriModel> musteriListesi()
        {
            List<Models.musteriModel> musteriList = new List<Models.musteriModel>();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader;

            cmd.CommandText = "Select MusteriTable.id, adi,soyadi,vergiNo,vergiDairesi,indirimOrani,IletisimToMusteri.id as 'iletisimTableId' ,iletisimId,musteriId,value from MusteriTable left join IletisimToMusteri on musteriId=MusteriTable.id  order by MusteriTable.id asc";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = dataCon.con;


            if (dataCon.con.State == ConnectionState.Closed)
            {

                dataCon.con.Open();

            }
            string sonuc = "";

            string adi = "";
            string soyadi = "";
            string vergiNo = "";
            string vergiDairesi = "";
            float indirimOrani = 0;



            reader = cmd.ExecuteReader();
            int tempId = -1;
            int musteriId = -1;
            int iletisimId = -1;
            int iletisimTableId = -1;
            string value = "";

            while (reader.Read())
            {

                sonuc = (String.Format("{0}", reader["id"]));
                int id = Convert.ToInt32(sonuc);
                if (reader["musteriId"].ToString() != "")
                {
                    musteriId = Convert.ToInt32((String.Format("{0}", reader["musteriId"])));
                }
                else
                    musteriId = -9;
                if (tempId != musteriId)
                {
                    adi = (String.Format("{0}", reader["adi"]));
                    soyadi = (String.Format("{0}", reader["soyadi"]));
                    vergiNo = (String.Format("{0}", reader["vergiNo"]));
                    vergiDairesi = (String.Format("{0}", reader["vergiDairesi"]));
                    indirimOrani = float.Parse(String.Format("{0}", reader["indirimOrani"]));
                    tempId = id;
                    List<Models.iletisimToMusteriModel> musteriIletisimList = new List<Models.iletisimToMusteriModel>();
                    if (musteriId != -9)
                    {
                        iletisimId = Convert.ToInt32((String.Format("{0}", reader["iletisimId"])));
                        iletisimTableId = Convert.ToInt32((String.Format("{0}", reader["iletisimTableId"])));
                        value = (String.Format("{0}", reader["value"]));
                        Models.iletisimToMusteriModel iletisimModel = new Models.iletisimToMusteriModel(iletisimTableId, iletisimId, musteriId, value);
                        musteriIletisimList.Add(iletisimModel);
                    }
                    Models.musteriModel musteriObj = new Models.musteriModel(id, adi, soyadi, vergiNo, vergiDairesi, indirimOrani, musteriIletisimList);
                    musteriList.Add(musteriObj);
                }
                else if (musteriId != -9)
                {
                    iletisimId = Convert.ToInt32((String.Format("{0}", reader["iletisimId"])));
                    value = (String.Format("{0}", reader["value"]));
                    iletisimTableId = Convert.ToInt32((String.Format("{0}", reader["iletisimTableId"])));
                    Models.iletisimToMusteriModel iletisimModel = new Models.iletisimToMusteriModel(iletisimTableId, iletisimId, musteriId, value);
                    musteriList[musteriList.Count - 1].IletisimBilgisi.Add(iletisimModel);

                }



                //settingsCihazMarkaCombo.Items.Add(sonuc1);

            }
            //textBox1.Text = sonuc + "  " + sonuc1;
            dataCon.con.Close();
            return musteriList;
        }

        public Boolean insertFaturaToStok(Models.faturaToStokModel faturaToStokModel)
        {
            try
            {

                //   MessageBox.Show(faturaToStokModel.FaturaId + " " + faturaToStokModel.StokId + " " + faturaToStokModel.Adet);
                SqlCommand cmd = new SqlCommand();

                if (dataCon.con.State == ConnectionState.Closed)
                {
                    dataCon.con.Open();
                }
                cmd.Connection = dataCon.con;
                cmd.CommandText = " Begin transaction  Declare @toplamMiktar int; " +
                " insert into FaturaToStok(faturaId, stokId, adet) values(@faturaId, @stokId, @adet) " +
                " Set @toplamMiktar = (Select toplamMiktar from StokTable where id = @stokId); " +
                " update StokTable set toplamMiktar = @toplamMiktar - @adet where id = @stokId; " +
                " SELECT MAX(id) AS id FROM FaturaToStok commit";
                cmd.Parameters.AddWithValue("@faturaId", faturaToStokModel.FaturaId);
                cmd.Parameters.AddWithValue("@stokId", faturaToStokModel.StokId);
                cmd.Parameters.AddWithValue("@adet", faturaToStokModel.Adet);//

                SqlDataReader reader = cmd.ExecuteReader();
                int id = -1;
                while (reader.Read())
                {

                    id = Convert.ToInt32((String.Format("{0}", reader["id"])));

                }
                dataCon.con.Close();
                faturaToStokModel.Id = id;
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return false;
            }

        }

        public List<Models.faturaToStokModel> faturaToStokListesi(int faturaId)
        {
            List<Models.faturaToStokModel> faturaToStokList = new List<Models.faturaToStokModel>();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader;

            cmd.CommandText = "Select * from FaturaToStok where faturaId=@faturaId ";
            cmd.Parameters.AddWithValue("@faturaId", faturaId);
            cmd.CommandType = CommandType.Text;
            cmd.Connection = dataCon.con;


            if (dataCon.con.State == ConnectionState.Closed)
            {

                dataCon.con.Open();

            }


            string Id = "";
            int stokId = 0;
            int adet = 0;




            reader = cmd.ExecuteReader();

            while (reader.Read())
            {

                Id = (String.Format("{0}", reader["id"]));
                int id = Convert.ToInt32(Id);

                stokId = Int32.Parse(String.Format("{0}", reader["stokId"]));
                adet = Int32.Parse(String.Format("{0}", reader["adet"]));




                Models.faturaToStokModel faturaToStokModel = new Models.faturaToStokModel(id, faturaId, stokId, adet);
                faturaToStokList.Add(faturaToStokModel);





                //settingsCihazMarkaCombo.Items.Add(sonuc1);

            }
            //textBox1.Text = sonuc + "  " + sonuc1;
            dataCon.con.Close();
            return faturaToStokList;
        }

        //TODO: delete fatura to stok  metodunu gözden geçir faturadaki seçilen ürünü kaldırmak için kullanılır.. 
        public Boolean deleteFaturaToStok(Models.faturaToStokModel faturaToStokModel)
        {
            try
            {

                //   MessageBox.Show(faturaToStokModel.FaturaId + " " + faturaToStokModel.StokId + " " + faturaToStokModel.Adet);
                SqlCommand cmd = new SqlCommand();

                if (dataCon.con.State == ConnectionState.Closed)
                {
                    dataCon.con.Open();
                }
                cmd.Connection = dataCon.con;
                cmd.CommandText = " Begin transaction " +
                       " Declare @toplamMiktar int; " +
                       " declare @stokId int; " +
                       " declare @urunMiktar int; " +
                       " set @stokId = (Select FaturaToStok.stokId as StokID from FaturaToStok where id =@tableId); " +
                       " Set @toplamMiktar=( Select toplamMiktar from StokTable where id=@stokId); " +
                       " set @urunMiktar =(Select FaturaToStok.adet as StokID from FaturaToStok where id = @tableId) " +
                       " update StokTable set toplamMiktar=@toplamMiktar+@urunMiktar where id=@stokId; " +
                       " delete FaturaToStok where id = @tableId commit ";
                cmd.Parameters.AddWithValue("@tableId", faturaToStokModel.Id);
                
                cmd.ExecuteNonQuery();
                dataCon.con.Close();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return false;
            }

        }


        public int insertFatura(Models.faturaModel faturaModel)
        {
            try
            {

                SqlCommand cmd = new SqlCommand();

                if (dataCon.con.State == ConnectionState.Closed)
                {

                    dataCon.con.Open();

                }
                cmd.Connection = dataCon.con;
                cmd.CommandText = "insert into FaturaTable(tarih,saat,musteriId,araToplam,indirim,genelToplam,hesapDurum) OUTPUT inserted.id values (@tarih,@saat,@musteriId,@araToplam,@indirim,@genelToplam,@hesapdurum)";
                cmd.Parameters.AddWithValue("@tarih", faturaModel.Tarih);
                cmd.Parameters.AddWithValue("@saat", faturaModel.Saat);
                cmd.Parameters.AddWithValue("@musteriId", faturaModel.MusteriId);//
                cmd.Parameters.AddWithValue("@araToplam", faturaModel.AraToplam);
                cmd.Parameters.AddWithValue("@indirim", faturaModel.Indirim);
                cmd.Parameters.AddWithValue("@genelToplam", faturaModel.GenelToplam);//
                cmd.Parameters.AddWithValue("@hesapdurum", faturaModel.HesapDurum);

                SqlDataReader reader = cmd.ExecuteReader();
                int id = -1;
                while (reader.Read())
                {

                    id = Convert.ToInt32((String.Format("{0}", reader["id"])));

                }
                dataCon.con.Close();
                return id;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return -1;
            }

        }
        public bool updateFatura(Models.faturaModel faturaModel)
        {
            try
            {

                SqlCommand cmd = new SqlCommand();

                if (dataCon.con.State == ConnectionState.Closed)
                {

                    dataCon.con.Open();

                }
                cmd.Connection = dataCon.con;
                cmd.CommandText = "update FaturaTable set araToplam=@araToplam , genelToplam=@genelToplam,hesapDurum=@hesapdurum where id=@FaturaId";
                cmd.Parameters.AddWithValue("@FaturaId", faturaModel.Id);//
                cmd.Parameters.AddWithValue("@araToplam", faturaModel.AraToplam);
                cmd.Parameters.AddWithValue("@genelToplam", faturaModel.GenelToplam);//
                cmd.Parameters.AddWithValue("@hesapdurum", faturaModel.HesapDurum);

                cmd.ExecuteReader();

                dataCon.con.Close();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return false;
            }

        }
        public Boolean deleteFatura(int FaturaId)
        {
            try
            {

                //   MessageBox.Show(faturaToStokModel.FaturaId + " " + faturaToStokModel.StokId + " " + faturaToStokModel.Adet);
                SqlCommand cmd = new SqlCommand();

                if (dataCon.con.State == ConnectionState.Closed)
                {
                    dataCon.con.Open();
                }
                cmd.Connection = dataCon.con;
                cmd.CommandText = "delete FaturaTable where id = @FaturaId ";
                cmd.Parameters.AddWithValue("@FaturaId", FaturaId);


                cmd.ExecuteNonQuery();
                dataCon.con.Close();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return false;
            }

        }

        public Boolean insertMusteri(Models.musteriModel musteri, Models.iletisimBilgisiModel iletisimBilgisi)
        {
            try
            {

                SqlCommand cmd = new SqlCommand();

                if (dataCon.con.State == ConnectionState.Closed)
                {

                    dataCon.con.Open();

                }
                string iletisimVerileri = "";
                //EKLENEN İLETİŞİM BİLGİLERİNİ ALIR TEK SATIR HALİNE GETİRİR
                for (int i = 0; i < iletisimBilgisi.GetEklenenIletisimIdList().Count; i++)
                {
                    if (iletisimBilgisi.GetTextList()[i].ToString() != "")
                        iletisimVerileri += "(" + iletisimBilgisi.GetEklenenIletisimIdList()[i] + ",@DataID,'" + iletisimBilgisi.GetTextList()[i].ToString() + "'),";
                }
                //  (iletisimTpID,müsteriId,"0538.."), (iletisimTpID, müsteriId, "0538.."), (iletisimTpID, müsteriId, "0538.."), (iletisimTpID, müsteriId, "0538.."),
                if (iletisimVerileri.Length > 0)
                    iletisimVerileri = " INSERT INTO IletisimToMusteri(iletisimId, musteriId, value) VALUES" + iletisimVerileri.Substring(0, iletisimVerileri.Length - 1);//Sondaki virgülü siler
                //Bir transaction oluşturduk müşteri eklemede veya müşterinin iletişim bilgisi eklemede bir sıkıntı çıkarsa işlemi olduğu gibi iptal eder
                cmd.Connection = dataCon.con;
                cmd.CommandText = " BEGIN TRANSACTION " +
                       "DECLARE @DataID int" +
                      " INSERT INTO MusteriTable(adi, soyadi, vergiNo, vergiDairesi, indirimOrani) VALUES(@adi,@soyadi,@vergiNo,@vergiDairesi,@indirimOrani)"
                      + " SELECT @DataID = scope_identity()"
                     + iletisimVerileri
                    + " COMMIT";
                cmd.Parameters.AddWithValue("@adi", musteri.Adi);
                cmd.Parameters.AddWithValue("@soyadi", musteri.Soyadi);
                cmd.Parameters.AddWithValue("@vergiNo", musteri.VergiNo);//
                cmd.Parameters.AddWithValue("@vergiDairesi", musteri.VergiDairesi);
                cmd.Parameters.AddWithValue("@indirimOrani", musteri.IndirimOrani);

                cmd.ExecuteNonQuery();
                dataCon.con.Close();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return false;
            }

        }

        public Boolean deleteMusteri(Models.musteriModel musteri)
        {
            try
            {

                SqlCommand cmd = new SqlCommand();

                if (dataCon.con.State == ConnectionState.Closed)
                {

                    dataCon.con.Open();

                }
                //Bir transaction oluşturduk müşteri eklemede veya müşterinin iletişim bilgisi eklemede bir sıkıntı çıkarsa işlemi olduğu gibi iptal eder
                cmd.Connection = dataCon.con;
                cmd.CommandText =
                    " delete from IletisimToMusteri where musteriId= @DataID "
                       + " delete from MusteriTable where id= @DataID ";

                cmd.Parameters.AddWithValue("@DataID", musteri.Id);



                cmd.ExecuteNonQuery();
                dataCon.con.Close();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return false;
            }

        }

        public Boolean insertTedarikci(Models.tedarikciModel tedarikci, Models.iletisimBilgisiModel iletisimBilgisi)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                if (dataCon.con.State == ConnectionState.Closed)
                {

                    dataCon.con.Open();

                }
                string iletisimVerileri = "";
                //EKLENEN İLETİŞİM BİLGİLERİNİ ALIR TEK SATIR HALİNE GETİRİR
                for (int i = 0; i < iletisimBilgisi.GetEklenenIletisimIdList().Count; i++)
                {
                    if (iletisimBilgisi.GetTextList()[i].ToString() != "")
                        iletisimVerileri += "(" + iletisimBilgisi.GetEklenenIletisimIdList()[i] + ",@DataID,'" + iletisimBilgisi.GetTextList()[i].ToString() + "'),";
                }
                //  (iletisimTpID,müsteriId,"0538.."), (iletisimTpID, müsteriId, "0538.."), (iletisimTpID, müsteriId, "0538.."), (iletisimTpID, müsteriId, "0538.."),
                if (iletisimVerileri.Length > 0)
                    iletisimVerileri = " INSERT INTO IletisimToTedarikci(iletisimId, tedarikciId, value) VALUES" + iletisimVerileri.Substring(0, iletisimVerileri.Length - 1);//Sondaki virgülü siler
                //Bir transaction oluşturduk müşteri eklemede veya müşterinin iletişim bilgisi eklemede bir sıkıntı çıkarsa işlemi olduğu gibi iptal eder
                cmd.Connection = dataCon.con;
                cmd.CommandText = " BEGIN TRANSACTION " +
                       "DECLARE @DataID int" +
                      " INSERT INTO TedarikciTable(ticariUnvan,yetkili) VALUES(@ticariUnvan,@yetkili)"
                      + " SELECT @DataID = scope_identity()"
                     + iletisimVerileri
                    + " COMMIT";
                cmd.Parameters.AddWithValue("@ticariUnvan", tedarikci.TicariUnvan);
                cmd.Parameters.AddWithValue("@yetkili", tedarikci.Yetkili);


                cmd.ExecuteNonQuery();
                dataCon.con.Close();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return false;
            }

        }

        public Boolean UpdateTedarikci(Models.tedarikciModel tedarikci)
        {           
            
            try
            {
                SqlCommand cmd = new SqlCommand();

                if (dataCon.con.State == ConnectionState.Closed)
                {

                    dataCon.con.Open();
                   
                }
                string iletisimVerileri = "";
                //EKLENEN İLETİŞİM BİLGİLERİNİ ALIR TEK SATIR HALİNE GETİRİR
                for (int i = 0; i < tedarikci.IletisimBilgisi.Count; i++)
                {
                    if (tedarikci.IletisimBilgisi[i].Value.ToString() != "")
                    {
                        //update
                        iletisimVerileri += " Update IletisimToTedarikci Set iletisimId='" + tedarikci.IletisimBilgisi[i].IletisimId + "', value='"+tedarikci.IletisimBilgisi[i].Value.ToString() + "' where id='"+ tedarikci.IletisimBilgisi[i].Id.ToString() + "'; ";
                        
                    }
                    else
                    {
                        //delete
                        iletisimVerileri += " delete IletisimToTedarikci where id=" + tedarikci.IletisimBilgisi[i].Id.ToString() + "; ";

                    }
                }

                cmd.Connection = dataCon.con;


                cmd.CommandText =" UPDATE TedarikciTable SET  ticariUnvan=@ticariUnvan,yetkili=@yetkili  where id=@id; "
                     + iletisimVerileri;

                cmd.Parameters.AddWithValue("@id", tedarikci.getId());
                cmd.Parameters.AddWithValue("@ticariUnvan", tedarikci.TicariUnvan);
                cmd.Parameters.AddWithValue("@yetkili", tedarikci.Yetkili);


                cmd.ExecuteNonQuery();
                dataCon.con.Close();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return false;
            }

        }





        public Boolean deleteTedarikci(Models.tedarikciModel tedarikci)
        {
            try
            {

                SqlCommand cmd = new SqlCommand();

                if (dataCon.con.State == ConnectionState.Closed)
                {

                    dataCon.con.Open();

                }
                //Bir transaction oluşturduk müşteri eklemede veya müşterinin iletişim bilgisi eklemede bir sıkıntı çıkarsa işlemi olduğu gibi iptal eder
                cmd.Connection = dataCon.con;
                cmd.CommandText =
                    " delete from IletisimToTedarikci where tedarikciId= @DataID "
                       + " delete from TedarikciTable where id= @DataID ";

                cmd.Parameters.AddWithValue("@DataID", tedarikci.getId());



                cmd.ExecuteNonQuery();
                dataCon.con.Close();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return false;
            }

        }
        //Select HizliSatisToUrunTable.id, HizliSatisToUrunTable.urunId, StokTable.urunAdi from HizliSatisToUrunTable JOIN StokTable on  StokTable.id=HizliSatisToUrunTable.urunId

        public List<Models.hizliSatisToUrunModel> hizlisatisList()
        {
            List<Models.hizliSatisToUrunModel> hizlisatisList = new List<Models.hizliSatisToUrunModel>();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader;

            cmd.CommandText = "Select HizliSatisToUrunTable.id, HizliSatisToUrunTable.urunId, StokTable.urunAdi, StokTable.barkodNo, StokTable.toplamMiktar, StokTable.image from HizliSatisToUrunTable JOIN StokTable on  StokTable.id=HizliSatisToUrunTable.urunId";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = dataCon.con;


            if (dataCon.con.State == ConnectionState.Closed)
            {

                dataCon.con.Open();

            }
            string urunAdi = "";
            string barkodNo = "";
            reader = cmd.ExecuteReader();
            int urunId = -1;
            int toplamMikar = -1;
            byte[] image=null;
            while (reader.Read())
            {



                int id = Convert.ToInt32(String.Format("{0}", reader["id"]));
                urunAdi = (String.Format("{0}", reader["urunAdi"]));
                barkodNo = (String.Format("{0}", reader["barkodNo"]));
                urunId = Convert.ToInt32((String.Format("{0}", reader["urunId"])));
                toplamMikar = Convert.ToInt32((String.Format("{0}", reader["toplamMiktar"])));
                image = (byte[])reader["image"];
                Models.hizliSatisToUrunModel hizliSatisModel = new Models.hizliSatisToUrunModel(id, urunId, urunAdi, barkodNo, toplamMikar,image);
                hizlisatisList.Add(hizliSatisModel);

            }

            dataCon.con.Close();
            return hizlisatisList;
        }


        public Boolean insertHizliSatis(int urunId)
        {

            try
            {

                SqlCommand cmd = new SqlCommand();

                if (dataCon.con.State == ConnectionState.Closed)
                {

                    dataCon.con.Open();

                }
                cmd.Connection = dataCon.con;
                cmd.CommandText = "insert INTO HizliSatisToUrunTable(urunId) values(@urunID)";
                cmd.Parameters.AddWithValue("@urunID", urunId);
                cmd.ExecuteNonQuery();
                dataCon.con.Close();

                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return false;
            }

        }
        public Boolean deleteHizliSatis(int urunId)
        {

            try
            {

                SqlCommand cmd = new SqlCommand();

                if (dataCon.con.State == ConnectionState.Closed)
                {

                    dataCon.con.Open();

                }
                cmd.Connection = dataCon.con;
                cmd.CommandText = "delete HizliSatisToUrunTable where urunId=@urunID";
                cmd.Parameters.AddWithValue("@urunID", urunId);

                cmd.ExecuteNonQuery();
                dataCon.con.Close();

                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return false;
            }

        }

        public List<Models.raporModel> toplamSatisListesi(string baslangic, string bitis)
        {
            List<Models.raporModel> toplamSatisList = new List<Models.raporModel>();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader;

            //cmd.CommandText = "Select tarih, Sum(FaturaTable.genelToplam) Indirimli ," +
            //            " sum(FaturaTable.araToplam) Indirimsiz " +
            //            " from FaturaTable where FaturaTable.tarih " +
            //            " between @baslangicTarihi and @bitisTarihi Group by(tarih)";

            cmd.CommandText = "GetSalesReport";

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@baslangicTarihi", baslangic);
            cmd.Parameters.AddWithValue("@bitisTarihi", bitis);
            cmd.Connection = dataCon.con;


            if (dataCon.con.State == ConnectionState.Closed)
            {

                dataCon.con.Open();

            }
            string tarih = "";
            reader = cmd.ExecuteReader();
            float indrimli = -1;
            float indirimsiz = -1;
            while (reader.Read())
            {

                tarih = (String.Format("{0}", reader["tarih"]));
                indrimli = float.Parse(String.Format("{0}", reader["Indirimli"]));
                indirimsiz = float.Parse(String.Format("{0}", reader["Indirimsiz"]));
                Models.raporModel hizliSatisModel = new Models.raporModel(tarih, indrimli, indirimsiz);
                toplamSatisList.Add(hizliSatisModel);
            }

            dataCon.con.Close();
            return toplamSatisList;
        }

        public List<Models.raporModel> toplamUrunListesi(int urunSayisi, string baslangic, string bitis)
        {
            List<Models.raporModel> toplamSatisList = new List<Models.raporModel>();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader;

            cmd.CommandText = "SELECT top " + urunSayisi + " Sum(adet) ToplamUrunMiktari, StokTable.urunAdi,StokTable.barkodNo" +
                                " FROM    FaturaToStok " +
                                " INNER JOIN StokTable " +
                                " ON FaturaToStok.stokId = StokTable.id " +
                                " where FaturaToStok.faturaId IN " +
                                " (Select FaturaTable.id from FaturaTable where FaturaTable.tarih " +
                                " between @baslangicTarihi and @bitisTarihi) " +
                                " GROUP BY StokTable.id, StokTable.urunAdi,StokTable.barkodNo " +
                                " order by(ToplamUrunMiktari) desc ";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@baslangicTarihi", baslangic);
            cmd.Parameters.AddWithValue("@bitisTarihi", bitis);
            cmd.Connection = dataCon.con;


            if (dataCon.con.State == ConnectionState.Closed)
            {

                dataCon.con.Open();

            }
            string urunAdi = "";
            string bardodNo = "";
            reader = cmd.ExecuteReader();
            int toplamUrunMiktari = -1;
            while (reader.Read())
            {

                urunAdi = (String.Format("{0}", reader["urunAdi"]));
                bardodNo = (String.Format("{0}", reader["barkodNo"]));
                toplamUrunMiktari = Int32.Parse(String.Format("{0}", reader["ToplamUrunMiktari"]));

                Models.raporModel hizliSatisModel = new Models.raporModel(toplamUrunMiktari, urunAdi,bardodNo); toplamSatisList.Add(hizliSatisModel);
            }

            dataCon.con.Close();
            return toplamSatisList;
        }

    }
}