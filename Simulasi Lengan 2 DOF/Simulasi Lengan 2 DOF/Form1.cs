using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Simulasi_Lengan_2_DOF
{
    public partial class Form1 : Form
    {
        List<PointF> points = new List<PointF>();
        Pen graphPen = new Pen(Color.Red, 2);
        Pen graphPenRed = new Pen(Color.Red, 2);
        Pen graphPenGreen = new Pen(Color.Green, 2);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.pictureBox1.Image = new Bitmap(this.pictureBox1.Width, this.pictureBox1.Height);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double teta1 = Convert.ToDouble(txtS1.Text) * Math.PI/180;
            double xl1 = Convert.ToInt16(txtL1.Text) * Math.Cos(teta1);
            double yl1 = Convert.ToInt16(txtL1.Text) * Math.Sin(teta1);

            double teta2 = Convert.ToDouble(txtS2.Text) * Math.PI/180;
            double xl2 = xl1 + Convert.ToInt16(txtL2.Text) * Math.Cos(teta2+teta1);
            double yl2 = yl1 + Convert.ToInt16(txtL2.Text) * Math.Sin(teta2+teta1);

            Graphics g = pictureBox1.CreateGraphics();
            g.Clear(Color.White);

            g.DrawLine(graphPenRed, 0, 320, (int)Math.Round(xl1), 320 - (int)Math.Round(yl1));
            g.DrawLine(graphPenGreen, (int)Math.Round(xl1), 320 - (int)Math.Round(yl1),(int)Math.Round(xl2), 320 - (int)Math.Round(yl2));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            pictureBox1.Invalidate();
        }
    }
}
