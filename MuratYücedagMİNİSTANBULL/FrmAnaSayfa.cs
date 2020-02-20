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
    public partial class FrmAnaSayfa : Form
    {
        public FrmAnaSayfa()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongTimeString();
            label2.Text = DateTime.Now.ToLongDateString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmCamiler camibilgi = new FrmCamiler();
            camibilgi.Show();
            this.Hide();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            FrmHarita haritaformu = new FrmHarita();
            haritaformu.Show();
            this.Hide();
        }

        private void FrmAnaSayfa_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            FrmKamera kameralar = new FrmKamera();
            kameralar.Show();
            this.Hide();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            FrmMetro metroformu = new FrmMetro();
            metroformu.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            FrmMetrobus metrobusform = new FrmMetrobus();
            metrobusform.Show();
            this.Hide();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            FrmNeAlınır nealınırform = new FrmNeAlınır();
            nealınırform.Show();
            
        }

        private void button13_Click(object sender, EventArgs e)
        {
            FrmNeYenir neyenirform = new FrmNeYenir();
            neyenirform.Show();
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FrmKopruler kopruform = new FrmKopruler();
            kopruform.Show();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmMüzeler müzeform = new FrmMüzeler();
            müzeform.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmKorular formkoru = new FrmKorular();
            formkoru.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmCarsilar formcarsi = new FrmCarsilar();
            formcarsi.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmAvm formavm = new FrmAvm();
            formavm.Show();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            FrmAdalar formadalar = new FrmAdalar();
            formadalar.Show();

        }

        private void button11_Click(object sender, EventArgs e)
        {
            FrmFotograf formfotograf = new FrmFotograf();
            formfotograf.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Minİstanbul Programı C# Dersleri için yapılmış olup, E-İstanbul Şehir Rehberi Niteligindedir. Nisan-2018 ");
        }
    }
}
