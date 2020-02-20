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
    public partial class FrmCamiler : Form
    {
        public FrmCamiler()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "İstanbul’da aynı isim ile anılan semtte bulunan ve “Selatin Camilerinin (Sultanlar tarafından yaptırılan camilerin) en büyüklerinden, en güzellerinden biridir. Padişah I. Ahmet tarafından 1609 – 1616 yılları arasında Mimar Sedefkar Mehmet Ağa’ya yaptırıldı. Yapılış sırasına göre 6. Selatin camisidir.Caminin orta kubbesi dört fil ayağına oturtulmuş, dört yarım kubbe ile çevrilmiştir. Çok pencerelidir. İç duvarları 20.000’den fazla mavi İznik çinisi ile kaplıdır. Bu yüzden Avrupalılar bu camiyi “Blue Mosque” “Mavi Cami” olarak anmaktadırlar. Altı minaresinin dördü 3’er, 2’si ise 2’şer şerefelidir...";
            pictureBox1.ImageLocation = @"C:\Users\Mostar\Desktop\MuratMİNİSTANBUL\sultan-ahmet-camisi.jpg";
            webBrowser1.Navigate("https://www.google.com.tr/maps/place/Sultan+Ahmet+Camii/@41.0047316,28.9749306,16.71z/data=!4m5!3m4!1s0x14cab9bd6570f4e1:0xe52df7368a157ca4!8m2!3d41.0054096!4d28.9768138");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            FrmAnaSayfa anaform= new FrmAnaSayfa();
            anaform.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "1598’de İstanbul’da Eminönü’nde yapımına başlandı ve 1663 ‘te tamamlandı.Yeni Cami ya da Valide Sultan Camii, olarak isimlendirilir. III. Murad’ın eşi Safiye Sultan isteğiyle yaptırılmıştır. Davut Ağa cami planının uygulanmasına başladıktan bir ay sonra öldü. Araya yolsuzluklar, ölümler, entrikalar girdi ve eser ancak 1663’te  tamamlandı; tamamlanması için mimar Dalgıç AhmedAğa ile Mustafa Ağa çalıştılar.Cami, planı bakımından Süleymaniye’ye benzer: kubbe dört büyük filayağı üzerine oturtulmuştur. Her yarım kubbeyi tutan kemerler sepet kulpuna benzeyen basık kemerlerdir. Ayaklar bir düzeye dek mavi ve ak çimlerle kaplıdır. Oyma mermerden çok güzel bir minberi bulunan camiye Hünkar Mahfili, Valide Sultan dairesiyle mahfile çıkan, son derece alımlı, kapı özel bir estetik değer kazandırmaktadır.";
            pictureBox1.ImageLocation = @"C:\Users\Mostar\Desktop\MuratMİNİSTANBUL\yeni-camii.jpg";
            webBrowser1.Navigate("https://www.google.com.tr/maps/place/Yeni+Cami/@41.0169902,28.9697707,17z/data=!3m1!4b1!4m5!3m4!1s0x14cab9eba0aba48d:0x653381c9eafc239c!8m2!3d41.0169862!4d28.9719594");
            

        }

        private void FrmCamiler_Load(object sender, EventArgs e)
        {
            webBrowser1.ScriptErrorsSuppressed = true;
        }

        private void btnayasofya_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "Anlam olarak “bilgelik” demek olan ve günümüzde müze olarak hizmet veren Ayasofya’nın ilk yapım tarihi Milattan sonra 537 yılı olarak bilinse de, aslında ilk yapım tarihi çok daha eskilere dayanmaktadır. Ayasofya, tarihte üç defa yapılan önemli tarihi eserlerden biridir. İlk yapılan Ayasofya, Roma İmparatorluğu’nun Hristiyanlığı resmi dil ilan etmesinin ardından yapılmıştır.360 yılında tamamlanan Ayasofya kilisesini 2. Constantinus açmıştır. Büyük kilise anlamına gelen Ayasofya Kilisesi, daha sonraları çıkan isyanlar sırasında Ayasofya kilisesi büyük zarar görerek yıkılmıştır. İkinci Ayasofya’nın yapılmasını ise, 2. Theodosius emretmiş ve bu günkü yerinde olan Ayasofya kilisesi yapılmıştır. 415 yılında açılan bu kilise, 532 yılında çıkan Nike ayaklanması sırasında yıkılmıştır. 3. Ayasofya’nın yapılmasını ise 532 yılında İmparator Justinyen emretmiştir ve bu günkü Ayasofya ortaya çıkmıştır. Ayasofya’nın tarih içinde bu kadar çok yıkılmasına neden olan etkenlerden biri de, o zaman henüz yeni bir teknik olan farklı mimarisinden de kaynaklanmaktadır. Dünyanın en eski ibadet merkezlerinden biri olarak bilinen Ayasofya’da kullanılan teknikler de oldukça yenilikçidir.";
            pictureBox1.ImageLocation = @"C:\Users\Mostar\Desktop\MuratMİNİSTANBUL\ayasoyfa.jpg";
            webBrowser1.Navigate("https://www.google.com.tr/maps/place/Ayasofya+M%C3%BCzesi/@41.008587,28.9779863,17z/data=!3m1!4b1!4m5!3m4!1s0x14cab9be92011c27:0x236e6f6f37444fae!8m2!3d41.008583!4d28.980175");
            
        }

        private void btnortaköy_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "Ortaköy Camii, İstanbul'da Boğaziçi’nde Ortaköy semtinde ve sahildedir. Cami, Sultan Abdülmecid tarafından Mimar Nigoğos Balyan’a 1853 yılında yaptırılmıştır. Oldukça zarif bir yapı olan cami Barok üslubundadır. Boğaziçi’nde eşsiz bir konuma yerleştirilmiştir. Bütün selatin camilerinde olduğu gibi harim ve hünkar bölümü olmak üzere iki kısımdan oluşur. Geniş ve yüksek pencereler Boğaz’ın değişken ışıklarını caminin içine taşıyacak biçimde düzenlenmiştir.";
            pictureBox1.ImageLocation = @"C:\Users\Mostar\Desktop\MuratMİNİSTANBUL\ortaköy.jpg";
            webBrowser1.Navigate("https://www.google.com.tr/maps/place/Ortak%C3%B6y+Camii/@41.0473309,29.0248007,17z/data=!3m1!4b1!4m5!3m4!1s0x14cab7c8e42887ad:0xfd73f2a29eafc8bc!8m2!3d41.0473269!4d29.0269894");

        }

        private void btnfatih_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "İstanbul’da bulunduğu semte adını vermiş olan Fatih Camisi, Fatih Sultan Mehmet tarafından Bizanslılar’ın Havariyun Kilisesi’nin kalıntısı üzerine 1463’te yaptırılmıştır.Yapılması yedi yıl on ay kadar sürmüş olan Fatih Camisi “Sahn-ı semân” (sekiz avlu) denilen medreseleriyle, imarethaneleriyle, darüşşifasi ile, bir külliye halindeydi. En kuvvetli rivayetle Mimar Atik Sinan’a ve İlyas’a yaptırtılan caminin esas bünyesi bugünkü Fatih Camisi’nden daha küçüktür. 1766’da büyük bir depremden yıkılan ilk caminin yerine bugünkü cami 1767’de temeli atılarak 1771’de bitirildi.";
            pictureBox1.ImageLocation = @"C:\Users\Mostar\Desktop\MuratMİNİSTANBUL\fatih-camii.jpg";
            webBrowser1.Navigate("https://www.google.com.tr/maps/place/Fatih+Camii+ve+K%C3%BClliyesi/@41.0195846,28.9476757,17z/data=!3m1!4b1!4m5!3m4!1s0x14caba203360ff75:0x711007ed3a83c64d!8m2!3d41.0195806!4d28.9498644");
        }

        private void btnsüleymaniye_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "Süleymaniye Camii 1551-1558 yılları arasında Kaununi Sultan Süleymanın isteği üzerine İstanbul Eminönü Semtinin Süleymaniye bölgesinde Mimar Sinan tarafından inşa edilmiştir.Mimar Sinan’ın 85 yaşında yaptığı bu eseri kalfalık eseri olarak bilinmektedir.";
            pictureBox1.ImageLocation = @"C:\Users\Mostar\Desktop\MuratMİNİSTANBUL\suleymaniye-cami.png";
            webBrowser1.Navigate("https://www.google.com.tr/maps/place/S%C3%BCleymaniye+Cami/@41.0161815,28.9619646,17z/data=!3m1!4b1!4m5!3m4!1s0x14cab98d3ac01031:0x8accf5042157cfed!8m2!3d41.0161775!4d28.9641533");

        }

        private void btnbeyazıt_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "Bayezid Camii, İstanbul'un Beyazıt semtinde, Beyazıt Meydanı`na dağınık bir şekilde yayılmış haldedir. Sultan II. Bayezid tarafından yaptırılmıştır. İnşasına 1500`de başlanmış ve 1505`de bitirilmiştir. Mimarının kim olduğu konusunda ihtilaf vardır. Mimar Hayrettin, Mimar Kemaleddin`in ve Yakupşah bin Sultanşah isimli mimarlardan biri tarafından yapıldığı sanılmaktadır ama kesin bilgiye ulaşılamamıştır. ";
            pictureBox1.ImageLocation = @"C:\Users\Mostar\Desktop\MuratMİNİSTANBUL\Beyazit-Cami.jpg";
            webBrowser1.Navigate("https://www.google.com.tr/maps/place/Beyaz%C4%B1t+Camii/@41.010226,28.9630139,17z/data=!3m1!4b1!4m5!3m4!1s0x14cab991d73292a1:0xc5894f505ceb16fa!8m2!3d41.010222!4d28.9652026");

        }
    }
}
