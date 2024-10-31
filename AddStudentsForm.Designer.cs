namespace UniManagementSystem
{
    partial class AddStudentsForm
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
            this.pnlStudentData_AddStudents = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblStudentData_AddStudents = new System.Windows.Forms.Label();
            this.dgvStudentData_AddStudents = new System.Windows.Forms.DataGridView();
            this.lblStudentID_AddStudents = new System.Windows.Forms.Label();
            this.tbStudentID_AddStudents = new System.Windows.Forms.TextBox();
            this.pnlStudentData_AddStudents.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentData_AddStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlStudentData_AddStudents
            // 
            this.pnlStudentData_AddStudents.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlStudentData_AddStudents.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlStudentData_AddStudents.Controls.Add(this.dgvStudentData_AddStudents);
            this.pnlStudentData_AddStudents.Controls.Add(this.lblStudentData_AddStudents);
            this.pnlStudentData_AddStudents.Location = new System.Drawing.Point(14, 21);
            this.pnlStudentData_AddStudents.Name = "pnlStudentData_AddStudents";
            this.pnlStudentData_AddStudents.Size = new System.Drawing.Size(826, 296);
            this.pnlStudentData_AddStudents.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.tbStudentID_AddStudents);
            this.panel2.Controls.Add(this.lblStudentID_AddStudents);
            this.panel2.Location = new System.Drawing.Point(14, 337);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(826, 291);
            this.panel2.TabIndex = 1;
            // 
            // lblStudentData_AddStudents
            // 
            this.lblStudentData_AddStudents.AutoSize = true;
            this.lblStudentData_AddStudents.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentData_AddStudents.Location = new System.Drawing.Point(15, 10);
            this.lblStudentData_AddStudents.Name = "lblStudentData_AddStudents";
            this.lblStudentData_AddStudents.Size = new System.Drawing.Size(123, 25);
            this.lblStudentData_AddStudents.TabIndex = 0;
            this.lblStudentData_AddStudents.Text = "Student Data";
            // 
            // dgvStudentData_AddStudents
            // 
            this.dgvStudentData_AddStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudentData_AddStudents.Location = new System.Drawing.Point(20, 38);
            this.dgvStudentData_AddStudents.Name = "dgvStudentData_AddStudents";
            this.dgvStudentData_AddStudents.RowHeadersWidth = 51;
            this.dgvStudentData_AddStudents.RowTemplate.Height = 24;
            this.dgvStudentData_AddStudents.Size = new System.Drawing.Size(785, 243);
            this.dgvStudentData_AddStudents.TabIndex = 1;
            // 
            // lblStudentID_AddStudents
            // 
            this.lblStudentID_AddStudents.AutoSize = true;
            this.lblStudentID_AddStudents.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentID_AddStudents.Location = new System.Drawing.Point(17, 38);
            this.lblStudentID_AddStudents.Name = "lblStudentID_AddStudents";
            this.lblStudentID_AddStudents.Size = new System.Drawing.Size(84, 18);
            this.lblStudentID_AddStudents.TabIndex = 1;
            this.lblStudentID_AddStudents.Text = "Student ID:";
            // 
            // tbStudentID_AddStudents
            // 
            this.tbStudentID_AddStudents.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbStudentID_AddStudents.Location = new System.Drawing.Point(107, 34);
            this.tbStudentID_AddStudents.Name = "tbStudentID_AddStudents";
            this.tbStudentID_AddStudents.Size = new System.Drawing.Size(100, 22);
            this.tbStudentID_AddStudents.TabIndex = 2;
            // 
            // AddStudentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlStudentData_AddStudents);
            this.Name = "AddStudentsForm";
            this.Size = new System.Drawing.Size(855, 653);
            this.pnlStudentData_AddStudents.ResumeLayout(false);
            this.pnlStudentData_AddStudents.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentData_AddStudents)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlStudentData_AddStudents;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblStudentData_AddStudents;
        private System.Windows.Forms.DataGridView dgvStudentData_AddStudents;
        private System.Windows.Forms.TextBox tbStudentID_AddStudents;
        private System.Windows.Forms.Label lblStudentID_AddStudents;
    }
}
