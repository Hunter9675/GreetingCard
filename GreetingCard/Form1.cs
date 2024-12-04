using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Media;

namespace GreetingCard
{
    public partial class Form1 : Form
    {
        int i = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            // Tools

            Graphics g = this.CreateGraphics();
            SolidBrush redBrush = new SolidBrush(Color.Red);
            Pen bigblackPen = new Pen(Color.Black, 10);
            Font drawFont = new Font("Arial", 12, FontStyle.Bold);
            SolidBrush blacktextBrush = new SolidBrush(Color.Black);
            g.DrawString("From: Hunter", drawFont, blacktextBrush, 400, 200);
            g.DrawString("To: Mr. T", drawFont, blacktextBrush, 400, 250);

            // Use of Tools

            g.DrawLine(bigblackPen, 0, 0, 253, 150);
            g.DrawLine(bigblackPen, 253, 150, 550, 0);
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            SoundPlayer sp = new SoundPlayer(Properties.Resources.jinglebells);
            sp.Play();


            // Tools

            Graphics g = this.CreateGraphics();
            SolidBrush redBrush = new SolidBrush(Color.Red);
            SolidBrush yellowBrush = new SolidBrush(Color.Yellow);
            Pen greenPen = new Pen(Color.Green, 50);
            Pen yellowPen = new Pen(Color.Yellow, 2);
            Pen redPen = new Pen(Color.Red, 2);
            Pen bigredPen = new Pen(Color.Red, 10);
            Font drawFont = new Font("Arial", 25, FontStyle.Bold);
            SolidBrush redtextBrush = new SolidBrush(Color.Red);


            // Use of Tools

            g.Clear(Color.LightBlue);
            g.DrawEllipse(greenPen, 180, 60, 150, 150);
           
            g.DrawLine(bigredPen, 255, 240, 300, 350);
            g.DrawLine(bigredPen, 255, 240, 230, 350);
            

            while (i <= 15)
            {

                if (i % 2 == 0)
                {
                    g.DrawEllipse(yellowPen, 180, 60, 20, 20);
                    g.FillEllipse(yellowBrush, 180, 60, 20, 20);
                    g.DrawEllipse(yellowPen, 295, 200, 20, 20);
                    g.FillEllipse(yellowBrush, 295, 200, 20, 20);
                    g.DrawEllipse(yellowPen, 295, 90, 20, 20);
                    g.FillEllipse(yellowBrush, 295, 90, 20, 20);
                    g.DrawEllipse(yellowPen, 295, 90, 20, 20);
                    g.FillEllipse(yellowBrush, 295, 90, 20, 20);
                    g.DrawEllipse(yellowPen, 160, 150, 20, 20);
                    g.FillEllipse(yellowBrush, 160, 150, 20, 20);
                }
                else if (i % 2 == 1)
                {
                    g.DrawEllipse(redPen, 180, 60, 20, 20);
                    g.FillEllipse(redBrush, 180, 60, 20, 20);
                    g.DrawEllipse(redPen, 295, 200, 20, 20);
                    g.FillEllipse(redBrush, 295, 200, 20, 20);
                    g.DrawEllipse(redPen, 295, 90, 20, 20);
                    g.FillEllipse(redBrush, 295, 90, 20, 20);
                    g.DrawEllipse(redPen, 295, 90, 20, 20);
                    g.FillEllipse(redBrush, 295, 90, 20, 20);
                    g.DrawEllipse(redPen, 160, 150, 20, 20);
                    g.FillEllipse(redBrush, 160, 150, 20, 20);
                    g.DrawEllipse(bigredPen, 260, 200, 120, 60);
                    g.DrawEllipse(bigredPen, 140, 200, 120, 60);
                }

                Thread.Sleep(500);   
                i++;

                if (i == 16)
                {
                    g.Clear(Color.LightBlue);
                    g.DrawString("Merry Christmas!", drawFont, redtextBrush, 100, 100);
                }


            }
        }
    }
}
