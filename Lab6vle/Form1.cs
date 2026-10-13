namespace Lab6vle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnKhoiTao_Click(object sender, EventArgs e)
        {
            try
            {
                int soDong = int.Parse(txtSoDong.Text);
                int soCot = int.Parse(txtSoCot.Text);

                // Khởi tạo và truyền số dòng, số cột sang frmXuat
                frmXuat f = new frmXuat(soDong, soCot);
                f.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Vui lòng nhập số hợp lệ! Lỗi: " + ex.Message);
            }
        }
    }
}
