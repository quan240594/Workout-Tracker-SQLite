namespace Workout_Tracker_SQLite
{
    partial class Visualization
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Visualization));
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.gb_Filters = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.chk_Total_Sets = new System.Windows.Forms.CheckBox();
            this.chk_Total_Reps = new System.Windows.Forms.CheckBox();
            this.chk_Avg_Reps = new System.Windows.Forms.CheckBox();
            this.chk_Avg_Weight = new System.Windows.Forms.CheckBox();
            this.chk_Total_Days = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.gb_Filters.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(13, 13);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(961, 595);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // gb_Filters
            // 
            this.gb_Filters.Controls.Add(this.tableLayoutPanel1);
            this.gb_Filters.Controls.Add(this.label2);
            this.gb_Filters.Controls.Add(this.comboBox2);
            this.gb_Filters.Controls.Add(this.comboBox1);
            this.gb_Filters.Controls.Add(this.label1);
            this.gb_Filters.Dock = System.Windows.Forms.DockStyle.Right;
            this.gb_Filters.Location = new System.Drawing.Point(980, 0);
            this.gb_Filters.Name = "gb_Filters";
            this.gb_Filters.Size = new System.Drawing.Size(305, 620);
            this.gb_Filters.TabIndex = 1;
            this.gb_Filters.TabStop = false;
            this.gb_Filters.Text = "Filters";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Person";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(110, 25);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(189, 32);
            this.comboBox1.TabIndex = 1;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(110, 63);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(189, 32);
            this.comboBox2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Exercise";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.chk_Total_Days, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.chk_Avg_Weight, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.chk_Avg_Reps, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.chk_Total_Reps, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.chk_Total_Sets, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 101);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(289, 204);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // chk_Total_Sets
            // 
            this.chk_Total_Sets.AutoSize = true;
            this.chk_Total_Sets.Location = new System.Drawing.Point(3, 3);
            this.chk_Total_Sets.Name = "chk_Total_Sets";
            this.chk_Total_Sets.Size = new System.Drawing.Size(111, 28);
            this.chk_Total_Sets.TabIndex = 0;
            this.chk_Total_Sets.Text = "Total Sets";
            this.chk_Total_Sets.UseVisualStyleBackColor = true;
            // 
            // chk_Total_Reps
            // 
            this.chk_Total_Reps.AutoSize = true;
            this.chk_Total_Reps.Location = new System.Drawing.Point(3, 45);
            this.chk_Total_Reps.Name = "chk_Total_Reps";
            this.chk_Total_Reps.Size = new System.Drawing.Size(119, 28);
            this.chk_Total_Reps.TabIndex = 1;
            this.chk_Total_Reps.Text = "Total Reps";
            this.chk_Total_Reps.UseVisualStyleBackColor = true;
            // 
            // chk_Avg_Reps
            // 
            this.chk_Avg_Reps.AutoSize = true;
            this.chk_Avg_Reps.Location = new System.Drawing.Point(3, 87);
            this.chk_Avg_Reps.Name = "chk_Avg_Reps";
            this.chk_Avg_Reps.Size = new System.Drawing.Size(149, 28);
            this.chk_Avg_Reps.TabIndex = 2;
            this.chk_Avg_Reps.Text = "Average Reps";
            this.chk_Avg_Reps.UseVisualStyleBackColor = true;
            // 
            // chk_Avg_Weight
            // 
            this.chk_Avg_Weight.AutoSize = true;
            this.chk_Avg_Weight.Location = new System.Drawing.Point(3, 136);
            this.chk_Avg_Weight.Name = "chk_Avg_Weight";
            this.chk_Avg_Weight.Size = new System.Drawing.Size(164, 28);
            this.chk_Avg_Weight.TabIndex = 3;
            this.chk_Avg_Weight.Text = "Average Weight";
            this.chk_Avg_Weight.UseVisualStyleBackColor = true;
            // 
            // chk_Total_Days
            // 
            this.chk_Total_Days.AutoSize = true;
            this.chk_Total_Days.Location = new System.Drawing.Point(3, 177);
            this.chk_Total_Days.Name = "chk_Total_Days";
            this.chk_Total_Days.Size = new System.Drawing.Size(174, 24);
            this.chk_Total_Days.TabIndex = 4;
            this.chk_Total_Days.Text = "Days of Workouts";
            this.chk_Total_Days.UseVisualStyleBackColor = true;
            // 
            // Visualization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1285, 620);
            this.Controls.Add(this.gb_Filters);
            this.Controls.Add(this.chart1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Visualization";
            this.Text = "Visualization";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.gb_Filters.ResumeLayout(false);
            this.gb_Filters.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.GroupBox gb_Filters;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.CheckBox chk_Total_Days;
        private System.Windows.Forms.CheckBox chk_Avg_Weight;
        private System.Windows.Forms.CheckBox chk_Avg_Reps;
        private System.Windows.Forms.CheckBox chk_Total_Reps;
        private System.Windows.Forms.CheckBox chk_Total_Sets;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
    }
}