namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }





        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn thoát không?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        // Nút Họ
        private void button1_Click(object sender, EventArgs e)
        {
            label3.Text = textBox1.Text;
        }

        // Nút Tên
        private void button2_Click(object sender, EventArgs e)
        {
            label3.Text = textBox2.Text;
        }

        // Nút Họ và tên
        private void button3_Click(object sender, EventArgs e)
        {
            label3.Text = textBox1.Text + " " + textBox2.Text;
        }

        // Nút Kết thúc
        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Click vào label - để Designer không báo lỗi
        private void label3_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;

        }

        // Double-click vào Họ tên thì xóa
        private void label3_DoubleClick(object sender, EventArgs e)
        {
            label3.Text = "";
        }
    }
}