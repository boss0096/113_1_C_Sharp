namespace Credit_Card_Points
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
            lblPoints = new Label();
            tbxCost = new TextBox();
            btnCalculate = new Button();
            btnClear = new Button();
            btnClose = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new Point(206, 102);
            label1.Name = "label1";
            label1.Size = new Size(140, 38);
            label1.TabIndex = 0;
            label1.Text = "Cost:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Location = new Point(206, 176);
            label2.Name = "label2";
            label2.Size = new Size(140, 38);
            label2.TabIndex = 1;
            label2.Text = "Points:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPoints
            // 
            lblPoints.BorderStyle = BorderStyle.Fixed3D;
            lblPoints.Location = new Point(413, 176);
            lblPoints.Name = "lblPoints";
            lblPoints.Size = new Size(140, 38);
            lblPoints.TabIndex = 2;
            lblPoints.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tbxCost
            // 
            tbxCost.Location = new Point(413, 102);
            tbxCost.Name = "tbxCost";
            tbxCost.Size = new Size(150, 30);
            tbxCost.TabIndex = 3;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(231, 257);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(112, 56);
            btnCalculate.TabIndex = 4;
            btnCalculate.Text = "Calculate Points";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(404, 257);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(112, 56);
            btnClear.TabIndex = 5;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(564, 257);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(112, 56);
            btnClose.TabIndex = 6;
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
            Controls.Add(tbxCost);
            Controls.Add(lblPoints);
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
        private Label lblPoints;
        private TextBox tbxCost;
        private Button btnCalculate;
        private Button btnClear;
        private Button btnClose;
    }
}
