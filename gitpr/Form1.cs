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
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics g = Graphics.FromImage(pictureBox1.Image);
            float w = pictureBox1.Width;
            float h = pictureBox1.Height;
            float x, y;
            g.Clear(Color.White);
            Brush sb = new SolidBrush(Color.Black);

            float drw = w / 7;
            float drh = w / 7;
            x = w / 2 - drw / 2;
            y = h / 2 - drh /2;
            g.FillRectangle(sb, x, y, drw, drh);

        }
    }
}
