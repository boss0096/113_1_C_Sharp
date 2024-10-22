namespace tutorial_3_4
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
            lblShow = new Label();
            tbxTest2 = new TextBox();
            tbxTest3 = new TextBox();
            tbxTest1 = new TextBox();
            btnCalculate = new Button();
            btnClear = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 15F);
            label1.Location = new Point(229, 83);
            label1.Name = "label1";
            label1.Size = new Size(67, 25);
            label1.TabIndex = 0;
            label1.Text = "Test1:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 15F);
            label2.Location = new Point(102, 283);
            label2.Name = "label2";
            label2.Size = new Size(194, 25);
            label2.TabIndex = 1;
            label2.Text = "Average Test Score:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei UI", 15F);
            label3.Location = new Point(229, 142);
            label3.Name = "label3";
            label3.Size = new Size(67, 25);
            label3.TabIndex = 2;
            label3.Text = "Test2:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft JhengHei UI", 15F);
            label4.Location = new Point(229, 214);
            label4.Name = "label4";
            label4.Size = new Size(67, 25);
            label4.TabIndex = 3;
            label4.Text = "Test3:";
            // 
            // lblShow
            // 
            lblShow.BorderStyle = BorderStyle.Fixed3D;
            lblShow.Font = new Font("Microsoft JhengHei UI", 15F);
            lblShow.Location = new Point(378, 283);
            lblShow.Name = "lblShow";
            lblShow.Size = new Size(136, 25);
            lblShow.TabIndex = 4;
            // 
            // tbxTest2
            // 
            tbxTest2.Location = new Point(378, 147);
            tbxTest2.Name = "tbxTest2";
            tbxTest2.Size = new Size(100, 23);
            tbxTest2.TabIndex = 5;
            // 
            // tbxTest3
            // 
            tbxTest3.Location = new Point(378, 219);
            tbxTest3.Name = "tbxTest3";
            tbxTest3.Size = new Size(100, 23);
            tbxTest3.TabIndex = 6;
            // 
            // tbxTest1
            // 
            tbxTest1.Location = new Point(378, 83);
            tbxTest1.Name = "tbxTest1";
            tbxTest1.Size = new Size(100, 23);
            tbxTest1.TabIndex = 7;
            // 
            // btnCalculate
            // 
            btnCalculate.Font = new Font("Microsoft JhengHei UI", 15F);
            btnCalculate.Location = new Point(126, 355);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(192, 36);
            btnCalculate.TabIndex = 8;
            btnCalculate.Text = "Calculate Average";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Microsoft JhengHei UI", 15F);
            btnClear.Location = new Point(342, 355);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(189, 36);
            btnClear.TabIndex = 9;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Microsoft JhengHei UI", 15F);
            btnExit.Location = new Point(565, 355);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(180, 36);
            btnExit.TabIndex = 10;
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
            Controls.Add(btnCalculate);
            Controls.Add(tbxTest1);
            Controls.Add(tbxTest3);
            Controls.Add(tbxTest2);
            Controls.Add(lblShow);
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
        private Label lblShow;
        private TextBox tbxTest2;
        private TextBox tbxTest3;
        private TextBox tbxTest1;
        private Button btnCalculate;
        private Button btnClear;
        private Button btnExit;
    }
}
