namespace QuanLiNhanSu_YT
{
    partial class Form5
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.userlabel = new System.Windows.Forms.Label();
            this.usertextBox = new System.Windows.Forms.TextBox();
            this.passwordtextBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.typeOfUserLabel = new System.Windows.Forms.Label();
            this.typeOfUserComboBox = new System.Windows.Forms.ComboBox();
            this.inputButton = new System.Windows.Forms.Button();
            this.repairButton = new System.Windows.Forms.Button();
            this.erasebutton = new System.Windows.Forms.Button();
            this.exitbutton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.exitbutton);
            this.panel1.Controls.Add(this.erasebutton);
            this.panel1.Controls.Add(this.repairButton);
            this.panel1.Controls.Add(this.inputButton);
            this.panel1.Controls.Add(this.typeOfUserComboBox);
            this.panel1.Controls.Add(this.typeOfUserLabel);
            this.panel1.Controls.Add(this.passwordtextBox);
            this.panel1.Controls.Add(this.passwordLabel);
            this.panel1.Controls.Add(this.usertextBox);
            this.panel1.Controls.Add(this.userlabel);
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(2, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(905, 449);
            this.panel1.TabIndex = 0;
            // 
            // userlabel
            // 
            this.userlabel.AutoSize = true;
            this.userlabel.Location = new System.Drawing.Point(11, 41);
            this.userlabel.Name = "userlabel";
            this.userlabel.Size = new System.Drawing.Size(99, 19);
            this.userlabel.TabIndex = 0;
            this.userlabel.Text = "Tên tài khoản";
            // 
            // usertextBox
            // 
            this.usertextBox.Location = new System.Drawing.Point(124, 37);
            this.usertextBox.Name = "usertextBox";
            this.usertextBox.Size = new System.Drawing.Size(187, 27);
            this.usertextBox.TabIndex = 1;
            // 
            // passwordtextBox
            // 
            this.passwordtextBox.Location = new System.Drawing.Point(124, 97);
            this.passwordtextBox.Name = "passwordtextBox";
            this.passwordtextBox.PasswordChar = '*';
            this.passwordtextBox.Size = new System.Drawing.Size(187, 27);
            this.passwordtextBox.TabIndex = 3;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(11, 101);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(71, 19);
            this.passwordLabel.TabIndex = 2;
            this.passwordLabel.Text = "Mật khẩu";
            // 
            // typeOfUserLabel
            // 
            this.typeOfUserLabel.AutoSize = true;
            this.typeOfUserLabel.Location = new System.Drawing.Point(11, 168);
            this.typeOfUserLabel.Name = "typeOfUserLabel";
            this.typeOfUserLabel.Size = new System.Drawing.Size(51, 19);
            this.typeOfUserLabel.TabIndex = 4;
            this.typeOfUserLabel.Text = "label3";
            // 
            // typeOfUserComboBox
            // 
            this.typeOfUserComboBox.FormattingEnabled = true;
            this.typeOfUserComboBox.Location = new System.Drawing.Point(124, 162);
            this.typeOfUserComboBox.Name = "typeOfUserComboBox";
            this.typeOfUserComboBox.Size = new System.Drawing.Size(208, 27);
            this.typeOfUserComboBox.TabIndex = 5;
            // 
            // inputButton
            // 
            this.inputButton.Location = new System.Drawing.Point(15, 244);
            this.inputButton.Name = "inputButton";
            this.inputButton.Size = new System.Drawing.Size(98, 36);
            this.inputButton.TabIndex = 6;
            this.inputButton.Text = "Nhập";
            this.inputButton.UseVisualStyleBackColor = true;
            // 
            // repairButton
            // 
            this.repairButton.Location = new System.Drawing.Point(150, 244);
            this.repairButton.Name = "repairButton";
            this.repairButton.Size = new System.Drawing.Size(98, 36);
            this.repairButton.TabIndex = 7;
            this.repairButton.Text = "Sửa";
            this.repairButton.UseVisualStyleBackColor = true;
            // 
            // erasebutton
            // 
            this.erasebutton.Location = new System.Drawing.Point(290, 244);
            this.erasebutton.Name = "erasebutton";
            this.erasebutton.Size = new System.Drawing.Size(98, 36);
            this.erasebutton.TabIndex = 8;
            this.erasebutton.Text = "Xóa";
            this.erasebutton.UseVisualStyleBackColor = true;
            // 
            // exitbutton
            // 
            this.exitbutton.Location = new System.Drawing.Point(15, 369);
            this.exitbutton.Name = "exitbutton";
            this.exitbutton.Size = new System.Drawing.Size(98, 36);
            this.exitbutton.TabIndex = 9;
            this.exitbutton.Text = "Thoát";
            this.exitbutton.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(394, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(511, 445);
            this.dataGridView1.TabIndex = 10;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Form5";
            this.Text = "Form5";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button inputButton;
        private System.Windows.Forms.ComboBox typeOfUserComboBox;
        private System.Windows.Forms.Label typeOfUserLabel;
        private System.Windows.Forms.TextBox passwordtextBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox usertextBox;
        private System.Windows.Forms.Label userlabel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button exitbutton;
        private System.Windows.Forms.Button erasebutton;
        private System.Windows.Forms.Button repairButton;
    }
}