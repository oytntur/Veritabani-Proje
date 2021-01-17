using MetroFramework;
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

namespace Veritabani_Proje
{
    public partial class SatışForm : MetroFramework.Forms.MetroForm
    {
        //sube id çalışanın sadece kendi mağazasını görmesini sağlıcak
        // id ise list viewde çift tıklanılan ürünün direk yukarıya ve urun classına doldurulmasını sağlıcak
        int subeid,id=0;
        string kullaniciTC;
        Urun urun = new Urun();
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;

        public SatışForm(int subeID,string TC)
        {
            InitializeComponent();
            kullaniciTC = TC;
            //List View ürünleri getir
            urun.urunGetir(listView1);
            subeid = subeID;
            con = new SqlConnection("Data Source=DESKTOP-V4OTKFI;Initial Catalog=Market;Integrated Security=True");
        }
        private void metroTile1_Click(object sender, EventArgs e)
        {
            int sayac = 0;
            //Stok Varsa Ürünü Sat
            if (urun.stokKontrol(subeid) != 0)
            {
                try
                {
                    if (urun.Ad == null || urun.Ad == "")
                    {
                        MetroMessageBox.Show(this, "Lütfen Ürünü Şeçiniz");
                        sayac++;
                    }
                    else
                        urun.urunSat(subeid,kullaniciTC);
                }
                catch (Exception hata)
                {
                    MetroMessageBox.Show(this, "Ürün Eklenirken Bir Hata Meydana Geldi\n" + hata);
                    sayac++;
                    throw;
                }
                finally
                {
                    if (sayac == 0)
                    {
                        MetroMessageBox.Show(this, "Satış Başarılı");
                        urun.urunGetir(listView1);

                    }
                }
            }
            else
                MetroMessageBox.Show(this, "Bulunduğunuz Markette Bu Üründen Kalmadı");
            //Stoktan Düş
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void urunBarkod_ButtonClick(object sender, EventArgs e)
        {
            //Veritabanından ürün Bilgisi çekilecek
            cmd = new SqlCommand("SELECT * FROM tblUrun U INNER JOIN tblKategori K on u.kategoriID=K.kategoriID WHERE U.urunBarkod='" + Convert.ToInt32(urunBarkod.Text) + "'", con);
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                urun.Ad = dr["urunAdi"].ToString();
                urun.ID = Convert.ToInt32(dr["urunID"]);
                urun.Fiyat = Convert.ToDouble(dr["urunFiyat"]);
                urun.KategoriAd = dr["kategoriAd"].ToString();
                lblUrunAd.Text= dr["urunAdi"].ToString();
                lblKategoriAd.Text = dr["kategoriAd"].ToString();
                lblFiyat.Text =dr["urunFiyat"].ToString();

            }
            con.Close();
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            id= int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            urun.ID = id;

            lblUrunAd.Text = listView1.SelectedItems[0].SubItems[2].Text;
            urun.Ad = urunAD.Text;

            urunBarkod.Text = listView1.SelectedItems[0].SubItems[1].Text;
            urun.BarkodNo = Convert.ToInt32(urunBarkod.Text);

            lblKategoriAd.Text = listView1.SelectedItems[0].SubItems[3].Text;
            urun.KategoriAd = lblKategoriAd.Text;

            lblFiyat.Text = listView1.SelectedItems[0].SubItems[4].Text;
            urun.Fiyat = Convert.ToDouble(listView1.SelectedItems[0].SubItems[4].Text);
        }
    }
}
