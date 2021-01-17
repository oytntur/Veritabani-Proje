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
    public partial class StokEkle : MetroFramework.Forms.MetroForm
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        private string kullaniciTC;

        public StokEkle(string TC)
        {
            InitializeComponent();
            kullaniciTC = TC;
            con = new SqlConnection("Data Source=DESKTOP-V4OTKFI;Initial Catalog=Market;Integrated Security=True");
            con.Open();
            cmd = new SqlCommand("SELECT urunAdi From tblUrun", con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                metroComboBox1.Items.Add(dr["urunAdi"]);
            }
            dr.Close();
            cmd = new SqlCommand("SELECT marketAdi From tblMarket", con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                metroComboBox2.Items.Add(dr["marketAdi"]);
            }
            con.Close();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            int hataSayac = 0;
            try
            {
                int urunid=0;
                cmd = new SqlCommand("Select urunID from tblUrun where siraID='" + (metroComboBox1.SelectedIndex + 1) + "'", con);
                con.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    urunid = Convert.ToInt32(dr["urunID"]);
                }
                dr.Close();
                con.Close();
                cmd = new SqlCommand("urunStokDegistir '"+urunid+"','" + (metroComboBox2.SelectedIndex + 1) + "','" + Convert.ToInt32(metroTextBox1.Text) + "'", con);
                con.Open();
                cmd.ExecuteNonQuery();
                cmd = new SqlCommand("logOlustur '" + "Stok Ekleme" + "','" + (kullaniciTC + " TCli Kullanıcı Tarafından " + metroTextBox1.Text+" Kalem "+ metroComboBox1.Text +" "+  metroComboBox2.Text+" Adlı Mağazaya Eklendi") + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception hata)
            {
                MetroMessageBox.Show(this, "Bir Hata Meydana Geldi\n\n" + hata);
                hataSayac++;
                throw;
            }
            finally
            {
                if (hataSayac==0)
                {
                    MetroMessageBox.Show(this, "Stok Başarıyla Eklendi");
                    this.Close();
                }
            }
        }
    }
}
