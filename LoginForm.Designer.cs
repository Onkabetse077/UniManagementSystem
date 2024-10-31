namespace UniManagementSystem
{
    partial class LoginForm
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
            this.pnlHeader_Login = new System.Windows.Forms.Panel();
            this.lblUMS_Login = new System.Windows.Forms.Label();
            this.lblX_Login = new System.Windows.Forms.Label();
            this.pnlSignin_Login = new System.Windows.Forms.Panel();
            this.lblRegisterLink_Login = new System.Windows.Forms.Label();
            this.lblRegister_Login = new System.Windows.Forms.Label();
            this.lblSignin_Login = new System.Windows.Forms.Label();
            this.btnLogin_Login = new System.Windows.Forms.Button();
            this.cbShowPassword_Login = new System.Windows.Forms.CheckBox();
            this.tbPassword_Login = new System.Windows.Forms.TextBox();
            this.lblPassword_Login = new System.Windows.Forms.Label();
            this.tbUsername_Login = new System.Windows.Forms.TextBox();
            this.lblUsername_Login = new System.Windows.Forms.Label();
            this.pnlHeader_Login.SuspendLayout();
            this.pnlSignin_Login.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader_Login
            // 
            this.pnlHeader_Login.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlHeader_Login.Controls.Add(this.lblUMS_Login);
            this.pnlHeader_Login.Controls.Add(this.lblX_Login);
            this.pnlHeader_Login.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader_Login.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader_Login.Name = "pnlHeader_Login";
            this.pnlHeader_Login.Size = new System.Drawing.Size(800, 35);
            this.pnlHeader_Login.TabIndex = 0;
            // 
            // lblUMS_Login
            // 
            this.lblUMS_Login.AutoSize = true;
            this.lblUMS_Login.Font = new System.Drawing.Font("Cooper Black", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUMS_Login.Location = new System.Drawing.Point(3, 9);
            this.lblUMS_Login.Name = "lblUMS_Login";
            this.lblUMS_Login.Size = new System.Drawing.Size(284, 20);
            this.lblUMS_Login.TabIndex = 2;
            this.lblUMS_Login.Text = "Uni Management System(Login)";
            // 
            // lblX_Login
            // 
            this.lblX_Login.AutoSize = true;
            this.lblX_Login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblX_Login.Font = new System.Drawing.Font("Cooper Black", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblX_Login.Location = new System.Drawing.Point(771, 9);
            this.lblX_Login.Name = "lblX_Login";
            this.lblX_Login.Size = new System.Drawing.Size(23, 20);
            this.lblX_Login.TabIndex = 1;
            this.lblX_Login.Text = "X";
            this.lblX_Login.Click += new System.EventHandler(this.lblX_Login_Click);
            // 
            // pnlSignin_Login
            // 
            this.pnlSignin_Login.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlSignin_Login.Controls.Add(this.lblRegisterLink_Login);
            this.pnlSignin_Login.Controls.Add(this.lblRegister_Login);
            this.pnlSignin_Login.Controls.Add(this.lblSignin_Login);
            this.pnlSignin_Login.Controls.Add(this.btnLogin_Login);
            this.pnlSignin_Login.Controls.Add(this.cbShowPassword_Login);
            this.pnlSignin_Login.Controls.Add(this.tbPassword_Login);
            this.pnlSignin_Login.Controls.Add(this.lblPassword_Login);
            this.pnlSignin_Login.Controls.Add(this.tbUsername_Login);
            this.pnlSignin_Login.Controls.Add(this.lblUsername_Login);
            this.pnlSignin_Login.Location = new System.Drawing.Point(234, 67);
            this.pnlSignin_Login.Name = "pnlSignin_Login";
            this.pnlSignin_Login.Size = new System.Drawing.Size(300, 396);
            this.pnlSignin_Login.TabIndex = 1;
            // 
            // lblRegisterLink_Login
            // 
            this.lblRegisterLink_Login.AutoSize = true;
            this.lblRegisterLink_Login.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblRegisterLink_Login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblRegisterLink_Login.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegisterLink_Login.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblRegisterLink_Login.Location = new System.Drawing.Point(190, 332);
            this.lblRegisterLink_Login.Name = "lblRegisterLink_Login";
            this.lblRegisterLink_Login.Size = new System.Drawing.Size(96, 19);
            this.lblRegisterLink_Login.TabIndex = 8;
            this.lblRegisterLink_Login.Text = "Register Here";
            this.lblRegisterLink_Login.Click += new System.EventHandler(this.lblRegisterLink_Login_Click);
            // 
            // lblRegister_Login
            // 
            this.lblRegister_Login.AutoSize = true;
            this.lblRegister_Login.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegister_Login.Location = new System.Drawing.Point(11, 332);
            this.lblRegister_Login.Name = "lblRegister_Login";
            this.lblRegister_Login.Size = new System.Drawing.Size(173, 19);
            this.lblRegister_Login.TabIndex = 7;
            this.lblRegister_Login.Text = "Don\'t Have An Account ?";
            // 
            // lblSignin_Login
            // 
            this.lblSignin_Login.AutoSize = true;
            this.lblSignin_Login.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignin_Login.Location = new System.Drawing.Point(98, 26);
            this.lblSignin_Login.Name = "lblSignin_Login";
            this.lblSignin_Login.Size = new System.Drawing.Size(81, 23);
            this.lblSignin_Login.TabIndex = 6;
            this.lblSignin_Login.Text = "Sign In";
            // 
            // btnLogin_Login
            // 
            this.btnLogin_Login.BackColor = System.Drawing.Color.Lime;
            this.btnLogin_Login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin_Login.FlatAppearance.BorderSize = 0;
            this.btnLogin_Login.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LimeGreen;
            this.btnLogin_Login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.btnLogin_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin_Login.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin_Login.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLogin_Login.Location = new System.Drawing.Point(39, 243);
            this.btnLogin_Login.Name = "btnLogin_Login";
            this.btnLogin_Login.Size = new System.Drawing.Size(94, 39);
            this.btnLogin_Login.TabIndex = 5;
            this.btnLogin_Login.Text = "Login";
            this.btnLogin_Login.UseVisualStyleBackColor = false;
            this.btnLogin_Login.Click += new System.EventHandler(this.btnLogin_Login_Click);
            // 
            // cbShowPassword_Login
            // 
            this.cbShowPassword_Login.AutoSize = true;
            this.cbShowPassword_Login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbShowPassword_Login.Location = new System.Drawing.Point(145, 199);
            this.cbShowPassword_Login.Name = "cbShowPassword_Login";
            this.cbShowPassword_Login.Size = new System.Drawing.Size(125, 20);
            this.cbShowPassword_Login.TabIndex = 4;
            this.cbShowPassword_Login.Text = "Show Password";
            this.cbShowPassword_Login.UseVisualStyleBackColor = true;
            this.cbShowPassword_Login.CheckedChanged += new System.EventHandler(this.cbShowPassword_Login_CheckedChanged);
            // 
            // tbPassword_Login
            // 
            this.tbPassword_Login.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPassword_Login.Location = new System.Drawing.Point(39, 171);
            this.tbPassword_Login.Name = "tbPassword_Login";
            this.tbPassword_Login.PasswordChar = '*';
            this.tbPassword_Login.Size = new System.Drawing.Size(231, 22);
            this.tbPassword_Login.TabIndex = 3;
            // 
            // lblPassword_Login
            // 
            this.lblPassword_Login.AutoSize = true;
            this.lblPassword_Login.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword_Login.Location = new System.Drawing.Point(34, 143);
            this.lblPassword_Login.Name = "lblPassword_Login";
            this.lblPassword_Login.Size = new System.Drawing.Size(92, 25);
            this.lblPassword_Login.TabIndex = 2;
            this.lblPassword_Login.Text = "Password:";
            // 
            // tbUsername_Login
            // 
            this.tbUsername_Login.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbUsername_Login.Location = new System.Drawing.Point(39, 105);
            this.tbUsername_Login.Name = "tbUsername_Login";
            this.tbUsername_Login.Size = new System.Drawing.Size(231, 22);
            this.tbUsername_Login.TabIndex = 1;
            // 
            // lblUsername_Login
            // 
            this.lblUsername_Login.AutoSize = true;
            this.lblUsername_Login.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername_Login.Location = new System.Drawing.Point(34, 77);
            this.lblUsername_Login.Name = "lblUsername_Login";
            this.lblUsername_Login.Size = new System.Drawing.Size(99, 25);
            this.lblUsername_Login.TabIndex = 0;
            this.lblUsername_Login.Text = "Username:";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.pnlSignin_Login);
            this.Controls.Add(this.pnlHeader_Login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.pnlHeader_Login.ResumeLayout(false);
            this.pnlHeader_Login.PerformLayout();
            this.pnlSignin_Login.ResumeLayout(false);
            this.pnlSignin_Login.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader_Login;
        private System.Windows.Forms.Label lblX_Login;
        private System.Windows.Forms.Label lblUMS_Login;
        private System.Windows.Forms.Panel pnlSignin_Login;
        private System.Windows.Forms.Label lblUsername_Login;
        private System.Windows.Forms.TextBox tbUsername_Login;
        private System.Windows.Forms.TextBox tbPassword_Login;
        private System.Windows.Forms.Label lblPassword_Login;
        private System.Windows.Forms.CheckBox cbShowPassword_Login;
        private System.Windows.Forms.Button btnLogin_Login;
        private System.Windows.Forms.Label lblSignin_Login;
        private System.Windows.Forms.Label lblRegister_Login;
        private System.Windows.Forms.Label lblRegisterLink_Login;
    }
}