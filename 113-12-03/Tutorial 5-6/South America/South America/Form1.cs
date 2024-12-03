﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace South_America
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void getCountriesButton_Click(object sender, EventArgs e)
        {
            // 這裡是取得國家按鈕的點擊事件處理程式。
            try
            {
                StreamReader inputFile;//讀檔案

                String countryname;//存檔案

                inputFile = File.OpenText("Countries.txt");

                countriesListBox.Items.Clear(); 

                while (!inputFile.EndOfStream)//沒到最後一個
                {
                    countryname = inputFile.ReadLine();//讀資料

                    countriesListBox.Items.Add(countryname);//將資料加入ListBox
                }
                inputFile.Close();//關檔
            }
           
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單。
            this.Close();
        }
    }
}
