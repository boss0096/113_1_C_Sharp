﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ending_Balance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {

            const decimal INTEREST_RATE = 0.005m;
            decimal balance;
            int months;
            
            if(decimal.TryParse(startingBalTextBox.Text, out balance))
            {
                int count = 1;

                if (int.TryParse(monthsTextBox.Text,out months))
                {
                    while(count <= months)
                        {
                    balance = balance +(INTEREST_RATE *balance);  
                        count = count + 1;
                    }
                    endingBalanceLabel.Text = balance.ToString("c");
                }
                else 
                {
                    MessageBox.Show("Invcalid value for months");
                }
            }
            else
            {
                MessageBox.Show("Invalid value for starting balance");
            }
        }


        private void clearButton_Click(object sender, EventArgs e)
        {
            // 清除 TextBoxes 和 endingBalanceLabel 控制項的內容。
            startingBalTextBox.Text = "";
            monthsTextBox.Text = "";
            endingBalanceLabel.Text = "";

            // 重設焦點。
            startingBalTextBox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單。
            this.Close();
        }
    }
}