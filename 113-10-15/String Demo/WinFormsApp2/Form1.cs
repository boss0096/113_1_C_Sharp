namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShowName_Click(object sender, EventArgs e)
        {
            string FullName;
            string FirstName;
            string LastName;

            FirstName =tbxLastName.Text;
            LastName=tbxLastName.Text;
            FullName = tbxLastName.Text + " " + tbxFirstName.Text;
            lblNameFUll.Text = FullName;

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
