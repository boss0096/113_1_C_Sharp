namespace tutorial_3_2
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
            tbxMiles = new TextBox();
            tbxGallons = new TextBox();
            lblMpg = new Label();
            btnCalculate = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft JhengHei UI", 15F);
            label1.Location = new Point(50, 106);
            label1.Name = "label1";
            label1.Size = new Size(337, 24);
            label1.TabIndex = 0;
            label1.Text = "Enter the number of miles driven:";
            // 
            // label2
            // 
            label2.Font = new Font("Microsoft JhengHei UI", 15F);
            label2.Location = new Point(82, 187);
            label2.Name = "label2";
            label2.Size = new Size(295, 33);
            label2.TabIndex = 1;
            label2.Text = "Enter the gallons of gas used:";
            // 
            // label3
            // 
            label3.Font = new Font("Microsoft JhengHei UI", 15F);
            label3.Location = new Point(202, 249);
            label3.Name = "label3";
            label3.Size = new Size(160, 24);
            label3.TabIndex = 2;
            label3.Text = "Your car's MPG:";
            // 
            // tbxMiles
            // 
            tbxMiles.Location = new Point(423, 106);
            tbxMiles.Name = "tbxMiles";
            tbxMiles.Size = new Size(101, 23);
            tbxMiles.TabIndex = 3;
            // 
            // tbxGallons
            // 
            tbxGallons.Location = new Point(423, 187);
            tbxGallons.Name = "tbxGallons";
            tbxGallons.Size = new Size(101, 23);
            tbxGallons.TabIndex = 4;
            // 
            // lblMpg
            // 
            lblMpg.BorderStyle = BorderStyle.Fixed3D;
            lblMpg.Location = new Point(424, 249);
            lblMpg.Name = "lblMpg";
            lblMpg.Size = new Size(100, 24);
            lblMpg.TabIndex = 5;
            // 
            // btnCalculate
            // 
            btnCalculate.Font = new Font("Microsoft JhengHei UI", 15F);
            btnCalculate.Location = new Point(136, 338);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(180, 55);
            btnCalculate.TabIndex = 6;
            btnCalculate.Text = "Calculate MPG";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Microsoft JhengHei UI", 15F);
            btnExit.Location = new Point(440, 338);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(180, 55);
            btnExit.TabIndex = 7;
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
            Controls.Add(btnCalculate);
            Controls.Add(lblMpg);
            Controls.Add(tbxGallons);
            Controls.Add(tbxMiles);
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
        private TextBox tbxMiles;
        private TextBox tbxGallons;
        private Label lblMpg;
        private Button btnCalculate;
        private Button btnExit;
    }
}
