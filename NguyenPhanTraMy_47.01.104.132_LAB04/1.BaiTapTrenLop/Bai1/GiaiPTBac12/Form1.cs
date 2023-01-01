using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiaiPTBac12
{
    public partial class Form1 : Form
    {
        bool _checkA = false;
        bool _checkB = false;
        bool _checkC = false;
        bool _checkOption = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void txtA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '-' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void txtB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '-' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void txtC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '-' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }
        void CheckButton()
        {
            if (rdoPTBac1.Checked)
            {
                if (_checkA && _checkB)
                {
                    btnThucHien.Enabled = true;
                }
                else
                {
                    btnThucHien.Enabled = false;
                }
            }
            else if (rdoPTBac2.Checked)
            {
                if (_checkA && _checkB && _checkC)
                {
                    btnThucHien.Enabled = true;
                }
                else
                {
                    btnThucHien.Enabled = false;
                }
            }
        }
        private void txtA_TextChanged(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            try
            {

                float number;
                if (!float.TryParse(ctr.Text, out number))
                {
                    throw new Exception("A is invalid");
                }
                else
                {
                    _checkA = true;
                }


            }
            catch (Exception err)
            {
                _checkA = false;
            }
            finally
            {
                CheckButton();
            }

        }

        private void txtB_TextChanged(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            try
            {

                float number;
                if (!float.TryParse(ctr.Text, out number))
                {
                    throw new Exception("B is invalid");
                }
                else
                {
                    _checkB = true;
                }

            }
            catch (Exception err)
            {
                _checkB = false;
            }
            finally
            {
                CheckButton();
            }

        }

        private void txtC_TextChanged(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            try
            {

                float number;
                if (!float.TryParse(ctr.Text, out number))
                {
                    throw new Exception("C is invalid");
                }
                else
                {
                    _checkC = true;
                }


            }
            catch (Exception err)
            {
                _checkC = false;
            }
            finally
            {
                CheckButton();
            }

        }

        private void rdoPTBac1_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoPTBac1.Checked)
            {
                txtC.Text = null;
                lblC.Enabled = false;
                txtC.Enabled = false;
                CheckButton();
                txtKetQua.Text = null;
            }
        }

        private void rdoPTBac2_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoPTBac2.Checked)
            {
                lblC.Enabled = true;
                txtC.Enabled = true;
                CheckButton();
                txtKetQua.Text = null;
            }
        }

        private void btnThucHien_Click(object sender, EventArgs e)
        {
            try
            {
                if (rdoPTBac1.Checked)
                {
                    if (!_checkA || !_checkB)
                    {
                        throw new Exception("Vui long nhap du lieu!");

                    }
                    else
                    {
                        float a = float.Parse(txtA.Text);
                        float b = float.Parse(txtB.Text);
                        PhuongTrinhBacHai tinhToan = new PhuongTrinhBacHai(0, a, b);
                        txtKetQua.Text = tinhToan.Giai();
                    }
                }
                else if (rdoPTBac2.Checked)
                {
                    if (!_checkA || !_checkB || !_checkC)
                    {
                        throw new Exception("Vui long nhap du lieu!");

                    }
                    else
                    {
                        float a = float.Parse(txtA.Text);
                        float b = float.Parse(txtB.Text);
                        float c = float.Parse(txtC.Text);
                        PhuongTrinhBacHai tinhToan = new PhuongTrinhBacHai(a, b, c);
                        txtKetQua.Text = tinhToan.Giai();
                    }
                }

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
          
                this.Close();
            

        }
        bool CancelConfirm()
        {
            DialogResult r;
            r = MessageBox.Show("Cancel?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            return r == DialogResult.Yes;
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
