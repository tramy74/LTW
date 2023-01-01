using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Globalization;
using System.Net.Http.Headers;

namespace Lab10_BTTL
{
    public partial class frmLab10_bttl : Form
    {
        SqlConnection connsql;
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da;
        DataTable dt = new DataTable();
        DataSet ds = new DataSet();
        public frmLab10_bttl()
        {
            InitializeComponent();
            connsql = new SqlConnection(@"Data Source = DESKTOP-UBEE6PG\TEAMEE27042003; Initial Catalog = QLSINHVIEN; Integrated Security = True");
        }
        private void frmLab10_bttl_Load(object sender, EventArgs e)
        {
            loadKhoa();
            LoadData();
        }

        //Load cac data
        void LoadData()
        {
            ds.Clear();
            if (connsql.State == ConnectionState.Closed)
                connsql.Open();
            string strselect = "SELECT SV.MASV, SV.HOTEN, SV.NGAYSINH, L.TENLOP FROM SINHVIEN AS SV, LOP AS L WHERE SV.MALOP = L.MALOP";
            da = new SqlDataAdapter(strselect, connsql);
            da.Fill(ds, "SINHVIEN");
            dgv.DataSource = ds.Tables["SINHVIEN"];
            DataColumn[] key = new DataColumn[1];
            key[0] = ds.Tables["SINHVIEN"].Columns[0];
            ds.Tables["SINHVIEN"].PrimaryKey = key;
            if (connsql.State == ConnectionState.Open)
                connsql.Close();
        }
        private void loadKhoa()
        {
            connsql.Open();
            string selectString = "SELECT * FROM KHOA";
            cmd = new SqlCommand(selectString, connsql);
            SqlDataReader rd = cmd.ExecuteReader();

            while (rd.Read())
                cbKhoa.Items.Add(rd["TENKHOA"].ToString());
            rd.Close();
            connsql.Close();
        }
        private void loadLop()
        {
            cbLop.Items.Clear();
            cbLop.Text = "";
            if (connsql.State == ConnectionState.Closed)
                connsql.Open();
            string selectString = @"SELECT LOP.* FROM LOP, KHOA WHERE LOP.MAKHOA = KHOA.MAKHOA AND KHOA.TENKHOA = N'" + cbKhoa.Text + "'";
            cmd = new SqlCommand(selectString, connsql);
            SqlDataReader rd = cmd.ExecuteReader();

            while (rd.Read())
                cbLop.Items.Add(rd["TENLOP"].ToString());
            rd.Close();
            if (connsql.State == ConnectionState.Open)
                connsql.Close();
        }
        void LoadSeletedDGV()
        {
            //if (connsql.State == ConnectionState.Closed)
            //{
            //    connsql.Open();
            //}
            //string strselect = "SELECT K.TENKHOA FROM SINHVIEN AS SV, LOP AS L, KHOA AS K WHERE SV.MALOP = L.MALOP AND K.MAKHOA = L.MAKHOA AND L.TENLOP LIKE '" + cbLop.Text + "' GROUP BY K.TENKHOA";
            //cmd = new SqlCommand(strselect, connsql);
            //cmd.ExecuteNonQuery();
            //cbKhoa.Text = cmd.ExecuteScalar().ToString();
            //if (connsql.State == ConnectionState.Open)
            //{
            //    connsql.Close();
            //}
            cbKhoa.DisplayMember = "MAKHOA";
            cbKhoa.ValueMember = "TENKHOA";
            cbKhoa.DataSource = ds.Tables["KHOA"];
            cbKhoa.Text = cbKhoa.ValueMember;
        }
        public string loadMaLop()
        {
            string result = "";
            if(cbLop.Text != "")
            {
                if (connsql.State == ConnectionState.Closed)
                    connsql.Open();
                string selectString = "SELECT MALOP FROM LOP WHERE TENLOP = '" + cbLop.Text + "'";
                cmd = new SqlCommand(selectString, connsql);
                result = cmd.ExecuteScalar().ToString();
            }
            else
            {
             
            }
            return result.Trim();
        }

       // Check MaSV From Diem
        public bool CheckMaSVFromDiem(string masv)
        {
            int count = 0;
            if (connsql.State == ConnectionState.Closed)
                connsql.Open();
            string selectString = "SELECT COUNT(MASV) FROM DIEM WHERE MASV LIKE '" + masv + "'";
            cmd = new SqlCommand(selectString, connsql);
            count = Convert.ToInt32(cmd.ExecuteScalar().ToString());
            if(connsql.State == ConnectionState.Open)
                connsql.Close();
            if (count > 0)
                return true;
            return false;
        }

        // Check MaSV From Lop
        //public bool CheckMaSVFromLop(string masv)
        //{
        //    bool result = false;
        //    string selectString = "SELECT SINHVIEN.MASV FROM LOP, SINHVIEN WHERE SINHVIEN.MALOP = LOP.MALOP";
        //    da = new SqlDataAdapter(selectString, connsql);
        //    da.Fill(ds, "LOP_MASV");
        //    for (int i = 0; i < ds.Tables["LOP_MASV"].Rows.Count; i++)
        //    {
        //        if (ds.Tables["LOP_MASV"].Rows[i].ToString() == masv)
        //        {
        //            result = true;
        //            break;
        //        }
        //    }
        //    return result;
        //}

        //Tranh nhap thu cong
        private void cbKhoa_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void cbLop_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void dgv_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void cbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbKhoa.SelectedItem != null)
            {
                loadLop();
            }
        }
        //Hien thi thong tin 
        // <-- no bi an o day ne !!!
        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if (i >= 0)
            {
                cbLop.Text = dgv.Rows[i].Cells[3].Value.ToString();
                LoadSeletedDGV();
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                txtMaSV.Text = dgv.Rows[i].Cells[0].Value.ToString();
                txtHoTen.Text = dgv.Rows[i].Cells[1].Value.ToString();
                string changDate = dgv.Rows[i].Cells[2].Value.ToString();
                var date = DateTime.Parse(changDate).ToString("yyyy/MM/dd");
                mtxtNgSinh.Text = date;

            }
        }

        void Reset()
        {
            cbKhoa.Text = "";
            cbLop.Text = "";
            txtMaSV.Text = "";
            txtHoTen.Text = "";
            mtxtNgSinh.Text = "";
        }
        int countBtnThem = 0;
        private void btnThem_Click(object sender, EventArgs e)
        {
            if(countBtnThem == 0)
            {
                Reset();
                txtHoTen.Enabled = true;
                txtMaSV.Enabled = true;
                btnLuu.Enabled = true;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                txtMaSV.Focus();
            }
            countBtnThem++;
            if(countBtnThem == 2)
            {
                Reset();
                txtHoTen.Enabled = false;
                txtMaSV.Enabled = false;
                btnLuu.Enabled = false;
                txtMaSV.Focus();
                countBtnThem = 0;
            }     
        }
        private void btnTim_Click(object sender, EventArgs e)
        {
            if (cbKhoa.Text != null)
            {
                if (cbLop.Text == "")
                {
                    try
                    {
                        ds.Clear();
                        connsql.Open();
                        string strselect = "SELECT SV.MASV, SV.HOTEN, SV.NGAYSINH, L.TENLOP FROM SINHVIEN AS SV, LOP AS L, KHOA AS K WHERE SV.MALOP = L.MALOP AND K.MAKHOA = L.MAKHOA AND K.TENKHOA LIKE N'" + cbKhoa.Text + "'";
                        da = new SqlDataAdapter(strselect, connsql);
                        da.Fill(ds, "SINHVIEN");
                        dgv.DataSource = ds.Tables["SINHVIEN"];
                        DataColumn[] key = new DataColumn[1];
                        key[0] = ds.Tables["SINHVIEN"].Columns[0];
                        ds.Tables["SINHVIEN"].PrimaryKey = key;
                        connsql.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        connsql.Close();
                    }
                }
                else
                {
                    try
                    {
                        ds.Clear();
                        connsql.Open();
                        string strselect = "SELECT SV.MASV, SV.HOTEN, SV.NGAYSINH, L.TENLOP FROM SINHVIEN AS SV, LOP AS L WHERE SV.MALOP = L.MALOP AND L.TENLOP LIKE '" + cbLop.Text + "'";
                        da = new SqlDataAdapter(strselect, connsql);
                        da.Fill(ds, "SINHVIEN");
                        dgv.DataSource = ds.Tables["SINHVIEN"];
                        DataColumn[] key = new DataColumn[1];
                        key[0] = ds.Tables["SINHVIEN"].Columns[0];
                        ds.Tables["SINHVIEN"].PrimaryKey = key;
                        connsql.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        connsql.Close();
                    }
                }
            }
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(txtMaSV.Enabled == true)
            {
                if (txtMaSV.Text == "")
                {
                    MessageBox.Show("Vui long nhap ma sinh vien");
                    txtMaSV.Focus();
                }
                if (txtHoTen.Text == "")
                {
                    MessageBox.Show("Vui long nhap ho ten");
                    txtHoTen.Focus();
                }
                if (mtxtNgSinh.Text == "")
                {
                    MessageBox.Show("Vui long nhap ngay sinh");
                    mtxtNgSinh.Focus();
                }
                if (cbKhoa.Text == "")
                {
                    MessageBox.Show("Vui long chon khoa");
                    cbKhoa.Focus();
                }
                if (cbLop.Text == "")
                {
                    MessageBox.Show("Vui long chon lop");
                    cbLop.Focus();
                }
                if(txtMaSV.Text != "" && txtHoTen.Text != "" && mtxtNgSinh.Text != "" && cbKhoa.Text != "" && cbLop.Text != "")
                {
                        try
                        {
                            if (connsql.State == ConnectionState.Closed)
                                connsql.Open();
                            string insertValue = $"INSERT INTO SINHVIEN VALUES ('{txtMaSV.Text}', N'{txtHoTen.Text}', '{mtxtNgSinh.Text}', '{loadMaLop()}' )";
                            cmd = new SqlCommand(insertValue, connsql);
                            cmd.ExecuteNonQuery();
                            LoadData();
                        MessageBox.Show("Them Thanh cong", "Thong bao");
                        btnLuu.Enabled = false;
                        Reset();
                        }
                        catch
                        {
                            MessageBox.Show("Ma sinh vien nay da ton tai!", "Thong bao");
                            txtMaSV.Clear();
                            txtMaSV.Focus();
                        }
                }
            }
            else
            {
                if (txtMaSV.Text == "")
                {
                    MessageBox.Show("Vui long nhap ma sinh vien");
                    txtMaSV.Focus();
                }
                if (txtHoTen.Text == "")
                {
                    MessageBox.Show("Vui long nhap ho ten");
                    txtHoTen.Focus();
                }
                if (mtxtNgSinh.Text == "")
                {
                    MessageBox.Show("Vui long nhap ngay sinh");
                    mtxtNgSinh.Focus();
                }
                if (cbKhoa.Text == "")
                {
                    MessageBox.Show("Vui long chon khoa");
                    cbKhoa.Focus();
                }
                if (cbLop.Text == "")
                {
                    MessageBox.Show("Vui long chon lop");
                    cbLop.Focus();
                }
                if (txtMaSV.Text != "" && txtHoTen.Text != "" && mtxtNgSinh.Text != "" && cbKhoa.Text != "" && cbLop.Text != "")
                {
                    try
                    {
                        if (connsql.State == ConnectionState.Closed)
                            connsql.Open();
                        string FixValue = $"UPDATE SINHVIEN SET HOTEN = N'{txtHoTen.Text}', NGAYSINH = '{mtxtNgSinh.Text}', MALOP = '{loadMaLop()}' WHERE MASV = '{txtMaSV.Text}'";
                        cmd = new SqlCommand(FixValue, connsql);
                        cmd.ExecuteNonQuery();
                        LoadData();
                        MessageBox.Show("Chinh sua thanh cong", "Thong bao");
                        btnLuu.Enabled = false;
                        Reset();
                    }
                    catch
                    {
                        MessageBox.Show("Loi ne!", "Thong bao");
                    }
                }
            }
        }
        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaSV.Text != "")
            {
                bool check = false;
                for (int i = 0; i < dgv.Rows.Count; i++)
                    if (dgv.Rows[i].Cells[0].ToString() == txtMaSV.Text)
                    {
                        check = true;
                        return;
                    }
                if(check == false)
                {
                    try
                    {
                        if(MessageBox.Show("Ban co muon xoa sinh vien nay","Thong bao",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            if (CheckMaSVFromDiem(txtMaSV.Text) == true)
                            {
                                MessageBox.Show("Du lieu dang su dung khong the xoa", "Thong bao");
                                btnXoa.Enabled = false;
                                btnSua.Enabled = false;
                                dgv.ClearSelection();
                                Reset();
                            }
                            else
                            {
                                    if (connsql.State == ConnectionState.Closed)
                                        connsql.Open();
                                    string insertValue = $"DELETE FROM SINHVIEN WHERE MASV LIKE '" + txtMaSV.Text + "'";
                                    cmd = new SqlCommand(insertValue, connsql);
                                    cmd.ExecuteNonQuery();
                                    LoadData();
                                    MessageBox.Show("Xoa thanh cong", "Thong bao");
                                btnXoa.Enabled = false;
                                btnSua.Enabled = false;
                                dgv.ClearSelection();
                                Reset();
                            }
                        }    
                    }
                    catch
                    {
                        MessageBox.Show("Vui long chon sinh vien can xoa!", "Thong bao");
                        txtMaSV.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Ma sinh vien nay khong ton tai!", "Thong bao");
                }
            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaSV.Text != "")
            {
                btnLuu.Enabled = true;
                txtMaSV.Enabled = false;
                txtHoTen.Enabled = true;
                mtxtNgSinh.Enabled = true;
            }
        }

        private void btnXemIn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("De bai khong yeu cau!", "Thong bao");
        }
    }
}
