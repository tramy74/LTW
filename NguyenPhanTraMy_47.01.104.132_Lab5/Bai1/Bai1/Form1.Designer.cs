namespace Bai1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboListSo = new System.Windows.Forms.ComboBox();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.txtNhapSo = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstUocSo = new System.Windows.Forms.ListBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnTongUoc = new System.Windows.Forms.Button();
            this.btnSoLuongUocChan = new System.Windows.Forms.Button();
            this.btnSoLuongUocNT = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboListSo);
            this.groupBox1.Controls.Add(this.btnCapNhat);
            this.groupBox1.Controls.Add(this.txtNhapSo);
            this.groupBox1.Location = new System.Drawing.Point(13, 23);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(325, 228);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập số";
            // 
            // cboListSo
            // 
            this.cboListSo.FormattingEnabled = true;
            this.cboListSo.Location = new System.Drawing.Point(8, 131);
            this.cboListSo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboListSo.Name = "cboListSo";
            this.cboListSo.Size = new System.Drawing.Size(279, 28);
            this.cboListSo.TabIndex = 2;
            this.cboListSo.SelectedIndexChanged += new System.EventHandler(this.cboListSo_SelectedIndexChanged);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(185, 38);
            this.btnCapNhat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(102, 52);
            this.btnCapNhat.TabIndex = 1;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // txtNhapSo
            // 
            this.txtNhapSo.Location = new System.Drawing.Point(8, 50);
            this.txtNhapSo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNhapSo.Name = "txtNhapSo";
            this.txtNhapSo.Size = new System.Drawing.Size(150, 28);
            this.txtNhapSo.TabIndex = 0;
            this.txtNhapSo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNhapSo_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstUocSo);
            this.groupBox2.Location = new System.Drawing.Point(463, 23);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(366, 200);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách ước số";
            // 
            // lstUocSo
            // 
            this.lstUocSo.FormattingEnabled = true;
            this.lstUocSo.ItemHeight = 20;
            this.lstUocSo.Location = new System.Drawing.Point(8, 46);
            this.lstUocSo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstUocSo.Name = "lstUocSo";
            this.lstUocSo.Size = new System.Drawing.Size(309, 84);
            this.lstUocSo.TabIndex = 0;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(236, 296);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(102, 52);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnTongUoc
            // 
            this.btnTongUoc.Location = new System.Drawing.Point(463, 296);
            this.btnTongUoc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTongUoc.Name = "btnTongUoc";
            this.btnTongUoc.Size = new System.Drawing.Size(366, 52);
            this.btnTongUoc.TabIndex = 4;
            this.btnTongUoc.Text = "Tổng các ước số";
            this.btnTongUoc.UseVisualStyleBackColor = true;
            this.btnTongUoc.Click += new System.EventHandler(this.btnTongUoc_Click);
            // 
            // btnSoLuongUocChan
            // 
            this.btnSoLuongUocChan.Location = new System.Drawing.Point(463, 395);
            this.btnSoLuongUocChan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSoLuongUocChan.Name = "btnSoLuongUocChan";
            this.btnSoLuongUocChan.Size = new System.Drawing.Size(366, 52);
            this.btnSoLuongUocChan.TabIndex = 4;
            this.btnSoLuongUocChan.Text = "Số lượng các ước số chẵn";
            this.btnSoLuongUocChan.UseVisualStyleBackColor = true;
            this.btnSoLuongUocChan.Click += new System.EventHandler(this.btnSoLuongUocChan_Click);
            // 
            // btnSoLuongUocNT
            // 
            this.btnSoLuongUocNT.Location = new System.Drawing.Point(463, 489);
            this.btnSoLuongUocNT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSoLuongUocNT.Name = "btnSoLuongUocNT";
            this.btnSoLuongUocNT.Size = new System.Drawing.Size(366, 52);
            this.btnSoLuongUocNT.TabIndex = 4;
            this.btnSoLuongUocNT.Text = "Số lượng các ước số nguyên tố";
            this.btnSoLuongUocNT.UseVisualStyleBackColor = true;
            this.btnSoLuongUocNT.Click += new System.EventHandler(this.btnSoLuongUocNT_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 611);
            this.Controls.Add(this.btnSoLuongUocNT);
            this.Controls.Add(this.btnSoLuongUocChan);
            this.Controls.Add(this.btnTongUoc);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Combo box";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboListSo;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.TextBox txtNhapSo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lstUocSo;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnTongUoc;
        private System.Windows.Forms.Button btnSoLuongUocChan;
        private System.Windows.Forms.Button btnSoLuongUocNT;
    }
}

