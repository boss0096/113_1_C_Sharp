using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Change_Counter
{
    public partial class Form1 : Form
    {

        const decimal Five_Cents = 0.05m;
        const decimal Ten_Cents = 0.10m;
        const decimal Twenty_Cents = 0.25m;
        const decimal Fifty_Cents = 0.50m;

        private decimal total = 0m;

        public Form1()
        {
            InitializeComponent();
        }

        private void fiveCentsPictureBox_Click(object sender, EventArgs e)
        {
            total += Fifty_Cents;
            totalLabel.Text = total.ToString("C");
        }

        private void tenCentsPictureBox_Click(object sender, EventArgs e)
        {
            total += Ten_Cents;
            totalLabel.Text = total.ToString("C");
        }

        private void twentyFiveCentsPictureBox_Click(object sender, EventArgs e)
        {
            total += Fifty_Cents;
            totalLabel.Text = total.ToString("C");
        }

        private void fiftyCentsPictureBox_Click(object sender, EventArgs e)
        {
            total += Fifty_Cents;
            totalLabel.Text = total.ToString("C");
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            totalLabel.Text ="0";
        }
    }
}
