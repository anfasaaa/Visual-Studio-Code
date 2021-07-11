using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Simulasi_Lengan_3_DOF___Scroll_Bar
{
    public partial class Form1 : Form
    {
        List<PointF> points = new List<PointF>();
        Pen graphPen = new Pen(Color.Red, 2);
        Pen graphPenRed = new Pen(Color.Red, 2);
        Pen graphPenGray = new Pen(Color.Gray, 2);
        Pen graphPenBlue = new Pen(Color.Blue, 2);

        public int nilai1, nilai2, nilai3, hasil1, hasil2, hasil3;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.pictureBox1.Image = new Bitmap(this.pictureBox1.Width, this.pictureBox1.Height);
        }

        private void btn_proses_Click(object sender, EventArgs e)
        {
            double teta1 = Convert.ToDouble(txtS1.Text) * Math.PI / 180;
            double xl1 = Convert.ToInt16(txtL1.Text) * Math.Cos(teta1);
            double yl1 = Convert.ToInt16(txtL1.Text) * Math.Sin(teta1);

            double teta2 = Convert.ToDouble(txtS2.Text) * Math.PI / 180;
            double xl2 = xl1 + Convert.ToInt16(txtL2.Text) * Math.Cos(teta2 + teta1);
            double yl2 = yl1 + Convert.ToInt16(txtL2.Text) * Math.Sin(teta2 + teta1);

            double teta3 = Convert.ToDouble(txtS3.Text) * Math.PI / 180;
            double xl3 = xl2 + Convert.ToInt16(txtL3.Text) * Math.Cos(teta3 + teta2 + teta1);
            double yl3 = yl2 + Convert.ToInt16(txtL3.Text) * Math.Sin(teta3 + teta2 + teta1);

            Graphics g = pictureBox1.CreateGraphics();
            g.Clear(Color.White);

            g.DrawLine(graphPenRed, 0, 320, (int)Math.Round(xl1), 320 - (int)Math.Round(yl1));
            g.DrawLine(graphPenGray, (int)Math.Round(xl1), 320 - (int)Math.Round(yl1), (int)Math.Round(xl2), 320 - (int)Math.Round(yl2));
            g.DrawLine(graphPenBlue, (int)Math.Round(xl2), 320 - (int)Math.Round(yl2), (int)Math.Round(xl3), 320 - (int)Math.Round(yl3));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            nilai1 = Convert.ToInt16(txtS1.Text);
            hasil1 = nilai1 - 5;
            txtS1.Text = Convert.ToString(hasil1);

            double teta1 = Convert.ToDouble(txtS1.Text) * Math.PI / 180;
            double xl1 = Convert.ToInt16(txtL1.Text) * Math.Cos(teta1);
            double yl1 = Convert.ToInt16(txtL1.Text) * Math.Sin(teta1);

            double teta2 = Convert.ToDouble(txtS2.Text) * Math.PI / 180;
            double xl2 = xl1 + Convert.ToInt16(txtL2.Text) * Math.Cos(teta2 + teta1);
            double yl2 = yl1 + Convert.ToInt16(txtL2.Text) * Math.Sin(teta2 + teta1);

            double teta3 = Convert.ToDouble(txtS3.Text) * Math.PI / 180;
            double xl3 = xl2 + Convert.ToInt16(txtL3.Text) * Math.Cos(teta3 + teta2 + teta1);
            double yl3 = yl2 + Convert.ToInt16(txtL3.Text) * Math.Sin(teta3 + teta2 + teta1);

            Graphics g = pictureBox1.CreateGraphics();
            g.Clear(Color.White);

            g.DrawLine(graphPenRed, 0, 320, (int)Math.Round(xl1), 320 - (int)Math.Round(yl1));
            g.DrawLine(graphPenGray, (int)Math.Round(xl1), 320 - (int)Math.Round(yl1), (int)Math.Round(xl2), 320 - (int)Math.Round(yl2));
            g.DrawLine(graphPenBlue, (int)Math.Round(xl2), 320 - (int)Math.Round(yl2), (int)Math.Round(xl3), 320 - (int)Math.Round(yl3));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            nilai1 = Convert.ToInt16(txtS1.Text);
            hasil1 = nilai1 + 5;
            txtS1.Text = Convert.ToString(hasil1);

            double teta1 = Convert.ToDouble(txtS1.Text) * Math.PI / 180;
            double xl1 = Convert.ToInt16(txtL1.Text) * Math.Cos(teta1);
            double yl1 = Convert.ToInt16(txtL1.Text) * Math.Sin(teta1);

            double teta2 = Convert.ToDouble(txtS2.Text) * Math.PI / 180;
            double xl2 = xl1 + Convert.ToInt16(txtL2.Text) * Math.Cos(teta2 + teta1);
            double yl2 = yl1 + Convert.ToInt16(txtL2.Text) * Math.Sin(teta2 + teta1);

            double teta3 = Convert.ToDouble(txtS3.Text) * Math.PI / 180;
            double xl3 = xl2 + Convert.ToInt16(txtL3.Text) * Math.Cos(teta3 + teta2 + teta1);
            double yl3 = yl2 + Convert.ToInt16(txtL3.Text) * Math.Sin(teta3 + teta2 + teta1);

            Graphics g = pictureBox1.CreateGraphics();
            g.Clear(Color.White);

            g.DrawLine(graphPenRed, 0, 320, (int)Math.Round(xl1), 320 - (int)Math.Round(yl1));
            g.DrawLine(graphPenGray, (int)Math.Round(xl1), 320 - (int)Math.Round(yl1), (int)Math.Round(xl2), 320 - (int)Math.Round(yl2));
            g.DrawLine(graphPenBlue, (int)Math.Round(xl2), 320 - (int)Math.Round(yl2), (int)Math.Round(xl3), 320 - (int)Math.Round(yl3));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            nilai2 = Convert.ToInt16(txtS2.Text);
            hasil2 = nilai2 - 5;
            txtS2.Text = Convert.ToString(hasil2);

            double teta1 = Convert.ToDouble(txtS1.Text) * Math.PI / 180;
            double xl1 = Convert.ToInt16(txtL1.Text) * Math.Cos(teta1);
            double yl1 = Convert.ToInt16(txtL1.Text) * Math.Sin(teta1);

            double teta2 = Convert.ToDouble(txtS2.Text) * Math.PI / 180;
            double xl2 = xl1 + Convert.ToInt16(txtL2.Text) * Math.Cos(teta2 + teta1);
            double yl2 = yl1 + Convert.ToInt16(txtL2.Text) * Math.Sin(teta2 + teta1);

            double teta3 = Convert.ToDouble(txtS3.Text) * Math.PI / 180;
            double xl3 = xl2 + Convert.ToInt16(txtL3.Text) * Math.Cos(teta3 + teta2 + teta1);
            double yl3 = yl2 + Convert.ToInt16(txtL3.Text) * Math.Sin(teta3 + teta2 + teta1);

            Graphics g = pictureBox1.CreateGraphics();
            g.Clear(Color.White);

            g.DrawLine(graphPenRed, 0, 320, (int)Math.Round(xl1), 320 - (int)Math.Round(yl1));
            g.DrawLine(graphPenGray, (int)Math.Round(xl1), 320 - (int)Math.Round(yl1), (int)Math.Round(xl2), 320 - (int)Math.Round(yl2));
            g.DrawLine(graphPenBlue, (int)Math.Round(xl2), 320 - (int)Math.Round(yl2), (int)Math.Round(xl3), 320 - (int)Math.Round(yl3));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            nilai2 = Convert.ToInt16(txtS2.Text);
            hasil2 = nilai2 + 5;
            txtS2.Text = Convert.ToString(hasil2);

            double teta1 = Convert.ToDouble(txtS1.Text) * Math.PI / 180;
            double xl1 = Convert.ToInt16(txtL1.Text) * Math.Cos(teta1);
            double yl1 = Convert.ToInt16(txtL1.Text) * Math.Sin(teta1);

            double teta2 = Convert.ToDouble(txtS2.Text) * Math.PI / 180;
            double xl2 = xl1 + Convert.ToInt16(txtL2.Text) * Math.Cos(teta2 + teta1);
            double yl2 = yl1 + Convert.ToInt16(txtL2.Text) * Math.Sin(teta2 + teta1);

            double teta3 = Convert.ToDouble(txtS3.Text) * Math.PI / 180;
            double xl3 = xl2 + Convert.ToInt16(txtL3.Text) * Math.Cos(teta3 + teta2 + teta1);
            double yl3 = yl2 + Convert.ToInt16(txtL3.Text) * Math.Sin(teta3 + teta2 + teta1);

            Graphics g = pictureBox1.CreateGraphics();
            g.Clear(Color.White);

            g.DrawLine(graphPenRed, 0, 320, (int)Math.Round(xl1), 320 - (int)Math.Round(yl1));
            g.DrawLine(graphPenGray, (int)Math.Round(xl1), 320 - (int)Math.Round(yl1), (int)Math.Round(xl2), 320 - (int)Math.Round(yl2));
            g.DrawLine(graphPenBlue, (int)Math.Round(xl2), 320 - (int)Math.Round(yl2), (int)Math.Round(xl3), 320 - (int)Math.Round(yl3));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            nilai3 = Convert.ToInt16(txtS3.Text);
            hasil3 = nilai3 - 5;
            txtS3.Text = Convert.ToString(hasil3);

            double teta1 = Convert.ToDouble(txtS1.Text) * Math.PI / 180;
            double xl1 = Convert.ToInt16(txtL1.Text) * Math.Cos(teta1);
            double yl1 = Convert.ToInt16(txtL1.Text) * Math.Sin(teta1);

            double teta2 = Convert.ToDouble(txtS2.Text) * Math.PI / 180;
            double xl2 = xl1 + Convert.ToInt16(txtL2.Text) * Math.Cos(teta2 + teta1);
            double yl2 = yl1 + Convert.ToInt16(txtL2.Text) * Math.Sin(teta2 + teta1);

            double teta3 = Convert.ToDouble(txtS3.Text) * Math.PI / 180;
            double xl3 = xl2 + Convert.ToInt16(txtL3.Text) * Math.Cos(teta3 + teta2 + teta1);
            double yl3 = yl2 + Convert.ToInt16(txtL3.Text) * Math.Sin(teta3 + teta2 + teta1);

            Graphics g = pictureBox1.CreateGraphics();
            g.Clear(Color.White);

            g.DrawLine(graphPenRed, 0, 320, (int)Math.Round(xl1), 320 - (int)Math.Round(yl1));
            g.DrawLine(graphPenGray, (int)Math.Round(xl1), 320 - (int)Math.Round(yl1), (int)Math.Round(xl2), 320 - (int)Math.Round(yl2));
            g.DrawLine(graphPenBlue, (int)Math.Round(xl2), 320 - (int)Math.Round(yl2), (int)Math.Round(xl3), 320 - (int)Math.Round(yl3));
        }

        private void button6_Click(object sender, EventArgs e)
        {
            nilai3 = Convert.ToInt16(txtS3.Text);
            hasil3 = nilai3 + 5;
            txtS3.Text = Convert.ToString(hasil3);

            double teta1 = Convert.ToDouble(txtS1.Text) * Math.PI / 180;
            double xl1 = Convert.ToInt16(txtL1.Text) * Math.Cos(teta1);
            double yl1 = Convert.ToInt16(txtL1.Text) * Math.Sin(teta1);

            double teta2 = Convert.ToDouble(txtS2.Text) * Math.PI / 180;
            double xl2 = xl1 + Convert.ToInt16(txtL2.Text) * Math.Cos(teta2 + teta1);
            double yl2 = yl1 + Convert.ToInt16(txtL2.Text) * Math.Sin(teta2 + teta1);

            double teta3 = Convert.ToDouble(txtS3.Text) * Math.PI / 180;
            double xl3 = xl2 + Convert.ToInt16(txtL3.Text) * Math.Cos(teta3 + teta2 + teta1);
            double yl3 = yl2 + Convert.ToInt16(txtL3.Text) * Math.Sin(teta3 + teta2 + teta1);

            Graphics g = pictureBox1.CreateGraphics();
            g.Clear(Color.White);

            g.DrawLine(graphPenRed, 0, 320, (int)Math.Round(xl1), 320 - (int)Math.Round(yl1));
            g.DrawLine(graphPenGray, (int)Math.Round(xl1), 320 - (int)Math.Round(yl1), (int)Math.Round(xl2), 320 - (int)Math.Round(yl2));
            g.DrawLine(graphPenBlue, (int)Math.Round(xl2), 320 - (int)Math.Round(yl2), (int)Math.Round(xl3), 320 - (int)Math.Round(yl3));
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                int a, b, c;
                a = 90;
                b = Convert.ToInt16(vScrollBar1.Value);
                c = a-b;

                txtS1.Text = c.ToString();
                double teta1 = Convert.ToDouble(txtS1.Text) * Math.PI / 180;
                double xl1 = Convert.ToInt16(txtL1.Text) * Math.Cos(teta1);
                double yl1 = Convert.ToInt16(txtL1.Text) * Math.Sin(teta1);

                double teta2 = Convert.ToDouble(txtS2.Text) * Math.PI / 180;
                double xl2 = xl1 + Convert.ToInt16(txtL2.Text) * Math.Cos(teta2 + teta1);
                double yl2 = yl1 + Convert.ToInt16(txtL2.Text) * Math.Sin(teta2 + teta1);

                double teta3 = Convert.ToDouble(txtS3.Text) * Math.PI / 180;
                double xl3 = xl2 + Convert.ToInt16(txtL3.Text) * Math.Cos(teta3 + teta2 + teta1);
                double yl3 = yl2 + Convert.ToInt16(txtL3.Text) * Math.Sin(teta3 + teta2 + teta1);

                Graphics g = pictureBox1.CreateGraphics();
                g.Clear(Color.White);

                g.DrawLine(graphPenRed, 0, 320, (int)Math.Round(xl1), 320 - (int)Math.Round(yl1));
                g.DrawLine(graphPenGray, (int)Math.Round(xl1), 320 - (int)Math.Round(yl1), (int)Math.Round(xl2), 320 - (int)Math.Round(yl2));
                g.DrawLine(graphPenBlue, (int)Math.Round(xl2), 320 - (int)Math.Round(yl2), (int)Math.Round(xl3), 320 - (int)Math.Round(yl3));
            }
        }

        private void vScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                int a, b, c;
                a = 90;
                b = Convert.ToInt16(vScrollBar2.Value);
                c = a-b;

                txtS2.Text = c.ToString();
                double teta1 = Convert.ToDouble(txtS1.Text) * Math.PI / 180;
                double xl1 = Convert.ToInt16(txtL1.Text) * Math.Cos(teta1);
                double yl1 = Convert.ToInt16(txtL1.Text) * Math.Sin(teta1);

                double teta2 = Convert.ToDouble(txtS2.Text) * Math.PI / 180;
                double xl2 = xl1 + Convert.ToInt16(txtL2.Text) * Math.Cos(teta2 + teta1);
                double yl2 = yl1 + Convert.ToInt16(txtL2.Text) * Math.Sin(teta2 + teta1);

                double teta3 = Convert.ToDouble(txtS3.Text) * Math.PI / 180;
                double xl3 = xl2 + Convert.ToInt16(txtL3.Text) * Math.Cos(teta3 + teta2 + teta1);
                double yl3 = yl2 + Convert.ToInt16(txtL3.Text) * Math.Sin(teta3 + teta2 + teta1);

                Graphics g = pictureBox1.CreateGraphics();
                g.Clear(Color.White);

                g.DrawLine(graphPenRed, 0, 320, (int)Math.Round(xl1), 320 - (int)Math.Round(yl1));
                g.DrawLine(graphPenGray, (int)Math.Round(xl1), 320 - (int)Math.Round(yl1), (int)Math.Round(xl2), 320 - (int)Math.Round(yl2));
                g.DrawLine(graphPenBlue, (int)Math.Round(xl2), 320 - (int)Math.Round(yl2), (int)Math.Round(xl3), 320 - (int)Math.Round(yl3));
            }
        }

        private void vScrollBar3_Scroll(object sender, ScrollEventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                int a, b, c;
                a = 90;
                b = Convert.ToInt16(vScrollBar3.Value);
                c = a - b;

                txtS3.Text = c.ToString();
                double teta1 = Convert.ToDouble(txtS1.Text) * Math.PI / 180;
                double xl1 = Convert.ToInt16(txtL1.Text) * Math.Cos(teta1);
                double yl1 = Convert.ToInt16(txtL1.Text) * Math.Sin(teta1);

                double teta2 = Convert.ToDouble(txtS2.Text) * Math.PI / 180;
                double xl2 = xl1 + Convert.ToInt16(txtL2.Text) * Math.Cos(teta2 + teta1);
                double yl2 = yl1 + Convert.ToInt16(txtL2.Text) * Math.Sin(teta2 + teta1);

                double teta3 = Convert.ToDouble(txtS3.Text) * Math.PI / 180;
                double xl3 = xl2 + Convert.ToInt16(txtL3.Text) * Math.Cos(teta3 + teta2 + teta1);
                double yl3 = yl2 + Convert.ToInt16(txtL3.Text) * Math.Sin(teta3 + teta2 + teta1);

                Graphics g = pictureBox1.CreateGraphics();
                g.Clear(Color.White);

                g.DrawLine(graphPenRed, 0, 320, (int)Math.Round(xl1), 320 - (int)Math.Round(yl1));
                g.DrawLine(graphPenGray, (int)Math.Round(xl1), 320 - (int)Math.Round(yl1), (int)Math.Round(xl2), 320 - (int)Math.Round(yl2));
                g.DrawLine(graphPenBlue, (int)Math.Round(xl2), 320 - (int)Math.Round(yl2), (int)Math.Round(xl3), 320 - (int)Math.Round(yl3));
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            pictureBox1.Invalidate();
            txtL1.Text = "";
            txtL2.Text = "";
            txtL3.Text = "";
            txtS1.Text = "";
            txtS2.Text = "";
            txtS3.Text = "";
            checkBox1.Checked = false;
            vScrollBar1.Value = 99;
            vScrollBar2.Value = 99;
            vScrollBar3.Value = 99;
        }
    }
}