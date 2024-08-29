namespace UniManagementSystem
{
    partial class LoadingForm
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
            this.components = new System.ComponentModel.Container();
            this.lblUMS_Loading = new System.Windows.Forms.Label();
            this.pnlLoading = new System.Windows.Forms.Panel();
            this.pnlLoadingBar = new System.Windows.Forms.Panel();
            this.timer_Loading = new System.Windows.Forms.Timer(this.components);
            this.pbLogo_Loading = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo_Loading)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUMS_Loading
            // 
            this.lblUMS_Loading.AutoSize = true;
            this.lblUMS_Loading.Font = new System.Drawing.Font("Forte", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUMS_Loading.Location = new System.Drawing.Point(308, 351);
            this.lblUMS_Loading.Name = "lblUMS_Loading";
            this.lblUMS_Loading.Size = new System.Drawing.Size(181, 31);
            this.lblUMS_Loading.TabIndex = 0;
            this.lblUMS_Loading.Text = "Uni Manager";
            // 
            // pnlLoading
            // 
            this.pnlLoading.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlLoading.Location = new System.Drawing.Point(0, 545);
            this.pnlLoading.Name = "pnlLoading";
            this.pnlLoading.Size = new System.Drawing.Size(800, 55);
            this.pnlLoading.TabIndex = 2;
            // 
            // pnlLoadingBar
            // 
            this.pnlLoadingBar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlLoadingBar.Location = new System.Drawing.Point(0, 545);
            this.pnlLoadingBar.Name = "pnlLoadingBar";
            this.pnlLoadingBar.Size = new System.Drawing.Size(100, 55);
            this.pnlLoadingBar.TabIndex = 3;
            // 
            // timer_Loading
            // 
            this.timer_Loading.Enabled = true;
            this.timer_Loading.Interval = 20;
            this.timer_Loading.Tick += new System.EventHandler(this.timer_Loading_Tick);
            // 
            // pbLogo_Loading
            // 
            this.pbLogo_Loading.Image = global::UniManagementSystem.Properties.Resources.Loading_Logo;
            this.pbLogo_Loading.Location = new System.Drawing.Point(349, 248);
            this.pbLogo_Loading.Name = "pbLogo_Loading";
            this.pbLogo_Loading.Size = new System.Drawing.Size(100, 100);
            this.pbLogo_Loading.TabIndex = 1;
            this.pbLogo_Loading.TabStop = false;
            // 
            // LoadingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.pnlLoadingBar);
            this.Controls.Add(this.pnlLoading);
            this.Controls.Add(this.pbLogo_Loading);
            this.Controls.Add(this.lblUMS_Loading);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoadingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoadingForm";
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo_Loading)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUMS_Loading;
        private System.Windows.Forms.PictureBox pbLogo_Loading;
        private System.Windows.Forms.Panel pnlLoading;
        private System.Windows.Forms.Panel pnlLoadingBar;
        private System.Windows.Forms.Timer timer_Loading;
    }
}

