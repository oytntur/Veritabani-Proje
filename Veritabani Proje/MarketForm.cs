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
    public partial class MarketForm : MetroFramework.Forms.MetroForm
    {
        public MarketForm()
        {
            InitializeComponent();
        }

        private void MarketForm_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'marketDataSet1.marketGoruntule' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.marketGoruntuleTableAdapter.Fill(this.marketDataSet1.marketGoruntule);

        }
    }
}
