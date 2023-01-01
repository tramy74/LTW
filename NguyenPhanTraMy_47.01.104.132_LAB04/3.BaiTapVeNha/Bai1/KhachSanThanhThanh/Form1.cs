using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KhachSanThanhThanh
{
    public partial class frmKhachSan : Form
    {
        bool _checkNhapNgayO = false;
        bool _checkLoaiPhong = false;
        bool _checkNhapTen = false;
        bool _checkNhapDiaChi = false;
        List<int> _tienKhachHang = new List<int>();

        public frmKhachSan()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e) { }

        private void frmKhachSan_Load(object sender, EventArgs e)
        {
            btnThanhToan.Enabled = false;
            btnTongKet.Enabled = false;
            btnNhapMoi.Enabled = false;
            txtHoTen.Focus();
        }

        private void txtSoNgayO_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int number;
                if (!int.TryParse(txtSoNgayO.Text, out number))
                {
                    throw new Exception("So khong hop le");
                }
                _checkNhapNgayO = true;
            }
            catch (Exception err)
            {
                _checkNhapNgayO = false;
            }
            finally
            {
                KiemTraNhap();
            }
        }

        private void txtSoNgayO_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            try
            {
                if (!_checkNhapTen || !_checkNhapDiaChi || !_checkLoaiPhong || !_checkNhapNgayO)
                {
                    throw new Exception("Vui long dien day du thong tin");
                }
                int tienKhach = 0;
                int tienLoaiPhong = 0;
                int tienTienNghi = 0;
                int tienDichVu = 0;
                int soNgayO = int.Parse(txtSoNgayO.Text);
                if (rdoPhongDon.Checked)
                {
                    tienLoaiPhong = 300000;
                }
                else if (rdoPhongDoi.Checked)
                {
                    tienLoaiPhong = 350000;
                }
                else if (rdoPhongBa.Checked)
                {
                    tienLoaiPhong = 400000;
                }
                tienLoaiPhong = soNgayO * tienLoaiPhong;
                if (chkTiVi.Checked)
                {
                    tienDichVu += 10000;
                }
                if (chkInternet.Checked)
                {
                    tienDichVu += 10000;
                }
                if (chkNuocNong.Checked)
                {
                    tienDichVu += 10000;
                }
                if (chkAnSang.Checked)
                {
                    tienDichVu += 15000 * soNgayO;
                }
                if (chkKaraoke.Checked)
                {
                    tienDichVu += 50000;
                }
                tienKhach = tienLoaiPhong + tienTienNghi + tienDichVu;
                txtThanhTien.Text = tienKhach.ToString();
                _tienKhachHang.Add(tienKhach);
                btnNhapMoi.Enabled = true;
                btnTongKet.Enabled = true;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void txtHoTen_TextChanged(object sender, EventArgs e)
        {
            KiemTraNhap();
        }

        void KiemTraNhap()
        {
            _checkNhapTen = txtHoTen.Text.Length > 0;
            _checkNhapDiaChi = txtDiaChi.Text.Length > 0;
            if (_checkNhapDiaChi && _checkNhapTen && _checkNhapNgayO && _checkLoaiPhong)
            {
                btnThanhToan.Enabled = true;
            }
            else
            {
                btnThanhToan.Enabled = false;
            }
        }

        private void rdoPhongDon_CheckedChanged(object sender, EventArgs e)
        {
            _checkLoaiPhong = rdoPhongDon.Checked || rdoPhongDoi.Checked || rdoPhongBa.Checked;
            KiemTraNhap();
        }

        private void txtDiaChi_TextChanged(object sender, EventArgs e)
        {
            KiemTraNhap();
        }

        private void btnTongKet_Click(object sender, EventArgs e)
        {
            txtSoLuotNguoi.Text = _tienKhachHang.Count.ToString();
            txtTongTien.Text = _tienKhachHang.Sum().ToString();
            _tienKhachHang.Clear();
            btnTongKet.Enabled = false;
        }

        bool CancelConfirm()
        {
            DialogResult r;
            r = MessageBox.Show(
                "Cancel?",
                "Warning",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );
            return r == DialogResult.Yes;
        }

        private void btnNhapMoi_Click(object sender, EventArgs e)
        {
            txtHoTen.Text = null;
            txtDiaChi.Text = null;
            txtSoNgayO.Text = null;
            rdoPhongBa.Checked = false;
            rdoPhongDoi.Checked = false;
            rdoPhongDon.Checked = false;
            chkAnSang.Checked = false;
            chkInternet.Checked = false;
            chkKaraoke.Checked = false;
            chkNuocNong.Checked = false;
            chkTiVi.Checked = false;
            btnNhapMoi.Enabled = false;
            txtThanhTien.Text = null;
            _checkLoaiPhong = false;
            _checkNhapDiaChi = false;
            _checkNhapNgayO = false;
            _checkNhapTen = false;
        }

        private void frmKhachSan_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!CancelConfirm())
            {
                e.Cancel = true;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
