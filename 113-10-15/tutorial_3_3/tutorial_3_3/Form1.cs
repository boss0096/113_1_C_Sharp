namespace tutorial_3_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCulculate_Click(object sender, EventArgs e)
        {
            decimal originalPrice;
            decimal discountPercentage;
            decimal discountAmount;
            decimal salePrice;

            originalPrice = decimal.Parse(tbxOriginal.Text);
            discountPercentage = decimal.Parse(tbxDiscount.Text);

            discountPercentage = discountPercentage / 100;

            discountAmount = originalPrice * discountPercentage;

            salePrice = originalPrice - discountAmount;

            lblSale.Text  = salePrice.ToString();




        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
}
