using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsStructures
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public struct EmployeeRecord
        {
            public string EmployeeName, DateOfJoining;
            public int salary;
            public EmployeeRecord(string name, int sal, string date)
            {
                EmployeeName = name;
                DateOfJoining = date;
                salary = sal;



            }
            public void ShowEmployeeDetails()
            {
                MessageBox.Show("Employee Name: " + EmployeeName);
                MessageBox.Show("Date of Joining: " + DateOfJoining);
                MessageBox.Show("Salary: " + salary);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EmployeeRecord emp = new EmployeeRecord("Kishore", 30000, "04-07-2022");
            emp.ShowEmployeeDetails();
        }
    }
}
