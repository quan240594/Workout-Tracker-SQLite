namespace Workout_Tracker_SQLite
{
    partial class Workout_Details
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Workout_Details));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Workout_name = new System.Windows.Forms.TextBox();
            this.cb_Muscle_group = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.sqLiteCommand1 = new System.Data.SQLite.SQLiteCommand();
            this.chk_Weight = new System.Windows.Forms.CheckBox();
            this.chk_Active = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_Weight_Type = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_Day1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_Day2 = new System.Windows.Forms.ComboBox();
            this.btn_Save = new System.Windows.Forms.ToolStripButton();
            this.btn_Refresh = new System.Windows.Forms.ToolStripButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(25, 25);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_Save,
            this.btn_Refresh});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1278, 32);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 144);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(946, 388);
            this.dataGridView1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Exercise Name";
            // 
            // txt_Workout_name
            // 
            this.txt_Workout_name.Location = new System.Drawing.Point(200, 29);
            this.txt_Workout_name.Name = "txt_Workout_name";
            this.txt_Workout_name.Size = new System.Drawing.Size(299, 29);
            this.txt_Workout_name.TabIndex = 3;
            // 
            // cb_Muscle_group
            // 
            this.cb_Muscle_group.FormattingEnabled = true;
            this.cb_Muscle_group.Location = new System.Drawing.Point(200, 65);
            this.cb_Muscle_group.Name = "cb_Muscle_group";
            this.cb_Muscle_group.Size = new System.Drawing.Size(299, 32);
            this.cb_Muscle_group.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Muscle Group";
            // 
            // sqLiteCommand1
            // 
            this.sqLiteCommand1.CommandText = null;
            // 
            // chk_Weight
            // 
            this.chk_Weight.AutoSize = true;
            this.chk_Weight.Location = new System.Drawing.Point(411, 108);
            this.chk_Weight.Name = "chk_Weight";
            this.chk_Weight.Size = new System.Drawing.Size(88, 28);
            this.chk_Weight.TabIndex = 6;
            this.chk_Weight.Text = "Weight";
            this.chk_Weight.UseVisualStyleBackColor = true;
            this.chk_Weight.CheckStateChanged += new System.EventHandler(this.chk_Weight_CheckStateChanged);
            // 
            // chk_Active
            // 
            this.chk_Active.AutoSize = true;
            this.chk_Active.Location = new System.Drawing.Point(79, 109);
            this.chk_Active.Name = "chk_Active";
            this.chk_Active.Size = new System.Drawing.Size(80, 28);
            this.chk_Active.TabIndex = 7;
            this.chk_Active.Text = "Active";
            this.chk_Active.UseVisualStyleBackColor = true;
            this.chk_Active.CheckStateChanged += new System.EventHandler(this.chk_Active_CheckStateChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(602, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "Weight Type";
            // 
            // cb_Weight_Type
            // 
            this.cb_Weight_Type.FormattingEnabled = true;
            this.cb_Weight_Type.Location = new System.Drawing.Point(790, 29);
            this.cb_Weight_Type.Name = "cb_Weight_Type";
            this.cb_Weight_Type.Size = new System.Drawing.Size(168, 32);
            this.cb_Weight_Type.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(602, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 24);
            this.label4.TabIndex = 11;
            this.label4.Text = "Day 1";
            // 
            // cb_Day1
            // 
            this.cb_Day1.FormattingEnabled = true;
            this.cb_Day1.Location = new System.Drawing.Point(790, 68);
            this.cb_Day1.Name = "cb_Day1";
            this.cb_Day1.Size = new System.Drawing.Size(168, 32);
            this.cb_Day1.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(602, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 24);
            this.label5.TabIndex = 13;
            this.label5.Text = "Day 2";
            // 
            // cb_Day2
            // 
            this.cb_Day2.FormattingEnabled = true;
            this.cb_Day2.Location = new System.Drawing.Point(790, 106);
            this.cb_Day2.Name = "cb_Day2";
            this.cb_Day2.Size = new System.Drawing.Size(168, 32);
            this.cb_Day2.TabIndex = 12;
            // 
            // btn_Save
            // 
            this.btn_Save.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Save.Image = ((System.Drawing.Image)(resources.GetObject("btn_Save.Image")));
            this.btn_Save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(29, 29);
            this.btn_Save.Text = "Save";
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Refresh.Image = ((System.Drawing.Image)(resources.GetObject("btn_Refresh.Image")));
            this.btn_Refresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(29, 29);
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 24);
            this.label6.TabIndex = 14;
            this.label6.Text = "Active";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(196, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 24);
            this.label7.TabIndex = 15;
            this.label7.Text = "Weight Required";
            // 
            // Workout_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1278, 544);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cb_Day2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cb_Day1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_Weight_Type);
            this.Controls.Add(this.chk_Active);
            this.Controls.Add(this.chk_Weight);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_Muscle_group);
            this.Controls.Add(this.txt_Workout_name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Workout_Details";
            this.Text = "Workout_Details";
            this.Load += new System.EventHandler(this.Workout_Details_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Workout_name;
        private System.Windows.Forms.ComboBox cb_Muscle_group;
        private System.Windows.Forms.Label label2;
        private System.Data.SQLite.SQLiteCommand sqLiteCommand1;
        private System.Windows.Forms.CheckBox chk_Weight;
        private System.Windows.Forms.CheckBox chk_Active;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_Weight_Type;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_Day1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_Day2;
        private System.Windows.Forms.ToolStripButton btn_Save;
        private System.Windows.Forms.ToolStripButton btn_Refresh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}