using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace class7
{
    public partial class Form1 : Form
    {
        Graphics graphics;
        int n;
        double length;
        double per1;
        double per2;
        double th1 ;
        double th2 ;
        Pen pen = Pens.Red;

        void DrawCayleyTree(int n, double x0, double y0, double length, double th)
        {
            if (n == 0) return;
            double x1 = x0 + length * Math.Cos(th);
            double y1 = y0 + length * Math.Sin(th);
            graphics.DrawLine(pen, (int)x0, (int)y0, (int)x1, (int)y1);
            DrawCayleyTree(n - 1, x1, y1, per1 * length, th + th1);
            DrawCayleyTree(n - 1, x1, y1, per2 * length, th - th2);
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Draw_Click(object sender, EventArgs e)
        {

            if (graphics == null)
            {
                graphics = panel1.CreateGraphics();
                n = 10;
                length = 100;
                per1 = 0.6;
                per2 = 0.7;
                th1 = 30 * Math.PI / 180;
                th2 = 30 * Math.PI / 180;

            }
            graphics.Clear(panel1.BackColor);
            ErrorBox.Text = "Error Information:";
            pen = new Pen(colorDialog1.Color, 5);
            //DrawCayleyTree(10, 300, 500, 50, 80);

            DrawCayleyTree(n, 300, 510, length, -Math.PI/2);



        }

        private void Depth_B_TextChanged(object sender, EventArgs e)
        {
            try
            {
                n = int.Parse(Depth_B.Text);
                if (n < 0) { n = 10; }
            }
            catch (FormatException)
            {
                n = 10;//default
                ErrorBox.Text += "depth error!! set to 100 by default\n";
            }
            catch (ArgumentNullException)
            {
                n = 10;//default
                ErrorBox.Text += "depth error!! set to 100 by default\n";
            }

        }

        private void Color_Click(object sender, EventArgs e)
        {
            DialogResult dialog = colorDialog1.ShowDialog();
            if (dialog == DialogResult.OK)
            {
                Color.BackColor = colorDialog1.Color;
            }
        }

        private void Leng_B_TextChanged(object sender, EventArgs e)
        {
            try
            {
                length = double.Parse(Leng_B.Text);
                if (length < 0) { length = 100; }
            }
            catch (FormatException)
            {
                length = 100;//default
                ErrorBox.Text += "length error!! set to 100 by default\n";
            }
            catch (ArgumentNullException)
            {
                length = 100;//default
                ErrorBox.Text +=  "length error!! set to 100 by default\n";
            }
        }

        private void PR_B_TextChanged(object sender, EventArgs e)
        {
            try
            {
                per1 = double.Parse(PR_B.Text);
                if (per1 < 0) { per1 = 0.6; }
            }
            catch (FormatException)
            {
                per1 = 0.6;
                ErrorBox.Text += "per right error!! set to 0.6 by default\n";
            }
            catch (ArgumentNullException)
            {
                per1 = 0.6;
                ErrorBox.Text += "per right error!! set to 0.6 by default\n";
            }
        }

        private void PL_B_TextChanged(object sender, EventArgs e)
        {
            try
            {
                per2 = double.Parse(PL_B.Text);
                if (per2 < 0) { per2 = 0.7; }
            }
            catch (FormatException)
            {
                per2 = 0.7;
                ErrorBox.Text += "per right error!! set to 0.7 by default\n";
            }
            catch (ArgumentNullException)
            {
                per2 = 0.7;
                ErrorBox.Text += "per right error!! set to 0.7 by default\n";
            }
        }

        private void AR_B_TextChanged(object sender, EventArgs e)
        {
            if (!double.TryParse(AR_B.Text, out th1))
            {
                th1 = 30 * Math.PI / 180;
                ErrorBox.Text += "angle right error!! set to 0.7 by default\r\n";
            }

        }

        private void AL_B_TextChanged(object sender, EventArgs e)
        {
            if (!double.TryParse(AL_B.Text, out th2))
            {
                th2 = 30 * Math.PI / 180;
                ErrorBox.Text += "angle right error!! set to 0.7 by default\n";

            }

        }
    }
}
