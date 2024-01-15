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
        public int iter = 1;
        private void Form1_Paint(object sender, PaintEventArgs e)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics g = Graphics.FromImage(pictureBox1.Image);
            Brush sb = new SolidBrush(Color.FromArgb(100, 100, 100, 100));

            float w = pictureBox1.Width;
            float h = pictureBox1.Height;
            float x, y;

            


           
            float drw = w / (7);
            float drh = w / (7);
            x = (w / 2 - drw / 2);
            y = (h / 2 - drh / 2);
            g.FillRectangle(sb, x, y, drw, drh);
            makeFractal(x, y, drw, drh, 4);
            
        }
        public void makeFractal(float x, float y, float drw, float drh, int maxIter)
        {
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics g = Graphics.FromImage(pictureBox1.Image);
            Brush sb = new SolidBrush(Color.FromArgb(100, 100, 100, 100));

            if (iter == maxIter)
            {
                return;
            }
            iter++;


            g.FillRectangle(sb, x - (drw / 2), y - (drh / 2), drw / 2, drh / 2); // верхний левый 
            g.FillRectangle(sb, x + drw      , y - (drh / 2), drw / 2, drh / 2); // вехиний правый 
            g.FillRectangle(sb, x - (drw / 2), y + (drh    ), drw / 2, drh / 2); // нижний  левый
            g.FillRectangle(sb, x + (drw    ), y + (drh    ), drw / 2, drh / 2); // нижний  правый


            
        }
    }
}
