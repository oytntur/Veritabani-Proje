using MetroFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Veritabani_Proje
{
    public partial class FiyatGüncelle : MetroFramework.Forms.MetroForm
    {

        //ComboBox Form açıldığında ürünleri veritabanından çekicek
        //ComboBox index değişiminde textboxa fiyat getirilcek
        //Butona basıldığında ürün fiyatı güncellenecek
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        string kullaniciTC;

        public FiyatGüncelle(string TC)
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
            con.Close();

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            int hataSayac = 0;
            try
            {
                Urun urun = new Urun();
                if (metroComboBox1.SelectedIndex >= 0)
                {
                    urun.fiyatGuncelle(metroComboBox1.SelectedIndex+1, Convert.ToDouble(metroTextBox1.Text),kullaniciTC,metroComboBox1.Text);
                }
                else if(metroComboBox1.SelectedIndex < 0)
                {
                    MetroMessageBox.Show(this, "Lütfen Bir Ürün Şeçiniz");
                    hataSayac++;
                }
            }
            catch (Exception hata)
            {
                MetroMessageBox.Show(this, "Bir Hata Meydana Geldi\n\n" + hata);
                hataSayac++;
                throw;
            }
            finally
            {
                if (hataSayac == 0)
                {
                    MetroMessageBox.Show(this, "Ürün Fiyatı Başarıyla Güncellendi");
                }
                this.Close();
            }
        }
    }
}
