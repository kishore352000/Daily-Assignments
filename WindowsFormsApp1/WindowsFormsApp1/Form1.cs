using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public class SavingAccount
        {
            string AccountNo, AccountHolder;
            double BalanceAmount, InterestRate;

            internal void OpenAccount(string name, string number, double amount)
            {
                AccountHolder = name;
                AccountNo = number;
                BalanceAmount = amount;
            }

            public void debit(double amount)
            {
                BalanceAmount -= amount;
            }

            public void credit(double amount)
            {
                BalanceAmount += amount;
            }

            public void ApplyInterest()
            {
                BalanceAmount += BalanceAmount * InterestRate;
            }

            public void ShowBalance()
            {
                MessageBox.Show("Your balance amount is Rs " + BalanceAmount);
            }

            internal void ShowAccount()
            {
                MessageBox.Show("Account Holder's Name : " + AccountHolder);
                MessageBox.Show("Account Number : " + AccountNo);
            }
        }

        public Form1()
        {

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SavingAccount myAc = new SavingAccount();
            myAc.OpenAccount("Kishore", "1234567", 10000.00);
            myAc.credit(1000.00);
            myAc.debit(100.00);
            myAc.ShowBalance();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SavingAccount myAc = new SavingAccount();
            myAc.OpenAccount("Kishore", "1234567", 10000.00);
            myAc.ShowAccount();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SavingAccount myAc = new SavingAccount();
            myAc.OpenAccount("Venkata", "2847629", 100000.00);
            myAc.credit(25000.00);
            myAc.debit(10000.00);
            myAc.ShowBalance();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SavingAccount myAc = new SavingAccount();
            myAc.OpenAccount("Venkata", "2847629", 100000.00);
            myAc.ShowAccount();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SavingAccount myAc = new SavingAccount();
            myAc.OpenAccount("reddy", "28448241", 30000.00);
            myAc.credit(20000.00);
            myAc.debit(10000.00);
            myAc.ShowBalance();
        }
    }
    }
