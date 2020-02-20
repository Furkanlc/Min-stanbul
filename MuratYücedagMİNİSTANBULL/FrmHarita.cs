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
    public partial class FrmHarita : Form
    {
        public FrmHarita()
        {
            InitializeComponent();
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            Image img = pictureBox1.Image;
            int zoomwidht = pictureBox1.Width;
            int zoomheight = pictureBox1.Height;
            if (img.Width<=(e.X+zoomwidht))
            {
                zoomwidht = img.Width - e.X;
            }
            if (img.Height<=e.Y+zoomwidht)
            {
                zoomheight = img.Height - e.Y;
            }
            Rectangle rec = new Rectangle(e.X, e.Y, zoomwidht, zoomheight);
            pictureBox2.Image = cropImage(img, rec);
        }
        private Image cropImage (Image img, Rectangle cropArea)
        {
            Bitmap bmpImage=new Bitmap(img);
            Bitmap bmpCrop=bmpImage.Clone(cropArea,bmpImage.PixelFormat);
            return(Image)(bmpCrop);
        }
    }
}
