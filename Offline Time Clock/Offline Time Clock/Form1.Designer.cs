namespace Offline_Time_Clock
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
            this.LblClockIn = new System.Windows.Forms.Label();
            this.LblClockOut = new System.Windows.Forms.Label();
            this.TxtClockInHours = new System.Windows.Forms.TextBox();
            this.LblClockInDots = new System.Windows.Forms.Label();
            this.TxtClockInMin = new System.Windows.Forms.TextBox();
            this.TxtClockOutHours = new System.Windows.Forms.TextBox();
            this.LblClockOutDots = new System.Windows.Forms.Label();
            this.TxtClockOutMin = new System.Windows.Forms.TextBox();
            this.BtnAddTime = new System.Windows.Forms.Button();
            this.BtnTotalTime = new System.Windows.Forms.Button();
            this.TxtTotalTimeMin = new System.Windows.Forms.TextBox();
            this.LblTotalTimeMin = new System.Windows.Forms.Label();
            this.LblTotalTimeBroken = new System.Windows.Forms.Label();
            this.TxtTotalTimeBroken = new System.Windows.Forms.TextBox();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblClockIn
            // 
            this.LblClockIn.AutoSize = true;
            this.LblClockIn.Location = new System.Drawing.Point(12, 55);
            this.LblClockIn.Name = "LblClockIn";
            this.LblClockIn.Size = new System.Drawing.Size(61, 17);
            this.LblClockIn.TabIndex = 0;
            this.LblClockIn.Text = "Clock In:";
            // 
            // LblClockOut
            // 
            this.LblClockOut.AutoSize = true;
            this.LblClockOut.Location = new System.Drawing.Point(159, 55);
            this.LblClockOut.Name = "LblClockOut";
            this.LblClockOut.Size = new System.Drawing.Size(73, 17);
            this.LblClockOut.TabIndex = 1;
            this.LblClockOut.Text = "Clock Out:";
            // 
            // TxtClockInHours
            // 
            this.TxtClockInHours.Location = new System.Drawing.Point(12, 96);
            this.TxtClockInHours.Name = "TxtClockInHours";
            this.TxtClockInHours.Size = new System.Drawing.Size(26, 22);
            this.TxtClockInHours.TabIndex = 2;
            // 
            // LblClockInDots
            // 
            this.LblClockInDots.AutoSize = true;
            this.LblClockInDots.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblClockInDots.Location = new System.Drawing.Point(44, 99);
            this.LblClockInDots.Name = "LblClockInDots";
            this.LblClockInDots.Size = new System.Drawing.Size(13, 17);
            this.LblClockInDots.TabIndex = 3;
            this.LblClockInDots.Text = ":";
            // 
            // TxtClockInMin
            // 
            this.TxtClockInMin.Location = new System.Drawing.Point(63, 96);
            this.TxtClockInMin.Name = "TxtClockInMin";
            this.TxtClockInMin.Size = new System.Drawing.Size(26, 22);
            this.TxtClockInMin.TabIndex = 4;
            // 
            // TxtClockOutHours
            // 
            this.TxtClockOutHours.Location = new System.Drawing.Point(162, 96);
            this.TxtClockOutHours.Name = "TxtClockOutHours";
            this.TxtClockOutHours.Size = new System.Drawing.Size(26, 22);
            this.TxtClockOutHours.TabIndex = 5;
            // 
            // LblClockOutDots
            // 
            this.LblClockOutDots.AutoSize = true;
            this.LblClockOutDots.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblClockOutDots.Location = new System.Drawing.Point(194, 99);
            this.LblClockOutDots.Name = "LblClockOutDots";
            this.LblClockOutDots.Size = new System.Drawing.Size(13, 17);
            this.LblClockOutDots.TabIndex = 6;
            this.LblClockOutDots.Text = ":";
            // 
            // TxtClockOutMin
            // 
            this.TxtClockOutMin.Location = new System.Drawing.Point(213, 96);
            this.TxtClockOutMin.Name = "TxtClockOutMin";
            this.TxtClockOutMin.Size = new System.Drawing.Size(26, 22);
            this.TxtClockOutMin.TabIndex = 7;
            // 
            // BtnAddTime
            // 
            this.BtnAddTime.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAddTime.Location = new System.Drawing.Point(82, 144);
            this.BtnAddTime.Name = "BtnAddTime";
            this.BtnAddTime.Size = new System.Drawing.Size(78, 23);
            this.BtnAddTime.TabIndex = 8;
            this.BtnAddTime.Text = "Add Time";
            this.BtnAddTime.UseVisualStyleBackColor = true;
            this.BtnAddTime.Click += new System.EventHandler(this.BtnAddTime_Click);
            // 
            // BtnTotalTime
            // 
            this.BtnTotalTime.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnTotalTime.Location = new System.Drawing.Point(85, 190);
            this.BtnTotalTime.Name = "BtnTotalTime";
            this.BtnTotalTime.Size = new System.Drawing.Size(75, 23);
            this.BtnTotalTime.TabIndex = 9;
            this.BtnTotalTime.Text = "Total Time";
            this.BtnTotalTime.UseVisualStyleBackColor = true;
            this.BtnTotalTime.Click += new System.EventHandler(this.BtnTotalTime_Click);
            // 
            // TxtTotalTimeMin
            // 
            this.TxtTotalTimeMin.Location = new System.Drawing.Point(71, 265);
            this.TxtTotalTimeMin.Name = "TxtTotalTimeMin";
            this.TxtTotalTimeMin.Size = new System.Drawing.Size(100, 22);
            this.TxtTotalTimeMin.TabIndex = 10;
            // 
            // LblTotalTimeMin
            // 
            this.LblTotalTimeMin.AutoSize = true;
            this.LblTotalTimeMin.Location = new System.Drawing.Point(54, 231);
            this.LblTotalTimeMin.Name = "LblTotalTimeMin";
            this.LblTotalTimeMin.Size = new System.Drawing.Size(143, 17);
            this.LblTotalTimeMin.TabIndex = 11;
            this.LblTotalTimeMin.Text = "Total Time in Minutes";
            // 
            // LblTotalTimeBroken
            // 
            this.LblTotalTimeBroken.AutoSize = true;
            this.LblTotalTimeBroken.Location = new System.Drawing.Point(54, 302);
            this.LblTotalTimeBroken.Name = "LblTotalTimeBroken";
            this.LblTotalTimeBroken.Size = new System.Drawing.Size(146, 17);
            this.LblTotalTimeBroken.TabIndex = 12;
            this.LblTotalTimeBroken.Text = "Total Time Broken Up";
            // 
            // TxtTotalTimeBroken
            // 
            this.TxtTotalTimeBroken.Location = new System.Drawing.Point(71, 333);
            this.TxtTotalTimeBroken.Name = "TxtTotalTimeBroken";
            this.TxtTotalTimeBroken.Size = new System.Drawing.Size(100, 22);
            this.TxtTotalTimeBroken.TabIndex = 13;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(108, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(263, 28);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 367);
            this.Controls.Add(this.TxtTotalTimeBroken);
            this.Controls.Add(this.LblTotalTimeBroken);
            this.Controls.Add(this.LblTotalTimeMin);
            this.Controls.Add(this.TxtTotalTimeMin);
            this.Controls.Add(this.BtnTotalTime);
            this.Controls.Add(this.BtnAddTime);
            this.Controls.Add(this.TxtClockOutMin);
            this.Controls.Add(this.LblClockOutDots);
            this.Controls.Add(this.TxtClockOutHours);
            this.Controls.Add(this.TxtClockInMin);
            this.Controls.Add(this.LblClockInDots);
            this.Controls.Add(this.TxtClockInHours);
            this.Controls.Add(this.LblClockOut);
            this.Controls.Add(this.LblClockIn);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Offline Time Clock";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblClockIn;
        private System.Windows.Forms.Label LblClockOut;
        private System.Windows.Forms.TextBox TxtClockInHours;
        private System.Windows.Forms.Label LblClockInDots;
        private System.Windows.Forms.TextBox TxtClockInMin;
        private System.Windows.Forms.TextBox TxtClockOutHours;
        private System.Windows.Forms.Label LblClockOutDots;
        private System.Windows.Forms.TextBox TxtClockOutMin;
        private System.Windows.Forms.Button BtnAddTime;
        private System.Windows.Forms.Button BtnTotalTime;
        private System.Windows.Forms.TextBox TxtTotalTimeMin;
        private System.Windows.Forms.Label LblTotalTimeMin;
        private System.Windows.Forms.Label LblTotalTimeBroken;
        private System.Windows.Forms.TextBox TxtTotalTimeBroken;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}

