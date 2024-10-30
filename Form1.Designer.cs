namespace QuanLiNhanSu_YT
{
    partial class Form1
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
            this.userLabel = new System.Windows.Forms.Label();
            this.txbUserName = new System.Windows.Forms.TextBox();
            this.LoginButton = new System.Windows.Forms.Button();
            this.ckbShowPassWord = new System.Windows.Forms.CheckBox();
            this.txbPassWord = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userLabel.Location = new System.Drawing.Point(51, 42);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(140, 31);
            this.userLabel.TabIndex = 0;
            this.userLabel.Text = "Tài Khoản";
            // 
            // txbUserName
            // 
            this.txbUserName.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbUserName.Location = new System.Drawing.Point(232, 42);
            this.txbUserName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbUserName.Name = "txbUserName";
            this.txbUserName.Size = new System.Drawing.Size(391, 38);
            this.txbUserName.TabIndex = 2;
            this.txbUserName.Text = "QuangDuyReal";
            // 
            // LoginButton
            // 
            this.LoginButton.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LoginButton.Location = new System.Drawing.Point(232, 239);
            this.LoginButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(180, 46);
            this.LoginButton.TabIndex = 3;
            this.LoginButton.Text = "Đăng nhập";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            this.LoginButton.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            // 
            // ckbShowPassWord
            // 
            this.ckbShowPassWord.AutoSize = true;
            this.ckbShowPassWord.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbShowPassWord.Location = new System.Drawing.Point(232, 189);
            this.ckbShowPassWord.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ckbShowPassWord.Name = "ckbShowPassWord";
            this.ckbShowPassWord.Size = new System.Drawing.Size(184, 27);
            this.ckbShowPassWord.TabIndex = 4;
            this.ckbShowPassWord.Text = "Hiển thị mật khẩu";
            this.ckbShowPassWord.UseVisualStyleBackColor = true;
            this.ckbShowPassWord.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // txbPassWord
            // 
            this.txbPassWord.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPassWord.Location = new System.Drawing.Point(232, 119);
            this.txbPassWord.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbPassWord.Name = "txbPassWord";
            this.txbPassWord.Size = new System.Drawing.Size(391, 38);
            this.txbPassWord.TabIndex = 6;
            this.txbPassWord.Text = "Duy161005.";
            this.txbPassWord.UseSystemPasswordChar = true;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(51, 126);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(134, 31);
            this.passwordLabel.TabIndex = 5;
            this.passwordLabel.Text = "Mật Khẩu";
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(464, 239);
            this.exitButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(159, 46);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "Thoát";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 351);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.txbPassWord);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.ckbShowPassWord);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.txbUserName);
            this.Controls.Add(this.userLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "LoginForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.TextBox txbUserName;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.CheckBox ckbShowPassWord;
        private System.Windows.Forms.TextBox txbPassWord;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Button exitButton;
    }
}

