namespace tutorial_3_4
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
                double test1;
                double test2;
                double test3;
                double average;

                test1 = double.Parse(tbxTest1.Text);
                test2 = double.Parse(tbxTest2.Text);
                test3 = double.Parse(tbxTest3.Text);

                average = (test1 + test2 + test3) / 3;

                lblShow.Text = average.ToString("n1");
            }
            catch (Exception ex)
            {
                MessageBox.Show("¿é¤J¿ù»~");
                tbxTest1.Focus();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbxTest1.Text = "";
            tbxTest2.Text = "";
            tbxTest3.Text = "";
            lblShow.Text = ""; 

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
}
