using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Bai09
{
    public partial class Form1 : Form
    {
        public class SinhVien
        {
            public string MSSV { get; set; }
            public string HoTen { get; set; }
            public string ChuyenNganh { get; set; }
            public string GioiTinh { get; set; }
            public int SoMon { get; set; }
        }

        private List<SinhVien> danhSachSV = new List<SinhVien>();

        public Form1()
        {
            InitializeComponent();

            this.Load += new EventHandler(Form1_Load);
            this.checkBox1.CheckedChanged += new EventHandler(ChkNam_CheckedChanged);
            this.checkBox2.CheckedChanged += new EventHandler(ChkNu_CheckedChanged);

            this.button2.Click += new EventHandler(BtnChonMon_Click);
            this.button1.Click += new EventHandler(BtnBoChon_Click);
            //this.button4.Click += new EventHandler(BtnXoaChon_Click);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns[0].DataPropertyName = "MSSV";
            dataGridView1.Columns[1].DataPropertyName = "HoTen";
            dataGridView1.Columns[2].DataPropertyName = "ChuyenNganh";
            dataGridView1.Columns[3].DataPropertyName = "GioiTinh";
            dataGridView1.Columns[4].DataPropertyName = "SoMon";

            comboBox1.SelectedIndex = 0;

            listBox1.Items.Clear();
            listBox1.Items.AddRange(new object[] { "Cơ Sở Dữ Liệu", "Cơ Sở DL NC", "PTTK Hệ thống thông tin" });
            listBox2.Items.Clear();
        }

        private void ChkNam_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox2.Checked = false;
            }
        }

        private void ChkNu_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                checkBox1.Checked = false;
            }
        }

        private void BtnChonMon_Click(object sender, EventArgs e)
        {
            List<object> itemsToMove = listBox1.SelectedItems.Cast<object>().ToList();

            foreach (object item in itemsToMove)
            {
                listBox2.Items.Add(item);
                listBox1.Items.Remove(item);
            }
        }

        private void BtnBoChon_Click(object sender, EventArgs e)
        {
            List<object> itemsToMove = listBox2.SelectedItems.Cast<object>().ToList();

            foreach (object item in itemsToMove)
            {
                listBox1.Items.Add(item);
                listBox2.Items.Remove(item);
            }
        }

        private bool IsDigitsOnly(string str)
        {
            return Regex.IsMatch(str, @"^\d+$");
        }

        private bool IsLettersOnly(string str)
        {
            return Regex.IsMatch(str, @"^[\p{L}\s]+$");
        }

        private void BtnLuuThongTin_Click(object sender, EventArgs e)
        {
            string mssvText = maskedTextBox1.Text.Trim().Replace(" ", "");
            string hoTenText = maskedTextBox3.Text.Trim();

            if (string.IsNullOrWhiteSpace(mssvText) || string.IsNullOrWhiteSpace(hoTenText) || (!checkBox1.Checked && !checkBox2.Checked) || listBox2.Items.Count == 0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Mã SV, Họ Tên, Giới Tính và chọn ít nhất một Môn học!", "Lỗi Dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!IsDigitsOnly(mssvText))
            {
                MessageBox.Show("Mã Sinh Viên chỉ được chứa ký tự số!", "Lỗi Dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!IsLettersOnly(hoTenText))
            {
                MessageBox.Show("Họ Tên chỉ được chứa ký tự chữ cái và khoảng trắng!", "Lỗi Dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string gioiTinh = checkBox1.Checked ? "Nam" : "Nữ";

            SinhVien sv = new SinhVien
            {
                MSSV = mssvText,
                HoTen = hoTenText,
                ChuyenNganh = comboBox1.Text,
                GioiTinh = gioiTinh,
                SoMon = listBox2.Items.Count
            };

            danhSachSV.Add(sv);
            MessageBox.Show("Lưu thông tin thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

            CapNhatDataGridView();

            //BtnXoaChon_Click(null, null);
        }

        private void BtnXoaChon_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count > 0)
            {
                string mssvCanXoa = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                var svCanXoa = danhSachSV.FirstOrDefault(sv => sv.MSSV == mssvCanXoa);
                if (svCanXoa != null)
                {
                    DialogResult dialogResult = MessageBox.Show(
                        $"Bạn có chắc muốn xóa sinh viên {svCanXoa.HoTen} ({svCanXoa.MSSV})?",
                        "Xác nhận xóa",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning
                    );
                    if (dialogResult == DialogResult.Yes)
                    {
                        danhSachSV.Remove(svCanXoa);
                        CapNhatDataGridView();
                        MessageBox.Show("Xóa sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void CapNhatDataGridView()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = danhSachSV;
            dataGridView1.Refresh();
        }
    }
}