namespace tutorial_3_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShowDate_Click(object sender, EventArgs e)
        {
            string output;

            output = tbxDayOfWeek.Text + ", "
                + tbxMonth.Text + ", "
                + tbxDyaOfMonth.Text + ", " 
                + tbxYear.Text;

            lblShow.Text = output;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbxDayOfWeek.Text = "";

            tbxDyaOfMonth.Text = "";

            tbxMonth.Text = "";

            tbxYear.Text = "";

            lblShow.Text = "";

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
