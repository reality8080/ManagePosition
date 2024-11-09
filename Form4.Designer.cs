namespace QuanLiNhanSu_YT
{
    partial class Form4
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.position_textBox = new System.Windows.Forms.TextBox();
            this.positionListBox = new System.Windows.Forms.ListBox();
            this.inputButton = new System.Windows.Forms.Button();
            this.repairButton = new System.Windows.Forms.Button();
            this.eraseButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.exitButton);
            this.panel1.Controls.Add(this.eraseButton);
            this.panel1.Controls.Add(this.repairButton);
            this.panel1.Controls.Add(this.inputButton);
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(-2, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(164, 416);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.positionListBox);
            this.panel2.Controls.Add(this.position_textBox);
            this.panel2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(168, -2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(329, 416);
            this.panel2.TabIndex = 1;
            // 
            // position_textBox
            // 
            this.position_textBox.Location = new System.Drawing.Point(21, 61);
            this.position_textBox.Name = "position_textBox";
            this.position_textBox.Size = new System.Drawing.Size(296, 28);
            this.position_textBox.TabIndex = 0;
            // 
            // positionListBox
            // 
            this.positionListBox.FormattingEnabled = true;
            this.positionListBox.ItemHeight = 20;
            this.positionListBox.Location = new System.Drawing.Point(21, 162);
            this.positionListBox.Name = "positionListBox";
            this.positionListBox.Size = new System.Drawing.Size(296, 244);
            this.positionListBox.TabIndex = 1;
            // 
            // inputButton
            // 
            this.inputButton.AutoSize = true;
            this.inputButton.Location = new System.Drawing.Point(38, 31);
            this.inputButton.Name = "inputButton";
            this.inputButton.Size = new System.Drawing.Size(78, 32);
            this.inputButton.TabIndex = 0;
            this.inputButton.Text = "Nhập";
            this.inputButton.UseVisualStyleBackColor = true;
            // 
            // repairButton
            // 
            this.repairButton.AutoSize = true;
            this.repairButton.Location = new System.Drawing.Point(38, 93);
            this.repairButton.Name = "repairButton";
            this.repairButton.Size = new System.Drawing.Size(78, 32);
            this.repairButton.TabIndex = 1;
            this.repairButton.Text = "Sửa";
            this.repairButton.UseVisualStyleBackColor = true;
            // 
            // eraseButton
            // 
            this.eraseButton.AutoSize = true;
            this.eraseButton.Location = new System.Drawing.Point(38, 162);
            this.eraseButton.Name = "eraseButton";
            this.eraseButton.Size = new System.Drawing.Size(78, 32);
            this.eraseButton.TabIndex = 2;
            this.eraseButton.Text = "Xóa";
            this.eraseButton.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            this.exitButton.AutoSize = true;
            this.exitButton.Location = new System.Drawing.Point(38, 334);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(78, 32);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Thoát";
            this.exitButton.UseVisualStyleBackColor = true;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 414);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button eraseButton;
        private System.Windows.Forms.Button repairButton;
        private System.Windows.Forms.Button inputButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox positionListBox;
        private System.Windows.Forms.TextBox position_textBox;
    }
}