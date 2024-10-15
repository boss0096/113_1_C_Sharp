namespace tutorial_3_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double miles;
            double gallons;
            double mpg;

            miles = double.Parse(tbxMiles.Text);

            gallons = double.Parse(tbxGallons.Text);

            mpg = miles / gallons;

            lblMpg.Text = mpg.ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
