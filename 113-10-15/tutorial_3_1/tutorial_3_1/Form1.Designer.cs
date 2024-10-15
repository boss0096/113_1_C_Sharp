namespace tutorial_3_1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            tbxDayOfWeek = new TextBox();
            tbxMonth = new TextBox();
            tbxDyaOfMonth = new TextBox();
            tbxYear = new TextBox();
            lblShow = new Label();
            btnShowDate = new Button();
            btnClear = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 15F);
            label1.Location = new Point(104, 66);
            label1.Name = "label1";
            label1.Size = new Size(248, 25);
            label1.TabIndex = 0;
            label1.Text = "Enter the day of the week";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 15F);
            label2.Location = new Point(71, 143);
            label2.Name = "label2";
            label2.Size = new Size(281, 25);
            label2.TabIndex = 1;
            label2.Text = "Enter the name of the month";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei UI", 15F);
            label3.Location = new Point(9, 210);
            label3.Name = "label3";
            label3.Size = new Size(343, 25);
            label3.TabIndex = 2;
            label3.Text = "Enter the numeric day of the month";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft JhengHei UI", 15F);
            label4.Location = new Point(213, 278);
            label4.Name = "label4";
            label4.Size = new Size(139, 25);
            label4.TabIndex = 3;
            label4.Text = "Enter the year";
            // 
            // tbxDayOfWeek
            // 
            tbxDayOfWeek.Font = new Font("Microsoft JhengHei UI", 15F);
            tbxDayOfWeek.Location = new Point(411, 63);
            tbxDayOfWeek.Name = "tbxDayOfWeek";
            tbxDayOfWeek.Size = new Size(146, 33);
            tbxDayOfWeek.TabIndex = 4;
            // 
            // tbxMonth
            // 
            tbxMonth.Font = new Font("Microsoft JhengHei UI", 15F);
            tbxMonth.Location = new Point(411, 135);
            tbxMonth.Name = "tbxMonth";
            tbxMonth.Size = new Size(146, 33);
            tbxMonth.TabIndex = 5;
            // 
            // tbxDyaOfMonth
            // 
            tbxDyaOfMonth.Font = new Font("Microsoft JhengHei UI", 15F);
            tbxDyaOfMonth.Location = new Point(411, 207);
            tbxDyaOfMonth.Name = "tbxDyaOfMonth";
            tbxDyaOfMonth.Size = new Size(146, 33);
            tbxDyaOfMonth.TabIndex = 6;
            // 
            // tbxYear
            // 
            tbxYear.Font = new Font("Microsoft JhengHei UI", 15F);
            tbxYear.Location = new Point(411, 275);
            tbxYear.Name = "tbxYear";
            tbxYear.Size = new Size(146, 33);
            tbxYear.TabIndex = 7;
            // 
            // lblShow
            // 
            lblShow.BorderStyle = BorderStyle.Fixed3D;
            lblShow.Font = new Font("Microsoft JhengHei UI", 15F);
            lblShow.Location = new Point(121, 331);
            lblShow.Name = "lblShow";
            lblShow.Size = new Size(458, 39);
            lblShow.TabIndex = 8;
            lblShow.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnShowDate
            // 
            btnShowDate.Font = new Font("Microsoft JhengHei UI", 15F);
            btnShowDate.Location = new Point(121, 393);
            btnShowDate.Name = "btnShowDate";
            btnShowDate.Size = new Size(122, 34);
            btnShowDate.TabIndex = 9;
            btnShowDate.Text = "Show Date";
            btnShowDate.UseVisualStyleBackColor = true;
            btnShowDate.Click += btnShowDate_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Microsoft JhengHei UI", 15F);
            btnClear.Location = new Point(323, 393);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(105, 34);
            btnClear.TabIndex = 10;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Microsoft JhengHei UI", 15F);
            btnExit.Location = new Point(517, 393);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(105, 34);
            btnExit.TabIndex = 11;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(btnShowDate);
            Controls.Add(lblShow);
            Controls.Add(tbxYear);
            Controls.Add(tbxDyaOfMonth);
            Controls.Add(tbxMonth);
            Controls.Add(tbxDayOfWeek);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox tbxDayOfWeek;
        private TextBox tbxMonth;
        private TextBox tbxDyaOfMonth;
        private TextBox tbxYear;
        private Label lblShow;
        private Button btnShowDate;
        private Button btnClear;
        private Button btnExit;
    }
}
