namespace CafeSinhVien
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lblTenKhachHang = new System.Windows.Forms.Label();
            this.txtTenKhachHang = new System.Windows.Forms.TextBox();
            this.txtSoKhachHang = new System.Windows.Forms.TextBox();
            this.lblSoKhachHang = new System.Windows.Forms.Label();
            this.chkSinhVien = new System.Windows.Forms.CheckBox();
            this.grpNuocUong = new System.Windows.Forms.GroupBox();
            this.rdoCafeKem = new System.Windows.Forms.RadioButton();
            this.rdoCafeDa = new System.Windows.Forms.RadioButton();
            this.rdoCafeSuaDa = new System.Windows.Forms.RadioButton();
            this.rdoCafeSua = new System.Windows.Forms.RadioButton();
            this.rdoCafeDen = new System.Windows.Forms.RadioButton();
            this.grpThucAn = new System.Windows.Forms.GroupBox();
            this.chkMyCay = new System.Windows.Forms.CheckBox();
            this.chkMyXaoBo = new System.Windows.Forms.CheckBox();
            this.chkMyTomTrung = new System.Windows.Forms.CheckBox();
            this.chkBanhMyCa = new System.Windows.Forms.CheckBox();
            this.chkBanhMyTrung = new System.Windows.Forms.CheckBox();
            this.btnTinhTien = new System.Windows.Forms.Button();
            this.btnNhapLai = new System.Windows.Forms.Button();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.txtTongTienThanhToan = new System.Windows.Forms.TextBox();
            this.lblTongTienThanhToan = new System.Windows.Forms.Label();
            this.txtTongKhachHang = new System.Windows.Forms.TextBox();
            this.lblTongKhachHang = new System.Windows.Forms.Label();
            this.grpNuocUong.SuspendLayout();
            this.grpThucAn.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(324, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "CAFE SINH VIÊN";
            // 
            // lblTenKhachHang
            // 
            this.lblTenKhachHang.AutoSize = true;
            this.lblTenKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenKhachHang.Location = new System.Drawing.Point(162, 110);
            this.lblTenKhachHang.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTenKhachHang.Name = "lblTenKhachHang";
            this.lblTenKhachHang.Size = new System.Drawing.Size(141, 20);
            this.lblTenKhachHang.TabIndex = 1;
            this.lblTenKhachHang.Text = "Tên khách hàng";
            // 
            // txtTenKhachHang
            // 
            this.txtTenKhachHang.Location = new System.Drawing.Point(454, 110);
            this.txtTenKhachHang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTenKhachHang.Name = "txtTenKhachHang";
            this.txtTenKhachHang.Size = new System.Drawing.Size(392, 28);
            this.txtTenKhachHang.TabIndex = 2;
            this.txtTenKhachHang.TextChanged += new System.EventHandler(this.txtTenKhachHang_TextChanged);
            // 
            // txtSoKhachHang
            // 
            this.txtSoKhachHang.Location = new System.Drawing.Point(454, 161);
            this.txtSoKhachHang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSoKhachHang.Name = "txtSoKhachHang";
            this.txtSoKhachHang.Size = new System.Drawing.Size(392, 28);
            this.txtSoKhachHang.TabIndex = 4;
            this.txtSoKhachHang.TextChanged += new System.EventHandler(this.txtSoKhachHang_TextChanged);
            this.txtSoKhachHang.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoKhachHang_KeyPress);
            // 
            // lblSoKhachHang
            // 
            this.lblSoKhachHang.AutoSize = true;
            this.lblSoKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoKhachHang.Location = new System.Drawing.Point(162, 161);
            this.lblSoKhachHang.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSoKhachHang.Name = "lblSoKhachHang";
            this.lblSoKhachHang.Size = new System.Drawing.Size(132, 20);
            this.lblSoKhachHang.TabIndex = 3;
            this.lblSoKhachHang.Text = "Số khách hàng";
            // 
            // chkSinhVien
            // 
            this.chkSinhVien.AutoSize = true;
            this.chkSinhVien.Location = new System.Drawing.Point(454, 214);
            this.chkSinhVien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkSinhVien.Name = "chkSinhVien";
            this.chkSinhVien.Size = new System.Drawing.Size(111, 24);
            this.chkSinhVien.TabIndex = 5;
            this.chkSinhVien.Text = "Sinh viên ?";
            this.chkSinhVien.UseVisualStyleBackColor = true;
            // 
            // grpNuocUong
            // 
            this.grpNuocUong.Controls.Add(this.rdoCafeKem);
            this.grpNuocUong.Controls.Add(this.rdoCafeDa);
            this.grpNuocUong.Controls.Add(this.rdoCafeSuaDa);
            this.grpNuocUong.Controls.Add(this.rdoCafeSua);
            this.grpNuocUong.Controls.Add(this.rdoCafeDen);
            this.grpNuocUong.Location = new System.Drawing.Point(168, 246);
            this.grpNuocUong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpNuocUong.Name = "grpNuocUong";
            this.grpNuocUong.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpNuocUong.Size = new System.Drawing.Size(281, 141);
            this.grpNuocUong.TabIndex = 6;
            this.grpNuocUong.TabStop = false;
            this.grpNuocUong.Text = "Nước uống";
            // 
            // rdoCafeKem
            // 
            this.rdoCafeKem.AutoSize = true;
            this.rdoCafeKem.Location = new System.Drawing.Point(125, 66);
            this.rdoCafeKem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdoCafeKem.Name = "rdoCafeKem";
            this.rdoCafeKem.Size = new System.Drawing.Size(100, 24);
            this.rdoCafeKem.TabIndex = 4;
            this.rdoCafeKem.TabStop = true;
            this.rdoCafeKem.Text = "Cafe kem";
            this.rdoCafeKem.UseVisualStyleBackColor = true;
            this.rdoCafeKem.CheckedChanged += new System.EventHandler(this.rdoCafeKem_CheckedChanged);
            // 
            // rdoCafeDa
            // 
            this.rdoCafeDa.AutoSize = true;
            this.rdoCafeDa.Location = new System.Drawing.Point(125, 34);
            this.rdoCafeDa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdoCafeDa.Name = "rdoCafeDa";
            this.rdoCafeDa.Size = new System.Drawing.Size(86, 24);
            this.rdoCafeDa.TabIndex = 3;
            this.rdoCafeDa.TabStop = true;
            this.rdoCafeDa.Text = "Cafe đá";
            this.rdoCafeDa.UseVisualStyleBackColor = true;
            this.rdoCafeDa.CheckedChanged += new System.EventHandler(this.rdoCafeDa_CheckedChanged);
            // 
            // rdoCafeSuaDa
            // 
            this.rdoCafeSuaDa.AutoSize = true;
            this.rdoCafeSuaDa.Location = new System.Drawing.Point(4, 99);
            this.rdoCafeSuaDa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdoCafeSuaDa.Name = "rdoCafeSuaDa";
            this.rdoCafeSuaDa.Size = new System.Drawing.Size(116, 24);
            this.rdoCafeSuaDa.TabIndex = 2;
            this.rdoCafeSuaDa.TabStop = true;
            this.rdoCafeSuaDa.Text = "Cafe sữa đá";
            this.rdoCafeSuaDa.UseVisualStyleBackColor = true;
            this.rdoCafeSuaDa.CheckedChanged += new System.EventHandler(this.rdoCafeSuaDa_CheckedChanged);
            // 
            // rdoCafeSua
            // 
            this.rdoCafeSua.AutoSize = true;
            this.rdoCafeSua.Location = new System.Drawing.Point(4, 66);
            this.rdoCafeSua.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdoCafeSua.Name = "rdoCafeSua";
            this.rdoCafeSua.Size = new System.Drawing.Size(94, 24);
            this.rdoCafeSua.TabIndex = 1;
            this.rdoCafeSua.TabStop = true;
            this.rdoCafeSua.Text = "Cafe sữa";
            this.rdoCafeSua.UseVisualStyleBackColor = true;
            this.rdoCafeSua.CheckedChanged += new System.EventHandler(this.rdoCafeSua_CheckedChanged);
            // 
            // rdoCafeDen
            // 
            this.rdoCafeDen.AutoSize = true;
            this.rdoCafeDen.Location = new System.Drawing.Point(4, 34);
            this.rdoCafeDen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdoCafeDen.Name = "rdoCafeDen";
            this.rdoCafeDen.Size = new System.Drawing.Size(95, 24);
            this.rdoCafeDen.TabIndex = 0;
            this.rdoCafeDen.TabStop = true;
            this.rdoCafeDen.Text = "Cafe đen";
            this.rdoCafeDen.UseVisualStyleBackColor = true;
            this.rdoCafeDen.CheckedChanged += new System.EventHandler(this.rdoCafeDen_CheckedChanged);
            // 
            // grpThucAn
            // 
            this.grpThucAn.Controls.Add(this.chkMyCay);
            this.grpThucAn.Controls.Add(this.chkMyXaoBo);
            this.grpThucAn.Controls.Add(this.chkMyTomTrung);
            this.grpThucAn.Controls.Add(this.chkBanhMyCa);
            this.grpThucAn.Controls.Add(this.chkBanhMyTrung);
            this.grpThucAn.Location = new System.Drawing.Point(501, 246);
            this.grpThucAn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpThucAn.Name = "grpThucAn";
            this.grpThucAn.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpThucAn.Size = new System.Drawing.Size(345, 141);
            this.grpThucAn.TabIndex = 7;
            this.grpThucAn.TabStop = false;
            this.grpThucAn.Text = "Thức ăn";
            // 
            // chkMyCay
            // 
            this.chkMyCay.AutoSize = true;
            this.chkMyCay.Location = new System.Drawing.Point(156, 68);
            this.chkMyCay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkMyCay.Name = "chkMyCay";
            this.chkMyCay.Size = new System.Drawing.Size(86, 24);
            this.chkMyCay.TabIndex = 4;
            this.chkMyCay.Text = "Mỳ cay";
            this.chkMyCay.UseVisualStyleBackColor = true;
            // 
            // chkMyXaoBo
            // 
            this.chkMyXaoBo.AutoSize = true;
            this.chkMyXaoBo.Location = new System.Drawing.Point(156, 35);
            this.chkMyXaoBo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkMyXaoBo.Name = "chkMyXaoBo";
            this.chkMyXaoBo.Size = new System.Drawing.Size(109, 24);
            this.chkMyXaoBo.TabIndex = 3;
            this.chkMyXaoBo.Text = "Mỳ xào bò";
            this.chkMyXaoBo.UseVisualStyleBackColor = true;
            // 
            // chkMyTomTrung
            // 
            this.chkMyTomTrung.AutoSize = true;
            this.chkMyTomTrung.Location = new System.Drawing.Point(8, 99);
            this.chkMyTomTrung.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkMyTomTrung.Name = "chkMyTomTrung";
            this.chkMyTomTrung.Size = new System.Drawing.Size(132, 24);
            this.chkMyTomTrung.TabIndex = 2;
            this.chkMyTomTrung.Text = "Mỳ tôm trứng";
            this.chkMyTomTrung.UseVisualStyleBackColor = true;
            // 
            // chkBanhMyCa
            // 
            this.chkBanhMyCa.AutoSize = true;
            this.chkBanhMyCa.Location = new System.Drawing.Point(8, 66);
            this.chkBanhMyCa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkBanhMyCa.Name = "chkBanhMyCa";
            this.chkBanhMyCa.Size = new System.Drawing.Size(118, 24);
            this.chkBanhMyCa.TabIndex = 1;
            this.chkBanhMyCa.Text = "Bánh mỳ cá";
            this.chkBanhMyCa.UseVisualStyleBackColor = true;
            // 
            // chkBanhMyTrung
            // 
            this.chkBanhMyTrung.AutoSize = true;
            this.chkBanhMyTrung.Location = new System.Drawing.Point(8, 34);
            this.chkBanhMyTrung.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkBanhMyTrung.Name = "chkBanhMyTrung";
            this.chkBanhMyTrung.Size = new System.Drawing.Size(140, 24);
            this.chkBanhMyTrung.TabIndex = 0;
            this.chkBanhMyTrung.Text = "Bánh mỳ trứng";
            this.chkBanhMyTrung.UseVisualStyleBackColor = true;
            // 
            // btnTinhTien
            // 
            this.btnTinhTien.Enabled = false;
            this.btnTinhTien.Location = new System.Drawing.Point(202, 421);
            this.btnTinhTien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTinhTien.Name = "btnTinhTien";
            this.btnTinhTien.Size = new System.Drawing.Size(125, 51);
            this.btnTinhTien.TabIndex = 8;
            this.btnTinhTien.Text = "Tính tiền";
            this.btnTinhTien.UseVisualStyleBackColor = true;
            this.btnTinhTien.Click += new System.EventHandler(this.btnTinhTien_Click);
            // 
            // btnNhapLai
            // 
            this.btnNhapLai.Enabled = false;
            this.btnNhapLai.Location = new System.Drawing.Point(375, 421);
            this.btnNhapLai.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNhapLai.Name = "btnNhapLai";
            this.btnNhapLai.Size = new System.Drawing.Size(125, 51);
            this.btnNhapLai.TabIndex = 9;
            this.btnNhapLai.Text = "Nhập lại";
            this.btnNhapLai.UseVisualStyleBackColor = true;
            this.btnNhapLai.Click += new System.EventHandler(this.btnNhapLai_Click);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Enabled = false;
            this.btnThanhToan.Location = new System.Drawing.Point(532, 421);
            this.btnThanhToan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(125, 51);
            this.btnThanhToan.TabIndex = 10;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(720, 421);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(125, 51);
            this.btnThoat.TabIndex = 11;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // txtTongTienThanhToan
            // 
            this.txtTongTienThanhToan.Enabled = false;
            this.txtTongTienThanhToan.Location = new System.Drawing.Point(452, 544);
            this.txtTongTienThanhToan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTongTienThanhToan.Name = "txtTongTienThanhToan";
            this.txtTongTienThanhToan.Size = new System.Drawing.Size(392, 28);
            this.txtTongTienThanhToan.TabIndex = 15;
            // 
            // lblTongTienThanhToan
            // 
            this.lblTongTienThanhToan.AutoSize = true;
            this.lblTongTienThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTienThanhToan.Location = new System.Drawing.Point(162, 544);
            this.lblTongTienThanhToan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTongTienThanhToan.Name = "lblTongTienThanhToan";
            this.lblTongTienThanhToan.Size = new System.Drawing.Size(181, 20);
            this.lblTongTienThanhToan.TabIndex = 14;
            this.lblTongTienThanhToan.Text = "Tổng tiền thanh toán";
            // 
            // txtTongKhachHang
            // 
            this.txtTongKhachHang.Enabled = false;
            this.txtTongKhachHang.Location = new System.Drawing.Point(452, 492);
            this.txtTongKhachHang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTongKhachHang.Name = "txtTongKhachHang";
            this.txtTongKhachHang.Size = new System.Drawing.Size(392, 28);
            this.txtTongKhachHang.TabIndex = 13;
            // 
            // lblTongKhachHang
            // 
            this.lblTongKhachHang.AutoSize = true;
            this.lblTongKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongKhachHang.Location = new System.Drawing.Point(162, 492);
            this.lblTongKhachHang.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTongKhachHang.Name = "lblTongKhachHang";
            this.lblTongKhachHang.Size = new System.Drawing.Size(151, 20);
            this.lblTongKhachHang.TabIndex = 12;
            this.lblTongKhachHang.Text = "Tổng khách hàng";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 603);
            this.Controls.Add(this.txtTongTienThanhToan);
            this.Controls.Add(this.lblTongTienThanhToan);
            this.Controls.Add(this.txtTongKhachHang);
            this.Controls.Add(this.lblTongKhachHang);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.btnNhapLai);
            this.Controls.Add(this.btnTinhTien);
            this.Controls.Add(this.grpThucAn);
            this.Controls.Add(this.grpNuocUong);
            this.Controls.Add(this.chkSinhVien);
            this.Controls.Add(this.txtSoKhachHang);
            this.Controls.Add(this.lblSoKhachHang);
            this.Controls.Add(this.txtTenKhachHang);
            this.Controls.Add(this.lblTenKhachHang);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Cafe Sinh Viên";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.grpNuocUong.ResumeLayout(false);
            this.grpNuocUong.PerformLayout();
            this.grpThucAn.ResumeLayout(false);
            this.grpThucAn.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTenKhachHang;
        private System.Windows.Forms.TextBox txtTenKhachHang;
        private System.Windows.Forms.TextBox txtSoKhachHang;
        private System.Windows.Forms.Label lblSoKhachHang;
        private System.Windows.Forms.CheckBox chkSinhVien;
        private System.Windows.Forms.GroupBox grpNuocUong;
        private System.Windows.Forms.RadioButton rdoCafeKem;
        private System.Windows.Forms.RadioButton rdoCafeDa;
        private System.Windows.Forms.RadioButton rdoCafeSuaDa;
        private System.Windows.Forms.RadioButton rdoCafeSua;
        private System.Windows.Forms.RadioButton rdoCafeDen;
        private System.Windows.Forms.GroupBox grpThucAn;
        private System.Windows.Forms.CheckBox chkMyCay;
        private System.Windows.Forms.CheckBox chkMyXaoBo;
        private System.Windows.Forms.CheckBox chkMyTomTrung;
        private System.Windows.Forms.CheckBox chkBanhMyCa;
        private System.Windows.Forms.CheckBox chkBanhMyTrung;
        private System.Windows.Forms.Button btnTinhTien;
        private System.Windows.Forms.Button btnNhapLai;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.TextBox txtTongTienThanhToan;
        private System.Windows.Forms.Label lblTongTienThanhToan;
        private System.Windows.Forms.TextBox txtTongKhachHang;
        private System.Windows.Forms.Label lblTongKhachHang;
    }
}

