using QuanLyMayMac.DAO;
using QuanLyMayMac.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyMayMac
{
    public partial class fQuanLy : Form
    {
        #region BindingSource

        BindingSource danhsachnhanvien = new BindingSource();
        BindingSource danhsachkhachhang = new BindingSource();
        BindingSource danhsachdaily = new BindingSource();
        BindingSource danhsachkhovai = new BindingSource();
        BindingSource danhsachvai = new BindingSource();
        BindingSource danhsachtrangphuc = new BindingSource();
        BindingSource danhsachkhotrangphuc = new BindingSource();
        BindingSource danhsachloaivai = new BindingSource();
        BindingSource danhsachloaitrangphuc = new BindingSource();
        BindingSource danhsachgiavai = new BindingSource();
        BindingSource danhsachgiatrangphuc = new BindingSource();
        BindingSource danhsachchi = new BindingSource();
        BindingSource danhsachthu = new BindingSource();

        #endregion

        public fQuanLy()
        {
            InitializeComponent();
            LoadNhanVien();
            LoadHangHoa();
            LoadKhachHang();
            LoadDaiLy();
            LoadLoaiVai();
            LoadLoaiTrangPhuc();
        }

        #region methods Nhan Vien

        void LoadNhanVien()
        {
            dtGVDanhSachNhanVien.DataSource = danhsachnhanvien;
            LoadDanhSachNhanVien();
            NhanVienBinding();
        }

        void LocNhanVien()
        {
            if (cbBLoc1NV.Text == "Bo phan")
            {
                List<BoPhan> NhanVien = NhanVienDAO.Instance.LocBoPhan();
                cbBLoc2NV.DataSource = NhanVien;
                cbBLoc2NV.DisplayMember = "BoPhan";
            }
            if (cbBLoc1NV.Text == "Quan ly")
            {
                List<QuanLy> NhanVien = NhanVienDAO.Instance.LocQuanLy();
                cbBLoc2NV.DataSource = NhanVien;
                cbBLoc2NV.DisplayMember = "TenNhanVien";
            }
            if (cbBLoc1NV.Text == "To truong")
            {
                List<ToTruong> NhanVien = NhanVienDAO.Instance.LocToTruong();
                cbBLoc2NV.DataSource = NhanVien;
                cbBLoc2NV.DisplayMember = "TenNhanVien";
            }
            if (cbBLoc1NV.Text == "Tat ca")
            {
                cbBLoc2NV.DataSource = null;
                cbBLoc2NV.Text = "Tat ca";
            }
        }

        void LoadDanhSachNhanVien()
        {
            if (cbBLoc1NV.Text == "Bo phan")
            {
                string loc2 = cbBLoc2NV.Text;
                danhsachnhanvien.DataSource = NhanVienDAO.Instance.DanhSachNhanVien("SELECT IDNhanVien AS 'ID',TenNhanVien AS 'Ten', CMND, SDT, BoPhan AS 'Bo phan', Luong, IDToTruong AS 'To truong',IDQuanLy AS 'Quan ly' FROM dbo.NhanVien WHERE BoPhan = N'" + loc2 + "'");
            }
            if (cbBLoc1NV.Text == "To truong")
            {
                int idnhanvien = (cbBLoc2NV.SelectedItem as ToTruong).IDNhanVien;
                danhsachnhanvien.DataSource = NhanVienDAO.Instance.DanhSachNhanVien("SELECT IDNhanVien AS 'ID',TenNhanVien AS 'Ten', CMND, SDT, BoPhan AS 'Bo phan', Luong, IDToTruong AS 'To truong',IDQuanLy AS 'Quan ly' FROM dbo.NhanVien WHERE IDToTruong = " + idnhanvien);
            }
            if (cbBLoc1NV.Text == "Quan ly")
            {
                int idnhanvien = (cbBLoc2NV.SelectedItem as QuanLy).IDNhanVien;
                danhsachnhanvien.DataSource = NhanVienDAO.Instance.DanhSachNhanVien("SELECT IDNhanVien AS 'ID',TenNhanVien AS 'Ten', CMND, SDT, BoPhan AS 'Bo phan', Luong, IDToTruong AS 'To truong',IDQuanLy AS 'Quan ly' FROM dbo.NhanVien WHERE IDQuanLy = " + idnhanvien);
            }
            if (cbBLoc1NV.Text == "Tat ca")
            {
                danhsachnhanvien.DataSource = NhanVienDAO.Instance.DanhSachNhanVien("SELECT IDNhanVien AS 'ID',TenNhanVien AS 'Ten', CMND, SDT, BoPhan AS 'Bo phan', Luong, IDToTruong AS 'To truong',IDQuanLy AS 'Quan ly' FROM dbo.NhanVien");
            }
        }

        void NhanVienBinding()
        {
            txtIDNhanVienNV.DataBindings.Add(new Binding("Text", dtGVDanhSachNhanVien.DataSource, "ID", true, DataSourceUpdateMode.Never));
            txtTenNhanVienNV.DataBindings.Add(new Binding("Text", dtGVDanhSachNhanVien.DataSource, "Ten", true, DataSourceUpdateMode.Never));
            txtCMNDNV.DataBindings.Add(new Binding("Text", dtGVDanhSachNhanVien.DataSource, "CMND", true, DataSourceUpdateMode.Never));
            txtSDTNV.DataBindings.Add(new Binding("Text", dtGVDanhSachNhanVien.DataSource, "SDT", true, DataSourceUpdateMode.Never));
            txtBoPhanNV.DataBindings.Add(new Binding("Text", dtGVDanhSachNhanVien.DataSource, "Bo phan", true, DataSourceUpdateMode.Never));
            txtLuongNV.DataBindings.Add(new Binding("Text", dtGVDanhSachNhanVien.DataSource, "Luong", true, DataSourceUpdateMode.Never));
            txtIDToTruongNV.DataBindings.Add(new Binding("Text", dtGVDanhSachNhanVien.DataSource, "To truong", true, DataSourceUpdateMode.Never));
            txtIDQuanLyNV.DataBindings.Add(new Binding("Text", dtGVDanhSachNhanVien.DataSource, "Quan ly", true, DataSourceUpdateMode.Never));
        }


        #endregion

        #region events Nhan Vien

        private void cbBLoc1NV_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            LocNhanVien();
        }

        private void btLocNV_Click_1(object sender, EventArgs e)
        {
            if (cbBLoc2NV.Text == "")
            {
                MessageBox.Show("Ban chua chon phuong thuc loc!", "Thong bao");
            }
            else
            {
                LoadDanhSachNhanVien();
            }
        }
        
        private void btThemNgayNghiNV_Click_1(object sender, EventArgs e)
        {
            NgayNghiDAO.Instance.LuuID(txtIDNhanVienNV.Text, txtTenNhanVienNV.Text);
            fThemNgayNghi themngaynghi = new fThemNgayNghi();
            this.Hide();
            themngaynghi.ShowDialog();
            this.Show();
        }

        private void btXoaNhanVienNV_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ban muon xoa nhan vien " + txtTenNhanVienNV.Text, "Thong bao", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                int id = Convert.ToInt32(txtIDNhanVienNV.Text);
                if (txtBoPhanNV.Text == "Nhân viên")
                {
                    NhanVienDAO.Instance.XoaNhanVien(id);
                }
                else
                {
                    NhanVienDAO.Instance.XoaTaiKhoan(id);
                    NhanVienDAO.Instance.XoaNhanVien(id);
                }
                MessageBox.Show("Da xoa nhan vien " + txtTenNhanVienNV.Text + " !", "Thong bao");
                LoadDanhSachNhanVien();
            }
            else
                return;
        }

        private void btSuaThongTinNV_Click_1(object sender, EventArgs e)
        {
            NhanVienDAO.Instance.SuaThongTinNhanVien(Convert.ToInt32(txtIDNhanVienNV.Text), txtTenNhanVienNV.Text, txtCMNDNV.Text, txtSDTNV.Text, txtBoPhanNV.Text, Convert.ToInt32(txtIDToTruongNV.Text), Convert.ToInt32(txtIDQuanLyNV.Text), Convert.ToInt32(txtLuongNV.Text));
            MessageBox.Show("Sua thong tin nhan vien thanh cong!", "Thong bao");
            string taiKhoan = (DataProvider.Instance.ExecuteScalar("SELECT TenTaiKhoan FROM taikhoan where idnhanvien = " + txtIDNhanVienNV.Text)).ToString();
            if ((txtBoPhanNV.Text != "Nhân viên") && (taiKhoan == null))
            {
                NhanVienDAO.Instance.NhanID(Convert.ToInt32(txtIDNhanVienNV.Text));
                fThemTaiKhoan themTaiKhoan = new fThemTaiKhoan();
                themTaiKhoan.ShowDialog();
            }
            LoadDanhSachNhanVien();
        }

        private void btThemNhanVien_Click_1(object sender, EventArgs e)
        {
            fThemNhanVien themnhanvien = new fThemNhanVien();
            this.Hide();
            themnhanvien.ShowDialog();
            this.Show();
            LoadDanhSachNhanVien();
        }

        private void btResetMKNV_Click_1(object sender, EventArgs e)
        {
            NhanVienDAO.Instance.ResetMatKhau(Convert.ToInt32(txtIDNhanVienNV.Text));
            MessageBox.Show("Reset mat khau thanh cong!", "Thong Bao");
        }

        private void btTimNhanVien_Click(object sender, EventArgs e)
        {
            danhsachnhanvien.DataSource = NhanVienDAO.Instance.TimNhanVienTheoTen(txtTenNhanVienNV.Text);
        }

        #endregion



        #region methods Kho

        void LoadHangHoa()
        {
            dtGVDanhSachHangHoa.DataSource = danhsachvai;
            dtGVKhoVai.DataSource = danhsachkhovai;
            dtGVDanhSachKhoTrangPhuc.DataSource = danhsachtrangphuc;
            dtGVKhoTrangPhuc.DataSource = danhsachkhotrangphuc;
            LoadDanhSachHangHoa();
            LoadCBBTenKho();
            BindingHangHoa();
        }

        void LoadDanhSachHangHoa()
        {
            danhsachvai.DataSource = KhoDAO.Instance.LoadDanhSachVai();
            danhsachtrangphuc.DataSource = KhoDAO.Instance.LoadDanhSachTrangPhuc();
        }

        void BindingHangHoa()
        {
            txtIDKhoVai.DataBindings.Add(new Binding("Text", dtGVDanhSachHangHoa.DataSource, "ID", true, DataSourceUpdateMode.Never));
            txtIDKhoTrangPhuc.DataBindings.Add(new Binding("Text", dtGVDanhSachKhoTrangPhuc.DataSource, "ID", true, DataSourceUpdateMode.Never));
        }

        void LoadCBBTenKho()
        {
            List<Kho> DSKho = KhoDAO.Instance.DanhSachKho();
            txtTenKhoTK.DataSource = DSKho;
            txtTenKhoTK.DisplayMember = "TenKho";
            txtTenKhoTP.DataSource = DSKho;
            txtTenKhoTP.DisplayMember = "TenKho";
        }

        #endregion

        #region events Kho

        
        private void btSuaKho_Click_1(object sender, EventArgs e)
        {
            if ((txtIDKhoTK.Text == "") || (txtTenKhoTK.Text == ""))
            {
                MessageBox.Show("Thieu thong tin!", "Thong bao");
            }
            else
            {
                int KhoDay;
                if (ckBKhoDay.Checked == true)
                {
                    KhoDay = 1;
                }
                else
                {
                    KhoDay = 0;
                }
                KhoDAO.Instance.SuaKho(Convert.ToInt32(txtIDKhoTK.Text), txtTenKhoTK.Text, KhoDay);
                MessageBox.Show("Sua kho thanh cong!", "Thong bao");
            }
        }

        private void btThemKho_Click_1(object sender, EventArgs e)
        {
            fThemKho themkho = new fThemKho();
            this.Hide();
            themkho.ShowDialog();
            this.Show();
            dtGVDanhSachHangHoa.DataSource = danhsachvai;
            dtGVKhoVai.DataSource = danhsachkhovai;
        }

        private void btSuaKhoTP_Click_1(object sender, EventArgs e)
        {
            if ((txtIDKhoTK.Text == "") || (txtIDKhoTP.Text == ""))
            {
                MessageBox.Show("Thieu thong tin!", "Thong bao");
            }
            else
            {
                int KhoDay;
                if (ckBKhoDayTP.Checked == true)
                {
                    KhoDay = 1;
                }
                else
                {
                    KhoDay = 0;
                }
                KhoDAO.Instance.SuaKho(Convert.ToInt32(txtIDKhoTP.Text), txtTenKhoTP.Text, KhoDay);
                MessageBox.Show("Sua kho thanh cong!", "Thong bao");
            }
        }

        private void btThemKhoTP_Click_1(object sender, EventArgs e)
        {
            fThemKho themkho = new fThemKho();
            this.Hide();
            themkho.ShowDialog();
            this.Show();
            dtGVDanhSachKhoTrangPhuc.DataSource = danhsachtrangphuc;
            dtGVKhoTrangPhuc.DataSource = danhsachkhotrangphuc;
        }

        private void btNhapTP_Click_2(object sender, EventArgs e)
        {
            fNhapTrangPhuc NhapTrangPhuc = new fNhapTrangPhuc();
            this.Hide();
            NhapTrangPhuc.ShowDialog();
            this.Show();
            LoadDanhSachHangHoa();
        }

        private void btXuatTP_Click_1(object sender, EventArgs e)
        {
            fXuatTrangPhuc xuathang = new fXuatTrangPhuc();
            this.Hide();
            xuathang.ShowDialog();
            this.Show();
            LoadDanhSachHangHoa();
        }

        #endregion



        #region methods Khach hang

        void LoadKhachHang()
        {
            dtGVDanSachKhachHang.DataSource = danhsachkhachhang;
            LoadDanhSachKhachHang();
            BindingKhachHang();
        }

        void LoadDanhSachKhachHang()
        {
            danhsachkhachhang.DataSource = KhachHangDAO.Instance.DanhSachKhachHang();
        }

        void BindingKhachHang()
        {
            txtIDKH.DataBindings.Add(new Binding("Text", dtGVDanSachKhachHang.DataSource, "ID", true, DataSourceUpdateMode.Never));
            txtTenKH.DataBindings.Add(new Binding("Text", dtGVDanSachKhachHang.DataSource, "Ten", true, DataSourceUpdateMode.Never));
            txtSDTKH.DataBindings.Add(new Binding("Text", dtGVDanSachKhachHang.DataSource, "SDT", true, DataSourceUpdateMode.Never));
            txtDiaChiKH.DataBindings.Add(new Binding("Text", dtGVDanSachKhachHang.DataSource, "Dia chi", true, DataSourceUpdateMode.Never));
        }

        #endregion

        #region events Khach Hang


        private void btThemKH_Click(object sender, EventArgs e)
        {
            fThemKhachHang themkhachhang = new fThemKhachHang();
            this.Hide();
            themkhachhang.ShowDialog();
            this.Show();
            LoadDanhSachKhachHang();
        }

        private void btSuaKH_Click(object sender, EventArgs e)
        {
            KhachHangDAO.Instance.SuaKhachHang(Convert.ToInt32(txtIDKH.Text), txtTenKH.Text, txtSDTKH.Text, txtDiaChiKH.Text);
            MessageBox.Show("Sua thong tin khach hang thanh cong!", "Thong bao");
            LoadDanhSachKhachHang();
        }

        private void btbXoaKH_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Ban muon xoa mau vai " + txtTenKH.Text + " !", "Thong bao", MessageBoxButtons.OKCancel)) == System.Windows.Forms.DialogResult.OK)
            {
                if (KhachHangDAO.Instance.KiemTraKhachHang(Convert.ToInt32(txtIDKH.Text),"HoaDonBan") > 0)
                {
                    MessageBox.Show("Khach hang con trong hoa don", "Thong bao");
                }
                else
                {
                    KhachHangDAO.Instance.XoaKhachHang(Convert.ToInt32(txtIDKH.Text));
                    MessageBox.Show("Ban da xoa khach hang " + txtTenKH.Text + " !", "Thong bao");
                    LoadDanhSachKhachHang();
                }
            }
            else
            {
                return;
            }
        }

        private void txtTenKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(txtIDKH.Text);
            txtIDKH.Text = ID.ToString();
            txtTenKH.Text = KhachHangDAO.Instance.LayThongTinKhachHang("TenKhachHang",ID);
            txtSDTKH.Text = KhachHangDAO.Instance.LayThongTinKhachHang("SDT",ID);
            txtDiaChiKH.Text = KhachHangDAO.Instance.LayThongTinKhachHang("DiaChi", ID);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            danhsachkhachhang.DataSource = KhachHangDAO.Instance.XemDSKhachHang(txtTenKH.Text);
        }

        #endregion



        #region methods Dai ly

        void LoadDaiLy()
        {
            dtGVDanhSachDaiLy.DataSource = danhsachdaily;
            LoadDanhSachDaiLy();
            BindingDaiLy();
        }

        void LoadDanhSachDaiLy()
        {
            danhsachdaily.DataSource = DaiLyDAO.Instance.LoadDanhSachDaiLy();
        }

        void BindingDaiLy()
        {
            txtIDDL.DataBindings.Add(new Binding("Text", dtGVDanhSachDaiLy.DataSource, "ID", true, DataSourceUpdateMode.Never));
            txtTenDL.DataBindings.Add(new Binding("Text", dtGVDanhSachDaiLy.DataSource, "Ten", true, DataSourceUpdateMode.Never));
            txtSDTDL.DataBindings.Add(new Binding("Text", dtGVDanhSachDaiLy.DataSource, "SDT", true, DataSourceUpdateMode.Never));
            txtDiaChiDL.DataBindings.Add(new Binding("Text", dtGVDanhSachDaiLy.DataSource, "Dia chi", true, DataSourceUpdateMode.Never));
        }

        #endregion

        #region events Dai Ly


        private void btThemDL_Click(object sender, EventArgs e)
        {
            fThemDaiLy themdaily = new fThemDaiLy();
            this.Hide();
            themdaily.ShowDialog();
            this.Show();
            LoadDanhSachDaiLy();
        }

        private void btSuaDL_Click(object sender, EventArgs e)
        {
            DaiLyDAO.Instance.SuaDaiLy(Convert.ToInt32(txtIDDL.Text), txtTenDL.Text, txtSDTDL.Text, txtDiaChiDL.Text);
            MessageBox.Show("Sua thong tin dai ly thanh cong!", "Thong bao");
            LoadDanhSachDaiLy();
        }

        private void btXoaDL_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Ban muon xoa mau vai " + txtTenDL.Text + " !", "Thong bao", MessageBoxButtons.OKCancel)) == System.Windows.Forms.DialogResult.OK)
            {
                if (DaiLyDAO.Instance.KiemTraDaiLy(Convert.ToInt32(txtIDDL.Text),"HoaDonMua") > 0)
                {
                    MessageBox.Show("Dai ly con trong hoa don", "Thong bao");
                }
                else
                {
                    DaiLyDAO.Instance.XoaDaiLy(Convert.ToInt32(txtIDDL.Text));
                    MessageBox.Show("Ban da xoa dai ly " + txtTenKH.Text + " !", "Thong bao");
                    LoadDanhSachKhachHang();
                }
            }
            else
            {
                return;
            }
        }

        private void txtTenDL_SelectedIndexChanged(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(txtIDDL.Text);
            txtIDDL.Text = ID.ToString();
            txtSDTDL.Text = DaiLyDAO.Instance.LayThongTinDaiLy("SDT", ID);
            txtDiaChiDL.Text = DaiLyDAO.Instance.LayThongTinDaiLy("DiaChi", ID);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            danhsachdaily.DataSource = DaiLyDAO.Instance.XemDSDaiLy(txtTenDL.Text);
        }

        #endregion



        #region methods Vai

        void LoadLoaiVai()
        {
            dtGVDanhSachVai.DataSource = danhsachloaivai;
            dtGVDanhSachGiaVai.DataSource = danhsachgiavai;
            dtGVDanhSachChi.DataSource = danhsachchi;
            LoadDanhSachLoaiVai();
            LoadDanhSachGiaVai();
            LoadTienMuaVai();
            LoaiVaiBinding();
            BindingGiaVai();
        }

        void LoadDanhSachLoaiVai()
        {
            danhsachloaivai.DataSource = MauVaiDAO.Instance.LoadDanhSachVai();
        }

        void LoaiVaiBinding()
        {
            txtIDVai.DataBindings.Add(new Binding("Text", dtGVDanhSachVai.DataSource, "ID", true, DataSourceUpdateMode.Never));
            txtTenVai.DataBindings.Add(new Binding("Text", dtGVDanhSachVai.DataSource, "Ten", true, DataSourceUpdateMode.Never));
            txtMauV.DataBindings.Add(new Binding("Text", dtGVDanhSachVai.DataSource, "Mau", true, DataSourceUpdateMode.Never));
            txtDaiV.DataBindings.Add(new Binding("Text", dtGVDanhSachVai.DataSource, "Chieu dai", true, DataSourceUpdateMode.Never));
            txtRongV.DataBindings.Add(new Binding("Text", dtGVDanhSachVai.DataSource, "Chieu rong", true, DataSourceUpdateMode.Never));
            //get in csdl lay cai link of cai anh tu id nhan vien, set cho boximage cho cai ink getptrBHinhV
        }

        void BindingGiaVai()
        {
            txtIDGiaVai.DataBindings.Add(new Binding("Text", dtGVDanhSachGiaVai.DataSource, "ID", true, DataSourceUpdateMode.Never));
            txtTenGiaVai.DataBindings.Add(new Binding("Text", dtGVDanhSachGiaVai.DataSource, "Ten vai", true, DataSourceUpdateMode.Never));
            txtGiaGiaVai.DataBindings.Add(new Binding("Text", dtGVDanhSachGiaVai.DataSource, "Gia", true, DataSourceUpdateMode.Never));
            dtPkGiaVai.DataBindings.Add(new Binding("Text", dtGVDanhSachGiaVai.DataSource, "Ngay cap nhat", true, DataSourceUpdateMode.Never));
            txtIDHoaDonMua.DataBindings.Add(new Binding("Text", dtGVDanhSachChi.DataSource, "ID", true, DataSourceUpdateMode.Never));
        }

        void LoadDanhSachGiaVai()
        {
            danhsachgiavai.DataSource = MauVaiDAO.Instance.LoadDSGiaVai();
            
        }

        void LoadTienMuaVai()
        {
            danhsachchi.DataSource = VaiDAO.Instance.DanhSachChi();
        }

        #endregion

        #region events Vai


        private void btThemV_Click(object sender, EventArgs e)
        {
            fThemMauVai themmauvai = new fThemMauVai();
            this.Hide();
            themmauvai.ShowDialog();
            this.Show();
            LoadDanhSachLoaiVai();
        }

        private void btNhapVai_Click_1(object sender, EventArgs e)
        {
            fNhapVai nhaphang = new fNhapVai();
            this.Hide();
            nhaphang.ShowDialog();
            this.Show();
            LoadDanhSachHangHoa();
        }

        private void dtGVDanhSachVai_Click(object sender, EventArgs e)
        {
            if (txtIDVai.Text != "")
            {
                string duongdan = (DataProvider.Instance.ExecuteScalar("SELECT HinhAnhMau FROM dbo.LoaiVai WHERE IDLoaiVai = " + txtIDVai.Text).ToString());
                Image HinhAnh = Image.FromFile(duongdan);
                ptrBHinhV.Image = HinhAnh;
                txtGiaV.Text = (DataProvider.Instance.ExecuteScalar("SELECT Gia FROM GiaVai WHERE IDLoaiVai = " + txtIDVai.Text + " AND ThoiGian = (SELECT MAX(ThoiGian) FROM GiaVai Where IDLoaiVai = " + txtIDVai.Text + ")")).ToString();
            }
            else
            {
                return;
            }
        }

        private void btXoaV_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Ban muon xoa mau vai " + txtTenVai.Text + " !", "Thong bao", MessageBoxButtons.OKCancel)) == System.Windows.Forms.DialogResult.OK)
            {
                if (MauVaiDAO.Instance.KiemTraLoaiVai(Convert.ToInt32(txtIDVai.Text), "Vai") > 0)
                {
                    MessageBox.Show("Mau nay con trong kho!", "Thong bao");
                }
                else if (MauVaiDAO.Instance.KiemTraLoaiVai(Convert.ToInt32(txtIDVai.Text), "GiaVai") > 0)
                {
                    MessageBox.Show("Mau nay con trong bang gia!", "Thong bao");
                }
                else if (MauVaiDAO.Instance.KiemTraLoaiVai(Convert.ToInt32(txtIDVai.Text), "LoaiTrangPhuc") > 0)
                {
                    MessageBox.Show("Mau nay con trong mau trang phuc!", "Thong bao");
                }
                else
                {
                    MauVaiDAO.Instance.XoaMauVai(Convert.ToInt32(txtIDVai.Text));
                    MessageBox.Show("Ban da xoa mau vai " + txtTenVai.Text + " !", "Thong bao");
                    LoadDanhSachLoaiVai();
                }
            }
            else
            {
                return;
            }
        }

        private void btSuaV_Click(object sender, EventArgs e)
        {
            MauVaiDAO.Instance.SuaMauVai(Convert.ToInt32(txtIDVai.Text), txtTenVai.Text, Convert.ToInt32(txtDaiV.Text), Convert.ToInt32(txtRongV.Text), txtMauV.Text, Convert.ToInt32(txtGiaV.Text));
            MessageBox.Show("Sua thong tin vai thanh cong!", "Thong bao");
            LoadDanhSachLoaiVai();
        }

        private void ptrBHinhV_Click(object sender, EventArgs e)
        {
            if (txtIDVai.Text == null)
            {
                MessageBox.Show(txtIDVai.Text, "Thong bao");
            }
            else
            {
                KiemTraDAO.Instance.nhapID(Convert.ToInt32(txtIDVai.Text), "Vai");
                fHinhVai hinhVai = new fHinhVai();
                hinhVai.ShowDialog();
            }
        }

        private void dtGVKhoVai_Click(object sender, EventArgs e)
        {
            if (txtIDKhoVai.Text != "")
            {
                txtIDKhoTK.Text = KhoDAO.Instance.LayIDKhoVai(Convert.ToInt32(txtIDKhoVai.Text)).ToString();
                txtTenKhoTK.Text = (DataProvider.Instance.ExecuteScalar("SELECT TenKho FROM dbo.Kho WHERE IDKho = " + txtIDKhoTK.Text)).ToString();
                ckBKhoDay.Checked = KhoDAO.Instance.KhoDay(Convert.ToInt32(txtIDKhoTK.Text));
            }
            else
            {
                MessageBox.Show("Chon kho vai!", "Thong bao");
            }
        }

        private void btSuaGiaVai_Click(object sender, EventArgs e)
        {
            if ((txtIDGiaVai.Text == "") || (txtTenGiaVai.Text == "") || (txtGiaGiaVai.Text == ""))
            {
                MessageBox.Show("Thieu thong tin!", "Thong bao");
            }
            else
            {
                string Ngay = KiemTraDAO.Instance.ChuoiNgay((dtPkGiaVai.Value.Day).ToString(), (dtPkGiaVai.Value.Month).ToString(), (dtPkGiaVai.Value.Year).ToString());
                int IDLoaiVai = Convert.ToInt32(txtIDGiaVai.Text);
                MauVaiDAO.Instance.SuaGiaVai(Convert.ToInt32(txtIDGiaVai.Text), Convert.ToInt32(txtGiaGiaVai.Text), Ngay, IDLoaiVai);
                MessageBox.Show("Sua thanh cong!", "Thong bao");
                LoadDanhSachGiaVai();
            }
        }

        private void btXoaGiaVai_Click(object sender, EventArgs e)
        {
            if (txtIDGiaVai.Text != "")
            {
                MauVaiDAO.Instance.XoaGiaVai(Convert.ToInt32(txtIDGiaVai.Text));
                MessageBox.Show("Xoa thanh cong!", "Thong bao");
                LoadDanhSachGiaVai();
            }
            else
            {
                MessageBox.Show("Chon gia vai can xoa!", "Thong bao");
            }
        }

        private void dtGVDanhSachChi_Click(object sender, EventArgs e)
        {
            if (txtIDHoaDonMua.Text != "")
            {
                txtTenDaiLyHoaDonMua.Text = (DataProvider.Instance.ExecuteScalar("SELECT b.TenDaiLy FROM dbo.HoaDonMua a, dbo.DaiLy b WHERE a.IDDaiLyVai = b.IDDaiLy AND a.IDHoaDonMua = " + txtIDHoaDonMua.Text)).ToString();
                txtTenNhanVienHoaDonMua.Text = (DataProvider.Instance.ExecuteScalar("SELECT b.TenNhanVien FROM dbo.HoaDonMua a, dbo.NhanVien b WHERE a.IDNhanVien = b.IDNhanVien AND a.IDHoaDonMua = " + txtIDHoaDonMua.Text)).ToString();
            }
            else
            {
                MessageBox.Show("Chon hoa don mua!", "Thong bao");
            }
        }

        private void btXemHoaDonMua_Click(object sender, EventArgs e)
        {
            txtTenDaiLyHoaDonMua.Text = (DataProvider.Instance.ExecuteScalar("SELECT b.TenDaiLy FROM dbo.HoaDonMua a, dbo.DaiLy b WHERE a.IDDaiLyVai = b.IDDaiLy AND a.IDHoaDonMua = " + txtIDHoaDonMua.Text)).ToString();
            txtTenNhanVienHoaDonMua.Text = (DataProvider.Instance.ExecuteScalar("SELECT b.TenNhanVien FROM dbo.HoaDonMua a, dbo.NhanVien b WHERE a.IDNhanVien = b.IDNhanVien AND a.IDHoaDonMua = " + txtIDHoaDonMua.Text)).ToString();
        }

        private void btXemChi_Click(object sender, EventArgs e)
        {
            string Tu = KiemTraDAO.Instance.ChuoiNgay((dTPTuChi.Value.Day).ToString(), (dTPTuChi.Value.Month).ToString(), (dTPTuChi.Value.Year).ToString());
            string Den = KiemTraDAO.Instance.ChuoiNgay((dTPDenChi.Value.Day).ToString(), (dTPDenChi.Value.Month).ToString(), (dTPDenChi.Value.Year).ToString());
            danhsachchi.DataSource = VaiDAO.Instance.DanhSachChiCoNgay(Tu, Den);
            txtTongChiChi.Text = (VaiDAO.Instance.TongTienChi(Tu, Den));
        }

        private void btXemTatCaChi_Click(object sender, EventArgs e)
        {
            danhsachchi.DataSource = VaiDAO.Instance.DanhSachChi();
        }

        private void dtGVDanhSachHangHoa_Click(object sender, EventArgs e)
        {
            if (txtIDKhoVai.Text != "")
            {
                danhsachkhovai.DataSource = KhoDAO.Instance.LoadDanhSachKhoVai(Convert.ToInt32(txtIDKhoVai.Text));
            }
            else
            {
                MessageBox.Show("Chon kho vai!", "Thong bao");
            }
        }

        private void btXemGiaVai_Click(object sender, EventArgs e)
        {
            danhsachgiavai.DataSource = MauVaiDAO.Instance.XemDSGiaVai(txtTenGiaVai.Text);
        }

        private void txtTenKhoTK_SelectedIndexChanged(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32((txtTenKhoTK.SelectedItem as Kho).IDKho);
            txtIDKhoTK.Text = ID.ToString();
            string KhoDay = (KhoDAO.Instance.LayThongTinKho("KhoDay", ID));
            if (KhoDay == "True")
            {
                ckBKhoDay.Checked = true;
            }
            else
            {
                ckBKhoDay.Checked = false;
            }
        }

        

        private void btXemMauVai_Click(object sender, EventArgs e)
        {
            danhsachloaivai.DataSource = MauVaiDAO.Instance.XemDSVai(txtTenVai.Text);
        }

        #endregion


        #region methods TrangPhuc

        void LoadLoaiTrangPhuc()
        {
            dtGVDanhSachTP.DataSource = danhsachloaitrangphuc;
            dtGVDanhSachGiaTP.DataSource = danhsachgiatrangphuc;
            dtGVDanhSachThu.DataSource = danhsachthu;
            LoadDanhSachLoaiTrangPhuc();
            BindingLoaiTrangPhuc();
            BindingGiaTrangPhuc();
            LoadDanhSachThu();
        }

        void LoadDanhSachLoaiTrangPhuc()
        {
            danhsachloaitrangphuc.DataSource = MauTrangPhucDAO.Instance.LoadDanhSachTrangPhuc();
            danhsachgiatrangphuc.DataSource = MauTrangPhucDAO.Instance.LoadDSGiaTrangPhuc();
        }

        void BindingLoaiTrangPhuc()
        {
            cbBKichCoTP.DataBindings.Add(new Binding("Text", dtGVDanhSachTP.DataSource, "Kich co", true, DataSourceUpdateMode.Never));
            txtIDMauTP.DataBindings.Add(new Binding("Text", dtGVDanhSachTP.DataSource, "ID", true, DataSourceUpdateMode.Never));
            txtTenTP.DataBindings.Add(new Binding("Text", dtGVDanhSachTP.DataSource, "Ten", true, DataSourceUpdateMode.Never));
            txtLoaiVai.DataBindings.Add(new Binding("Text", dtGVDanhSachTP.DataSource, "Loai vai", true, DataSourceUpdateMode.Never));
            LoadCbBMauVai();
        }

        void LoadCbBMauVai()
        {
            List<MauVai> list = MauVaiDAO.Instance.DanhSachMauVai();
            txtLoaiVai.DataSource = list;
            txtLoaiVai.DisplayMember = "Ten";
        }

        void BindingGiaTrangPhuc()
        {
            txtIDGiaTP.DataBindings.Add(new Binding("Text", dtGVDanhSachGiaTP.DataSource, "ID", true, DataSourceUpdateMode.Never));
            txtTenGiaTrangPhuc.DataBindings.Add(new Binding("Text", dtGVDanhSachGiaTP.DataSource, "Ten trang phuc", true, DataSourceUpdateMode.Never));
            txtGiaGiaTrangPhuc.DataBindings.Add(new Binding("Text", dtGVDanhSachGiaTP.DataSource, "Gia", true, DataSourceUpdateMode.Never));
            dtPkGiaTrangPhuc.DataBindings.Add(new Binding("Text", dtGVDanhSachGiaTP.DataSource, "Ngay cap nhat", true, DataSourceUpdateMode.Never));
        }

        void LoadDanhSachThu()
        {
            danhsachthu.DataSource = TrangPhucDAO.Instance.LoadDSThu();
            txtIDHoaDonThu.DataBindings.Add(new Binding("Text", dtGVDanhSachThu.DataSource, "ID", true, DataSourceUpdateMode.Never));
        }

        #endregion

        #region events Trang Phuc


        private void btThemTP_Click(object sender, EventArgs e)
        {
            fThemMauAo themmauao = new fThemMauAo();
            this.Hide();
            themmauao.ShowDialog();
            this.Show();
            LoadDanhSachLoaiTrangPhuc();
        }

        private void dtGVDanhSachTP_Click(object sender, EventArgs e)
        {
            if (txtIDMauTP.Text != "")
            {
                string duongdan = (DataProvider.Instance.ExecuteScalar("SELECT HinhAnhMau FROM dbo.LoaiTrangPhuc WHERE IDLoaiTrangphuc = " + txtIDMauTP.Text).ToString());
                Image HinhAnh = Image.FromFile(duongdan);
                ptrBHinhTP.Image = HinhAnh;
                int Ao = Convert.ToInt32((DataProvider.Instance.ExecuteScalar("SELECT Ao FROM dbo.LoaiTrangPhuc WHERE IDLoaiTrangphuc = " + txtIDMauTP.Text)));
                if (Ao == 1)
                {
                    cbBLoaiTP.Text = "Ao";
                }
                else
                {
                    cbBLoaiTP.Text = "Quan";
                }
                txtGia.Text = (DataProvider.Instance.ExecuteScalar("SELECT Gia FROM GiaTrangPhuc WHERE IDLoaiTrangPhuc = " + txtIDMauTP.Text)).ToString();
            }
            else
            {
                return;
            }
        }

        private void ptrBHinhTP_Click(object sender, EventArgs e)
        {
            if (txtIDVai.Text == null)
            {
                MessageBox.Show(txtIDMauTP.Text, "Thong bao");
            }
            else
            {
                KiemTraDAO.Instance.nhapID(Convert.ToInt32(txtIDMauTP.Text), "TrangPhuc");
                fHinhVai hinhVai = new fHinhVai();
                hinhVai.ShowDialog();
            }
        }

        private void btSuaTP_Click(object sender, EventArgs e)
        {
            int iD = (txtLoaiVai.SelectedItem as MauVai).ID;
            int Ao;
            if(cbBLoaiTP.Text == "Ao")
            {
                Ao = 1;
            }
            else
            {
                Ao = 0;
            }
            MauTrangPhucDAO.Instance.SuaTrangPhuc(Convert.ToInt32(txtIDMauTP.Text), txtTenTP.Text, iD, Ao, cbBKichCoTP.Text, Convert.ToInt32(txtGia.Text));
            MessageBox.Show("Sua thong tin trang phuc thanh cong!", "Thong bao");
            LoadDanhSachLoaiTrangPhuc();
        }

        private void btXoaTP_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Ban muon xoa mau vai " + txtTenVai.Text + " !", "Thong bao",MessageBoxButtons.OKCancel)) == System.Windows.Forms.DialogResult.OK)
            {
                MauTrangPhucDAO.Instance.XoaMauVai(Convert.ToInt32(txtIDMauTP.Text));
                MessageBox.Show("Ban da xoa mau vai " + txtTenTP.Text + " !", "Thong bao");
                LoadDanhSachLoaiTrangPhuc();
            }
            else
            {
                return;
            }
        }

        private void btLocTP_Click(object sender, EventArgs e)
        {
            danhsachloaitrangphuc.DataSource = MauTrangPhucDAO.Instance.LocTrangPhuc(cbBLoaiTP.Text,cbBKichCoTP.Text);

        }

        private void dtGVKhoTrangPhuc_Click(object sender, EventArgs e)
        {
            if (txtIDKhoTrangPhuc.Text != "")
            {
                txtIDKhoTP.Text = KhoDAO.Instance.LayIDKhoTrangPhuc(Convert.ToInt32(txtIDKhoTrangPhuc.Text)).ToString();
                txtTenKhoTP.Text = (KhoDAO.Instance.LayThongTinKho("TenKho", Convert.ToInt32(txtIDKhoTP.Text)));
                ckBKhoDayTP.Checked = Convert.ToBoolean(KhoDAO.Instance.LayThongTinKho("KhoDay", Convert.ToInt32(txtIDKhoTP.Text)));
            }
            else
            {
                MessageBox.Show("Chon kho trang phuc!", "Thong bao");
            }
        }


        private void btNhapTP_Click_1(object sender, EventArgs e)
        {
            fNhapTrangPhuc NhapTrangPhuc = new fNhapTrangPhuc();
            this.Hide();
            NhapTrangPhuc.ShowDialog();
            this.Show();
        }


        private void btSuaGiaTrangPhuc_Click(object sender, EventArgs e)
        {
            if ((txtIDGiaTP.Text == "") || (txtTenGiaTrangPhuc.Text == "") || (txtGiaGiaTrangPhuc.Text == ""))
            {
                MessageBox.Show("Thieu thong tin!", "Thong bao");
            }
            else
            {
                string Ngay = KiemTraDAO.Instance.ChuoiNgay((dtPkGiaTrangPhuc.Value.Day).ToString(), (dtPkGiaTrangPhuc.Value.Month).ToString(), (dtPkGiaTrangPhuc.Value.Year).ToString());
                int IDLoaiTrangPhuc = Convert.ToInt32(txtIDGiaTP.Text);
                MauTrangPhucDAO.Instance.SuaGiaTrangPhuc(Convert.ToInt32(txtIDGiaTP.Text), Convert.ToInt32(txtGiaGiaTrangPhuc.Text), Ngay, IDLoaiTrangPhuc);
                MessageBox.Show("Sua thanh cong!", "Thong bao");
                LoadDanhSachLoaiTrangPhuc();
            }
        }

        private void btXoaGiaTrangPhuc_Click(object sender, EventArgs e)
        {
            if (txtIDGiaVai.Text != "")
            {
                MauTrangPhucDAO.Instance.XoaGiaTrangPhuc(Convert.ToInt32(txtIDGiaTP.Text));
                MessageBox.Show("Xoa thanh cong!", "Thong bao");
                LoadDanhSachLoaiTrangPhuc();
            }
            else
            {
                MessageBox.Show("Chon gia vai can xoa!", "Thong bao");
            }
        }

        private void dtGVDanhSachThu_Click(object sender, EventArgs e)
        {
            if (txtIDHoaDonThu.Text != "")
            {
                txtNhanVienHoaDonThu.Text = (DataProvider.Instance.ExecuteScalar("SELECT b.TenNhanVien FROM dbo.HoaDonBan a, dbo.NhanVien b WHERE a.IDNhanVien = b.IDNhanVien AND a.IDHoaDonBan = " + txtIDHoaDonThu.Text)).ToString();
                txtKhachHangHoaDonThu.Text = (DataProvider.Instance.ExecuteScalar("SELECT b.TenKhachHang FROM dbo.HoaDonBan a, dbo.KhachHang b WHERE a.IDKhachHang = b.IDKhachHang AND a.IDHoaDonBan = " + txtIDHoaDonThu.Text)).ToString();
            }
            else
            {
                MessageBox.Show("Chon hoa don thu!", "Thong bao");
            }
        }

        private void btXemHoaDonThu_Click(object sender, EventArgs e)
        {
            txtNhanVienHoaDonThu.Text = (DataProvider.Instance.ExecuteScalar("SELECT b.TenNhanVien FROM dbo.HoaDonBan a, dbo.NhanVien b WHERE a.IDNhanVien = b.IDNhanVien AND a.IDHoaDonBan = " + txtIDHoaDonThu.Text)).ToString();
            txtKhachHangHoaDonThu.Text = (DataProvider.Instance.ExecuteScalar("SELECT b.TenKhachHang FROM dbo.HoaDonBan a, dbo.KhachHang b WHERE a.IDKhachHang = b.IDKhachHang AND a.IDHoaDonBan = " + txtIDHoaDonThu.Text)).ToString();
        }

        private void btXemThu_Click(object sender, EventArgs e)
        {
            string Tu = KiemTraDAO.Instance.ChuoiNgay((dTPTuThu.Value.Day).ToString(), (dTPTuThu.Value.Month).ToString(), (dTPTuThu.Value.Year).ToString());
            string Den = KiemTraDAO.Instance.ChuoiNgay((dTPDenThu.Value.Day).ToString(), (dTPDenThu.Value.Month).ToString(), (dTPDenThu.Value.Year).ToString());
            danhsachthu.DataSource = TrangPhucDAO.Instance.DanhSachThuCoNgay(Tu, Den);
            txtTongThuThu.Text = (TrangPhucDAO.Instance.TongTienThu(Tu, Den));
        }

        private void btXemTatCaThu_Click(object sender, EventArgs e)
        {
            danhsachthu.DataSource = TrangPhucDAO.Instance.LoadDSThu();
        }

        private void dtGVDanhSachKhoTrangPhuc_Click_1(object sender, EventArgs e)
        {
            if (txtIDKhoTrangPhuc.Text != "")
            {
                danhsachkhotrangphuc.DataSource = KhoDAO.Instance.LoadDanhSachKhoTrangPhuc(Convert.ToInt32(txtIDKhoTrangPhuc.Text));
            }
            else
            {
                MessageBox.Show("Chon loai trang phuc!", "Thong bao");
            }
        }

        private void btXemGiaTP_Click(object sender, EventArgs e)
        {
            danhsachgiatrangphuc.DataSource = MauTrangPhucDAO.Instance.XemDSGiaTrangPhuc(txtTenGiaTrangPhuc.Text);
        }

        private void txtTenKhoTP_SelectedIndexChanged(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32((txtTenKhoTP.SelectedItem as Kho).IDKho);
            txtIDKhoTP.Text = ID.ToString();
            string KhoDay = (KhoDAO.Instance.LayThongTinKho("KhoDay", ID));
            if (KhoDay == "True")
            {
                ckBKhoDayTP.Checked = true;
            }
            else
            {
                ckBKhoDayTP.Checked = false;
            }
        }

        private void txtTenTP_SelectedIndexChanged(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(txtIDMauTP.Text);
            string duongdan = TrangPhucDAO.Instance.LayThongTinTrangPhuc("HinhAnhMau", ID);
            Image HinhAnh = Image.FromFile(duongdan);
            ptrBHinhTP.Image = HinhAnh;
            Boolean Ao = Convert.ToBoolean(TrangPhucDAO.Instance.LayThongTinTrangPhuc("Ao",ID));
            if (Ao)
            {
                cbBLoaiTP.Text = "Ao";
            }
            else
            {
                cbBLoaiTP.Text = "Quan";
            }
            txtIDMauTP.Text = ID.ToString();
            txtGia.Text = TrangPhucDAO.Instance.LayGiaTrangPhuc("Gia",ID);
            txtLoaiVai.Text = TrangPhucDAO.Instance.LayThongTinLoaiVaiKichCo("c.TenLoaiVai",ID);
            cbBKichCoTP.Text = TrangPhucDAO.Instance.LayThongTinLoaiVaiKichCo("b.KichCo",ID);
        }

        private void btXemMauTrangPhuc_Click(object sender, EventArgs e)
        {
            danhsachloaitrangphuc.DataSource = MauTrangPhucDAO.Instance.XemDSTrangPhuc(txtTenTP.Text);
        }

        #endregion


        #region events Ca Nhan

        private void xemThongTinCaNhanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NgayNghiDAO.Instance.LuuID(txtIDNhanVienNV.Text, txtTenNhanVienNV.Text);
            fThongTinCaNhan thongtincanhan = new fThongTinCaNhan();
            this.Hide();
            thongtincanhan.ShowDialog();
            this.Show();
            LoadDanhSachNhanVien();
        }

        private void doiMatKhauToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fDoiMatKhau doimatkhau = new fDoiMatKhau();
            this.Hide();
            doimatkhau.ShowDialog();
            this.Show();
        }

        private void dangXuatToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        private void txtCMNDNV_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtIDNhanVienNV_TextChanged(object sender, EventArgs e)
        {

        }

        

        

        

        

        

        

        

        

        

        

        

        

        

        

        

        

        

        


        


        

        

        

        

    }
}
