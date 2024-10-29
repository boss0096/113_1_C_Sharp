using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loan_Qualifier
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            decimal salary;
            int yearsOnJob;
            const decimal MINIMUM_SALART = 1300000m;
            const int MINIMUM_YEARS_ON_JOB = 2;

            try 
            {            
                salary = decimal.Parse(salaryTextBox.Text);
                yearsOnJob = int.Parse(yearsTextBox.Text);

                if(salary > MINIMUM_SALART)
                    {
                    if(yearsOnJob >= MINIMUM_YEARS_ON_JOB)
                        {
                        decisionLabel.Text = "You qualify for the loan.";
                    }
                    else
                    {
                        decisionLabel.Text = "Minimum years at current job not yet";
                    }
                }
                else
                {
                    decisionLabel.Text = "Minimum salary requirement not yet";
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // Clear the TextBoxes and the decisionLabel.
            salaryTextBox.Text = "";
            yearsTextBox.Text = "";
            decisionLabel.Text = "";

            // Reset the focus.
            salaryTextBox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
