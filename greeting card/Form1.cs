﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

/// <summary>
/// 
/// </summary>
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
            //Setup
            Graphics g = this.CreateGraphics();
            Font titleFont = new Font("Impact", 20, FontStyle.Bold);
            Font descriptionFont = new Font("Times New Roman", 20, FontStyle.Bold);
            SolidBrush drawBrush = new SolidBrush(Color.White);
            Font nameFont = new Font("Arial", 10, FontStyle.Bold);


            //Clear Background
            this.BackgroundImage = null;
            Refresh();
            g.Clear(Color.Black);
            SoundPlayer player2 = new SoundPlayer(Properties.Resources.end);
            SoundPlayer player = new SoundPlayer(Properties.Resources.ding);

            //Show Constellation
            g.FillEllipse(drawBrush, 130, 155, 10, 10);
            player.Play();
            Thread.Sleep(300);
            g.FillEllipse(drawBrush, 251, 149, 7, 7);
            player.Play();
            Thread.Sleep(300);
            g.FillEllipse(drawBrush, 316, 197, 11, 11);
            player.Play();
            Thread.Sleep(300);
            g.FillEllipse(drawBrush, 400, 250, 6, 6);
            player.Play();
            Thread.Sleep(300);
            g.FillEllipse(drawBrush, 409, 339, 12, 12);
            player.Play();
            Thread.Sleep(300);
            g.FillEllipse(drawBrush, 551, 338, 10, 10);
            player.Play();
            Thread.Sleep(300);
            g.FillEllipse(drawBrush, 589, 264, 11, 11);
            player.Play();
            Thread.Sleep(3000);
            g.Clear(Color.Black);
            //Constellation Name
            g.DrawString("The Big Dipper", titleFont, drawBrush, 275, 100);

            //Constellation Description
            player2.Play();
            SolidBrush drawBrush3 = new SolidBrush(Color.Blue);
            g.DrawString("The Big Dipper or the Plough is a large asterism", descriptionFont, drawBrush3, 5, 225);
            Thread.Sleep(200);
            g.DrawString("consisting of seven bright stars of the constellation", descriptionFont, drawBrush3, 5, 245);
            Thread.Sleep(200);
            g.DrawString("Ursa Major six of them are of second magnitude and", descriptionFont, drawBrush3, 5, 265);
            Thread.Sleep(200);
            g.DrawString("one, Megrez, of third magnitude.", descriptionFont, drawBrush3, 5, 285);
            Thread.Sleep(200);
            g.DrawString("Four define a bowl and three define a handle or head.", descriptionFont, drawBrush3, 5, 305);
            Thread.Sleep(200);
            g.DrawString("It is recognized as a distinct grouping in many cultures.", descriptionFont, drawBrush3, 5, 325);
        }
            private void Form1_Shown(object sender, EventArgs e)
        {
            //Title Page
            Graphics g = this.CreateGraphics();
            SolidBrush drawBrush2 = new SolidBrush(Color.Red);
            Font titleFont = new Font("Impact", 30, FontStyle.Bold);
            Font signFont = new Font("Arial", 20, FontStyle.Bold);
            SolidBrush drawBrush = new SolidBrush(Color.White);

            g.DrawString("The Big Dipper", titleFont, drawBrush, 275, 100);
            g.DrawString("By: Jordan Sinclair", signFont, drawBrush2, 275, 400);
        }
    }
}
