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

namespace Friend_File
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void writeNameButton_Click(object sender, EventArgs e)
        {
            // 這裡是寫入名字的按鈕點擊事件處理程式
            try
            {
                StreamWriter outputFile;

                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                   
                    //outputFile = File.AppendText(@"C:\Users\shu\Desktop\Friends.txt");

                    outputFile = File.AppendText(saveFile.FileName);

                    outputFile.WriteLine(nameTextBox.Text);

                    outputFile.Close();

                    MessageBox.Show("以填寫");
                }
                else
                {
                    MessageBox.Show("作業取消");
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("錯誤");
            }
            }


        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單
            this.Close();
        }
    }
}
