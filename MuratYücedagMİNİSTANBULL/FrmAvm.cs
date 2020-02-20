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
    public partial class FrmAvm : Form
    {
        public FrmAvm()
        {
            InitializeComponent();
        }

        private void FrmAvm_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.istanbulcevahir.com/tr-TR/anasayfa/1.aspx");
        }
    }
}
