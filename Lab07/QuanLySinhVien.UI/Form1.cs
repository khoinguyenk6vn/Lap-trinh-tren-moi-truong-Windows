using System;
using System.Collections.Generic;
using System.Windows.Forms;
using QuanLySinhVien.DAL.Model;
namespace QuanLySinhVien.UI
{
    public partial class Form1 : Form
    {
        private readonly BLL.SinhVienBLL _sinhVienBLL = new BLL.SinhVienBLL();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Student> danhSach = _sinhVienBLL.LayDanhSach();
            // Gán danh sách sinh viên vào DataGridView hoặc control tương tự
            dataGridView1.DataSource = danhSach;
        }
    }
}
