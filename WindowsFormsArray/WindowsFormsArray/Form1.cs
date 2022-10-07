using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsArray
{
    public partial class Form1 : Form
    {
        public class Bottle
        {
            int[] height = { 10, 15, 20, 30, 40 };
            int[] volume = { 2, 6, 8, 12, 25 };



            public void bottleHeight()
            {
                for (int i = 0; i < height.Length; i++)
                {
                    MessageBox.Show("height of bottle : " + height[i]);
                }
            }
            public void bottleVolume()
            {
                for (int i = 0; i < volume.Length; i++)
                {
                    MessageBox.Show("volume of bottle : " + volume[i] + " litres");
                }
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bottle b = new Bottle();
            b.bottleHeight();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bottle b = new Bottle();
            b.bottleVolume();
        }
    }
}
