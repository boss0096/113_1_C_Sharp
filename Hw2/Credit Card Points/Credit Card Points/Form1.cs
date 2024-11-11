namespace Credit_Card_Points
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                decimal Cost;
                Cost = decimal.Parse(tbxCost.Text);

                if (Cost <= 0)
                {
                    lblPoints.Text = " Wrong Number";
                }
                else if (Cost > 0 && Cost <= 100)
                {
                    lblPoints.Text = "1";
                }
                else if (Cost >= 101 && Cost <= 500)
                {
                    lblPoints.Text = "5";
                }
                else if (Cost >= 501 && Cost <= 1000)
                {
                    lblPoints.Text = "10";
                }
                else if (Cost >= 1001 && Cost <= 2000)
                {
                    lblPoints.Text = "15";
                }
                else
                {
                    lblPoints.Text = "20";
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Input Error");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbxCost.Text = "";
            lblPoints.Text = "";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
