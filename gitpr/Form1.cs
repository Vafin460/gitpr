using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gitpr
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // width - ширина - x
        // height - высота - y
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics g = Graphics.FromImage(pictureBox1.Image);
            float w = pictureBox1.Width;
            float h = pictureBox1.Height;
            g.Clear(Color.White);
            Brush pn = new SolidBrush(Color.Black);
            g.FillRectangle(pn,
                w / 2- w / 10 / 2, 
                h / 2, 
                w / 10, 
                w / 10
                );

        }
    }
}
