namespace Bai3
{
    partial class frmBai3
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
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoPhongDoi = new System.Windows.Forms.RadioButton();
            this.rdoPhongDon = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ckbThueXe = new System.Windows.Forms.CheckBox();
            this.ckbGiatUi = new System.Windows.Forms.CheckBox();
            this.cbkVIP = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.rdoVisa = new System.Windows.Forms.RadioButton();
            this.rdoTienMat = new System.Windows.Forms.RadioButton();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.txtSoNgayO = new System.Windows.Forms.TextBox();
            this.txtTienPhong = new System.Windows.Forms.TextBox();
            this.txtTienDichVu = new System.Windows.Forms.TextBox();
            this.txtGiamGia = new System.Windows.Forms.TextBox();
            this.btnTinhTien = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.txtTongtien = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(145, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ KHÁCH SẠN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ và tên khách hàng";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoPhongDoi);
            this.groupBox1.Controls.Add(this.rdoPhongDon);
            this.groupBox1.Location = new System.Drawing.Point(12, 93);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Loại phòng";
            // 
            // rdoPhongDoi
            // 
            this.rdoPhongDoi.AutoSize = true;
            this.rdoPhongDoi.Location = new System.Drawing.Point(5, 62);
            this.rdoPhongDoi.Name = "rdoPhongDoi";
            this.rdoPhongDoi.Size = new System.Drawing.Size(103, 24);
            this.rdoPhongDoi.TabIndex = 1;
            this.rdoPhongDoi.TabStop = true;
            this.rdoPhongDoi.Text = "Phòng đôi";
            this.rdoPhongDoi.UseVisualStyleBackColor = true;
            // 
            // rdoPhongDon
            // 
            this.rdoPhongDon.AutoSize = true;
            this.rdoPhongDon.Location = new System.Drawing.Point(5, 32);
            this.rdoPhongDon.Name = "rdoPhongDon";
            this.rdoPhongDon.Size = new System.Drawing.Size(109, 24);
            this.rdoPhongDon.TabIndex = 0;
            this.rdoPhongDon.TabStop = true;
            this.rdoPhongDon.Text = "Phòng đơn";
            this.rdoPhongDon.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ckbThueXe);
            this.groupBox2.Controls.Add(this.ckbGiatUi);
            this.groupBox2.Location = new System.Drawing.Point(264, 93);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "TH";
            // 
            // ckbThueXe
            // 
            this.ckbThueXe.AutoSize = true;
            this.ckbThueXe.Location = new System.Drawing.Point(13, 63);
            this.ckbThueXe.Name = "ckbThueXe";
            this.ckbThueXe.Size = new System.Drawing.Size(126, 24);
            this.ckbThueXe.TabIndex = 1;
            this.ckbThueXe.Text = "Thuê xe máy";
            this.ckbThueXe.UseVisualStyleBackColor = true;
            // 
            // ckbGiatUi
            // 
            this.ckbGiatUi.AutoSize = true;
            this.ckbGiatUi.Location = new System.Drawing.Point(13, 27);
            this.ckbGiatUi.Name = "ckbGiatUi";
            this.ckbGiatUi.Size = new System.Drawing.Size(79, 24);
            this.ckbGiatUi.TabIndex = 0;
            this.ckbGiatUi.Text = "Giặt ủi";
            this.ckbGiatUi.UseVisualStyleBackColor = true;
            // 
            // cbkVIP
            // 
            this.cbkVIP.AutoSize = true;
            this.cbkVIP.Location = new System.Drawing.Point(264, 201);
            this.cbkVIP.Name = "cbkVIP";
            this.cbkVIP.Size = new System.Drawing.Size(151, 24);
            this.cbkVIP.TabIndex = 4;
            this.cbkVIP.Text = "Khách hàng VIP";
            this.cbkVIP.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Số ngày ở";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(260, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tiền phòng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(400, 286);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Tiền dịch vụ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(562, 286);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Giảm giá";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 363);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(185, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "Tổng tiền khách phải trả";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 399);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(184, 20);
            this.label8.TabIndex = 10;
            this.label8.Text = "Phương thức thanh toán";
            // 
            // rdoVisa
            // 
            this.rdoVisa.AutoSize = true;
            this.rdoVisa.Location = new System.Drawing.Point(207, 397);
            this.rdoVisa.Name = "rdoVisa";
            this.rdoVisa.Size = new System.Drawing.Size(60, 24);
            this.rdoVisa.TabIndex = 11;
            this.rdoVisa.TabStop = true;
            this.rdoVisa.Text = "Visa";
            this.rdoVisa.UseVisualStyleBackColor = true;
            // 
            // rdoTienMat
            // 
            this.rdoTienMat.AutoSize = true;
            this.rdoTienMat.Location = new System.Drawing.Point(309, 395);
            this.rdoTienMat.Name = "rdoTienMat";
            this.rdoTienMat.Size = new System.Drawing.Size(94, 24);
            this.rdoTienMat.TabIndex = 12;
            this.rdoTienMat.TabStop = true;
            this.rdoTienMat.Text = "Tiền mặt";
            this.rdoTienMat.UseVisualStyleBackColor = true;
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(181, 47);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(283, 28);
            this.txtTenKH.TabIndex = 13;
            // 
            // txtSoNgayO
            // 
            this.txtSoNgayO.Location = new System.Drawing.Point(112, 197);
            this.txtSoNgayO.Name = "txtSoNgayO";
            this.txtSoNgayO.Size = new System.Drawing.Size(100, 28);
            this.txtSoNgayO.TabIndex = 14;
            this.txtSoNgayO.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // txtTienPhong
            // 
            this.txtTienPhong.Location = new System.Drawing.Point(264, 315);
            this.txtTienPhong.Name = "txtTienPhong";
            this.txtTienPhong.ReadOnly = true;
            this.txtTienPhong.Size = new System.Drawing.Size(100, 28);
            this.txtTienPhong.TabIndex = 15;
            // 
            // txtTienDichVu
            // 
            this.txtTienDichVu.Location = new System.Drawing.Point(404, 315);
            this.txtTienDichVu.Name = "txtTienDichVu";
            this.txtTienDichVu.Size = new System.Drawing.Size(100, 28);
            this.txtTienDichVu.TabIndex = 16;
            // 
            // txtGiamGia
            // 
            this.txtGiamGia.Location = new System.Drawing.Point(566, 315);
            this.txtGiamGia.Name = "txtGiamGia";
            this.txtGiamGia.Size = new System.Drawing.Size(100, 28);
            this.txtGiamGia.TabIndex = 18;
            // 
            // btnTinhTien
            // 
            this.btnTinhTien.Location = new System.Drawing.Point(157, 446);
            this.btnTinhTien.Name = "btnTinhTien";
            this.btnTinhTien.Size = new System.Drawing.Size(105, 28);
            this.btnTinhTien.TabIndex = 19;
            this.btnTinhTien.Text = "Tính tiền";
            this.btnTinhTien.UseVisualStyleBackColor = true;
            this.btnTinhTien.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(310, 446);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(105, 28);
            this.btnThoat.TabIndex = 20;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // txtTongtien
            // 
            this.txtTongtien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtTongtien.Location = new System.Drawing.Point(207, 355);
            this.txtTongtien.Name = "txtTongtien";
            this.txtTongtien.ReadOnly = true;
            this.txtTongtien.Size = new System.Drawing.Size(292, 28);
            this.txtTongtien.TabIndex = 21;
            // 
            // frmBai3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 638);
            this.Controls.Add(this.txtTongtien);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnTinhTien);
            this.Controls.Add(this.txtGiamGia);
            this.Controls.Add(this.txtTienDichVu);
            this.Controls.Add(this.txtTienPhong);
            this.Controls.Add(this.txtSoNgayO);
            this.Controls.Add(this.txtTenKH);
            this.Controls.Add(this.rdoTienMat);
            this.Controls.Add(this.rdoVisa);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbkVIP);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmBai3";
            this.Text = "To";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmBai3_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoPhongDoi;
        private System.Windows.Forms.RadioButton rdoPhongDon;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox ckbThueXe;
        private System.Windows.Forms.CheckBox ckbGiatUi;
        private System.Windows.Forms.CheckBox cbkVIP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton rdoVisa;
        private System.Windows.Forms.RadioButton rdoTienMat;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.TextBox txtSoNgayO;
        private System.Windows.Forms.TextBox txtTienPhong;
        private System.Windows.Forms.TextBox txtTienDichVu;
        private System.Windows.Forms.TextBox txtGiamGia;
        private System.Windows.Forms.Button btnTinhTien;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.TextBox txtTongtien;
    }
}

