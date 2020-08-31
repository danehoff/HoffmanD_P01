namespace HoffmanD_P01
{
    partial class UserInterface
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
            this.uxEditButton = new System.Windows.Forms.Button();
            this.uxAddAlarmButton = new System.Windows.Forms.Button();
            this.uxSetAlarmList = new System.Windows.Forms.ListBox();
            this.uxSnoozeButton = new System.Windows.Forms.Button();
            this.uxStopButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uxEditButton
            // 
            this.uxEditButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.uxEditButton.Location = new System.Drawing.Point(55, 38);
            this.uxEditButton.Name = "uxEditButton";
            this.uxEditButton.Size = new System.Drawing.Size(184, 100);
            this.uxEditButton.TabIndex = 0;
            this.uxEditButton.Text = "Edit";
            this.uxEditButton.UseVisualStyleBackColor = true;
            this.uxEditButton.Click += new System.EventHandler(this.uxEditButton_Click);
            // 
            // uxAddAlarmButton
            // 
            this.uxAddAlarmButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.uxAddAlarmButton.Location = new System.Drawing.Point(394, 38);
            this.uxAddAlarmButton.Name = "uxAddAlarmButton";
            this.uxAddAlarmButton.Size = new System.Drawing.Size(184, 100);
            this.uxAddAlarmButton.TabIndex = 1;
            this.uxAddAlarmButton.Text = "+";
            this.uxAddAlarmButton.UseVisualStyleBackColor = true;
            this.uxAddAlarmButton.Click += new System.EventHandler(this.uxAddAlarmButton_Click);
            // 
            // uxSetAlarmList
            // 
            this.uxSetAlarmList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uxSetAlarmList.FormattingEnabled = true;
            this.uxSetAlarmList.ItemHeight = 37;
            this.uxSetAlarmList.Location = new System.Drawing.Point(55, 175);
            this.uxSetAlarmList.Name = "uxSetAlarmList";
            this.uxSetAlarmList.ScrollAlwaysVisible = true;
            this.uxSetAlarmList.Size = new System.Drawing.Size(523, 448);
            this.uxSetAlarmList.TabIndex = 2;
            // 
            // uxSnoozeButton
            // 
            this.uxSnoozeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.uxSnoozeButton.Location = new System.Drawing.Point(55, 673);
            this.uxSnoozeButton.Name = "uxSnoozeButton";
            this.uxSnoozeButton.Size = new System.Drawing.Size(239, 88);
            this.uxSnoozeButton.TabIndex = 3;
            this.uxSnoozeButton.Text = "Snooze";
            this.uxSnoozeButton.UseVisualStyleBackColor = true;
            this.uxSnoozeButton.Click += new System.EventHandler(this.uxSnoozeButton_Click);
            // 
            // uxStopButton
            // 
            this.uxStopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.uxStopButton.Location = new System.Drawing.Point(339, 673);
            this.uxStopButton.Name = "uxStopButton";
            this.uxStopButton.Size = new System.Drawing.Size(239, 88);
            this.uxStopButton.TabIndex = 4;
            this.uxStopButton.Text = "Stop";
            this.uxStopButton.UseVisualStyleBackColor = true;
            this.uxStopButton.Click += new System.EventHandler(this.uxStopButton_Click);
            // 
            // UserInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 820);
            this.Controls.Add(this.uxStopButton);
            this.Controls.Add(this.uxSnoozeButton);
            this.Controls.Add(this.uxSetAlarmList);
            this.Controls.Add(this.uxAddAlarmButton);
            this.Controls.Add(this.uxEditButton);
            this.Name = "UserInterface";
            this.Text = "Alarm501";

            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button uxEditButton;
        private System.Windows.Forms.Button uxAddAlarmButton;
        private System.Windows.Forms.ListBox uxSetAlarmList;
        private System.Windows.Forms.Button uxSnoozeButton;
        private System.Windows.Forms.Button uxStopButton;
    }
}

