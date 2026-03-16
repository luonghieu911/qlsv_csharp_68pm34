namespace QLSV
{
    partial class frm_sinhvien
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.grpThongTin  = new System.Windows.Forms.GroupBox();
            this.lblMSSV      = new System.Windows.Forms.Label();
            this.txtMSSV      = new System.Windows.Forms.TextBox();
            this.lblHoTen     = new System.Windows.Forms.Label();
            this.txtHoTen     = new System.Windows.Forms.TextBox();
            this.lblNgaySinh  = new System.Windows.Forms.Label();
            this.dtpNgaySinh  = new System.Windows.Forms.DateTimePicker();
            this.lblGioiTinh  = new System.Windows.Forms.Label();
            this.cboGioiTinh  = new System.Windows.Forms.ComboBox();
            this.lblLop       = new System.Windows.Forms.Label();
            this.txtMaLop     = new System.Windows.Forms.TextBox();
            this.btnThem      = new System.Windows.Forms.Button();
            this.btnSua       = new System.Windows.Forms.Button();
            this.btnXoa       = new System.Windows.Forms.Button();
            this.btnLamMoi    = new System.Windows.Forms.Button();
            this.lblSearch    = new System.Windows.Forms.Label();
            this.txtTimKiem   = new System.Windows.Forms.TextBox();
            this.btnTimKiem   = new System.Windows.Forms.Button();
            this.dgvSinhVien  = new System.Windows.Forms.DataGridView();
            this.grpThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).BeginInit();
            this.SuspendLayout();

            // ── grpThongTin ──────────────────────────────────────────────
            this.grpThongTin.Controls.Add(this.lblMSSV);
            this.grpThongTin.Controls.Add(this.txtMSSV);
            this.grpThongTin.Controls.Add(this.lblHoTen);
            this.grpThongTin.Controls.Add(this.txtHoTen);
            this.grpThongTin.Controls.Add(this.lblNgaySinh);
            this.grpThongTin.Controls.Add(this.dtpNgaySinh);
            this.grpThongTin.Controls.Add(this.lblGioiTinh);
            this.grpThongTin.Controls.Add(this.cboGioiTinh);
            this.grpThongTin.Controls.Add(this.lblLop);
            this.grpThongTin.Controls.Add(this.txtMaLop);
            this.grpThongTin.Font     = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.grpThongTin.Location = new System.Drawing.Point(15, 15);
            this.grpThongTin.Name     = "grpThongTin";
            this.grpThongTin.Size     = new System.Drawing.Size(450, 555);
            this.grpThongTin.TabIndex = 0;
            this.grpThongTin.TabStop  = false;
            this.grpThongTin.Text     = "Thông tin sinh viên";

            // ── lblMSSV ───────────────────────────────────────────────────
            this.lblMSSV.AutoSize = true;
            this.lblMSSV.Font     = new System.Drawing.Font("Segoe UI", 9F);
            this.lblMSSV.Location = new System.Drawing.Point(15, 38);
            this.lblMSSV.Name     = "lblMSSV";
            this.lblMSSV.Text     = "Mã sinh viên:";

            // ── txtMSSV ───────────────────────────────────────────────────
            this.txtMSSV.Font     = new System.Drawing.Font("Segoe UI", 10F);
            this.txtMSSV.Location = new System.Drawing.Point(15, 65);
            this.txtMSSV.Name     = "txtMSSV";
            this.txtMSSV.Size     = new System.Drawing.Size(415, 44);
            this.txtMSSV.TabIndex = 0;

            // ── lblHoTen ──────────────────────────────────────────────────
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Font     = new System.Drawing.Font("Segoe UI", 9F);
            this.lblHoTen.Location = new System.Drawing.Point(15, 125);
            this.lblHoTen.Name     = "lblHoTen";
            this.lblHoTen.Text     = "Họ và tên:";

            // ── txtHoTen ──────────────────────────────────────────────────
            this.txtHoTen.Font     = new System.Drawing.Font("Segoe UI", 10F);
            this.txtHoTen.Location = new System.Drawing.Point(15, 152);
            this.txtHoTen.Name     = "txtHoTen";
            this.txtHoTen.Size     = new System.Drawing.Size(415, 44);
            this.txtHoTen.TabIndex = 1;

            // ── lblNgaySinh ───────────────────────────────────────────────
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Font     = new System.Drawing.Font("Segoe UI", 9F);
            this.lblNgaySinh.Location = new System.Drawing.Point(15, 215);
            this.lblNgaySinh.Name     = "lblNgaySinh";
            this.lblNgaySinh.Text     = "Ngày sinh:";

            // ── dtpNgaySinh ───────────────────────────────────────────────
            this.dtpNgaySinh.Font     = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpNgaySinh.Format   = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinh.Location = new System.Drawing.Point(15, 242);
            this.dtpNgaySinh.Name     = "dtpNgaySinh";
            this.dtpNgaySinh.Size     = new System.Drawing.Size(415, 44);
            this.dtpNgaySinh.TabIndex = 2;

            // ── lblGioiTinh ───────────────────────────────────────────────
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Font     = new System.Drawing.Font("Segoe UI", 9F);
            this.lblGioiTinh.Location = new System.Drawing.Point(15, 305);
            this.lblGioiTinh.Name     = "lblGioiTinh";
            this.lblGioiTinh.Text     = "Giới tính:";

            // ── cboGioiTinh ───────────────────────────────────────────────
            this.cboGioiTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGioiTinh.Font          = new System.Drawing.Font("Segoe UI", 10F);
            this.cboGioiTinh.Items.AddRange(new object[] { "Nam", "Nữ" });
            this.cboGioiTinh.Location      = new System.Drawing.Point(15, 332);
            this.cboGioiTinh.Name          = "cboGioiTinh";
            this.cboGioiTinh.Size          = new System.Drawing.Size(415, 44);
            this.cboGioiTinh.TabIndex      = 3;

            // ── lblLop ────────────────────────────────────────────────────
            this.lblLop.AutoSize = true;
            this.lblLop.Font     = new System.Drawing.Font("Segoe UI", 9F);
            this.lblLop.Location = new System.Drawing.Point(15, 395);
            this.lblLop.Name     = "lblLop";
            this.lblLop.Text     = "Lớp:";

            // ── txtMaLop ──────────────────────────────────────────────────
            this.txtMaLop.Font     = new System.Drawing.Font("Segoe UI", 10F);
            this.txtMaLop.Location = new System.Drawing.Point(15, 422);
            this.txtMaLop.Name     = "txtMaLop";
            this.txtMaLop.Size     = new System.Drawing.Size(415, 44);
            this.txtMaLop.TabIndex = 4;

            // ── btnThem ───────────────────────────────────────────────────
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font      = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location  = new System.Drawing.Point(15, 585);
            this.btnThem.Name      = "btnThem";
            this.btnThem.Size      = new System.Drawing.Size(215, 58);
            this.btnThem.TabIndex  = 5;
            this.btnThem.Text      = "Thêm";
            this.btnThem.Click    += new System.EventHandler(this.btnThem_Click);

            // ── btnSua ────────────────────────────────────────────────────
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(39, 174, 96);
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font      = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location  = new System.Drawing.Point(248, 585);
            this.btnSua.Name      = "btnSua";
            this.btnSua.Size      = new System.Drawing.Size(215, 58);
            this.btnSua.TabIndex  = 6;
            this.btnSua.Text      = "Sửa";
            this.btnSua.Click    += new System.EventHandler(this.btnSua_Click);

            // ── btnXoa ────────────────────────────────────────────────────
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(231, 76, 60);
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font      = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location  = new System.Drawing.Point(15, 660);
            this.btnXoa.Name      = "btnXoa";
            this.btnXoa.Size      = new System.Drawing.Size(215, 58);
            this.btnXoa.TabIndex  = 7;
            this.btnXoa.Text      = "Xóa";
            this.btnXoa.Click    += new System.EventHandler(this.btnXoa_Click);

            // ── btnLamMoi ─────────────────────────────────────────────────
            this.btnLamMoi.BackColor = System.Drawing.Color.FromArgb(127, 140, 141);
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.Font      = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnLamMoi.ForeColor = System.Drawing.Color.White;
            this.btnLamMoi.Location  = new System.Drawing.Point(248, 660);
            this.btnLamMoi.Name      = "btnLamMoi";
            this.btnLamMoi.Size      = new System.Drawing.Size(215, 58);
            this.btnLamMoi.TabIndex  = 8;
            this.btnLamMoi.Text      = "Làm mới";
            this.btnLamMoi.Click    += new System.EventHandler(this.btnLamMoi_Click);

            // ── lblSearch ─────────────────────────────────────────────────
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font     = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblSearch.Location = new System.Drawing.Point(487, 20);
            this.lblSearch.Name     = "lblSearch";
            this.lblSearch.Text     = "Tìm kiếm (Tên / Mã SV / Lớp):";

            // ── txtTimKiem ────────────────────────────────────────────────
            this.txtTimKiem.Font     = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTimKiem.Location = new System.Drawing.Point(487, 50);
            this.txtTimKiem.Name     = "txtTimKiem";
            this.txtTimKiem.Size     = new System.Drawing.Size(380, 44);
            this.txtTimKiem.TabIndex = 9;
            this.txtTimKiem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTimKiem_KeyDown);

            // ── btnTimKiem ────────────────────────────────────────────────
            this.btnTimKiem.BackColor = System.Drawing.Color.FromArgb(52, 73, 94);
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.Font      = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnTimKiem.ForeColor = System.Drawing.Color.White;
            this.btnTimKiem.Location  = new System.Drawing.Point(882, 48);
            this.btnTimKiem.Name      = "btnTimKiem";
            this.btnTimKiem.Size      = new System.Drawing.Size(130, 48);
            this.btnTimKiem.TabIndex  = 10;
            this.btnTimKiem.Text      = "Tìm";
            this.btnTimKiem.Click    += new System.EventHandler(this.btnTimKiem_Click);

            // ── dgvSinhVien ───────────────────────────────────────────────
            this.dgvSinhVien.AllowUserToAddRows    = false;
            this.dgvSinhVien.AllowUserToDeleteRows = false;
            this.dgvSinhVien.BackgroundColor       = System.Drawing.SystemColors.Window;
            this.dgvSinhVien.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSinhVien.Location      = new System.Drawing.Point(487, 112);
            this.dgvSinhVien.Name          = "dgvSinhVien";
            this.dgvSinhVien.ReadOnly      = true;
            this.dgvSinhVien.RowHeadersVisible = false;
            this.dgvSinhVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSinhVien.Size          = new System.Drawing.Size(888, 710);
            this.dgvSinhVien.TabIndex      = 11;
            this.dgvSinhVien.CellClick    += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSinhVien_CellClick);

            // ── frm_sinhvien ──────────────────────────────────────────────
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize          = new System.Drawing.Size(1395, 840);
            this.Controls.Add(this.grpThongTin);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.dgvSinhVien);
            this.Font          = new System.Drawing.Font("Segoe UI", 9.5F);
            this.Name          = "frm_sinhvien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text          = "Quản Lý Sinh Viên";
            this.Load         += new System.EventHandler(this.frm_sinhvien_Load);
            this.grpThongTin.ResumeLayout(false);
            this.grpThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.GroupBox       grpThongTin;
        private System.Windows.Forms.Label          lblMSSV;
        private System.Windows.Forms.TextBox        txtMSSV;
        private System.Windows.Forms.Label          lblHoTen;
        private System.Windows.Forms.TextBox        txtHoTen;
        private System.Windows.Forms.Label          lblNgaySinh;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Label          lblGioiTinh;
        private System.Windows.Forms.ComboBox       cboGioiTinh;
        private System.Windows.Forms.Label          lblLop;
        private System.Windows.Forms.TextBox        txtMaLop;
        private System.Windows.Forms.Button         btnThem;
        private System.Windows.Forms.Button         btnSua;
        private System.Windows.Forms.Button         btnXoa;
        private System.Windows.Forms.Button         btnLamMoi;
        private System.Windows.Forms.Label          lblSearch;
        private System.Windows.Forms.TextBox        txtTimKiem;
        private System.Windows.Forms.Button         btnTimKiem;
        private System.Windows.Forms.DataGridView   dgvSinhVien;
    }
}
