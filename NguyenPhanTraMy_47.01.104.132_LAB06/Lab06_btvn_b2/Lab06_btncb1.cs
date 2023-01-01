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
    public partial class Lab06_btncb1 : Form
    {

        private void loadData(string ten, string lop)
        {
            if (lop == "Lớp A")
                ls_A.Items.Add(ten);
            else
                ls_B.Items.Add(ten);
        }


        public Lab06_btncb1()
        {
            InitializeComponent();
        }

        private void kếtThúcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Lab06_btncb1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Do you want to close this program ?", "Announce", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                e.Cancel = true;
        }

        private void nhậpHọcViênMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lab06_btncb1_1 ncb1_1 = new lab06_btncb1_1();
            ncb1_1.capnhat = new lab06_btncb1_1.CapNhat(loadData);
            ncb1_1.ShowDialog();
        }

        private void chuyểnSangLớpAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ls_A.SelectedItems.Count > 0)
            {
                ls_B.Items.Add(ls_A.SelectedItem);
                ls_A.Items.Remove(ls_A.SelectedItem);
            }
            else
            {
                MessageBox.Show("Vui long chon hoc vien !", "Thong bao");
            }
        }

        private void chuyểnSangLớpBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ls_B.SelectedItems.Count > 0)
            {
                ls_A.Items.Add(ls_B.SelectedItem);
                ls_B.Items.Remove(ls_B.SelectedItem);
            }
            else
            {
                MessageBox.Show("Vui long chon hoc vien !", "Thong bao");
            }
        }

        private void xóaHọcViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ls_A.SelectedItems.Count > 0 || ls_B.SelectedItems.Count > 0)
            {
                ls_B.Items.Remove(ls_B.SelectedItem);
                ls_A.Items.Remove(ls_A.SelectedItem);
            }
            else
            {
                MessageBox.Show("Vui long chon hoc vien !", "Thong bao");
            }
        }
    }
}
