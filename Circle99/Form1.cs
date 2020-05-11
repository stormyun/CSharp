﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Circle99
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random randomColor = new Random();
        Color getRandomColor()
        {
            return Color.FromArgb(
                randomColor.Next(256),
                randomColor.Next(256),
                randomColor.Next(256));
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();

            int x0 = this.Width / 2;
            int y0 = this.Height / 2;

            for (int r = 0; r < this.Height / 2; r++)
            {
                g.DrawEllipse(
                    new Pen(getRandomColor(), 1),
                    x0 - r, y0 - r, r * 2, r * 2
                    );
            }
            g.Dispose();
        }
    }
}
