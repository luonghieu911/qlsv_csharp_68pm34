using System;
using System.Linq;
using System.Windows.Forms;

namespace QLSV
{
    public partial class frm_sinhvien : Form
    {
        private DatabaseDataContext db = new DatabaseDataContext();

        private string _selectedMaSV = null;

        public frm_sinhvien()
        {
            InitializeComponent();
        }

        private void frm_sinhvien_Load(object sender, EventArgs e)
        {
            LoadSinhVien();   // Hiển thị danh sách lên lưới
            ClearForm();      // Đặt lại form nhập liệu
        }
        private void LoadSinhVien()
        {
            try
            {
                var ds = db.tbl_sinhviens
                           .OrderBy(sv => sv.id)
                           .ToList();
                dgvSinhVien.DataSource = ds;
                FormatGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối CSDL:\n" + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadSinhVienTheoTu(string tuKhoa)
        {
            string tk = tuKhoa.Trim();
            var ds = db.tbl_sinhviens
                       .Where(sv =>
                           sv.id.Contains(tk) ||
                           sv.hoten.Contains(tk) ||
                           sv.malop.Contains(tk))
                       .OrderBy(sv => sv.id)
                       .ToList();
            dgvSinhVien.DataSource = ds;
            FormatGrid();
        }
        private void FormatGrid()
        {
            if (dgvSinhVien.Columns.Count == 0) return;

            if (dgvSinhVien.Columns["id"]       != null) { dgvSinhVien.Columns["id"].HeaderText       = "Mã SV";     dgvSinhVien.Columns["id"].Width       = 100; }
            if (dgvSinhVien.Columns["hoten"]    != null) { dgvSinhVien.Columns["hoten"].HeaderText    = "Họ và Tên"; dgvSinhVien.Columns["hoten"].Width    = 200; }
            if (dgvSinhVien.Columns["gioitinh"] != null) { dgvSinhVien.Columns["gioitinh"].HeaderText = "Giới Tính"; dgvSinhVien.Columns["gioitinh"].Width = 90;  }
            if (dgvSinhVien.Columns["malop"]    != null) { dgvSinhVien.Columns["malop"].HeaderText    = "Lớp";       dgvSinhVien.Columns["malop"].Width    = 90;  }
            if (dgvSinhVien.Columns["ngaysinh"] != null)
            {
                dgvSinhVien.Columns["ngaysinh"].HeaderText = "Ngày Sinh";
                dgvSinhVien.Columns["ngaysinh"].Width = 110;
                dgvSinhVien.Columns["ngaysinh"].DefaultCellStyle.Format = "dd/MM/yyyy";
            }
        }
        private tbl_sinhvien GetSinhVienFromForm()
        {
            if (string.IsNullOrWhiteSpace(txtMSSV.Text))
            {
                MessageBox.Show("Vui lòng nhập Mã sinh viên!", "Thiếu thông tin",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMSSV.Focus();
                return null;
            }
            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show("Vui lòng nhập Họ và tên!", "Thiếu thông tin",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHoTen.Focus();
                return null;
            }

            return new tbl_sinhvien
            {
                id       = txtMSSV.Text.Trim(),
                hoten    = txtHoTen.Text.Trim(),
                ngaysinh = dtpNgaySinh.Value.Date,
                gioitinh = cboGioiTinh.Text,
                malop    = txtMaLop.Text.Trim()
            };
        }

        private void ClearForm()
        {
            txtMSSV.Text     = "";
            txtHoTen.Text    = "";
            dtpNgaySinh.Value = DateTime.Today;
            cboGioiTinh.SelectedIndex = 0;
            txtMaLop.Text    = "";
            txtMSSV.Enabled  = true;   // Cho phép nhập mã khi thêm mới
            _selectedMaSV    = null;
            dgvSinhVien.ClearSelection();
            txtMSSV.Focus();
        }
        private void dgvSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // e.RowIndex = -1 khi click vào tiêu đề cột → bỏ qua
            if (e.RowIndex < 0) return;

            var row = dgvSinhVien.Rows[e.RowIndex];

            _selectedMaSV        = row.Cells["id"].Value?.ToString();
            txtMSSV.Text         = _selectedMaSV;
            txtHoTen.Text        = row.Cells["hoten"].Value?.ToString();
            cboGioiTinh.Text     = row.Cells["gioitinh"].Value?.ToString()?.Trim();
            txtMaLop.Text        = row.Cells["malop"].Value?.ToString()?.Trim();
            txtMSSV.Enabled      = false;  // Không cho sửa khóa chính

            if (row.Cells["ngaysinh"].Value is DateTime dt)
                dtpNgaySinh.Value = dt;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            tbl_sinhvien sv = GetSinhVienFromForm();
            if (sv == null) return;

            // Kiểm tra trùng mã sinh viên
            if (db.tbl_sinhviens.Any(x => x.id == sv.id))
            {
                MessageBox.Show("Mã sinh viên đã tồn tại!", "Trùng mã",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                db.tbl_sinhviens.InsertOnSubmit(sv); // Đăng ký thêm vào bộ đệm
                db.SubmitChanges();                   // Lưu thật sự vào CSDL

                MessageBox.Show("Thêm sinh viên thành công!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadSinhVien();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm:\n"  + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (_selectedMaSV == null)
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần sửa!", "Chưa chọn",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var sv = db.tbl_sinhviens.FirstOrDefault(x => x.id == _selectedMaSV);
            if (sv == null) { MessageBox.Show("Không tìm thấy sinh viên!"); return; }

            sv.hoten    = txtHoTen.Text.Trim();
            sv.ngaysinh = dtpNgaySinh.Value.Date;
            sv.gioitinh = cboGioiTinh.Text;
            sv.malop    = txtMaLop.Text.Trim();

            try
            {
                db.SubmitChanges();

                MessageBox.Show("Cập nhật thành công!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadSinhVien();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa:\n" + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (_selectedMaSV == null)
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần xóa!", "Chưa chọn",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Hỏi xác nhận trước khi xóa
            var result = MessageBox.Show(
                $"Bạn có chắc muốn xóa sinh viên '{txtHoTen.Text.Trim()}'?",
                "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes) return;

            var sv = db.tbl_sinhviens.FirstOrDefault(x => x.id == _selectedMaSV);
            if (sv == null) { MessageBox.Show("Không tìm thấy sinh viên!"); return; }

            try
            {
                db.tbl_sinhviens.DeleteOnSubmit(sv); // Đánh dấu xóa
                db.SubmitChanges();                   // Thực thi xóa

                MessageBox.Show("Xóa thành công!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadSinhVien();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa:\n" + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtTimKiem.Text = "";
            LoadSinhVien();
            ClearForm();
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTimKiem.Text))
                LoadSinhVien();
            else
                LoadSinhVienTheoTu(txtTimKiem.Text);
        }

        // Nhấn Enter trong ô tìm kiếm → tự động tìm
        private void txtTimKiem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnTimKiem_Click(sender, e);
        }
    }
}
