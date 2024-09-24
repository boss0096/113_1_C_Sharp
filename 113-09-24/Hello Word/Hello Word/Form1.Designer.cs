namespace Hello_Word
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
            btn_display_message = new Button();
            SuspendLayout();
            // 
            // btn_display_message
            // 
            btn_display_message.BackColor = SystemColors.ButtonHighlight;
            btn_display_message.Font = new Font("Microsoft JhengHei UI", 15F);
            btn_display_message.ForeColor = Color.MediumBlue;
            btn_display_message.Location = new Point(312, 212);
            btn_display_message.Name = "btn_display_message";
            btn_display_message.Size = new Size(264, 192);
            btn_display_message.TabIndex = 0;
            btn_display_message.Text = "Disply Message";
            btn_display_message.UseVisualStyleBackColor = false;
            btn_display_message.Click += btn_display_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(862, 610);
            Controls.Add(btn_display_message);
            Font = new Font("Microsoft JhengHei UI", 9F);
            Name = "Form1";
            Text = "Greeting!";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_display_message;
    }
}
