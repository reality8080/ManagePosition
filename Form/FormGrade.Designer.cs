namespace QuanLiNhanSu_YT
{
    partial class FormGrade
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
            this.txbID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txbGrade = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.dtgvGrade = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvGrade)).BeginInit();
            this.SuspendLayout();
            // 
            // txbID
            // 
            this.txbID.Location = new System.Drawing.Point(170, 198);
            this.txbID.Name = "txbID";
            this.txbID.Size = new System.Drawing.Size(203, 26);
            this.txbID.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mã số sinh viên";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(16, 347);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(95, 47);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txbGrade
            // 
            this.txbGrade.Location = new System.Drawing.Point(170, 266);
            this.txbGrade.Name = "txbGrade";
            this.txbGrade.Size = new System.Drawing.Size(203, 26);
            this.txbGrade.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Điểm số";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(126, 347);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(95, 47);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(243, 347);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(95, 47);
            this.btnEdit.TabIndex = 8;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // dtgvGrade
            // 
            this.dtgvGrade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvGrade.Location = new System.Drawing.Point(415, 70);
            this.dtgvGrade.Name = "dtgvGrade";
            this.dtgvGrade.RowHeadersWidth = 62;
            this.dtgvGrade.RowTemplate.Height = 28;
            this.dtgvGrade.Size = new System.Drawing.Size(713, 343);
            this.dtgvGrade.TabIndex = 9;
            this.dtgvGrade.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvGrade_CellClick);
            this.dtgvGrade.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvGrade_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Họ và tên giảng viên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Môn học";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(170, 58);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(203, 26);
            this.textBox1.TabIndex = 12;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(170, 124);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(203, 26);
            this.textBox2.TabIndex = 13;
            // 
            // FormGrade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 450);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgvGrade);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbGrade);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbID);
            this.Name = "FormGrade";
            this.Text = "FormGrade";
            this.Load += new System.EventHandler(this.FormGrade_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvGrade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txbID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txbGrade;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.DataGridView dtgvGrade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}