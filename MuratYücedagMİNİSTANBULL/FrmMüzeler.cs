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
    public partial class FrmMüzeler : Form
    {
        public FrmMüzeler()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text=="KÜLTÜR VE TURİZM BAKANLIĞI'NA BAĞLI MÜZELER")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("TOPKAPI SARAYI MÜZESİ");
                comboBox2.Items.Add("AYASOFYA MÜZESİ (Hagia Sophia)");
                comboBox2.Items.Add("AYA İRİNİ KİLİSESİ MÜZESİ");
                comboBox2.Items.Add("ANADOLUHİSARI MÜZESİ");
                comboBox2.Items.Add("RUMELİHİSARI MÜZESİ");
            }
            if (comboBox1.Text=="İSTANBUL BÜYÜKŞEHİR BELEDİYESİNE BAĞLI MÜZELER")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("YEREBATAN SARNICI MÜZESİ (Kültür A.Ş.)");
                comboBox2.Items.Add("PANAROMA 1453 TARİH MÜZESİ (Kültür A.Ş.)");
                comboBox2.Items.Add("MİNİATÜRK (Kültür A.Ş.)");
                comboBox2.Items.Add("ATATÜRK MÜZESİ (İnkılap Müzesi)");
                comboBox2.Items.Add("İTFAİYE MÜZESİ");
            }
            
            if (comboBox1.Text == "(MİLLİ SARAYLAR) BAĞLI MÜZELER")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("AYNALIKAVAK KASRI");
                comboBox2.Items.Add("BEYKOZ KASRI");
                comboBox2.Items.Add("BEYLERBEYİ SARAYI");
                comboBox2.Items.Add("DOLMABAHÇE SARAYI");
                comboBox2.Items.Add("FLORYA ATATÜRK DENİZ KÖŞKÜ");
                comboBox2.Items.Add("IHLAMUR KASIRLARI");
            }
            if (comboBox1.Text == "GENELKURMAY BAŞKANLIĞINA BAĞLI MÜZELER")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("DENİZ MÜZESİ");
                comboBox2.Items.Add("HAVACILIK MÜZESİ");
                comboBox2.Items.Add("ASKERİ MÜZE VE KÜLTÜR SİTESİ KOMUTANLIĞI");
              
            }
            if (comboBox1.Text == "ÖZEL MÜZELER")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("İSTANBUL MODERN SANAT MÜZESİ");
                comboBox2.Items.Add("İSTANBUL OYUNCAK MÜZESİ");
                comboBox2.Items.Add("JURASSIC LAND");
                comboBox2.Items.Add("SİRKECİ GARI TCDD Müzesi");
            }


        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //KÜLTÜR VE TURİZM BAKANLIĞI'NA BAĞLI MÜZELER

            if (comboBox2.Text=="TOPKAPI SARAYI MÜZESİ")
            {
                richTextBox1.Text = "Müze : TOPKAPI SARAYI MÜZESİ Yer : Sultanahmet, Fatih / İSTANBUL Telefon : 0212 512 0480 Web : (http://topkapisarayi.gov.tr/tr) Ziyaret Gün ve Saati : Salı günü hariç 09.00 - 19.00 (Yaz saati uygulaması boyunca) Açıklama : Topkapı Sarayı Fatih Sultan Mehmed tarafından 1460-1478 tarihleri arasında yaptırılmıştır. Saray, 19. Yüzyıla kadar Osmanlı padişahların resmî ikametgâhı olmaya devam etmiştir. Ücret : 20 TL, Harem: 15 TL    Koordinat : 41.011107N,28.982574E";
                pictureBox2.ImageLocation = @"C:\Users\Mostar\Desktop\MuratMİNİSTANBUL\topkapı.jpg";
            }
            if (comboBox2.Text=="AYASOFYA MÜZESİ (Hagia Sophia)")
            {
                richTextBox1.Text = "Müze : AYASOFYA MÜZESİ (Hagia Sophia) Yer : Ayasofya Meydanı, Sultanahmet Fatih/İSTANBUL Telefon : 0212 5221750 Web : (http://ayasofyamuzesi.gov.tr/tr) Ziyaret Gün ve Saati : Pazartesi kapalı, diğer günler 09.00 - 19.00 (Yaz saati uygulaması boyunca) Açıklama : Ayasofya 916 yıl kilise olarak kalmıştır. 1453 Yılında Fatih Sultan Mehmed tarafından İstanbul'un fethiyle camiye çevrilerek, 482 yıl cami olarak kullanılmıştır. Atatürk'ün emri ve Bakanlar Kurulu'nun Kararı ile 1935 yılında Ayasofya müze olarak kapılarını ziyarete açmıştır. Ücret : 20 TL Koordinat : 41°0′31″K 28°58′48″D";
                pictureBox2.ImageLocation = @"C:\Users\Mostar\Desktop\MuratMİNİSTANBUL\ayasoyfa.jpg";
            }
            if (comboBox2.Text=="AYA İRİNİ KİLİSESİ MÜZESİ")
            {
                richTextBox1.Text = "Müze : AYA İRİNİ KİLİSESİ MÜZESİ Yer : Topkapı Sarayı Avlusu, Sultanahmet, Eminönü Telefon : 0212 5284500 Web : http://www.topkapisarayi.gov.tr/tr/aya-irini-m%C3%BCzesi-a%C3%A7%C4%B1ld%C4%B1 Ziyaret Gün ve Saati : Topkapı Sarayı Müzesinden alınacak izinle gezilebilir. Açıklama : Türkiye'deki ilk müze çalışmaları Aya İrini'de başlamıştır. III. Ahmet döneminde Osmanlı İmparatorluğu'nun çeşitli yerlerinden gönderilen eserler Mecma-i Esliha-i Atika (Eski Silahlar Koleksiyonu) ve Mecma-i Asar-ı Atika (Eski Eserler Koleksiyonu) isimleri altında iki ayrı bölüm olarak Aya İrini'de toplanmıştı. Bu müze 1875'te Çinili Köşk'e taşındı. 1908'de yeni bir askeri müzenin kurulması için Aya İrini'de çeşitli tarihsel malzeme depolandı. Daha açılan bu müze 1949'a kadar Askeri Müze olarak hizmet verdi. 1974-76'da arasında yapılan çalışmalarda nemden arındırmak amacıyla çevresindeki toprak dolguları kaldırılmıştır. 1973'ten beri başta İKSV bünyesinde olmak üzere, birçok sanat etkinliğine ev sahipliği yapmaktadır. Ücret : 20 TL Koordinat : 41°0′35″N, 28°58′52″E ";
                pictureBox2.ImageLocation = @"C:\Users\Mostar\Desktop\MuratMİNİSTANBUL\ayairina.jpg";
            }
            if (comboBox2.Text == "ANADOLUHİSARI MÜZESİ")
            {
                richTextBox1.Text = "Müze : ANADOLUHİSARI MÜZESİ Yer : Anadoluhisarı, Beykoz Telefon : 0212 2635305 Web : http://www.kulturvarliklari.gov.tr/TR,43843/anadoluhisari.html Ziyaret Gün ve Saati : Hisarlar Müzesi Müdürlüğünün izni ile gezilir. Açıklama : Okumak için tıklayınız Ücret : 3 TL Koordinat : 41.082413, 29.066888  ";
                pictureBox2.ImageLocation = @"C:\Users\Mostar\Desktop\MuratMİNİSTANBUL\anadoluhisarı.jpg";
            }
            if (comboBox2.Text == "RUMELİHİSARI MÜZESİ")
            {
                richTextBox1.Text = "Müze : RUMELİHİSARI MÜZESİ Yer : Yahya Kemal Caddesi No:42, Rumelihisarı, Sarıyer Telefon : 0212 2635305 Web : http://www.kulturvarliklari.gov.tr/TR,44097/istanbul-hisarlar-muze-mudurlugu.html Ziyaret Gün ve Saati : Çarşamba hariç, diğer günler 09.30 - 16.30 Açıklama : Okumak için tıklayınız Ücret : 3 TL Koordinat : 41.085804, 29.055972 ";
                pictureBox2.ImageLocation = @"C:\Users\Mostar\Desktop\MuratMİNİSTANBUL\rumelihisarı.jpg";
            }

            //İSTANBUL BÜYÜKŞEHİR BELEDİYESİNE BAĞLI MÜZELER

            if (comboBox2.Text == "YEREBATAN SARNICI MÜZESİ (Kültür A.Ş.)")
            {
                richTextBox1.Text = "Müze : YEREBATAN SARNICI MÜZESİ (Kültür A.Ş.) Yer : Yerebatan Caddesi Alemdar Mah. No: 13, Sultanahmet Telefon : 0212 5221259  Ziyaret Gün ve Saati : Her gün 09.00 - 18.30  Web : http://yerebatan.com/ Açıklama : Okumak için tıklayınız Ücret : Ücret: 5 TL, Yabancı 10 TL Koordinat : 41.008390, 28.977828";
                pictureBox2.ImageLocation = @"C:\Users\Mostar\Desktop\MuratMİNİSTANBUL\yerebatan.jpg";
            }
            if (comboBox2.Text == "PANAROMA 1453 TARİH MÜZESİ (Kültür A.Ş.)")
            {
                richTextBox1.Text = "Müze : PANAROMA 1453 TARİH MÜZESİ (Kültür A.Ş.) Yer : Topkapı Kültür Parkı Merkez Efendi Mah. Topkapı Telefon : 0212 4151453 Ziyaret Gün ve Saati : Her gün 09.00 - 18.30 Web : http://panoramikmuze.com/panorama-1453 Açıklama : Okumak için tıklayınız Ücret : 5 TL, Öğrenci: 3 TL, Yabancı 10 TL Koordinat : 41.012924, 28.983836 ";
                pictureBox2.ImageLocation = @"C:\Users\Mostar\Desktop\MuratMİNİSTANBUL\panaroma1453.jpg";
            }
            if (comboBox2.Text == "MİNİATÜRK (Kültür A.Ş.)")
            {
                richTextBox1.Text = "Müze : MİNİATÜRK (Kültür A.Ş.) Yer : İmrahor Caddesi, Sütlüce Telefon : 0212 2222882 Ziyaret Gün ve Saati : Her gün 09.00 - 18.00 Web : http://miniaturk.com.tr/ Açıklama : Okumak için tıklayınız Ücret : 5 TL, Öğrenci: 3 TL, Yabancı 10 TL Koordinat : 41.060038, 28.948592  ";
                pictureBox2.ImageLocation = @"C:\Users\Mostar\Desktop\MuratMİNİSTANBUL\miniatürk.jpg";
            }
            if (comboBox2.Text == "ATATÜRK MÜZESİ (İnkılap Müzesi)")
            {
                richTextBox1.Text = "Müze : ATATÜRK MÜZESİ (İnkılap Müzesi) Yer : Halaskargazi Caddesi No: 250, Şişli Telefon : 0212 233 47 23 Ziyaret Gün ve Saati : Pazar, Perşembe hariç diğer günler 09.00-16.00  Web : http://ataturkkitapligi.ibb.gov.tr/ataturkkitapligi/index.php?dil=tr&p=3&ID=1 Açıklama : Okumak için tıklayınız Ücret : Ücretsiz Koordinat : 41.053360, 28.988178   ";
                pictureBox2.ImageLocation = @"C:\Users\Mostar\Desktop\MuratMİNİSTANBUL\atatürkmüzesi.jpg";
            }
            if (comboBox2.Text == "İTFAİYE MÜZESİ")
            {
                richTextBox1.Text = "Müze : İTFAİYE MÜZESİ Yer : Yıldız Mahallesi Çitlembik Yokuşu Horoz Sokak No : 1 Beşiktaş/İstanbul Telefon : 0212 259 91 24 Ziyaret Gün ve Saati : Hafta içi ve Hafta sonu 09:00 - 16:00saatleri arasındadır.Cumartesi ve Pazar günü kapalıdır. Web : http://ataturkkitapligi.ibb.gov.tr/ataturkkitapligi/index.php?dil=tr&p=3&ID=4 Açıklama : Okumak için tıklayınız Ücret : 20Koordinat : 41.016579, 28.953926  ";
                pictureBox2.ImageLocation = @"C:\Users\Mostar\Desktop\MuratMİNİSTANBUL\itfaiye.jpg";
            }

            //(MİLLİ SARAYLAR) BAĞLI MÜZELER

            if (comboBox2.Text == "AYNALIKAVAK KASRI")
            {
                richTextBox1.Text = " Müze : AYNALIKAVAK KASRI Yer : Aynalı Kavak Caddesi, Hasköy, Eyüp Telefon : 0212 256 9750 Ziyaret Gün ve Saati : Pazartesi ve Perşembe günleri hariç diğer günler 09.00 - 17.00 Web : http://www.millisaraylar.gov.tr/portalmain/Palaces.aspx?SarayId=3 Açıklama : Okumak için tıklayınız Ücret : 5Koordinat : 41.038080, 28.955583 ";
                pictureBox2.ImageLocation = @"C:\Users\Mostar\Desktop\MuratMİNİSTANBUL\aynalıkasrı müzesi.jpg";
            }
            if (comboBox2.Text == "BEYKOZ KASRI")
            {
                richTextBox1.Text = "Müze : BEYKOZ KASRI Yer : Hünkar İskele Caddesi, Beykoz Telefon : 0216 4241638 Ziyaret Gün ve Saati : Pazartesi ve Perşembe günleri hariç diğer günler 09.00 - 17.00 Web : http://www.millisaraylar.gov.tr/portalmain/Palaces.aspx?SarayId=4 Açıklama : Mısır Valisi Kavalalı Mehmet Ali Paşa tarafından Sultan Abdülmecid'e (1839-1861) armağan olarak yaptırılmaya başlanmış, ölümü üzerine oğlu Said Paşa tarafından tamamlanmıştır (1848-1854). Boğaziçi’nde yeni üslupta yaptırılan ilk kârgir Kasır olan Beykoz Kasrı’nın bahçeleri, set set yapının bulunduğu alana kadar yükselmektedir. Ücret : Koordinat : 41.138625, 29.081259 ";
                pictureBox2.ImageLocation = @"C:\Users\Mostar\Desktop\MuratMİNİSTANBUL\beykozkasrı.jpg";
            }
            if (comboBox2.Text == "BEYLERBEYİ SARAYI")
            {
                richTextBox1.Text = "Müze : BEYLERBEYİ SARAYI Yer : Abdullahağa Caddesi, Beylerbeyi, Üsküdar Telefon : 0216 3219320   Ziyaret Gün ve Saati : Pazartesi ve Perşembe günleri hariç diğer günler 09.00 - 17.00 Web : http://www.millisaraylar.gov.tr/portalmain/Palaces.aspx?SarayId=4 Açıklama : Okumak için tıklayınız Ücret : 3Koordinat : 41.042676, 29.039984 ";
                pictureBox2.ImageLocation = @"C:\Users\Mostar\Desktop\MuratMİNİSTANBUL\beylerbeyi.jpg";
            }
            if (comboBox2.Text == "DOLMABAHÇE SARAYI")
            {
                richTextBox1.Text = "Müze : DOLMABAHÇE SARAYI Yer : Dolmabahçe, Beşiktaş Telefon : 0212 2369000 Ziyaret Gün ve Saati : Pazartesi ve Perşembe günleri hariç diğer günler 09.00 - 16.00 Web : http://www.millisaraylar.gov.tr/portalmain/Palaces.aspx?SarayId=10 Açıklama : Okumak için tıklayınız Ücret : 10Koordinat : 41.039152, 29.000448 ";
                pictureBox2.ImageLocation = @"C:\Users\Mostar\Desktop\MuratMİNİSTANBUL\dolmabahçe.jpg";
            }
            if (comboBox2.Text == "FLORYA ATATÜRK DENİZ KÖŞKÜ")
            {
                richTextBox1.Text = "Müze : FLORYA ATATÜRK DENİZ KÖŞKÜ Yer : Florya Telefon : 0212 4265151 Ziyaret Gün ve Saati : Pazartesi ve Perşembe günleri hariç diğer günler 09.00 - 17.00 Web : http://www.millisaraylar.gov.tr/portalmain/Palaces.aspx?SarayId=5 Açıklama : Okumak için tıklayınız Ücret : 10 Koordinat : 40.973504, 28.784467 ";
                pictureBox2.ImageLocation = @"C:\Users\Mostar\Desktop\MuratMİNİSTANBUL\floraya atatürk.jpg";
            }
            if (comboBox2.Text == "IHLAMUR KASIRLARI")
            {
                richTextBox1.Text = "Müze : IHLAMUR KASIRLARI Yer : Ihlamur Yolu, Beşiktaş Telefon : 0212 2595086 Ziyaret Gün ve Saati : Pazartesi ve Perşembe günleri hariç diğer günler 09.00 - 17.00 Web : http://www.millisaraylar.gov.tr/portalmain/Palaces.aspx?SarayId=6 Açıklama : Okumak için tıklayınız Ücret : 10 Koordinat : 41.046177, 29.002499 ";
                pictureBox2.ImageLocation = @"C:\Users\Mostar\Desktop\MuratMİNİSTANBUL\ıhlamur kasrı.jpg";
            }

            // GENELKURMAY BAŞKANLIĞINA BAĞLI MÜZELER

            if (comboBox2.Text == "DENİZ MÜZESİ")
            {
                richTextBox1.Text = " Müze : DENİZ MÜZESİ Yer : Cezayir Cad. No:1, Beşiktaş Telefon : 0212 3274345 Ziyaret Gün ve Saati : Pazartesi ve Salı günleri kapalı olup, hafta içi: 09.00 - 17.00, hafta sonu: 10.00 - 18.00 web : http://www.denizmuzeleri.tsk.tr/idmk/ Açıklama : Türkiye'nin denizcilik alanında en büyük müzesi olan Deniz Müzesi, içerdiği koleksiyon çeşitliliği açısından dünyanın sayılı müzelerinden biridir. Koleksiyonunda yaklaşık 20.000 adet eser bulunmaktadır. Deniz Kuvvetleri Komutanlığı'na bağlı olan Deniz Müzesi, Türkiye'de kurulan ilk askeri müzedir. Ana sergi binası 3 katlı olup, 20.000 m2' lik alana sahiptir. 4 ana galeri, 2 oda, çocuk odası, sinevizyon odası, çok amaçlı salon, 2 sanat galerisi ve 2 fuaye bulunan bina çağdaş müzecilik anlayışıyla sizlere hizmet etmektedir. Ücret : Ücret: 4 TL, Öğrenci:1 TL Koordinat : 41.041544, 29.005389 ";
                pictureBox2.ImageLocation = @"C:\Users\Mostar\Desktop\MuratMİNİSTANBUL\denizmüzesi.jpg";
            }
            if (comboBox2.Text == "HAVACILIK MÜZESİ")
            {
                richTextBox1.Text = "Müze : HAVACILIK MÜZESİ Yer : Hava Harp Okulu Komutanlığı, Yeşilköy Telefon : 0212 6632490 Ziyaret Gün ve Saati : Pazartesi ve Salı günleri dışında her gün 09.00 - 16.30 web : http://tr.wikipedia.org/wiki/%C4%B0stanbul_Havac%C4%B1l%C4%B1k_M%C3%Bczesi Açıklama : Okumak için tıklayınız Ücret : Ücret: 3 TL, Öğrenci 1 TL Koordinat : 40.963109, 28.826093 ";
                pictureBox2.ImageLocation = @"C:\Users\Mostar\Desktop\MuratMİNİSTANBUL\havacılıkmüzesi.jpg";
            }
            if (comboBox2.Text == "ASKERİ MÜZE VE KÜLTÜR SİTESİ KOMUTANLIĞI")
            {
                richTextBox1.Text = "Müze : ASKERİ MÜZE VE KÜLTÜR SİTESİ KOMUTANLIĞI Yer : Askeri Müze ve Kültür Sitesi Komutanlığı, Harbiye, Şişli Telefon : 0212 2332720 Ziyaret Gün ve Saati : Pazartesi ve Salı günleri dışında her gün 09:00-17:00 web : http://www.askerimuze.tsk.tr/ana_sayfa/ana_sayfa.htm Açıklama : Okumak için tıklayınız Ücret : 5Koordinat : 41.046312, 28.987011 ";
                pictureBox2.ImageLocation = @"C:\Users\Mostar\Desktop\MuratMİNİSTANBUL\ASKERİ MÜZE VE KÜLTÜR SİTESİ KOMUTANLIĞI.jpg";
            }
            //ÖZEL MÜZELER 

            if (comboBox2.Text == "İSTANBUL MODERN SANAT MÜZESİ")
            {
                richTextBox1.Text = "Müze : İSTANBUL MODERN SANAT MÜZESİ Yer : Mebusan Cad. Liman İşletmeleri Sahası Antrepo No:4 Karaköy Telefon : 0212 3347300 Web : www.istanbulmodern.org Açıklama : Okumak için tıklayınız Koordinat : 41.026650, 28.984445  ";
                pictureBox2.ImageLocation = @"C:\Users\Mostar\Desktop\MuratMİNİSTANBUL\modern sanat.jpg";
            }
            if (comboBox2.Text == "İSTANBUL OYUNCAK MÜZESİ")
            {
                richTextBox1.Text = "Müze : İSTANBUL OYUNCAK MÜZESİ Yer : Ömerpaşa Caddesi Dr. Zeki Zeren Sokağı No:17, Göztepe Telefon : 0216 3594550 Web : www.istanbuloyuncakmuzesi.com Açıklama : Okumak için tıklayınız Koordinat : 40.976166, 29.070061 ";
                pictureBox2.ImageLocation = @"C:\Users\Mostar\Desktop\MuratMİNİSTANBUL\oyuncak müzesi.jpg";
            }
            if (comboBox2.Text == "JURASSIC LAND")
            {
                richTextBox1.Text = "Müze : JURASSIC LAND   Yer : Kocatepe Mah. Paşa Cad. Forum İstanbul AVM SF Blok No.17/02.120 Bayrampaşa, Telefon : 0212 6408088 Web : www.jurassicland.com.tr Açıklama : Okumak için tıklayınız Koordinat : 41.047279, 28.897553";
                pictureBox2.ImageLocation = @"C:\Users\Mostar\Desktop\MuratMİNİSTANBUL\JURASSICland.jpg";
            }
            if (comboBox2.Text == "SİRKECİ GARI TCDD Müzesi")
            {
                richTextBox1.Text = "Müze : SİRKECİ GARI TCDD Müzesi Yer : Sirkeci Tren Garı, Sirkeci Telefon : 0212 5206575 Web : http://www.panoramikistanbul.com/tcdd-istanbul-sirkeci-gari-demiryolu-muzesi.html Açıklama : Müze İstanbul Gar Binası içinde yaklaşık 45.50 metrekarelik alanda 23 Eylül 2005 Müze demiryolu sevgisini halkımıza aşılamak, gelecek nesillerin kullanılan eski objeleri tanımasına yardımcı olmak ve kaybolup yok olmalarını önlemek amacıyla kurulmuştur. Müzede sergilenen eserler, bulunduğu yer sebebiyle Sirkeci Garı ağırlıklıdır. Yaklaşık 300 eser sergilenmektedir. Koordinat : 41.015244, 28.977109  ";
                pictureBox2.ImageLocation = @"C:\Users\Mostar\Desktop\MuratMİNİSTANBUL\sirkexi.jpg";
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmAnaSayfa anaform = new FrmAnaSayfa();
            anaform.Show();
            this.Hide();
        }
    }
}
