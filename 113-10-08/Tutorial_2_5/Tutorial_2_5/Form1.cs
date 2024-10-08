namespace Tutorial_2_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //show the card backe
        private void btnshowback_Click(object sender, EventArgs e)
        {
            ptxback.Visible = true;  //visible屬性為假
            ptxface.Visible = false;
        }
        //show the card face
        private void btnshowface_Click(object sender, EventArgs e)
        {
            ptxback.Visible = false;
            ptxface.Visible = true;
        }

        private void btnescape_Click(object sender, EventArgs e)
        {
            this.Close();
            /*-----------------------------------
             班級:口傳二乙
             姓名:姚彥宇
             學號:A112060096
            -----------------------------------*/
        }
    }

}
