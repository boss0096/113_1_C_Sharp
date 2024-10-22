namespace tutorial_3_3
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
            lblSale = new Label();
            tbxOriginal = new TextBox();
            tbxDiscount = new TextBox();
            btnCulculate = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft JhengHei UI", 15F);
            label1.Location = new Point(101, 91);
            label1.Name = "label1";
            label1.Size = new Size(299, 36);
            label1.TabIndex = 0;
            label1.Text = "Enter the iltem's original price:";
            // 
            // label2
            // 
            label2.Font = new Font("Microsoft JhengHei UI", 15F);
            label2.Location = new Point(101, 159);
            label2.Name = "label2";
            label2.Size = new Size(299, 39);
            label2.TabIndex = 1;
            label2.Text = "Enter the discount percentage:";
            // 
            // label3
            // 
            label3.Font = new Font("Microsoft JhengHei UI", 15F);
            label3.Location = new Point(277, 234);
            label3.Name = "label3";
            label3.Size = new Size(123, 23);
            label3.TabIndex = 2;
            label3.Text = "Sale price:";
            // 
            // lblSale
            // 
            lblSale.BorderStyle = BorderStyle.Fixed3D;
            lblSale.Font = new Font("Microsoft JhengHei UI", 15F);
            lblSale.Location = new Point(446, 234);
            lblSale.Name = "lblSale";
            lblSale.Size = new Size(123, 23);
            lblSale.TabIndex = 3;
            // 
            // tbxOriginal
            // 
            tbxOriginal.Location = new Point(446, 91);
            tbxOriginal.Name = "tbxOriginal";
            tbxOriginal.Size = new Size(123, 23);
            tbxOriginal.TabIndex = 4;
            // 
            // tbxDiscount
            // 
            tbxDiscount.Location = new Point(446, 164);
            tbxDiscount.Name = "tbxDiscount";
            tbxDiscount.Size = new Size(123, 23);
            tbxDiscount.TabIndex = 5;
            // 
            // btnCulculate
            // 
            btnCulculate.AutoSize = true;
            btnCulculate.Font = new Font("Microsoft JhengHei UI", 15F);
            btnCulculate.Location = new Point(169, 317);
            btnCulculate.Name = "btnCulculate";
            btnCulculate.Size = new Size(201, 44);
            btnCulculate.TabIndex = 6;
            btnCulculate.Text = "Culculate Sale Price";
            btnCulculate.UseVisualStyleBackColor = true;
            btnCulculate.Click += btnCulculate_Click;
            // 
            // btnExit
            // 
            btnExit.AutoSize = true;
            btnExit.Font = new Font("Microsoft JhengHei UI", 15F);
            btnExit.Location = new Point(459, 317);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(137, 44);
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
            Controls.Add(btnCulculate);
            Controls.Add(tbxDiscount);
            Controls.Add(tbxOriginal);
            Controls.Add(lblSale);
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
        private Label lblSale;
        private TextBox tbxOriginal;
        private TextBox tbxDiscount;
        private Button btnCulculate;
        private Button btnExit;
    }
}
