using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lab6vle
{
    // Cho phép frmXuat kế thừa trực tiếp từ lớp Form của C#
    public class frmXuat : Form
    {
        // Khai báo biến lưu số dòng, số cột
        public int SoDong;
        public int SoCot;

        // Kích thước button và khoảng cách lề
        int h = 35, margin = 5;

        // Constructor nhận 2 tham số dòng và cột
        public frmXuat(int dong, int cot)
        {
            this.SoDong = dong;
            this.SoCot = cot;

            // Thiết lập giao diện form cơ bản
            this.Text = "Form Xuất Mảng";
            this.StartPosition = FormStartPosition.CenterScreen;

            // Vòng lặp tạo các Button động giống hệt tài liệu Lab
            for (int i = 0; i < SoDong; i++)
            {
                for (int j = 0; j < SoCot; j++)
                {
                    Button btn = new Button();
                    btn.Width = h;
                    btn.Height = h;
                    btn.Text = (i * SoCot + j + 1).ToString();
                    btn.Left = margin * (j + 1) + h * j;
                    btn.Top = margin * (i + 1) + h * i;

                    // Gắn sự kiện
                    btn.Click += btn_Click;
                    btn.MouseHover += HoChuotLenButton;
                    btn.Tag = string.Format("Dòng {0} cột {1}", i, j);

                    this.Controls.Add(btn);
                }
            }

            // Tự động điều chỉnh kích thước form vừa khít với lưới button
            this.ClientSize = new Size(SoCot * (h + margin) + margin, SoDong * (h + margin) + margin);
        }

        private void HoChuotLenButton(object sender, EventArgs e)
        {
            if (sender is Button btn && btn.Tag != null)
            {
                this.Text = btn.Tag.ToString();
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            // Xử lý khi click vào button (nếu cần)
        }
    }
}