namespace WinFormsApp2
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
            components = new System.ComponentModel.Container();
            lblFirstName = new Label();
            lblLastName = new Label();
            lblFullName = new Label();
            tbxFirstName = new TextBox();
            tbxLastName = new TextBox();
            notifyIcon1 = new NotifyIcon(components);
            lblNameFUll = new Label();
            btnShowName = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // lblFirstName
            // 
            lblFirstName.AutoEllipsis = true;
            lblFirstName.Font = new Font("Microsoft JhengHei UI", 15F);
            lblFirstName.Location = new Point(81, 76);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(213, 37);
            lblFirstName.TabIndex = 0;
            lblFirstName.Text = "Enter your first name:";
            // 
            // lblLastName
            // 
            lblLastName.AutoEllipsis = true;
            lblLastName.Font = new Font("Microsoft JhengHei UI", 15F);
            lblLastName.Location = new Point(81, 179);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(213, 37);
            lblLastName.TabIndex = 1;
            lblLastName.Text = "Enter your last name:";
            // 
            // lblFullName
            // 
            lblFullName.AutoEllipsis = true;
            lblFullName.Font = new Font("Microsoft JhengHei UI", 15F);
            lblFullName.Location = new Point(81, 277);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(213, 37);
            lblFullName.TabIndex = 2;
            lblFullName.Text = "This is your full name:";
            // 
            // tbxFirstName
            // 
            tbxFirstName.Location = new Point(340, 76);
            tbxFirstName.Name = "tbxFirstName";
            tbxFirstName.Size = new Size(216, 23);
            tbxFirstName.TabIndex = 3;
            // 
            // tbxLastName
            // 
            tbxLastName.Location = new Point(343, 179);
            tbxLastName.Name = "tbxLastName";
            tbxLastName.Size = new Size(216, 23);
            tbxLastName.TabIndex = 4;
            // 
            // notifyIcon1
            // 
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            // 
            // lblNameFUll
            // 
            lblNameFUll.AutoEllipsis = true;
            lblNameFUll.BorderStyle = BorderStyle.Fixed3D;
            lblNameFUll.Font = new Font("Microsoft JhengHei UI", 15F);
            lblNameFUll.ForeColor = SystemColors.ControlText;
            lblNameFUll.Location = new Point(343, 277);
            lblNameFUll.Name = "lblNameFUll";
            lblNameFUll.Size = new Size(213, 37);
            lblNameFUll.TabIndex = 5;
            lblNameFUll.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnShowName
            // 
            btnShowName.AutoEllipsis = true;
            btnShowName.Font = new Font("Microsoft JhengHei UI", 15F);
            btnShowName.Location = new Point(144, 348);
            btnShowName.Name = "btnShowName";
            btnShowName.Size = new Size(176, 40);
            btnShowName.TabIndex = 6;
            btnShowName.Text = "Show Name";
            btnShowName.UseVisualStyleBackColor = true;
            btnShowName.Click += btnShowName_Click;
            // 
            // btnExit
            // 
            btnExit.AutoEllipsis = true;
            btnExit.Font = new Font("Microsoft JhengHei UI", 15F);
            btnExit.Location = new Point(358, 348);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(176, 40);
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
            Controls.Add(btnShowName);
            Controls.Add(lblNameFUll);
            Controls.Add(tbxLastName);
            Controls.Add(tbxFirstName);
            Controls.Add(lblFullName);
            Controls.Add(lblLastName);
            Controls.Add(lblFirstName);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFirstName;
        private Label lblLastName;
        private Label lblFullName;
        private TextBox tbxFirstName;
        private TextBox tbxLastName;
        private NotifyIcon notifyIcon1;
        private Label lblNameFUll;
        private Button btnShowName;
        private Button btnExit;
    }
}
