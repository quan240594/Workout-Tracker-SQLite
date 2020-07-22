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
            this.btn_Reset = new System.Windows.Forms.Button();
            this.cb_Total_Days = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_LoadChart = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.chk_Avg_Weight = new System.Windows.Forms.CheckBox();
            this.chk_Avg_Reps = new System.Windows.Forms.CheckBox();
            this.chk_Total_Reps = new System.Windows.Forms.CheckBox();
            this.chk_Total_Sets = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_Workout_Name = new System.Windows.Forms.ComboBox();
            this.cb_Person_Name = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.gb_Filters.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Left;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(980, 620);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "Workut Progress VIsualized";
            // 
            // gb_Filters
            // 
            this.gb_Filters.Controls.Add(this.btn_Reset);
            this.gb_Filters.Controls.Add(this.cb_Total_Days);
            this.gb_Filters.Controls.Add(this.label3);
            this.gb_Filters.Controls.Add(this.btn_LoadChart);
            this.gb_Filters.Controls.Add(this.tableLayoutPanel1);
            this.gb_Filters.Controls.Add(this.label2);
            this.gb_Filters.Controls.Add(this.cb_Workout_Name);
            this.gb_Filters.Controls.Add(this.cb_Person_Name);
            this.gb_Filters.Controls.Add(this.label1);
            this.gb_Filters.Dock = System.Windows.Forms.DockStyle.Right;
            this.gb_Filters.Location = new System.Drawing.Point(980, 0);
            this.gb_Filters.Name = "gb_Filters";
            this.gb_Filters.Size = new System.Drawing.Size(305, 620);
            this.gb_Filters.TabIndex = 1;
            this.gb_Filters.TabStop = false;
            this.gb_Filters.Text = "Filters";
            // 
            // btn_Reset
            // 
            this.btn_Reset.Location = new System.Drawing.Point(10, 415);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(289, 60);
            this.btn_Reset.TabIndex = 9;
            this.btn_Reset.Text = "Refresh";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // cb_Total_Days
            // 
            this.cb_Total_Days.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cb_Total_Days.FormattingEnabled = true;
            this.cb_Total_Days.Location = new System.Drawing.Point(178, 101);
            this.cb_Total_Days.Name = "cb_Total_Days";
            this.cb_Total_Days.Size = new System.Drawing.Size(121, 32);
            this.cb_Total_Days.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Days of workout";
            // 
            // btn_LoadChart
            // 
            this.btn_LoadChart.Location = new System.Drawing.Point(10, 349);
            this.btn_LoadChart.Name = "btn_LoadChart";
            this.btn_LoadChart.Size = new System.Drawing.Size(289, 60);
            this.btn_LoadChart.TabIndex = 5;
            this.btn_LoadChart.Text = "Load Chart";
            this.btn_LoadChart.UseVisualStyleBackColor = true;
            this.btn_LoadChart.Click += new System.EventHandler(this.btn_LoadChart_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.chk_Avg_Weight, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.chk_Avg_Reps, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.chk_Total_Reps, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.chk_Total_Sets, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 139);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(170, 136);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // chk_Avg_Weight
            // 
            this.chk_Avg_Weight.AutoSize = true;
            this.chk_Avg_Weight.Location = new System.Drawing.Point(3, 105);
            this.chk_Avg_Weight.Name = "chk_Avg_Weight";
            this.chk_Avg_Weight.Size = new System.Drawing.Size(164, 28);
            this.chk_Avg_Weight.TabIndex = 3;
            this.chk_Avg_Weight.Text = "Average Weight";
            this.chk_Avg_Weight.UseVisualStyleBackColor = true;
            this.chk_Avg_Weight.CheckStateChanged += new System.EventHandler(this.chk_Avg_Weight_CheckStateChanged);
            // 
            // chk_Avg_Reps
            // 
            this.chk_Avg_Reps.AutoSize = true;
            this.chk_Avg_Reps.Location = new System.Drawing.Point(3, 71);
            this.chk_Avg_Reps.Name = "chk_Avg_Reps";
            this.chk_Avg_Reps.Size = new System.Drawing.Size(149, 28);
            this.chk_Avg_Reps.TabIndex = 2;
            this.chk_Avg_Reps.Text = "Average Reps";
            this.chk_Avg_Reps.UseVisualStyleBackColor = true;
            this.chk_Avg_Reps.CheckStateChanged += new System.EventHandler(this.chk_Avg_Reps_CheckStateChanged);
            // 
            // chk_Total_Reps
            // 
            this.chk_Total_Reps.AutoSize = true;
            this.chk_Total_Reps.Location = new System.Drawing.Point(3, 37);
            this.chk_Total_Reps.Name = "chk_Total_Reps";
            this.chk_Total_Reps.Size = new System.Drawing.Size(119, 28);
            this.chk_Total_Reps.TabIndex = 1;
            this.chk_Total_Reps.Text = "Total Reps";
            this.chk_Total_Reps.UseVisualStyleBackColor = true;
            this.chk_Total_Reps.CheckStateChanged += new System.EventHandler(this.chk_Total_Reps_CheckStateChanged);
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
            this.chk_Total_Sets.CheckStateChanged += new System.EventHandler(this.chk_Total_Sets_CheckStateChanged);
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
            // cb_Workout_Name
            // 
            this.cb_Workout_Name.FormattingEnabled = true;
            this.cb_Workout_Name.Location = new System.Drawing.Point(110, 63);
            this.cb_Workout_Name.Name = "cb_Workout_Name";
            this.cb_Workout_Name.Size = new System.Drawing.Size(189, 32);
            this.cb_Workout_Name.TabIndex = 2;
            // 
            // cb_Person_Name
            // 
            this.cb_Person_Name.FormattingEnabled = true;
            this.cb_Person_Name.Location = new System.Drawing.Point(110, 25);
            this.cb_Person_Name.Name = "cb_Person_Name";
            this.cb_Person_Name.Size = new System.Drawing.Size(189, 32);
            this.cb_Person_Name.TabIndex = 1;
            this.cb_Person_Name.SelectionChangeCommitted += new System.EventHandler(this.cb_Person_Name_SelectionChangeCommitted);
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
            // Visualization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1285, 620);
            this.Controls.Add(this.gb_Filters);
            this.Controls.Add(this.chart1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Visualization";
            this.Text = "Visualization";
            this.Load += new System.EventHandler(this.Visualization_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.gb_Filters.ResumeLayout(false);
            this.gb_Filters.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gb_Filters;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.CheckBox chk_Avg_Weight;
        private System.Windows.Forms.CheckBox chk_Avg_Reps;
        private System.Windows.Forms.CheckBox chk_Total_Reps;
        private System.Windows.Forms.CheckBox chk_Total_Sets;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_Workout_Name;
        private System.Windows.Forms.ComboBox cb_Person_Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_LoadChart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_Total_Days;
        private System.Windows.Forms.Button btn_Reset;
        public System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}