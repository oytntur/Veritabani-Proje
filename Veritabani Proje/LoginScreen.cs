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
    public partial class LoginScreen : MetroFramework.Forms.MetroForm
    {
        public LoginScreen()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        private void metroButton1_Click(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=DESKTOP-V4OTKFI;Initial Catalog=Market;Integrated Security=True");
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM tblKullanicilar where kullanıcıTC='" + txtTC.Text + "' AND kullaniciPassword='" + txtPassword.Text + "'";
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                AnaMenu anaMenu = new AnaMenu(Convert.ToInt32(dr["marketID"]),dr["kullanıcıTC"].ToString());
                anaMenu.Show();
                this.Hide();
            }
            else
                MetroMessageBox.Show(this, "Kullanıcı TC veya Şifre Yanlış");
        }
    }
}
