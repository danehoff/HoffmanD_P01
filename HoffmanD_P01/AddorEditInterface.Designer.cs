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
            this.SuspendLayout();
            // 
            // uxAlarmTimePicker
            // 
            this.uxAlarmTimePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.uxAlarmTimePicker.CustomFormat = "";
            this.uxAlarmTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.uxAlarmTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.uxAlarmTimePicker.Location = new System.Drawing.Point(42, 49);
            this.uxAlarmTimePicker.Name = "uxAlarmTimePicker";
            this.uxAlarmTimePicker.ShowUpDown = true;
            this.uxAlarmTimePicker.Size = new System.Drawing.Size(454, 41);
            this.uxAlarmTimePicker.TabIndex = 0;
            this.uxAlarmTimePicker.Value = new System.DateTime(2020, 8, 31, 12, 0, 0, 0);
            // 
            // uxCancelButton
            // 
            this.uxCancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.uxCancelButton.Location = new System.Drawing.Point(42, 125);
            this.uxCancelButton.Name = "uxCancelButton";
            this.uxCancelButton.Size = new System.Drawing.Size(199, 81);
            this.uxCancelButton.TabIndex = 2;
            this.uxCancelButton.Text = "Cancel";
            this.uxCancelButton.UseVisualStyleBackColor = true;
            this.uxCancelButton.Click += new System.EventHandler(this.uxCancelButton_Click);
            // 
            // uxSetButton
            // 
            this.uxSetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.uxSetButton.Location = new System.Drawing.Point(412, 125);
            this.uxSetButton.Name = "uxSetButton";
            this.uxSetButton.Size = new System.Drawing.Size(199, 81);
            this.uxSetButton.TabIndex = 3;
            this.uxSetButton.Text = "Set";
            this.uxSetButton.UseVisualStyleBackColor = true;
            this.uxSetButton.Click += new System.EventHandler(this.uxSetButton_Click);
            // 
            // uxAlarmOnRButton
            // 
            this.uxAlarmOnRButton.AutoSize = true;
            this.uxAlarmOnRButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.uxAlarmOnRButton.Location = new System.Drawing.Point(514, 49);
            this.uxAlarmOnRButton.Name = "uxAlarmOnRButton";
            this.uxAlarmOnRButton.Size = new System.Drawing.Size(85, 40);
            this.uxAlarmOnRButton.TabIndex = 4;
            this.uxAlarmOnRButton.TabStop = true;
            this.uxAlarmOnRButton.Text = "On";
            this.uxAlarmOnRButton.UseVisualStyleBackColor = true;
            // 
            // AddOrEditInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 238);
            this.Controls.Add(this.uxAlarmOnRButton);
            this.Controls.Add(this.uxSetButton);
            this.Controls.Add(this.uxCancelButton);
            this.Controls.Add(this.uxAlarmTimePicker);
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
    }
}