namespace DBMidProject
{
    partial class mainUserControlMenuPanel
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
            this.rlevelsBtn = new System.Windows.Forms.Button();
            this.assessmentsBtn = new System.Windows.Forms.Button();
            this.rubricsBtn = new System.Windows.Forms.Button();
            this.closBtn = new System.Windows.Forms.Button();
            this.studentsBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rlevelsBtn
            // 
            this.rlevelsBtn.Location = new System.Drawing.Point(40, 367);
            this.rlevelsBtn.Name = "rlevelsBtn";
            this.rlevelsBtn.Size = new System.Drawing.Size(129, 23);
            this.rlevelsBtn.TabIndex = 9;
            this.rlevelsBtn.Text = "Manage R_Levels";
            this.rlevelsBtn.UseVisualStyleBackColor = true;
            this.rlevelsBtn.Click += new System.EventHandler(this.rlevelsBtn_Click_1);
            // 
            // assessmentsBtn
            // 
            this.assessmentsBtn.Location = new System.Drawing.Point(40, 288);
            this.assessmentsBtn.Name = "assessmentsBtn";
            this.assessmentsBtn.Size = new System.Drawing.Size(129, 23);
            this.assessmentsBtn.TabIndex = 8;
            this.assessmentsBtn.Text = "Manage Assessments";
            this.assessmentsBtn.UseVisualStyleBackColor = true;
            this.assessmentsBtn.Click += new System.EventHandler(this.assessmentsBtn_Click_1);
            // 
            // rubricsBtn
            // 
            this.rubricsBtn.Location = new System.Drawing.Point(40, 225);
            this.rubricsBtn.Name = "rubricsBtn";
            this.rubricsBtn.Size = new System.Drawing.Size(129, 23);
            this.rubricsBtn.TabIndex = 7;
            this.rubricsBtn.Text = "Manage Rubrics";
            this.rubricsBtn.UseVisualStyleBackColor = true;
            this.rubricsBtn.Click += new System.EventHandler(this.rubricsBtn_Click_1);
            // 
            // closBtn
            // 
            this.closBtn.Location = new System.Drawing.Point(40, 157);
            this.closBtn.Name = "closBtn";
            this.closBtn.Size = new System.Drawing.Size(129, 23);
            this.closBtn.TabIndex = 6;
            this.closBtn.Text = "Manage CLOs";
            this.closBtn.UseVisualStyleBackColor = true;
            this.closBtn.Click += new System.EventHandler(this.closBtn_Click_1);
            // 
            // studentsBtn
            // 
            this.studentsBtn.Location = new System.Drawing.Point(40, 78);
            this.studentsBtn.Name = "studentsBtn";
            this.studentsBtn.Size = new System.Drawing.Size(129, 23);
            this.studentsBtn.TabIndex = 5;
            this.studentsBtn.Text = "Manage Students";
            this.studentsBtn.UseVisualStyleBackColor = true;
            this.studentsBtn.Click += new System.EventHandler(this.studentsBtn_Click);
            // 
            // mainUserControlMenuPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rlevelsBtn);
            this.Controls.Add(this.assessmentsBtn);
            this.Controls.Add(this.rubricsBtn);
            this.Controls.Add(this.closBtn);
            this.Controls.Add(this.studentsBtn);
            this.Name = "mainUserControlMenuPanel";
            this.Size = new System.Drawing.Size(209, 469);
            this.Load += new System.EventHandler(this.mainUserControlMenuPanel_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button rlevelsBtn;
        private System.Windows.Forms.Button assessmentsBtn;
        private System.Windows.Forms.Button rubricsBtn;
        private System.Windows.Forms.Button closBtn;
        private System.Windows.Forms.Button studentsBtn;
    }
}
