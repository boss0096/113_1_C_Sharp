namespace Stadium_Seating
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
                decimal ClassA;
                decimal ClassB;
                decimal ClassC;
                decimal Total;

                ClassA = decimal.Parse(tbxA.Text) * 15;
                ClassB = decimal.Parse(tbxB.Text) * 12;
                ClassC = decimal.Parse(tbxC.Text) * 9;
                Total = (ClassA + ClassB + ClassC);

                lblAShow.Text = ClassA.ToString("n2");
                lblShowB.Text = ClassB.ToString("n2");
                lblShowC.Text = ClassC.ToString("n2");

                lblTShow.Text = Total.ToString("n2");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Input Error");
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbxA.Text = "";
            tbxB.Text = "";
            tbxC.Text = "";
            
            lblAShow.Text = tbxA.Text;
            lblShowB.Text = tbxB.Text;
            lblShowC.Text = tbxC.Text;
            lblTShow.Text = "";

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
