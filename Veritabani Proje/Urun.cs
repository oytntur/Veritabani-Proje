using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using MetroFramework;

namespace Veritabani_Proje
{
    class Urun
    {
        public int ID { get; set; }
        public string Ad { get; set; }
        public int Kategori { get; set; }
        public string KategoriAd { get; set; }
        public double Fiyat { get; set; }
        public int BarkodNo { get; set; }


        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;

        public Urun()
        {
            con = new SqlConnection("Data Source=DESKTOP-V4OTKFI;Initial Catalog=Market;Integrated Security=True");
        }
       

        public void urunEkle(string kullaniciTC)
        {

            cmd = new SqlCommand("urunEkle '" + this.Ad + "','" + this.Kategori + "','" + this.BarkodNo + "','" + this.Fiyat + "','"+this.ID+"'", con);
            con.Open();
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand("logOlustur '" + "Ürün Oluşturma" + "','" + (kullaniciTC + " TCli Kullanıcı Tarafından " + this.Ad + " Adlı Ürünü Eklendi") + "'", con);
            cmd.ExecuteNonQuery();
            con.Close();
      

        }
        public void fiyatGuncelle(int id,double fiyat, string kullaniciTC,string ad)
        {
            cmd = new SqlCommand("UPDATE tblUrun SET urunFiyat='" + fiyat + "' WHERE siraID='" + id + "'", con);
            con.Open();
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand("logOlustur '" + "Ürün Güncelleme" + "','" + (kullaniciTC + " TCli Kullanıcı Tarafından " + ad + " Adlı Ürünü Güncelledi") + "'", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void stokOlustur()
        {
            int marketCount=0;
            cmd = new SqlCommand("select count (*) as Sayi from tblMarket", con);
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                marketCount = Convert.ToInt32(dr["Sayi"]);
            }
            dr.Close();
            MessageBox.Show(marketCount.ToString());
            for (int i = 0; i < marketCount; i++)
            {
                cmd = new SqlCommand("Insert Into tblMarketStok(urunID,marketID,stokSayisi) values('"+this.ID+"','"+(i+1)+"','"+0+"')", con);
                cmd.ExecuteNonQuery();
            }
            con.Close();
        }
        
        public int stokKontrol(int marketid)
        {
            int dondur=100;
            cmd = new SqlCommand("urunStokKontrol '"+this.ID+"','"+marketid+"'", con);
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                dondur = Convert.ToInt32(dr["stokSayisi"]);
            }
            
            con.Close();
            return dondur;
        }
        public void urunSat(int marketid, string kullaniciTC)
        {
            
            cmd = new SqlCommand("urunStokDegistir '" + this.ID + "','" + marketid + "','" + (-1) + "'", con);
            con.Open();
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand("logOlustur '" + "Ürün Satış" + "','" + (kullaniciTC + " TCli Kullanıcı Tarafından " + this.Ad + " Adlı Ürün Satıldı") + "'", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void urunGetir(ListView list)
        {
            list.Items.Clear();
            cmd = new SqlCommand("SELECT * FROM tblUrun U INNER JOIN tblKategori K on u.kategoriID=K.kategoriID", con);
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ListViewItem add = new ListViewItem();
                add.Text = dr["urunID"].ToString();
                add.SubItems.Add(dr["urunBarkod"].ToString());
                add.SubItems.Add(dr["urunAdi"].ToString());
                add.SubItems.Add(dr["kategoriAd"].ToString());
                add.SubItems.Add(dr["urunFiyat"].ToString());
                list.Items.Add(add);
            }
            
            dr.Close();
            con.Close();

        }

    }
}
