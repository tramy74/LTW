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
    public partial class Lab06_bttlb1 : Form
    {
        public Lab06_bttlb1()
        {
            InitializeComponent();
        }

        private void frmLab06_bttlb1_Load(object sender, EventArgs e)
        {
            string[] dt = { "Kinh", "Hoa", "Tày", "Ê đê", "H'Mông", "Khác" };
            foreach (string s in dt)
                cb_DanToc.Items.Add(s);
        }

        private void cb_DanToc_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void Reset()
        {
            txtName.Clear();
            txtMaSV.Clear();
            rbtnNam.Checked = false;
            rbtnNu.Checked = false;
            cb_DanToc.Text = "";
            c_English.Checked = false;
            c_French.Checked = false;
            c_Hoa.Checked = false;
        }

        private void cb_DanToc_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //if(lsv_ThongTin.Items.Count == 0)
            //{
            //    lsv_ThongTin.Items.Add(txtName.Text).SubItems.Add(txtMaSV.Text);
            //    lsv_ThongTin.Items[lsv_ThongTin.Items.Count - 1].SubItems.Add(CheckGT());
            //    lsv_ThongTin.Items[lsv_ThongTin.Items.Count - 1].SubItems.Add(CheckLanguage());
            //    lsv_ThongTin.Items[lsv_ThongTin.Items.Count - 1].SubItems.Add(cb_DanToc.Text);
            //}
            if (lsv_ThongTin.Items.Count >= 0)
            {
                bool isExists = false;

                for (int i = 0; i < lsv_ThongTin.Items.Count; i++)
                    if (lsv_ThongTin.Items[i].SubItems[1].Text == txtMaSV.Text)
                    {
                        isExists = true;
                        break;
                    }

                if (isExists == false)
                {
                    lsv_ThongTin.Items.Add(txtName.Text).SubItems.Add(txtMaSV.Text);
                    lsv_ThongTin.Items[lsv_ThongTin.Items.Count - 1].SubItems.Add(CheckGT());
                    lsv_ThongTin.Items[lsv_ThongTin.Items.Count - 1].SubItems.Add(CheckLanguage());
                    lsv_ThongTin.Items[lsv_ThongTin.Items.Count - 1].SubItems.Add(cb_DanToc.Text);
                }
                else
                    MessageBox.Show("This student code is already exists");
            }
            Reset();
        }


        private string CheckGT()
        {
            string s = "";
            if (rbtnNam.Checked)
                s = "Nam";
            if (rbtnNu.Checked)
                s = "Nữ";
            return s;

        }

        private string CheckLanguage()
        {
            string s = "";
            if (c_English.Checked)
                s += "Tiếng anh" + " ";
            if (c_French.Checked)
                s += "Tiếng pháp" + " ";
            if (c_Hoa.Checked)
                s += "Tiếng hoa" + " ";
            if (s == "")
                return "Không có";

            return s;
        }


        private void btnXoa_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem ls in lsv_ThongTin.SelectedItems)
                ls.Remove();

            Reset();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (lsv_ThongTin.Items.Count == 0)
            {
                MessageBox.Show("No item to change");
            }
            else if (lsv_ThongTin.SelectedItems != null && lsv_ThongTin.Items.Count > 0)
            {
                lsv_ThongTin.SelectedItems[0].Text = txtName.Text;

                bool isExists = false;
                for (int i = 0; i < lsv_ThongTin.Items.Count; i++)
                    if (lsv_ThongTin.Items[i].SubItems[1].Text == txtMaSV.Text)
                    {
                        isExists = true;
                        break;
                    }

                if (!isExists)
                {
                    lsv_ThongTin.SelectedItems[0].SubItems[1].Text = txtMaSV.Text;

                    if (rbtnNam.Checked)
                        lsv_ThongTin.SelectedItems[0].SubItems[2].Text = "Nam";
                    else
                        lsv_ThongTin.SelectedItems[0].SubItems[2].Text = "Nữ";

                    lsv_ThongTin.SelectedItems[0].SubItems[3].Text = CheckLanguage();

                    lsv_ThongTin.SelectedItems[0].SubItems[4].Text = cb_DanToc.Text;
                }
                else
                    MessageBox.Show("This student code is already exists");



                Reset();
            }
            else
                MessageBox.Show("you have not selected to change the information");
        }

        private void lsv_ThongTin_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txtName.Text = lsv_ThongTin.SelectedItems[0].Text;
                txtMaSV.Text = lsv_ThongTin.SelectedItems[0].SubItems[1].Text;
                if (lsv_ThongTin.SelectedItems[0].SubItems[2].Text == "Nam")
                    rbtnNam.Checked = true;
                else
                    rbtnNu.Checked = true;

                if (lsv_ThongTin.SelectedItems[0].SubItems[3].Text.Contains("Tiếng anh"))
                    c_English.Checked = true;
                if (lsv_ThongTin.SelectedItems[0].SubItems[3].Text.Contains("Tiếng pháp"))
                    c_French.Checked = true;
                if (lsv_ThongTin.SelectedItems[0].SubItems[3].Text.Contains("Tiếng hoa"))
                    c_Hoa.Checked = true;

                cb_DanToc.Text = lsv_ThongTin.SelectedItems[0].SubItems[4].Text;

            }
            catch { }
        }

        private void rbtnNam_Leave(object sender, EventArgs e)
        {
            if (!rbtnNam.Checked && !rbtnNu.Checked)
                errorProvider1.SetError(rbtnNu, "Please, click your sex");
            else
                errorProvider1.Clear();
        }

        private void cb_DanToc_Leave(object sender, EventArgs e)
        {
            if (cb_DanToc.Text == "")
                errorProvider1.SetError(rbtnNu, "Please, click your ethnicity");
            else
                errorProvider1.Clear();
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            if (txtName.Text == "")
                errorProvider1.SetError(txtName, "Please, input your name");
            else
                errorProvider1.Clear();
        }

        private void txtMaSV_Leave(object sender, EventArgs e)
        {
            if (txtMaSV.Text == "")
                errorProvider1.SetError(txtMaSV, "Please, input your name");
            else
                errorProvider1.Clear();
        }
    }
}

