namespace Workout_Tracker_SQLite
{
    partial class DataForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataForm));
            this.dataGridView_DailyProgress = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_Person = new System.Windows.Forms.ComboBox();
            this.btn_Filter_Person = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_Exercise = new System.Windows.Forms.ComboBox();
            this.btn_Filter_Exercise = new System.Windows.Forms.Button();
            this.btn_FilterAll = new System.Windows.Forms.Button();
            this.btn_ClearFilters = new System.Windows.Forms.Button();
            this.groupBox_Filters = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DailyProgress)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox_Filters.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_DailyProgress
            // 
            this.dataGridView_DailyProgress.AllowUserToAddRows = false;
            this.dataGridView_DailyProgress.AllowUserToDeleteRows = false;
            this.dataGridView_DailyProgress.AllowUserToOrderColumns = true;
            this.dataGridView_DailyProgress.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_DailyProgress.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView_DailyProgress.Location = new System.Drawing.Point(0, 109);
            this.dataGridView_DailyProgress.Name = "dataGridView_DailyProgress";
            this.dataGridView_DailyProgress.ReadOnly = true;
            this.dataGridView_DailyProgress.Size = new System.Drawing.Size(1269, 515);
            this.dataGridView_DailyProgress.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 151F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cb_Person, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_Filter_Person, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.cb_Exercise, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_Filter_Exercise, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_FilterAll, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_ClearFilters, 3, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 25);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.22222F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.77778F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1263, 78);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Person";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cb_Person
            // 
            this.cb_Person.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cb_Person.FormattingEnabled = true;
            this.cb_Person.Location = new System.Drawing.Point(307, 3);
            this.cb_Person.Name = "cb_Person";
            this.cb_Person.Size = new System.Drawing.Size(602, 32);
            this.cb_Person.TabIndex = 1;
            // 
            // btn_Filter_Person
            // 
            this.btn_Filter_Person.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Filter_Person.Location = new System.Drawing.Point(915, 3);
            this.btn_Filter_Person.Name = "btn_Filter_Person";
            this.btn_Filter_Person.Size = new System.Drawing.Size(145, 34);
            this.btn_Filter_Person.TabIndex = 9;
            this.btn_Filter_Person.Text = "Filter Person";
            this.btn_Filter_Person.UseVisualStyleBackColor = true;
            this.btn_Filter_Person.Click += new System.EventHandler(this.btn_Filter_Person_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(298, 38);
            this.label2.TabIndex = 2;
            this.label2.Text = "Exercise";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cb_Exercise
            // 
            this.cb_Exercise.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cb_Exercise.FormattingEnabled = true;
            this.cb_Exercise.Location = new System.Drawing.Point(307, 43);
            this.cb_Exercise.Name = "cb_Exercise";
            this.cb_Exercise.Size = new System.Drawing.Size(602, 32);
            this.cb_Exercise.TabIndex = 3;
            // 
            // btn_Filter_Exercise
            // 
            this.btn_Filter_Exercise.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Filter_Exercise.Location = new System.Drawing.Point(915, 43);
            this.btn_Filter_Exercise.Name = "btn_Filter_Exercise";
            this.btn_Filter_Exercise.Size = new System.Drawing.Size(145, 32);
            this.btn_Filter_Exercise.TabIndex = 10;
            this.btn_Filter_Exercise.Text = "Filter Exercise";
            this.btn_Filter_Exercise.UseVisualStyleBackColor = true;
            this.btn_Filter_Exercise.Click += new System.EventHandler(this.btn_Filter_Exercise_Click);
            // 
            // btn_FilterAll
            // 
            this.btn_FilterAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_FilterAll.Location = new System.Drawing.Point(1066, 3);
            this.btn_FilterAll.Name = "btn_FilterAll";
            this.btn_FilterAll.Size = new System.Drawing.Size(194, 34);
            this.btn_FilterAll.TabIndex = 13;
            this.btn_FilterAll.Text = "Filter All";
            this.btn_FilterAll.UseVisualStyleBackColor = true;
            this.btn_FilterAll.Click += new System.EventHandler(this.btn_FilterAll_Click);
            // 
            // btn_ClearFilters
            // 
            this.btn_ClearFilters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_ClearFilters.Location = new System.Drawing.Point(1066, 43);
            this.btn_ClearFilters.Name = "btn_ClearFilters";
            this.btn_ClearFilters.Size = new System.Drawing.Size(194, 32);
            this.btn_ClearFilters.TabIndex = 14;
            this.btn_ClearFilters.Text = "Clear Filters";
            this.btn_ClearFilters.UseVisualStyleBackColor = true;
            this.btn_ClearFilters.Click += new System.EventHandler(this.btn_ClearFilters_Click);
            // 
            // groupBox_Filters
            // 
            this.groupBox_Filters.Controls.Add(this.tableLayoutPanel1);
            this.groupBox_Filters.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox_Filters.Location = new System.Drawing.Point(0, 0);
            this.groupBox_Filters.Name = "groupBox_Filters";
            this.groupBox_Filters.Size = new System.Drawing.Size(1269, 106);
            this.groupBox_Filters.TabIndex = 2;
            this.groupBox_Filters.TabStop = false;
            this.groupBox_Filters.Text = "Data Filters";
            // 
            // DataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1269, 624);
            this.Controls.Add(this.groupBox_Filters);
            this.Controls.Add(this.dataGridView_DailyProgress);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "DataForm";
            this.Text = "DataForm";
            this.Load += new System.EventHandler(this.DataForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DailyProgress)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox_Filters.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_DailyProgress;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox cb_Exercise;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_Person;
        private System.Windows.Forms.Button btn_Filter_Person;
        private System.Windows.Forms.Button btn_Filter_Exercise;
        private System.Windows.Forms.Button btn_FilterAll;
        private System.Windows.Forms.Button btn_ClearFilters;
        private System.Windows.Forms.GroupBox groupBox_Filters;
    }
}