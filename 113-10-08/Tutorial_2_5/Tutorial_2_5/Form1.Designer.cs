namespace Tutorial_2_5
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
            btnshowback = new Button();
            ptxback = new PictureBox();
            ptxface = new PictureBox();
            btnshowface = new Button();
            btnescape = new Button();
            ((System.ComponentModel.ISupportInitialize)ptxback).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptxface).BeginInit();
            SuspendLayout();
            // 
            // btnshowback
            // 
            btnshowback.Location = new Point(152, 275);
            btnshowback.Name = "btnshowback";
            btnshowback.Size = new Size(160, 37);
            btnshowback.TabIndex = 0;
            btnshowback.Text = "Show the card back";
            btnshowback.UseVisualStyleBackColor = true;
            btnshowback.Click += btnshowback_Click;
            // 
            // ptxback
            // 
            ptxback.Image = Properties.Resources.Backface_Blue;
            ptxback.Location = new Point(152, 39);
            ptxback.Name = "ptxback";
            ptxback.Size = new Size(160, 205);
            ptxback.SizeMode = PictureBoxSizeMode.Zoom;
            ptxback.TabIndex = 2;
            ptxback.TabStop = false;
            ptxback.Visible = false;
            // 
            // ptxface
            // 
            ptxface.Image = Properties.Resources.Ace_Spades;
            ptxface.Location = new Point(432, 39);
            ptxface.Name = "ptxface";
            ptxface.Size = new Size(160, 205);
            ptxface.SizeMode = PictureBoxSizeMode.Zoom;
            ptxface.TabIndex = 3;
            ptxface.TabStop = false;
            ptxface.Visible = false;
            // 
            // btnshowface
            // 
            btnshowface.Location = new Point(432, 275);
            btnshowface.Name = "btnshowface";
            btnshowface.Size = new Size(160, 37);
            btnshowface.TabIndex = 4;
            btnshowface.Text = "Show the card face";
            btnshowface.UseVisualStyleBackColor = true;
            btnshowface.Click += btnshowface_Click;
            // 
            // btnescape
            // 
            btnescape.Location = new Point(328, 347);
            btnescape.Name = "btnescape";
            btnescape.Size = new Size(75, 34);
            btnescape.TabIndex = 5;
            btnescape.Text = "escape";
            btnescape.UseVisualStyleBackColor = true;
            btnescape.Click += btnescape_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnescape);
            Controls.Add(btnshowface);
            Controls.Add(ptxface);
            Controls.Add(ptxback);
            Controls.Add(btnshowback);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)ptxback).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptxface).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnshowback;
        private PictureBox ptxback;
        private PictureBox ptxface;
        private Button btnshowface;
        private Button btnescape;
    }
}
