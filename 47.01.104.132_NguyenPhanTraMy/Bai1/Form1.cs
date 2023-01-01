using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _47._01._104._132_NguyenPhanTraMy
{
    public partial class frmBai1 : Form
    {
        public frmBai1()
        {
            InitializeComponent();
        }

        private Double tinhTong(double n)
        {
            double sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum = sum + (double)1 / i;
            }
            return sum;
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

        private void txtNhapGiaTriN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }



        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTinhTong_Click(object sender, EventArgs e)
        {
            double giaTriN = double.Parse(txtNhapGiaTriN.Text);
            double tong = tinhTong(giaTriN);
            txtKetQua.Text = tong.ToString();
        }
    }
}
