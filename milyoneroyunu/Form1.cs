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
                richTextBox1.Text = "Hep aynı terane sözünde geçen 'terane'nin anlamı nedir?";

                btnA.Text = "A: Hikaye";
                btnB.Text = "B: Oyun";
                btnC.Text = "C: Ezgi";
                btnD.Text = "D: Manzara";

                lbl4.Text = "C: Ezgi";
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
                richTextBox1.Text = "İpek böceğinin yapraklarını yediği tek ağaç hangisidir?";

                btnA.Text = "A: İncir";
                btnB.Text = "B: Kiraz";
                btnC.Text = "C: Dut";
                btnD.Text = "D: Şeftali";

                lbl4.Text = "C: Dut";
            }
            if (sorusayisi == 4)
            {
                richTextBox1.Text = "'Civcivli' ifadesi nasıl yerler için kullanılır?";

                btnA.Text = "A: Sessiz sakin";
                btnB.Text = "B: Gürültülü patırtılı";
                btnC.Text = "C: Eski püskü";
                btnD.Text = "D: Ufak tefek";

                lbl4.Text = "B: Gürültülü patırtılı";
            }
            if (sorusayisi == 5)
            {
                richTextBox1.Text = "'Çıtır Çıtır' nasıl yiyecekler için söylenen bir sözdür?";

                btnA.Text = "A: Çok tuzlu";
                btnB.Text = "B: Çok taze";
                btnC.Text = "C: Çok tatlı";
                btnD.Text = "D: Çok yumuşak";

                lbl4.Text = "B: Çok taze";
            }
            if (sorusayisi == 6)
            {
                richTextBox1.Text = "Günümüzde popüler bir söz olarak sıklıkla kullanılan ‘şehir efsanesi’ sözü, eski kuşaklar tarafından nasıl söylenir?";

                btnA.Text = "A: Teamül";
                btnB.Text = "B: Tahayyül";
                btnC.Text = "C: Tevatür";
                btnD.Text = "D: Tezahür";

                lbl4.Text = "C: Tevatür";
            }
            if (sorusayisi == 7)
            {
                richTextBox1.Text = "Dünya üzerindeki en büyük okyanus aşağıdakilerden hangisidir?";

                btnA.Text = "A: Hint Okyanusu";
                btnB.Text = "B: Atlantik Okyanusu";
                btnC.Text = "C: Arktik Denizi";
                btnD.Text = "D: Pasifik Okyanusu";

                lbl4.Text = "D: Pasifik Okyanusu";
            }
            if (sorusayisi == 8)
            {
                richTextBox1.Text = "Payanda nedir?";

                btnA.Text = "A: Takla";
                btnB.Text = "B: Olta";
                btnC.Text = "C: Çatı";
                btnD.Text = "D: Destek";

                lbl4.Text = "D: Destek";
            }
            if (sorusayisi == 9)
            {
                richTextBox1.Text = "1924 Anayasası’nda ve 1961 Anayasası’nda Türkiye’nin başkentinin hangisi olduğu yazar?";

                btnA.Text = "A: İstanbul";
                btnB.Text = "B: Ankara";
                btnC.Text = "C: Erzurum";
                btnD.Text = "D: Sivas";

                lbl4.Text = "B: Ankara";
            }
            if (sorusayisi == 10)
            {
                richTextBox1.Text = "Bir şeyi ‘cephe’den gördüğünüzü söylüyorsanız nereden bakıyorsunuzdur?";

                btnA.Text = "A: Karşı";
                btnB.Text = "B: Yan";
                btnC.Text = "C: Arka";
                btnD.Text = "D: Üst";

                lbl4.Text = "A: Karşı";
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
