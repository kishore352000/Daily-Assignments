﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsPointers
{

        public struct Student
        {
            unsafe string StudentName;
            int Marks, MaxMarks;
            public void student(string n, int m, int max)
            {
                StudentName = n;
                Marks = m;
                MaxMarks = max;
            }
            public void ShowStudent()
            {
                //unsafe double percent;
                double percent;
                percent = (Marks % MaxMarks);
                unsafe
                {
                    MessageBox.Show("Name of Student : " + StudentName);
                    MessageBox.Show("Percentage : " + percent);
                }
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
                int* myptr;
                int myvar = 233;
                myptr = &myvar;
                for (int i = 0; i < 3; i++)
                {
                    *myptr -= 1;
                    MessageBox.Show("Second var after the iteration is : " + *myptr);
                    MessageBox.Show("Address" + (uint)myptr);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            unsafe
            {
                int* myptr2;
                int myVar2 = 311;
                myptr2 = &myVar2;
                MessageBox.Show("Value stored in 2nd Var is " + *myptr2);
                for (int i = 0; i < 3; i++)
                {
                    *myptr2 -= 1;
                    MessageBox.Show("Second var after the iteration is : " + *myptr2);
                }
            }
        }
    }
    
}
