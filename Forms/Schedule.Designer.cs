namespace Workout_Tracker_SQLite
{
    partial class Schedule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Schedule));
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_todayWorkout = new System.Windows.Forms.Button();
            this.listBox_Workout = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Location = new System.Drawing.Point(199, 24);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(321, 29);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Today\'s Date";
            // 
            // btn_todayWorkout
            // 
            this.btn_todayWorkout.AutoSize = true;
            this.btn_todayWorkout.Location = new System.Drawing.Point(24, 62);
            this.btn_todayWorkout.Name = "btn_todayWorkout";
            this.btn_todayWorkout.Size = new System.Drawing.Size(161, 34);
            this.btn_todayWorkout.TabIndex = 2;
            this.btn_todayWorkout.Text = "Today\'s Workout";
            this.btn_todayWorkout.UseVisualStyleBackColor = true;
            this.btn_todayWorkout.Click += new System.EventHandler(this.btn_todayWorkout_Click);
            // 
            // listBox_Workout
            // 
            this.listBox_Workout.FormattingEnabled = true;
            this.listBox_Workout.ItemHeight = 24;
            this.listBox_Workout.Location = new System.Drawing.Point(199, 63);
            this.listBox_Workout.Name = "listBox_Workout";
            this.listBox_Workout.Size = new System.Drawing.Size(321, 100);
            this.listBox_Workout.TabIndex = 3;
            // 
            // Schedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(790, 412);
            this.Controls.Add(this.listBox_Workout);
            this.Controls.Add(this.btn_todayWorkout);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Schedule";
            this.Text = "Schedule";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_todayWorkout;
        private System.Windows.Forms.ListBox listBox_Workout;
    }
}