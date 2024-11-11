namespace Stadium_Seating
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
            groupBox1 = new GroupBox();
            tbxC = new TextBox();
            tbxB = new TextBox();
            tbxA = new TextBox();
            label8 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            lblTShow = new Label();
            lblShowC = new Label();
            lblShowB = new Label();
            lblAShow = new Label();
            label9 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            btnCalculate = new Button();
            btnClear = new Button();
            btnClose = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tbxC);
            groupBox1.Controls.Add(tbxB);
            groupBox1.Controls.Add(tbxA);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(36, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(311, 335);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tickets Sold";
            // 
            // tbxC
            // 
            tbxC.Location = new Point(125, 233);
            tbxC.Name = "tbxC";
            tbxC.Size = new Size(150, 30);
            tbxC.TabIndex = 6;
            // 
            // tbxB
            // 
            tbxB.Location = new Point(125, 175);
            tbxB.Name = "tbxB";
            tbxB.Size = new Size(150, 30);
            tbxB.TabIndex = 5;
            // 
            // tbxA
            // 
            tbxA.Location = new Point(125, 119);
            tbxA.Name = "tbxA";
            tbxA.Size = new Size(150, 30);
            tbxA.TabIndex = 4;
            // 
            // label8
            // 
            label8.Location = new Point(6, 41);
            label8.Name = "label8";
            label8.Size = new Size(294, 53);
            label8.TabIndex = 3;
            label8.Text = "Enter the number of tickets sold for each class of seats.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 240);
            label3.Name = "label3";
            label3.Size = new Size(106, 23);
            label3.TabIndex = 2;
            label3.Text = "Class C($9):";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 178);
            label2.Name = "label2";
            label2.Size = new Size(115, 23);
            label2.TabIndex = 1;
            label2.Text = "Class B($12):";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 126);
            label1.Name = "label1";
            label1.Size = new Size(116, 23);
            label1.TabIndex = 0;
            label1.Text = "Class A($15):";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblTShow);
            groupBox2.Controls.Add(lblShowC);
            groupBox2.Controls.Add(lblShowB);
            groupBox2.Controls.Add(lblAShow);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(446, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(307, 335);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Revenue Generated";
            // 
            // lblTShow
            // 
            lblTShow.BorderStyle = BorderStyle.Fixed3D;
            lblTShow.Location = new Point(126, 240);
            lblTShow.Name = "lblTShow";
            lblTShow.Size = new Size(140, 23);
            lblTShow.TabIndex = 9;
            lblTShow.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblShowC
            // 
            lblShowC.BorderStyle = BorderStyle.Fixed3D;
            lblShowC.Location = new Point(126, 186);
            lblShowC.Name = "lblShowC";
            lblShowC.Size = new Size(140, 23);
            lblShowC.TabIndex = 8;
            lblShowC.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblShowB
            // 
            lblShowB.BorderStyle = BorderStyle.Fixed3D;
            lblShowB.Location = new Point(126, 144);
            lblShowB.Name = "lblShowB";
            lblShowB.Size = new Size(140, 23);
            lblShowB.TabIndex = 7;
            lblShowB.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblAShow
            // 
            lblAShow.BorderStyle = BorderStyle.Fixed3D;
            lblAShow.Location = new Point(126, 96);
            lblAShow.Name = "lblAShow";
            lblAShow.Size = new Size(140, 23);
            lblAShow.TabIndex = 6;
            lblAShow.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(31, 195);
            label9.Name = "label9";
            label9.Size = new Size(74, 23);
            label9.TabIndex = 5;
            label9.Text = "Class C:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(48, 240);
            label7.Name = "label7";
            label7.Size = new Size(57, 23);
            label7.TabIndex = 4;
            label7.Text = "Total:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(32, 186);
            label6.Name = "label6";
            label6.Size = new Size(0, 23);
            label6.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(32, 144);
            label5.Name = "label5";
            label5.Size = new Size(73, 23);
            label5.TabIndex = 2;
            label5.Text = "Class B:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 96);
            label4.Name = "label4";
            label4.Size = new Size(74, 23);
            label4.TabIndex = 1;
            label4.Text = "Class A:";
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(136, 379);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(112, 59);
            btnCalculate.TabIndex = 2;
            btnCalculate.Text = "Calculate Revenue";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(352, 379);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(112, 52);
            btnClear.TabIndex = 3;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(591, 379);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(112, 52);
            btnClose.TabIndex = 4;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnClose);
            Controls.Add(btnClear);
            Controls.Add(btnCalculate);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Button btnCalculate;
        private Button btnClear;
        private Button btnClose;
        private Label label8;
        private Label lblTShow;
        private Label lblShowC;
        private Label lblShowB;
        private Label lblAShow;
        private Label label9;
        private TextBox tbxC;
        private TextBox tbxB;
        private TextBox tbxA;
    }
}
