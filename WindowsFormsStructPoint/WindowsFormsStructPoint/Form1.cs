﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsStructPoint
{
    struct Cube
    {
        double side;
        public Cube(double s)
        {
            side = s;
        }
        public double showVolume()
        {
            double v = side * side * side;
            return v;
        }


    }


    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            unsafe
            {
                Cube* pointToCube;
                Cube mycube = new Cube(2);
                pointToCube = &mycube;

                MessageBox.Show("volume =" + (*pointToCube).showVolume());
                MessageBox.Show("volume =" + pointToCube->showVolume());
            }
        }
    }
}
