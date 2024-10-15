namespace Hw1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ptxAceOfHearts_Click(object sender, EventArgs e)
        {
            lblShow.Text = "Ace of Hearts";
        }

        private void ptxTwoOfClubs_Click(object sender, EventArgs e)
        {
            lblShow.Text = "Two of Clubs";
        }

        private void ptxTenOfDiamonds_Click(object sender, EventArgs e)
        {
            lblShow.Text = "Ten of Diamonds";
        }

        private void ptxSixOfSpades_Click(object sender, EventArgs e)
        {
            lblShow.Text = "Six of Spades";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
