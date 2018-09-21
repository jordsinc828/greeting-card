using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace greeting_card
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void Form1_Click(object sender, EventArgs e)
        {

            Graphics g = this.CreateGraphics();
            Font titleFont = new Font("Arial", 20, FontStyle.Bold);
            SolidBrush drawBrush = new SolidBrush(Color.White);
            Font nameFont = new Font("Arial", 10, FontStyle.Bold);

            //Clear Background
            this.BackgroundImage = null;
            Refresh();
            g.Clear(Color.Black);
           
            //Show Constellation
            g.FillEllipse(drawBrush, 130, 155, 10, 10);
            Thread.Sleep(300);
            g.FillEllipse(drawBrush, 251, 149, 7, 7);
            Thread.Sleep(300);
            g.FillEllipse(drawBrush, 316, 197, 11, 11);
            Thread.Sleep(300);
            g.FillEllipse(drawBrush, 400, 250, 6, 6);
            Thread.Sleep(300);
            g.FillEllipse(drawBrush, 409, 339, 12, 12);
            Thread.Sleep(300);
            g.FillEllipse(drawBrush, 551, 338, 10, 10);
            Thread.Sleep(300);
            g.FillEllipse(drawBrush, 589, 264, 11, 11);

            //Constellation Name
            g.DrawString("The Big Dipper", titleFont, drawBrush, 275, 100);

            
            


        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            //Title Page
            Graphics g = this.CreateGraphics();
            Font titleFont = new Font("Arial", 30, FontStyle.Bold);
            Font signFont = new Font("Arial", 20, FontStyle.Bold);
            SolidBrush drawBrush = new SolidBrush(Color.White);

            g.DrawString("The Big Dipper", titleFont, drawBrush, 275, 100);
            g.DrawString("By: Jordan Sinclair", signFont, drawBrush, 275, 400);
        }
    }
}
