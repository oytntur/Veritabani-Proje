using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Veritabani_Proje
{
    public partial class StokKontrol : MetroFramework.Forms.MetroForm
    {
        public StokKontrol()
        {
            InitializeComponent();
            //yüklendiğinde stok Bilgilerini Getir

        }

        private void StokKontrol_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'marketDataSet.stokGoruntule' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.stokGoruntuleTableAdapter.Fill(this.marketDataSet.stokGoruntule);

        }
    }
}
