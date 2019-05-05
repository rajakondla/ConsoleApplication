using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SampleWindowsForm
{
    public partial class Form1 : Form
    {
        PictureBox pictureBox = new PictureBox();
        UserImage image = new UserImage("http://www.gravatar.com/avatar/6810d91caff032b202c50701dd3af745?d=identicon&r=PG");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            // Dock the PictureBox to the form and set its background to white.
            pictureBox.Dock = DockStyle.Fill;
            pictureBox.BackColor = Color.White;
            // Connect the Paint event of the PictureBox to the event handler method.
            pictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            image.PaintEventHandler = this.pictureBox1_Paint;
            // Add the PictureBox control to the Form.
            this.Controls.Add(pictureBox);
        }

        public void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            image.Object = sender;
            image.PaintEventArgs = e;
            Icon icon1 = new Icon(image.Icon, image.Height, image.Width);
            Bitmap bmp = icon1.ToBitmap();
            e.Graphics.DrawImage(bmp, new Point(30, 30));
            e.Dispose();
        }
    }
}
