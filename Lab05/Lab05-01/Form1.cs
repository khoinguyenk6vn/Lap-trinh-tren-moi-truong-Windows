namespace Lab05_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //sử dụng dialog chuẩn để open file
            OpenFileDialog oFile = new OpenFileDialog();

            //chỉ open những file *.bmp, *.jpeg
            oFile.Filter = "Bitmap file|*.bmp|JPEG file|*.jpg";

            if (oFile.ShowDialog() == DialogResult.OK) //hiển thị dialog
            {
                //tạo thể hiện form con và truyền tên file cần mở
                Form2 frm = new Form2(oFile.FileName);

                frm.MdiParent = this; //khai báo form cha
                frm.Show(); //hiển thị ra màn hình
            }
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void tileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void tileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }
        }
                      
    }