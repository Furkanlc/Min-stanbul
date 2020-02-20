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
    public partial class FrmKamera : Form
    {
        public FrmKamera()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.istanbuluseyret.com/turistikkameralar/");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://ibbtube.com/kameralar/istiklal-caddesi-2/");   
        }

        private void button3_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.kocbey.com/kcam/istanbul/taksim.html");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.kocbey.com/kcam/istanbul/bogazicikoprusu.html");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://ibbtube.com/kameralar/eyup-sultan/");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://ibbtube.com/kameralar/kız-kulesi/");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://ibbtube.com/kameralar/galata/");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://ibbtube.com/kameralar/pierre-lotti/");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            FrmAnaSayfa anaform = new FrmAnaSayfa();
            anaform.Show();
            this.Hide();
        }
    }
}
