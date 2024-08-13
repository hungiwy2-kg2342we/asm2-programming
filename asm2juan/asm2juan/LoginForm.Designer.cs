namespace asm2juan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.TbxUserName = new System.Windows.Forms.TextBox();
            this.TbxPassword = new System.Windows.Forms.TextBox();
            this.lblExit = new System.Windows.Forms.Label();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(71, 101);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(155, 32);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "User Name";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(71, 186);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(138, 32);
            this.lblPassword.TabIndex = 0;
            this.lblPassword.Text = "Password";
            // 
            // TbxUserName
            // 
            this.TbxUserName.Location = new System.Drawing.Point(318, 101);
            this.TbxUserName.Multiline = true;
            this.TbxUserName.Name = "TbxUserName";
            this.TbxUserName.Size = new System.Drawing.Size(344, 39);
            this.TbxUserName.TabIndex = 1;
            // 
            // TbxPassword
            // 
            this.TbxPassword.Location = new System.Drawing.Point(318, 186);
            this.TbxPassword.Multiline = true;
            this.TbxPassword.Name = "TbxPassword";
            this.TbxPassword.Size = new System.Drawing.Size(344, 41);
            this.TbxPassword.TabIndex = 1;
            this.TbxPassword.TextChanged += new System.EventHandler(this.TbxPassword_TextChanged);
            // 
            // lblExit
            // 
            this.lblExit.AutoSize = true;
            this.lblExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExit.Location = new System.Drawing.Point(404, 380);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(44, 25);
            this.lblExit.TabIndex = 0;
            this.lblExit.Text = "Exit";
            this.lblExit.Click += new System.EventHandler(this.label3_Click);
            // 
            // BtnLogin
            // 
            this.BtnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogin.Location = new System.Drawing.Point(381, 284);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(100, 61);
            this.BtnLogin.TabIndex = 2;
            this.BtnLogin.Text = "Login";
            this.BtnLogin.UseVisualStyleBackColor = true;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.TbxPassword);
            this.Controls.Add(this.TbxUserName);
            this.Controls.Add(this.lblExit);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUserName);
            this.Name = "LoginForm";
            this.Text = "Login ";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox TbxUserName;
        private System.Windows.Forms.TextBox TbxPassword;
        private System.Windows.Forms.Label lblExit;
        private System.Windows.Forms.Button BtnLogin;
    }
}

