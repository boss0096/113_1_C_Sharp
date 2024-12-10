using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Load_Event
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            exitButton.Text = "離開";

            try
            {
                StreamReader inputFile;//讀檔案

                String countryname;//存檔案

                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    inputFile = File.OpenText(openFile.FileName);//找檔案

                    countriesListBox.Items.Clear();

                    while (!inputFile.EndOfStream)//沒到最後一個
                    {
                        countryname = inputFile.ReadLine();//讀資料

                        countriesListBox.Items.Add(countryname);//將資料加入ListBox
                    }
                    inputFile.Close();//關檔
                }
                else
                {
                    MessageBox.Show("no select the file");
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }

        private void openFileDialog(object sender, CancelEventArgs e)
        {

        }

        private void countriesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(countriesListBox.SelectedItem.ToString());
        }
    }
}
