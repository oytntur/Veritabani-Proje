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
    public partial class personelForm : MetroFramework.Forms.MetroForm
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        string kullaniciTC;
        Kullanıcı kullanıcı = new Kullanıcı();
        public personelForm(string TC)
        {
            InitializeComponent();
            kullaniciTC = TC;
            con = new SqlConnection("Data Source=DESKTOP-V4OTKFI;Initial Catalog=Market;Integrated Security=True");
            cmd = new SqlCommand("Select marketAdi from tblMarket", con);
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                metroComboBox1.Items.Add(dr["marketAdi"]);
            }
        }


        private void personelForm_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'marketDataSet13.personelTablo' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.personelTabloTableAdapter2.Fill(this.marketDataSet13.personelTablo);


        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            kullanıcı.MarketID = metroComboBox1.SelectedIndex + 1;
            kullanıcı.TC = txtTC.Text;
            kullanıcı.Password = txtSifre.Text;
            kullanıcı.Pozisyon = txtMevki.Text;
            int sayac = 0;
            try
            {
                kullanıcı.personelEkle(kullaniciTC);
                //veritabanına Ekleme
            }
            catch (Exception hata)
            {
                MetroMessageBox.Show(this, "Personel Eklenirken Bir Hata Meydana Geldi\n" + hata);
                sayac++;
                throw;
            }
            finally
            {
                if (sayac == 0)
                {
                    MetroMessageBox.Show(this, "Personel Başarıyla Eklendi");
                    this.Close();
                    
                }
            }
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            PersonelSil personelSil = new PersonelSil(kullaniciTC);
            personelSil.ShowDialog();

        }
    }
}
