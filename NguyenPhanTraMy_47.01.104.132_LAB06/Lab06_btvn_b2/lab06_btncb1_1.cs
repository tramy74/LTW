using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab06_btvn_b2
{
    public partial class lab06_btncb1_1 : Form
    {
        public delegate void CapNhat(string ten, string lop);
        public CapNhat capnhat;

        public lab06_btncb1_1()
        {
            InitializeComponent();
        }

        private void cbLop_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (txthovaten.Text.Trim().Length > 0)
            {
                if (capnhat != null)
                    capnhat(txthovaten.Text, cbLop.SelectedItem.ToString());
                txthovaten.Clear();
                cbLop.Text = "";
            }
            else
            {
                MessageBox.Show("Vui long nhap ten !", "Thong bao");
                txthovaten.Focus();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txthovaten_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && char.IsDigit(e.KeyChar))
                e.Handled = true;
        }
    }
}
