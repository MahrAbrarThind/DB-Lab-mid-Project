namespace DBMidProject.MenuPanels.Attendence_Panels
{
    partial class studentAttendencePanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.attendenceComboBox = new System.Windows.Forms.ComboBox();
            this.attendenceBtn = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(70, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(372, 373);
            this.dataGridView1.TabIndex = 13;
            // 
            // attendenceComboBox
            // 
            this.attendenceComboBox.FormattingEnabled = true;
            this.attendenceComboBox.Items.AddRange(new object[] {
            "present",
            "absent",
            "leave",
            "late"});
            this.attendenceComboBox.Location = new System.Drawing.Point(94, 426);
            this.attendenceComboBox.Name = "attendenceComboBox";
            this.attendenceComboBox.Size = new System.Drawing.Size(121, 21);
            this.attendenceComboBox.TabIndex = 14;
            this.attendenceComboBox.SelectedIndexChanged += new System.EventHandler(this.attendenceComboBox_SelectedIndexChanged);
            // 
            // attendenceBtn
            // 
            this.attendenceBtn.Location = new System.Drawing.Point(267, 426);
            this.attendenceBtn.Name = "attendenceBtn";
            this.attendenceBtn.Size = new System.Drawing.Size(101, 23);
            this.attendenceBtn.TabIndex = 15;
            this.attendenceBtn.Text = "Mark Attendence";
            this.attendenceBtn.UseVisualStyleBackColor = true;
            this.attendenceBtn.Click += new System.EventHandler(this.attendenceBtn_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(168, 3);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 17;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // studentAttendencePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.attendenceBtn);
            this.Controls.Add(this.attendenceComboBox);
            this.Controls.Add(this.dataGridView1);
            this.Name = "studentAttendencePanel";
            this.Size = new System.Drawing.Size(506, 546);
            this.Load += new System.EventHandler(this.studentAttendencePanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox attendenceComboBox;
        private System.Windows.Forms.Button attendenceBtn;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}
