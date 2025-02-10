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
            this.cardbtn1 = new System.Windows.Forms.Button();
            this.cardbtn2 = new System.Windows.Forms.Button();
            this.cardbtn3 = new System.Windows.Forms.Button();
            this.cardbtn4 = new System.Windows.Forms.Button();
            this.cardbtn5 = new System.Windows.Forms.Button();
            this.cardbtn6 = new System.Windows.Forms.Button();
            this.cardbtn7 = new System.Windows.Forms.Button();
            this.cardbtn8 = new System.Windows.Forms.Button();
            this.resetTimer = new System.Windows.Forms.Timer(this.components);
            this.currentTurnLabel = new System.Windows.Forms.Label();
            this.pointsLabel = new System.Windows.Forms.Label();
            this.endTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // cardbtn1
            // 
            this.cardbtn1.Location = new System.Drawing.Point(176, 86);
            this.cardbtn1.Name = "cardbtn1";
            this.cardbtn1.Size = new System.Drawing.Size(110, 100);
            this.cardbtn1.TabIndex = 0;
            this.cardbtn1.UseVisualStyleBackColor = true;
            this.cardbtn1.Click += new System.EventHandler(this.cardClick1);
            // 
            // cardbtn2
            // 
            this.cardbtn2.Location = new System.Drawing.Point(354, 86);
            this.cardbtn2.Name = "cardbtn2";
            this.cardbtn2.Size = new System.Drawing.Size(110, 100);
            this.cardbtn2.TabIndex = 1;
            this.cardbtn2.UseVisualStyleBackColor = true;
            this.cardbtn2.Click += new System.EventHandler(this.cardbtn2_Click);
            // 
            // cardbtn3
            // 
            this.cardbtn3.Location = new System.Drawing.Point(533, 85);
            this.cardbtn3.Name = "cardbtn3";
            this.cardbtn3.Size = new System.Drawing.Size(110, 100);
            this.cardbtn3.TabIndex = 2;
            this.cardbtn3.UseVisualStyleBackColor = true;
            this.cardbtn3.Click += new System.EventHandler(this.cardbtn3_Click);
            // 
            // cardbtn4
            // 
            this.cardbtn4.Location = new System.Drawing.Point(176, 207);
            this.cardbtn4.Name = "cardbtn4";
            this.cardbtn4.Size = new System.Drawing.Size(110, 100);
            this.cardbtn4.TabIndex = 3;
            this.cardbtn4.UseVisualStyleBackColor = true;
            this.cardbtn4.Click += new System.EventHandler(this.cardbtn4_Click);
            // 
            // cardbtn5
            // 
            this.cardbtn5.Location = new System.Drawing.Point(354, 207);
            this.cardbtn5.Name = "cardbtn5";
            this.cardbtn5.Size = new System.Drawing.Size(110, 100);
            this.cardbtn5.TabIndex = 4;
            this.cardbtn5.UseVisualStyleBackColor = true;
            this.cardbtn5.Click += new System.EventHandler(this.cardbtn5_Click);
            // 
            // cardbtn6
            // 
            this.cardbtn6.Location = new System.Drawing.Point(533, 207);
            this.cardbtn6.Name = "cardbtn6";
            this.cardbtn6.Size = new System.Drawing.Size(110, 100);
            this.cardbtn6.TabIndex = 5;
            this.cardbtn6.UseVisualStyleBackColor = true;
            this.cardbtn6.Click += new System.EventHandler(this.cardbtn6_Click);
            // 
            // cardbtn7
            // 
            this.cardbtn7.Location = new System.Drawing.Point(268, 326);
            this.cardbtn7.Name = "cardbtn7";
            this.cardbtn7.Size = new System.Drawing.Size(110, 100);
            this.cardbtn7.TabIndex = 6;
            this.cardbtn7.UseVisualStyleBackColor = true;
            this.cardbtn7.Click += new System.EventHandler(this.cardbtn7_Click);
            // 
            // cardbtn8
            // 
            this.cardbtn8.Location = new System.Drawing.Point(447, 326);
            this.cardbtn8.Name = "cardbtn8";
            this.cardbtn8.Size = new System.Drawing.Size(110, 100);
            this.cardbtn8.TabIndex = 7;
            this.cardbtn8.UseVisualStyleBackColor = true;
            this.cardbtn8.Click += new System.EventHandler(this.cardbtn8_Click);
            // 
            // resetTimer
            // 
            this.resetTimer.Interval = 1;
            this.resetTimer.Tick += new System.EventHandler(this.resetTimer_Tick);
            // 
            // currentTurnLabel
            // 
            this.currentTurnLabel.AutoSize = true;
            this.currentTurnLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.currentTurnLabel.Location = new System.Drawing.Point(49, 38);
            this.currentTurnLabel.Name = "currentTurnLabel";
            this.currentTurnLabel.Size = new System.Drawing.Size(83, 31);
            this.currentTurnLabel.TabIndex = 9;
            this.currentTurnLabel.Text = "turn 1";
            // 
            // pointsLabel
            // 
            this.pointsLabel.AutoSize = true;
            this.pointsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.pointsLabel.Location = new System.Drawing.Point(671, 38);
            this.pointsLabel.Name = "pointsLabel";
            this.pointsLabel.Size = new System.Drawing.Size(109, 31);
            this.pointsLabel.TabIndex = 10;
            this.pointsLabel.Text = "0 points";
            // 
            // endTimer
            // 
            this.endTimer.Tick += new System.EventHandler(this.endTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 484);
            this.Controls.Add(this.pointsLabel);
            this.Controls.Add(this.currentTurnLabel);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cardbtn1;
        private System.Windows.Forms.Button cardbtn2;
        private System.Windows.Forms.Button cardbtn3;
        private System.Windows.Forms.Button cardbtn4;
        private System.Windows.Forms.Button cardbtn5;
        private System.Windows.Forms.Button cardbtn6;
        private System.Windows.Forms.Button cardbtn7;
        private System.Windows.Forms.Button cardbtn8;
        private System.Windows.Forms.Timer resetTimer;
        private System.Windows.Forms.Label currentTurnLabel;
        private System.Windows.Forms.Label pointsLabel;
        private System.Windows.Forms.Timer endTimer;
    }
}

