using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;

namespace Veritabani_Proje
{
    public partial class ÜrünEkle : MetroFramework.Forms.MetroForm
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        string kullaniciTC;
        public ÜrünEkle(string TC)
        {
            InitializeComponent();
            kullaniciTC = TC;
            //combo boxa kategori getir
            con = new SqlConnection("Data Source=DESKTOP-V4OTKFI;Initial Catalog=Market;Integrated Security=True");
            con.Open();
            cmd = new SqlCommand("SELECT * From tblKategori", con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                metroComboBox1.Items.Add(dr["kategoriAd"]);
            }
            con.Close();
            urun = new Urun();
        }
        Urun urun;
        private void metroTile1_Click(object sender, EventArgs e)
        {
            int sayac = 0;
            try
            {
                urun.Kategori = Convert.ToInt32(metroComboBox1.SelectedIndex+1);
                urun.Ad = urunAd.Text;
                urun.Fiyat = Convert.ToDouble(urunFiyat.Text);
                urun.BarkodNo = Convert.ToInt32(metroTextBox1.Text);
                urun.ID = Convert.ToInt32(metroTextBox2.Text);
                urun.urunEkle(kullaniciTC);
                urun.stokOlustur();
                //veritabanına Ekleme
            }
            catch (Exception hata)
            {
                MetroMessageBox.Show(this, "Ürün Eklenirken Bir Hata Meydana Geldi\n" + hata);
                sayac++;
                throw;
            }
            finally
            {
                if(sayac == 0)
                {
                    MetroMessageBox.Show(this, "Ürün Başarıyla Eklendi");
                    this.Close();
                }
            }
        }
    }
}
