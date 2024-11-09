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
    public partial class mainForm : Form
    {
        public bool isExit = true;

        public event EventHandler Logout;
        public mainForm()
        {
            InitializeComponent();
        }

        void Decentralization()
        {
            if (Const.accountType == false)
            {
                userToolStripMenuItem.Enabled = departmentToolStripMenuItem.Enabled = employeeToolStripMenuItem.Enabled = false;
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void SearchGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void mainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isExit)
            {
                Application.Exit();
            }
            
        }

        private void mainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isExit)
            {
                if (MessageBox.Show("Ban muon thoat chuong trinh", "Canh bao", MessageBoxButtons.YesNo) != DialogResult.Yes)
                    {
                        e.Cancel = true;
                    }
            }
            
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Logout(this,new EventArgs ());
        }

        private void toolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        //private void mainForm_Load(object sender, EventArgs e)
        //{
        //    addToolStripButton.Enabled=repairtoolStripButton.Enabled = erasetoolStripButton.Enabled = false;
        //    Decentralization();
        //}

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //addToolStripButton.Enabled = repairtoolStripButton.Enabled = erasetoolStripButton.Enabled = true;
        }

        private void maganeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Const.accountType == false)
            {
                MessageBox.Show("Ban khong co quyen", "Canh Bao");
                return;
            }
        }
    }
}
