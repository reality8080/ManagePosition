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
            this.txbSubject = new System.Windows.Forms.TextBox();
            this.txbMssv = new System.Windows.Forms.TextBox();
            this.SubjectLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txbScore = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.dtgvGrade = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvGrade)).BeginInit();
            this.SuspendLayout();
            // 
            // txbSubject
            // 
            this.txbSubject.Location = new System.Drawing.Point(120, 59);
            this.txbSubject.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbSubject.Name = "txbSubject";
            this.txbSubject.Size = new System.Drawing.Size(181, 22);
            this.txbSubject.TabIndex = 0;
            // 
            // txbMssv
            // 
            this.txbMssv.Location = new System.Drawing.Point(120, 135);
            this.txbMssv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbMssv.Name = "txbMssv";
            this.txbMssv.Size = new System.Drawing.Size(181, 22);
            this.txbMssv.TabIndex = 1;
            // 
            // SubjectLabel
            // 
            this.SubjectLabel.AutoSize = true;
            this.SubjectLabel.Location = new System.Drawing.Point(11, 64);
            this.SubjectLabel.Name = "SubjectLabel";
            this.SubjectLabel.Size = new System.Drawing.Size(58, 16);
            this.SubjectLabel.TabIndex = 2;
            this.SubjectLabel.Text = "Môn học";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mã số sinh viên";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(14, 278);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(84, 38);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txbScore
            // 
            this.txbScore.Location = new System.Drawing.Point(120, 213);
            this.txbScore.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbScore.Name = "txbScore";
            this.txbScore.Size = new System.Drawing.Size(181, 22);
            this.txbScore.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Điểm số";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(112, 278);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(84, 38);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(216, 278);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(84, 38);
            this.btnEdit.TabIndex = 8;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // dtgvGrade
            // 
            this.dtgvGrade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvGrade.Location = new System.Drawing.Point(322, 56);
            this.dtgvGrade.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgvGrade.Name = "dtgvGrade";
            this.dtgvGrade.RowHeadersWidth = 62;
            this.dtgvGrade.RowTemplate.Height = 28;
            this.dtgvGrade.Size = new System.Drawing.Size(681, 290);
            this.dtgvGrade.TabIndex = 9;
            this.dtgvGrade.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvGrade_CellClick);
            this.dtgvGrade.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvGrade_CellContentClick);
            // 
            // FormGrade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 360);
            this.Controls.Add(this.dtgvGrade);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbScore);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SubjectLabel);
            this.Controls.Add(this.txbMssv);
            this.Controls.Add(this.txbSubject);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormGrade";
            this.Text = "FormGrade";
            this.Load += new System.EventHandler(this.FormGrade_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvGrade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbSubject;
        private System.Windows.Forms.TextBox txbMssv;
        private System.Windows.Forms.Label SubjectLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txbScore;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.DataGridView dtgvGrade;
    }
}