using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class frmlistview : Form
    {
        public frmlistview()
        {
            InitializeComponent();
        }



        private void btnThem_Click(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem(txtLastName.Text);

            item.SubItems.Add(txtFirstName.Text);
            item.SubItems.Add(txtPhone.Text);
            lvDanhSach.Items.Add(item);

        }



        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lvDanhSach.SelectedItems.Count > 0)
            {
                lvDanhSach.Items.Remove(lvDanhSach.SelectedItems[0]);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng cần xóa!");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (lvDanhSach.SelectedItems.Count > 0)
            {
                ListViewItem item = lvDanhSach.SelectedItems[0];

                item.Text = txtLastName.Text;
                item.SubItems[1].Text = txtFirstName.Text;
                item.SubItems[2].Text = txtPhone.Text;

                MessageBox.Show("Sửa thành công!");
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng cần sửa!");
            }
        }
        private void lvDanhSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvDanhSach.SelectedItems.Count > 0)
            {
                ListViewItem item = lvDanhSach.SelectedItems[0];

                txtLastName.Text = item.Text;
                txtFirstName.Text = item.SubItems[1].Text;
                txtPhone.Text = item.SubItems[2].Text;
            }
        }
    }
}
