using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Veritabani_Proje
{
    class Market
    {
        SqlCommand cmd;
        SqlDataReader dr;
        SqlConnection con;
        int newid;
        public Market()
        {
            con = new SqlConnection("Data Source=DESKTOP-V4OTKFI;Initial Catalog=Market;Integrated Security=True");
            cmd = new SqlCommand("Select count(*)as Sayi from tblMarket", con);
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                newid = Convert.ToInt32(dr["Sayi"])+1;
            }
            dr.Close();
            con.Close();
        }
        public string Adi { get; set; }
        public string Adresi { get; set; }
        public void marketEkle(string kullaniciTC)
        {
            cmd = new SqlCommand("marketEkle '" + this.Adi + "','" + this.Adresi + "'", con);
            con.Open();
            cmd.ExecuteNonQuery();
            marketStokEkle();
            cmd = new SqlCommand("logOlustur '" + "Market Oluşturma" + "','" + (kullaniciTC + " TCli Kullanıcı Tarafından " + this.Adi + " Adlı Market Eklendi") + "'", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        private void marketStokEkle()
        {
            int sayac=0;
            cmd = new SqlCommand("select count(*) as Sayi from tblUrun", con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                sayac= Convert.ToInt32(dr["Sayi"]);
            }
            dr.Close();
            for (int i = 0; i < sayac; i++)
            {
                cmd = new SqlCommand("INSERT INTO tblMarketStok(urunID,marketID,stokSayisi) VALUES((SELECT urunID FROM tblUrun WHERE siraID='" + (i + 1) + "'),'" + newid + "','" + 0 + "')", con);
                cmd.ExecuteNonQuery();
            }
            
            
        }
    }
}
