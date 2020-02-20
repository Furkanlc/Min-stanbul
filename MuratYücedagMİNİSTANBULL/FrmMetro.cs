using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MuratYücedagMİNİSTANBULL
{
    public partial class FrmMetro : Form
    {
        public FrmMetro()
        {
            InitializeComponent();
        }

        private void FrmMetro_Load(object sender, EventArgs e)
        {
            textBox1.Text = " Minİstanbul Metro Duraklar";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Substring(1) + textBox1.Text.Substring(0,1); 
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text=="M1-Yenikapı-Atatürk Havalimanı / Kirazlı Metro Hattı")
            {
                textBox1.Text = " Yenikapı, Aksaray, Emniyet/Fatih, Ulubatlı/Topkapı, Bayrampaşa-Maltepe, Sağmalcılar, Kartaltepe/Kocatepe, Otogar, Terazidere, Davutpaşa/Yıldız Teknik Üniversitesi, Merter, Zeytinburnu, Bakırköy-İncirli, Bahçelievler, Ataköy/Şirinevler, Yenibosna, DTM/İstanbul Fuar Merkezi, İstanbul Atatürk Havalimanı";
            }
            if (comboBox1.Text == " M2-Yenikapı-Hacıosman Metro Hattı")
            {
                textBox1.Text = " Yenikapı,  Vezneciler, Haliç, Şişhane, Taksim, Osmanbey, Şişli/Mecidiyeköy, Gayrettepe, Levent,  4.Levent, Sanayi, İTÜ Ayazağa, Atatürk Oto Sanayi, Darüşşafaka, Hacıosman Seyrantepe.";
            }
            if (comboBox1.Text=="M3-Başakşehir Metro Hattı")
            {
                textBox1.Text = " Metrokent,Başak Konutları,Siteler,Turgut Özal,İkitelli Sanayi,Olimpiyat,Ziya Gökalp Mh,İstoç,Mahmutbey,Yeni Mahalle,Kirazlı";
            }
            if (comboBox1.Text=="M4-Kadıköy-Kartal Metro Hattı")
            {
                textBox1.Text = "Kadıköy, Acıbadem, Göztepe, Kozyatağı, Bostancı, Küçükyalı, Maltepe, Gülsuyu, Anadolu Adalet Sarayı, Kartal, Pendik";
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            FrmAnaSayfa anaform = new FrmAnaSayfa();
            anaform.Show();
            this.Hide();
        }
    }
}
