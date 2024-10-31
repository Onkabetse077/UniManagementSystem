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
            this.dgvStudentData_AddStudents = new System.Windows.Forms.DataGridView();
            this.lblStudentData_AddStudents = new System.Windows.Forms.Label();
            this.pnlInputStudentData_AddStudents = new System.Windows.Forms.Panel();
            this.tbAddress_AddStudent = new System.Windows.Forms.TextBox();
            this.lblAddress_AddStudent = new System.Windows.Forms.Label();
            this.lblSection_AddStudents = new System.Windows.Forms.Label();
            this.lblGrade_AddStudents = new System.Windows.Forms.Label();
            this.lblGender_AddStudents = new System.Windows.Forms.Label();
            this.cbGender_AddStudents = new System.Windows.Forms.ComboBox();
            this.tbFullName_AddStudents = new System.Windows.Forms.TextBox();
            this.lblFullName_AddStudents = new System.Windows.Forms.Label();
            this.tbStudentID_AddStudents = new System.Windows.Forms.TextBox();
            this.lblStudentID_AddStudents = new System.Windows.Forms.Label();
            this.cbGrade_AddStudents = new System.Windows.Forms.ComboBox();
            this.cbSection_AddStudents = new System.Windows.Forms.ComboBox();
            this.pnlImg_AddStudents = new System.Windows.Forms.Panel();
            this.btnImport_AddStudents = new System.Windows.Forms.Button();
            this.btnAdd_AddStudents = new System.Windows.Forms.Button();
            this.btnUpdate_AddStudents = new System.Windows.Forms.Button();
            this.btnDelete_AddStudents = new System.Windows.Forms.Button();
            this.btnClear_AddStudents = new System.Windows.Forms.Button();
            this.pnlStudentData_AddStudents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentData_AddStudents)).BeginInit();
            this.pnlInputStudentData_AddStudents.SuspendLayout();
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
            this.pnlStudentData_AddStudents.Size = new System.Drawing.Size(1026, 296);
            this.pnlStudentData_AddStudents.TabIndex = 0;
            // 
            // dgvStudentData_AddStudents
            // 
            this.dgvStudentData_AddStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudentData_AddStudents.Location = new System.Drawing.Point(20, 38);
            this.dgvStudentData_AddStudents.Name = "dgvStudentData_AddStudents";
            this.dgvStudentData_AddStudents.RowHeadersWidth = 51;
            this.dgvStudentData_AddStudents.RowTemplate.Height = 24;
            this.dgvStudentData_AddStudents.Size = new System.Drawing.Size(986, 243);
            this.dgvStudentData_AddStudents.TabIndex = 1;
            // 
            // lblStudentData_AddStudents
            // 
            this.lblStudentData_AddStudents.AutoSize = true;
            this.lblStudentData_AddStudents.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentData_AddStudents.Location = new System.Drawing.Point(15, 10);
            this.lblStudentData_AddStudents.Name = "lblStudentData_AddStudents";
            this.lblStudentData_AddStudents.Size = new System.Drawing.Size(138, 25);
            this.lblStudentData_AddStudents.TabIndex = 0;
            this.lblStudentData_AddStudents.Text = "Student\'s Data";
            // 
            // pnlInputStudentData_AddStudents
            // 
            this.pnlInputStudentData_AddStudents.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlInputStudentData_AddStudents.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlInputStudentData_AddStudents.Controls.Add(this.btnDelete_AddStudents);
            this.pnlInputStudentData_AddStudents.Controls.Add(this.btnClear_AddStudents);
            this.pnlInputStudentData_AddStudents.Controls.Add(this.btnUpdate_AddStudents);
            this.pnlInputStudentData_AddStudents.Controls.Add(this.btnAdd_AddStudents);
            this.pnlInputStudentData_AddStudents.Controls.Add(this.btnImport_AddStudents);
            this.pnlInputStudentData_AddStudents.Controls.Add(this.pnlImg_AddStudents);
            this.pnlInputStudentData_AddStudents.Controls.Add(this.cbSection_AddStudents);
            this.pnlInputStudentData_AddStudents.Controls.Add(this.cbGrade_AddStudents);
            this.pnlInputStudentData_AddStudents.Controls.Add(this.tbAddress_AddStudent);
            this.pnlInputStudentData_AddStudents.Controls.Add(this.lblAddress_AddStudent);
            this.pnlInputStudentData_AddStudents.Controls.Add(this.lblSection_AddStudents);
            this.pnlInputStudentData_AddStudents.Controls.Add(this.lblGrade_AddStudents);
            this.pnlInputStudentData_AddStudents.Controls.Add(this.lblGender_AddStudents);
            this.pnlInputStudentData_AddStudents.Controls.Add(this.cbGender_AddStudents);
            this.pnlInputStudentData_AddStudents.Controls.Add(this.tbFullName_AddStudents);
            this.pnlInputStudentData_AddStudents.Controls.Add(this.lblFullName_AddStudents);
            this.pnlInputStudentData_AddStudents.Controls.Add(this.tbStudentID_AddStudents);
            this.pnlInputStudentData_AddStudents.Controls.Add(this.lblStudentID_AddStudents);
            this.pnlInputStudentData_AddStudents.Location = new System.Drawing.Point(14, 337);
            this.pnlInputStudentData_AddStudents.Name = "pnlInputStudentData_AddStudents";
            this.pnlInputStudentData_AddStudents.Size = new System.Drawing.Size(1026, 291);
            this.pnlInputStudentData_AddStudents.TabIndex = 1;
            // 
            // tbAddress_AddStudent
            // 
            this.tbAddress_AddStudent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbAddress_AddStudent.Location = new System.Drawing.Point(398, 30);
            this.tbAddress_AddStudent.Multiline = true;
            this.tbAddress_AddStudent.Name = "tbAddress_AddStudent";
            this.tbAddress_AddStudent.Size = new System.Drawing.Size(160, 70);
            this.tbAddress_AddStudent.TabIndex = 14;
            // 
            // lblAddress_AddStudent
            // 
            this.lblAddress_AddStudent.AutoSize = true;
            this.lblAddress_AddStudent.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress_AddStudent.Location = new System.Drawing.Point(308, 30);
            this.lblAddress_AddStudent.Name = "lblAddress_AddStudent";
            this.lblAddress_AddStudent.Size = new System.Drawing.Size(65, 18);
            this.lblAddress_AddStudent.TabIndex = 13;
            this.lblAddress_AddStudent.Text = "Address:";
            // 
            // lblSection_AddStudents
            // 
            this.lblSection_AddStudents.AutoSize = true;
            this.lblSection_AddStudents.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSection_AddStudents.Location = new System.Drawing.Point(620, 30);
            this.lblSection_AddStudents.Name = "lblSection_AddStudents";
            this.lblSection_AddStudents.Size = new System.Drawing.Size(59, 18);
            this.lblSection_AddStudents.TabIndex = 9;
            this.lblSection_AddStudents.Text = "Section:";
            // 
            // lblGrade_AddStudents
            // 
            this.lblGrade_AddStudents.AutoSize = true;
            this.lblGrade_AddStudents.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrade_AddStudents.Location = new System.Drawing.Point(308, 128);
            this.lblGrade_AddStudents.Name = "lblGrade_AddStudents";
            this.lblGrade_AddStudents.Size = new System.Drawing.Size(52, 18);
            this.lblGrade_AddStudents.TabIndex = 7;
            this.lblGrade_AddStudents.Text = "Grade:";
            // 
            // lblGender_AddStudents
            // 
            this.lblGender_AddStudents.AutoSize = true;
            this.lblGender_AddStudents.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender_AddStudents.Location = new System.Drawing.Point(17, 133);
            this.lblGender_AddStudents.Name = "lblGender_AddStudents";
            this.lblGender_AddStudents.Size = new System.Drawing.Size(60, 18);
            this.lblGender_AddStudents.TabIndex = 6;
            this.lblGender_AddStudents.Text = "Gender:";
            // 
            // cbGender_AddStudents
            // 
            this.cbGender_AddStudents.FormattingEnabled = true;
            this.cbGender_AddStudents.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.cbGender_AddStudents.Location = new System.Drawing.Point(107, 127);
            this.cbGender_AddStudents.Name = "cbGender_AddStudents";
            this.cbGender_AddStudents.Size = new System.Drawing.Size(160, 24);
            this.cbGender_AddStudents.TabIndex = 5;
            // 
            // tbFullName_AddStudents
            // 
            this.tbFullName_AddStudents.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbFullName_AddStudents.Location = new System.Drawing.Point(107, 78);
            this.tbFullName_AddStudents.Name = "tbFullName_AddStudents";
            this.tbFullName_AddStudents.Size = new System.Drawing.Size(160, 22);
            this.tbFullName_AddStudents.TabIndex = 4;
            // 
            // lblFullName_AddStudents
            // 
            this.lblFullName_AddStudents.AutoSize = true;
            this.lblFullName_AddStudents.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullName_AddStudents.Location = new System.Drawing.Point(17, 82);
            this.lblFullName_AddStudents.Name = "lblFullName_AddStudents";
            this.lblFullName_AddStudents.Size = new System.Drawing.Size(77, 18);
            this.lblFullName_AddStudents.TabIndex = 3;
            this.lblFullName_AddStudents.Text = "Full Name:";
            // 
            // tbStudentID_AddStudents
            // 
            this.tbStudentID_AddStudents.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbStudentID_AddStudents.Location = new System.Drawing.Point(107, 30);
            this.tbStudentID_AddStudents.Name = "tbStudentID_AddStudents";
            this.tbStudentID_AddStudents.Size = new System.Drawing.Size(160, 22);
            this.tbStudentID_AddStudents.TabIndex = 2;
            // 
            // lblStudentID_AddStudents
            // 
            this.lblStudentID_AddStudents.AutoSize = true;
            this.lblStudentID_AddStudents.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentID_AddStudents.Location = new System.Drawing.Point(17, 30);
            this.lblStudentID_AddStudents.Name = "lblStudentID_AddStudents";
            this.lblStudentID_AddStudents.Size = new System.Drawing.Size(84, 18);
            this.lblStudentID_AddStudents.TabIndex = 1;
            this.lblStudentID_AddStudents.Text = "Student ID:";
            // 
            // cbGrade_AddStudents
            // 
            this.cbGrade_AddStudents.FormattingEnabled = true;
            this.cbGrade_AddStudents.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.cbGrade_AddStudents.Location = new System.Drawing.Point(398, 127);
            this.cbGrade_AddStudents.Name = "cbGrade_AddStudents";
            this.cbGrade_AddStudents.Size = new System.Drawing.Size(160, 24);
            this.cbGrade_AddStudents.TabIndex = 15;
            // 
            // cbSection_AddStudents
            // 
            this.cbSection_AddStudents.FormattingEnabled = true;
            this.cbSection_AddStudents.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.cbSection_AddStudents.Location = new System.Drawing.Point(695, 30);
            this.cbSection_AddStudents.Name = "cbSection_AddStudents";
            this.cbSection_AddStudents.Size = new System.Drawing.Size(160, 24);
            this.cbSection_AddStudents.TabIndex = 17;
            // 
            // pnlImg_AddStudents
            // 
            this.pnlImg_AddStudents.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlImg_AddStudents.Location = new System.Drawing.Point(888, 30);
            this.pnlImg_AddStudents.Name = "pnlImg_AddStudents";
            this.pnlImg_AddStudents.Size = new System.Drawing.Size(118, 121);
            this.pnlImg_AddStudents.TabIndex = 18;
            // 
            // btnImport_AddStudents
            // 
            this.btnImport_AddStudents.BackColor = System.Drawing.Color.Lime;
            this.btnImport_AddStudents.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btnImport_AddStudents.FlatAppearance.BorderSize = 0;
            this.btnImport_AddStudents.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LimeGreen;
            this.btnImport_AddStudents.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.btnImport_AddStudents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImport_AddStudents.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImport_AddStudents.Location = new System.Drawing.Point(888, 157);
            this.btnImport_AddStudents.Name = "btnImport_AddStudents";
            this.btnImport_AddStudents.Size = new System.Drawing.Size(118, 23);
            this.btnImport_AddStudents.TabIndex = 19;
            this.btnImport_AddStudents.Text = "Import";
            this.btnImport_AddStudents.UseVisualStyleBackColor = false;
            // 
            // btnAdd_AddStudents
            // 
            this.btnAdd_AddStudents.BackColor = System.Drawing.Color.Lime;
            this.btnAdd_AddStudents.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btnAdd_AddStudents.FlatAppearance.BorderSize = 0;
            this.btnAdd_AddStudents.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LimeGreen;
            this.btnAdd_AddStudents.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.btnAdd_AddStudents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd_AddStudents.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd_AddStudents.Location = new System.Drawing.Point(170, 213);
            this.btnAdd_AddStudents.Name = "btnAdd_AddStudents";
            this.btnAdd_AddStudents.Size = new System.Drawing.Size(118, 51);
            this.btnAdd_AddStudents.TabIndex = 20;
            this.btnAdd_AddStudents.Text = "Add";
            this.btnAdd_AddStudents.UseVisualStyleBackColor = false;
            // 
            // btnUpdate_AddStudents
            // 
            this.btnUpdate_AddStudents.BackColor = System.Drawing.Color.Lime;
            this.btnUpdate_AddStudents.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btnUpdate_AddStudents.FlatAppearance.BorderSize = 0;
            this.btnUpdate_AddStudents.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LimeGreen;
            this.btnUpdate_AddStudents.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.btnUpdate_AddStudents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate_AddStudents.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate_AddStudents.Location = new System.Drawing.Point(326, 213);
            this.btnUpdate_AddStudents.Name = "btnUpdate_AddStudents";
            this.btnUpdate_AddStudents.Size = new System.Drawing.Size(118, 51);
            this.btnUpdate_AddStudents.TabIndex = 21;
            this.btnUpdate_AddStudents.Text = "Update";
            this.btnUpdate_AddStudents.UseVisualStyleBackColor = false;
            // 
            // btnDelete_AddStudents
            // 
            this.btnDelete_AddStudents.BackColor = System.Drawing.Color.Lime;
            this.btnDelete_AddStudents.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btnDelete_AddStudents.FlatAppearance.BorderSize = 0;
            this.btnDelete_AddStudents.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LimeGreen;
            this.btnDelete_AddStudents.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.btnDelete_AddStudents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete_AddStudents.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete_AddStudents.Location = new System.Drawing.Point(642, 213);
            this.btnDelete_AddStudents.Name = "btnDelete_AddStudents";
            this.btnDelete_AddStudents.Size = new System.Drawing.Size(118, 51);
            this.btnDelete_AddStudents.TabIndex = 23;
            this.btnDelete_AddStudents.Text = "Delete";
            this.btnDelete_AddStudents.UseVisualStyleBackColor = false;
            // 
            // btnClear_AddStudents
            // 
            this.btnClear_AddStudents.BackColor = System.Drawing.Color.Lime;
            this.btnClear_AddStudents.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btnClear_AddStudents.FlatAppearance.BorderSize = 0;
            this.btnClear_AddStudents.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LimeGreen;
            this.btnClear_AddStudents.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.btnClear_AddStudents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear_AddStudents.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear_AddStudents.Location = new System.Drawing.Point(486, 213);
            this.btnClear_AddStudents.Name = "btnClear_AddStudents";
            this.btnClear_AddStudents.Size = new System.Drawing.Size(118, 51);
            this.btnClear_AddStudents.TabIndex = 22;
            this.btnClear_AddStudents.Text = "Clear";
            this.btnClear_AddStudents.UseVisualStyleBackColor = false;
            // 
            // AddStudentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlInputStudentData_AddStudents);
            this.Controls.Add(this.pnlStudentData_AddStudents);
            this.Name = "AddStudentsForm";
            this.Size = new System.Drawing.Size(1059, 653);
            this.pnlStudentData_AddStudents.ResumeLayout(false);
            this.pnlStudentData_AddStudents.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentData_AddStudents)).EndInit();
            this.pnlInputStudentData_AddStudents.ResumeLayout(false);
            this.pnlInputStudentData_AddStudents.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlStudentData_AddStudents;
        private System.Windows.Forms.Panel pnlInputStudentData_AddStudents;
        private System.Windows.Forms.Label lblStudentData_AddStudents;
        private System.Windows.Forms.DataGridView dgvStudentData_AddStudents;
        private System.Windows.Forms.TextBox tbStudentID_AddStudents;
        private System.Windows.Forms.Label lblStudentID_AddStudents;
        private System.Windows.Forms.TextBox tbFullName_AddStudents;
        private System.Windows.Forms.Label lblFullName_AddStudents;
        private System.Windows.Forms.Label lblGender_AddStudents;
        private System.Windows.Forms.ComboBox cbGender_AddStudents;
        private System.Windows.Forms.Label lblSection_AddStudents;
        private System.Windows.Forms.Label lblGrade_AddStudents;
        private System.Windows.Forms.TextBox tbAddress_AddStudent;
        private System.Windows.Forms.Label lblAddress_AddStudent;
        private System.Windows.Forms.ComboBox cbSection_AddStudents;
        private System.Windows.Forms.ComboBox cbGrade_AddStudents;
        private System.Windows.Forms.Panel pnlImg_AddStudents;
        private System.Windows.Forms.Button btnImport_AddStudents;
        private System.Windows.Forms.Button btnAdd_AddStudents;
        private System.Windows.Forms.Button btnDelete_AddStudents;
        private System.Windows.Forms.Button btnClear_AddStudents;
        private System.Windows.Forms.Button btnUpdate_AddStudents;
    }
}
