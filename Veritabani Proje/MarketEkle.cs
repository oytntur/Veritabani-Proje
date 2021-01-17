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
    public partial class MarketEkle : MetroFramework.Forms.MetroForm
    {

        //Form çalıştığında il ilçe getirme
        //Ekle tuşunun programını yazma(ekle classına)
        //Adres olarak il+" "+ilçe+" "+ekadres olarak market classına gönderme
        SqlCommand cmd;
        SqlDataReader dr;
        SqlConnection con;
        Market market;
        string TC;


        public MarketEkle(string kullaniciTC)
        {
            InitializeComponent();
            con = new SqlConnection("Data Source=DESKTOP-V4OTKFI;Initial Catalog=Market;Integrated Security=True");
            cmd = new SqlCommand("Select * From ilTablo", con);
            TC = kullaniciTC;
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                
                cmbIl.Items.Add(dr["ilAdi"].ToString());
            }
            dr.Close();
            con.Close();
            market = new Market();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            int hataSayac = 0;
            try
            {
                market.Adi = metroTextBox1.Text;
                market.Adresi = cmbIl.Text + " " + cmbIlce.Text + " " + textBox1.Text;
                market.marketEkle(TC);
                this.Close();
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
                    MetroMessageBox.Show(this, "Market Başarıyla Eklendi");
                }
            }
        }

        private void cmbIl_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmd = new SqlCommand("Select * From ilceTablo WHERE ilID='" + (cmbIl.SelectedIndex + 1) + "'", con);

            con.Open();
            dr = cmd.ExecuteReader();
            cmbIlce.Items.Clear();
            while (dr.Read())
            {

                cmbIlce.Items.Add(dr["ilceAd"].ToString());
            }
            con.Close();
        }
    }
}
