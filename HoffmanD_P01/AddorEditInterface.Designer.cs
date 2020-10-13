namespace HoffmanD_P01
{
    partial class AddOrEditInterface
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
            this.uxAlarmTimePicker = new System.Windows.Forms.DateTimePicker();
            this.uxCancelButton = new System.Windows.Forms.Button();
            this.uxSetButton = new System.Windows.Forms.Button();
            this.uxAlarmOnRButton = new System.Windows.Forms.RadioButton();
            this.uxAlarmSoundDB = new System.Windows.Forms.ComboBox();
            this.uxAlarmSLabel = new System.Windows.Forms.Label();
            this.uxSnoozeTime = new System.Windows.Forms.TextBox();
            this.uxSnoozetimerLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // uxAlarmTimePicker
            // 
            this.uxAlarmTimePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.uxAlarmTimePicker.CustomFormat = "";
            this.uxAlarmTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.uxAlarmTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.uxAlarmTimePicker.Location = new System.Drawing.Point(74, 25);
            this.uxAlarmTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.uxAlarmTimePicker.Name = "uxAlarmTimePicker";
            this.uxAlarmTimePicker.ShowUpDown = true;
            this.uxAlarmTimePicker.Size = new System.Drawing.Size(229, 24);
            this.uxAlarmTimePicker.TabIndex = 0;
            this.uxAlarmTimePicker.Value = new System.DateTime(2020, 8, 31, 12, 0, 0, 0);
            // 
            // uxCancelButton
            // 
            this.uxCancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.uxCancelButton.Location = new System.Drawing.Point(24, 130);
            this.uxCancelButton.Margin = new System.Windows.Forms.Padding(2);
            this.uxCancelButton.Name = "uxCancelButton";
            this.uxCancelButton.Size = new System.Drawing.Size(100, 42);
            this.uxCancelButton.TabIndex = 2;
            this.uxCancelButton.Text = "Cancel";
            this.uxCancelButton.UseVisualStyleBackColor = true;
            this.uxCancelButton.Click += new System.EventHandler(this.uxCancelButton_Click);
            // 
            // uxSetButton
            // 
            this.uxSetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.uxSetButton.Location = new System.Drawing.Point(203, 130);
            this.uxSetButton.Margin = new System.Windows.Forms.Padding(2);
            this.uxSetButton.Name = "uxSetButton";
            this.uxSetButton.Size = new System.Drawing.Size(100, 42);
            this.uxSetButton.TabIndex = 3;
            this.uxSetButton.Text = "Set";
            this.uxSetButton.UseVisualStyleBackColor = true;
            this.uxSetButton.Click += new System.EventHandler(this.uxSetButton_Click);
            // 
            // uxAlarmOnRButton
            // 
            this.uxAlarmOnRButton.AutoSize = true;
            this.uxAlarmOnRButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.uxAlarmOnRButton.Location = new System.Drawing.Point(24, 28);
            this.uxAlarmOnRButton.Margin = new System.Windows.Forms.Padding(2);
            this.uxAlarmOnRButton.Name = "uxAlarmOnRButton";
            this.uxAlarmOnRButton.Size = new System.Drawing.Size(46, 22);
            this.uxAlarmOnRButton.TabIndex = 4;
            this.uxAlarmOnRButton.TabStop = true;
            this.uxAlarmOnRButton.Text = "On";
            this.uxAlarmOnRButton.UseVisualStyleBackColor = true;
            // 
            // uxAlarmSoundDB
            // 
            this.uxAlarmSoundDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.uxAlarmSoundDB.FormattingEnabled = true;
            this.uxAlarmSoundDB.Items.AddRange(new object[] {
            "Radar",
            "Beacon",
            "Chimes",
            "Circuit",
            "Reflection"});
            this.uxAlarmSoundDB.Location = new System.Drawing.Point(136, 54);
            this.uxAlarmSoundDB.Name = "uxAlarmSoundDB";
            this.uxAlarmSoundDB.Size = new System.Drawing.Size(167, 26);
            this.uxAlarmSoundDB.TabIndex = 5;
            this.uxAlarmSoundDB.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // uxAlarmSLabel
            // 
            this.uxAlarmSLabel.AutoSize = true;
            this.uxAlarmSLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.uxAlarmSLabel.Location = new System.Drawing.Point(21, 57);
            this.uxAlarmSLabel.Name = "uxAlarmSLabel";
            this.uxAlarmSLabel.Size = new System.Drawing.Size(93, 18);
            this.uxAlarmSLabel.TabIndex = 6;
            this.uxAlarmSLabel.Text = "Alarm Sound";
            // 
            // uxSnoozeTime
            // 
            this.uxSnoozeTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.uxSnoozeTime.Location = new System.Drawing.Point(224, 86);
            this.uxSnoozeTime.Name = "uxSnoozeTime";
            this.uxSnoozeTime.Size = new System.Drawing.Size(79, 24);
            this.uxSnoozeTime.TabIndex = 7;
            // 
            // uxSnoozetimerLabel
            // 
            this.uxSnoozetimerLabel.AutoSize = true;
            this.uxSnoozetimerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.uxSnoozetimerLabel.Location = new System.Drawing.Point(21, 89);
            this.uxSnoozetimerLabel.Name = "uxSnoozetimerLabel";
            this.uxSnoozetimerLabel.Size = new System.Drawing.Size(197, 18);
            this.uxSnoozetimerLabel.TabIndex = 8;
            this.uxSnoozetimerLabel.Text = "Snooze Time in Minutes(int):";
            // 
            // AddOrEditInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 180);
            this.Controls.Add(this.uxSnoozetimerLabel);
            this.Controls.Add(this.uxSnoozeTime);
            this.Controls.Add(this.uxAlarmSLabel);
            this.Controls.Add(this.uxAlarmSoundDB);
            this.Controls.Add(this.uxAlarmOnRButton);
            this.Controls.Add(this.uxSetButton);
            this.Controls.Add(this.uxCancelButton);
            this.Controls.Add(this.uxAlarmTimePicker);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AddOrEditInterface";
            this.Text = "Add/Edit Alarm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker uxAlarmTimePicker;
        private System.Windows.Forms.Button uxCancelButton;
        private System.Windows.Forms.Button uxSetButton;
        private System.Windows.Forms.RadioButton uxAlarmOnRButton;
        private System.Windows.Forms.ComboBox uxAlarmSoundDB;
        private System.Windows.Forms.Label uxAlarmSLabel;
        private System.Windows.Forms.TextBox uxSnoozeTime;
        private System.Windows.Forms.Label uxSnoozetimerLabel;
    }
}