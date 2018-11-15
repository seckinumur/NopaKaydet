namespace NopaKaydet
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dOSYAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excellKaydetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniSayfaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kapatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aYARLARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sistemAyarlarıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.programAyarlarıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yARDIMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yardımToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hakkındaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.Form = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Form)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dOSYAToolStripMenuItem,
            this.aYARLARToolStripMenuItem,
            this.yARDIMToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dOSYAToolStripMenuItem
            // 
            this.dOSYAToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eToolStripMenuItem,
            this.excellKaydetToolStripMenuItem,
            this.yeniSayfaToolStripMenuItem,
            this.kapatToolStripMenuItem});
            this.dOSYAToolStripMenuItem.Name = "dOSYAToolStripMenuItem";
            this.dOSYAToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.dOSYAToolStripMenuItem.Text = "DOSYA";
            // 
            // eToolStripMenuItem
            // 
            this.eToolStripMenuItem.Name = "eToolStripMenuItem";
            this.eToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.eToolStripMenuItem.Text = "KLASÖR EKLE";
            this.eToolStripMenuItem.Click += new System.EventHandler(this.eToolStripMenuItem_Click);
            // 
            // excellKaydetToolStripMenuItem
            // 
            this.excellKaydetToolStripMenuItem.Name = "excellKaydetToolStripMenuItem";
            this.excellKaydetToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.excellKaydetToolStripMenuItem.Text = "DOSYA EKLE";
            this.excellKaydetToolStripMenuItem.Click += new System.EventHandler(this.excellKaydetToolStripMenuItem_Click);
            // 
            // yeniSayfaToolStripMenuItem
            // 
            this.yeniSayfaToolStripMenuItem.Name = "yeniSayfaToolStripMenuItem";
            this.yeniSayfaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.yeniSayfaToolStripMenuItem.Text = "EXCEL KAYDET";
            this.yeniSayfaToolStripMenuItem.Click += new System.EventHandler(this.yeniSayfaToolStripMenuItem_Click);
            // 
            // kapatToolStripMenuItem
            // 
            this.kapatToolStripMenuItem.Name = "kapatToolStripMenuItem";
            this.kapatToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kapatToolStripMenuItem.Text = "SIFIRLA";
            this.kapatToolStripMenuItem.Click += new System.EventHandler(this.kapatToolStripMenuItem_Click);
            // 
            // aYARLARToolStripMenuItem
            // 
            this.aYARLARToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sistemAyarlarıToolStripMenuItem,
            this.programAyarlarıToolStripMenuItem});
            this.aYARLARToolStripMenuItem.Name = "aYARLARToolStripMenuItem";
            this.aYARLARToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.aYARLARToolStripMenuItem.Text = "AYARLAR";
            // 
            // sistemAyarlarıToolStripMenuItem
            // 
            this.sistemAyarlarıToolStripMenuItem.Name = "sistemAyarlarıToolStripMenuItem";
            this.sistemAyarlarıToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sistemAyarlarıToolStripMenuItem.Text = "Sistem Ayarları";
            // 
            // programAyarlarıToolStripMenuItem
            // 
            this.programAyarlarıToolStripMenuItem.Name = "programAyarlarıToolStripMenuItem";
            this.programAyarlarıToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.programAyarlarıToolStripMenuItem.Text = "Program Ayarları";
            // 
            // yARDIMToolStripMenuItem
            // 
            this.yARDIMToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yardımToolStripMenuItem,
            this.hakkındaToolStripMenuItem});
            this.yARDIMToolStripMenuItem.Name = "yARDIMToolStripMenuItem";
            this.yARDIMToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.yARDIMToolStripMenuItem.Text = "YARDIM";
            // 
            // yardımToolStripMenuItem
            // 
            this.yardımToolStripMenuItem.Name = "yardımToolStripMenuItem";
            this.yardımToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.yardımToolStripMenuItem.Text = "Yardım";
            // 
            // hakkındaToolStripMenuItem
            // 
            this.hakkındaToolStripMenuItem.Name = "hakkındaToolStripMenuItem";
            this.hakkındaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.hakkındaToolStripMenuItem.Text = "Hakkında";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 539);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(784, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 24);
            this.gridControl1.MainView = this.Form;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(784, 515);
            this.gridControl1.TabIndex = 3;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.Form});
            // 
            // Form
            // 
            this.Form.GridControl = this.gridControl1;
            this.Form.GroupPanelText = "Excel Listesi";
            this.Form.Name = "Form";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nopa Dijital Baskı Kayıt Sistemi Beta 0.4 - seckinumur";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Form)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dOSYAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excellKaydetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniSayfaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kapatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aYARLARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sistemAyarlarıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem programAyarlarıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yARDIMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yardımToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hakkındaToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView Form;
    }
}

