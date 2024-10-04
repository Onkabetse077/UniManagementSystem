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
            this.lblX_Main = new System.Windows.Forms.Label();
            this.pnlSideMain_Main = new System.Windows.Forms.Panel();
            this.pbLogo_Main = new System.Windows.Forms.PictureBox();
            this.lblUniManagementSystem_Main = new System.Windows.Forms.Label();
            this.pnlHeader_Main.SuspendLayout();
            this.pnlSideMain_Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo_Main)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader_Main
            // 
            this.pnlHeader_Main.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlHeader_Main.Controls.Add(this.lblX_Main);
            this.pnlHeader_Main.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader_Main.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader_Main.Name = "pnlHeader_Main";
            this.pnlHeader_Main.Size = new System.Drawing.Size(1200, 47);
            this.pnlHeader_Main.TabIndex = 0;
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
            // 
            // pnlSideMain_Main
            // 
            this.pnlSideMain_Main.BackColor = System.Drawing.Color.Lime;
            this.pnlSideMain_Main.Controls.Add(this.lblUniManagementSystem_Main);
            this.pnlSideMain_Main.Controls.Add(this.pbLogo_Main);
            this.pnlSideMain_Main.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSideMain_Main.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlSideMain_Main.Location = new System.Drawing.Point(0, 47);
            this.pnlSideMain_Main.Name = "pnlSideMain_Main";
            this.pnlSideMain_Main.Size = new System.Drawing.Size(334, 653);
            this.pnlSideMain_Main.TabIndex = 1;
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
            // lblUniManagementSystem_Main
            // 
            this.lblUniManagementSystem_Main.AutoSize = true;
            this.lblUniManagementSystem_Main.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUniManagementSystem_Main.Location = new System.Drawing.Point(42, 186);
            this.lblUniManagementSystem_Main.Name = "lblUniManagementSystem_Main";
            this.lblUniManagementSystem_Main.Size = new System.Drawing.Size(251, 29);
            this.lblUniManagementSystem_Main.TabIndex = 2;
            this.lblUniManagementSystem_Main.Text = "Uni Management System";
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
        private System.Windows.Forms.Label lblUniManagementSystem_Main;
    }
}