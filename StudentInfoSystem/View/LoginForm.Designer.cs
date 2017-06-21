namespace StudentInfoSystem.View
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
            this.LogInWindow = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.PassBox = new System.Windows.Forms.TextBox();
            this.UserBox = new System.Windows.Forms.TextBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.LogInWindow.SuspendLayout();
            this.SuspendLayout();
            // 
            // LogInWindow
            // 
            this.LogInWindow.Controls.Add(this.btnCancel);
            this.LogInWindow.Controls.Add(this.btnLogin);
            this.LogInWindow.Controls.Add(this.PassBox);
            this.LogInWindow.Controls.Add(this.UserBox);
            this.LogInWindow.Controls.Add(this.lblPass);
            this.LogInWindow.Controls.Add(this.lblUser);
            this.LogInWindow.Location = new System.Drawing.Point(5, 5);
            this.LogInWindow.Name = "LogInWindow";
            this.LogInWindow.Size = new System.Drawing.Size(327, 269);
            this.LogInWindow.TabIndex = 0;
            this.LogInWindow.TabStop = false;
            this.LogInWindow.Text = "Вход";
            this.LogInWindow.Enter += new System.EventHandler(this.LogInWindow_Enter);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(205, 171);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(76, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(72, 171);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // PassBox
            // 
            this.PassBox.Location = new System.Drawing.Point(112, 109);
            this.PassBox.Name = "PassBox";
            this.PassBox.Size = new System.Drawing.Size(189, 20);
            this.PassBox.TabIndex = 4;
            // 
            // UserBox
            // 
            this.UserBox.Location = new System.Drawing.Point(114, 59);
            this.UserBox.Name = "UserBox";
            this.UserBox.Size = new System.Drawing.Size(189, 20);
            this.UserBox.TabIndex = 3;
            this.UserBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Location = new System.Drawing.Point(49, 109);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(48, 13);
            this.lblPass.TabIndex = 2;
            this.lblPass.Text = "Парола:";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(35, 59);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(73, 13);
            this.lblUser.TabIndex = 1;
            this.lblUser.Text = "Потребител: ";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 281);
            this.Controls.Add(this.LogInWindow);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.LogInWindow.ResumeLayout(false);
            this.LogInWindow.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox LogInWindow;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox PassBox;
        private System.Windows.Forms.TextBox UserBox;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Label lblUser;
    }
}