namespace project_memory
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.resetTimer = new System.Windows.Forms.Timer(this.components);
            this.cardbtn1 = new System.Windows.Forms.PictureBox();
            this.cardbtn2 = new System.Windows.Forms.PictureBox();
            this.cardbtn3 = new System.Windows.Forms.PictureBox();
            this.cardbtn4 = new System.Windows.Forms.PictureBox();
            this.cardbtn5 = new System.Windows.Forms.PictureBox();
            this.cardbtn6 = new System.Windows.Forms.PictureBox();
            this.cardbtn7 = new System.Windows.Forms.PictureBox();
            this.cardbtn8 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.currentTurnLabel = new System.Windows.Forms.Label();
            this.endTimer = new System.Windows.Forms.Timer(this.components);
            this.pointsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cardbtn1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardbtn2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardbtn3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardbtn4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardbtn5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardbtn6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardbtn7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardbtn8)).BeginInit();
            this.SuspendLayout();
            // 
            // resetTimer
            // 
            this.resetTimer.Interval = 1;
            this.resetTimer.Tick += new System.EventHandler(this.resetTimer_Tick);
            // 
            // cardbtn1
            // 
            this.cardbtn1.AccessibleName = "pbx1";
            this.cardbtn1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardbtn1.Location = new System.Drawing.Point(147, 12);
            this.cardbtn1.Name = "cardbtn1";
            this.cardbtn1.Size = new System.Drawing.Size(150, 130);
            this.cardbtn1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cardbtn1.TabIndex = 8;
            this.cardbtn1.TabStop = false;
            this.cardbtn1.Click += new System.EventHandler(this.cardClick1);
            // 
            // cardbtn2
            // 
            this.cardbtn2.AccessibleName = "pbx2";
            this.cardbtn2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardbtn2.Location = new System.Drawing.Point(522, 12);
            this.cardbtn2.Name = "cardbtn2";
            this.cardbtn2.Size = new System.Drawing.Size(150, 130);
            this.cardbtn2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cardbtn2.TabIndex = 9;
            this.cardbtn2.TabStop = false;
            this.cardbtn2.Click += new System.EventHandler(this.cardbtn2_Click);
            // 
            // cardbtn3
            // 
            this.cardbtn3.AccessibleName = "pbx3";
            this.cardbtn3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardbtn3.Location = new System.Drawing.Point(336, 12);
            this.cardbtn3.Name = "cardbtn3";
            this.cardbtn3.Size = new System.Drawing.Size(150, 130);
            this.cardbtn3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cardbtn3.TabIndex = 10;
            this.cardbtn3.TabStop = false;
            this.cardbtn3.Click += new System.EventHandler(this.cardbtn3_Click);
            // 
            // cardbtn4
            // 
            this.cardbtn4.AccessibleName = "pbx4";
            this.cardbtn4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardbtn4.Location = new System.Drawing.Point(147, 152);
            this.cardbtn4.Name = "cardbtn4";
            this.cardbtn4.Size = new System.Drawing.Size(150, 130);
            this.cardbtn4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cardbtn4.TabIndex = 11;
            this.cardbtn4.TabStop = false;
            this.cardbtn4.Click += new System.EventHandler(this.cardbtn4_Click);
            // 
            // cardbtn5
            // 
            this.cardbtn5.AccessibleName = "pbx5";
            this.cardbtn5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardbtn5.Location = new System.Drawing.Point(522, 152);
            this.cardbtn5.Name = "cardbtn5";
            this.cardbtn5.Size = new System.Drawing.Size(150, 130);
            this.cardbtn5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cardbtn5.TabIndex = 12;
            this.cardbtn5.TabStop = false;
            this.cardbtn5.Click += new System.EventHandler(this.cardbtn5_Click);
            // 
            // cardbtn6
            // 
            this.cardbtn6.AccessibleName = "pbx6";
            this.cardbtn6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardbtn6.Location = new System.Drawing.Point(417, 308);
            this.cardbtn6.Name = "cardbtn6";
            this.cardbtn6.Size = new System.Drawing.Size(150, 130);
            this.cardbtn6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cardbtn6.TabIndex = 13;
            this.cardbtn6.TabStop = false;
            this.cardbtn6.Click += new System.EventHandler(this.cardbtn6_Click);
            // 
            // cardbtn7
            // 
            this.cardbtn7.AccessibleName = "pbx7";
            this.cardbtn7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardbtn7.Location = new System.Drawing.Point(244, 308);
            this.cardbtn7.Name = "cardbtn7";
            this.cardbtn7.Size = new System.Drawing.Size(150, 130);
            this.cardbtn7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cardbtn7.TabIndex = 14;
            this.cardbtn7.TabStop = false;
            this.cardbtn7.Click += new System.EventHandler(this.cardbtn7_Click);
            // 
            // cardbtn8
            // 
            this.cardbtn8.AccessibleName = "pbx8";
            this.cardbtn8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardbtn8.Location = new System.Drawing.Point(336, 152);
            this.cardbtn8.Name = "cardbtn8";
            this.cardbtn8.Size = new System.Drawing.Size(150, 130);
            this.cardbtn8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cardbtn8.TabIndex = 15;
            this.cardbtn8.TabStop = false;
            this.cardbtn8.Click += new System.EventHandler(this.cardbtn8_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(691, 318);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "label1";
            // 
            // currentTurnLabel
            // 
            this.currentTurnLabel.AutoSize = true;
            this.currentTurnLabel.Location = new System.Drawing.Point(49, 69);
            this.currentTurnLabel.Name = "currentTurnLabel";
            this.currentTurnLabel.Size = new System.Drawing.Size(44, 16);
            this.currentTurnLabel.TabIndex = 17;
            this.currentTurnLabel.Text = "label2";
            // 
            // endTimer
            // 
            this.endTimer.Tick += new System.EventHandler(this.endTimer_Tick);
            // 
            // pointsLabel
            // 
            this.pointsLabel.AutoSize = true;
            this.pointsLabel.Location = new System.Drawing.Point(724, 110);
            this.pointsLabel.Name = "pointsLabel";
            this.pointsLabel.Size = new System.Drawing.Size(44, 16);
            this.pointsLabel.TabIndex = 18;
            this.pointsLabel.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pointsLabel);
            this.Controls.Add(this.currentTurnLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cardbtn8);
            this.Controls.Add(this.cardbtn7);
            this.Controls.Add(this.cardbtn6);
            this.Controls.Add(this.cardbtn5);
            this.Controls.Add(this.cardbtn4);
            this.Controls.Add(this.cardbtn3);
            this.Controls.Add(this.cardbtn2);
            this.Controls.Add(this.cardbtn1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.cardbtn1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardbtn2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardbtn3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardbtn4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardbtn5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardbtn6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardbtn7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardbtn8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer resetTimer;
        private System.Windows.Forms.PictureBox cardbtn1;
        private System.Windows.Forms.PictureBox cardbtn2;
        private System.Windows.Forms.PictureBox cardbtn3;
        private System.Windows.Forms.PictureBox cardbtn4;
        private System.Windows.Forms.PictureBox cardbtn5;
        private System.Windows.Forms.PictureBox cardbtn6;
        private System.Windows.Forms.PictureBox cardbtn7;
        private System.Windows.Forms.PictureBox cardbtn8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label currentTurnLabel;
        private System.Windows.Forms.Timer endTimer;
        private System.Windows.Forms.Label pointsLabel;

    }
}

