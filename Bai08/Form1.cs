using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Bai08
{
    

    public partial class Form1 : Form
    {
        public class TaiKhoan
        {
            public int STT { get; set; }
            public string SoTK { get; set; }
            public string TenKH { get; set; }
            public string DiaChi { get; set; }
            public decimal SoTien { get; set; }
        }
        private List<TaiKhoan> listTaiKhoan = new List<TaiKhoan>();

        public Form1()
        {
            InitializeComponent();
            this.dgvTaiKhoan.RowHeadersVisible = false;
            this.btXoa.Click += new EventHandler(btXoa_Click);
            this.btThoat.Click += new EventHandler(btThoat_Click);
            this.dgvTaiKhoan.CellClick += new DataGridViewCellEventHandler(dgvTaiKhoan_CellClick);
            this.dgvTaiKhoan.RowPostPaint += new DataGridViewRowPostPaintEventHandler(dgvTaiKhoan_RowPostPaint);
        }
        private void dgvTaiKhoan_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            string stt = (e.RowIndex + 1).ToString();
            if (e.RowIndex < dgvTaiKhoan.Rows.Count)
            {
                dgvTaiKhoan.Rows[e.RowIndex].Cells["Column1"].Value = stt;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            dgvTaiKhoan.AutoGenerateColumns = false; 
            dgvTaiKhoan.Columns["Column2"].DataPropertyName = "SoTK";
            dgvTaiKhoan.Columns["Column3"].DataPropertyName = "TenKH";
            dgvTaiKhoan.Columns["Column4"].DataPropertyName = "DiaChi";
            dgvTaiKhoan.Columns["Column5"].DataPropertyName = "SoTien";
            CapNhatDataGridView();
        }

        private void CapNhatDataGridView()
        {
            for (int i = 0; i < listTaiKhoan.Count; i++)
            {
                listTaiKhoan[i].STT = i + 1;
            }

            dgvTaiKhoan.DataSource = null;
            dgvTaiKhoan.DataSource = listTaiKhoan;
        }

        private bool IsDigitsOnly(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }
            return true;
        }

        private bool IsLettersOnly(string str)
        {
            return Regex.IsMatch(str, @"^[\p{L}\s]+$");
        }

        private void btThemCapNhat_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSoTK.Text) ||
                string.IsNullOrWhiteSpace(txtTen.Text) ||
                string.IsNullOrWhiteSpace(txtDiaChi.Text) ||
                string.IsNullOrWhiteSpace(txtSoTien.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!IsDigitsOnly(txtSoTK.Text.Trim()))
            {
                MessageBox.Show("Số tài khoản chỉ được chứa ký tự số!", "Lỗi Dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!IsLettersOnly(txtTen.Text.Trim()))
            {
                MessageBox.Show("Tên khách hàng chỉ được chứa ký tự chữ cái và khoảng trắng!", "Lỗi Dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!decimal.TryParse(txtSoTien.Text, out decimal soTienMoi) || soTienMoi < 0)
            {
                MessageBox.Show("Số tiền không hợp lệ. Vui lòng nhập số dương.", "Lỗi Dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string soTKCanTim = txtSoTK.Text.Trim();
            var taiKhoanHienTai = listTaiKhoan.FirstOrDefault(tk => tk.SoTK == soTKCanTim);

            if (taiKhoanHienTai == null)
            {
                var taiKhoanMoi = new TaiKhoan
                {
                    SoTK = soTKCanTim,
                    TenKH = txtTen.Text.Trim(),
                    DiaChi = txtDiaChi.Text.Trim(),
                    SoTien = soTienMoi
                };
                listTaiKhoan.Add(taiKhoanMoi);
                MessageBox.Show("Thêm mới dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                taiKhoanHienTai.TenKH = txtTen.Text.Trim();
                taiKhoanHienTai.DiaChi = txtDiaChi.Text.Trim();
                taiKhoanHienTai.SoTien = soTienMoi;
                MessageBox.Show("Cập nhật dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            CapNhatDataGridView();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (dgvTaiKhoan.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn dòng cần xóa.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string soTKCanXoa = dgvTaiKhoan.SelectedRows[0].Cells["Column2"].Value.ToString();
            var taiKhoanCanXoa = listTaiKhoan.FirstOrDefault(tk => tk.SoTK == soTKCanXoa);

            if (taiKhoanCanXoa != null)
            {
                DialogResult dialogResult = MessageBox.Show($"Bạn có chắc chắn muốn xóa tài khoản {soTKCanXoa}?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dialogResult == DialogResult.Yes)
                {
                    listTaiKhoan.Remove(taiKhoanCanXoa);
                    CapNhatDataGridView();

                    ClearInputFields();

                    MessageBox.Show("Xóa tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy số tài khoản cần xóa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvTaiKhoan.Rows[e.RowIndex];

                if (row.Cells["Column2"].Value != null)
                {
                    txtSoTK.Text = row.Cells["Column2"].Value.ToString();
                    txtTen.Text = row.Cells["Column3"].Value.ToString();
                    txtDiaChi.Text = row.Cells["Column4"].Value.ToString();
                    txtSoTien.Text = row.Cells["Column5"].Value.ToString();
                }
            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ClearInputFields()
        {
            txtSoTK.Text = string.Empty;
            txtTen.Text = string.Empty;
            txtDiaChi.Text = string.Empty;
            txtSoTien.Text = string.Empty;
        }
    }
}