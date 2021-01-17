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
    public partial class PersonelSil : MetroFramework.Forms.MetroForm
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        string tc;
        Kullanıcı kullanıcı = new Kullanıcı();
        public PersonelSil(string TC)
        {
            InitializeComponent();
            
            kullanıcı.personelGetir(listView1);
            con = new SqlConnection("Data Source=DESKTOP-V4OTKFI;Initial Catalog=Market;Integrated Security=True");
            tc = TC;
        }
        int id = 0;
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            if (MessageBox.Show("Bu Kullanıcıyı Silmek İstediğinize Emin Misiniz", "Kullanıcı Silme", MessageBoxButtons.YesNo) == DialogResult.Yes)

            {

                cmd = new SqlCommand("DELETE FROM tblKullanicilar WHERE kullanıcıID='" + id + "'", con);
                con.Open();
                cmd.ExecuteNonQuery();
                cmd = new SqlCommand("logOlustur '" + "Personel Silme" + "','" + (tc + " TCli Kullanıcı Tarafından " + listView1.SelectedItems[0].SubItems[1].Text + " TCli Kullanıcı Silindi") + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();

            }
            kullanıcı.personelGetir(listView1);

        }
    }
}
