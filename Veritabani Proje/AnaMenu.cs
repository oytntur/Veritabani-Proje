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
    public partial class AnaMenu : MetroFramework.Forms.MetroForm
    {
        int id = 0;
        string kullaniciTC;
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        public AnaMenu(int subeid,string TC)
        {
            InitializeComponent();
            id = subeid;
            kullaniciTC = TC;
            con = new SqlConnection("Data Source=DESKTOP-V4OTKFI;Initial Catalog=Market;Integrated Security=True");

        }

        private void UpdatePriceBtn_Click(object sender, EventArgs e)
        {
            FiyatGüncelle yeni = new FiyatGüncelle(kullaniciTC);
            yeni.ShowDialog();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            MarketEkle yeni = new MarketEkle(kullaniciTC);
            yeni.ShowDialog();
        }

        private void metroTile5_Click(object sender, EventArgs e)
        {
            StokEkle yeni = new StokEkle(kullaniciTC);
            yeni.ShowDialog();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            SatışForm yeni = new SatışForm(id, kullaniciTC);
            //this.Close();
            yeni.Show();
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            ÜrünEkle yeni = new ÜrünEkle(kullaniciTC);
            yeni.ShowDialog();
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            StokKontrol yeni = new StokKontrol();
            yeni.Show();
        }

        private void metroTile7_Click(object sender, EventArgs e)
        {
            personelForm personelForm = new personelForm(kullaniciTC);
            personelForm.Show();
        }

        private void metroTile6_Click(object sender, EventArgs e)
        {
            MarketForm marketForm = new MarketForm();
            marketForm.Show();
        }

        private void metroTile8_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("logOlustur '" + "LOG GÖRÜNTÜLEME" + "','" + (kullaniciTC + " TCli Personel LOGLARI GÖRÜNTÜLEDİ") + "'", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            LogForm logForm = new LogForm();
            logForm.Show();
        }
    }
}
