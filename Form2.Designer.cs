namespace QuanLiNhanSu_YT
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.toolPanel = new System.Windows.Forms.Panel();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.addToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.repairtoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.erasetoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.canceltoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.updatetoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.printtoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.mSHeThong = new System.Windows.Forms.MenuStrip();
            this.systemTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.userTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.maganeTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.departmentTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.trợGiúpTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.informationPanel = new System.Windows.Forms.Panel();
            this.searchgroupBox = new System.Windows.Forms.GroupBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.birthdaydateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.sexcomboBox = new System.Windows.Forms.ComboBox();
            this.IDtextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.sexLabel = new System.Windows.Forms.Label();
            this.nametextBox = new System.Windows.Forms.TextBox();
            this.birthdayLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.listPanel = new System.Windows.Forms.Panel();
            this.listEmployeeLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolPanel.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.mSHeThong.SuspendLayout();
            this.informationPanel.SuspendLayout();
            this.searchgroupBox.SuspendLayout();
            this.listPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolPanel
            // 
            this.toolPanel.Controls.Add(this.toolStrip);
            this.toolPanel.Controls.Add(this.mSHeThong);
            this.toolPanel.Location = new System.Drawing.Point(-10, 0);
            this.toolPanel.Name = "toolPanel";
            this.toolPanel.Size = new System.Drawing.Size(917, 56);
            this.toolPanel.TabIndex = 0;
            // 
            // toolStrip
            // 
            this.toolStrip.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripButton,
            this.repairtoolStripButton,
            this.erasetoolStripButton,
            this.canceltoolStripButton,
            this.updatetoolStripButton,
            this.printtoolStripButton});
            this.toolStrip.Location = new System.Drawing.Point(0, 25);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(917, 27);
            this.toolStrip.TabIndex = 2;
            this.toolStrip.Text = "toolStrip1";
            this.toolStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip_ItemClicked);
            // 
            // addToolStripButton
            // 
            this.addToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("addToolStripButton.Image")));
            this.addToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addToolStripButton.Name = "addToolStripButton";
            this.addToolStripButton.Size = new System.Drawing.Size(66, 24);
            this.addToolStripButton.Text = "Thêm";
            // 
            // repairtoolStripButton
            // 
            this.repairtoolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("repairtoolStripButton.Image")));
            this.repairtoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.repairtoolStripButton.Name = "repairtoolStripButton";
            this.repairtoolStripButton.Size = new System.Drawing.Size(55, 24);
            this.repairtoolStripButton.Text = "Sửa";
            // 
            // erasetoolStripButton
            // 
            this.erasetoolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("erasetoolStripButton.Image")));
            this.erasetoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.erasetoolStripButton.Name = "erasetoolStripButton";
            this.erasetoolStripButton.Size = new System.Drawing.Size(56, 24);
            this.erasetoolStripButton.Text = "Xóa";
            // 
            // canceltoolStripButton
            // 
            this.canceltoolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("canceltoolStripButton.Image")));
            this.canceltoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.canceltoolStripButton.Name = "canceltoolStripButton";
            this.canceltoolStripButton.Size = new System.Drawing.Size(57, 24);
            this.canceltoolStripButton.Text = "Hủy";
            // 
            // updatetoolStripButton
            // 
            this.updatetoolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("updatetoolStripButton.Image")));
            this.updatetoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.updatetoolStripButton.Name = "updatetoolStripButton";
            this.updatetoolStripButton.Size = new System.Drawing.Size(85, 24);
            this.updatetoolStripButton.Text = "Cập nhật";
            // 
            // printtoolStripButton
            // 
            this.printtoolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("printtoolStripButton.Image")));
            this.printtoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printtoolStripButton.Name = "printtoolStripButton";
            this.printtoolStripButton.Size = new System.Drawing.Size(44, 24);
            this.printtoolStripButton.Text = "In";
            // 
            // mSHeThong
            // 
            this.mSHeThong.AutoSize = false;
            this.mSHeThong.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.mSHeThong.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mSHeThong.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.systemTSMI,
            this.maganeTSMI,
            this.thốngKêTSMI,
            this.trợGiúpTSMI});
            this.mSHeThong.Location = new System.Drawing.Point(0, 0);
            this.mSHeThong.Name = "mSHeThong";
            this.mSHeThong.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.mSHeThong.Size = new System.Drawing.Size(917, 25);
            this.mSHeThong.TabIndex = 0;
            this.mSHeThong.Text = "Hệ Thống";
            // 
            // systemTSMI
            // 
            this.systemTSMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userTSMI,
            this.logoutTSMI});
            this.systemTSMI.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.systemTSMI.Name = "systemTSMI";
            this.systemTSMI.Size = new System.Drawing.Size(81, 21);
            this.systemTSMI.Text = "Hệ Thống";
            // 
            // userTSMI
            // 
            this.userTSMI.Name = "userTSMI";
            this.userTSMI.Size = new System.Drawing.Size(224, 26);
            this.userTSMI.Text = "Quản lí tài khoản";
            // 
            // logoutTSMI
            // 
            this.logoutTSMI.Name = "logoutTSMI";
            this.logoutTSMI.Size = new System.Drawing.Size(224, 26);
            this.logoutTSMI.Text = "Đăng xuất";
            this.logoutTSMI.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // maganeTSMI
            // 
            this.maganeTSMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.employeeTSMI,
            this.departmentTSMI});
            this.maganeTSMI.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maganeTSMI.Name = "maganeTSMI";
            this.maganeTSMI.Size = new System.Drawing.Size(64, 21);
            this.maganeTSMI.Text = "Quản lí";
            this.maganeTSMI.Click += new System.EventHandler(this.maganeToolStripMenuItem_Click);
            // 
            // employeeTSMI
            // 
            this.employeeTSMI.Name = "employeeTSMI";
            this.employeeTSMI.Size = new System.Drawing.Size(224, 26);
            this.employeeTSMI.Text = "Nhân viên";
            this.employeeTSMI.Click += new System.EventHandler(this.employeeToolStripMenuItem_Click);
            // 
            // departmentTSMI
            // 
            this.departmentTSMI.Name = "departmentTSMI";
            this.departmentTSMI.Size = new System.Drawing.Size(224, 26);
            this.departmentTSMI.Text = "Phòng ban";
            // 
            // thốngKêTSMI
            // 
            this.thốngKêTSMI.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thốngKêTSMI.Name = "thốngKêTSMI";
            this.thốngKêTSMI.Size = new System.Drawing.Size(77, 21);
            this.thốngKêTSMI.Text = "Thống kê";
            // 
            // trợGiúpTSMI
            // 
            this.trợGiúpTSMI.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trợGiúpTSMI.Name = "trợGiúpTSMI";
            this.trợGiúpTSMI.Size = new System.Drawing.Size(71, 21);
            this.trợGiúpTSMI.Text = "Trợ giúp";
            // 
            // informationPanel
            // 
            this.informationPanel.Controls.Add(this.searchgroupBox);
            this.informationPanel.Location = new System.Drawing.Point(0, 55);
            this.informationPanel.Name = "informationPanel";
            this.informationPanel.Size = new System.Drawing.Size(908, 124);
            this.informationPanel.TabIndex = 1;
            // 
            // searchgroupBox
            // 
            this.searchgroupBox.Controls.Add(this.searchButton);
            this.searchgroupBox.Controls.Add(this.birthdaydateTimePicker);
            this.searchgroupBox.Controls.Add(this.sexcomboBox);
            this.searchgroupBox.Controls.Add(this.IDtextBox);
            this.searchgroupBox.Controls.Add(this.label2);
            this.searchgroupBox.Controls.Add(this.sexLabel);
            this.searchgroupBox.Controls.Add(this.nametextBox);
            this.searchgroupBox.Controls.Add(this.birthdayLabel);
            this.searchgroupBox.Controls.Add(this.nameLabel);
            this.searchgroupBox.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchgroupBox.Location = new System.Drawing.Point(0, 7);
            this.searchgroupBox.Name = "searchgroupBox";
            this.searchgroupBox.Size = new System.Drawing.Size(908, 112);
            this.searchgroupBox.TabIndex = 0;
            this.searchgroupBox.TabStop = false;
            this.searchgroupBox.Text = "Tìm kiếm";
            // 
            // searchButton
            // 
            this.searchButton.AutoSize = true;
            this.searchButton.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(792, 67);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(95, 30);
            this.searchButton.TabIndex = 10;
            this.searchButton.Text = "Tìm";
            this.searchButton.UseVisualStyleBackColor = true;
            // 
            // birthdaydateTimePicker
            // 
            this.birthdaydateTimePicker.CalendarFont = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthdaydateTimePicker.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthdaydateTimePicker.Location = new System.Drawing.Point(149, 65);
            this.birthdaydateTimePicker.Name = "birthdaydateTimePicker";
            this.birthdaydateTimePicker.Size = new System.Drawing.Size(221, 25);
            this.birthdaydateTimePicker.TabIndex = 9;
            this.birthdaydateTimePicker.ValueChanged += new System.EventHandler(this.bỉthdaydateTimePicker_ValueChanged);
            // 
            // sexcomboBox
            // 
            this.sexcomboBox.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sexcomboBox.FormattingEnabled = true;
            this.sexcomboBox.Items.AddRange(new object[] {
            "Nam",
            "Nữ",
            "Tùy chọn"});
            this.sexcomboBox.Location = new System.Drawing.Point(584, 17);
            this.sexcomboBox.Name = "sexcomboBox";
            this.sexcomboBox.Size = new System.Drawing.Size(121, 25);
            this.sexcomboBox.TabIndex = 8;
            // 
            // IDtextBox
            // 
            this.IDtextBox.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDtextBox.Location = new System.Drawing.Point(584, 66);
            this.IDtextBox.Name = "IDtextBox";
            this.IDtextBox.Size = new System.Drawing.Size(191, 25);
            this.IDtextBox.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(436, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mã só nhân viên";
            // 
            // sexLabel
            // 
            this.sexLabel.AutoSize = true;
            this.sexLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sexLabel.Location = new System.Drawing.Point(436, 22);
            this.sexLabel.Name = "sexLabel";
            this.sexLabel.Size = new System.Drawing.Size(81, 22);
            this.sexLabel.TabIndex = 4;
            this.sexLabel.Text = "Giới tính";
            // 
            // nametextBox
            // 
            this.nametextBox.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nametextBox.Location = new System.Drawing.Point(149, 18);
            this.nametextBox.Name = "nametextBox";
            this.nametextBox.Size = new System.Drawing.Size(221, 25);
            this.nametextBox.TabIndex = 2;
            // 
            // birthdayLabel
            // 
            this.birthdayLabel.AutoSize = true;
            this.birthdayLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthdayLabel.Location = new System.Drawing.Point(7, 66);
            this.birthdayLabel.Name = "birthdayLabel";
            this.birthdayLabel.Size = new System.Drawing.Size(88, 22);
            this.birthdayLabel.TabIndex = 1;
            this.birthdayLabel.Text = "Ngày sinh";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(7, 22);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(93, 22);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Họ và Tên";
            // 
            // listPanel
            // 
            this.listPanel.Controls.Add(this.listEmployeeLabel);
            this.listPanel.Controls.Add(this.dataGridView1);
            this.listPanel.Location = new System.Drawing.Point(0, 180);
            this.listPanel.Name = "listPanel";
            this.listPanel.Size = new System.Drawing.Size(914, 323);
            this.listPanel.TabIndex = 2;
            // 
            // listEmployeeLabel
            // 
            this.listEmployeeLabel.AutoSize = true;
            this.listEmployeeLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listEmployeeLabel.Location = new System.Drawing.Point(362, 25);
            this.listEmployeeLabel.Name = "listEmployeeLabel";
            this.listEmployeeLabel.Size = new System.Drawing.Size(190, 23);
            this.listEmployeeLabel.TabIndex = 1;
            this.listEmployeeLabel.Text = "Danh Sách Nhân Viên";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.Location = new System.Drawing.Point(5, 65);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(903, 255);
            this.dataGridView1.TabIndex = 0;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 500);
            this.Controls.Add(this.listPanel);
            this.Controls.Add(this.informationPanel);
            this.Controls.Add(this.toolPanel);
            this.Name = "mainForm";
            this.Text = "mainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mainForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.mainForm_FormClosed);
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.toolPanel.ResumeLayout(false);
            this.toolPanel.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.mSHeThong.ResumeLayout(false);
            this.mSHeThong.PerformLayout();
            this.informationPanel.ResumeLayout(false);
            this.searchgroupBox.ResumeLayout(false);
            this.searchgroupBox.PerformLayout();
            this.listPanel.ResumeLayout(false);
            this.listPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel toolPanel;
        private System.Windows.Forms.MenuStrip mSHeThong;
        private System.Windows.Forms.ToolStripMenuItem systemTSMI;
        private System.Windows.Forms.ToolStripMenuItem maganeTSMI;
        private System.Windows.Forms.ToolStripMenuItem thốngKêTSMI;
        private System.Windows.Forms.ToolStripMenuItem trợGiúpTSMI;
        private System.Windows.Forms.ToolStripMenuItem userTSMI;
        private System.Windows.Forms.ToolStripMenuItem logoutTSMI;
        private System.Windows.Forms.ToolStripMenuItem employeeTSMI;
        private System.Windows.Forms.ToolStripMenuItem departmentTSMI;
        private System.Windows.Forms.Panel informationPanel;
        private System.Windows.Forms.GroupBox searchgroupBox;
        private System.Windows.Forms.TextBox IDtextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label sexLabel;
        private System.Windows.Forms.TextBox nametextBox;
        private System.Windows.Forms.Label birthdayLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.ComboBox sexcomboBox;
        private System.Windows.Forms.Panel listPanel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label listEmployeeLabel;
        private System.Windows.Forms.DateTimePicker birthdaydateTimePicker;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton repairtoolStripButton;
        private System.Windows.Forms.ToolStripButton erasetoolStripButton;
        private System.Windows.Forms.ToolStripButton canceltoolStripButton;
        private System.Windows.Forms.ToolStripButton updatetoolStripButton;
        private System.Windows.Forms.ToolStripButton printtoolStripButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.ToolStripButton addToolStripButton;
    }
}