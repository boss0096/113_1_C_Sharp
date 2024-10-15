namespace Hw1
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
            ptxAceOfHearts = new PictureBox();
            btnExit = new Button();
            lblShow = new Label();
            ptxTenOfDiamonds = new PictureBox();
            ptxTwoOfClubs = new PictureBox();
            ptxSixOfSpades = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)ptxAceOfHearts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptxTenOfDiamonds).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptxTwoOfClubs).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptxSixOfSpades).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 20F);
            label1.Location = new Point(229, 55);
            label1.Name = "label1";
            label1.Size = new Size(355, 35);
            label1.TabIndex = 0;
            label1.Text = "Click a card to see its name";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ptxAceOfHearts
            // 
            ptxAceOfHearts.Image = Properties.Resources.Ace_Hearts;
            ptxAceOfHearts.Location = new Point(75, 120);
            ptxAceOfHearts.Name = "ptxAceOfHearts";
            ptxAceOfHearts.Size = new Size(103, 148);
            ptxAceOfHearts.SizeMode = PictureBoxSizeMode.Zoom;
            ptxAceOfHearts.TabIndex = 1;
            ptxAceOfHearts.TabStop = false;
            ptxAceOfHearts.Click += ptxAceOfHearts_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Microsoft JhengHei UI", 15F);
            btnExit.Location = new Point(329, 389);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(112, 37);
            btnExit.TabIndex = 5;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // lblShow
            // 
            lblShow.BorderStyle = BorderStyle.Fixed3D;
            lblShow.Font = new Font("Microsoft JhengHei UI", 20F);
            lblShow.Location = new Point(229, 307);
            lblShow.Name = "lblShow";
            lblShow.Size = new Size(309, 54);
            lblShow.TabIndex = 6;
            lblShow.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ptxTenOfDiamonds
            // 
            ptxTenOfDiamonds.Image = Properties.Resources._10_Diamonds;
            ptxTenOfDiamonds.Location = new Point(409, 120);
            ptxTenOfDiamonds.Name = "ptxTenOfDiamonds";
            ptxTenOfDiamonds.Size = new Size(103, 148);
            ptxTenOfDiamonds.SizeMode = PictureBoxSizeMode.Zoom;
            ptxTenOfDiamonds.TabIndex = 7;
            ptxTenOfDiamonds.TabStop = false;
            ptxTenOfDiamonds.Click += ptxTenOfDiamonds_Click;
            // 
            // ptxTwoOfClubs
            // 
            ptxTwoOfClubs.Image = Properties.Resources._2_Clubs;
            ptxTwoOfClubs.Location = new Point(239, 120);
            ptxTwoOfClubs.Name = "ptxTwoOfClubs";
            ptxTwoOfClubs.Size = new Size(103, 148);
            ptxTwoOfClubs.SizeMode = PictureBoxSizeMode.Zoom;
            ptxTwoOfClubs.TabIndex = 8;
            ptxTwoOfClubs.TabStop = false;
            ptxTwoOfClubs.Click += ptxTwoOfClubs_Click;
            // 
            // ptxSixOfSpades
            // 
            ptxSixOfSpades.Image = Properties.Resources._6_Spades;
            ptxSixOfSpades.Location = new Point(578, 120);
            ptxSixOfSpades.Name = "ptxSixOfSpades";
            ptxSixOfSpades.Size = new Size(103, 148);
            ptxSixOfSpades.SizeMode = PictureBoxSizeMode.Zoom;
            ptxSixOfSpades.TabIndex = 9;
            ptxSixOfSpades.TabStop = false;
            ptxSixOfSpades.Click += ptxSixOfSpades_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ptxSixOfSpades);
            Controls.Add(ptxTwoOfClubs);
            Controls.Add(ptxTenOfDiamonds);
            Controls.Add(lblShow);
            Controls.Add(btnExit);
            Controls.Add(ptxAceOfHearts);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Card Identifier";
            ((System.ComponentModel.ISupportInitialize)ptxAceOfHearts).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptxTenOfDiamonds).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptxTwoOfClubs).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptxSixOfSpades).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox ptxAceOfHearts;
        private Button btnExit;
        private Label lblShow;
        private PictureBox ptxTenOfDiamonds;
        private PictureBox ptxTwoOfClubs;
        private PictureBox ptxSixOfSpades;
    }
}
