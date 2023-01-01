using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeSinhVien
{
    public partial class Form1 : Form
    {
        bool _checkTenKhachHang = false;
        bool _checkThucUong = false;
        bool _checkSoKhachHang = false;
        CuaHang cuaHang;

        public Form1()
        {
            InitializeComponent();
            cuaHang = new CuaHang();
        }

        private void txtTenKhachHang_TextChanged(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            try
            {
                if (ctr.Text.Trim().Length == 0)
                {
                    throw new Exception("Ten khach hang khong duoc bo trong!");
                }
                _checkTenKhachHang = true;
                CheckButton();
            }
            catch (Exception err)
            {
                _checkTenKhachHang = false;
            }
        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            try
            {
                _checkThucUong =
                    rdoCafeDa.Checked
                    || rdoCafeDen.Checked
                    || rdoCafeKem.Checked
                    || rdoCafeSua.Checked
                    || rdoCafeSuaDa.Checked;
                if (!_checkTenKhachHang || !_checkThucUong)
                {
                    throw new Exception("Vui long nhap day du thong tin");
                }
                int soKhachHang;
                if (txtSoKhachHang.Text == null)
                {
                    soKhachHang = cuaHang.GetSoLuongKhachHang() + 1;
                }
                else
                {
                    soKhachHang = int.Parse(txtSoKhachHang.Text);
                }
                KhachHang khachHangMoi = new KhachHang(
                    soKhachHang,
                    txtTenKhachHang.Text,
                    chkSinhVien.Checked
                );
                if (rdoCafeDa.Checked)
                {
                    ThucUong thucUong = cuaHang.GetThucUong(2);

                    khachHangMoi.SetThucUong(thucUong);
                }
                else if (rdoCafeDen.Checked)
                {
                    ThucUong thucUong = cuaHang.GetThucUong(1);

                    khachHangMoi.SetThucUong(thucUong);
                }
                else if (rdoCafeKem.Checked)
                {
                    ThucUong thucUong = cuaHang.GetThucUong(5);

                    khachHangMoi.SetThucUong(thucUong);
                }
                else if (rdoCafeSua.Checked)
                {
                    ThucUong thucUong = cuaHang.GetThucUong(3);

                    khachHangMoi.SetThucUong(thucUong);
                }
                else if (rdoCafeSuaDa.Checked)
                {
                    ThucUong thucUong = cuaHang.GetThucUong(4);

                    khachHangMoi.SetThucUong(thucUong);
                }
                if (chkBanhMyCa.Checked)
                {
                    ThucAn thucAn = cuaHang.GetThucAn(2);
                    khachHangMoi.AddThucAn(thucAn);
                }
                if (chkBanhMyTrung.Checked)
                {
                    ThucAn thucAn = cuaHang.GetThucAn(1);
                    khachHangMoi.AddThucAn(thucAn);
                }
                if (chkMyCay.Checked)
                {
                    ThucAn thucAn = cuaHang.GetThucAn(5);
                    khachHangMoi.AddThucAn(thucAn);
                }
                if (chkMyTomTrung.Checked)
                {
                    ThucAn thucAn = cuaHang.GetThucAn(3);
                    khachHangMoi.AddThucAn(thucAn);
                }
                if (chkMyXaoBo.Checked)
                {
                    ThucAn thucAn = cuaHang.GetThucAn(4);
                    khachHangMoi.AddThucAn(thucAn);
                }
                khachHangMoi.SetTongTien();
                cuaHang.AddKhachHang(khachHangMoi);
                MessageBox.Show(
                    $"{khachHangMoi.GetThongTin()}",
                    "Thông tin đơn hàng",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                btnNhapLai.Enabled = true;
                btnThanhToan.Enabled = true;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error");
            }
        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            _checkTenKhachHang = false;
            _checkThucUong = false;
            txtTenKhachHang.Text = null;
            txtSoKhachHang.Text = null;
            chkSinhVien.Checked = false;
            rdoCafeDa.Checked = false;
            rdoCafeDen.Checked = false;
            rdoCafeKem.Checked = false;
            rdoCafeSua.Checked = false;
            rdoCafeSuaDa.Checked = false;
            chkBanhMyCa.Checked = false;
            chkBanhMyTrung.Checked = false;
            chkMyCay.Checked = false;
            chkMyTomTrung.Checked = false;
            chkMyXaoBo.Checked = false;
            txtTenKhachHang.Focus();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            txtTongKhachHang.Text = cuaHang.GetSoLuongKhachHang().ToString();
            txtTongTienThanhToan.Text = cuaHang.GetTongTien().ToString();
            btnNhapLai.PerformClick();
        }

        private void txtSoKhachHang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSoKhachHang_TextChanged(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            try
            {
                int number;

                if (!int.TryParse(ctr.Text, out number))
                {
                    throw new Exception("So khach hang khong hop le");
                }
                _checkSoKhachHang = true;
                CheckButton();
            }
            catch (Exception err)
            {
                _checkSoKhachHang = false;
            }
        }

        void CheckButton()
        {
            _checkThucUong =
                rdoCafeDa.Checked
                || rdoCafeDen.Checked
                || rdoCafeKem.Checked
                || rdoCafeSua.Checked
                || rdoCafeSuaDa.Checked;

            if (_checkTenKhachHang && _checkThucUong && _checkSoKhachHang)
            {
                btnTinhTien.Enabled = true;
            }
            else
            {
                btnTinhTien.Enabled = false;
            }
        }

        void SetButton()
        {
            btnThanhToan.Enabled = false;
            btnTinhTien.Enabled = false;
            btnNhapLai.Enabled = false;
        }

        private void rdoCafeDen_CheckedChanged(object sender, EventArgs e)
        {
            CheckButton();
            _checkThucUong = true;
        }

        private void rdoCafeDa_CheckedChanged(object sender, EventArgs e)
        {
            CheckButton();
            _checkThucUong = true;
        }

        private void rdoCafeSua_CheckedChanged(object sender, EventArgs e)
        {
            CheckButton();
            _checkThucUong = true;
        }

        private void rdoCafeKem_CheckedChanged(object sender, EventArgs e)
        {
            CheckButton();
            _checkThucUong = true;
        }

        private void rdoCafeSuaDa_CheckedChanged(object sender, EventArgs e)
        {
            CheckButton();
            _checkThucUong = true;
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

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!CancelConfirm())
            {
                e.Cancel = true;
            }
        }
    }
}
