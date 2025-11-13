using System;
using System.Windows.Forms;

namespace Bai01
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            MessageBox.Show("Hàm khởi tạo (Constructor) đang chạy", 
                "Thông báo", MessageBoxButtons.OK);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Form đang được tải (Load)...", 
                "Thông báo", MessageBoxButtons.OK);
        }

        private void Form2_Activated(object sender, EventArgs e)
        {
            Status_lbl.Text = "Form đang được kích hoạt";
        }

        private void Form2_Shown(object sender, EventArgs e)
        {
            MessageBox.Show("Form đã được hiển thị (Shown)", "Thông báo", 
                MessageBoxButtons.OK);
        }

        private void Form2_Deactivate(object sender, EventArgs e)
        {
            Status_lbl.Text = "Form đã bị mất focus";
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có muốn hủy thao tác đóng không?",
                "Xác nhận đóng",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Form đã được đóng hoàn toàn!", 
                "Thông báo", MessageBoxButtons.OK);
        }
    }
}
