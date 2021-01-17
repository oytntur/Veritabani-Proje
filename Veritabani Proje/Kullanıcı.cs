using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Veritabani_Proje
{
    class Kullanıcı
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        
        public Kullanıcı()
        {
            con = new SqlConnection("Data Source=DESKTOP-V4OTKFI;Initial Catalog=Market;Integrated Security=True");
            
        }
        public string Ad { get; set; }
        public string TC { get; set; }
        public string Pozisyon { get; set; }
        public string Password { get; set; }
        public int MarketID { get; set; }

        public void personelEkle(string kullaniciTC)
        {
            cmd = new SqlCommand("INSERT INTO tblKullanicilar(kullanıcıTC,kullanıcıPos,marketID,kullaniciPassword) VALUES('" + this.TC + "','" + this.Pozisyon + "','" + this.MarketID + "','" + this.Password + "')", con);
            con.Open();
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand("logOlustur '" + "Personel Oluşturma" + "','" + (kullaniciTC + " TCli Kullanıcı Tarafından " + this.TC + " TCli Kullanıcı Eklendi") + "'", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void personelGetir(ListView list)
        {
            list.Items.Clear();
            cmd = new SqlCommand("SELECT * FROM personelSilme", con);
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ListViewItem add = new ListViewItem();
                add.Text = dr["ID"].ToString();
                add.SubItems.Add(dr["TC"].ToString());
                add.SubItems.Add(dr["MarketAdı"].ToString());
                add.SubItems.Add(dr["Pozisyon"].ToString());
                list.Items.Add(add);
            }

            dr.Close();
            con.Close();

        }
    }
}
