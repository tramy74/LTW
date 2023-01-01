using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai2
{
    public partial class frmBai2 : Form
    {
        List<int> _list = new List<int>();
        public frmBai2()
        {
            InitializeComponent();
        }

        private void frmBai2_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có muốn thoát?", "Thoát",
           MessageBoxButtons.YesNo, MessageBoxIcon.Question,
           MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

        private void frmBai2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnNhapSo_Click(object sender, EventArgs e)
        {
            int nhapN;
            if (!int.TryParse(txtNhapSo.Text, out nhapN))
            {
                throw new Exception("Số không hợp lệ, vui lòng nhập số nguyên!!!");
                MessageBox.Show("Vui lòng nhập số", "LỖI!!!");
                return;
            }

            _list.Add(nhapN);
            txtNhapSo.Text = null;
            txtNhapSo.Focus();
            string result = "";
            foreach (var item in _list)
            {
                result = result + item.ToString() + " ";
            }
            txtDayVuaNhap.Text = result;
        }

        private void btnSxGiam_Click(object sender, EventArgs e)
        {
            _list.Sort();
            _list.Reverse();
            string result = "";
            foreach (var item in _list)
            {
                result = result + item.ToString() + " ";
            }
            txtDayVuaNhap.Text = result;
        }

        private void txtNhapSo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnThucHien_Click(object sender, EventArgs e)
        {
            int sum = 0;
            sum = _list.Sum();
            txtTongMang.Text = sum.ToString();

            List<int> listPhanTuChan = _list.Where(x => x % 2 == 0).ToList();
            txtTongChan.Text = listPhanTuChan.Count.ToString();

        }
    }
}
