namespace DBMidProject
{
    partial class StudentMenuPanel
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
            this.addStudentMenuBtn = new System.Windows.Forms.Button();
            this.updateStudentMenuBtn = new System.Windows.Forms.Button();
            this.deleteStudentMenuBtn = new System.Windows.Forms.Button();
            this.viewStudentMenuBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.markAttendenceBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addStudentMenuBtn
            // 
            this.addStudentMenuBtn.Location = new System.Drawing.Point(64, 20);
            this.addStudentMenuBtn.Name = "addStudentMenuBtn";
            this.addStudentMenuBtn.Size = new System.Drawing.Size(94, 23);
            this.addStudentMenuBtn.TabIndex = 0;
            this.addStudentMenuBtn.Text = "Add Student";
            this.addStudentMenuBtn.UseVisualStyleBackColor = true;
            this.addStudentMenuBtn.Click += new System.EventHandler(this.addStudentMenuBtn_Click);
            // 
            // updateStudentMenuBtn
            // 
            this.updateStudentMenuBtn.Location = new System.Drawing.Point(64, 70);
            this.updateStudentMenuBtn.Name = "updateStudentMenuBtn";
            this.updateStudentMenuBtn.Size = new System.Drawing.Size(94, 23);
            this.updateStudentMenuBtn.TabIndex = 1;
            this.updateStudentMenuBtn.Text = "Update Student";
            this.updateStudentMenuBtn.UseVisualStyleBackColor = true;
            this.updateStudentMenuBtn.Click += new System.EventHandler(this.updateStudentMenuBtn_Click);
            // 
            // deleteStudentMenuBtn
            // 
            this.deleteStudentMenuBtn.Location = new System.Drawing.Point(64, 132);
            this.deleteStudentMenuBtn.Name = "deleteStudentMenuBtn";
            this.deleteStudentMenuBtn.Size = new System.Drawing.Size(94, 23);
            this.deleteStudentMenuBtn.TabIndex = 2;
            this.deleteStudentMenuBtn.Text = "Delete Student";
            this.deleteStudentMenuBtn.UseVisualStyleBackColor = true;
            this.deleteStudentMenuBtn.Click += new System.EventHandler(this.deleteStudentMenuBtn_Click);
            // 
            // viewStudentMenuBtn
            // 
            this.viewStudentMenuBtn.Location = new System.Drawing.Point(64, 197);
            this.viewStudentMenuBtn.Name = "viewStudentMenuBtn";
            this.viewStudentMenuBtn.Size = new System.Drawing.Size(94, 23);
            this.viewStudentMenuBtn.TabIndex = 3;
            this.viewStudentMenuBtn.Text = "View Students";
            this.viewStudentMenuBtn.UseVisualStyleBackColor = true;
            this.viewStudentMenuBtn.Click += new System.EventHandler(this.viewStudentMenuBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(64, 438);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(94, 23);
            this.backBtn.TabIndex = 4;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // markAttendenceBtn
            // 
            this.markAttendenceBtn.Location = new System.Drawing.Point(64, 272);
            this.markAttendenceBtn.Name = "markAttendenceBtn";
            this.markAttendenceBtn.Size = new System.Drawing.Size(103, 23);
            this.markAttendenceBtn.TabIndex = 5;
            this.markAttendenceBtn.Text = "Mark Attendence";
            this.markAttendenceBtn.UseVisualStyleBackColor = true;
            this.markAttendenceBtn.Click += new System.EventHandler(this.markAttendenceBtn_Click);
            // 
            // StudentMenuPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.markAttendenceBtn);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.viewStudentMenuBtn);
            this.Controls.Add(this.deleteStudentMenuBtn);
            this.Controls.Add(this.updateStudentMenuBtn);
            this.Controls.Add(this.addStudentMenuBtn);
            this.Name = "StudentMenuPanel";
            this.Size = new System.Drawing.Size(268, 517);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addStudentMenuBtn;
        private System.Windows.Forms.Button updateStudentMenuBtn;
        private System.Windows.Forms.Button deleteStudentMenuBtn;
        private System.Windows.Forms.Button viewStudentMenuBtn;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button markAttendenceBtn;
    }
}
