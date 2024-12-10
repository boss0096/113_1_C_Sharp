using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cards
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        private void showAceSpades()
        {
            aceSpadesPictureBox.Visible = true;
            tenHeartsPictureBox.Visible = false;
            kingClubsPictureBox.Visible = false;
        }
        private void showTenofHearts()
        {
            aceSpadesPictureBox.Visible = false;
            tenHeartsPictureBox.Visible = true;
            kingClubsPictureBox.Visible = false;
        }
        private void showKingofClubs()
        {
            aceSpadesPictureBox.Visible = false;
            tenHeartsPictureBox.Visible = false;
            kingClubsPictureBox.Visible = true;
        }
        private void showCard(string cardName)
        {
            switch (cardName)
            {
                case "Ace of Spades":
              showAceSpades();
                    break;
                case "10 of Hearts":
                 showTenofHearts();
                    break;
                case "King of Clubs":
                    showKingofClubs();
                    break;

            }
        }
            private void showCardButton_Click(object sender, EventArgs e)
        {
           if(cardListBox.SelectedIndex !=-1)
            {
                showCard(cardListBox.SelectedItem.ToString());
            }
           else
            {
                MessageBox.Show("select a card");

            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
