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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.systemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maganeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.departmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trợGiúpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informationPanel = new System.Windows.Forms.Panel();
            this.searchgroupBox = new System.Windows.Forms.GroupBox();
            this.bỉthdaydateTimePicker = new System.Windows.Forms.DateTimePicker();
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsBAdd = new System.Windows.Forms.ToolStripButton();
            this.tsbErase = new System.Windows.Forms.ToolStripButton();
            this.tsbRepair = new System.Windows.Forms.ToolStripButton();
            this.tsbUpdate = new System.Windows.Forms.ToolStripButton();
            this.tsbPrint = new System.Windows.Forms.ToolStripButton();
            this.toolPanel.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.informationPanel.SuspendLayout();
            this.searchgroupBox.SuspendLayout();
            this.listPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolPanel
            // 
            this.toolPanel.Controls.Add(this.toolStrip1);
            this.toolPanel.Controls.Add(this.menuStrip1);
            this.toolPanel.Location = new System.Drawing.Point(-9, 0);
            this.toolPanel.Name = "toolPanel";
            this.toolPanel.Size = new System.Drawing.Size(917, 56);
            this.toolPanel.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.systemToolStripMenuItem,
            this.maganeToolStripMenuItem,
            this.thốngKêToolStripMenuItem,
            this.trợGiúpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(917, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // systemToolStripMenuItem
            // 
            this.systemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.systemToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.systemToolStripMenuItem.Name = "systemToolStripMenuItem";
            this.systemToolStripMenuItem.Size = new System.Drawing.Size(81, 21);
            this.systemToolStripMenuItem.Text = "Hệ Thống";
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this.userToolStripMenuItem.Text = "Quản lí tài khoản";
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // maganeToolStripMenuItem
            // 
            this.maganeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.employeeToolStripMenuItem,
            this.departmentToolStripMenuItem});
            this.maganeToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maganeToolStripMenuItem.Name = "maganeToolStripMenuItem";
            this.maganeToolStripMenuItem.Size = new System.Drawing.Size(64, 21);
            this.maganeToolStripMenuItem.Text = "Quản lí";
            this.maganeToolStripMenuItem.Click += new System.EventHandler(this.maganeToolStripMenuItem_Click);
            // 
            // employeeToolStripMenuItem
            // 
            this.employeeToolStripMenuItem.Name = "employeeToolStripMenuItem";
            this.employeeToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.employeeToolStripMenuItem.Text = "Nhân viên";
            this.employeeToolStripMenuItem.Click += new System.EventHandler(this.employeeToolStripMenuItem_Click);
            // 
            // departmentToolStripMenuItem
            // 
            this.departmentToolStripMenuItem.Name = "departmentToolStripMenuItem";
            this.departmentToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.departmentToolStripMenuItem.Text = "Phòng ban";
            // 
            // thốngKêToolStripMenuItem
            // 
            this.thốngKêToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thốngKêToolStripMenuItem.Name = "thốngKêToolStripMenuItem";
            this.thốngKêToolStripMenuItem.Size = new System.Drawing.Size(77, 21);
            this.thốngKêToolStripMenuItem.Text = "Thống kê";
            // 
            // trợGiúpToolStripMenuItem
            // 
            this.trợGiúpToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trợGiúpToolStripMenuItem.Name = "trợGiúpToolStripMenuItem";
            this.trợGiúpToolStripMenuItem.Size = new System.Drawing.Size(71, 21);
            this.trợGiúpToolStripMenuItem.Text = "Trợ giúp";
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
            this.searchgroupBox.Controls.Add(this.bỉthdaydateTimePicker);
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
            // bỉthdaydateTimePicker
            // 
            this.bỉthdaydateTimePicker.CalendarFont = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bỉthdaydateTimePicker.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bỉthdaydateTimePicker.Location = new System.Drawing.Point(149, 65);
            this.bỉthdaydateTimePicker.Name = "bỉthdaydateTimePicker";
            this.bỉthdaydateTimePicker.Size = new System.Drawing.Size(221, 25);
            this.bỉthdaydateTimePicker.TabIndex = 9;
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
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBAdd,
            this.tsbErase,
            this.tsbRepair,
            this.tsbUpdate,
            this.tsbPrint});
            this.toolStrip1.Location = new System.Drawing.Point(0, 25);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(917, 27);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsBAdd
            // 
            this.tsBAdd.Image = ((System.Drawing.Image)(resources.GetObject("tsBAdd.Image")));
            this.tsBAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBAdd.Name = "tsBAdd";
            this.tsBAdd.Size = new System.Drawing.Size(70, 24);
            this.tsBAdd.Text = "Thêm";
            // 
            // tsbErase
            // 
            this.tsbErase.Image = ((System.Drawing.Image)(resources.GetObject("tsbErase.Image")));
            this.tsbErase.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbErase.Name = "tsbErase";
            this.tsbErase.Size = new System.Drawing.Size(59, 24);
            this.tsbErase.Text = "Xóa";
            // 
            // tsbRepair
            // 
            this.tsbRepair.Image = ((System.Drawing.Image)(resources.GetObject("tsbRepair.Image")));
            this.tsbRepair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRepair.Name = "tsbRepair";
            this.tsbRepair.Size = new System.Drawing.Size(58, 24);
            this.tsbRepair.Text = "Sửa";
            // 
            // tsbUpdate
            // 
            this.tsbUpdate.Image = ((System.Drawing.Image)(resources.GetObject("tsbUpdate.Image")));
            this.tsbUpdate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbUpdate.Name = "tsbUpdate";
            this.tsbUpdate.Size = new System.Drawing.Size(92, 24);
            this.tsbUpdate.Text = "Cập nhật";
            // 
            // tsbPrint
            // 
            this.tsbPrint.Image = ((System.Drawing.Image)(resources.GetObject("tsbPrint.Image")));
            this.tsbPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPrint.Name = "tsbPrint";
            this.tsbPrint.Size = new System.Drawing.Size(45, 24);
            this.tsbPrint.Text = "In";
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
            this.toolPanel.ResumeLayout(false);
            this.toolPanel.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.informationPanel.ResumeLayout(false);
            this.searchgroupBox.ResumeLayout(false);
            this.searchgroupBox.PerformLayout();
            this.listPanel.ResumeLayout(false);
            this.listPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel toolPanel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem systemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maganeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thốngKêToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trợGiúpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem employeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem departmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhânViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phòngBanToolStripMenuItem;
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
        private System.Windows.Forms.DateTimePicker bỉthdaydateTimePicker;
        private System.Windows.Forms.ToolStripButton addtoolStripButton;
        private System.Windows.Forms.ToolStripButton repairtoolStripButton;
        private System.Windows.Forms.ToolStripButton erasetoolStripButton;
        private System.Windows.Forms.ToolStripButton canceltoolStripButton;
        private System.Windows.Forms.ToolStripButton updatetoolStripButton;
        private System.Windows.Forms.ToolStripButton printtoolStripButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsBAdd;
        private System.Windows.Forms.ToolStripButton tsbErase;
        private System.Windows.Forms.ToolStripButton tsbRepair;
        private System.Windows.Forms.ToolStripButton tsbUpdate;
        private System.Windows.Forms.ToolStripButton tsbPrint;
    }
}