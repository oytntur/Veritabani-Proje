namespace Veritabani_Proje
{
    partial class StokKontrol
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.marketDataSet = new Veritabani_Proje.MarketDataSet();
            this.stokGoruntuleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stokGoruntuleTableAdapter = new Veritabani_Proje.MarketDataSetTableAdapters.stokGoruntuleTableAdapter();
            this.ürünAdıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marketAdıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ürünFiyatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stokSayısıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marketDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokGoruntuleBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ürünAdıDataGridViewTextBoxColumn,
            this.marketAdıDataGridViewTextBoxColumn,
            this.ürünFiyatDataGridViewTextBoxColumn,
            this.stokSayısıDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.stokGoruntuleBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(24, 64);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(762, 396);
            this.dataGridView1.TabIndex = 0;
            // 
            // marketDataSet
            // 
            this.marketDataSet.DataSetName = "MarketDataSet";
            this.marketDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stokGoruntuleBindingSource
            // 
            this.stokGoruntuleBindingSource.DataMember = "stokGoruntule";
            this.stokGoruntuleBindingSource.DataSource = this.marketDataSet;
            // 
            // stokGoruntuleTableAdapter
            // 
            this.stokGoruntuleTableAdapter.ClearBeforeFill = true;
            // 
            // ürünAdıDataGridViewTextBoxColumn
            // 
            this.ürünAdıDataGridViewTextBoxColumn.DataPropertyName = "Ürün Adı";
            this.ürünAdıDataGridViewTextBoxColumn.HeaderText = "Ürün Adı";
            this.ürünAdıDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ürünAdıDataGridViewTextBoxColumn.Name = "ürünAdıDataGridViewTextBoxColumn";
            this.ürünAdıDataGridViewTextBoxColumn.Width = 125;
            // 
            // marketAdıDataGridViewTextBoxColumn
            // 
            this.marketAdıDataGridViewTextBoxColumn.DataPropertyName = "Market Adı";
            this.marketAdıDataGridViewTextBoxColumn.HeaderText = "Market Adı";
            this.marketAdıDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.marketAdıDataGridViewTextBoxColumn.Name = "marketAdıDataGridViewTextBoxColumn";
            this.marketAdıDataGridViewTextBoxColumn.Width = 125;
            // 
            // ürünFiyatDataGridViewTextBoxColumn
            // 
            this.ürünFiyatDataGridViewTextBoxColumn.DataPropertyName = "Ürün Fiyat";
            this.ürünFiyatDataGridViewTextBoxColumn.HeaderText = "Ürün Fiyat";
            this.ürünFiyatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ürünFiyatDataGridViewTextBoxColumn.Name = "ürünFiyatDataGridViewTextBoxColumn";
            this.ürünFiyatDataGridViewTextBoxColumn.Width = 125;
            // 
            // stokSayısıDataGridViewTextBoxColumn
            // 
            this.stokSayısıDataGridViewTextBoxColumn.DataPropertyName = "Stok Sayısı";
            this.stokSayısıDataGridViewTextBoxColumn.HeaderText = "Stok Sayısı";
            this.stokSayısıDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stokSayısıDataGridViewTextBoxColumn.Name = "stokSayısıDataGridViewTextBoxColumn";
            this.stokSayısıDataGridViewTextBoxColumn.Width = 125;
            // 
            // StokKontrol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 483);
            this.Controls.Add(this.dataGridView1);
            this.Name = "StokKontrol";
            this.Text = "StokKontrol";
            this.Load += new System.EventHandler(this.StokKontrol_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marketDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokGoruntuleBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private MarketDataSet marketDataSet;
        private System.Windows.Forms.BindingSource stokGoruntuleBindingSource;
        private MarketDataSetTableAdapters.stokGoruntuleTableAdapter stokGoruntuleTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ürünAdıDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn marketAdıDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ürünFiyatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stokSayısıDataGridViewTextBoxColumn;
    }
}