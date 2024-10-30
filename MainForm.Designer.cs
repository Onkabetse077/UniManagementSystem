namespace UniManagementSystem
{
    partial class MainForm
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
            this.pnlHeader_Main = new System.Windows.Forms.Panel();
            this.lblUMS_Main = new System.Windows.Forms.Label();
            this.lblX_Main = new System.Windows.Forms.Label();
            this.pnlSideMain_Main = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblWelcome_Main = new System.Windows.Forms.Label();
            this.btnLogout_Main = new System.Windows.Forms.Button();
            this.btnAddStudent_Main = new System.Windows.Forms.Button();
            this.btnAddTeacher_Main = new System.Windows.Forms.Button();
            this.btnDashboard_Main = new System.Windows.Forms.Button();
            this.pbLogo_Main = new System.Windows.Forms.PictureBox();
            this.pnlHeader_Main.SuspendLayout();
            this.pnlSideMain_Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo_Main)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader_Main
            // 
            this.pnlHeader_Main.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlHeader_Main.Controls.Add(this.lblUMS_Main);
            this.pnlHeader_Main.Controls.Add(this.lblX_Main);
            this.pnlHeader_Main.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader_Main.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader_Main.Name = "pnlHeader_Main";
            this.pnlHeader_Main.Size = new System.Drawing.Size(1200, 47);
            this.pnlHeader_Main.TabIndex = 0;
            // 
            // lblUMS_Main
            // 
            this.lblUMS_Main.AutoSize = true;
            this.lblUMS_Main.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUMS_Main.Location = new System.Drawing.Point(12, 9);
            this.lblUMS_Main.Name = "lblUMS_Main";
            this.lblUMS_Main.Size = new System.Drawing.Size(327, 23);
            this.lblUMS_Main.TabIndex = 1;
            this.lblUMS_Main.Text = "Uni Management System(Main)";
            // 
            // lblX_Main
            // 
            this.lblX_Main.AutoSize = true;
            this.lblX_Main.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblX_Main.Location = new System.Drawing.Point(1162, 9);
            this.lblX_Main.Name = "lblX_Main";
            this.lblX_Main.Size = new System.Drawing.Size(26, 23);
            this.lblX_Main.TabIndex = 0;
            this.lblX_Main.Text = "X";
            this.lblX_Main.Click += new System.EventHandler(this.lblX_Main_Click);
            // 
            // pnlSideMain_Main
            // 
            this.pnlSideMain_Main.BackColor = System.Drawing.Color.Lime;
            this.pnlSideMain_Main.Controls.Add(this.btnLogout_Main);
            this.pnlSideMain_Main.Controls.Add(this.btnAddStudent_Main);
            this.pnlSideMain_Main.Controls.Add(this.btnAddTeacher_Main);
            this.pnlSideMain_Main.Controls.Add(this.btnDashboard_Main);
            this.pnlSideMain_Main.Controls.Add(this.label1);
            this.pnlSideMain_Main.Controls.Add(this.lblWelcome_Main);
            this.pnlSideMain_Main.Controls.Add(this.pbLogo_Main);
            this.pnlSideMain_Main.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSideMain_Main.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlSideMain_Main.Location = new System.Drawing.Point(0, 47);
            this.pnlSideMain_Main.Name = "pnlSideMain_Main";
            this.pnlSideMain_Main.Size = new System.Drawing.Size(334, 653);
            this.pnlSideMain_Main.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(175, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Admin";
            // 
            // lblWelcome_Main
            // 
            this.lblWelcome_Main.AutoSize = true;
            this.lblWelcome_Main.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome_Main.Location = new System.Drawing.Point(62, 186);
            this.lblWelcome_Main.Name = "lblWelcome_Main";
            this.lblWelcome_Main.Size = new System.Drawing.Size(107, 29);
            this.lblWelcome_Main.TabIndex = 2;
            this.lblWelcome_Main.Text = "Welcome,";
            // 
            // btnLogout_Main
            // 
            this.btnLogout_Main.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout_Main.FlatAppearance.BorderSize = 0;
            this.btnLogout_Main.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LimeGreen;
            this.btnLogout_Main.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.btnLogout_Main.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout_Main.Image = global::UniManagementSystem.Properties.Resources.logout;
            this.btnLogout_Main.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout_Main.Location = new System.Drawing.Point(12, 591);
            this.btnLogout_Main.Name = "btnLogout_Main";
            this.btnLogout_Main.Size = new System.Drawing.Size(56, 50);
            this.btnLogout_Main.TabIndex = 6;
            this.btnLogout_Main.UseVisualStyleBackColor = true;
            this.btnLogout_Main.Click += new System.EventHandler(this.btnLogout_Main_Click);
            // 
            // btnAddStudent_Main
            // 
            this.btnAddStudent_Main.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddStudent_Main.FlatAppearance.BorderSize = 0;
            this.btnAddStudent_Main.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LimeGreen;
            this.btnAddStudent_Main.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.btnAddStudent_Main.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddStudent_Main.Image = global::UniManagementSystem.Properties.Resources.student_registration;
            this.btnAddStudent_Main.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddStudent_Main.Location = new System.Drawing.Point(0, 393);
            this.btnAddStudent_Main.Name = "btnAddStudent_Main";
            this.btnAddStudent_Main.Size = new System.Drawing.Size(331, 50);
            this.btnAddStudent_Main.TabIndex = 5;
            this.btnAddStudent_Main.Text = "Add Student";
            this.btnAddStudent_Main.UseVisualStyleBackColor = true;
            // 
            // btnAddTeacher_Main
            // 
            this.btnAddTeacher_Main.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddTeacher_Main.FlatAppearance.BorderSize = 0;
            this.btnAddTeacher_Main.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LimeGreen;
            this.btnAddTeacher_Main.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.btnAddTeacher_Main.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTeacher_Main.Image = global::UniManagementSystem.Properties.Resources.Add_teacher_Main;
            this.btnAddTeacher_Main.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddTeacher_Main.Location = new System.Drawing.Point(0, 337);
            this.btnAddTeacher_Main.Name = "btnAddTeacher_Main";
            this.btnAddTeacher_Main.Size = new System.Drawing.Size(331, 50);
            this.btnAddTeacher_Main.TabIndex = 4;
            this.btnAddTeacher_Main.Text = "Add Teacher";
            this.btnAddTeacher_Main.UseVisualStyleBackColor = true;
            // 
            // btnDashboard_Main
            // 
            this.btnDashboard_Main.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDashboard_Main.FlatAppearance.BorderSize = 0;
            this.btnDashboard_Main.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LimeGreen;
            this.btnDashboard_Main.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.btnDashboard_Main.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard_Main.Image = global::UniManagementSystem.Properties.Resources.dashboard_Main;
            this.btnDashboard_Main.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard_Main.Location = new System.Drawing.Point(3, 281);
            this.btnDashboard_Main.Name = "btnDashboard_Main";
            this.btnDashboard_Main.Size = new System.Drawing.Size(331, 50);
            this.btnDashboard_Main.TabIndex = 1;
            this.btnDashboard_Main.Text = "Dashboard";
            this.btnDashboard_Main.UseVisualStyleBackColor = true;
            // 
            // pbLogo_Main
            // 
            this.pbLogo_Main.Image = global::UniManagementSystem.Properties.Resources.Main_Logo;
            this.pbLogo_Main.Location = new System.Drawing.Point(94, 55);
            this.pbLogo_Main.Name = "pbLogo_Main";
            this.pbLogo_Main.Size = new System.Drawing.Size(128, 128);
            this.pbLogo_Main.TabIndex = 2;
            this.pbLogo_Main.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.pnlSideMain_Main);
            this.Controls.Add(this.pnlHeader_Main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.pnlHeader_Main.ResumeLayout(false);
            this.pnlHeader_Main.PerformLayout();
            this.pnlSideMain_Main.ResumeLayout(false);
            this.pnlSideMain_Main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo_Main)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader_Main;
        private System.Windows.Forms.Label lblX_Main;
        private System.Windows.Forms.Panel pnlSideMain_Main;
        private System.Windows.Forms.PictureBox pbLogo_Main;
        private System.Windows.Forms.Label lblWelcome_Main;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDashboard_Main;
        private System.Windows.Forms.Button btnAddStudent_Main;
        private System.Windows.Forms.Button btnAddTeacher_Main;
        private System.Windows.Forms.Label lblUMS_Main;
        private System.Windows.Forms.Button btnLogout_Main;
    }
}