namespace Menu_Strip
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
            this.kategorilerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aksiyonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.madMaxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gladyatörToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.avengersSonsuzlukSavaşıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aşkTesadüfleriSeverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.koğuştakiMucizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.korkuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.halloweenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bilimKurguToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.geleceğeDönüşToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.matrixToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yıldızlararasıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renklerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maviToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.griToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.turuncuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hızlıErişimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hakkımızdaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kategorilerToolStripMenuItem,
            this.renklerToolStripMenuItem,
            this.hızlıErişimToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(598, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // kategorilerToolStripMenuItem
            // 
            this.kategorilerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aksiyonToolStripMenuItem,
            this.dramToolStripMenuItem,
            this.korkuToolStripMenuItem,
            this.bilimKurguToolStripMenuItem});
            this.kategorilerToolStripMenuItem.Name = "kategorilerToolStripMenuItem";
            this.kategorilerToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.kategorilerToolStripMenuItem.Text = "Kategoriler";
            this.kategorilerToolStripMenuItem.Click += new System.EventHandler(this.kategorilerToolStripMenuItem_Click);
            // 
            // aksiyonToolStripMenuItem
            // 
            this.aksiyonToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.madMaxToolStripMenuItem,
            this.gladyatörToolStripMenuItem,
            this.avengersSonsuzlukSavaşıToolStripMenuItem});
            this.aksiyonToolStripMenuItem.Name = "aksiyonToolStripMenuItem";
            this.aksiyonToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.aksiyonToolStripMenuItem.Text = "Aksiyon";
            // 
            // madMaxToolStripMenuItem
            // 
            this.madMaxToolStripMenuItem.Name = "madMaxToolStripMenuItem";
            this.madMaxToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.madMaxToolStripMenuItem.Text = "Mad Max";
            this.madMaxToolStripMenuItem.Click += new System.EventHandler(this.madMaxToolStripMenuItem_Click);
            // 
            // gladyatörToolStripMenuItem
            // 
            this.gladyatörToolStripMenuItem.Name = "gladyatörToolStripMenuItem";
            this.gladyatörToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.gladyatörToolStripMenuItem.Text = "Gladyatör";
            this.gladyatörToolStripMenuItem.Click += new System.EventHandler(this.gladyatörToolStripMenuItem_Click);
            // 
            // avengersSonsuzlukSavaşıToolStripMenuItem
            // 
            this.avengersSonsuzlukSavaşıToolStripMenuItem.Name = "avengersSonsuzlukSavaşıToolStripMenuItem";
            this.avengersSonsuzlukSavaşıToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.avengersSonsuzlukSavaşıToolStripMenuItem.Text = " Avengers: Endgame";
            this.avengersSonsuzlukSavaşıToolStripMenuItem.Click += new System.EventHandler(this.avengersSonsuzlukSavaşıToolStripMenuItem_Click);
            // 
            // dramToolStripMenuItem
            // 
            this.dramToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aşkTesadüfleriSeverToolStripMenuItem,
            this.koğuştakiMucizeToolStripMenuItem});
            this.dramToolStripMenuItem.Name = "dramToolStripMenuItem";
            this.dramToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.dramToolStripMenuItem.Text = "Dram";
            // 
            // aşkTesadüfleriSeverToolStripMenuItem
            // 
            this.aşkTesadüfleriSeverToolStripMenuItem.Name = "aşkTesadüfleriSeverToolStripMenuItem";
            this.aşkTesadüfleriSeverToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.aşkTesadüfleriSeverToolStripMenuItem.Text = "Aşk Tesadüfleri Sever";
            this.aşkTesadüfleriSeverToolStripMenuItem.Click += new System.EventHandler(this.aşkTesadüfleriSeverToolStripMenuItem_Click);
            // 
            // koğuştakiMucizeToolStripMenuItem
            // 
            this.koğuştakiMucizeToolStripMenuItem.Name = "koğuştakiMucizeToolStripMenuItem";
            this.koğuştakiMucizeToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.koğuştakiMucizeToolStripMenuItem.Text = "7. Koğuştaki Mucize";
            this.koğuştakiMucizeToolStripMenuItem.Click += new System.EventHandler(this.koğuştakiMucizeToolStripMenuItem_Click);
            // 
            // korkuToolStripMenuItem
            // 
            this.korkuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.halloweenToolStripMenuItem,
            this.testereToolStripMenuItem});
            this.korkuToolStripMenuItem.Name = "korkuToolStripMenuItem";
            this.korkuToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.korkuToolStripMenuItem.Text = "Korku";
            // 
            // halloweenToolStripMenuItem
            // 
            this.halloweenToolStripMenuItem.Name = "halloweenToolStripMenuItem";
            this.halloweenToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.halloweenToolStripMenuItem.Text = "Halloween";
            this.halloweenToolStripMenuItem.Click += new System.EventHandler(this.halloweenToolStripMenuItem_Click);
            // 
            // testereToolStripMenuItem
            // 
            this.testereToolStripMenuItem.Name = "testereToolStripMenuItem";
            this.testereToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.testereToolStripMenuItem.Text = "Testere";
            this.testereToolStripMenuItem.Click += new System.EventHandler(this.testereToolStripMenuItem_Click);
            // 
            // bilimKurguToolStripMenuItem
            // 
            this.bilimKurguToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.geleceğeDönüşToolStripMenuItem,
            this.matrixToolStripMenuItem,
            this.yıldızlararasıToolStripMenuItem});
            this.bilimKurguToolStripMenuItem.Name = "bilimKurguToolStripMenuItem";
            this.bilimKurguToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.bilimKurguToolStripMenuItem.Text = "Bilim Kurgu";
            // 
            // geleceğeDönüşToolStripMenuItem
            // 
            this.geleceğeDönüşToolStripMenuItem.Name = "geleceğeDönüşToolStripMenuItem";
            this.geleceğeDönüşToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.geleceğeDönüşToolStripMenuItem.Text = "Geleceğe Dönüş";
            this.geleceğeDönüşToolStripMenuItem.Click += new System.EventHandler(this.geleceğeDönüşToolStripMenuItem_Click);
            // 
            // matrixToolStripMenuItem
            // 
            this.matrixToolStripMenuItem.Name = "matrixToolStripMenuItem";
            this.matrixToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.matrixToolStripMenuItem.Text = "Matrix";
            this.matrixToolStripMenuItem.Click += new System.EventHandler(this.matrixToolStripMenuItem_Click);
            // 
            // yıldızlararasıToolStripMenuItem
            // 
            this.yıldızlararasıToolStripMenuItem.Name = "yıldızlararasıToolStripMenuItem";
            this.yıldızlararasıToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.yıldızlararasıToolStripMenuItem.Text = "Yıldızlararası";
            this.yıldızlararasıToolStripMenuItem.Click += new System.EventHandler(this.yıldızlararasıToolStripMenuItem_Click);
            // 
            // renklerToolStripMenuItem
            // 
            this.renklerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.maviToolStripMenuItem,
            this.griToolStripMenuItem,
            this.turuncuToolStripMenuItem});
            this.renklerToolStripMenuItem.Name = "renklerToolStripMenuItem";
            this.renklerToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.renklerToolStripMenuItem.Text = "Renkler";
            // 
            // maviToolStripMenuItem
            // 
            this.maviToolStripMenuItem.Name = "maviToolStripMenuItem";
            this.maviToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.maviToolStripMenuItem.Text = "Mavi";
            this.maviToolStripMenuItem.Click += new System.EventHandler(this.maviToolStripMenuItem_Click);
            // 
            // griToolStripMenuItem
            // 
            this.griToolStripMenuItem.Name = "griToolStripMenuItem";
            this.griToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.griToolStripMenuItem.Text = "Gri";
            this.griToolStripMenuItem.Click += new System.EventHandler(this.griToolStripMenuItem_Click);
            // 
            // turuncuToolStripMenuItem
            // 
            this.turuncuToolStripMenuItem.Name = "turuncuToolStripMenuItem";
            this.turuncuToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.turuncuToolStripMenuItem.Text = "Turuncu";
            this.turuncuToolStripMenuItem.Click += new System.EventHandler(this.turuncuToolStripMenuItem_Click);
            // 
            // hızlıErişimToolStripMenuItem
            // 
            this.hızlıErişimToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hakkımızdaToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.hızlıErişimToolStripMenuItem.Name = "hızlıErişimToolStripMenuItem";
            this.hızlıErişimToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.hızlıErişimToolStripMenuItem.Text = "Hızlı Erişim";
            // 
            // hakkımızdaToolStripMenuItem
            // 
            this.hakkımızdaToolStripMenuItem.Name = "hakkımızdaToolStripMenuItem";
            this.hakkımızdaToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.hakkımızdaToolStripMenuItem.Text = "Hakkımızda";
            this.hakkımızdaToolStripMenuItem.Click += new System.EventHandler(this.hakkımızdaToolStripMenuItem_Click);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(12, 63);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(574, 360);
            this.webBrowser1.TabIndex = 1;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(210, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Film Adı";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(598, 435);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sinema Fragman";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kategorilerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aksiyonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem madMaxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gladyatörToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem avengersSonsuzlukSavaşıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aşkTesadüfleriSeverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem koğuştakiMucizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem korkuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem halloweenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testereToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bilimKurguToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem geleceğeDönüşToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem matrixToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yıldızlararasıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renklerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maviToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem griToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem turuncuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hızlıErişimToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hakkımızdaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Label label1;
    }
}

