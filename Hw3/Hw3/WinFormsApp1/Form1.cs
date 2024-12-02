namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int initialBacteria = int.Parse(textBox1.Text);

            int doublingTime = int.Parse(textBox2.Text);



            try
            {
                for (int day = 1; day <= 10; day++)
                {
                    double growthFactor = Math.Pow(2, day / (double)doublingTime);

                    int bacteriaCount = (int)(initialBacteria * growthFactor);

                    listresult.Items.Add($"Day {day}: {bacteriaCount} bacteria");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("½Ð¿é¤J¼Æ¦r");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listresult.Items.Clear();
        }
    }
}
