using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Vultrue.Generic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(PictureDrag)))
            {
                if (this.Controls.IndexOf((PictureDrag)e.Data.GetData(typeof(PictureDrag))) == -1)
                    e.Effect = DragDropEffects.Copy;
                else e.Effect = DragDropEffects.Move;
            }
            else e.Effect = DragDropEffects.None;
        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Effect == DragDropEffects.Move)
            {
                PictureDrag pic = (PictureDrag)e.Data.GetData(typeof(PictureDrag));
                pic.Location = this.PointToClient(new Point(e.X - pic.MousePoint.X, e.Y - pic.MousePoint.Y));
            }
        }

        private void pictureDrag1_Click(object sender, EventArgs e)
        {
            pictureDrag1.Image1 = pictureDrag1.Image2;
        }

        private void pictureDrag1_DoubleClick(object sender, EventArgs e)
        {

        }
    }
}
