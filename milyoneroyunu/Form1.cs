using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace milyoneroyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
 

        int sorusayisi = 0, puan = 0;
       
        private void btnA_Click(object sender, EventArgs e)
        {

            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnSonraki.Enabled = true;
            lbl5.Text = btnA.Text;
            if (lbl4.Text == lbl5.Text)
            {
                MessageBox.Show("DOĞRU tahminde bulundunuz, bir sonraki soruya geçebilirsiniz.", "BİLGİ", MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Yarışmadan Elendiniz, Şansınızı Tekrar Deneyiniz...","UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnA.Enabled = false;
                btnB.Enabled = false;
                btnC.Enabled = false;
                btnD.Enabled = false;
                btnSonraki.Enabled = false;
            }
        }

        private void btnB_Click(object sender, EventArgs e)
        {

            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnSonraki.Enabled = true;
            lbl5.Text = btnB.Text;
            if (lbl4.Text == lbl5.Text)
            {
               MessageBox.Show("DOĞRU tahminde bulundunuz, bir sonraki soruya geçebilirsiniz.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Yarışmadan Elendiniz, Şansınızı Tekrar Deneyiniz...", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnA.Enabled = false;
                btnB.Enabled = false;
                btnC.Enabled = false;
                btnD.Enabled = false;
                btnSonraki.Enabled = false;
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnSonraki.Enabled = true;
            lbl5.Text = btnC.Text;
            if (lbl4.Text == lbl5.Text)
            {
                MessageBox.Show("DOĞRU tahminde bulundunuz, bir sonraki soruya geçebilirsiniz.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Yarışmadan Elendiniz, Şansınızı Tekrar Deneyiniz...", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnA.Enabled = false;
                btnB.Enabled = false;
                btnC.Enabled = false;
                btnD.Enabled = false;
                btnSonraki.Enabled = false;
            }

        }

        private void btnD_Click(object sender, EventArgs e)
        {

            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnSonraki.Enabled = true;
            lbl5.Text = btnD.Text;
            if (lbl4.Text == lbl5.Text)
            {
                MessageBox.Show("DOĞRU tahminde bulundunuz, bir sonraki soruya geçebilirsiniz.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Yarışmadan Elendiniz, Şansınızı Tekrar Deneyiniz...", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnA.Enabled = false;
                btnB.Enabled = false;
                btnC.Enabled = false;
                btnD.Enabled = false;
                btnSonraki.Enabled = false;
            }
        }

        private void btnSonraki_Click(object sender, EventArgs e)
        {
            btnSonraki.Text = "Sonraki Soru";
            btnA.Enabled = true;
            btnB.Enabled = true;
            btnC.Enabled = true;
            btnD.Enabled = true;
            btnSonraki.Enabled = false;
            sorusayisi++;
            lblSorusayisi.Text = sorusayisi.ToString();

            if (sorusayisi == 1)
            {
                richTextBox1.Text = "Bir yere gitmeyi ifade ederken cümlenin başında kullanılan söz aşağıdakilerden hangisidir?";

                btnA.Text = "A: Sık Dişini";
                btnB.Text = "B: Kır Dizini";
                btnC.Text = "C: Ver Elini";
                btnD.Text = "D: Yum Gözünü";

                lbl4.Text = "C: Ver Elini";
            }
            if (sorusayisi == 2)
            {
                richTextBox1.Text = "Eski kuşaklar çocukları uyarırken, 'Caddeye Çıkma' yerine hangi sözü söylerler?";

                btnA.Text = "A: Asfalta çıkma";
                btnB.Text = "B: Betona çıkma";
                btnC.Text = "C: Taşa çıkma";
                btnD.Text = "D: Mıcıra çıkma";

                lbl4.Text = "A: Asfalta çıkma";
            }
            if (sorusayisi == 3)
            {
                richTextBox1.Text = "'Bulutların üzerinde gezmek' sözü hangisini ifade etmek için kullanılır?";

                btnA.Text = "A: Cesaret";
                btnB.Text = "B: Gurur";
                btnC.Text = "C: Şaşkınlık";
                btnD.Text = "D: Mutluluk";

                lbl4.Text = "D: Mutluluk";
            }
            if (sorusayisi == 4)
            {
                richTextBox1.Text = "Hangisi Hollywood filmlerinin mahkeme sahnelerinde sıklıkla duyulan ifadelerden birisidir?";

                btnA.Text = "A: Sakin ol şampiyon!";
                btnB.Text = "B: Bir cisim yaklaşıyor!";
                btnC.Text = "C: Senin sorunun ne!";
                btnD.Text = "D: İtiraz ediyorum!";

                lbl4.Text = "D: İtiraz ediyorum!";
            }
            if (sorusayisi == 5)
            {
                richTextBox1.Text = "Cumhuriyet ilan edildiği zaman Atatürk kaç yaşındaydı?";

                btnA.Text = "A: 32";
                btnB.Text = "B: 42";
                btnC.Text = "C: 52";
                btnD.Text = "D: 62";

                lbl4.Text = "B: 42";
            }
            if (sorusayisi == 6)
            {
                richTextBox1.Text = "Bir sayının karesi ile toplamı ifade eden matematik terimi aşağıdakilerden hangisidir?";

                btnA.Text = "A: Çarpım";
                btnB.Text = "B: Faktöriyel";
                btnC.Text = "C: Toplam";
                btnD.Text = "D: Karekök";

                lbl4.Text = "C: Toplam";
            }
            if (sorusayisi == 7)
            {
                richTextBox1.Text = "Dünya üzerindeki en büyük okyanus aşağıdakilerden hangisidir?";

                btnA.Text = "A: Hint Okyanusu";
                btnB.Text = "B: Atlantik Okyanusu";
                btnC.Text = "C: Arktik Okyanusu";
                btnD.Text = "D: Pasifik Okyanusu";

                lbl4.Text = "D: Pasifik Okyanusu";
            }
            if (sorusayisi == 8)
            {
                richTextBox1.Text = "5 makinenin 5 cihaz üretmesi 5 dakika sürüyorsa 100 makinenin 100 cihaz üretmesi ne kadar sürer?";

                btnA.Text = "A: 5 Dakika";
                btnB.Text = "B: 25 Dakika";
                btnC.Text = "C: 1 Saat";
                btnD.Text = "D: 1 Saat 30 Dakika";

                lbl4.Text = "A: 5 Dakika";
            }
            if (sorusayisi == 9)
            {
                richTextBox1.Text = "Bir cismin hızının ve konumunun aynı anda bilinmesini sağlayan ilke aşağıdakilerden hangisidir?";

                btnA.Text = "A: Heisenberg Belirsizlik İlkesi";
                btnB.Text = "B: Hareket Yasaları";
                btnC.Text = "C: Schrödinger Denklemi";
                btnD.Text = "D: Görelilik Teorisi";

                lbl4.Text = "B: Hareket Yasaları";
            }
            if (sorusayisi == 10)
            {
                richTextBox1.Text = "William Shakespeare'in hangi oyununda 'Hamlet' karakteri bulunmaktadır?";

                btnA.Text = "A: Macbeth";
                btnB.Text = "B: Romeo ve Juliet";
                btnC.Text = "C: Othello";
                btnD.Text = "D: Hamlet";

                lbl4.Text = "D: Hamlet";
            }
        }

        private void btnYeniden_Click(object sender, EventArgs e)
        {
            DialogResult yeniden;
            yeniden = MessageBox.Show("Oyunu yeniden oynamak istiyormusunuz?","UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(yeniden == DialogResult.Yes)
            {
                DialogResult islem;
                islem = MessageBox.Show("Oyun yeniden başlatılıyor.", "UYARI", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (islem == DialogResult.OK)
                {
                    Application.Restart();
                }
                else
                {
                    MessageBox.Show("Uygulama başlatılamadı.","HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Uygulama başlatılamadı.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    
    }
}
