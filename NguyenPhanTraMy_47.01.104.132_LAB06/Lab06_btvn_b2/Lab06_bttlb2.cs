using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Lab06_btvn_b2
{
    public partial class Lab06_bttlb2 : Form
    {
        public Lab06_bttlb2()
        {
            InitializeComponent();
        }

        private void Lab06_bttlb2_Load(object sender, EventArgs e)
        {

        }

        private void txtSTK_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void txtTenKH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void txtMoney_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }



        private void Reset()
        {
            txtSTK.Text = "";
            txtTenKH.Text = "";
            txtAddress.Text = "";
            txtMoney.Text = "";
            txtSTK.Enabled = false;
            txtAddress.Enabled = false;
            txtMoney.Enabled = false;
            txtTenKH.Enabled = false;
            btnSave.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (btnAdd.Text == "Hủy")
            {
                btnAdd.Text = "Thêm";
                Reset();
            }
            else
            {
                txtSTK.Enabled = true;
                txtAddress.Enabled = true;
                txtMoney.Enabled = true;
                txtTenKH.Enabled = true;
                btnSave.Enabled = true;
                btnAdd.Text = "Hủy";

            }
        }
       

        List<double> lstMoney = new List<double>();

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtTenKH.Text != "" && txtAddress.Text != "" && txtSTK.Text != "" && txtMoney.Text != "")
            {
                //ListBox item = new ListBox();
                //item.Items.Add((lsv_ThongTin.Items.Count + 1).ToString());

                lsv_ThongTin.Items.Add((lsv_ThongTin.Items.Count + 1).ToString()).SubItems.Add(txtSTK.Text);
                lsv_ThongTin.Items[lsv_ThongTin.Items.Count - 1].SubItems.Add(txtTenKH.Text);
                lsv_ThongTin.Items[lsv_ThongTin.Items.Count - 1].SubItems.Add(txtAddress.Text);
                lsv_ThongTin.Items[lsv_ThongTin.Items.Count - 1].SubItems.Add(txtMoney.Text);
                lstMoney.Add(Convert.ToDouble(txtMoney.Text));
                txtSum.Text = lstMoney.Sum().ToString();
                txtSTK.Focus();
            }
            Reset();
        }

        private void btnErase_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem ls in lsv_ThongTin.SelectedItems)
                ls.Remove();

            for (int i = count; i < lsv_ThongTin.Items.Count; i++)
            {
                lsv_ThongTin.Items[i].SubItems[0].Text = Convert.ToString(++i);
            }

            Reset();
        }


        int count = 0;

        private void lsv_ThongTin_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsv_ThongTin.SelectedItems != null)
            {
                try
                {
                    count = lsv_ThongTin.SelectedIndices.Count;
                    txtSTK.Text = lsv_ThongTin.SelectedItems[0].Text;
                    txtTenKH.Text = lsv_ThongTin.SelectedItems[0].SubItems[2].Text;
                    txtAddress.Text = lsv_ThongTin.SelectedItems[0].SubItems[3].Text;
                    txtMoney.Text = lsv_ThongTin.SelectedItems[0].SubItems[4].Text;
                }
                catch { }
                btnErase.Enabled = true;
                txtSTK.Enabled = false;
                txtAddress.Enabled = false;
                txtMoney.Enabled = false;
                txtTenKH.Enabled = false;
                btnSave.Enabled = false;
            }
            else
            {
                btnErase.Enabled = false;
                txtSTK.Enabled = true;
                txtAddress.Enabled = true;
                txtMoney.Enabled = true;
                txtTenKH.Enabled = true;
                btnSave.Enabled = true;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
