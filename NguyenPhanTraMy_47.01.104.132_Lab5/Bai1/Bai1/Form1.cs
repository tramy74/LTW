using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai1
{
    public partial class Form1 : Form
    {
        List<int> _listSo = new List<int>();
        List<int> _listUocSo = new List<int>();

        public Form1()
        {
            InitializeComponent();
        }

        private void txtNhapSo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                int number;
                if (!int.TryParse(txtNhapSo.Text, out number))
                {
                    throw new Exception("Vui long nhap so hop le");
                }
                if (_listSo.Contains(number))
                {
                    throw new Exception("So da duoc them");
                }
                cboListSo.Items.Add(number);
                _listSo.Add(number);
                txtNhapSo.Text = null;
                txtNhapSo.Focus();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void cboListSo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cboListSo.SelectedIndex < 0)
                {
                    throw new Exception("Vui long chon so");
                }
                lstUocSo.Items.Clear();
                _listUocSo.Clear();
                int number = int.Parse(cboListSo.SelectedItem.ToString());
                _listUocSo = TimUoc(number);
                foreach (var item in _listUocSo)
                {
                    lstUocSo.Items.Add(item.ToString());
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
        List<int> TimUoc(int number)
        {
            List<int> ketQua = new List<int>();
            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    ketQua.Add(i);
                }
            }
            return ketQua;
        }

        private void btnTongUoc_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_listUocSo.Sum().ToString());

        }

        private void btnSoLuongUocChan_Click(object sender, EventArgs e)
        {
            int dem = 0;
            dem = _listUocSo.Where((x => x % 2 == 0)).Count();
            MessageBox.Show(dem.ToString());
        }

        private void btnSoLuongUocNT_Click(object sender, EventArgs e)
        {
            int dem = 0;
            dem = _listUocSo.Where((x => CheckSoNguyenTo(x))).Count();
            MessageBox.Show(dem.ToString());

        }
        bool CheckSoNguyenTo(int n)
        {
            if (n < 2)
            {
                return false;
            }
            int dem = 0;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    dem++;
                }
            }
            return dem == 0;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có muốn thoát?", "Thoát",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question,
               MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
