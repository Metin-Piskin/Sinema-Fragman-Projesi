using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu_Strip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void maviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
        }

        private void griToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Gray;
        }

        private void turuncuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Orange;
        }

        private void hakkımızdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu Proje Metin Pişkin Tarafından Yapıldı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void madMaxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=hEJnMQG9ev8");
            label1.Text = "Mad Max";
        }

        private void aşkTesadüfleriSeverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=1qjMQ1xBldI");
            label1.Text = "Aşk Tesadüfleri Sever";
        }

        private void koğuştakiMucizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=z_tgY9Nmo18");
            label1.Text = "7. koğuştaki mucize";
        }

        private void gladyatörToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=owK1qxDselE");
            label1.Text = "Gladyatör";
        }

        private void avengersSonsuzlukSavaşıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=TcMBFSGVi1c");
            label1.Text = "Avengers endgame";
        }

        private void halloweenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=ek1ePFp-nBI");
            label1.Text = "Halloween";
        }

        private void testereToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=X744nrej8_4");
            label1.Text = "Testere";
        }

        private void geleceğeDönüşToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=L9HASvcViS8");
            label1.Text = "Geleceğe Dönüş"; ;
        }

        private void matrixToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=m8e-FF8MsqU");
            label1.Text = "Matrix";
        }

        private void yıldızlararasıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=vVJeYMRam0o");
            label1.Text = "Yıldızlararası";
        }

        private void kategorilerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
    }
}
