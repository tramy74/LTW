namespace Lab06_btvn_b2
{
    partial class Lab06_bttlb1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lab06_bttlb1));
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.lblMaSV = new System.Windows.Forms.Label();
            this.lblGT = new System.Windows.Forms.Label();
            this.rbtnNam = new System.Windows.Forms.RadioButton();
            this.rbtnNu = new System.Windows.Forms.RadioButton();
            this.lblLanguage = new System.Windows.Forms.Label();
            this.c_English = new System.Windows.Forms.CheckBox();
            this.c_French = new System.Windows.Forms.CheckBox();
            this.c_Hoa = new System.Windows.Forms.CheckBox();
            this.lblDanToc = new System.Windows.Forms.Label();
            this.cb_DanToc = new System.Windows.Forms.ComboBox();
            this.lsv_ThongTin = new System.Windows.Forms.ListView();
            this.col_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_MaSV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_GT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_Language = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_DanToc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(110, 76);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(103, 25);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Họ và Tên";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(274, 76);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(400, 30);
            this.txtName.TabIndex = 1;
            this.txtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtName_KeyPress);
            this.txtName.Leave += new System.EventHandler(this.txtName_Leave);
            // 
            // txtMaSV
            // 
            this.txtMaSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaSV.Location = new System.Drawing.Point(274, 145);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(400, 30);
            this.txtMaSV.TabIndex = 3;
            this.txtMaSV.Leave += new System.EventHandler(this.txtMaSV_Leave);
            // 
            // lblMaSV
            // 
            this.lblMaSV.AutoSize = true;
            this.lblMaSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaSV.Location = new System.Drawing.Point(110, 145);
            this.lblMaSV.Name = "lblMaSV";
            this.lblMaSV.Size = new System.Drawing.Size(122, 25);
            this.lblMaSV.TabIndex = 2;
            this.lblMaSV.Text = "Mã sinh viên";
            // 
            // lblGT
            // 
            this.lblGT.AutoSize = true;
            this.lblGT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGT.Location = new System.Drawing.Point(110, 207);
            this.lblGT.Name = "lblGT";
            this.lblGT.Size = new System.Drawing.Size(82, 25);
            this.lblGT.TabIndex = 4;
            this.lblGT.Text = "Giới tính";
            // 
            // rbtnNam
            // 
            this.rbtnNam.AutoSize = true;
            this.rbtnNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnNam.Location = new System.Drawing.Point(274, 212);
            this.rbtnNam.Name = "rbtnNam";
            this.rbtnNam.Size = new System.Drawing.Size(74, 29);
            this.rbtnNam.TabIndex = 5;
            this.rbtnNam.TabStop = true;
            this.rbtnNam.Text = "Nam";
            this.rbtnNam.UseVisualStyleBackColor = true;
            this.rbtnNam.Leave += new System.EventHandler(this.rbtnNam_Leave);
            // 
            // rbtnNu
            // 
            this.rbtnNu.AutoSize = true;
            this.rbtnNu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnNu.Location = new System.Drawing.Point(412, 212);
            this.rbtnNu.Name = "rbtnNu";
            this.rbtnNu.Size = new System.Drawing.Size(58, 29);
            this.rbtnNu.TabIndex = 6;
            this.rbtnNu.TabStop = true;
            this.rbtnNu.Text = "Nữ";
            this.rbtnNu.UseVisualStyleBackColor = true;
            this.rbtnNu.Leave += new System.EventHandler(this.rbtnNam_Leave);
            // 
            // lblLanguage
            // 
            this.lblLanguage.AutoSize = true;
            this.lblLanguage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLanguage.Location = new System.Drawing.Point(110, 276);
            this.lblLanguage.Name = "lblLanguage";
            this.lblLanguage.Size = new System.Drawing.Size(101, 25);
            this.lblLanguage.TabIndex = 7;
            this.lblLanguage.Text = "Ngoại ngữ";
            // 
            // c_English
            // 
            this.c_English.AutoSize = true;
            this.c_English.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c_English.Location = new System.Drawing.Point(274, 276);
            this.c_English.Name = "c_English";
            this.c_English.Size = new System.Drawing.Size(70, 29);
            this.c_English.TabIndex = 8;
            this.c_English.Text = "Anh";
            this.c_English.UseVisualStyleBackColor = true;
            // 
            // c_French
            // 
            this.c_French.AutoSize = true;
            this.c_French.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c_French.Location = new System.Drawing.Point(412, 276);
            this.c_French.Name = "c_French";
            this.c_French.Size = new System.Drawing.Size(80, 29);
            this.c_French.TabIndex = 9;
            this.c_French.Text = "Pháp";
            this.c_French.UseVisualStyleBackColor = true;
            // 
            // c_Hoa
            // 
            this.c_Hoa.AutoSize = true;
            this.c_Hoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c_Hoa.Location = new System.Drawing.Point(545, 276);
            this.c_Hoa.Name = "c_Hoa";
            this.c_Hoa.Size = new System.Drawing.Size(70, 29);
            this.c_Hoa.TabIndex = 10;
            this.c_Hoa.Text = "Hoa";
            this.c_Hoa.UseVisualStyleBackColor = true;
            // 
            // lblDanToc
            // 
            this.lblDanToc.AutoSize = true;
            this.lblDanToc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDanToc.Location = new System.Drawing.Point(110, 344);
            this.lblDanToc.Name = "lblDanToc";
            this.lblDanToc.Size = new System.Drawing.Size(79, 25);
            this.lblDanToc.TabIndex = 11;
            this.lblDanToc.Text = "Dân tộc";
            // 
            // cb_DanToc
            // 
            this.cb_DanToc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_DanToc.FormattingEnabled = true;
            this.cb_DanToc.Location = new System.Drawing.Point(274, 341);
            this.cb_DanToc.Name = "cb_DanToc";
            this.cb_DanToc.Size = new System.Drawing.Size(400, 33);
            this.cb_DanToc.TabIndex = 12;
            this.cb_DanToc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cb_DanToc_KeyPress_1);
            this.cb_DanToc.Leave += new System.EventHandler(this.cb_DanToc_Leave);
            // 
            // lsv_ThongTin
            // 
            this.lsv_ThongTin.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_Name,
            this.col_MaSV,
            this.col_GT,
            this.col_Language,
            this.col_DanToc});
            this.lsv_ThongTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsv_ThongTin.FullRowSelect = true;
            this.lsv_ThongTin.GridLines = true;
            this.lsv_ThongTin.HideSelection = false;
            this.lsv_ThongTin.Location = new System.Drawing.Point(52, 407);
            this.lsv_ThongTin.Name = "lsv_ThongTin";
            this.lsv_ThongTin.Size = new System.Drawing.Size(706, 189);
            this.lsv_ThongTin.TabIndex = 13;
            this.lsv_ThongTin.UseCompatibleStateImageBehavior = false;
            this.lsv_ThongTin.View = System.Windows.Forms.View.Details;
            this.lsv_ThongTin.SelectedIndexChanged += new System.EventHandler(this.lsv_ThongTin_SelectedIndexChanged);
            // 
            // col_Name
            // 
            this.col_Name.Text = "Họ tên";
            this.col_Name.Width = 165;
            // 
            // col_MaSV
            // 
            this.col_MaSV.Text = "Mã sinh viên";
            this.col_MaSV.Width = 161;
            // 
            // col_GT
            // 
            this.col_GT.Text = "Giới tính";
            // 
            // col_Language
            // 
            this.col_Language.Text = "Ngoại ngữ";
            this.col_Language.Width = 223;
            // 
            // col_DanToc
            // 
            this.col_DanToc.Text = "Dân tộc";
            this.col_DanToc.Width = 95;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(115, 618);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(117, 49);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(339, 618);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(121, 49);
            this.btnXoa.TabIndex = 15;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(572, 618);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(129, 49);
            this.btnSua.TabIndex = 16;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Lab06_bttlb1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 707);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lsv_ThongTin);
            this.Controls.Add(this.cb_DanToc);
            this.Controls.Add(this.lblDanToc);
            this.Controls.Add(this.c_Hoa);
            this.Controls.Add(this.c_French);
            this.Controls.Add(this.c_English);
            this.Controls.Add(this.lblLanguage);
            this.Controls.Add(this.rbtnNu);
            this.Controls.Add(this.rbtnNam);
            this.Controls.Add(this.lblGT);
            this.Controls.Add(this.txtMaSV);
            this.Controls.Add(this.lblMaSV);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Name = "Lab06_bttlb1";
            this.Text = "Bài 1";
            this.Load += new System.EventHandler(this.frmLab06_bttlb1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.Label lblMaSV;
        private System.Windows.Forms.Label lblGT;
        private System.Windows.Forms.RadioButton rbtnNam;
        private System.Windows.Forms.RadioButton rbtnNu;
        private System.Windows.Forms.Label lblLanguage;
        private System.Windows.Forms.CheckBox c_English;
        private System.Windows.Forms.CheckBox c_French;
        private System.Windows.Forms.CheckBox c_Hoa;
        private System.Windows.Forms.Label lblDanToc;
        private System.Windows.Forms.ComboBox cb_DanToc;
        private System.Windows.Forms.ListView lsv_ThongTin;
        private System.Windows.Forms.ColumnHeader col_Name;
        private System.Windows.Forms.ColumnHeader col_MaSV;
        private System.Windows.Forms.ColumnHeader col_GT;
        private System.Windows.Forms.ColumnHeader col_Language;
        private System.Windows.Forms.ColumnHeader col_DanToc;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}