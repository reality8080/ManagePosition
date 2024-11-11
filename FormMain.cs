using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiNhanSu_YT
{
    public partial class FormMain : Form
    {
        public bool isExit = true;
        public event EventHandler Logout;
        public FormMain()
        {
            InitializeComponent();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }
        #region Method
        void Decentralization()
        {
            if(Const.AccountType == false)
            {
                tsmiDepartment.Enabled = tsmiEmployee.Enabled = tsmiUser.Enabled = false;
            }
        }
        #endregion


        #region Event
        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isExit)
            {
                if (MessageBox.Show("Bạn muốn thoát chương trình?", "Cảnh báo", MessageBoxButtons.YesNo) != DialogResult.Yes)
                    e.Cancel = true;
            }
        }
        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(isExit)
                Application.Exit();

        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            btnAddNew.Enabled = btnDelete.Enabled = btnEdit.Enabled = false;
            Decentralization();
        }
        private void đăngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Logout(this, new EventArgs());
        }
        private void tsmiEmployee_Click(object sender, EventArgs e)
        {
            btnAddNew.Enabled = btnDelete.Enabled = btnEdit.Enabled = true;
        }
        private void quảnLíToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(!Const.AccountType)
                MessageBox.Show("Bạn không phải là admin", "Cảnh báo");
        }
        private void tsmiUser_Click(object sender, EventArgs e)
        {
            FormUser f = new FormUser();
            f.ShowDialog();
        }
        private void tsmiDepartment_Click(object sender, EventArgs e)
        {
            FormDepartment f = new FormDepartment();
            f.ShowDialog();
        }
        #endregion

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripSplitButton1_ButtonClick(object sender, EventArgs e)
        {

        }

        
    }
}
