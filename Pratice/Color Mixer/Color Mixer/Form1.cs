namespace Color_Mixer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMix_Click(object sender, EventArgs e)
        {
            if (rdbRed.Checked && rdbb.Checked || rdbBlue.Checked && rdbr.Checked)
            {
                this.BackColor = Color.Purple;
            }
            if (rdbRed.Checked && rdby.Checked || rdbYellow.Checked && rdbr.Checked)
            {
                this.BackColor = Color.Orange;
            }
            if (rdbBlue.Checked && rdby.Checked || rdbYellow.Checked && rdbb.Checked)
            {
                this.BackColor = Color.Green;
            }
            if (rdbRed.Checked && rdbr.Checked)
            {
                this.BackColor = Color.Red;
            }
            if (rdbBlue.Checked && rdbb.Checked)
            {
                this.BackColor = Color.Blue;
            }
            if (rdbYellow.Checked && rdby.Checked)
            {
                this.BackColor = Color.Yellow;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
