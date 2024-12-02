namespace Color_Mixer
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
            rdbYellow = new RadioButton();
            rdbBlue = new RadioButton();
            rdbRed = new RadioButton();
            groupBox2 = new GroupBox();
            rdbb = new RadioButton();
            rdbr = new RadioButton();
            rdby = new RadioButton();
            btnMix = new Button();
            btnExit = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdbYellow);
            groupBox1.Controls.Add(rdbBlue);
            groupBox1.Controls.Add(rdbRed);
            groupBox1.Location = new Point(50, 41);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(300, 262);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Select the First Color";
            // 
            // rdbYellow
            // 
            rdbYellow.AutoSize = true;
            rdbYellow.Location = new Point(24, 205);
            rdbYellow.Name = "rdbYellow";
            rdbYellow.Size = new Size(91, 27);
            rdbYellow.TabIndex = 2;
            rdbYellow.TabStop = true;
            rdbYellow.Text = "Yellow";
            rdbYellow.UseVisualStyleBackColor = true;
            // 
            // rdbBlue
            // 
            rdbBlue.AutoSize = true;
            rdbBlue.Location = new Point(24, 133);
            rdbBlue.Name = "rdbBlue";
            rdbBlue.Size = new Size(72, 27);
            rdbBlue.TabIndex = 1;
            rdbBlue.TabStop = true;
            rdbBlue.Text = "Blue";
            rdbBlue.UseVisualStyleBackColor = true;
            // 
            // rdbRed
            // 
            rdbRed.AutoSize = true;
            rdbRed.Location = new Point(24, 57);
            rdbRed.Name = "rdbRed";
            rdbRed.Size = new Size(68, 27);
            rdbRed.TabIndex = 0;
            rdbRed.TabStop = true;
            rdbRed.Text = "Red";
            rdbRed.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rdbb);
            groupBox2.Controls.Add(rdbr);
            groupBox2.Controls.Add(rdby);
            groupBox2.Location = new Point(438, 41);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(300, 262);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Select the Second Color";
            // 
            // rdbb
            // 
            rdbb.AutoSize = true;
            rdbb.Location = new Point(45, 133);
            rdbb.Name = "rdbb";
            rdbb.Size = new Size(72, 27);
            rdbb.TabIndex = 5;
            rdbb.TabStop = true;
            rdbb.Text = "Blue";
            rdbb.UseVisualStyleBackColor = true;
            // 
            // rdbr
            // 
            rdbr.AutoSize = true;
            rdbr.Location = new Point(45, 57);
            rdbr.Name = "rdbr";
            rdbr.Size = new Size(68, 27);
            rdbr.TabIndex = 4;
            rdbr.TabStop = true;
            rdbr.Text = "Red";
            rdbr.UseVisualStyleBackColor = true;
            // 
            // rdby
            // 
            rdby.AutoSize = true;
            rdby.Location = new Point(45, 205);
            rdby.Name = "rdby";
            rdby.Size = new Size(91, 27);
            rdby.TabIndex = 3;
            rdby.TabStop = true;
            rdby.Text = "Yellow";
            rdby.UseVisualStyleBackColor = true;
            // 
            // btnMix
            // 
            btnMix.Location = new Point(258, 332);
            btnMix.Name = "btnMix";
            btnMix.Size = new Size(112, 34);
            btnMix.TabIndex = 2;
            btnMix.Text = "Mix";
            btnMix.UseVisualStyleBackColor = true;
            btnMix.Click += btnMix_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(443, 332);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(112, 34);
            btnExit.TabIndex = 3;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExit);
            Controls.Add(btnMix);
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
        private RadioButton rdbYellow;
        private RadioButton rdbBlue;
        private RadioButton rdbRed;
        private GroupBox groupBox2;
        private RadioButton rdby;
        private RadioButton rdbr;
        private RadioButton rdbb;
        private Button btnMix;
        private Button btnExit;
    }
}
