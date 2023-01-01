using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MangSoNguyen
{
    public partial class Form1 : Form
    {
        MangSoNguyen mangSoNguyen;
        bool _checkSapXep = false;
        bool _checkTimKiem = false;
        bool _checkXoa = false;
        bool _checkThem = false;
        bool _checkThayThe = false;

        public Form1()
        {
            InitializeComponent();
            mangSoNguyen = new MangSoNguyen();
        }

        private void Form1_Load(object sender, EventArgs e) { }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (
                !char.IsControl(e.KeyChar)
                && !char.IsDigit(e.KeyChar)
                && e.KeyChar != '-'
                && e.KeyChar != ' '
            )
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                mangSoNguyen.Clear();

                txtKetQua.Text = null;

                var arr = txtNhap.Text.Split(' ').Select(x => int.Parse(x.ToString())).ToArray();
                foreach (var item in arr)
                {
                    txtKetQua.Text += item.ToString() + " ";
                    mangSoNguyen.Add(item);
                }
                btnThucHien.PerformClick();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            mangSoNguyen.Clear();
            ResetSapXep();
            ResetTimKiem();
            ResetNhap();
            ResetKetQua();
            ResetMinMax();
            ResetThem();
            ResetXoa();
            ResetTong();
            ResetMinMax();
            ResetThayThe();
        }

        void UpdateKetQua()
        {
            txtKetQua.Text = null;
            foreach (var item in mangSoNguyen.GetList())
            {
                txtKetQua.Text += item.ToString() + " ";
            }
        }

        private void btnThucHien_Click(object sender, EventArgs e)
        {
            try
            {
                if (_checkSapXep)
                {
                    if (rdoSapXepTang.Checked)
                    {
                        mangSoNguyen.Sort();
                    }
                    else if (rdoSapXepGiam.Checked)
                    {
                        mangSoNguyen.Sort(-1);
                    }
                    UpdateKetQua();
                }
                if (_checkTimKiem)
                {
                    string result = "";
                    if (rdoTimGiaTri.Checked)
                    {
                        int search = int.Parse(txtTimGiaTri.Text);
                        result = mangSoNguyen.SearchGiaTri(search).ToString();
                    }
                    else if (rdoTimViTri.Checked)
                    {
                        int search = int.Parse(txtTimViTri.Text);
                        result = mangSoNguyen.SearchViTri(search).ToString();
                    }
                    txtKetQuaTimKiem.Text = result;
                }
                if (_checkXoa)
                {
                    bool checkSapXep = rdoSapXepTang.Checked;
                    if (!checkSapXep)
                    {
                        throw new Exception("Vui long sap xep tang dan truoc khi Xoa");
                    }
                    if (rdoTimGiaTriXoa.Checked)
                    {
                        int search = int.Parse(txtTimGiaTriXoa.Text);
                        mangSoNguyen.XoaGiaTri(search);
                    }
                    else if (rdoTimViTriXoa.Checked)
                    {
                        int search = int.Parse(txtTimViTriXoa.Text);
                        mangSoNguyen.XoaViTri(search);
                    }
                    UpdateKetQua();
                }
                if (_checkThem)
                {
                    bool checkSapXep = rdoSapXepTang.Checked;
                    if (!checkSapXep)
                    {
                        throw new Exception("Vui long sap xep tang dan truoc khi Xoa");
                    }
                    if (rdoTimGiaTriThem.Checked)
                    {
                        int search = int.Parse(txtTimGiaTriThem.Text);
                        int value = int.Parse(txtGiaTriThem.Text);
                        mangSoNguyen.ThemGiaTri(search, value);
                    }
                    else if (rdoTimViTriThem.Checked)
                    {
                        int search = int.Parse(txtTimViTriThem.Text);
                        int value = int.Parse(txtGiaTriThem.Text);
                        mangSoNguyen.ThemViTri(search, value);
                    }
                    UpdateKetQua();
                }
                if (_checkThayThe)
                {
                    if (rdoTimGiaTriThayThe.Checked)
                    {
                        int search = int.Parse(txtTimGiaTriThayThe.Text);
                        int value = int.Parse(txtGiaTriThayThe.Text);
                        mangSoNguyen.ThayTheGiaTri(search, value);
                    }
                    else if (rdoTimViTriThayThe.Checked)
                    {
                        int search = int.Parse(txtTimViTriThayThe.Text);
                        int value = int.Parse(txtGiaTriThayThe.Text);
                        mangSoNguyen.ThayTheViTri(search, value);
                    }
                    UpdateKetQua();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error");
            }
        }

        private void rdoSapXepTang_CheckedChanged(object sender, EventArgs e)
        {
            _checkSapXep = true;
        }

        private void rdoSapXepGiam_CheckedChanged(object sender, EventArgs e)
        {
            _checkSapXep = true;
        }

        private void rdoTimGiaTri_CheckedChanged(object sender, EventArgs e)
        {
            _checkTimKiem = true;
            txtTimGiaTri.Enabled = true;
            txtTimViTri.Enabled = false;
            txtTimViTri.Text = null;
            txtKetQuaTimKiem.Text = null;
            lblKetQuaTimKiem.Text = "Vị trí tìm được:";
        }

        private void rdoTimViTri_CheckedChanged(object sender, EventArgs e)
        {
            txtTimGiaTri.Enabled = false;
            txtTimViTri.Enabled = true;
            _checkTimKiem = true;
            txtKetQuaTimKiem.Text = null;
            txtTimGiaTri.Text = null;
            lblKetQuaTimKiem.Text = "Số tìm được là:";
        }

        private void rdoTimGiaTriXoa_CheckedChanged(object sender, EventArgs e)
        {
            _checkXoa = true;
            txtTimGiaTriXoa.Enabled = true;
            txtTimViTriXoa.Enabled = false;
            txtTimViTriXoa.Text = null;
        }

        private void rdoTimViTriXoa_CheckedChanged(object sender, EventArgs e)
        {
            _checkXoa = true;
            txtTimGiaTriXoa.Enabled = false;
            txtTimViTriXoa.Enabled = true;
            txtTimGiaTriXoa.Text = null;
        }

        private void rdoTimGiaTriThem_CheckedChanged(object sender, EventArgs e)
        {
            _checkThem = true;
            txtTimGiaTriThem.Enabled = true;
            txtTimViTriThem.Enabled = false;
            txtTimViTriThem.Text = null;
        }

        private void rdoTimViTriThem_CheckedChanged(object sender, EventArgs e)
        {
            _checkThem = true;
            txtTimGiaTriThem.Enabled = false;
            txtTimViTriThem.Enabled = true;
            txtTimGiaTriThem.Text = null;
        }

        private void rdoTimGiaTriThayThe_CheckedChanged(object sender, EventArgs e)
        {
            _checkThayThe = true;
            txtTimGiaTriThayThe.Enabled = true;
            txtTimViTriThayThe.Enabled = false;
            txtTimViTriThayThe.Text = null;
        }

        private void rdoTimViTriThayThe_CheckedChanged(object sender, EventArgs e)
        {
            _checkThayThe = true;
            txtTimGiaTriThayThe.Enabled = false;
            txtTimViTriThayThe.Enabled = true;
            txtTimGiaTriThayThe.Text = null;
        }

        private void btnTong_Click(object sender, EventArgs e)
        {
            txtTong.Text = mangSoNguyen.TongMang().ToString();
            txtTongChan.Text = mangSoNguyen.TongMangChan().ToString();
            txtTongLe.Text = mangSoNguyen.TongMangLe().ToString();
        }

        private void btnTimMinMax_Click(object sender, EventArgs e)
        {
            try
            {
                txtMin.Text = mangSoNguyen.Min().ToString();
                txtMax.Text = mangSoNguyen.Max().ToString();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error");
            }
        }

        void ResetNhap()
        {
            txtNhap.Text = null;
        }

        void ResetKetQua()
        {
            txtKetQua.Text = null;
        }

        void ResetSapXep()
        {
            _checkSapXep = false;
            rdoSapXepTang.Checked = false;
            rdoSapXepGiam.Checked = false;
        }

        void ResetTimKiem()
        {
            _checkTimKiem = false;
            rdoTimGiaTri.Checked = false;
            rdoTimViTri.Checked = false;
            txtTimGiaTri.Text = null;
            txtTimViTri.Text = null;
            txtKetQuaTimKiem.Text = null;
        }

        void ResetXoa()
        {
            _checkXoa = false;
            rdoTimGiaTriXoa.Checked = false;
            rdoTimViTriXoa.Checked = false;
            txtTimGiaTriXoa.Text = null;
            txtTimViTriXoa.Text = null;
        }

        void ResetThem()
        {
            _checkThem = false;
            rdoTimGiaTriThem.Checked = false;
            rdoTimViTriThem.Checked = false;
            txtTimGiaTriThem.Text = null;
            txtTimViTriThem.Text = null;
            txtGiaTriThem.Text = null;
        }

        void ResetThayThe()
        {
            _checkThayThe = false;
            rdoTimGiaTriThayThe.Checked = false;
            rdoTimViTriThayThe.Checked = false;
            txtTimGiaTriThayThe.Text = null;
            txtTimViTriThayThe.Text = null;
            txtGiaTriThayThe.Text = null;
        }

        void ResetTong()
        {
            txtTong.Text = null;
            txtTongChan.Text = null;
            txtTongLe.Text = null;
        }

        void ResetMinMax()
        {
            txtMin.Text = null;
            txtMax.Text = null;
        }

        private void txtTimGiaTri_TextChanged(object sender, EventArgs e) { }

        private void txtTimGiaTriXoa_TextChanged(object sender, EventArgs e) { }

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

        private void txtTimGiaTri_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '-')
            {
                e.Handled = true;
            }
        }

        private void txtTimViTri_TextChanged(object sender, EventArgs e) { }

        private void txtTimViTri_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '-')
            {
                e.Handled = true;
            }
        }

        private void txtTimGiaTriXoa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '-')
            {
                e.Handled = true;
            }
        }

        private void txtTimViTriXoa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '-')
            {
                e.Handled = true;
            }
        }

        private void txtTimGiaTriThem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '-')
            {
                e.Handled = true;
            }
        }

        private void txtTimViTriThem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '-')
            {
                e.Handled = true;
            }
        }

        private void txtGiaTriThem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '-')
            {
                e.Handled = true;
            }
        }

        private void txtTimGiaTriThayThe_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '-')
            {
                e.Handled = true;
            }
        }

        private void txtTimViTriThayThe_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '-')
            {
                e.Handled = true;
            }
        }

        private void txtGiaTriThayThe_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '-')
            {
                e.Handled = true;
            }
        }
    }
}
