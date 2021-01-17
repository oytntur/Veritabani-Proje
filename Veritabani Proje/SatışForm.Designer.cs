namespace Veritabani_Proje
{
    partial class SatışForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.urunBarkod = new MetroFramework.Controls.MetroTextBox();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.listView1 = new System.Windows.Forms.ListView();
            this.urunID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.urunBarkodNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.urunAD = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.urunKategori = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.urunFiyat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.lblFiyat = new MetroFramework.Controls.MetroLabel();
            this.lblKategoriAd = new MetroFramework.Controls.MetroLabel();
            this.lblUrunAd = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(43, 134);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(87, 20);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Ürün Barkod";
            // 
            // urunBarkod
            // 
            // 
            // 
            // 
            this.urunBarkod.CustomButton.Image = null;
            this.urunBarkod.CustomButton.Location = new System.Drawing.Point(146, 1);
            this.urunBarkod.CustomButton.Name = "";
            this.urunBarkod.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.urunBarkod.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.urunBarkod.CustomButton.TabIndex = 1;
            this.urunBarkod.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.urunBarkod.CustomButton.UseSelectable = true;
            this.urunBarkod.CustomButton.Visible = false;
            this.urunBarkod.Lines = new string[0];
            this.urunBarkod.Location = new System.Drawing.Point(137, 134);
            this.urunBarkod.MaxLength = 32767;
            this.urunBarkod.Name = "urunBarkod";
            this.urunBarkod.PasswordChar = '\0';
            this.urunBarkod.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.urunBarkod.SelectedText = "";
            this.urunBarkod.SelectionLength = 0;
            this.urunBarkod.SelectionStart = 0;
            this.urunBarkod.ShortcutsEnabled = true;
            this.urunBarkod.ShowButton = true;
            this.urunBarkod.Size = new System.Drawing.Size(168, 23);
            this.urunBarkod.TabIndex = 1;
            this.urunBarkod.UseSelectable = true;
            this.urunBarkod.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.urunBarkod.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.urunBarkod.ButtonClick += new MetroFramework.Controls.MetroTextBox.ButClick(this.urunBarkod_ButtonClick);
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(56, 215);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(172, 134);
            this.metroTile1.TabIndex = 10;
            this.metroTile1.Text = "Sat";
            this.metroTile1.UseSelectable = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.Location = new System.Drawing.Point(1202, 9);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(152, 84);
            this.metroTile2.TabIndex = 11;
            this.metroTile2.Text = "Geri Dön";
            this.metroTile2.UseSelectable = true;
            this.metroTile2.Click += new System.EventHandler(this.metroTile2_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.urunID,
            this.urunBarkodNo,
            this.urunAD,
            this.urunKategori,
            this.urunFiyat});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(24, 429);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1312, 333);
            this.listView1.TabIndex = 12;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // urunID
            // 
            this.urunID.Text = "ID";
            // 
            // urunBarkodNo
            // 
            this.urunBarkodNo.Text = "Ürün Barkod No";
            this.urunBarkodNo.Width = 262;
            // 
            // urunAD
            // 
            this.urunAD.Text = "Ürün Adı";
            this.urunAD.Width = 185;
            // 
            // urunKategori
            // 
            this.urunKategori.Text = "Ürün Kategorisi";
            this.urunKategori.Width = 200;
            // 
            // urunFiyat
            // 
            this.urunFiyat.Text = "Ürün Fiyat";
            this.urunFiyat.Width = 167;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(794, 146);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(64, 20);
            this.metroLabel2.TabIndex = 13;
            this.metroLabel2.Text = "Ürün Adı";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(794, 215);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(84, 20);
            this.metroLabel3.TabIndex = 14;
            this.metroLabel3.Text = "Kategori Adı";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(794, 292);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(72, 20);
            this.metroLabel4.TabIndex = 15;
            this.metroLabel4.Text = "Ürün Fiyat";
            // 
            // lblFiyat
            // 
            this.lblFiyat.AutoSize = true;
            this.lblFiyat.Location = new System.Drawing.Point(964, 292);
            this.lblFiyat.Name = "lblFiyat";
            this.lblFiyat.Size = new System.Drawing.Size(72, 20);
            this.lblFiyat.TabIndex = 18;
            this.lblFiyat.Text = "Ürün Fiyat";
            // 
            // lblKategoriAd
            // 
            this.lblKategoriAd.AutoSize = true;
            this.lblKategoriAd.Location = new System.Drawing.Point(964, 215);
            this.lblKategoriAd.Name = "lblKategoriAd";
            this.lblKategoriAd.Size = new System.Drawing.Size(84, 20);
            this.lblKategoriAd.TabIndex = 17;
            this.lblKategoriAd.Text = "Kategori Adı";
            // 
            // lblUrunAd
            // 
            this.lblUrunAd.AutoSize = true;
            this.lblUrunAd.Location = new System.Drawing.Point(964, 146);
            this.lblUrunAd.Name = "lblUrunAd";
            this.lblUrunAd.Size = new System.Drawing.Size(64, 20);
            this.lblUrunAd.TabIndex = 16;
            this.lblUrunAd.Text = "Ürün Adı";
            // 
            // SatışForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 785);
            this.Controls.Add(this.lblFiyat);
            this.Controls.Add(this.lblKategoriAd);
            this.Controls.Add(this.lblUrunAd);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.metroTile2);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.urunBarkod);
            this.Controls.Add(this.metroLabel1);
            this.Name = "SatışForm";
            this.Text = "SatışForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox urunBarkod;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroTile metroTile2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader urunID;
        private System.Windows.Forms.ColumnHeader urunBarkodNo;
        private System.Windows.Forms.ColumnHeader urunAD;
        private System.Windows.Forms.ColumnHeader urunKategori;
        private System.Windows.Forms.ColumnHeader urunFiyat;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel lblFiyat;
        private MetroFramework.Controls.MetroLabel lblKategoriAd;
        private MetroFramework.Controls.MetroLabel lblUrunAd;
    }
}