﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fuel_Economy_with_TryParse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            double miles;
            double gallons;
            double mpg;

            if (double.TryParse(milesTextBox.Text, out miles))
            {
                if(double.TryParse(milesTextBox.Text, out gallons))
                {
                 mpg = miles/gallons;

                    mpgLabel.Text = mpg.ToString("n1");        
                }
                else
                {
                    MessageBox.Show("Invalid input for gallons.");
                }

        }
            else
            {
            MessageBox.Show("Invvalid input for miles.");
            }
           }
        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
