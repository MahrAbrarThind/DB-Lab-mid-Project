namespace DBMidProject.Form_Panels
{
    partial class deleteStudentsPanel
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
            this.label1 = new System.Windows.Forms.Label();
            this.rNumberTxtBox = new System.Windows.Forms.TextBox();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Registration No Of Student To Delete";
            // 
            // rNumberTxtBox
            // 
            this.rNumberTxtBox.Location = new System.Drawing.Point(116, 123);
            this.rNumberTxtBox.Name = "rNumberTxtBox";
            this.rNumberTxtBox.Size = new System.Drawing.Size(100, 20);
            this.rNumberTxtBox.TabIndex = 1;
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(130, 214);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteBtn.TabIndex = 2;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // deleteStudentsPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.rNumberTxtBox);
            this.Controls.Add(this.label1);
            this.Name = "deleteStudentsPanel";
            this.Size = new System.Drawing.Size(444, 513);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox rNumberTxtBox;
        private System.Windows.Forms.Button deleteBtn;
    }
}
