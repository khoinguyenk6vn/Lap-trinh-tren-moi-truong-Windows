namespace Lab05_01
{
    public partial class Form2 : Form
    {
        public Form2(string imageFile)
        {
            InitializeComponent();

            //cho picturebox hiển thị file ảnh
            pictureBox1.Image = Image.FromFile(imageFile);

            //hiển thị tên của file ảnh lên title bar
            Text = imageFile.Substring(imageFile.LastIndexOf('\\') + 1);
        }

        public Form2()
        {
            InitializeComponent();
        }
    }
}