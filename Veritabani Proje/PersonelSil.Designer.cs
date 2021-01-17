namespace Veritabani_Proje
{
    partial class PersonelSil
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.kullaniciID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.marketAdi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.kullaniciPos = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.kullaniciTC = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.kullaniciID,
            this.kullaniciTC,
            this.marketAdi,
            this.kullaniciPos});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(24, 64);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(753, 363);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // kullaniciID
            // 
            this.kullaniciID.Text = "ID";
            // 
            // marketAdi
            // 
            this.marketAdi.Text = "Çalıştığı Market";
            this.marketAdi.Width = 182;
            // 
            // kullaniciPos
            // 
            this.kullaniciPos.Text = "Pozisyonu";
            this.kullaniciPos.Width = 195;
            // 
            // kullaniciTC
            // 
            this.kullaniciTC.Text = "TC";
            this.kullaniciTC.Width = 97;
            // 
            // PersonelSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listView1);
            this.Name = "PersonelSil";
            this.Text = "PersonelSil";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader kullaniciID;
        private System.Windows.Forms.ColumnHeader marketAdi;
        private System.Windows.Forms.ColumnHeader kullaniciPos;
        private System.Windows.Forms.ColumnHeader kullaniciTC;
    }
}